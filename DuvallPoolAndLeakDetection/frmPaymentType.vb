Public Class frmPaymentType

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		Dim intRadioValue As Integer
		Dim strSelect As String
		Dim strInsert As String
		Dim cmdSelect As OleDb.OleDbCommand
		Dim cmdInsert As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim intNextHighestRecordID As Integer
		Dim intRowsAffected As Integer

		If radCash.Checked = True Then

			intRadioValue = 1

		ElseIf radCreditDebit.Checked = True Then

			intRadioValue = 2

		ElseIf radCheck.Checked = True Then

			intRadioValue = 3

		ElseIf radBankTransfer.Checked = True Then

			intRadioValue = 4

		End If


		Try

			If OpenDatabaseConnectionSQLServer() = False Then


				'Alert if no connection
				MessageBox.Show(Me, "Database connection error." & vbNewLine &
										"The application will now close.",
										Me.Text + " Error",
										MessageBoxButtons.OK, MessageBoxIcon.Error)

				'Close Form
				Me.Close()

			End If


			strSelect = "SELECT MAX(intCustomerPaymentID) + 1 AS intNextHighestRecordID FROM TCustomerPayments"

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


			'Update statement
			strInsert = "Insert into TCustomerPayments Values (" & intRadioValue & ", " & strCustID & ", " & intRadioValue & ")"


			' execute the statement
			cmdInsert = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

			' Insert the row
			intRowsAffected = cmdInsert.ExecuteNonQuery()

			' have to let the user know what happened 
			If intRowsAffected = 1 Then
				MessageBox.Show("Update successful")
			Else
				MessageBox.Show("Update failed")
			End If

			' close the database connection
			CloseDatabaseConnection()

		Catch ex As Exception
			'unhandled exception
			MessageBox.Show(ex.Message)
		End Try




	End Sub


End Class