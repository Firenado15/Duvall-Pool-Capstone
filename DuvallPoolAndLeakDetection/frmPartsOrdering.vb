' Parts Ordering form
' Last Updated: 12/12/2020
' Last modified by Matthew Estes

Public Class frmPartsOrdering

	' Declare public varaible
	Dim intNewVendorID As Integer
	Dim intNewPartID As Integer
	Dim blnChanged As Boolean = False

	' Close form
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close form
		Close()

	End Sub

	' Runs when sumbit is clicked
	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		' After Validation, run submit and assign values to variables
		If Validation() = True Then

			' Both vendor and part aren't checked
			If radNo.Checked = True And radPartNo.Checked = True Then

				' Insert new vendor
				InsertNewVendor()

				' Insert part
				InsertParts(intNewVendorID)

				' Insert order
				InsertOrder(intNewPartID)

				'Close form
				Me.Close()

				' Only vendor is checked
			ElseIf radYes.Checked = True And radPartNo.Checked = True Then

				' Insert part
				InsertParts(cboVendor.SelectedValue)

				' Insert order
				InsertOrder(intNewPartID)

				'Close form
				Me.Close()

				' Only part is checked
			ElseIf radYes.Checked = False And radPartYes.Checked = True Then

				' Insert new vendor
				InsertNewVendor()

				' Update part
				UpdatePart()

				' Insert order
				InsertOrder(intNewPartID)

				'Close form
				Me.Close()

				' Both are checked
			Else

				' Update part
				UpdatePart()

				' Insert order
				InsertOrder(intNewPartID)

				'Close form
				Me.Close()

			End If

		End If

	End Sub

	' Insert new vendor
	Private Sub InsertNewVendor()

		'Variables
		Dim strVendorName As String = ""
		Dim strContactName As String = ""
		Dim strAddress As String = ""
		Dim strCity As String = ""
		Dim intState As Integer = 0
		Dim strZip As String = ""
		Dim strPhoneNumber As String = ""
		Dim strEmail As String = ""
		Dim strSelect As String
		Dim strInsert As String
		Dim cmdSelect As OleDb.OleDbCommand
		Dim cmdInsert As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim intNextHighestRecordID As Integer
		Dim intRowsAffected As Integer

		Try
			' Assign variables
			strVendorName = txtVendorName.Text
			strContactName = txtContactName.Text
			strAddress = txtAddress.Text
			strCity = txtCity.Text
			intState = cboState.SelectedValue
			strZip = txtZip.Text
			strPhoneNumber = txtPhone.Text
			strEmail = txtEmail.Text



			If OpenDatabaseConnectionSQLServer() = False Then

				'Alert if no connection
				MessageBox.Show(Me, "Database connection error." & vbNewLine &
										"The application will now close.",
										Me.Text + " Error",
										MessageBoxButtons.OK, MessageBoxIcon.Error)

				'Close Form
				Me.Close()

			End If

			strSelect = "SELECT MAX(intVendorID) + 1 AS intNextHighestRecordID FROM TVendors"

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

			'set variable to be used by parts insert
			intNewVendorID = intNextHighestRecordID

			'Create insert statement
			strInsert = "Insert into TVendors" &
					" Values (" & intNextHighestRecordID & ",'" & strVendorName & "'," & "'" & strContactName & "'," & "'" & strAddress & "'," & "'" & strCity &
					"','" & cboState.SelectedValue.ToString & "','" & strZip & "','" & strPhoneNumber & "','" & strEmail & "')"

			cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

			intRowsAffected = cmdInsert.ExecuteNonQuery()

			If intRowsAffected > 0 Then
				MessageBox.Show("Vendor has been added.")
				Me.Close()
			End If

			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	' Insert new part
	Private Sub InsertParts(ByVal intVendorID As Integer)

		'Variables
		Dim strSerialNumber As String = ""
		Dim strPartName As String = ""
		Dim strPartDesc As String = ""
		Dim intQuantity As Integer = 0
		Dim intQuantityBackordered As Integer = 0
		Dim decUnitCostBus As Double = 0
		Dim decUnitCostCust As Double = 0
		Dim strSelect As String
		Dim strInsert As String
		Dim cmdSelect As OleDb.OleDbCommand
		Dim cmdInsert As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim intNextHighestRecordID As Integer
		Dim intRowsAffected As Integer

		Try
			' Set variable 
			strSerialNumber = txtSerialNumber.Text
			strPartName = txtPartName.Text
			strPartDesc = txtPartName.Text
			decUnitCostBus = CDbl(txtUnitCostBus.Text)
			decUnitCostCust = CDbl(txtUnitCostCust.Text)

			' Check if the parts are delivered yet
			If radDelivered.Checked = True Then
				' If so, add it to quantity
				intQuantity = CInt(txtQuantity.Text)

			Else
				' if not add it to quantity back ordered
				intQuantityBackordered = CInt(txtQuantity.Text)

			End If
			If OpenDatabaseConnectionSQLServer() = False Then

				'Alert if no connection
				MessageBox.Show(Me, "Database connection error." & vbNewLine &
										"The application will now close.",
										Me.Text + " Error",
										MessageBoxButtons.OK, MessageBoxIcon.Error)

				'Close Form
				Me.Close()

			End If

			strSelect = "SELECT MAX(intPartID) + 1 AS intNextHighestRecordID FROM TParts"

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

			'set variable to be used by part orders insert
			intNewPartID = intNextHighestRecordID

			'Create insert statement
			strInsert = "Insert into TParts" &
					" Values (" & intNextHighestRecordID & ", " & intVendorID & ", '" & strSerialNumber & "', '" & strPartName & "', '" & strPartDesc & "', " & intQuantityBackordered &
						", " & intQuantity & ", " & decUnitCostBus & ", " & decUnitCostCust & ")"

			cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

			intRowsAffected = cmdInsert.ExecuteNonQuery()

			If intRowsAffected > 0 Then
				MessageBox.Show("Part has been added.")
				Me.Close()
			End If

			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try
	End Sub

	' Insert new part
	Private Sub InsertOrder(ByVal intPartID As Integer)

		'Variables
		Dim dtDateOfOrder As Date
		Dim dtDateOfArrival As Date
		Dim intQuantity As Integer = 0
		Dim decUnitCostBus As Double = 0
		Dim decUnitPurchaseCost As Double
		Dim intArrived As Integer
		Dim strSelect As String
		Dim strInsert As String
		Dim cmdSelect As OleDb.OleDbCommand
		Dim cmdInsert As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim intNextHighestRecordID As Integer
		Dim intRowsAffected As Integer

		Try
			' Set variable
			dtDateOfOrder = dtDateOrdered.Value
			dtDateOfArrival = dtDateDelivered.Value
			intQuantity = CInt(txtQuantity.Text)

			' Check if part radio button is checked
			If radPartYes.Checked = True Then
				decUnitCostBus = CDbl(lblCostPerUnitBus.Text)
			Else
				decUnitCostBus = CDbl(txtUnitCostBus.Text)
			End If

			' Calculate Purchase cost
			decUnitPurchaseCost = decUnitCostBus * intQuantity

			' Check if delivery has happened
			If radDelivered.Checked = True Then
				' Set arrived to true
				intArrived = 1

			Else
				' Set arrived to false
				intArrived = 0

			End If

			If OpenDatabaseConnectionSQLServer() = False Then

				'Alert if no connection
				MessageBox.Show(Me, "Database connection error." & vbNewLine &
										"The application will now close.",
										Me.Text + " Error",
										MessageBoxButtons.OK, MessageBoxIcon.Error)

				'Close Form
				Me.Close()

			End If

			strSelect = "SELECT MAX(intPartOrderedID) + 1 AS intNextHighestRecordID FROM TPartsOrders"

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
			strInsert = "Insert into TPartsOrders" &
					" Values (" & intNextHighestRecordID & ", " & intPartID & ", '" & dtDateOfOrder & "', '" & dtDateOfArrival & "', " & intArrived & ", " &
					intQuantity & ", " & decUnitPurchaseCost & ")"

			cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

			intRowsAffected = cmdInsert.ExecuteNonQuery()

			If intRowsAffected > 0 Then
				MessageBox.Show("Order has been added.")
				Me.Close()
			End If

			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try
	End Sub

	' Update existing part
	Private Sub UpdatePart()

		'Variables
		Dim intQuantity As Integer = 0
		Dim intQuantityTotal As Integer = 0
		Dim intQuantityBackordered As Integer = 0
		Dim intQuantityBackorderedTotal As Integer = 0
		Dim strSelect As String
		Dim strUpdate As String
		Dim cmdSelect As OleDb.OleDbCommand
		Dim cmdUpdate As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim dt As DataTable = New DataTable
		Dim intRowsAffected As Integer

		Try

			' Check if the parts are delivered yet
			If radDelivered.Checked = True Then
				' If so, add it to quantity
				intQuantity = CInt(txtQuantity.Text)

			Else
				' if not add it to quantity back ordered
				intQuantityBackordered = CInt(txtQuantity.Text)

			End If
			If OpenDatabaseConnectionSQLServer() = False Then

				'Alert if no connection
				MessageBox.Show(Me, "Database connection error." & vbNewLine &
										"The application will now close.",
										Me.Text + " Error",
										MessageBoxButtons.OK, MessageBoxIcon.Error)

				'Close Form
				Me.Close()

			End If

			'SELECT
			strSelect = "SELECT intQuantity, intQuantityBackordered FROM TParts WHERE intPartID = " & cboPartName.SelectedValue.ToString

			'Retrieve
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load from table
			dt.Load(drSourceTable)

			'Populate labels and CBO
			intQuantityTotal = CInt(dt.Rows(0).Item(0))
			intQuantityBackorderedTotal = CInt(dt.Rows(0).Item(1))

			' Set values
			intQuantityTotal += intQuantity
			intQuantityBackorderedTotal += intQuantityBackordered

			'Create insert statement
			'Create update statement
			strUpdate = "UPDATE TParts " &
					"SET intQuantityBackordered = " & intQuantityBackorderedTotal & ", " &
						"intQuantity = " & intQuantityTotal &
					" WHERE intPartID = " & cboPartName.SelectedValue

			cmdUpdate = New OleDb.OleDbCommand(strUpdate, m_conAdministrator)

			intRowsAffected = cmdUpdate.ExecuteNonQuery()

			If intRowsAffected > 0 Then
				MessageBox.Show("Part info has been updated.")
				Me.Close()
			End If

			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try
	End Sub


	' Runs validation on text boxes and radio buttons
	Function Validation() As Boolean

		txtVendorName.BackColor = Color.White
		txtContactName.BackColor = Color.White
		txtAddress.BackColor = Color.White
		txtCity.BackColor = Color.White
		txtZip.BackColor = Color.White
		txtEmail.BackColor = Color.White
		txtPhone.BackColor = Color.White
		txtSerialNumber.BackColor = Color.White
		txtPartName.BackColor = Color.White
		txtPartDescription.BackColor = Color.White
		txtQuantity.BackColor = Color.White
		txtUnitCostBus.BackColor = Color.White
		txtUnitCostCust.BackColor = Color.White

		' only validate vendor input if for new vendor
		If radNo.Checked = True Then

			' check if something is entered in vendor name text box
			If txtVendorName.Text <> String.Empty Then

			Else
				' text box is blank so tell user to enter vendor name, change back color to yellow,
				' put focus in text box and return false we don't want to continue
				MessageBox.Show("Please enter Vendor's name.")
				txtVendorName.BackColor = Color.Yellow
				txtVendorName.Focus()
				Return False
			End If

			' check if something is entered in contact name text box
			If txtContactName.Text <> String.Empty Then

			Else
				' text box is blank so tell user to enter contact name, change back color to yellow,
				' put focus in text box and return false we don't want to continue
				MessageBox.Show("Please enter Contact's name.")
				txtContactName.BackColor = Color.Yellow
				txtContactName.Focus()
				Return False
			End If

			' check if something is entered in street address text box
			If txtAddress.Text <> String.Empty Then

			Else
				' text box is blank so tell user to enter street address, change back color to yellow,
				' put focus in text box and return false we don't want to continue
				MessageBox.Show("Please enter Vendor's street address.")
				txtAddress.BackColor = Color.Yellow
				txtAddress.Focus()
				Return False
			End If

			' check if something is entered in city text box
			If txtCity.Text <> String.Empty Then

			Else
				' text box is blank so tell user to enter city, change back color to yellow,
				' put focus in text box and return false we don't want to continue
				MessageBox.Show("Please enter Vendor's city.")
				txtCity.BackColor = Color.Yellow
				txtCity.Focus()
				Return False
			End If

			' check if something is entered in zip text box
			If txtZip.Text <> String.Empty Then
				'Check for numeric value
				If IsNumeric(txtZip.Text) = True Then
				Else
					MessageBox.Show("Please enter numeric value for zip.")
					txtZip.BackColor = Color.Yellow
					txtZip.Focus()
					Return False
				End If
			Else
				' text box is blank so tell user to enter zip, change back color to yellow,
				' put focus in text box and return false we don't want to continue
				MessageBox.Show("Please enter Vendor's zip.")
				txtZip.BackColor = Color.Yellow
				txtZip.Focus()
				Return False
			End If

			' check if something is entered in phone number text box
			If txtPhone.Text <> String.Empty Then

			Else
				' text box is blank so tell user to enter phone number, change back color to yellow,
				' put focus in text box and return false we don't want to continue
				MessageBox.Show("Please enter Vendor's phone number.")
				txtPhone.BackColor = Color.Yellow
				txtPhone.Focus()
				Return False
			End If

			' check if something is entered in email text box
			If txtEmail.Text <> String.Empty Then

			Else
				' text box is blank so tell user to enter email, change back color to yellow,
				' put focus in text box and return false we don't want to continue
				MessageBox.Show("Please enter Vendor's email.")
				txtEmail.BackColor = Color.Yellow
				txtEmail.Focus()
				Return False
			End If
		End If

		If radPartNo.Checked = True Then

			' check if something is entered in part name text box
			If txtPartName.Text <> String.Empty Then

			Else
				' text box is blank so tell user to enter part name, change back color to yellow,
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

			' check if something is entered in business cost per unit text box
			If txtUnitCostBus.Text <> String.Empty Then
				' Check for numric value
				If IsNumeric(txtUnitCostBus.Text) = True Then
				Else
					MessageBox.Show("Please enter numeric values only for business cost.")
					txtUnitCostBus.BackColor = Color.Yellow
					txtUnitCostBus.Focus()
					Return False
				End If
			Else
				' text box is blank so tell user to enter business cost per unit, change back color to yellow,
				' put focus in text box and return false we don't want to continue
				MessageBox.Show("Please enter business cost per unit.")
				txtUnitCostBus.BackColor = Color.Yellow
				txtUnitCostBus.Focus()
				Return False
			End If

			' check if something is entered in customer cost per unit text box
			If txtUnitCostCust.Text <> String.Empty Then
				' Check for numric value
				If IsNumeric(txtUnitCostCust.Text) = True Then
				Else
					MessageBox.Show("Please enter numeric values only for customer cost.")
					txtUnitCostCust.BackColor = Color.Yellow
					txtUnitCostCust.Focus()
					Return False
				End If
			Else
				' text box is blank so tell user to enter customer cost per unit, change back color to yellow,
				' put focus in text box and return false we don't want to continue
				MessageBox.Show("Please enter customer cost per unit.")
				txtUnitCostCust.BackColor = Color.Yellow
				txtUnitCostCust.Focus()
				Return False
			End If

		End If

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

		' Validate vendor exist
		If radYes.Checked = True Then

			' Check all labels
			If lblAddress.Text <> String.Empty And lblCity.Text <> String.Empty And lblContactName.Text <> String.Empty And
				lblState.Text <> String.Empty And lblZip.Text <> String.Empty And lblPhone.Text <> String.Empty And lblEmail.Text <> String.Empty Then

			Else
				' Tell user to pick a vendor
				MessageBox.Show("Please enter a valid vendor.")
			End If

		End If

		' Validate part exist
		If radPartYes.Checked = True Then

			' Check all labels
			If lblSerialNumber.Text <> String.Empty And lblPartDescription.Text <> String.Empty And
				lblCostPerUnitBus.Text <> String.Empty And lblCostPerUnitCust.Text <> String.Empty Then

			Else
				' Tell user to enter valid part
				MessageBox.Show("Please enter a valid part.")
			End If
		End If

		' check if shipping is checked
		If radTransit.Checked = True Or radDelivered.Checked = True Then

		Else
			' Tell user to check one
			MessageBox.Show("Please select shipping progress.")
			Return False
		End If

		' check if verify is checked
		If chkVerify.Checked = True Then

		Else
			' Tell user to check one
			MessageBox.Show("Please verify all info.")
			Return False
		End If

		' check if either radio button is checked
		If radYes.Checked = True Or radPartYes.Checked = True Then

			' check if combo box is changed
			If blnChanged = True Then

			Else
				' Tell user to check one
				MessageBox.Show("Please select a part and vendor.")
				Return False
			End If
		End If

		Return True ' all is well in the world
	End Function

	' Loads state combo box
	Private Sub LoadStates()

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

		cboState.BeginUpdate()

		'Create select
		strSelect = "SELECT intStateID, strState FROM TStates"

		'Get records
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'Load Table
		dt.Load(drSourceTable)

		' Add items to combo box
		cboState.ValueMember = "intStateID"
		cboState.DisplayMember = "strState"
		cboState.DataSource = dt

		' Select the first item in the list by default
		If cboState.Items.Count > 0 Then cboState.SelectedIndex = 0

		' Show changes
		cboState.EndUpdate()

		' Clean up
		drSourceTable.Close()

		' close the database connection
		CloseDatabaseConnection()

	End Sub

	' Load part combo box 
	Private Sub LoadParts()

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

	' Loads vendor information
	Private Sub cboVendor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVendor.SelectedIndexChanged

		Try
			' Load list
			LoadCurrentVendor()

			If radYes.Checked = True Then

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

				' Fix changed
				blnChanged = True

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
				strSelect = "SELECT intPartID, strPartName FROM TParts WHERE intVendorID = " & cboVendor.SelectedValue & "ORDER BY strPartName ASC "

				'Get records
				cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
				drSourceTable = cmdSelect.ExecuteReader

				'Load Table
				dt.Load(drSourceTable)

				' Add items to combo box
				cboPartName.ValueMember = "intPartID"
				cboPartName.DisplayMember = "strPartName"
				cboPartName.DataSource = dt

				If dt.Rows.Count = 0 Then
					lblSerialNumber.Text = ""
					lblPartDescription.Text = ""
				End If

				' Select the first item in the list by default
				If cboPartName.Items.Count > 0 Then cboPartName.SelectedIndex = 0

				' Show changes
				cboPartName.EndUpdate()

				' Clean up
				drSourceTable.Close()

				' close the database connection
				CloseDatabaseConnection()

			End If

		Catch ex As Exception

			MessageBox.Show(ex.Message)
		End Try

	End Sub

	' Loads current vendor
	Private Sub LoadCurrentVendor()

		Dim strSelect As String = ""
		Dim strName As String = ""
		Dim cmdSelect As OleDb.OleDbCommand 'Select
		Dim drSourceTable As OleDb.OleDbDataReader 'retrieved data
		Dim dt As DataTable = New DataTable 'reader

		Try
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
			strSelect = "SELECT * FROM vVendors WHERE intVendorID = " & cboVendor.SelectedValue.ToString

			'Retrieve records 
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'load the data table from the reader
			dt.Load(drSourceTable)

			'populate text boxes
			lblContactName.Text = dt.Rows(0).Item(2).ToString
			lblAddress.Text = dt.Rows(0).Item(3).ToString
			lblCity.Text = dt.Rows(0).Item(4).ToString
			lblState.Text = dt.Rows(0).Item(5).ToString
			lblZip.Text = dt.Rows(0).Item(6).ToString
			lblPhone.Text = dt.Rows(0).Item(7).ToString
			lblEmail.Text = dt.Rows(0).Item(8).ToString

			'close connection
			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try
	End Sub

	' Runs when PartName selected is changed
	Private Sub cboPartName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPartName.SelectedIndexChanged

		Try
			' Load list
			LoadCurrentPart()

			If radPartYes.Checked = True Then

				' Declare variables
				Dim strSelect As String = ""
				Dim strPartName As String = ""
				Dim cmdSelect As OleDb.OleDbCommand
				Dim drSourceTable As OleDb.OleDbDataReader
				Dim dt As DataTable = New DataTable

				' Fix changed
				blnChanged = True

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

				'Create select
				strSelect = "SELECT intVendorID, strVendorName FROM vParts WHERE intPartID = " & intNewPartID & " ORDER BY strVendorName ASC"

				'Get records
				cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
				drSourceTable = cmdSelect.ExecuteReader

				'Load Table
				dt.Load(drSourceTable)

				' Add items to combo box
				cboVendor.ValueMember = "intVendorID"
				cboVendor.DisplayMember = "strVendorName"
				cboVendor.DataSource = dt

				If dt.Rows.Count = 0 Then
					lblAddress.Text = ""
					lblCity.Text = ""
					lblContactName.Text = ""
					lblEmail.Text = ""
					lblPhone.Text = ""
					lblState.Text = ""
				End If

				' Select the first item in the list by default
				If cboVendor.Items.Count > 0 Then cboVendor.SelectedIndex = 0

				' Show changes
				cboVendor.EndUpdate()

				' Clean up
				drSourceTable.Close()

				'Close DB connection
				CloseDatabaseConnection()

			End If

		Catch ex As Exception

		End Try

	End Sub

	' Loads current part
	Private Sub LoadCurrentPart()

		' Declare variables
		Dim strSelect As String = ""
		Dim strPartName As String = ""
		Dim cmdSelect As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim dt As DataTable = New DataTable

		Try
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
			lblCostPerUnitBus.Text = dt.Rows(0).Item(6).ToString
			lblCostPerUnitCust.Text = dt.Rows(0).Item(7).ToString

			' Set new part value
			intNewPartID = cboPartName.SelectedValue

			' Clean up
			drSourceTable.Close()

			'close connection
			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try
	End Sub

	' Runs when the form is loaded
	Private Sub frmPartsOrdering_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try

			LoadStates()

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

			cboVendor.BeginUpdate()

			'Create select
			strSelect = "SELECT intVendorID, strVendorName FROM TVendors ORDER BY strVendorName ASC"

			'Get records
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load Table
			dt.Load(drSourceTable)

			' Add items to combo box
			cboVendor.ValueMember = "intVendorID"
			cboVendor.DisplayMember = "strVendorName"
			cboVendor.DataSource = dt

			' Select the first item in the list by default
			If cboVendor.Items.Count > 0 Then cboVendor.SelectedIndex = 0

			' Show changes
			cboVendor.EndUpdate()

			' Clean up
			drSourceTable.Close()

			' Load parts
			LoadParts()

			' close the database connection
			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	' Runs when radio button No is clicked
	Private Sub radNo_CheckedChanged(sender As Object, e As EventArgs) Handles radNo.CheckedChanged

		'Turn off combo and labels and edit
		cboVendor.Visible = False
		lblContactName.Visible = False
		lblAddress.Visible = False
		lblCity.Visible = False
		lblState.Visible = False
		lblZip.Visible = False
		lblPhone.Visible = False
		lblEmail.Visible = False
		btnEditVendorInfo.Visible = False

		'Turn on text box
		txtVendorName.Visible = True
		txtContactName.Visible = True
		txtAddress.Visible = True
		txtCity.Visible = True
		cboState.Visible = True
		txtZip.Visible = True
		txtPhone.Visible = True
		txtEmail.Visible = True

	End Sub

	' Runs when radio button Yes is clicked
	Private Sub radYes_CheckedChanged(sender As Object, e As EventArgs) Handles radYes.CheckedChanged

		'Set cbo and labels and edit visible
		cboVendor.Visible = True
		lblContactName.Visible = True
		lblAddress.Visible = True
		lblCity.Visible = True
		lblState.Visible = True
		lblZip.Visible = True
		lblPhone.Visible = True
		lblEmail.Visible = True
		btnEditVendorInfo.Visible = True

		'text boxes invisible
		txtVendorName.Visible = False
		txtContactName.Visible = False
		txtAddress.Visible = False
		txtCity.Visible = False
		cboState.Visible = False
		txtZip.Visible = False
		txtPhone.Visible = False
		txtEmail.Visible = False

	End Sub

	' Runs when radio button No for parts is clicked
	Private Sub radPartNo_CheckedChanged(sender As Object, e As EventArgs) Handles radPartNo.CheckedChanged

		' Turn off combo and labels
		cboPartName.Visible = False
		lblSerialNumber.Visible = False
		lblPartDescription.Visible = False
		lblCostPerUnitBus.Visible = False
		lblCostPerUnitCust.Visible = False
		btnEditPart.Visible = False

		' Turn on text box
		txtPartName.Visible = True
		txtSerialNumber.Visible = True
		txtPartDescription.Visible = True
		txtUnitCostBus.Visible = True
		txtUnitCostCust.Visible = True

	End Sub

	' Runs when radio button Yes for parts is clicked
	Private Sub radPartYes_CheckedChanged(sender As Object, e As EventArgs) Handles radPartYes.CheckedChanged

		' Set text boxes to invisible
		txtPartName.Visible = False
		txtSerialNumber.Visible = False
		txtPartDescription.Visible = False
		txtUnitCostBus.Visible = False
		txtUnitCostCust.Visible = False

		' Turn on combo and labels
		cboPartName.Visible = True
		lblSerialNumber.Visible = True
		lblPartDescription.Visible = True
		lblCostPerUnitBus.Visible = True
		lblCostPerUnitCust.Visible = True
		btnEditPart.Visible = True

	End Sub

	' Runs if edit vendor button is clicked
	Private Sub btnEditVendorInfo_Click(sender As Object, e As EventArgs) Handles btnEditVendorInfo.Click

		Dim UpdateVendor As New frmUpdateVendorInfo(cboVendor.SelectedValue)

		' show the new form so any past data is not still on the form
		UpdateVendor.ShowDialog()

		'Relead customer info after update
		LoadCurrentVendor()

	End Sub

	' Runs if edit part button is clicked
	Private Sub btnEditPart_Click(sender As Object, e As EventArgs) Handles btnEditPart.Click

		' create a new instance of the edit inventory form
		Dim EditInventory As New frmEditInventory

		' show the new form so any past data is not still on the form
		EditInventory.ShowDialog()

		'Reload inventory info after update
		frmPartsOrdering_Load(sender, e)
	End Sub

	' Reset combo boxes
	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

		' Reset radio buttons and check boxes
		radNo.Checked = True
		radPartNo.Checked = True
		radTransit.Checked = False
		radDelivered.Checked = False
		chkVerify.Checked = False

		' Reset text boxes
		txtVendorName.Text = ""
		txtContactName.Text = ""
		txtAddress.Text = ""
		txtCity.Text = ""
		txtZip.Text = ""
		txtEmail.Text = ""
		txtPhone.Text = ""
		txtSerialNumber.Text = ""
		txtPartName.Text = ""
		txtPartDescription.Text = ""
		txtQuantity.Text = ""
		txtUnitCostBus.Text = ""
		txtUnitCostCust.Text = ""

		' Reset boolean changed
		blnChanged = False

		' Reload page
		frmPartsOrdering_Load(sender, e)
	End Sub
End Class
