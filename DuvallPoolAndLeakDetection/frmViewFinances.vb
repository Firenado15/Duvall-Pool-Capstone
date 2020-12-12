' View Finances form
' Last Updated: 11/30/2020
' Last modified by Matthew Estes

Public Class frmViewFinances

	' Close form
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close form
		Close()

	End Sub



	' Load in the finance date lists
	Private Sub frmViewFinances_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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



	' Update after the selected index is changed
	Private Sub cboDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDate.SelectedIndexChanged

		' Declare variables
		Dim intYear As Integer = 0
		Dim intMonth As Integer = 0
		Dim strSelect As String = ""
		Dim strName As String = ""
		Dim strTotalCostYTD As String = ""
		Dim dblOutstandingMonthly As Double = 0
		Dim dblOutstandingYTD As Double = 0
		Dim dblPaidRevenueMonthly As Double = 0
		Dim dblPaidRevenueYTD As Double = 0
		Dim dblInventoryCostMonthly As Double = 0
		Dim dblInventoryCostYTD As Double = 0
		Dim dblTotalCostMonthly As Double = 0
		Dim dblTotalCostYTD As Double = 0
		Dim dblGrossProfitMonthly As Double = 0
		Dim dblGrossProfitYTD As Double = 0
		Dim dblProfitMarginMonthly As Double = 0
		Dim dblProfitMarginYTD As Double = 0
		Dim cmdSelect As OleDb.OleDbCommand 'Select
		Dim cmdSelect2 As OleDb.OleDbCommand 'Select
		Dim cmdSelect3 As OleDb.OleDbCommand 'Select
		Dim cmdSelect4 As OleDb.OleDbCommand 'Select
		Dim cmdSelect5 As OleDb.OleDbCommand 'Select
		Dim cmdSelect6 As OleDb.OleDbCommand 'Select
		Dim drSourceTable As OleDb.OleDbDataReader 'retrieved data
		Dim drSourceTable2 As OleDb.OleDbDataReader 'retrieved data
		Dim drSourceTable3 As OleDb.OleDbDataReader 'retrieved data
		Dim drSourceTable4 As OleDb.OleDbDataReader 'retrieved data
		Dim drSourceTable5 As OleDb.OleDbDataReader 'retrieved data
		Dim drSourceTable6 As OleDb.OleDbDataReader 'retrieved data
		Dim dt As DataTable = New DataTable 'reader
		Dim dt2 As DataTable = New DataTable 'reader

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
		lblMonthlyPayroll.Text = "$" & dt.Rows(0).Item(1).ToString
		lblMonthlyInsurance.Text = "$" & dt.Rows(0).Item(2).ToString
		lblMonthlyProject.Text = "$" & dt.Rows(0).Item(3).ToString
		lblMonthlyVehicle.Text = "$" & dt.Rows(0).Item(4).ToString
		lblMonthlyFuel.Text = "$" & dt.Rows(0).Item(5).ToString
		lblMonthlyRent.Text = "$" & dt.Rows(0).Item(6).ToString
		lblMonthlyUtilities.Text = "$" & dt.Rows(0).Item(7).ToString
		lblMonthlyOther.Text = "$" & dt.Rows(0).Item(8).ToString
		dblTotalCostMonthly = CDbl(dt.Rows(0).Item(9))
		intMonth = dt.Rows(0).Item(10)
		intYear = CInt(dt.Rows(0).Item(11))


		'Select statement
		strSelect = "SELECT * FROM vYTDFinances WHERE intFinanceID = " & cboDate.SelectedValue.ToString

		'Retrieve records 
		cmdSelect2 = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable2 = cmdSelect2.ExecuteReader

		'load the data table from the reader
		dt2.Load(drSourceTable2)

		'populate YTD text boxes
		lblYTDPayroll.Text = "$" & dt2.Rows(0).Item(1).ToString
		lblYTDInsurance.Text = "$" & dt2.Rows(0).Item(2).ToString
		lblYTDProject.Text = "$" & dt2.Rows(0).Item(3).ToString
		lblYTDVehicle.Text = "$" & dt2.Rows(0).Item(4).ToString
		lblYTDFuel.Text = "$" & dt2.Rows(0).Item(5).ToString
		lblYTDRent.Text = "$" & dt2.Rows(0).Item(6).ToString
		lblYTDUtilities.Text = "$" & dt2.Rows(0).Item(7).ToString
		lblYTDOther.Text = "$" & dt2.Rows(0).Item(8).ToString
		dblTotalCostYTD = CDbl(dt2.Rows(0).Item(9))

		' Build the select statement
		strSelect = "SELECT Total, Paid FROM vMonthlyRevenue WHERE MonthDate = " & intMonth & " and YearDate = " & intYear

		'Execute
		cmdSelect3 = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable3 = cmdSelect3.ExecuteReader

		'load the data table from the reader
		drSourceTable3.Read()

		'Check for empty table
		If drSourceTable3.IsDBNull(0) = False Then
			dblPaidRevenueMonthly = CDbl((drSourceTable3.Item(1)))
			lblMonthlyPaidRevenue.Text = "$" & dblPaidRevenueMonthly.ToString("F2")
			dblOutstandingMonthly = CDbl((drSourceTable3.Item(0)) - (drSourceTable3.Item(1)))
			lblMonthlyOutstandingRevenue.Text = "$" & dblOutstandingMonthly.ToString("F2")
		End If

		' Build the select statement
		strSelect = "SELECT TotalCost FROM vPartsOrderedCost WHERE MonthDate = " & intMonth & " and YearDate = " & intYear

		'Execute
		cmdSelect4 = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable4 = cmdSelect4.ExecuteReader

		'load the data table from the reader
		drSourceTable4.Read()

		'Check for empty table
		If drSourceTable4.IsDBNull(0) = False Then
			dblInventoryCostMonthly = CDbl((drSourceTable4.Item(0)))
			lblMonthlyInventory.Text = "$" & dblInventoryCostMonthly.ToString("F2")
		End If

		' Set total monthly cost
		dblTotalCostMonthly += dblInventoryCostMonthly

		' Build the select statement
		strSelect = "SELECT SUM(Total), SUM(Paid) FROM vMonthlyRevenue WHERE MonthDate <= " & intMonth & " and YearDate = " & intYear

		'Execute
		cmdSelect5 = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable5 = cmdSelect5.ExecuteReader

		'load the data table from the reader
		drSourceTable5.Read()

		'Check for empty table
		If drSourceTable5.IsDBNull(0) = False Then
			dblPaidRevenueYTD = CDbl((drSourceTable5.Item(1)))
			lblYearlyRevenuePaid.Text = "$" & dblPaidRevenueYTD.ToString("F2")
			dblOutstandingYTD = CDbl((drSourceTable5.Item(0)) - (drSourceTable5.Item(1)))
			lblYearlyOutstandingRevenue.Text = "$" & dblOutstandingYTD.ToString("F2")
		End If

		' Build the select statement
		strSelect = "SELECT SUM(TotalCost) FROM vPartsOrderedCost WHERE MonthDate <= " & intMonth & " and YearDate = " & intYear

		'Execute
		cmdSelect6 = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable6 = cmdSelect6.ExecuteReader

		'load the data table from the reader
		drSourceTable6.Read()

		'Check for empty table
		If drSourceTable6.IsDBNull(0) = False Then
			dblInventoryCostYTD = CDbl((drSourceTable6.Item(0)))
			lblYTDInventory.Text = "$" & dblInventoryCostYTD.ToString("F2")
		End If

		' Set total YTD cost
		dblTotalCostYTD += dblInventoryCostYTD

		' Set gross profits
		dblGrossProfitMonthly = dblPaidRevenueMonthly - dblTotalCostMonthly
		dblGrossProfitYTD = dblPaidRevenueYTD - dblTotalCostYTD

		' Set gross profit labels
		lblMonthlyGross.Text = "$" & dblGrossProfitMonthly.ToString("F2")
		lblYTDGross.Text = "$" & dblGrossProfitYTD.ToString("F2")

		' Set profit margin
		dblProfitMarginMonthly = (dblGrossProfitMonthly / dblPaidRevenueMonthly) * 100
		dblProfitMarginYTD = (dblGrossProfitYTD / dblPaidRevenueYTD) * 100

		' Set profit margin labels
		lblMonthlyMargin.Text = dblProfitMarginMonthly.ToString("F2") & "%"
		lblYTDMargin.Text = dblProfitMarginYTD.ToString("F2") & "%"

		'close connection
		CloseDatabaseConnection()
	End Sub



	' Create a new edit finance form
	Private Sub btnEditFinances_Click(sender As Object, e As EventArgs) Handles btnEditFinances.Click

		' create a new instance of the edit finances form
		Dim EditFinance As New frmEditFinances

		' show the new form so any past data is not still on the form
		EditFinance.ShowDialog()

		'Reload finance info after update
		cboDate_SelectedIndexChanged(sender, e)

	End Sub
End Class