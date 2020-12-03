' Previous Invoices form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmPreviousInvoices

	Dim intJobRecordID As Integer

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close program
		Close()

	End Sub

	Private Sub frmPreviousInvoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try

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
			strSelect = "SELECT * FROM vCustomersWithInvoices ORDER BY FullName ASC"

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

	Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged

		Try

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

			cboInvoice.BeginUpdate()

			'Create select
			strSelect = "SELECT * FROM TInvoices WHERE intCustomerID = " & cboName.SelectedValue

			'Get records
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load Table
			dt.Load(drSourceTable)

			' Add items to combo box
			cboInvoice.ValueMember = "intInvoiceID"
			cboInvoice.DisplayMember = "CIN"
			cboInvoice.DataSource = dt

			' Select the first item in the list by default
			If cboInvoice.Items.Count > 0 Then cboInvoice.SelectedIndex = 0

			' Show changes
			cboInvoice.EndUpdate()

			' Clean up
			drSourceTable.Close()

			' close the database connection
			CloseDatabaseConnection()
		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub cboInvoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInvoice.SelectedIndexChanged

		Try

			ResetCheckBoxes()

			LoadInvoice()

			LoadJobDates()

			DetermineServices()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub ResetCheckBoxes()

		chkInstallation.Checked = False
		chkTesting.Checked = False
		chkDetection.Checked = False
		chkVacuumed.Checked = False
		chkSkimmed.Checked = False
		chkChemicals.Checked = False
		chkFilter.Checked = False

	End Sub

	Private Sub LoadInvoice()

		Dim strDate As String = ""
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

		'Create select
		strSelect = "SELECT * FROM TInvoices WHERE intInvoiceID = " & cboInvoice.SelectedValue

		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'load the data table from the reader
		dt.Load(drSourceTable)

		'load related job id
		intJobRecordID = dt.Rows(0).Item(2)

		'populate text boxes
		lblDueDate.Text = dt.Rows(0).Item(3)

		' close the database connection
		CloseDatabaseConnection()

	End Sub

	Private Sub LoadJobDates()

		Dim strDate As String = ""
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

		'Create select
		strSelect = "SELECT * FROM TJobRecords WHERE intJobRecordID = " & intJobRecordID

		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'load the data table from the reader
		dt.Load(drSourceTable)

		'populate text boxes
		lblDateServiceStarted.Text = dt.Rows(0).Item(1)
		lblDateServiceEnded.Text = dt.Rows(0).Item(2)

		' close the database connection
		CloseDatabaseConnection()

	End Sub

	Private Sub DetermineServices()

		Dim intRowCount As Integer
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

		'Create select
		strSelect = "SELECT * FROM TJobServices WHERE intJobRecordID = " & intJobRecordID & " AND intInvoiceID = " & cboInvoice.SelectedValue

		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'load the data table from the reader
		dt.Load(drSourceTable)

		intRowCount = dt.Rows.Count

		For intIndex As Integer = 0 To (intRowCount - 1)

			'Check related check boxes
			If dt.Rows(intIndex).Item(1) = 1 Then
				chkInstallation.Checked = True
			ElseIf dt.Rows(intIndex).Item(1) = 2 Then
				chkTesting.Checked = True
			ElseIf dt.Rows(intIndex).Item(1) = 3 Then
				chkDetection.Checked = True
			ElseIf dt.Rows(intIndex).Item(1) = 4 Then
				chkVacuumed.Checked = True
			ElseIf dt.Rows(intIndex).Item(1) = 5 Then
				chkSkimmed.Checked = True
			ElseIf dt.Rows(intIndex).Item(1) = 6 Then
				chkChemicals.Checked = True
			ElseIf dt.Rows(intIndex).Item(1) = 7 Then
				chkFilter.Checked = True
			End If

		Next

		' close the database connection
		CloseDatabaseConnection()

	End Sub

End Class