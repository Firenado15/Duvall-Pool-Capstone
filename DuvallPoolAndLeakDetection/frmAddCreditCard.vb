Public Class frmAddCreditCard
	'variable for intCustomerID, restricted to this form
	Dim receiveCustomerID As Integer

	Public Sub New(ByVal passedCustomerID As Integer)

		'Receive current intCustomerID from whichever form called this one
		InitializeComponent()
		receiveCustomerID = passedCustomerID

	End Sub

	Private Sub frmAddCreditCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try

			LoadCardTypes()


		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Function Validation() As Boolean

		txtCardholderName.BackColor = Color.White
		txtCardNumber.BackColor = Color.White
		txtExpiration.BackColor = Color.White
		txtCVV.BackColor = Color.White

		' check if something is entered in cardholder name box
		If txtCardholderName.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter cardholder name, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter Cardholder's name.")
			txtCardholderName.BackColor = Color.Yellow
			txtCardholderName.Focus()
			Return False
		End If

		' check if something is entered in card number
		If txtCardNumber.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter card number, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter the card number.")
			txtCardNumber.BackColor = Color.Yellow
			txtCardNumber.Focus()
			Return False
		End If

		' check if something is entered in expiration text box
		If txtExpiration.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter expiration date, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter expiration date.")
			txtExpiration.BackColor = Color.Yellow
			txtExpiration.Focus()
			Return False
		End If

		' check if something is entered in city text box
		If txtCVV.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter CVV/CVC, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter CVV/CVC.")
			txtCVV.BackColor = Color.Yellow
			txtCVV.Focus()
			Return False
		End If


		Return True ' all is well in the world

	End Function

	Private Sub LoadCardTypes()



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

		cboCardType.BeginUpdate()



		'Create select
		strSelect = "SELECT intCreditCardTypeID, strCardTypeDesc FROM TCreditCardTypes"

		'Get records
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'Load Table
		dt.Load(drSourceTable)


		' Add items to combo box
		cboCardType.ValueMember = "intCreditCardTypeID"
		cboCardType.DisplayMember = "strCardTypeDesc"
		cboCardType.DataSource = dt



		' Select the first item in the list by default
		If cboCardType.Items.Count > 0 Then cboCardType.SelectedIndex = 0

		' Show changes
		cboCardType.EndUpdate()

		' Clean up
		drSourceTable.Close()

		' close the database connection
		CloseDatabaseConnection()



	End Sub

	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click


		'Variables
		Dim strSelect As String = ""
		Dim strInsert As String = ""
		Dim strCardholderName As String = ""
		Dim strCardNumber As String = ""
		Dim strExpiration As String = ""
		Dim strCVV As String = ""
		Dim intCardCompanyID As Integer
		Dim intCreditCardTypeID As Integer


		Dim cmdSelect As OleDb.OleDbCommand
		Dim cmdInsert As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim intNextHighestRecordID As Integer
		Dim intRowsAffected As Integer


		Try

			If Validation() = True Then

				'Set values
				strCardholderName = txtCardholderName.Text
				strCardNumber = txtCardNumber.Text
				strExpiration = txtExpiration.Text
				strCVV = txtCVV.Text
				intCreditCardTypeID = cboCardType.SelectedValue

				If radVisa.Checked = True Then
					intCardCompanyID = 3
				ElseIf radMastercard.Checked = True Then
					intCardCompanyID = 2
				ElseIf radAmericanExpress.Checked = True Then
					intCardCompanyID = 1
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

				strSelect = "SELECT MAX(intCreditCardID) + 1 AS intNextHighestRecordID " &
							" FROM TCreditCards"

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
				strInsert = "Insert into TCreditCards Values (" & intNextHighestRecordID & ", " & receiveCustomerID & ", '" & strCardholderName & "', '" & strCardNumber & "', '" & strExpiration &
					"', '" & strCVV & "', " & intCardCompanyID & ", " & intCreditCardTypeID & ")"


				cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)


				intRowsAffected = cmdInsert.ExecuteNonQuery()

				If intRowsAffected > 0 Then
					MessageBox.Show("Credit Card has been added")
					Me.Close()
				End If


				CloseDatabaseConnection()

				Me.Close()
			End If




		Catch ex As Exception
			'unhandled exception
			MessageBox.Show(ex.Message)
		End Try

	End Sub
End Class