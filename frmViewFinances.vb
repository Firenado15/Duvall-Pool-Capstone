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
		Dim strYear As String = ""
		Dim strSelect As String = ""
		Dim strName As String = ""
		Dim cmdSelect As OleDb.OleDbCommand 'Select
		Dim cmdSelect2 As OleDb.OleDbCommand 'Select
		Dim drSourceTable As OleDb.OleDbDataReader 'retrieved data
		Dim drSourceTable2 As OleDb.OleDbDataReader 'retrieved data
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
		lblMonthlyPayroll.Text = dt.Rows(0).Item(1).ToString
		lblMonthlyInventory.Text = dt.Rows(0).Item(2).ToString
		lblMonthlyInsurance.Text = dt.Rows(0).Item(3).ToString
		lblMonthlyProject.Text = dt.Rows(0).Item(4).ToString
		lblMonthlyVehicle.Text = dt.Rows(0).Item(5).ToString
		lblMonthlyFuel.Text = dt.Rows(0).Item(6).ToString
		lblMonthlyRent.Text = dt.Rows(0).Item(7).ToString
		lblMonthlyUtilities.Text = dt.Rows(0).Item(8).ToString
		lblMonthlyOther.Text = dt.Rows(0).Item(9).ToString
		lblMonthlyRevenue.Text = dt.Rows(0).Item(10).ToString
		lblMonthlyGross.Text = dt.Rows(0).Item(11).ToString
		lblMonthlyMargin.Text = dt.Rows(0).Item(12).ToString

		'Select statement
		strSelect = "SELECT * FROM vYTDFinances WHERE intFinanceID = " & cboDate.SelectedValue.ToString

		'Retrieve records 
		cmdSelect2 = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable2 = cmdSelect2.ExecuteReader

		'load the data table from the reader
		dt2.Load(drSourceTable2)

		'populate YTD text boxes
		lblYTDPayroll.Text = dt2.Rows(0).Item(1).ToString
		lblYTDInventory.Text = dt2.Rows(0).Item(2).ToString
		lblYTDInsurance.Text = dt2.Rows(0).Item(3).ToString
		lblYTDProject.Text = dt2.Rows(0).Item(4).ToString
		lblYTDVehicle.Text = dt2.Rows(0).Item(5).ToString
		lblYTDFuel.Text = dt2.Rows(0).Item(6).ToString
		lblYTDRent.Text = dt2.Rows(0).Item(7).ToString
		lblYTDUtilities.Text = dt2.Rows(0).Item(8).ToString
		lblYTDOther.Text = dt2.Rows(0).Item(9).ToString
		lblYTDRevenue.Text = dt2.Rows(0).Item(10).ToString
		lblYTDGross.Text = dt2.Rows(0).Item(11).ToString
		lblYTDMargin.Text = dt2.Rows(0).Item(12).ToString

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