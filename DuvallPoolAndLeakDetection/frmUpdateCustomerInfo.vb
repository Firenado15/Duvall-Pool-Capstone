Public Class frmUpdateCustomerInfo

	'variable for intCustomerID, restricted to this form
	Dim receiveCustomerID As Integer

	Public Sub New(ByVal passedCustomerID As Integer)

		'Receive current intCustomerID from whichever form called this one
		InitializeComponent()
		receiveCustomerID = passedCustomerID

	End Sub

	Private Sub frmUpdateCustomerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try

			LoadStates()

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
			strSelect = "SELECT * FROM TCustomers WHERE intCustomerID = " & receiveCustomerID


			'Retrieve records 
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'load the data table from the reader
			dt.Load(drSourceTable)

			'populate text boxes
			txtFirstName.Text = dt.Rows(0).Item(1).ToString
			txtLastName.Text = dt.Rows(0).Item(2).ToString
			txtAddress.Text = dt.Rows(0).Item(3).ToString
			txtCity.Text = dt.Rows(0).Item(4).ToString
			cboState.SelectedValue = dt.Rows(0).Item(5)
			txtZipCode.Text = dt.Rows(0).Item(6).ToString
			txtPhone.Text = dt.Rows(0).Item(7).ToString
			txtEmail.Text = dt.Rows(0).Item(8).ToString

			'close connection
			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

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

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		'Close form
		Me.Close()

	End Sub

	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		'Variables
		Dim strUpdate As String
		Dim strFirstName As String = ""
		Dim strLastName As String = ""
		Dim strStreetAddress As String = ""
		Dim strCity As String = ""
		Dim intState As Integer = 0
		Dim strZip As String = ""
		Dim strPhoneNumber As String = ""
		Dim strEmail As String = ""
		Dim cmdUpdate As OleDb.OleDbCommand
		Dim intRowsAffected As Integer

		strFirstName = txtFirstName.Text
		strLastName = txtLastName.Text
		strStreetAddress = txtAddress.Text
		strCity = txtCity.Text
		intState = cboState.SelectedValue
		strZip = txtZipCode.Text
		strPhoneNumber = txtPhone.Text
		strEmail = txtEmail.Text

		Try

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

				'Create update statement
				strUpdate = "UPDATE TCustomers " &
					"SET strFirstName = '" & strFirstName & "', " &
						"strLastName = '" & strLastName & "', " &
						"strAddress = '" & strStreetAddress & "', " &
						"strCity = '" & strCity & "', " &
						"intStateID = " & cboState.SelectedValue & ", " &
						"strZip = '" & strZip & "', " &
						"strPhoneNumber = '" & strPhoneNumber & "', " &
						"strEmail = '" & strEmail & "' " &
					"WHERE intCustomerID = " & receiveCustomerID

				cmdUpdate = New OleDb.OleDbCommand(strUpdate, m_conAdministrator)

				intRowsAffected = cmdUpdate.ExecuteNonQuery()

				If intRowsAffected > 0 Then
					MessageBox.Show("Customer info has been updated")
					Me.Close()
				End If

				CloseDatabaseConnection()

			End If

		Catch ex As Exception
			'unhandled exception
			MessageBox.Show(ex.Message)
		End Try

	End Sub

	Function Validation() As Boolean

		txtFirstName.BackColor = Color.White
		txtLastName.BackColor = Color.White
		txtAddress.BackColor = Color.White
		txtCity.BackColor = Color.White
		txtZipCode.BackColor = Color.White
		txtEmail.BackColor = Color.White
		txtPhone.BackColor = Color.White

		' check if something is entered in first name text box
		If txtFirstName.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter first name, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter Customer's first name.")
			txtFirstName.BackColor = Color.Yellow
			txtFirstName.Focus()
			Return False
		End If

		' check if something is entered in last name text box
		If txtLastName.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter last name, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter Customer's last name.")
			txtLastName.BackColor = Color.Yellow
			txtLastName.Focus()
			Return False
		End If

		' check if something is entered in street address text box
		If txtAddress.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter street address, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter Customer's street address.")
			txtAddress.BackColor = Color.Yellow
			txtAddress.Focus()
			Return False
		End If

		' check if something is entered in city text box
		If txtCity.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter city, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter Customer's city.")
			txtCity.BackColor = Color.Yellow
			txtCity.Focus()
			Return False
		End If

		' check if something is entered in zip text box
		If txtZipCode.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter zip, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter Customer's zip.")
			txtZipCode.BackColor = Color.Yellow
			txtZipCode.Focus()
			Return False
		End If

		' check if something is entered in email text box
		If txtEmail.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter email, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter Customer's email.")
			txtEmail.BackColor = Color.Yellow
			txtEmail.Focus()
			Return False
		End If

		' check if something is entered in phone number text box
		If txtPhone.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter phone number, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter Customer's phone number.")
			txtPhone.BackColor = Color.Yellow
			txtPhone.Focus()
			Return False
		End If

		Return True ' all is well in the world

	End Function

End Class