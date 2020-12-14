Imports Microsoft.VisualBasic.PowerPacks.Printing

Public Class frmPrintInvoice

	'variable for passed invoice
	Dim receiveInvoiceNumber As String
	Dim intCustomerID As Integer
	Dim intJobRecordID As Integer
	Dim dblTotal As Double = 0.00

	Public Sub New(ByVal passedInvoiceNumber As String)

		'Receive current intCustomerID from whichever form called this one
		InitializeComponent()
		receiveInvoiceNumber = passedInvoiceNumber

	End Sub

	Private Sub frmPrintInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		'Dim todaysDate As Date
		'todaysDate = Today
		'lblDate.Text = todaysDate

		LoadInvoiceInfo()
		LoadCustomerInfo()
		LoadServices()
		LoadPartsCost()
		LoadJobInfo()

	End Sub

	Private Sub LoadInvoiceInfo()

		Dim strAddress As String = ""
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
		strSelect = "SELECT * FROM vPrintableInvoice WHERE CIN = '" & receiveInvoiceNumber & "'"


		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'load the data table from the reader
		dt.Load(drSourceTable)

		'populate labels
		lblInvoiceNumber.Text = dt.Rows(0).Item(1).ToString
		lblDate.Text = dt.Rows(0).Item(2).ToString
		intCustomerID = dt.Rows(0).Item(3)
		intJobRecordID = dt.Rows(0).Item(4)
		'lblTotal.Text = dt.Rows(0).Item(5).ToString

		'close connection
		CloseDatabaseConnection()

	End Sub

	Private Sub LoadCustomerInfo()

		Dim strAddress As String = ""
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
		strSelect = "SELECT * FROM vCustomers WHERE intCustomerID = " & intCustomerID

		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'load the data table from the reader
		dt.Load(drSourceTable)

		'populate text boxes
		lblName.Text = dt.Rows(0).Item(1).ToString & " " & dt.Rows(0).Item(2).ToString
		lblAddress.Text = dt.Rows(0).Item(3).ToString
		lblCity.Text = dt.Rows(0).Item(3).ToString & ", " & dt.Rows(0).Item(5).ToString & ", " & dt.Rows(0).Item(6).ToString
		lblPhone.Text = dt.Rows(0).Item(7).ToString
		lblEmail.Text = dt.Rows(0).Item(8).ToString

		'close connection
		CloseDatabaseConnection()

	End Sub

	Private Sub LoadServices()

		lblServices.ResetText()
		lblBilling.ResetText()
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

				lblServices.Text = lblServices.Text & "Liner Installation" & Environment.NewLine
				lblBilling.Text = lblBilling.Text & dt.Rows(intIndex).Item(3) & Environment.NewLine
				dblTotal += dt.Rows(intIndex).Item(3)

			ElseIf dt.Rows(intIndex).Item(1) = 2 Then

				lblServices.Text = lblServices.Text & "Water Testing" & Environment.NewLine
				lblBilling.Text = lblBilling.Text & dt.Rows(intIndex).Item(3) & Environment.NewLine
				dblTotal += dt.Rows(intIndex).Item(3)

			ElseIf dt.Rows(intIndex).Item(1) = 3 Then

				lblServices.Text = lblServices.Text & "Leak Detection" & Environment.NewLine
				lblBilling.Text = lblBilling.Text & dt.Rows(intIndex).Item(3) & Environment.NewLine
				dblTotal += dt.Rows(intIndex).Item(3)

			ElseIf dt.Rows(intIndex).Item(1) = 4 Then

				lblServices.Text = lblServices.Text & "Vacuuming" & Environment.NewLine
				lblBilling.Text = lblBilling.Text & dt.Rows(intIndex).Item(3) & Environment.NewLine
				dblTotal += dt.Rows(intIndex).Item(3)

			ElseIf dt.Rows(intIndex).Item(1) = 5 Then

				lblServices.Text = lblServices.Text & "Skimming" & Environment.NewLine
				lblBilling.Text = lblBilling.Text & dt.Rows(intIndex).Item(3) & Environment.NewLine
				dblTotal += dt.Rows(intIndex).Item(3)

			ElseIf dt.Rows(intIndex).Item(1) = 6 Then

				lblServices.Text = lblServices.Text & "Chemicals Added" & Environment.NewLine
				lblBilling.Text = lblBilling.Text & dt.Rows(intIndex).Item(3) & Environment.NewLine
				dblTotal += dt.Rows(intIndex).Item(3)

			ElseIf dt.Rows(intIndex).Item(1) = 7 Then

				lblServices.Text = lblServices.Text & "Filter Backwashed" & Environment.NewLine
				lblBilling.Text = lblBilling.Text & dt.Rows(intIndex).Item(3) & Environment.NewLine
				dblTotal += dt.Rows(intIndex).Item(3)

			End If

		Next

		' close the database connection
		CloseDatabaseConnection()

	End Sub

	Private Sub LoadPartsCost()

		Dim strSelectRowCount As String
		Dim cmdSelectRowCount As OleDb.OleDbCommand
		Dim dtSelectRowCount As DataTable = New DataTable

		Dim strPartsTotal As String
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

		strSelectRowCount = "SELECT COUNT(intJobRecordID) From TJobParts Where intJobRecordID = " & intJobRecordID

		cmdSelectRowCount = New OleDb.OleDbCommand(strSelectRowCount, m_conAdministrator)
		drSourceTable = cmdSelectRowCount.ExecuteReader

		dtSelectRowCount.Load(drSourceTable)

		intRowCount = dtSelectRowCount.Rows(0).Item(0)


		'Create select
		strSelect = "SELECT " &
						"CONVERT(VARCHAR, SUM(TP.decUnitSaleCost * TJP.intPartQuantity)) " &
					 "From " &
						 "TParts AS TP " &
						",TJobParts AS TJP " &
						",TJobRecords AS TJ " &
					 "WHERE TJP.intPartID = TP.intPartID " &
					 "AND TJP.intJobRecordID = TJ.intJobRecordID " &
					 "AND TJ.intJobRecordID = " & intJobRecordID

		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'load the data table from the reader
		dt.Load(drSourceTable)


		'Check for any parts
		If intRowCount > 0 Then

			strPartsTotal = dt.Rows(0).Item(0).ToString

			lblServices.Text = lblServices.Text & "Part Cost"
			lblBilling.Text = lblBilling.Text & strPartsTotal
			dblTotal += dt.Rows(0).Item(0).tos


		End If

		lblTotal.Text = "$" & dblTotal.ToString

		' close the database connection
		CloseDatabaseConnection()



	End Sub

	Private Sub LoadJobInfo()

		Dim strAddress As String = ""
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
		strSelect = "SELECT strJobDesc FROM TJobRecords WHERE intJobRecordID = " & intJobRecordID

		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'load the data table from the reader
		dt.Load(drSourceTable)

		'populate text boxes
		lblDescription.Text = dt.Rows(0).Item(0).ToString


		'close connection
		CloseDatabaseConnection()

	End Sub

	Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

		'Me.Visible = False



		prdiaInvoice.PrinterSettings = prfrmInvoice.PrinterSettings
		prdiaInvoice.AllowSomePages = True
		If prdiaInvoice.ShowDialog = DialogResult.OK Then prfrmInvoice.PrinterSettings = prdiaInvoice.PrinterSettings

		'Print Preview?
		If chkPrintPreview.Checked = True Then
			prfrmInvoice.PrintAction = Printing.PrintAction.PrintToPreview
		End If


		'Set Margins
		prfrmInvoice.PrinterSettings.DefaultPageSettings.Margins.Left = 10
		prfrmInvoice.PrinterSettings.DefaultPageSettings.Margins.Top = 10
		prfrmInvoice.PrinterSettings.DefaultPageSettings.Margins.Right = 10
		prfrmInvoice.PrinterSettings.DefaultPageSettings.Margins.Bottom = 10

		btnPrint.Visible = False
		chkPrintPreview.Visible = False

		prfrmInvoice.Print()

		btnPrint.Visible = True
		chkPrintPreview.Visible = True

	End Sub

End Class