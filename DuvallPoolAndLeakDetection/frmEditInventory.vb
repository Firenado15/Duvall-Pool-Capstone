Public Class frmEditInventory
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' Close form
        Close()

    End Sub

	' Runs when program is loaded
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
			txtSerialNumber.Text = dt.Rows(0).Item(2).ToString
			txtPartDescription.Text = dt.Rows(0).Item(3).ToString
			txtQuantity.Text = dt.Rows(0).Item(4).ToString
			txtQuantityBackordered.Text = dt.Rows(0).Item(5).ToString
			txtPartCostBus.Text = "$" & dt.Rows(0).Item(6).ToString
			txtPartCostCust.Text = "$" & dt.Rows(0).Item(7).ToString
			lblVendorName.Text = dt.Rows(0).Item(8).ToString
			lblContactName.Text = dt.Rows(0).Item(9).ToString
			lblAddress.Text = dt.Rows(0).Item(10).ToString
			lblCity.Text = dt.Rows(0).Item(11).ToString
			lblState.Text = dt.Rows(0).Item(12).ToString
			lblZip.Text = dt.Rows(0).Item(13).ToString
			lblEmail.Text = dt.Rows(0).Item(14).ToString
			lblPhone.Text = dt.Rows(0).Item(15).ToString
			txtPartName.Text = dt.Rows(0).Item(16).ToString

			'Close DB connection
			CloseDatabaseConnection()

		Catch ex As Exception

		End Try

	End Sub

	' Validates whether all text fiels are filled
	Function Validation() As Boolean
		txtPartName.BackColor = Color.White
		txtSerialNumber.BackColor = Color.White
		txtPartDescription.BackColor = Color.White
		txtQuantity.BackColor = Color.White
		txtQuantityBackordered.BackColor = Color.White
		txtPartCostBus.BackColor = Color.White
		txtPartCostCust.BackColor = Color.White

		' check if something is entered in part name text box
		If txtPartName.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter serial number, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter part name.")
			txtPartName.BackColor = Color.Yellow
			txtPartName.Focus()
			Return False
		End If

		' check if something is entered in serial number text box
		If txtSerialNumber.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter serial number, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter serial number.")
			txtSerialNumber.BackColor = Color.Yellow
			txtSerialNumber.Focus()
			Return False
		End If

		' check if something is entered in part description text box
		If txtPartDescription.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter part description, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter part description.")
			txtPartDescription.BackColor = Color.Yellow
			txtPartDescription.Focus()
			Return False
		End If

		' check if something is entered in quantity text box
		If txtQuantity.Text <> String.Empty And IsNumeric(txtQuantity.Text) Then

		Else
			' text box is blank so tell user to enter quantity, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter quantity.")
			txtQuantity.BackColor = Color.Yellow
			txtQuantity.Focus()
			Return False
		End If

		' check if something is entered in quantity backordered text box
		If txtQuantityBackordered.Text <> String.Empty And IsNumeric(txtQuantityBackordered.Text) Then

		Else
			' text box is blank so tell user to enter quantity backordered, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter quantity backordered.")
			txtQuantityBackordered.BackColor = Color.Yellow
			txtQuantityBackordered.Focus()
			Return False
		End If

		' check if something is entered in business part cost box
		If txtPartCostBus.Text <> String.Empty And IsNumeric(txtPartCostBus.Text) Then

		Else
			' text box is blank so tell user to enter business part cost, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter business part cost.")
			txtPartCostBus.BackColor = Color.Yellow
			txtPartCostBus.Focus()
			Return False
		End If

		' check if something is entered in customer part cost text box
		If txtPartCostCust.Text <> String.Empty And IsNumeric(txtPartCostCust.Text) Then

		Else
			' text box is blank so tell user to enter customer part cost, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter customer part cost.")
			txtPartCostCust.BackColor = Color.Yellow
			txtPartCostCust.Focus()
			Return False
		End If

		Return True ' all is well in the world

	End Function

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

		' Declare variables
		Dim strUpdate As String
		Dim strSerialNumber As String = ""
		Dim strPartDescription As String = ""
		Dim strQuantity As String = ""
		Dim strQuantityBackordered As String = ""
		Dim strPartCostBus As String = ""
		Dim strPartCostCust As String = ""
		Dim cmdUpdate As OleDb.OleDbCommand
		Dim intRowsAffected As Integer

		Try

			If Validation() = True Then

				' Set values
				strSerialNumber = txtSerialNumber.Text
				strPartDescription = txtPartDescription.Text
				strQuantity = txtQuantity.Text
				strQuantityBackordered = txtQuantityBackordered.Text
				strPartCostBus = txtPartCostBus.Text
				strPartCostCust = txtPartCostCust.Text

				If OpenDatabaseConnectionSQLServer() = False Then

					'Alert if no connection
					MessageBox.Show(Me, "Database connection error." & vbNewLine &
										"The application will now close.",
										Me.Text + " Error",
										MessageBoxButtons.OK, MessageBoxIcon.Error)

					'Close Form
					Me.Close()

				End If


				'Create update statement
				strUpdate = "UPDATE TParts " &
					"SET strSerialNumber = '" & strSerialNumber & "', " &
						"strPartDesc = '" & strPartDescription & "', " &
						"intQuantityBackordered = " & strQuantityBackordered & ", " &
						"intQuantity = " & strQuantity & ", " &
						"decUnitPurchaseCost = " & strPartCostBus & ", " &
						"decUnitSaleCost = " & strPartCostCust &
					" WHERE intPartID = " & cboPartName.SelectedValue

				cmdUpdate = New OleDb.OleDbCommand(strUpdate, m_conAdministrator)

				intRowsAffected = cmdUpdate.ExecuteNonQuery()

				If intRowsAffected > 0 Then
					MessageBox.Show("Part info has been updated.")
					Me.Close()
				End If

				CloseDatabaseConnection()

			End If

		Catch ex As Exception
			'unhandled exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub
End Class