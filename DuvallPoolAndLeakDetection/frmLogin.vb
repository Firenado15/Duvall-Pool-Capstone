' Login form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmLogin
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' Close program
        Close()

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

		Dim strUsername As String = txtUsername.Text
		Dim strPassword As String = ""


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
		strSelect = "SELECT * FROM TUserLogin WHERE strUsername = '" & strUsername & "'"


		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'load the data table from the reader
		dt.Load(drSourceTable)

		If dt.Rows.Count > 0 Then

			'populate text boxes
			strPassword = dt.Rows(0).Item(2).ToString

			'close connection
			CloseDatabaseConnection()


			If strPassword = txtPassword.Text Then

				' create a new instance of the add form
				Dim Options As New frmOptions

				' show the new form so any past data is not still on the form

				Me.Visible = False

				Options.ShowDialog()
				Close()
			Else

				MessageBox.Show("Incorrect username/password.")

			End If

		Else

			MessageBox.Show("Incorrect username/password.")

		End If

	End Sub

	Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		'Set focus on username
		txtUsername.Focus()

	End Sub
End Class
