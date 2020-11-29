' Parts Ordering form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmPartsOrdering
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' Close program
        Close()

    End Sub

	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		' After Validation, run submit and assign values to variables
		Validation()

		InsertNewVendor()

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

			'Create insert statement
			strInsert = "Insert into TVendors" &
					" Values (" & intNextHighestRecordID & ",'" & strVendorName & "'," & "'" & strContactName & "'," & "'" & strAddress & "'," & "'" & strCity &
					"','" & cboState.SelectedValue.ToString & "','" & strZip & "','" & strPhoneNumber & "','" & strEmail & "')"

			'LOOK HERE
			'intCustID = intNextHighestRecordID

			cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

			intRowsAffected = cmdInsert.ExecuteNonQuery()

			If intRowsAffected > 0 Then
				MessageBox.Show("Vendor has been added")
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
		txtPurchaseOrder.BackColor = Color.White
		txtJobNumber.BackColor = Color.White
		txtPartName.BackColor = Color.White
		txtPartDescription.BackColor = Color.White
		txtQuantity.BackColor = Color.White
		'txtCostPerUnit.BackColor = Color.White
		txtVendorIdentification.BackColor = Color.White

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

		' check if something is entered in purchase order text box
		If txtPurchaseOrder.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter purchase order, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter purchase order.")
			txtPurchaseOrder.BackColor = Color.Yellow
			txtPurchaseOrder.Focus()
			Return False
		End If

		' check if something is entered in job number text box
		If txtJobNumber.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter job number, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter job number.")
			txtJobNumber.BackColor = Color.Yellow
			txtJobNumber.Focus()
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
		If txtQuantity.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter quantity, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter quantity.")
			txtQuantity.BackColor = Color.Yellow
			txtQuantity.Focus()
			Return False
		End If

		'' check if something is entered in cost per unit text box
		'If txtCostPerUnit.Text <> String.Empty Then

		'Else
		'    ' text box is blank so tell user to enter cost per unit, change back color to yellow,
		'    ' put focus in text box and return false we don't want to continue
		'    MessageBox.Show("Please enter cost per unit.")
		'    txtCostPerUnit.BackColor = Color.Yellow
		'    txtCostPerUnit.Focus()
		'    Return False
		'End If

		' check if something is entered in identification number text box
		If txtVendorIdentification.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter identification number, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter Vendor's identification number.")
			txtVendorIdentification.BackColor = Color.Yellow
			txtVendorIdentification.Focus()
			Return False
		End If

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

		Catch ex As Exception

			MessageBox.Show(ex.Message)
		End Try

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

		'Turn off combo and labels
		cboVendor.Visible = False
		lblContactName.Visible = False
		lblAddress.Visible = False
		lblCity.Visible = False
		lblState.Visible = False
		lblZip.Visible = False
		lblPhone.Visible = False
		lblEmail.Visible = False

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
End Class
