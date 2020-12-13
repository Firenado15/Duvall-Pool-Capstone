Public Class frmJobDetails
	'variable for intCustomerID, restricted to this form
	Dim receiveJobNumber As Integer
	Dim intJobRecordID As Integer

	Public Sub New(ByVal passedJobNumber As Integer)

		'Receive current intCustomerID from whichever form called this one
		InitializeComponent()
		receiveJobNumber = passedJobNumber

	End Sub

	Private Sub frmJobDeatils_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try

			LoadJobDetails()

			LoadEmployeeJobInfo()

		Catch ex As Exception

		End Try


	End Sub

	Private Sub LoadJobDetails()

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
		intJobRecordID = dt.Rows(0).Item(6)

		'close connection
		CloseDatabaseConnection()

	End Sub

	Private Sub LoadEmployeeJobInfo()

		'count
		Dim strSelectCount As String = ""
		Dim cmdSelectCount As OleDb.OleDbCommand 'Select
		Dim dtCount As DataTable = New DataTable 'reader
		'names
		Dim strSelectNames As String = ""
		Dim cmdSelectNames As OleDb.OleDbCommand 'Select
		Dim dtNames As DataTable = New DataTable 'reader
		Dim intRowCount As Integer
		Dim strNames As String = ""
		Dim blnFirstName As Boolean = True

		Dim drSourceTable As OleDb.OleDbDataReader 'retrieved data


		' ----------------------------------------------------------------------------
		' open the database ----------------------------------------------------------
		' ----------------------------------------------------------------------------

		If OpenDatabaseConnectionSQLServer() = False Then


			' No connection error
			MessageBox.Show(Me, "Database connection error." & vbNewLine &
								"The application will now close.",
								Me.Text + " Error",
								MessageBoxButtons.OK, MessageBoxIcon.Error)

			'close the form
			Me.Close()

		End If

		' ----------------------------------------------------------------------------
		' Count Employees ------------------------------------------------------------
		' ----------------------------------------------------------------------------

		'Select statement
		strSelectCount = "SELECT COUNT(intJobEmployeeID) FROM TJobEmployees WHERE intJobRecordID = " & intJobRecordID

		'Retrieve records 
		cmdSelectCount = New OleDb.OleDbCommand(strSelectCount, m_conAdministrator)
		drSourceTable = cmdSelectCount.ExecuteReader

		'load the data table from the reader
		dtCount.Load(drSourceTable)

		'populate label
		lblNumberOfEmployees.Text = dtCount.Rows(0).Item(0)


		' ----------------------------------------------------------------------------
		' Employee Names -------------------------------------------------------------
		' ----------------------------------------------------------------------------

		'Select statement
		strSelectNames = "SELECT * FROM vEmployeeNames WHERE intJobRecordID = " & intJobRecordID

		'Retrieve records 
		cmdSelectNames = New OleDb.OleDbCommand(strSelectNames, m_conAdministrator)
		drSourceTable = cmdSelectNames.ExecuteReader

		'load the data table from the reader
		dtNames.Load(drSourceTable)

		'populate label
		intRowCount = dtNames.Rows.Count

		'Build name list
		For intIndex As Integer = 0 To intRowCount - 1

			If blnFirstName = False Then
				strNames = strNames & ", "
			End If

			strNames = strNames & dtNames.Rows(intIndex).Item(0).ToString
			blnFirstName = False

		Next

		'Display name list
		lblEmployeeNames.Text = strNames

		'close connection
		CloseDatabaseConnection()

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		'Close Form
		Me.Close()

	End Sub
End Class