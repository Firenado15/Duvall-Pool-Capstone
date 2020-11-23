' Previous Customer form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmPreviousCustomer
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close program
		Me.Close()

	End Sub

	Private Sub frmPreviousCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

			cboName.BeginUpdate()



			'Create select
			strSelect = "SELECT intCustomerID, ( strLastName + ', ' + strFirstName ) AS FullName FROM TCustomers ORDER BY FullName ASC"

			'Get records
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load Table
			dt.Load(drSourceTable)


			' Add items to combo box
			cboName.ValueMember = "intCustomerID"
			cboName.DisplayMember = "FullName"
			cboName.DataSource = dt



			' Select the first item in the list by default
			If cboName.Items.Count > 0 Then cboName.SelectedIndex = 0

			' Show changes
			cboName.EndUpdate()

			' Clean up
			drSourceTable.Close()

			' close the database connection
			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try


	End Sub

	Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged

		Try


			Dim intShirt As Integer
			Dim intGender As Integer
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
			strSelect = "SELECT * FROM vCustomers WHERE intCustomerID = " & cboName.SelectedValue.ToString


			'Retrieve records 
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'load the data table from the reader
			dt.Load(drSourceTable)

			'populate text boxes
			lblFirstName.Text = dt.Rows(0).Item(1).ToString
			lblLastName.Text = dt.Rows(0).Item(2).ToString
			lblAddress.Text = dt.Rows(0).Item(3).ToString
			lblCity.Text = dt.Rows(0).Item(4).ToString
			lblState.Text = dt.Rows(0).Item(5).ToString
			lblZip.Text = dt.Rows(0).Item(6).ToString
			lblPhone.Text = dt.Rows(0).Item(7).ToString
			lblEmail.Text = dt.Rows(0).Item(8).ToString

			''Set index value
			'intShirt = dt.Rows(0).Item(8)
			'intGender = dt.Rows(0).Item(9)

			''Display proper shirt size
			'Me.cboShirts.SelectedIndex = intShirt - 1
			'Me.cboGender.SelectedIndex = intGender - 1

			'close connection
			CloseDatabaseConnection()


		Catch ex As Exception

			MessageBox.Show(ex.Message)
		End Try


	End Sub
End Class