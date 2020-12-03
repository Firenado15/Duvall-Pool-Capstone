' Invoicing form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmInvoicing

	Dim intInvoiceNumber As Integer
	Dim blnFirstService As Boolean = True

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close program
		Close()

	End Sub

	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		Try

			Validation()

			InsertInvoice()

			InsertJobServices()



		Catch ex As Exception
			'unhandled exception
			MessageBox.Show(ex.Message)
		End Try

	End Sub

	Function Validation() As Boolean


		'txtDateStarted.BackColor = Color.White
		'      txtDateEnded.BackColor = Color.White
		'      txtClosing.BackColor = Color.White
		'      txtOpening.BackColor = Color.White
		'txtDueDate.BackColor = Color.White

		'' check if something is entered in date started text box
		'If txtDateStarted.Text <> String.Empty Then

		'      Else
		'          ' text box is blank so tell user to enter date started, change back color to yellow,
		'          ' put focus in text box and return false we don't want to continue
		'          MessageBox.Show("Please enter date started.")
		'          txtDateStarted.BackColor = Color.Yellow
		'          txtDateStarted.Focus()
		'          Return False
		'      End If

		'      ' check if something is entered in date ended text box
		'      If txtDateEnded.Text <> String.Empty Then

		'      Else
		'          ' text box is blank so tell user to enter date ended, change back color to yellow,
		'          ' put focus in text box and return false we don't want to continue
		'          MessageBox.Show("Please enter date ended.")
		'          txtDateEnded.BackColor = Color.Yellow
		'          txtDateEnded.Focus()
		'          Return False
		'      End If

		'      ' check if something is entered in closing date text box
		'      If txtClosing.Text <> String.Empty Then

		'      Else
		'          ' text box is blank so tell user to enter closing date, change back color to yellow,
		'          ' put focus in text box and return false we don't want to continue
		'          MessageBox.Show("Please enter closing date.")
		'          txtClosing.BackColor = Color.Yellow
		'          txtClosing.Focus()
		'          Return False
		'      End If

		'      ' check if something is entered in opening date text box
		'      If txtOpening.Text <> String.Empty Then

		'      Else
		'          ' text box is blank so tell user to enter opening date, change back color to yellow,
		'          ' put focus in text box and return false we don't want to continue
		'          MessageBox.Show("Please enter opening date.")
		'          txtOpening.BackColor = Color.Yellow
		'          txtOpening.Focus()
		'          Return False
		'      End If

		'      ' check if something is entered in due date text box
		'      If txtDueDate.Text <> String.Empty Then

		'      Else
		'          ' text box is blank so tell user to enter due date, change back color to yellow,
		'          ' put focus in text box and return false we don't want to continue
		'          MessageBox.Show("Please enter due date of invoice.")
		'          txtDueDate.BackColor = Color.Yellow
		'          txtDueDate.Focus()
		'          Return False
		'      End If

		Return True ' all is well in the world

	End Function

	Private Sub frmInvoicing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

			cboCustomer.BeginUpdate()

			'Create select
			strSelect = "SELECT intCustomerID, ( strLastName + ', ' + strFirstName ) AS FullName FROM TCustomers ORDER BY FullName ASC"

			'Get records
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load Table
			dt.Load(drSourceTable)

			' Add items to combo box
			cboCustomer.ValueMember = "intCustomerID"
			cboCustomer.DisplayMember = "FullName"
			cboCustomer.DataSource = dt

			' Select the first item in the list by default
			If cboCustomer.Items.Count > 0 Then cboCustomer.SelectedIndex = 0

			' Show changes
			cboCustomer.EndUpdate()

			' Clean up
			drSourceTable.Close()

			' close the database connection
			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub cboCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustomer.SelectedIndexChanged

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

			cboJob.BeginUpdate()

			'Create select
			strSelect = "SELECT intJobRecordID, JobNumber FROM TJobRecords WHERE intCustomerID = " & cboCustomer.SelectedValue

			'Get records
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load Table
			dt.Load(drSourceTable)

			' Add items to combo box
			cboJob.ValueMember = "intJobRecordID"
			cboJob.DisplayMember = "JobNumber"
			cboJob.DataSource = dt

			' Select the first item in the list by default
			If cboJob.Items.Count > 0 Then cboJob.SelectedIndex = 0

			' Show changes
			cboJob.EndUpdate()

			' Clean up
			drSourceTable.Close()

			' close the database connection
			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub cboJob_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJob.SelectedIndexChanged

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
		strSelect = "SELECT strJobDesc FROM TJobRecords WHERE intJobRecordID = " & cboJob.SelectedValue.ToString


		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'load the data table from the reader
		dt.Load(drSourceTable)

		'populate text boxes
		lblJobDesc.Text = dt.Rows(0).Item(0).ToString

		'close connection
		CloseDatabaseConnection()

	End Sub

	Private Sub InsertInvoice()

		'Variables
		Dim strSelect As String = ""
		Dim strInsert As String = ""
		Dim strDate As String = ""
		Dim cmdSelect As OleDb.OleDbCommand
		Dim cmdInsert As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim intNextHighestRecordID As Integer
		Dim intRowsAffected As Integer

		If Validation() = True Then

			If OpenDatabaseConnectionSQLServer() = False Then

				'Alert if no connection
				MessageBox.Show(Me, "Database connection error." & vbNewLine &
									"The application will now close.",
									Me.Text + " Error",
									MessageBoxButtons.OK, MessageBoxIcon.Error)

				'Close Form
				Me.Close()

			End If

			strSelect = "SELECT MAX(intInvoiceID) + 1 AS intNextHighestRecordID FROM TInvoices"

			'Execute
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Read
			drSourceTable.Read()

			'Check for empty table
			If drSourceTable.IsDBNull(0) = True Then

				'Start at 1 for empty table
				intNextHighestRecordID = 1

			Else

				'Not empty, add 1
				intNextHighestRecordID = CInt(drSourceTable.Item(0))

			End If

			strDate = dtInvoiceDueDate.Value.Date.ToString()

			'Create insert statement
			strInsert = "Insert into TInvoices VALUES (" & intNextHighestRecordID &
				", " & cboCustomer.SelectedValue &
				", " & cboJob.SelectedValue &
				", '" & strDate & "')"


			cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

			intRowsAffected = cmdInsert.ExecuteNonQuery()

			If intRowsAffected > 0 Then
				MessageBox.Show("Invoice has been added")
				Me.Close()
			End If

			intInvoiceNumber = intNextHighestRecordID

			CloseDatabaseConnection()

		End If

	End Sub

	Private Sub InsertJobServices()

		'Variables
		Dim strSelect As String
		Dim strInsert As String
		Dim cmdSelect As OleDb.OleDbCommand
		Dim cmdInsert As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim intNextHighestRecordID As Integer
		Dim intRowsAffected As Integer

		blnFirstService = True

		If OpenDatabaseConnectionSQLServer() = False Then

			'Alert if no connection
			MessageBox.Show(Me, "Database connection error." & vbNewLine &
										"The application will now close.",
										Me.Text + " Error",
										MessageBoxButtons.OK, MessageBoxIcon.Error)

			'Close Form
			Me.Close()

		End If

		strSelect = "SELECT MAX(intJobServiceID) + 1 AS intNextHighestRecordID FROM TJobServices"

		'Execute
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'Read
		drSourceTable.Read()

		'Check for empty table
		If drSourceTable.IsDBNull(0) = True Then

			'Start at 1 for empty table
			intNextHighestRecordID = 1

		Else

			'Not empty, add 1
			intNextHighestRecordID = CInt(drSourceTable.Item(0))

		End If

		'Create insert statement
		strInsert = "Insert into TJobServices VALUES"

		'Check Each check box for selection
		If chkInstallation.Checked = True Then

			strInsert = strInsert & " (" & intNextHighestRecordID & ", 1, " & cboJob.SelectedValue & ", " & intInvoiceNumber & ")"
			intNextHighestRecordID += 1
			blnFirstService = False

		End If
		If chkTesting.Checked = True Then

			If blnFirstService = False Then
				strInsert = strInsert & ","
			End If
			strInsert = strInsert & " (" & intNextHighestRecordID & ", 2, " & cboJob.SelectedValue & ", " & intInvoiceNumber & ")"
			intNextHighestRecordID += 1
			blnFirstService = False

		End If
		If chkDetection.Checked = True Then

			If blnFirstService = False Then
				strInsert = strInsert & ","

			End If
			strInsert = strInsert & " (" & intNextHighestRecordID & ", 3, " & cboJob.SelectedValue & ", " & intInvoiceNumber & ")"
			intNextHighestRecordID += 1
			blnFirstService = False

		End If
		If chkVacuumed.Checked = True Then

			If blnFirstService = False Then
				strInsert = strInsert & ","

			End If
			strInsert = strInsert & " (" & intNextHighestRecordID & ", 4, " & cboJob.SelectedValue & ", " & intInvoiceNumber & ")"
			intNextHighestRecordID += 1
			blnFirstService = False

		End If
		If chkSkimmed.Checked = True Then

			If blnFirstService = False Then
				strInsert = strInsert & ","

			End If
			strInsert = strInsert & " (" & intNextHighestRecordID & ", 5, " & cboJob.SelectedValue & ", " & intInvoiceNumber & ")"
			intNextHighestRecordID += 1
			blnFirstService = False

		End If
		If chkChemicals.Checked = True Then

			If blnFirstService = False Then
				strInsert = strInsert & ","

			End If
			strInsert = strInsert & " (" & intNextHighestRecordID & ", 6, " & cboJob.SelectedValue & ", " & intInvoiceNumber & ")"
			intNextHighestRecordID += 1
			blnFirstService = False

		End If
		If chkFilter.Checked = True Then

			If blnFirstService = False Then
				strInsert = strInsert & ","

			End If
			strInsert = strInsert & " (" & intNextHighestRecordID & ", 7, " & cboJob.SelectedValue & ", " & intInvoiceNumber & ")"
			intNextHighestRecordID += 1

		End If

		cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

		intRowsAffected = cmdInsert.ExecuteNonQuery()

		If intRowsAffected > 0 Then
			MessageBox.Show("Job Services have been added")
			Me.Close()
		End If

		CloseDatabaseConnection()

	End Sub
End Class
