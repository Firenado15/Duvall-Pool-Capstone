' Previous Invoices form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Imports Microsoft.VisualBasic.PowerPacks.Printing

Public Class frmPreviousInvoices

	Dim intJobRecordID As Integer
	Dim intJobServiceID As Integer

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
			strSelect = "SELECT * FROM vCustomerInvoices WHERE intCustomerID = " & cboName.SelectedValue

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
		intJobRecordID = dt.Rows(0).Item(1)

		'populate text boxes
		lblDueDate.Text = dt.Rows(0).Item(2)
		lblTotal.Text = "$" & dt.Rows(0).Item(3)
		lblPaid.Text = "$" & dt.Rows(0).Item(4)

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
		strSelect = "SELECT * FROM TJobServices WHERE intJobRecordID = " & intJobRecordID

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

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		'Dim pf As New PrintForm
		'pf.Form = Me
		'pf.PrintAction = Printing.PrintAction.PrintToFile
		'pf.PrintFileName = cboInvoice.Text.ToString
		'pf.Print()


		'prdiaInvoice.PrinterSettings = prfrmInvoice.PrinterSettings
		'prdiaInvoice.AllowSomePages = True
		'If prdiaInvoice.ShowDialog = DialogResult.OK Then prfrmInvoice.PrinterSettings = prdiaInvoice.PrinterSettings

		''With Me.PrintForm1
		'prfrmInvoice.PrintAction = Printing.PrintAction.PrintToPreview

		''Set Margins
		'prfrmInvoice.PrinterSettings.DefaultPageSettings.Margins.Left = 10
		'prfrmInvoice.PrinterSettings.DefaultPageSettings.Margins.Top = 10
		'prfrmInvoice.PrinterSettings.DefaultPageSettings.Margins.Right = 10
		'prfrmInvoice.PrinterSettings.DefaultPageSettings.Margins.Bottom = 10

		'prfrmInvoice.Print()

		'End With

		' create a new instance of the customer intake form, passing current intCustomerID
		Dim printInvoice As New frmPrintInvoice(cboInvoice.Text)

		' show the new form so any past data is not still on the form
		printInvoice.ShowDialog()

	End Sub

	Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click

		If lblTotal.Text = lblPaid.Text Then
			MessageBox.Show(Me, "This invoice is already paid in full.")
		Else

			Dim strSelect As String = ""
			Dim strName As String = ""
			Dim intRowCount As Integer
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
			strSelect = "SELECT TOP 1 * FROM TCustomerPaymentTypes WHERE intCustomerID = " & cboName.SelectedValue.ToString & " ORDER BY intCustomerPaymentID DESC"

			'Retrieve records 
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'load the data table from the reader
			dt.Load(drSourceTable)

			intRowCount = dt.Rows.Count

			'close connection
			CloseDatabaseConnection()

			'Verify any rows were added to dt
			If intRowCount = 0 Then

				Dim result As DialogResult = MessageBox.Show("You must have an active payment type to make a payment." & Environment.NewLine & " Would you like to enter one now?", "Payment", MessageBoxButtons.YesNo)
				If result = DialogResult.No Then

				ElseIf result = DialogResult.Yes Then

					' create a new instance of the customer intake form, passing current intCustomerID
					Dim CustomerPayment As New frmPaymentType(cboName.SelectedValue)

					' show the new form so any past data is not still on the form
					CustomerPayment.ShowDialog()

				End If

			Else

				' create a new instance of the customer intake form, passing current intCustomerID
				Dim MakeInvoicePayment As New frmMakeInvoicePayment(cboInvoice.SelectedValue, cboName.SelectedValue, lblTotal.Text, lblPaid.Text)

				' show the new form so any past data is not still on the form
				MakeInvoicePayment.ShowDialog()

				'Reload Invoice info
				LoadInvoice()

			End If

		End If

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDeleteInvoice.Click

		Try

			ResetCheckBoxes()

			DeleteInvoice()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub DeleteInvoice()

		Dim strDeleteServices As String = ""
		Dim strDeleteInvoice As String = ""
		Dim strDeleteInvoicePayments As String = ""
		Dim cmdDeleteServices As OleDb.OleDbCommand 'Select
		Dim cmdDeleteInvoices As OleDb.OleDbCommand 'Select
		Dim cmdDeletePayments As OleDb.OleDbCommand
		Dim intRowsAffected As Integer

		' ----------------------------------------------------------------------------
		'open the database -----------------------------------------------------------
		' ----------------------------------------------------------------------------

		If OpenDatabaseConnectionSQLServer() = False Then

			' No connection error
			MessageBox.Show(Me, "Database connection error." & vbNewLine &
								"The application will now close.",
								Me.Text + " Error",
								MessageBoxButtons.OK, MessageBoxIcon.Error)

			'close the form
			Me.Close()

		End If

		' ----------------------------------------------------------------------------
		' Remove job services --------------------------------------------------------
		' ----------------------------------------------------------------------------

		'Delete statement
		strDeleteServices = "DELETE FROM TJobServices WHERE intJobRecordID =" & intJobRecordID

		'Delete records 
		cmdDeleteServices = New OleDb.OleDbCommand(strDeleteServices, m_conAdministrator)

		intRowsAffected = cmdDeleteServices.ExecuteNonQuery()

		'If intRowsAffected > 0 Then
		'	MessageBox.Show("Services have been removed")
		'	Me.Close()
		'End If

		' ----------------------------------------------------------------------------
		' Remove invoice payments-----------------------------------------------------
		' ----------------------------------------------------------------------------

		'Delete statement
		strDeleteInvoicePayments = "DELETE FROM TInvoicePayments WHERE intInvoiceID =" & cboInvoice.SelectedValue

		'Delete records 
		cmdDeletePayments = New OleDb.OleDbCommand(strDeleteInvoicePayments, m_conAdministrator)

		intRowsAffected = cmdDeletePayments.ExecuteNonQuery()

		'If intRowsAffected > 0 Then
		'	MessageBox.Show("Services have been removed")
		'	Me.Close()
		'End If


		' ----------------------------------------------------------------------------
		' Remove job invoice ---------------------------------------------------------
		' ----------------------------------------------------------------------------

		intRowsAffected = 0

		'Delete statement
		strDeleteInvoice = "DELETE FROM TInvoices WHERE intInvoiceID =" & cboInvoice.SelectedValue

		'Delete records
		cmdDeleteInvoices = New OleDb.OleDbCommand(strDeleteInvoice, m_conAdministrator)

		intRowsAffected = cmdDeleteInvoices.ExecuteNonQuery()

		If intRowsAffected > 0 Then
			MessageBox.Show("Invoice has been removed")
			Me.Close()
		End If

		'close connection
		CloseDatabaseConnection()

	End Sub
End Class