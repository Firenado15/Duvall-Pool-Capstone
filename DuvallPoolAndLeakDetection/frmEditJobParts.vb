Public Class frmEditJobParts

	' ----------------------------------------------------------------------------------------------------------------------------------------------------------
	' FORM CONTROLS --------------------------------------------------------------------------------------------------------------------------------------------
	' ----------------------------------------------------------------------------------------------------------------------------------------------------------

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

			LoadJobDesc()

			LoadJobParts()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

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

			'Reset textbox color
			txtAddQnty.BackColor = Color.White
			txtRemoveQnty.BackColor = Color.White

			Dim intItemQuantity As Integer
			Dim intPartIndex As Integer = dgvAssignedParts.RowCount - 1
			Dim blnPartAlreadyOnJob As Boolean = False
			Dim strAvailSN As String = dgvAvailableParts.CurrentRow.Cells(1).Value.ToString
			Dim strAssignSN As String

			If txtAddQnty.Text <> String.Empty And IsNumeric(txtAddQnty.Text) Then

				'Set calculated quantity to current minus requestd
				intItemQuantity = dgvAvailableParts.CurrentRow.Cells(2).Value - txtAddQnty.Text

				'Check that the selected part is available
				If intItemQuantity >= 0 Then

					'check all rows for existing part
					For intIndex As Integer = 0 To intPartIndex

						'Compare serial of selected available part with all existing parts on the job
						strAssignSN = dgvAssignedParts.Rows(intIndex).Cells(1).Value.ToString

						'if exsists, flip boolean to true
						If strAvailSN = strAssignSN Then
							blnPartAlreadyOnJob = True
						End If

					Next

					'if part...
					If blnPartAlreadyOnJob = False Then

						'doesn't exist, add to job
						AddPartToJob()

					Else
						'does exist, update quantity
						UpdatePartOnJob()

					End If

					LowerAvailableQuantity()

					LoadPartsList()

					LoadJobParts()

				Else
					'Return message if not enough part quantity
					MessageBox.Show("Selected part quantity not available")
				End If

			Else

				' text box is blank so tell user to enter number of employees, change back color to yellow,
				' put focus in text box and return false we don't want to continue
				MessageBox.Show("Please enter number of parts to add.")
				txtAddQnty.BackColor = Color.Yellow
				txtAddQnty.Focus()
			End If

		Catch ex As Exception

			'Unhandled exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub btnRemovePart_Click(sender As Object, e As EventArgs) Handles btnRemovePart.Click

		Try

			'Reset textbox color
			txtAddQnty.BackColor = Color.White
			txtRemoveQnty.BackColor = Color.White

			'Determine how many are left assigned
			Dim intItemQuantityLeft As Integer

			' Check for numeric value in remove text box
			If txtRemoveQnty.Text <> String.Empty And IsNumeric(txtRemoveQnty.Text) Then

				intItemQuantityLeft = dgvAssignedParts.CurrentRow.Cells(2).Value - txtRemoveQnty.Text

				'Check for remaining qnty...
				If intItemQuantityLeft <= 0 Then

					' if 0 or less, remove part from job
					RemovePartFromJob()

				Else

					' more than 0, update part quantity
					UpdateAssignedQuantity()

				End If

				'add parts back to available qnty
				IncreaseAvailableQuantity()

				'reload available parts list data
				LoadPartsList()

				'reload assigned parts data
				LoadJobParts()

			Else

				' text box is blank so tell user to enter number of employees, change back color to yellow,
				' put focus in text box and return false we don't want to continue
				MessageBox.Show("Please enter number of parts to remove.")
				txtRemoveQnty.BackColor = Color.Yellow
				txtRemoveQnty.Focus()
			End If

		Catch ex As Exception

			'Unhandled exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Close()

	End Sub




	' ----------------------------------------------------------------------------------------------------------------------------------------------------------
	' Load Data Subs -------------------------------------------------------------------------------------------------------------------------------------------
	' ----------------------------------------------------------------------------------------------------------------------------------------------------------

	Private Sub LoadJobDesc()

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
		strSelect = "SELECT strJobDesc FROM TJobRecords WHERE intJobRecordID = " & cboJob.SelectedValue

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
		strSelect = "SELECT * FROM vJobsAndNoInvoice WHERE FullName LIKE '%" & cboName.Text &
			"%' ORDER BY FullName ASC"

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
		strSelect = "SELECT intJobRecordID, JobNumber FROM vJobsWithoutInvoices WHERE intCustomerID = " & cboName.SelectedValue &
					" ORDER BY JobNumber DESC"

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
		strSelect = "SELECT strPartName as Name, strSerialNumber as Serial, intQuantity AS Quantity, intPartID FROM TParts" &
			" WHERE strSerialNumber LIKE '%" & txtPartSearch.Text & "%' OR" &
			" strPartDesc LIKE '%" & txtPartSearch.Text & "%' OR" &
			" strPartName LIKE '%" & txtPartSearch.Text & "%'"

		'Get records
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'Load Table
		dt.Load(drSourceTable)

		dgvAvailableParts.DataSource = dt
		dgvAssignedParts.Refresh()
		dgvAvailableParts.Columns(3).Visible = False

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
							"TP.strPartName AS Name " &
							",TP.strSerialNumber AS Serial " &
							",TJP.intPartQuantity AS Quantity " &
							",TJP.intPartID AS ID " &
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

		dgvAssignedParts.Columns(3).Visible = False

		' Clean up
		drSourceTable.Close()

		' close the database connection
		CloseDatabaseConnection()

	End Sub



	' ----------------------------------------------------------------------------------------------------------------------------------------------------------
	' DATABASE QUERIES -----------------------------------------------------------------------------------------------------------------------------------------
	' ----------------------------------------------------------------------------------------------------------------------------------------------------------

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
						"FROM TJobParts"

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
		strFindPartID = "SELECT intPartID AS intPartID FROM TParts WHERE strSerialNumber = '" & dgvAvailableParts.CurrentRow.Cells(1).Value & "'"

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

		'Retrieve data
		cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

		intRowsAffected = cmdInsert.ExecuteNonQuery()

		'Close DB
		CloseDatabaseConnection()

	End Sub

	Private Sub UpdatePartOnJob()

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
		strUpdate = "UPDATE TJobParts " &
				"SET intPartQuantity = " & dgvAssignedParts.CurrentRow.Cells(2).Value + txtAddQnty.Text &
				" WHERE intJobRecordID = " & cboJob.SelectedValue &
				" AND intPartID = " & dgvAvailableParts.CurrentRow.Cells(3).Value

		cmdUpdate = New OleDb.OleDbCommand(strUpdate, m_conAdministrator)

		intRowsAffected = cmdUpdate.ExecuteNonQuery()

		'Close DB
		CloseDatabaseConnection()

	End Sub

	Private Sub LowerAvailableQuantity()

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
				" WHERE strSerialNumber = '" & dgvAvailableParts.CurrentRow.Cells(1).Value & "'"

		cmdUpdate = New OleDb.OleDbCommand(strUpdate, m_conAdministrator)

		intRowsAffected = cmdUpdate.ExecuteNonQuery()

		'Close DB
		CloseDatabaseConnection()

	End Sub

	Private Sub RemovePartFromJob()

		Dim strDelete As String = ""
		Dim strSelect As String = ""
		Dim strFindPartID As String = ""
		Dim strInsert As String = ""
		Dim cmdDelete As OleDb.OleDbCommand
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
		' Remote Part From Job ------------------------------------------------
		' ---------------------------------------------------------------------
		strDelete = "DELETE FROM TJobParts WHERE " &
							"intJobRecordID = " & cboJob.SelectedValue &
							" AND " &
							"intPartID = " & dgvAssignedParts.CurrentRow().Cells(3).Value

		cmdDelete = New OleDb.OleDbCommand(strDelete, m_conAdministrator)

		intRowsAffected = cmdDelete.ExecuteNonQuery()

		'Close DB
		CloseDatabaseConnection()

	End Sub

	Private Sub IncreaseAvailableQuantity()

		Dim intCurrentQnty As Integer
		Dim intAmountToAdd As Integer
		Dim strUpdate As String = ""
		Dim strSelect As String = ""
		Dim strFindPartQuantity As String = ""
		Dim strInsert As String = ""
		Dim cmdSelect As OleDb.OleDbCommand
		Dim cmdUpdate As OleDb.OleDbCommand
		Dim dt As DataTable = New DataTable
		Dim drSourceTable As OleDb.OleDbDataReader
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
		' Get Current Quantity ------------------------------------------------
		' ---------------------------------------------------------------------
		'Find max value and add 1
		strFindPartQuantity = "SELECT intQuantity FROM TParts WHERE strSerialNumber = '" & dgvAssignedParts.CurrentRow.Cells(1).Value & "'"

		'Execute
		cmdSelect = New OleDb.OleDbCommand(strFindPartQuantity, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'Read
		drSourceTable.Read()

		'Assign Part ID
		intCurrentQnty = CInt(drSourceTable.Item(0))

		' ---------------------------------------------------------------------
		' Update Available Quantity -------------------------------------------
		' ---------------------------------------------------------------------

		'If remove amount....
		If dgvAssignedParts.CurrentRow.Cells(2).Value - txtRemoveQnty.Text < 0 Then

			'below zero, add the current inventory qnty
			intAmountToAdd = dgvAssignedParts.CurrentRow.Cells(2).Value

		Else
			'0 or more, add given qnty
			intAmountToAdd = txtRemoveQnty.Text

		End If

		strUpdate = "UPDATE TParts " &
				"SET intQuantity = " & intCurrentQnty + intAmountToAdd &
				" WHERE strSerialNumber = '" & dgvAssignedParts.CurrentRow.Cells(1).Value & "'"

		cmdUpdate = New OleDb.OleDbCommand(strUpdate, m_conAdministrator)

		intRowsAffected = cmdUpdate.ExecuteNonQuery()

		'Close DB
		CloseDatabaseConnection()

	End Sub

	Private Sub UpdateAssignedQuantity()

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
		strUpdate = "UPDATE TJobParts " &
				"SET intPartQuantity = " & dgvAssignedParts.CurrentRow.Cells(2).Value - txtRemoveQnty.Text &
				" WHERE intJobRecordID = " & cboJob.SelectedValue &
				" AND intPartID = " & dgvAssignedParts.CurrentRow.Cells(3).Value

		cmdUpdate = New OleDb.OleDbCommand(strUpdate, m_conAdministrator)

		intRowsAffected = cmdUpdate.ExecuteNonQuery()

		'Close DB
		CloseDatabaseConnection()

	End Sub







End Class