' Invetory Management form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmInventoryManagement
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close program
		Close()

	End Sub

	Private Sub frmInventoryManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try

			Dim strSelect As String = ""
			Dim cmdSelect As OleDb.OleDbCommand
			Dim drSourceTable As OleDb.OleDbDataReader
			Dim dt As DataTable = New DataTable

			'Delete all data from boxes
			For Each cntrl As Control In Controls
				If TypeOf cntrl Is TextBox Then
					cntrl.Text = String.Empty
				End If
			Next

			'Open the DB
			If OpenDatabaseConnectionSQLServer() = False Then

				'If DB doesn't open
				MessageBox.Show(Me, "Database connection error." & vbNewLine &
								"The application will now close.",
								Me.Text + " Error",
								MessageBoxButtons.OK, MessageBoxIcon.Error)
				Me.Close()
			End If

			cboPartName.BeginUpdate()

			'Create SELECT statement
			strSelect = "SELECT intPartID, (strPartDesc) AS PartName FROM TParts ORDER BY PartName ASC"

			'Get RECORDS
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load the Table
			dt.Load(drSourceTable)

			'Add to CBO
			cboPartName.ValueMember = "intPartID"
			cboPartName.DisplayMember = "PartName"
			cboPartName.DataSource = dt

			'Select first index
			If cboPartName.Items.Count > 0 Then cboPartName.SelectedIndex = 0

			'Show updates
			cboPartName.EndUpdate()

			'Clean up
			drSourceTable.Close()

			'Close the DB connection
			CloseDatabaseConnection()

		Catch ex As Exception

		End Try

	End Sub

	Private Sub cboPartName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPartName.SelectedIndexChanged

		Try

			Dim strSelect As String = ""
			Dim strPartName As String = ""
			Dim cmdSelect As OleDb.OleDbCommand
			Dim drSourceTable As OleDb.OleDbDataReader
			Dim dt As DataTable = New DataTable

			'Open the DB
			If OpenDatabaseConnectionSQLServer() = False Then

				' No connection error
				MessageBox.Show(Me, "Database connection error." & vbNewLine &
									"The application will now close.",
									Me.Text + " Error",
									MessageBoxButtons.OK, MessageBoxIcon.Error)

				'close the form
				Me.Close()

			End If

			'SELECT
			strSelect = "SELECT * FROM vParts WHERE intPartID = " & cboPartName.SelectedValue.ToString

			'Retrieve
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load from table
			dt.Load(drSourceTable)

			'Populate labels and CBO
			cboSerialNumber.ValueMember = "strSerialNumber"
			cboSerialNumber.DisplayMember = "strSerialNumber"
			cboSerialNumber.DataSource = dt
			lblPartDescription.Text = dt.Rows(0).Item(3).ToString
			lblQuantity.Text = dt.Rows(0).Item(4).ToString
			lblPartCostBus.Text = dt.Rows(0).Item(5).ToString
			lblPartCostCust.Text = dt.Rows(0).Item(6).ToString
			lblYTDSold.Text = dt.Rows(0).Item(7).ToString

			'Close DB connection
			CloseDatabaseConnection()

		Catch ex As Exception

		End Try

	End Sub

End Class