' Invetory Management form
' Last Updated: 11/23/2020
' Last modified by Matthew Thompson

Public Class frmInventoryManagement
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close form
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
			strSelect = "SELECT intPartID, strPartName FROM TParts ORDER BY strPartName ASC"

			'Get RECORDS
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load the Table
			dt.Load(drSourceTable)

			'Add to CBO
			cboPartName.ValueMember = "intPartID"
			cboPartName.DisplayMember = "strPartName"
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
			lblSerialNumber.Text = dt.Rows(0).Item(2).ToString
			lblPartDescription.Text = dt.Rows(0).Item(3).ToString
			lblQuantity.Text = dt.Rows(0).Item(4).ToString
			lblBackorderedQuantity.Text = dt.Rows(0).Item(5).ToString
			lblPartCostBus.Text = "$" & dt.Rows(0).Item(6).ToString
			lblPartCostCust.Text = "$" & dt.Rows(0).Item(7).ToString
			lblVendorName.Text = dt.Rows(0).Item(8).ToString
			lblContactName.Text = dt.Rows(0).Item(9).ToString
			lblAddress.Text = dt.Rows(0).Item(10).ToString
			lblCity.Text = dt.Rows(0).Item(11).ToString
			lblState.Text = dt.Rows(0).Item(12).ToString
			lblZip.Text = dt.Rows(0).Item(13).ToString
			lblEmail.Text = dt.Rows(0).Item(14).ToString
			lblPhone.Text = dt.Rows(0).Item(15).ToString

			'Close DB connection
			CloseDatabaseConnection()

		Catch ex As Exception

		End Try

	End Sub

	Private Sub btnEditInventory_Click(sender As Object, e As EventArgs) Handles btnEditInventory.Click

		' create a new instance of the edit inventory form
		Dim EditInventory As New frmEditInventory

		' show the new form so any past data is not still on the form
		EditInventory.ShowDialog()

		'Reload inventory info after update
		cboPartName_SelectedIndexChanged(sender, e)
	End Sub

End Class
