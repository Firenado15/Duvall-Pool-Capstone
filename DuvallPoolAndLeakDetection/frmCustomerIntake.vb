' Customer Intake form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmCustomerIntake
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		'Close form
		Me.Close()

	End Sub

	Private Sub frmCustomerIntake_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try

			LoadStates()


		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		'Variables
		Dim strSelect As String
		Dim strInsert As String
		Dim strFirstName As String = ""
		Dim strLastName As String = ""
		Dim strStreetAddress As String = ""
		Dim strCity As String = ""
		Dim intState As Integer = 0
		Dim strZip As String = ""
		Dim strPhoneNumber As String = ""
		Dim strEmail As String = ""
		Dim cmdSelect As OleDb.OleDbCommand
		Dim cmdInsert As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim intNextHighestRecordID As Integer
		Dim intRowsAffected As Integer



		strFirstName = txtFirstName.Text
		strLastName = txtLastName.Text
		strStreetAddress = txtAddress.Text
		strCity = txtCity.Text
		intState = cboState.SelectedValue
		strZip = txtZipCode.Text
		strPhoneNumber = txtPhoneNumber.Text
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

				strSelect = "SELECT MAX(intCustomerID) + 1 AS intNextHighestRecordID " &
							" FROM TCustomers"

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
				strInsert = "Insert into TCustomers (intCustomerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail)" &
					" Values (" & intNextHighestRecordID & ",'" & strFirstName & "'," & "'" & strLastName & "'," & "'" & strStreetAddress & "'," & "'" & strCity &
					"','" & cboState.SelectedValue.ToString & "','" & strZip & "','" & strPhoneNumber & "','" & strEmail & "')"

				'LOOK HERE
				strCustID = intNextHighestRecordID


				cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)


				intRowsAffected = cmdInsert.ExecuteNonQuery()

				If intRowsAffected > 0 Then
					MessageBox.Show("Customer has been added")
					Me.Close()
				End If


				CloseDatabaseConnection()


				Dim result As DialogResult = MessageBox.Show("Would you like to enter a payment option now?", "Payment", MessageBoxButtons.YesNo)
				If result = DialogResult.No Then

				ElseIf result = DialogResult.Yes Then

					' create a new instance of the customer intake form
					Dim CustomerPayment As New frmPaymentType

					' show the new form so any past data is not still on the form
					CustomerPayment.ShowDialog()

				End If




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
		txtPhoneNumber.BackColor = Color.White

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
		If txtPhoneNumber.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter phone number, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter Customer's phone number.")
			txtPhoneNumber.BackColor = Color.Yellow
			txtPhoneNumber.Focus()
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


End Class
