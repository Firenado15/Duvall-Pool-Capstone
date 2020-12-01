' Parts Ordering form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmPartsOrdering

	Dim intNewVendorID As Integer

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close program
		Close()

	End Sub

	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		' After Validation, run submit and assign values to variables
		If Validation() = True Then

			If radNo.Checked = True Then

				'insert new vendor
				InsertNewVendor()
				'place PO
				InsertParts(intNewVendorID)

				'Close form
				Me.Close()

			ElseIf radYes.Checked = True Then

				'Place PO using selected vendor
				InsertParts(cboVendor.SelectedValue)

				'Close form
				Me.Close()

			End If

		End If

	End Sub

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

		strVendorName = txtVendorName.Text
		strContactName = txtContactName.Text
		strAddress = txtAddress.Text
		strCity = txtCity.Text
		intState = cboState.SelectedValue
		strZip = txtZip.Text
		strPhoneNumber = txtPhone.Text
		strEmail = txtEmail.Text


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
				MessageBox.Show("Vendor has been added")
				Me.Close()
			End If

			CloseDatabaseConnection()

		End If

	End Sub

	Private Sub InsertParts(ByVal intVendorID As Integer)

		'Variables
		Dim strSerialNumber As String = ""
		Dim strPartDesc As String = ""
		Dim intQuantity As Integer = 0
		Dim strUnitCost As String = ""
		Dim decUnitPurchaseCost As Double = 0.00
		Dim decUniteSaleCost As Double = 0.00

		Dim strSelect As String
		Dim strInsert As String
		Dim cmdSelect As OleDb.OleDbCommand
		Dim cmdInsert As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim intNextHighestRecordID As Integer
		Dim intRowsAffected As Integer

		strSerialNumber = txtSerialNumber.Text
		strPartDesc = txtPartName.Text
		intQuantity = Integer.Parse(txtQuantity.Text)
		strUnitCost = txtUnitCost.Text
		decUnitPurchaseCost = Convert.ToDouble(strUnitCost)
		decUniteSaleCost = decUnitPurchaseCost * 1.5

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

			'Create insert statement
			strInsert = "Insert into TParts" &
					" Values (" & intNextHighestRecordID & ", " & intVendorID & ", '" & strSerialNumber & "', '" & strPartDesc & "', " & intQuantity &
					", " & decUnitPurchaseCost & ", " & decUniteSaleCost & ", 0)"

			cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

			intRowsAffected = cmdInsert.ExecuteNonQuery()

			If intRowsAffected > 0 Then
				MessageBox.Show("PO has been added")
				Me.Close()
			End If

			CloseDatabaseConnection()

		End If

	End Sub


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
		txtQuantity.BackColor = Color.White
		txtUnitCost.BackColor = Color.White
		'txtVendorIdentification.BackColor = Color.White

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

			Else
				' text box is blank so tell user to enter zip, change back color to yellow,
				' put focus in text box and return false we don't want to continue
				MessageBox.Show("Please enter Vendor's zip.")
				txtZip.BackColor = Color.Yellow
				txtZip.Focus()
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

		End If



		'' check if something is entered in purchase order text box
		'If txtPurchaseOrder.Text <> String.Empty Then

		'Else
		'	' text box is blank so tell user to enter purchase order, change back color to yellow,
		'	' put focus in text box and return false we don't want to continue
		'	MessageBox.Show("Please enter purchase order.")
		'	txtPurchaseOrder.BackColor = Color.Yellow
		'	txtPurchaseOrder.Focus()
		'	Return False
		'End If

		' check if something is entered in job number text box
		If txtSerialNumber.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter job number, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter job number.")
			txtSerialNumber.BackColor = Color.Yellow
			txtSerialNumber.Focus()
			Return False
		End If

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

		'' check if something is entered in part description text box
		'If txtPartDescription.Text <> String.Empty Then

		'Else
		'	' text box is blank so tell user to enter part description, change back color to yellow,
		'	' put focus in text box and return false we don't want to continue
		'	MessageBox.Show("Please enter part description.")
		'	txtPartDescription.BackColor = Color.Yellow
		'	txtPartDescription.Focus()
		'	Return False
		'End If

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

		' check if something is entered in cost per unit text box
		If txtUnitCost.Text <> String.Empty Then
			' Check for numric value
			If IsNumeric(txtUnitCost.Text) = True Then
			Else
				MessageBox.Show("Please enter numeric values only for cost.")
				txtUnitCost.BackColor = Color.Yellow
				txtUnitCost.Focus()
				Return False
			End If
		Else
			' text box is blank so tell user to enter cost per unit, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter cost per unit.")
			txtUnitCost.BackColor = Color.Yellow
			txtUnitCost.Focus()
			Return False
		End If

		'' check if something is entered in identification number text box
		'If txtVendorIdentification.Text <> String.Empty Then

		'Else
		'	' text box is blank so tell user to enter identification number, change back color to yellow,
		'	' put focus in text box and return false we don't want to continue
		'	MessageBox.Show("Please enter Vendor's identification number.")
		'	txtVendorIdentification.BackColor = Color.Yellow
		'	txtVendorIdentification.Focus()
		'	Return False
		'End If

		Return True ' all is well in the world

	End Function

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

	Private Sub cboVendor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVendor.SelectedIndexChanged

		Try

			LoadCurrentVendor()

		Catch ex As Exception

			MessageBox.Show(ex.Message)
		End Try

	End Sub

	Private Sub LoadCurrentVendor()

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

	End Sub

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

			' close the database connection
			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

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

	Private Sub radYes_CheckedChanged(sender As Object, e As EventArgs) Handles radYes.CheckedChanged

		'Set cbo and labels visible
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

	Private Sub btnEditVendorInfo_Click(sender As Object, e As EventArgs) Handles btnEditVendorInfo.Click

		Dim UpdateVendor As New frmUpdateVendorInfo(cboVendor.SelectedValue)

		' show the new form so any past data is not still on the form
		UpdateVendor.ShowDialog()

		'Relead customer info after update
		LoadCurrentVendor()

	End Sub
End Class
