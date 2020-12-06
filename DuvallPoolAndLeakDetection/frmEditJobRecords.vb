' View job Records form
' Last Updated: 12/1/2020
' Last modified by Matthew Estes

'Imports Microsoft.VisualBasic.ApplicationServices.

Public Class frmEditJobRecords



	Dim receiveJobNumber As String
	Dim intJobID As Integer

	Public Sub New(ByVal passedJobNumber As String)

		'Receive current intCustomerID from whichever form called this one
		InitializeComponent()
		receiveJobNumber = passedJobNumber

	End Sub


	' Close form
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close form
		Close()

	End Sub



	' Runs when form loads, loads in both combo boxes
	Private Sub frmViewJobRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try

			' Load names combo box
			LoadJobInfo()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try
	End Sub



	' Runs when form loads, loads in name combo box
	Private Sub LoadJobInfo()

		Try
			Dim intStatus As Integer
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

			'Create select
			strSelect = "SELECT * FROM TJobRecords WHERE JobNumber = '" & receiveJobNumber & "'"

			'Get records
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load Table
			dt.Load(drSourceTable)

			' Add items
			'intJobID = dt.Rows(0).Item(0)
			lblJobNumber.Text = dt.Rows(0).Item(8).ToString
			dtStartDate.Value = dt.Rows(0).Item(1).ToString
			dtEndDate.Value = dt.Rows(0).Item(2).ToString
			txtNumberEmployees.Text = dt.Rows(0).Item(3).ToString
			txtEmployeeNames.Text = dt.Rows(0).Item(4).ToString
			txtJobDescription.Text = dt.Rows(0).Item(5).ToString
			intStatus = dt.Rows(0).Item(6)

			'Set Progress
			If intStatus = 1 Then
				radScheduled.Checked = True
			ElseIf intStatus = 2 Then
				radInProgress.Checked = True
			ElseIf intStatus = 3 Then
				radCompleted.Checked = True
			End If

			' Clean up
			drSourceTable.Close()

			' close the database connection
			CloseDatabaseConnection()

			' Load jobs combo box
		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try
	End Sub

	' Update job record
	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		' Declare Variables
		Dim strupdate As String = ""
		Dim strStartDate As String = ""
		Dim strEndDate As String = ""
		Dim intNumberEmployees As Integer = 0
		Dim strEmployeeNames As String = ""
		Dim strJobDescription As String = ""
		Dim strJobNumber As String = ""
		Dim intStatusID As Integer = 0
		Dim cmdUpdate As OleDb.OleDbCommand
		Dim intRowsAffected As Integer


		Try

			If Validation() = True Then

				' Set values
				strStartDate = dtStartDate.Value.Date.ToString()
				strEndDate = dtEndDate.Value.Date.ToString()
				intNumberEmployees = txtNumberEmployees.Text
				strEmployeeNames = txtEmployeeNames.Text
				strJobDescription = txtJobDescription.Text

				' Set status ID
				If radScheduled.Checked Then
					intStatusID = 1
				ElseIf radInProgress.Checked Then
					intStatusID = 2
				ElseIf radCompleted.Checked Then
					intStatusID = 3
				End If

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
				strupdate = "UPDATE TJobRecords " &
					"SET dtStartDate = '" & strStartDate & "', " &
						"dtEndDate = '" & strEndDate & "', " &
						"intEmployees = " & intNumberEmployees & ", " &
						"strEmployeeNames = '" & strEmployeeNames & "', " &
						"strJobDesc = '" & strJobDescription & "', " &
						"intStatusID = " & intStatusID &
					" WHERE JobNumber = " & lblJobNumber.Text

				cmdUpdate = New OleDb.OleDbCommand(strupdate, m_conAdministrator)

				intRowsAffected = cmdUpdate.ExecuteNonQuery()

				If intRowsAffected > 0 Then
					MessageBox.Show("Job record has been updated.")
					Me.Close()
				End If

				CloseDatabaseConnection()

			End If

		Catch ex As Exception
			'unhandled exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub


	' Validation
	Function Validation() As Boolean

		' Declare variables
		Dim intEmployees As Integer = 0
		Dim intEmployeeNames As Integer = 0

		' Reset backcolor
		'txtStartDate.BackColor = Color.White
		'txtEndDate.BackColor = Color.White
		txtNumberEmployees.BackColor = Color.White
		txtEmployeeNames.BackColor = Color.White
		txtJobDescription.BackColor = Color.White

		'' check if something is entered in date started text box
		'If txtStartDate.Text <> String.Empty And IsDate(txtStartDate.Text) Then

		'Else
		'	' text box is blank so tell user to enter date started, change back color to yellow,
		'	' put focus in text box and return false we don't want to continue
		'	MessageBox.Show("Please enter start date.")
		'	txtStartDate.BackColor = Color.Yellow
		'	txtStartDate.Focus()
		'	Return False
		'End If

		'' check if something is entered in date ended text box
		'If txtEndDate.Text <> String.Empty And IsDate(txtEndDate.Text) Then

		'Else
		'	' text box is blank so tell user to enter date ended, change back color to yellow,
		'	' put focus in text box and return false we don't want to continue
		'	MessageBox.Show("Please enter end date.")
		'	txtEndDate.BackColor = Color.Yellow
		'	txtEndDate.Focus()
		'	Return False
		'End If

		' check if something is entered in number of employees text box
		If txtNumberEmployees.Text <> String.Empty And IsNumeric(txtNumberEmployees.Text) Then
			intEmployees = txtNumberEmployees.Text
		Else
			' text box is blank so tell user to enter number of employees, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter number of employees.")
			txtNumberEmployees.BackColor = Color.Yellow
			txtNumberEmployees.Focus()
			Return False
		End If

		' check if something is entered in employee names text box
		If txtEmployeeNames.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter employee names, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter employee names.")
			txtEmployeeNames.BackColor = Color.Yellow
			txtEmployeeNames.Focus()
			Return False
		End If

		' Check if there is the correct number of employees entered
		intEmployeeNames = CountEmployees(txtEmployeeNames.Text)
		If intEmployeeNames <> intEmployees Then

			' Tell user to enter correct amount of names
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter employee names. Format is First Last, First Last, First Last, ...")
			txtEmployeeNames.BackColor = Color.Yellow
			txtEmployeeNames.Focus()
			Return False
		End If

		' check if something is entered in description text box
		If txtJobDescription.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter description, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter job description.")
			txtJobDescription.BackColor = Color.Yellow
			txtJobDescription.Focus()
			Return False
		End If


		' Check if a radio button is chosen
		If radCompleted.Checked = False And radInProgress.Checked = False And radScheduled.Checked = False Then
			' Tell user to selct a radio button
			MessageBox.Show("Please select a radio button.")
			Return False
		End If

		Return True ' all is well in the world

	End Function

	' Count Employees
	Function CountEmployees(strEmployeeNames As String) As Integer

		' Declare variables
		Dim intEmployeeNames As Integer = 0
		Dim intLength As Integer = 0
		Dim intIndex As Integer = 0
		Dim intCount As Integer = 0

		' Get length of string
		intLength = strEmployeeNames.Length

		' Loop to find all strings
		Do
			' Look for first user
			If intCount = 0 And strEmployeeNames.Chars(intIndex) <> "," And strEmployeeNames.Chars(intIndex) <> " " Then

				' Count first person
				intEmployeeNames += 1
				intCount = 1

			ElseIf strEmployeeNames.Chars(intIndex) = "," And intCount = 1 Then

				' Increase count
				intCount = 2

			ElseIf intCount = 2 And strEmployeeNames.Chars(intIndex) <> "," And strEmployeeNames.Chars(intIndex) <> " " Then

				' Add one to employee name count
				intEmployeeNames += 1

				' Reset count
				intCount = 1
			End If

			' Increase index
			intIndex += 1
		Loop While intIndex < intLength

		Return intEmployeeNames
	End Function

End Class