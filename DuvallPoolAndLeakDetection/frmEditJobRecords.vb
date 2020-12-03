' View job Records form
' Last Updated: 12/1/2020
' Last modified by Matthew Estes


Public Class frmEditJobRecords

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
		txtStartDate.Text = dt.Rows(0).Item(2).ToString
		txtEndDate.Text = dt.Rows(0).Item(3).ToString
		txtNumberEmployees.Text = dt.Rows(0).Item(4).ToString
		txtEmployeeNames.Text = dt.Rows(0).Item(5).ToString
		txtJobDescription.Text = dt.Rows(0).Item(6).ToString
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



	' Update job record
	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		' Declare Variables
		Dim strupdate As String = ""
		Dim strStartDate As String = ""
		Dim strEndDate As String = ""
		Dim intNumberEmployees As Integer = 0
		Dim strEmployeeNames As String = ""
		Dim strJobDescription As String = ""
		Dim strJobNumber As String = ""
		Dim intStatusID As Integer = 0
		Dim cmdUpdate As OleDb.OleDbCommand
		Dim intRowsAffected As Integer


		Try

			If Validation() = True Then

				' Set values
				strStartDate = txtStartDate.Text
				strEndDate = txtEndDate.Text
				intNumberEmployees = txtNumberEmployees.Text
				strEmployeeNames = txtEmployeeNames.Text
				strJobDescription = txtJobDescription.Text

				' Set status ID
				If radScheduled.Checked Then

					intStatusID = 1
				ElseIf radInProgress.Checked Then

					intStatusID = 2
				ElseIf radCompleted.Checked Then

					intStatusID = 3
				End If

				' Open database connection
				If OpenDatabaseConnectionSQLServer() = False Then

					'Alert if no connection
					MessageBox.Show(Me, "Database connection error." & vbNewLine &
										"The application will now close.",
										Me.Text + " Error",
										MessageBoxButtons.OK, MessageBoxIcon.Error)

					'Close Form
					Me.Close()

				End If

				'Create update statement
				strupdate = "UPDATE TJobRecords " &
					"SET dtStartDate = '" & strStartDate & "', " &
						"dtEndDate = '" & strEndDate & "', " &
						"intEmployees = " & intNumberEmployees & ", " &
						"strEmployeeNames = '" & strEmployeeNames & "', " &
						"strJobDesc = '" & strJobDescription & "', " &
						"intStatusID = " & intStatusID &
					" WHERE intJobRecordID = " & cboJobNumber.SelectedValue

				cmdUpdate = New OleDb.OleDbCommand(strupdate, m_conAdministrator)

				intRowsAffected = cmdUpdate.ExecuteNonQuery()

				If intRowsAffected > 0 Then
					MessageBox.Show("Job record has been updated.")
					Me.Close()
				End If

				CloseDatabaseConnection()

			End If

		Catch ex As Exception
			'unhandled exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub



	' Validation
	Function Validation() As Boolean

		' Declare variables
		Dim intEmployees As Integer = 0
		Dim intEmployeeNames As Integer = 0

		' Reset backcolor
		txtStartDate.BackColor = Color.White
		txtEndDate.BackColor = Color.White
		txtNumberEmployees.BackColor = Color.White
		txtEmployeeNames.BackColor = Color.White
		txtJobDescription.BackColor = Color.White

		' check if something is entered in date started text box
		If txtStartDate.Text <> String.Empty And IsDate(txtStartDate.Text) Then

		Else
			' text box is blank so tell user to enter date started, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter start date.")
			txtStartDate.BackColor = Color.Yellow
			txtStartDate.Focus()
			Return False
		End If

		' check if something is entered in date ended text box
		If txtEndDate.Text <> String.Empty And IsDate(txtEndDate.Text) Then

		Else
			' text box is blank so tell user to enter date ended, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter end date.")
			txtEndDate.BackColor = Color.Yellow
			txtEndDate.Focus()
			Return False
		End If

		' check if something is entered in number of employees text box
		If txtNumberEmployees.Text <> String.Empty And IsNumeric(txtNumberEmployees.Text) Then
			intEmployees = txtNumberEmployees.Text
		Else
			' text box is blank so tell user to enter number of employees, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter number of employees.")
			txtNumberEmployees.BackColor = Color.Yellow
			txtNumberEmployees.Focus()
			Return False
		End If

		' check if something is entered in employee names text box
		If txtEmployeeNames.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter employee names, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter employee names.")
			txtEmployeeNames.BackColor = Color.Yellow
			txtEmployeeNames.Focus()
			Return False
		End If

		' Check if there is the correct number of employees entered
		intEmployeeNames = CountEmployees(txtEmployeeNames.Text)
		If intEmployeeNames <> intEmployees Then

			' Tell user to enter correct amount of names
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter employee names. Format is First Last, First Last, First Last, ...")
			txtEmployeeNames.BackColor = Color.Yellow
			txtEmployeeNames.Focus()
			Return False
		End If

		' check if something is entered in description text box
		If txtJobDescription.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter description, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter job description.")
			txtJobDescription.BackColor = Color.Yellow
			txtJobDescription.Focus()
			Return False
		End If


		' Check if a radio button is chosen
		If radCompleted.Checked = False And radInProgress.Checked = False And radScheduled.Checked = False Then
			' Tell user to selct a radio button
			MessageBox.Show("Please select a radio button.")
			Return False
		End If

		Return True ' all is well in the world

	End Function



	' Count Employees
	Function CountEmployees(strEmployeeNames As String) As Integer

		' Declare variables
		Dim intEmployeeNames As Integer = 0
		Dim intLength As Integer = 0
		Dim intIndex As Integer = 0
		Dim intCount As Integer = 0

		' Get length of string
		intLength = strEmployeeNames.Length

		' Loop to find all strings
		Do
			' Look for first user
			If intCount = 0 And strEmployeeNames.Chars(intIndex) <> "," And strEmployeeNames.Chars(intIndex) <> " " Then

				' Count first person
				intEmployeeNames += 1
				intCount = 1

			ElseIf strEmployeeNames.Chars(intIndex) = "," And intCount = 1 Then

				' Increase count
				intCount = 2

			ElseIf intCount = 2 And strEmployeeNames.Chars(intIndex) <> "," And strEmployeeNames.Chars(intIndex) <> " " Then

				' Add one to employee name count
				intEmployeeNames += 1

				' Reset count
				intCount = 1
			End If

			' Increase index
			intIndex += 1
		Loop While intIndex < intLength

		Return intEmployeeNames
	End Function
End Class