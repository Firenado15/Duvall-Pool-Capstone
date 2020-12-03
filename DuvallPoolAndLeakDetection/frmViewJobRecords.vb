' View job Records form
' Last Updated: 12/1/2020
' Last modified by Matthew Estes

Public Class frmViewJobRecords


	' Close form
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close form
		Close()

	End Sub


	' Runs when form loads, loads in both combo boxes
	Private Sub frmViewJobRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try

			' Load names combo box
			LoadNamesCombobox()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try
	End Sub


	' Runs when form loads, loads in name combo box
	Private Sub LoadNamesCombobox()

		Try

			Dim strSelect As String = ""
			Dim cmdSelect As OleDb.OleDbCommand
			Dim drSourceTable As OleDb.OleDbDataReader
			Dim dt As DataTable = New DataTable

			'Delete data from boxes
			For Each cntrl As Control In Controls
				If TypeOf cntrl Is TextBox Then
					cntrl.Text = String.Empty
				End If
			Next

			'Open DB
			If OpenDatabaseConnectionSQLServer() = False Then

				'If DB could not open
				MessageBox.Show(Me, "Database connection error." & vbNewLine &
									"The application will now close.",
									Me.Text + " Error",
									MessageBoxButtons.OK, MessageBoxIcon.Error)
				Me.Close()

			End If

			cboName.BeginUpdate()

			'Create select
			strSelect = "SELECT * FROM vJobRecordCustomers ORDER BY FullName ASC"

			'Get records
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load Table
			dt.Load(drSourceTable)

			' Add items to combo box
			cboName.ValueMember = "intCustomerID"
			cboName.DisplayMember = "FullName"
			cboName.DataSource = dt

			' Select the first item in the list by default
			If cboName.Items.Count > 0 Then cboName.SelectedIndex = 0

			' Show changes
			cboName.EndUpdate()

			' Clean up
			drSourceTable.Close()

			' close the database connection
			CloseDatabaseConnection()

			' Load jobs combo box
		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try
	End Sub


	' Runs when name is changed
	Private Sub LoadJobsCombobox(intCustomerID As Integer)

		Try

			Dim strSelect As String = ""
			Dim cmdSelect As OleDb.OleDbCommand
			Dim drSourceTable As OleDb.OleDbDataReader
			Dim dt As DataTable = New DataTable

			'Delete data from boxes
			For Each cntrl As Control In Controls
				If TypeOf cntrl Is TextBox Then
					cntrl.Text = String.Empty
				End If
			Next

			'Open DB
			If OpenDatabaseConnectionSQLServer() = False Then

				'If DB could not open
				MessageBox.Show(Me, "Database connection error." & vbNewLine &
									"The application will now close.",
									Me.Text + " Error",
									MessageBoxButtons.OK, MessageBoxIcon.Error)
				Me.Close()

			End If

			cboJobNumber.BeginUpdate()

			'Create select
			strSelect = "SELECT * FROM vJobRecordNumber WHERE intCustomerID = " & intCustomerID & " ORDER BY intJobRecordID DESC"

			'Get records
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load Table
			dt.Load(drSourceTable)

			' Add items to combo box
			cboJobNumber.ValueMember = "intJobRecordID"
			cboJobNumber.DisplayMember = "strJobNumber"
			cboJobNumber.DataSource = dt

			' Select the first item in the list by default
			If cboJobNumber.Items.Count > 0 Then cboJobNumber.SelectedIndex = 0

			' Show changes
			cboJobNumber.EndUpdate()

			' Clean up
			drSourceTable.Close()

			' close the database connection
			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try
	End Sub


	' Update name
	Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged

		Dim strSelect As String = ""
		Dim strName As String = ""
		Dim cmdSelect As OleDb.OleDbCommand 'Select
		Dim drSourceTable As OleDb.OleDbDataReader 'retrieved data
		Dim dt As DataTable = New DataTable 'reader

		'open the database
		If OpenDatabaseConnectionSQLServer() = False Then


			' No connection error
			MessageBox.Show(Me, "Database connection error." & vbNewLine &
								"The application will now close.",
								Me.Text + " Error",
								MessageBoxButtons.OK, MessageBoxIcon.Error)

			'close the form
			Me.Close()

		End If

		'Select statement
		strSelect = "SELECT * FROM vCustomers WHERE intCustomerID = " & cboName.SelectedValue.ToString


		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'load the data table from the reader
		dt.Load(drSourceTable)

		'populate text boxes
		lblAddress.Text = dt.Rows(0).Item(3).ToString
		lblCity.Text = dt.Rows(0).Item(4).ToString
		lblState.Text = dt.Rows(0).Item(5).ToString
		lblZip.Text = dt.Rows(0).Item(6).ToString
		lblPhone.Text = dt.Rows(0).Item(7).ToString
		lblEmail.Text = dt.Rows(0).Item(8).ToString

		'close connection
		CloseDatabaseConnection()

		' Load jobs combo box
		LoadJobsCombobox(cboName.SelectedValue)
	End Sub


	' Click search for customer name
	Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnNameSearch.Click

		Try

			'initiante search
			ComboBoxNameSearch()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try
	End Sub


	' Search for customer name
	Private Sub cboName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboName.KeyPress

		'If keypress return
		Dim tb As ComboBox = CType(sender, ComboBox)
		If Char.IsControl(e.KeyChar) Then
			If e.KeyChar.Equals(Chr(Keys.Return)) Then

				Try

					'initiante search
					ComboBoxNameSearch()

				Catch ex As Exception

					'Unhandled Exception
					MessageBox.Show(ex.Message)

				End Try

			End If
		End If

	End Sub


	' Combo search
	Private Sub ComboBoxNameSearch()

		Dim strSelect As String = ""
		Dim cmdSelect As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim dt As DataTable = New DataTable

		'Delete data from boxes
		For Each cntrl As Control In Controls
			If TypeOf cntrl Is TextBox Then
				cntrl.Text = String.Empty
			End If
		Next

		'Open DB
		If OpenDatabaseConnectionSQLServer() = False Then

			'If DB could not open
			MessageBox.Show(Me, "Database connection error." & vbNewLine &
								"The application will now close.",
								Me.Text + " Error",
								MessageBoxButtons.OK, MessageBoxIcon.Error)
			Me.Close()

		End If

		cboName.BeginUpdate()

		'Create select
		strSelect = "SELECT * FROM  vJobRecordsSearch WHERE ( strLastName + ', ' + strFirstName ) LIKE '%" & cboName.Text &
			"%' OR (strFirstName + ' ' + strLastName) like '%" & cboName.Text & "%' ORDER BY strLastName ASC"

		'Get records
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'Load Table
		dt.Load(drSourceTable)

		' Add items to combo box
		cboName.ValueMember = "intCustomerID"
		cboName.DisplayMember = "FullName"
		cboName.DataSource = dt

		' Select the first item in the list by default
		If cboName.Items.Count > 0 Then cboName.SelectedIndex = 0

		' Show changes
		cboName.EndUpdate()

		' Clean up
		drSourceTable.Close()

		' close the database connection
		CloseDatabaseConnection()

	End Sub


	' Update name
	Private Sub cboJobNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJobNumber.SelectedIndexChanged

		Dim strSelect As String = ""
		Dim strName As String = ""
		Dim intStatus As Integer = 0
		Dim cmdSelect As OleDb.OleDbCommand 'Select
		Dim drSourceTable As OleDb.OleDbDataReader 'retrieved data
		Dim dt As DataTable = New DataTable 'reader

		'open the database
		If OpenDatabaseConnectionSQLServer() = False Then


			' No connection error
			MessageBox.Show(Me, "Database connection error." & vbNewLine &
								"The application will now close.",
								Me.Text + " Error",
								MessageBoxButtons.OK, MessageBoxIcon.Error)

			'close the form
			Me.Close()

		End If

		'Select statement
		strSelect = "SELECT * FROM vJobRecords WHERE intJobRecordID = " & cboJobNumber.SelectedValue.ToString


		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'load the data table from the reader
		dt.Load(drSourceTable)

		'populate text boxes
		lblStartDate.Text = dt.Rows(0).Item(2).ToString
		lblEndDate.Text = dt.Rows(0).Item(3).ToString
		lblNumberOfEmployees.Text = dt.Rows(0).Item(4).ToString
		lblEmployeeNames.Text = dt.Rows(0).Item(5).ToString
		lblDescription.Text = dt.Rows(0).Item(6).ToString
		intStatus = dt.Rows(0).Item(7)

		If intStatus = 1 Then

			radScheduled.Checked = True

		ElseIf intStatus = 2 Then

			radInProgress.Checked = True

		ElseIf intStatus = 3 Then

			radCompleted.Checked = True

		End If


		'close connection
		CloseDatabaseConnection()

	End Sub



	' Load new page to update records
	Private Sub btnEditJobRecord_Click(sender As Object, e As EventArgs) Handles btnEditJobRecord.Click

		' create a new instance of the edit job records form
		Dim EditJobRecords As New frmEditJobRecords

		' show the new form so any past data is not still on the form
		EditJobRecords.ShowDialog()

		'Reload job records info after update
		cboName_SelectedIndexChanged(sender, e)

	End Sub
End Class
