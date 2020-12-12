Public Class frmEditJobParts
	Private Sub frmEditJobParts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try

			' Load names combo box
			ComboBoxNameSearch()

			LoadPartsList()

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

	Private Sub cboJob_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJob.SelectedIndexChanged

		Try

			LoadJobParts()

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

	Private Sub LoadPartsList()

		Dim strSelect As String = ""
		Dim cmdSelect As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim dt As DataTable = New DataTable

		txtAddQnty.Clear()
		txtRemoveQnty.Clear()

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
		strSelect = "SELECT strSerialNumber as Serial, strPartDesc AS Description, intQuantity AS Quantity FROM TParts" &
			" WHERE strSerialNumber LIKE '%" & txtPartSearch.Text & "%' OR" &
			" strPartDesc LIKE '%" & txtPartSearch.Text & "%'"

		'Get records
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'Load Table
		dt.Load(drSourceTable)

		dgvAvailableParts.DataSource = dt


		' Clean up
		drSourceTable.Close()

		' close the database connection
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
							"TP.strSerialNumber AS Serial " &
							",TP.strPartDesc AS Description " &
							",TJP.intPartQuantity AS Quantity " &
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

		' Clean up
		drSourceTable.Close()

		'dgvAssignedParts

		' close the database connection
		CloseDatabaseConnection()

	End Sub

	Private Sub txtPartSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPartSearch.KeyPress

		'If keypress return
		Dim tb As TextBox = CType(sender, TextBox)
		If Char.IsControl(e.KeyChar) Then
			If e.KeyChar.Equals(Chr(Keys.Return)) Then

				Try

					btnPartSearch_Click(sender, e)

				Catch ex As Exception

					'Unhandled Exception
					MessageBox.Show(ex.Message)

				End Try

			End If
		End If

	End Sub

	Private Sub btnPartSearch_Click(sender As Object, e As EventArgs) Handles btnPartSearch.Click

		'initiante search
		LoadPartsList()

	End Sub

	Private Sub btnAssignPart_Click(sender As Object, e As EventArgs) Handles btnAssignPart.Click

		Try

			Dim intItemQuantity As Integer = dgvAvailableParts.CurrentRow.Cells(2).Value - txtAddQnty.Text

			If intItemQuantity >= 0 Then

				AddPartToJob()

				UpdateAvailableQuantity()

				LoadPartsList()

				LoadJobParts()

			Else

				MessageBox.Show("Selected part quantity not available")

			End If

		Catch ex As Exception

			'Unhandled exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub AddPartToJob()

		Dim strSelect As String = ""
		Dim strFindPartID As String = ""
		Dim strInsert As String = ""
		Dim cmdInsert As OleDb.OleDbCommand
		Dim cmdSelect As OleDb.OleDbCommand
		Dim dt As DataTable = New DataTable
		Dim intRowsAffected As Integer
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim intNextHighestRecordID As Integer
		Dim intPartID As Integer

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

		' ---------------------------------------------------------------------
		' GET NEXT HIGHEST INT FOR ID -----------------------------------------
		' ---------------------------------------------------------------------
		'Find max value and add 1
		strSelect = "SELECT MAX(intJobPartID) + 1 AS intNextHighestRecordID " &
						" FROM TJobParts"

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

		' ---------------------------------------------------------------------
		' GET Part ID ---------------------------------------------------------
		' ---------------------------------------------------------------------
		'Find max value and add 1
		strFindPartID = "SELECT intPartID AS intPartID FROM TParts WHERE strSerialNumber = '" & dgvAvailableParts.CurrentRow.Cells(0).Value & "'"

		'Execute
		cmdSelect = New OleDb.OleDbCommand(strFindPartID, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'Read
		drSourceTable.Read()

		'Assign Part ID
		intPartID = CInt(drSourceTable.Item(0))

		'Create Select
		strInsert = "INSERT INTO TJobParts VALUES (" & intNextHighestRecordID &
			", " & cboJob.SelectedValue &
			", " & intPartID &
			", " & txtAddQnty.Text &
			")"

		'dgvJobs.CurrentRow.Cells(0).Value

		'Retrieve data
		cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

		intRowsAffected = cmdInsert.ExecuteNonQuery()

		'Close DB
		CloseDatabaseConnection()

	End Sub

	Private Sub UpdateAvailableQuantity()

		Dim strUpdate As String = ""
		Dim strSelect As String = ""
		Dim strFindPartID As String = ""
		Dim strInsert As String = ""
		Dim cmdUpdate As OleDb.OleDbCommand
		Dim dt As DataTable = New DataTable
		Dim intRowsAffected As Integer

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

		' ---------------------------------------------------------------------
		' Update Available Quantity -------------------------------------------
		' ---------------------------------------------------------------------
		strUpdate = "UPDATE TParts " &
				"SET intQuantity = " & dgvAvailableParts.CurrentRow.Cells(2).Value - txtAddQnty.Text &
				" WHERE strSerialNumber = '" & dgvAvailableParts.CurrentRow.Cells(0).Value & "'"

		cmdUpdate = New OleDb.OleDbCommand(strUpdate, m_conAdministrator)

		intRowsAffected = cmdUpdate.ExecuteNonQuery()

		'Close DB
		CloseDatabaseConnection()

	End Sub


	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Close()

	End Sub

End Class