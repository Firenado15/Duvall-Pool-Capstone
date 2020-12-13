' Edit Finances form
' Last Updated: 11/30/2020
' Last modified by Matthew Estes

Public Class frmEditFinances


	' Close form
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close form
		Close()

	End Sub



	' Runs when form loads, sets combo box
	Private Sub frmEditFinances_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

			cboDate.BeginUpdate()

			'Select statement
			strSelect = "SELECT intFinanceID, ( strMonth + ', ' + strYear ) AS MonthAndYear FROM vMonthAndYear ORDER BY intFinanceID Desc"

			'Retrieve records 
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'load the data table from the reader
			dt.Load(drSourceTable)

			' Add items to combo box
			cboDate.ValueMember = "intFinanceID"
			cboDate.DisplayMember = "MonthAndYear"
			cboDate.DataSource = dt

			' Select the first item in the list by default
			If cboDate.Items.Count > 0 Then cboDate.SelectedIndex = 0

			' Show changes
			cboDate.EndUpdate()

			' Clean up
			drSourceTable.Close()

			' close the database connection
			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try


	End Sub



	' Updates when a change happens in combo box
	Private Sub cboDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDate.SelectedIndexChanged

		' Declare variables
		Dim intYear As Integer = 0
		Dim intMonth As Integer = 0
		Dim dblOutstandingRevenue As Double = 0
		Dim strYear As String = ""
		Dim strSelect As String = ""
		Dim strName As String = ""
		Dim cmdSelect As OleDb.OleDbCommand 'select
		Dim cmdSelect2 As OleDb.OleDbCommand 'select
		Dim cmdSelect3 As OleDb.OleDbCommand 'select
		Dim drSourceTable As OleDb.OleDbDataReader 'retrieved data
		Dim drSourceTable2 As OleDb.OleDbDataReader 'retrieved data
		Dim drSourceTable3 As OleDb.OleDbDataReader 'retrieved data
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
		strSelect = "SELECT * FROM vMonthlyFinances WHERE intFinanceID = " & cboDate.SelectedValue.ToString

		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'load the data table from the reader
		dt.Load(drSourceTable)

		'populate monthly text boxes
		txtPayroll.Text = dt.Rows(0).Item(1).ToString
		txtInsurance.Text = dt.Rows(0).Item(2).ToString
		txtVehicle.Text = dt.Rows(0).Item(3).ToString
		txtFuel.Text = dt.Rows(0).Item(4).ToString
		txtRent.Text = dt.Rows(0).Item(5).ToString
		txtUtilities.Text = dt.Rows(0).Item(6).ToString
		txtOther.Text = dt.Rows(0).Item(7).ToString
		intMonth = dt.Rows(0).Item(9)
		intYear = CInt(dt.Rows(0).Item(10))

		' Build the select statement
		strSelect = "SELECT Total, Paid FROM vMonthlyRevenue WHERE MonthDate = " & intMonth & " and YearDate = " & intYear

		'Execute
		cmdSelect2 = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable2 = cmdSelect2.ExecuteReader

		'load the data table from the reader
		drSourceTable2.Read()

		'Check for empty table
		If drSourceTable2.IsDBNull(0) = False Then
			lblPaidRevenue.Text = "$" & drSourceTable2.Item(1)
			dblOutstandingRevenue = CDbl((drSourceTable2.Item(0)) - (drSourceTable2.Item(1)))
			lblOutstandingRevenue.Text = "$" & dblOutstandingRevenue.ToString("F2")
		End If

		' Build the select statement
		strSelect = "SELECT TotalCost FROM vPartsOrderedCost WHERE MonthDate = " & intMonth & " and YearDate = " & intYear

		'Execute
		cmdSelect3 = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable3 = cmdSelect3.ExecuteReader

		'load the data table from the reader
		drSourceTable3.Read()

		'Check for empty table
		If drSourceTable3.IsDBNull(0) = False Then
			lblInventory.Text = "$" & drSourceTable3.Item(0).ToString
		End If

		'close connection
		CloseDatabaseConnection()

	End Sub



	' Submit update
	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		'Variables
		Dim strUpdate As String
		Dim strPayroll As String = ""
		Dim strInventory As String = ""
		Dim strInsurance As String = ""
		Dim strVehicle As String = ""
		Dim strFuel As String = ""
		Dim strRent As String = ""
		Dim strUtilities As String = ""
		Dim strOther As String = ""
		Dim strRevenue As String = ""
		Dim intFinanceIDMax As Integer = 0
		Dim intFinanceID = 0
		Dim strSelect As String = ""
		Dim cmdSelect As OleDb.OleDbCommand
		Dim drSourceTable As OleDb.OleDbDataReader
		Dim cmdUpdate As OleDb.OleDbCommand
		Dim intRowsAffected As Integer


		Try

			If Validation() = True Then

				' Set values
				strPayroll = txtPayroll.Text
				strInsurance = txtInsurance.Text
				strVehicle = txtVehicle.Text
				strFuel = txtFuel.Text
				strRent = txtRent.Text
				strUtilities = txtUtilities.Text
				strOther = txtOther.Text

				If OpenDatabaseConnectionSQLServer() = False Then

					'Alert if no connection
					MessageBox.Show(Me, "Database connection error." & vbNewLine &
										"The application will now close.",
										Me.Text + " Error",
										MessageBoxButtons.OK, MessageBoxIcon.Error)

					'Close Form
					Me.Close()

				End If

				' Build the select statement
				strSelect = "SELECT MAX(intFinanceID) AS intFinanceIDMax " &
							" FROM TFinances"

				'Execute
				cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
				drSourceTable = cmdSelect.ExecuteReader

				'Read
				drSourceTable.Read()

				'Not empty, add 1 to next line
				intFinanceIDMax = CInt(drSourceTable.Item(0))

				' Close the reader
				drSourceTable.Close()

				' Set Financial ID number
				intFinanceID = intFinanceIDMax - cboDate.SelectedIndex

				'Create update statement
				strUpdate = "UPDATE TFinances " &
					"SET decPayrollCost = " & strPayroll & ", " &
						"decInsuranceCost = " & strInsurance & ", " &
						"decVehicleCost = " & strVehicle & ", " &
						"decFuelCost = " & strFuel & ", " &
						"decShopRental = " & strRent & ", " &
						"decUtilitiesCost = " & strUtilities & ", " &
						"decOtherCost = " & strOther &
					" WHERE intFinanceID = " & intFinanceID

				cmdUpdate = New OleDb.OleDbCommand(strUpdate, m_conAdministrator)

				intRowsAffected = cmdUpdate.ExecuteNonQuery()

				If intRowsAffected > 0 Then
					MessageBox.Show("Financial info has been updated.")
					Me.Close()
				End If

				CloseDatabaseConnection()

			End If

		Catch ex As Exception
			'unhandled exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub



	' Validate Input
	Function Validation() As Boolean

		txtPayroll.BackColor = Color.White
		txtInsurance.BackColor = Color.White
		txtVehicle.BackColor = Color.White
		txtFuel.BackColor = Color.White
		txtRent.BackColor = Color.White
		txtUtilities.BackColor = Color.White
		txtOther.BackColor = Color.White

		' check if something is entered in Payroll text box
		If txtPayroll.Text <> String.Empty And IsNumeric(txtPayroll.Text) Then

		Else
			' text box is blank so tell user to enter payroll, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter payroll expense.")
			txtPayroll.BackColor = Color.Yellow
			txtPayroll.Focus()
			Return False
		End If

		' check if something is entered in Insurance text box
		If txtInsurance.Text <> String.Empty And IsNumeric(txtInsurance.Text) Then

		Else
			' text box is blank so tell user to enter insurance, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter insurance expense.")
			txtInsurance.BackColor = Color.Yellow
			txtInsurance.Focus()
			Return False
		End If

		' check if something is entered in Vehicle text box
		If txtVehicle.Text <> String.Empty And IsNumeric(txtVehicle.Text) Then

		Else
			' text box is blank so tell user to enter vehicle, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter vehicle expense.")
			txtVehicle.BackColor = Color.Yellow
			txtVehicle.Focus()
			Return False
		End If

		' check if something is entered in Fuel text box
		If txtFuel.Text <> String.Empty And IsNumeric(txtFuel.Text) Then

		Else
			' text box is blank so tell user to enter fuel, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter fuel expense.")
			txtFuel.BackColor = Color.Yellow
			txtFuel.Focus()
			Return False
		End If

		' check if something is entered in Rent text box
		If txtRent.Text <> String.Empty And IsNumeric(txtRent.Text) Then

		Else
			' text box is blank so tell user to enter rent, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter rent expense.")
			txtRent.BackColor = Color.Yellow
			txtRent.Focus()
			Return False
		End If

		' check if something is entered in Utility text box
		If txtUtilities.Text <> String.Empty And IsNumeric(txtUtilities.Text) Then

		Else
			' text box is blank so tell user to enter utility, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter utilities expense.")
			txtUtilities.BackColor = Color.Yellow
			txtUtilities.Focus()
			Return False
		End If

		' check if something is entered in Other text box
		If txtOther.Text <> String.Empty And IsNumeric(txtOther.Text) Then

		Else
			' text box is blank so tell user to enter other, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter other expenses.")
			txtOther.BackColor = Color.Yellow
			txtOther.Focus()
			Return False
		End If

		Return True ' all is well in the world

	End Function
End Class