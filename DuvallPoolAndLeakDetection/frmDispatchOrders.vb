' Dispatch Orders form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmDispatchOrders

	Private Sub frmDispatchOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try

			' Load names combo box
			ComboBoxNameSearch()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub


	Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged

		Try

			LoadJobList()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub ComboBoxNameSearch()

		Dim strSelect As String = ""
		Dim cmdSelect As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim dt As DataTable = New DataTable

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

	Private Sub LoadJobList()

		Dim strSelect As String = ""
		Dim cmdSelect As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim dt As DataTable = New DataTable

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
		strSelect = "SELECT intJobRecordID, JobNumber FROM TJobRecords WHERE intCustomerID = " & cboName.SelectedValue

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

	End Sub

	Private Sub cboJob_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJob.SelectedIndexChanged

		Dim strSelect As String = ""
		Dim cmdSelect As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim dt As DataTable = New DataTable

		lstAvailable.ResetText()
		lstAssigned.ResetText()

		'Open DB
		If OpenDatabaseConnectionSQLServer() = False Then

			'No Connection
			MessageBox.Show(Me, "Database connection error." & vbNewLine &
								"The application will now close.",
								Me.Text + " Error",
								MessageBoxButtons.OK, MessageBoxIcon.Error)

			'Close Form
			Me.Close()

		End If

		lstAvailable.BeginUpdate()

		'Create Select
		strSelect = "SELECT intEmployeeID, (strFirstName + ' ' + strLastName) AS FullName FROM TEmployees WHERE intEmployeeID NOT IN (SELECT intEmployeeID FROM TJobEmployees WHERE intJobRecordID = " & cboJob.SelectedValue.ToString & ")"

		'Retrieve Records
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'Load Data
		dt.Load(drSourceTable)

		lstAvailable.ValueMember = "intEmployeeID"
		lstAvailable.DisplayMember = "FullName"
		lstAvailable.DataSource = dt

		'Select First Item
		If lstAvailable.Items.Count > 0 Then lstAvailable.SelectedIndex = 0

		'Show Changes
		lstAvailable.EndUpdate()

		LoadAssigned()

		' Clean up
		drSourceTable.Close()

		'Close DB
		CloseDatabaseConnection()

	End Sub

	Private Sub LoadAssigned()
		Dim strSelect As String = ""
		Dim cmdSelect As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim dt As DataTable = New DataTable

		'lstAvailable.ResetText()
		lstAssigned.ResetText()

		'Open DB
		If OpenDatabaseConnectionSQLServer() = False Then

			'No Connection
			MessageBox.Show(Me, "Database connection error." & vbNewLine &
									"The application will now close.",
									Me.Text + " Error",
									MessageBoxButtons.OK, MessageBoxIcon.Error)

			'Close Form
			Me.Close()

		End If

		lstAssigned.BeginUpdate()

		'Create Select
		strSelect = "SELECT intEmployeeID, (strFirstName + ' ' + strLastName) AS FullName FROM TEmployees WHERE intEmployeeID IN (SELECT intEmployeeID FROM TJobEmployees WHERE intJobRecordID = " & cboJob.SelectedValue.ToString & ")"

		'Retrieve Records
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'Load Data
		dt.Load(drSourceTable)

		lstAssigned.ValueMember = "intEmployeeID"
		lstAssigned.DisplayMember = "FullName"
		lstAssigned.DataSource = dt

		'Select First Item
		If lstAssigned.Items.Count > 0 Then lstAssigned.SelectedIndex = 0

		'Show Changes
		lstAssigned.EndUpdate()

		' Clean up
		drSourceTable.Close()

		'Close DB
		CloseDatabaseConnection()

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		Try

			Dim strSelect As String = ""
			Dim strInsert As String = ""
			Dim cmdInsert As OleDb.OleDbCommand
			Dim dt As DataTable = New DataTable
			Dim intRowsAffected As Integer
			Dim cmdSelect As OleDb.OleDbCommand
			Dim drSourceTable As OleDb.OleDbDataReader
			Dim intNextHighestRecordID As Integer

			'Open DB
			If OpenDatabaseConnectionSQLServer() = False Then

				'No Connection
				MessageBox.Show(Me, "Database connection error." & vbNewLine &
									"The application will now close.",
									Me.Text + " Error",
									MessageBoxButtons.OK, MessageBoxIcon.Error)
				'Close form
				Me.Close()

			End If

			'Find max value and add 1
			strSelect = "SELECT MAX(intJobEmployeeID) + 1 AS intNextHighestRecordID " &
							" FROM TJobEmployees"

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

			'Create Select
			strInsert = "INSERT INTO TJobEmployees VALUES (" & intNextHighestRecordID & ", " & cboJob.SelectedValue & ", " & lstAvailable.SelectedValue & ")"

			'Retrieve data
			cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

			intRowsAffected = cmdInsert.ExecuteNonQuery()

			'Close DB
			CloseDatabaseConnection()

			'Reload lists
			cboJob_SelectedIndexChanged(sender, e)

		Catch ex As Exception

			'Unhandled exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub btnRemoveFromJob_Click(sender As Object, e As EventArgs) Handles btnRemoveFromJob.Click

		'Variables
		Dim strDelete As String = ""
		Dim strSelect As String = String.Empty
		Dim intRowsAffected As Integer
		Dim cmdDelete As OleDb.OleDbCommand 'Delete statement
		Dim dt As DataTable = New DataTable 'Table

		Try

			'Open Database
			If OpenDatabaseConnectionSQLServer() = False Then

				'Check for connection
				MessageBox.Show(Me, "Database connection error." & vbNewLine &
									"The application will now close.",
									Me.Text + " Error",
									MessageBoxButtons.OK, MessageBoxIcon.Error)

				'Close form
				Me.Close()

			End If

			'Delete from golfer event year sponsors
			'Create delete statement
			strDelete = "Delete FROM TJobEmployees Where intEmployeeID = " & lstAssigned.SelectedValue &
				" AND intJobRecordID = " & cboJob.SelectedValue

			' Delete the record
			cmdDelete = New OleDb.OleDbCommand(strDelete, m_conAdministrator)
			intRowsAffected = cmdDelete.ExecuteNonQuery()

			'Close database
			CloseDatabaseConnection()

			'Reload lists
			cboJob_SelectedIndexChanged(sender, e)

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Close()

	End Sub


End Class
