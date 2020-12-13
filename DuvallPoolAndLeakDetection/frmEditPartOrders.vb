' Edit Part Orders form
' Last Updated: 12/12/2020
' Last modified by Matthew Estes

Public Class frmEditPartOrders

	' Daclare public variable
	Dim intArrived As Integer
	Dim dblCostPerUnit As Double
	Dim intQuantity As Integer

	' Close form
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close form
		Me.Close()

	End Sub


	' Runs when program is loaded
	Private Sub frmPreviousOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try
			' Load parts
			LoadParts()
		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub


	' Load part list
	Private Sub LoadParts()

		Try
			' Declare variables
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

			cboPartName.BeginUpdate()

			'Create select
			strSelect = "SELECT intPartID, strPartName FROM TParts ORDER BY strPartName ASC"

			'Get records
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load Table
			dt.Load(drSourceTable)

			' Add items to combo box
			cboPartName.ValueMember = "intPartID"
			cboPartName.DisplayMember = "strPartName"
			cboPartName.DataSource = dt

			' Select the first item in the list by default
			If cboPartName.Items.Count > 0 Then cboPartName.SelectedIndex = 0

			' Show changes
			cboPartName.EndUpdate()

			' Clean up
			drSourceTable.Close()

			' close the database connection
			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try
	End Sub


	' Load order list
	Private Sub LoadOrders()

		Try
			' Declare variables
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

			cboOrderNumber.BeginUpdate()

			'Create select
			strSelect = "SELECT intPartOrderedID, PONumber FROM TPartsOrders WHERE intPartID = " & cboPartName.SelectedValue & " ORDER BY PONumber DESC"

			'Get records
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load Table
			dt.Load(drSourceTable)

			' Add items to combo box
			cboOrderNumber.ValueMember = "intPartOrderedID"
			cboOrderNumber.DisplayMember = "PONumber"
			cboOrderNumber.DataSource = dt

			' Select the first item in the list by default
			If cboOrderNumber.Items.Count > 0 Then cboOrderNumber.SelectedIndex = 0

			' Show changes
			cboOrderNumber.EndUpdate()

			' Clean up
			drSourceTable.Close()

			' close the database connection
			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try
	End Sub


	' Runs when PartName selected is changed
	Private Sub cboPartName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPartName.SelectedIndexChanged
		' Load orders related to that part
		LoadOrders()
	End Sub


	' Runs when OrderNumber selected is changed
	Private Sub cboOrderNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrderNumber.SelectedIndexChanged

		Try
			' Declare variables
			Dim strSelect As String = ""
			Dim strPartName As String = ""
			Dim dblTotalPurchaseCost As Double
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
			strSelect = "SELECT * FROM vPartOrders WHERE intPartOrderedID = " & cboOrderNumber.SelectedValue.ToString

			'Retrieve
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load from table
			dt.Load(drSourceTable)

			'Populate labels and CBO
			lblSerialNumber.Text = dt.Rows(0).Item(1).ToString
			lblPartDescription.Text = dt.Rows(0).Item(2).ToString
			txtQuantity.Text = dt.Rows(0).Item(3).ToString
			lblTotalPurchaseCost.Text = "$" + dt.Rows(0).Item(4).ToString
			lblVendorName.Text = dt.Rows(0).Item(5).ToString
			lblContactName.Text = dt.Rows(0).Item(6).ToString
			lblAddress.Text = dt.Rows(0).Item(7).ToString
			lblCity.Text = dt.Rows(0).Item(8).ToString
			lblState.Text = dt.Rows(0).Item(9).ToString
			lblZip.Text = dt.Rows(0).Item(10).ToString
			lblEmail.Text = dt.Rows(0).Item(11).ToString
			lblPhone.Text = dt.Rows(0).Item(12).ToString
			dtDateOrdered.Text = dt.Rows(0).Item(13).ToString
			dtDateDelivered.Text = dt.Rows(0).Item(14).ToString
			intArrived = CInt(dt.Rows(0).Item(15))

			dblTotalPurchaseCost = CDbl(lblTotalPurchaseCost.Text)
			intQuantity = CInt(txtQuantity.Text)
			dblCostPerUnit = dblTotalPurchaseCost / CDbl(intQuantity)

			' Check if it is arrived
			If intArrived = 1 Then

				' Set delivered to true
				radDelivered.Checked = True
			Else

				' Set delivered to false
				radTransit.Checked = True
			End If
			'Close DB connection
			CloseDatabaseConnection()

		Catch ex As Exception

		End Try
	End Sub


	' Submit update
	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		Try

			If Validation() = True Then
				' Declare variables
				Dim strSelect As String = ""
				Dim strName As String = ""
				Dim intPartQuantity As Integer
				Dim intPartQuantityBackordered As Integer
				Dim intRowsAffected As Integer
				Dim dblTotalPurchaseCost As Double = 0
				Dim cmdSelect As OleDb.OleDbCommand 'Select
				Dim drSourceTable As OleDb.OleDbDataReader 'retrieved data
				Dim strUpdate As String
				Dim cmdUpdate As OleDb.OleDbCommand
				Dim cmdUpdate2 As OleDb.OleDbCommand
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

				'SELECT
				strSelect = "SELECT intQuantity, intQuantityBackordered, intPartID FROM TParts WHERE intPartID = " & cboPartName.SelectedValue.ToString

				'Retrieve
				cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
				drSourceTable = cmdSelect.ExecuteReader

				'Load from table
				dt.Load(drSourceTable)

				' Load info
				intPartQuantity = CInt(dt.Rows(0).Item(0))
				intPartQuantityBackordered = CInt(dt.Rows(0).Item(1))

				' Set quantity amounts
				If radDelivered.Checked = True And intArrived = 0 Then

					' If it just now got delivered
					intPartQuantityBackordered -= intQuantity
					intQuantity = CInt(txtQuantity.Text)
					intPartQuantity += intQuantity

				ElseIf radTransit.Checked = True And intArrived = 1 Then

					' If shipment was thought to be arrived but it wasn't
					intPartQuantity -= intQuantity
					intQuantity = CInt(txtQuantity.Text)
					intPartQuantityBackordered += intQuantity

				ElseIf radDelivered.Checked = True Then

					' If it just now got delivered
					intPartQuantity -= intQuantity
					intQuantity = CInt(txtQuantity.Text)
					intPartQuantity += intQuantity

				ElseIf radTransit.Checked = True Then

					' If it just now got delivered
					intPartQuantityBackordered -= intQuantity
					intQuantity = CInt(txtQuantity.Text)
					intPartQuantityBackordered += intQuantity
				End If

				'Create update statement
				strUpdate = "UPDATE TParts " &
					"SET intQuantity = " & intPartQuantity & ", " &
						"intQuantityBackordered = " & intPartQuantityBackordered &
					" WHERE intPartID = " & cboPartName.SelectedValue

				' Update database
				cmdUpdate = New OleDb.OleDbCommand(strUpdate, m_conAdministrator)
				intRowsAffected = cmdUpdate.ExecuteNonQuery()

				If intRowsAffected > 0 Then
					MessageBox.Show("Update parts successful.")
					Me.Close()
				End If

				' Reset rows affected
				intRowsAffected = 0

				' Set Total purchase cost
				dblTotalPurchaseCost = dblCostPerUnit * CDbl(intQuantity)

				' Set arrived for update
				If radDelivered.Checked = True Then
					intArrived = 1
				Else
					intArrived = 0
				End If

				'Create update statement
				strUpdate = "UPDATE TPartsOrders " &
					"SET dtDateOrdered = '" & dtDateOrdered.Value & "', " &
						"dtDateArrived = '" & dtDateDelivered.Value & "', " &
						"blnArrived = " & intArrived & ", " &
						"intQuantity = " & intQuantity & ", " &
						"decUnitPurchaseCost = " & dblTotalPurchaseCost & " " &
					"WHERE intPartOrderedID = " & cboOrderNumber.SelectedValue

				' Update database
				cmdUpdate2 = New OleDb.OleDbCommand(strUpdate, m_conAdministrator)
				intRowsAffected = cmdUpdate2.ExecuteNonQuery()

				If intRowsAffected > 0 Then
					MessageBox.Show("Update orders successful.")
					Me.Close()
				End If

				CloseDatabaseConnection()
			End If
		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try
	End Sub


	' Runs validation on text boxes and radio buttons
	Function Validation() As Boolean

		txtQuantity.BackColor = Color.White

		' check if something is entered in quantity text box
		If txtQuantity.Text <> String.Empty Then
			'Check for numeric value
			If IsNumeric(txtQuantity.Text) = True Then
			Else
				MessageBox.Show("Please enter numeric value for quantity.")
				txtQuantity.BackColor = Color.Yellow
				txtQuantity.Focus()
				Return False
			End If
		Else
			' text box is blank so tell user to enter quantity, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter quantity.")
			txtQuantity.BackColor = Color.Yellow
			txtQuantity.Focus()
			Return False
		End If

		' check if shipping is checked
		If radTransit.Checked = True Or radDelivered.Checked = True Then

		Else
			' Tell user to check one
			MessageBox.Show("Please select shipping progress.")
			Return False
		End If

		Return True ' all is well in the world
	End Function
End Class