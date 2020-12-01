Public Class frmAddBankAccount
	'variable for intCustomerID, restricted to this form
	Dim receiveCustomerID As Integer

	Public Sub New(ByVal passedCustomerID As Integer)

		'Receive current intCustomerID from whichever form called this one
		InitializeComponent()
		receiveCustomerID = passedCustomerID

	End Sub

	Private Sub frmAddBankAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try

			LoadBankAccountTypes()


		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub LoadBankAccountTypes()

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

		cboAccountType.BeginUpdate()

		'Create select
		strSelect = "SELECT intBankAccountTypeID, strAccountTypeDesc FROM TBankAccountTypes"

		'Get records
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'Load Table
		dt.Load(drSourceTable)


		' Add items to combo box
		cboAccountType.ValueMember = "intBankAccountTypeID"
		cboAccountType.DisplayMember = "strAccountTypeDesc"
		cboAccountType.DataSource = dt

		' Select the first item in the list by default
		If cboAccountType.Items.Count > 0 Then cboAccountType.SelectedIndex = 0

		' Show changes
		cboAccountType.EndUpdate()

		' Clean up
		drSourceTable.Close()

		' close the database connection
		CloseDatabaseConnection()

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Close()

	End Sub

	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		'Variables
		Dim strSelect As String = ""
		Dim strInsert As String = ""

		Dim strRoutingNumber As String = ""
		Dim strAccountNumber As String = ""
		Dim intBankAccountTypeID As Integer
		Dim strAccountName As String = ""

		Dim cmdSelect As OleDb.OleDbCommand
		Dim cmdInsert As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim intNextHighestRecordID As Integer
		Dim intRowsAffected As Integer


		Try

			If Validation() = True Then

				'Set values
				strRoutingNumber = txtRoutingNumber.Text
				strAccountNumber = txtAccountNumber.Text
				intBankAccountTypeID = cboAccountType.SelectedValue
				strAccountName = txtNameOnAccount.Text

				If OpenDatabaseConnectionSQLServer() = False Then

					'Alert if no connection
					MessageBox.Show(Me, "Database connection error." & vbNewLine &
										"The application will now close.",
										Me.Text + " Error",
										MessageBoxButtons.OK, MessageBoxIcon.Error)

					'Close Form
					Me.Close()

				End If

				strSelect = "SELECT MAX(intBankAccountID) + 1 AS intNextHighestRecordID FROM TBankAccounts"

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
				strInsert = "Insert into TBankAccounts Values (" & intNextHighestRecordID & ", " & receiveCustomerID & ", '" & strRoutingNumber & "', '" &
					strAccountNumber & "', " & intBankAccountTypeID & ", '" & strAccountName & "')"

				cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

				intRowsAffected = cmdInsert.ExecuteNonQuery()

				If intRowsAffected > 0 Then
					MessageBox.Show("Bank Account has been added")
					Me.Close()
				End If

				CloseDatabaseConnection()

			End If

		Catch ex As Exception
			'unhandled exception
			MessageBox.Show(ex.Message)
		End Try

		Me.Close()

	End Sub

	Function Validation() As Boolean

		txtRoutingNumber.BackColor = Color.White
		txtAccountNumber.BackColor = Color.White
		txtNameOnAccount.BackColor = Color.White

		' check if something is entered in routing number
		If txtRoutingNumber.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter routing number, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter the routing number.")
			txtRoutingNumber.BackColor = Color.Yellow
			txtRoutingNumber.Focus()
			Return False
		End If

		' check if something is entered in account number text box
		If txtAccountNumber.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter account number, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter account number.")
			txtAccountNumber.BackColor = Color.Yellow
			txtAccountNumber.Focus()
			Return False
		End If

		' check if something is entered in account name box
		If txtNameOnAccount.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter account name, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter bank account owner's name.")
			txtNameOnAccount.BackColor = Color.Yellow
			txtNameOnAccount.Focus()
			Return False
		End If

		Return True ' all is well in the world

	End Function

End Class