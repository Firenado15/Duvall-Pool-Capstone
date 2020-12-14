' Invoicing form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmAddInvoice

	Dim intInvoiceNumber As Integer
	Dim blnFirstService As Boolean = True
	Dim dblInvoiceCost As Double = 0.00

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close program
		Close()

	End Sub

	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		Try

			Validation()

			CalculateTotalCost()

			InsertInvoice()

			InsertJobServices()

			MessageBox.Show("Invoice has been added")

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
			strSelect = "SELECT * FROM vJobsAndNoInvoice ORDER BY FullName ASC"

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
			strSelect = "SELECT intJobRecordID, JobNumber FROM vJobsWithoutInvoices WHERE intCustomerID = " & cboCustomer.SelectedValue

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

		Try

			LoadJobDetails()

			LoadJobParts()

			CalculatePartsCost()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub LoadJobDetails()

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
		strSelect = "SELECT * FROM TJobRecords WHERE intJobRecordID = " & cboJob.SelectedValue.ToString


		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'Load Table
		dt.Load(drSourceTable)

		'populate text boxes
		lblStartDate.Text = dt.Rows(0).Item(1).ToString
		lblEndDate.Text = dt.Rows(0).Item(2).ToString
		lblJobDesc.Text = dt.Rows(0).Item(3).ToString

		'close connection
		CloseDatabaseConnection()

	End Sub

	Private Sub LoadJobParts()

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
		strSelect = "SELECT " &
							"TP.strPartName AS Name " &
							",TP.strSerialNumber AS Serial " &
							",TJP.intPartQuantity AS Quantity " &
							", ('$' + CONVERT(VARCHAR, TP.decUnitSaleCost)) AS UnitCost " &
					"From " &
							"TParts AS TP " &
							",TJobParts AS TJP " &
							",TJobRecords AS TJ " &
					"WHERE TJP.intPartID = TP.intPartID " &
					"AND TJP.intJobRecordID = TJ.intJobRecordID " &
					"AND TJ.intJobRecordID = " & cboJob.SelectedValue

		'Get records
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'Load Table
		dt.Load(drSourceTable)

		dgvAssignedParts.DataSource = dt

		'dgvAssignedParts.Columns(3).Visible = False

		' Clean up
		drSourceTable.Close()

		' close the database connection
		CloseDatabaseConnection()

	End Sub

	Private Sub CalculatePartsCost()

		Dim dblTotalCost As Double = 0.00

		If dgvAssignedParts.RowCount > 0 Then

			Dim intRowCount As Integer = dgvAssignedParts.RowCount


			For intIndex As Integer = 0 To (intRowCount - 1)

				dblTotalCost += (dgvAssignedParts.Rows(intIndex).Cells(3).Value * dgvAssignedParts.Rows(intIndex).Cells(2).Value)

			Next

		End If

		lblTotalPartCost.Text = "$" & dblTotalCost

	End Sub

	Private Sub CalculateTotalCost()

		'reset total
		dblInvoiceCost = 0


		'only text boxes to total if they're enabled
		If txtLinerCost.Enabled = True Then
			dblInvoiceCost += txtLinerCost.Text
		End If

		If txtTestingCost.Enabled = True Then
			dblInvoiceCost += txtTestingCost.Text
		End If

		If txtLeakCost.Enabled = True Then
			dblInvoiceCost += txtLeakCost.Text
		End If

		If txtVacuumCost.Enabled = True Then
			dblInvoiceCost += txtVacuumCost.Text
		End If

		If txtSkimCost.Enabled = True Then
			dblInvoiceCost += txtSkimCost.Text
		End If

		If txtChemCost.Enabled = True Then
			dblInvoiceCost += txtChemCost.Text
		End If

		If txtFilterCost.Enabled = True Then
			dblInvoiceCost += txtFilterCost.Text
		End If

		'Add Part cost total
		dblInvoiceCost += lblTotalPartCost.Text

		txtTotalCost.Text = dblInvoiceCost

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
				", " & cboJob.SelectedValue &
				", '" & strDate &
				"', " & dblInvoiceCost &
				", 0.00)"


			cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

			intRowsAffected = cmdInsert.ExecuteNonQuery()

			intInvoiceNumber = intNextHighestRecordID

			CloseDatabaseConnection()

			Me.Close()

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

			strInsert = strInsert & " (" & intNextHighestRecordID & ", 1, " & cboJob.SelectedValue & ", " & txtLinerCost.Text & ")"
			intNextHighestRecordID += 1
			blnFirstService = False

		End If
		If chkTesting.Checked = True Then

			If blnFirstService = False Then
				strInsert = strInsert & ","
			End If
			strInsert = strInsert & " (" & intNextHighestRecordID & ", 2, " & cboJob.SelectedValue & ", " & txtTestingCost.Text & ")"
			intNextHighestRecordID += 1
			blnFirstService = False

		End If
		If chkDetection.Checked = True Then

			If blnFirstService = False Then
				strInsert = strInsert & ","

			End If
			strInsert = strInsert & " (" & intNextHighestRecordID & ", 3, " & cboJob.SelectedValue & ", " & txtLeakCost.Text & ")"
			intNextHighestRecordID += 1
			blnFirstService = False

		End If
		If chkVacuumed.Checked = True Then

			If blnFirstService = False Then
				strInsert = strInsert & ","

			End If
			strInsert = strInsert & " (" & intNextHighestRecordID & ", 4, " & cboJob.SelectedValue & ", " & txtVacuumCost.Text & ")"
			intNextHighestRecordID += 1
			blnFirstService = False

		End If
		If chkSkimmed.Checked = True Then

			If blnFirstService = False Then
				strInsert = strInsert & ","

			End If
			strInsert = strInsert & " (" & intNextHighestRecordID & ", 5, " & cboJob.SelectedValue & ", " & txtSkimCost.Text & ")"
			intNextHighestRecordID += 1
			blnFirstService = False

		End If
		If chkChemicals.Checked = True Then

			If blnFirstService = False Then
				strInsert = strInsert & ","

			End If
			strInsert = strInsert & " (" & intNextHighestRecordID & ", 6, " & cboJob.SelectedValue & ", " & txtChemCost.Text & ")"
			intNextHighestRecordID += 1
			blnFirstService = False

		End If
		If chkFilter.Checked = True Then

			If blnFirstService = False Then
				strInsert = strInsert & ","

			End If
			strInsert = strInsert & " (" & intNextHighestRecordID & ", 7, " & cboJob.SelectedValue & ", " & txtFilterCost.Text & ")"
			intNextHighestRecordID += 1

		End If

		cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

		intRowsAffected = cmdInsert.ExecuteNonQuery()

		CloseDatabaseConnection()

		Me.Close()

	End Sub

	' Liner ----------------------------------------------

	Private Sub chkInstallation_CheckedChanged(sender As Object, e As EventArgs) Handles chkInstallation.CheckedChanged

		'if checked
		If chkInstallation.Checked = True Then
			'turn on radio buttons
			radAbove.Enabled = True
			radInground.Enabled = True

		End If

		'if unchecked
		If chkInstallation.Checked = False Then

			'turn off radio buttons
			radAbove.Checked = False
			radInground.Checked = False
			radAbove.Enabled = False
			radInground.Enabled = False
			txtLinerCost.Clear()
			txtLinerCost.Enabled = False


			'turn off combo boxes
			cboAbove.Enabled = False
			cboAbove.Text = ""
			cboInground.Enabled = False
			cboInground.Text = ""

		End If

	End Sub

	Private Sub radAbove_CheckedChanged(sender As Object, e As EventArgs) Handles radAbove.CheckedChanged

		'turn on Above combo box
		cboAbove.Visible = True
		cboAbove.Enabled = True

		'turn off Inground combo box
		cboInground.Enabled = False
		cboInground.Visible = False

	End Sub

	Private Sub radInground_CheckedChanged(sender As Object, e As EventArgs) Handles radInground.CheckedChanged

		'turn on Inground combo box
		cboInground.Visible = True
		cboInground.Enabled = True


		'turn off Above combo box
		cboAbove.Enabled = False
		cboAbove.Visible = False

	End Sub

	Private Sub cboInground_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInground.SelectedIndexChanged

		txtLinerCost.Enabled = True
		CalculateLinerCost()

	End Sub

	Private Sub cboAbove_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAbove.SelectedIndexChanged

		txtLinerCost.Enabled = True
		CalculateLinerCost()

	End Sub

	Private Sub CalculateLinerCost()

		'check for liner installation
		If chkInstallation.Checked = True Then
			'check for aboveground
			If radAbove.Checked = True Then
				'check which pool size and assign price
				If cboAbove.SelectedIndex = 0 Then
					txtLinerCost.Text = 400
				ElseIf cboAbove.SelectedIndex = 1 Then
					txtLinerCost.Text = 800
				ElseIf cboAbove.SelectedIndex = 2 Then
					txtLinerCost.Text = 1200
				ElseIf cboAbove.SelectedIndex = 3 Then
					txtLinerCost.Text = 1600
				End If
				'check for inground
			ElseIf radInground.Checked = True Then
				'check which pool size and assign price
				If cboInground.SelectedIndex = 0 Then
					txtLinerCost.Text = 960
				ElseIf cboInground.SelectedIndex = 1 Then
					txtLinerCost.Text = 1920
				ElseIf cboInground.SelectedIndex = 2 Then
					txtLinerCost.Text = 2880
				ElseIf cboInground.SelectedIndex = 3 Then
					txtLinerCost.Text = 3840
				ElseIf cboInground.SelectedIndex = 4 Then
					txtLinerCost.Text = 4800
				End If
			End If
		End If

	End Sub

	' Water Testing -------------------------------------------------------

	Private Sub chkTesting_CheckedChanged(sender As Object, e As EventArgs) Handles chkTesting.CheckedChanged

		If chkTesting.Checked = True Then
			'turn on combo and text box
			txtTestingCost.Enabled = True
			txtTestingCost.Text = 45

		End If
		'unchecked
		If chkTesting.Checked = False Then
			'turn off combo and text box
			txtTestingCost.Clear()
			txtTestingCost.Enabled = False

		End If

	End Sub

	' Leak Detection --------------------------------------------------------

	Private Sub chkDetection_CheckedChanged(sender As Object, e As EventArgs) Handles chkDetection.CheckedChanged

		'checked
		If chkDetection.Checked = True Then
			'turn on combo and text box
			cboLeak.Enabled = True
		End If
		'unchecked
		If chkDetection.Checked = False Then
			'turn off combo and text box
			cboLeak.Enabled = False
			cboLeak.Text = ""
			txtLeakCost.Enabled = False
			txtLeakCost.Clear()
		End If

	End Sub

	Private Sub cboLeak_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLeak.SelectedIndexChanged

		'Recalculate cost
		txtLeakCost.Enabled = True
		CalculateLeakCost()

	End Sub

	Private Sub CalculateLeakCost()

		'Determine selection
		If cboLeak.SelectedIndex = 0 Then
			txtLeakCost.Text = 100
		ElseIf cboLeak.SelectedIndex = 1 Then
			txtLeakCost.Text = 300
		ElseIf cboLeak.SelectedIndex = 2 Then
			txtLeakCost.Text = 500
		End If

	End Sub

	' Vacuumed -------------------------------------------------------------

	Private Sub chkVacuumed_CheckedChanged(sender As Object, e As EventArgs) Handles chkVacuumed.CheckedChanged

		'checked
		If chkVacuumed.Checked = True Then
			'turn on combo and text box
			cboVacuumHours.Enabled = True

		End If
		'unchecked
		If chkVacuumed.Checked = False Then
			'turn off combo and text box
			cboVacuumHours.Enabled = False
			cboVacuumHours.Text = ""
			txtVacuumCost.Enabled = False
			txtVacuumCost.Clear()

		End If

	End Sub

	Private Sub cboVacuumHours_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVacuumHours.SelectedIndexChanged

		txtVacuumCost.Enabled = True
		txtVacuumCost.Text = cboVacuumHours.Text * 85

	End Sub

	' Skimmed -----------------------------------------------------------

	Private Sub chkSkimmed_CheckedChanged(sender As Object, e As EventArgs) Handles chkSkimmed.CheckedChanged

		If chkSkimmed.Checked = True Then
			'turn on combo and text box
			txtSkimCost.Enabled = True
			txtSkimCost.Text = 35

		End If
		'unchecked
		If chkSkimmed.Checked = False Then
			'turn off combo and text box
			txtSkimCost.Clear()
			txtSkimCost.Enabled = False

		End If

	End Sub

	' Chemical Balance ---------------------------------------------------

	Private Sub chkChemicals_CheckedChanged(sender As Object, e As EventArgs) Handles chkChemicals.CheckedChanged

		If chkChemicals.Checked = True Then
			'turn on combo and text box
			txtChemCost.Enabled = True
			txtChemCost.Text = 50

		End If
		'unchecked
		If chkChemicals.Checked = False Then
			'turn off combo and text box
			txtChemCost.Clear()
			txtChemCost.Enabled = False

		End If

	End Sub

	' Filter -------------------------------------------------------------

	Private Sub chkFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilter.CheckedChanged

		If chkFilter.Checked = True Then
			'turn on combo and text box
			txtFilterCost.Enabled = True
			txtFilterCost.Text = 45

		End If
		'unchecked
		If chkFilter.Checked = False Then
			'turn off combo and text box
			txtFilterCost.Clear()
			txtFilterCost.Enabled = False

		End If

	End Sub

	Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

		CalculateTotalCost()

	End Sub


End Class
