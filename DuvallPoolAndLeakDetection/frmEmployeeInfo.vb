' View and Update Dispatched Orders form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmEmployeeInfo
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close program
		Close()

	End Sub

	Private Sub frmViewAndUpdateDispatchedOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

			cboEmployee.BeginUpdate()

			'Create select
			strSelect = "SELECT intEmployeeID, ( strLastName + ', ' + strFirstName ) AS FullName FROM TEmployees ORDER BY FullName ASC"

			'Get records
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load Table
			dt.Load(drSourceTable)

			' Add items to combo box
			cboEmployee.ValueMember = "intEmployeeID"
			cboEmployee.DisplayMember = "FullName"
			cboEmployee.DataSource = dt

			' Select the first item in the list by default
			If cboEmployee.Items.Count > 0 Then cboEmployee.SelectedIndex = 0

			' Show changes
			cboEmployee.EndUpdate()

			' Clean up
			drSourceTable.Close()

			' close the database connection
			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub cboEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmployee.SelectedIndexChanged

		Try

			LoadJobList()

		Catch ex As Exception

			MessageBox.Show(ex.Message)
		End Try

	End Sub

	Private Sub LoadJobList()

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

		'Create select
		strSelect = "SELECT JobNumber, strJobDesc AS Description, dtStartDate AS StartDate, dtendDate AS EndDate FROM TJobRecords" &
			" WHERE intJobRecordID IN (SELECT intJobRecordID FROM TJobEmployees WHERE intEmployeeID = " & cboEmployee.SelectedValue & ")"

		'Get records
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'Load Table
		dt.Load(drSourceTable)

		dgvJobs.DataSource = dt


		' Clean up
		drSourceTable.Close()

		' close the database connection
		CloseDatabaseConnection()

	End Sub

	Private Sub dgvJobs_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobs.CellDoubleClick

		'Check to make sure it is not a DBNull value
		If IsDBNull(dgvJobs.CurrentRow.Cells(0).Value) = False Then

			' create a new instance of the job information form, passing current job ID
			Dim JobDetails As New frmJobDetails(dgvJobs.CurrentRow.Cells(0).Value)

			' show the new form so any past data is not still on the form
			JobDetails.ShowDialog()

		End If

	End Sub
End Class