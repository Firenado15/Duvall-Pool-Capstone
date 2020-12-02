Public Class frmAddJobRecords

	' Close form
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close form
		Close()
	End Sub


	' Runs when form load, populates name combo box
	Private Sub frmAddJobRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
			strSelect = "SELECT intCustomerID, ( strLastName + ', ' + strFirstName ) AS FullName FROM TCustomers ORDER BY FullName ASC"

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

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try
	End Sub


	' Validation
	Function Validation() As Boolean

		txtJobNumber.BackColor = Color.White
		txtStartDate.BackColor = Color.White
		txtEndDate.BackColor = Color.White
		txtNumberEmployees.BackColor = Color.White
		txtEmployeeNames.BackColor = Color.White
		txtJobDescription.BackColor = Color.White

		' check if something is entered in Job Number  text box
		If txtJobNumber.Text <> String.Empty And IsNumeric(txtJobNumber.Text) Then

		Else
			' text box is blank so tell user to enter job number, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter job number.")
			txtJobNumber.BackColor = Color.Yellow
			txtJobNumber.Focus()
			Return False
		End If

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

		' Check if check box is chosen
		If chkCustomer.Checked = False Then

			' Tell user to selct a radio button
			MessageBox.Show("Please verify this is the right customer.")
			Return False
		End If

		Return True ' all is well in the world

	End Function


	' Attempts to enter information into database
	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		If Validation() = True Then

			MessageBox.Show("Validate works")

		End If

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
	End Sub


	' Click search for customer name
	Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

		Try

			'initiante search
			ComboBoxSearch()

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
					ComboBoxSearch()

				Catch ex As Exception

					'Unhandled Exception
					MessageBox.Show(ex.Message)

				End Try

			End If
		End If

	End Sub


	' Combo search
	Private Sub ComboBoxSearch()

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
		strSelect = "SELECT intCustomerID, ( strLastName + ', ' + strFirstName ) AS FullName FROM TCustomers WHERE ( strLastName + ', ' + strFirstName ) LIKE '%" & cboName.Text &
			"%' OR (strFirstName + ' ' + strLastName) like '%" & cboName.Text & "%' ORDER BY FullName ASC"

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

End Class