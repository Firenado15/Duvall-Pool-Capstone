Public Class frmMakeInvoicePayment
	'variable for intCustomerID, restricted to this form
	Dim receivedInvoiceID As Integer
	Dim receivedCustomerID As Integer
	Dim dblinvoiceTotal As Double
	Dim dblAmountPaid As Double
	Dim dblCurrentPayment As Double = 0.00

	Public Sub New(ByVal passedInvoiceID As Integer, ByVal passedCustomerID As Integer, ByVal InvoiceTotal As Double, ByVal AmountPaid As Double)

		'Receive current intCustomerID from whichever form called this one
		InitializeComponent()
		receivedInvoiceID = passedInvoiceID
		receivedCustomerID = passedCustomerID
		dblinvoiceTotal = InvoiceTotal
		dblAmountPaid = AmountPaid

	End Sub

	Private Sub frmMakePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load



	End Sub

	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		' Declare Variables



		Try

			If IsNumeric(txtPaymentAmount.Text) = True Then

				dblCurrentPayment = txtPaymentAmount.Text

				If dblCurrentPayment >= (dblinvoiceTotal - dblAmountPaid) Then

					dblCurrentPayment = (dblinvoiceTotal - dblAmountPaid)
					MessageBox.Show(Me, "This payment will exceed the remaining balance." & vbNewLine &
											"You will be charged $" & dblCurrentPayment.ToString & ".",
											Me.Text + " Error",
											MessageBoxButtons.OK, MessageBoxIcon.Information)
					dblCurrentPayment += dblAmountPaid

				End If

				MakePayment()

				InsertPaymentRecord()


			Else

				MessageBox.Show("Please enter a numeric value.")

			End If



		Catch ex As Exception
			'unhandled exception
			MessageBox.Show(ex.Message)
		End Try

	End Sub

	Private Sub MakePayment()

		Dim strupdate As String = ""
		Dim cmdUpdate As OleDb.OleDbCommand
		Dim intRowsAffected As Integer

		' Open database connection
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
		strupdate = "UPDATE TInvoices " &
				"SET decAmountPaid = " & dblCurrentPayment &
				" WHERE intInvoiceID = " & receivedInvoiceID

		cmdUpdate = New OleDb.OleDbCommand(strupdate, m_conAdministrator)

		intRowsAffected = cmdUpdate.ExecuteNonQuery()

		'If Rows affected is more than 0
		If intRowsAffected > 0 Then
			MessageBox.Show("Payment submitted")
			Me.Close()
		End If

		'Close connection
		CloseDatabaseConnection()

	End Sub

	Private Sub InsertPaymentRecord()

		Dim strSelect As String = ""
		Dim strInsert As String = ""
		Dim cmdSelect As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim cmdInsert As OleDb.OleDbCommand
		Dim intNextHighestRecordID As Integer
		Dim intRowsAffected As Integer

		' Open database connection
		If OpenDatabaseConnectionSQLServer() = False Then

			'Alert if no connection
			MessageBox.Show(Me, "Database connection error." & vbNewLine &
									"The application will now close.",
									Me.Text + " Error",
									MessageBoxButtons.OK, MessageBoxIcon.Error)

			'Close Form
			Me.Close()

		End If


		'Get next highest record ID
		strSelect = "SELECT MAX(intInvoicePaymentID) + 1 AS intNextHighestRecordID " &
				" FROM TInvoicePayments"

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
		strInsert = "Insert into TInvoicePayments Values (" & intNextHighestRecordID &
			", " & receivedInvoiceID &
			", " & dblCurrentPayment &
			", '" & DateAndTime.Today &
			"')"

		cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

		intRowsAffected = cmdInsert.ExecuteNonQuery()

		'If Rows affected is more than 0
		If intRowsAffected = 0 Then
			MessageBox.Show("Couldn't record payment history")
			Me.Close()
		End If

		'Close connection
		CloseDatabaseConnection()

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Close()

	End Sub
End Class