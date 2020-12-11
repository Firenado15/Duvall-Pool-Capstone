Public Class frmJobDetails
	'variable for intCustomerID, restricted to this form
	Dim receiveJobNumber As Integer

	Public Sub New(ByVal passedJobNumber As Integer)

		'Receive current intCustomerID from whichever form called this one
		InitializeComponent()
		receiveJobNumber = passedJobNumber

	End Sub

	Private Sub frmJobDeatils_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
		strSelect = "SELECT * FROM vJobAndCustomerInfo WHERE JobNumber = " & receiveJobNumber

		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'load the data table from the reader
		dt.Load(drSourceTable)

		'populate text boxes
		lblJobNumber.Text = dt.Rows(0).Item(0).ToString
		lblCustomerName.Text = dt.Rows(0).Item(1).ToString
		lblStartDate.Text = dt.Rows(0).Item(2).ToString
		lblEndDate.Text = dt.Rows(0).Item(3).ToString
		lblDescription.Text = dt.Rows(0).Item(4).ToString
		lblStatus.Text = dt.Rows(0).Item(5).ToString


		'close connection
		CloseDatabaseConnection()

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		'Close Form
		Me.Close()

	End Sub
End Class