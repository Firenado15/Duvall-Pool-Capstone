' Previous Orders form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmPreviousOrders

	Dim intVendorID As Integer

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close form
		Me.Close()

	End Sub

	Private Sub frmPreviousOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

			cboOrderNumber.BeginUpdate()

			'Create select
			strSelect = "SELECT intPartID, strSerialNumber FROM TParts"

			'Get records
			cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
			drSourceTable = cmdSelect.ExecuteReader

			'Load Table
			dt.Load(drSourceTable)

			' Add items to combo box
			cboOrderNumber.ValueMember = "intPartID"
			cboOrderNumber.DisplayMember = "intPartID"
			cboOrderNumber.DataSource = dt

			' Select the first item in the list by default
			If cboOrderNumber.Items.Count > 0 Then cboOrderNumber.SelectedIndex = 0

			' Show changes
			cboOrderNumber.EndUpdate()

			' Clean up
			drSourceTable.Close()

			' close the database connection
			CloseDatabaseConnection()

		Catch ex As Exception

			'Unhandled Exception
			MessageBox.Show(ex.Message)

		End Try

	End Sub

	Private Sub cboOrderNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrderNumber.SelectedIndexChanged

		Try

			LoadPartInfo()

			LoadVendorInfo()

		Catch ex As Exception

			MessageBox.Show(ex.Message)
		End Try

	End Sub

	Private Sub LoadPartInfo()

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
		strSelect = "SELECT * FROM TParts WHERE intPartID = " & cboOrderNumber.SelectedValue.ToString


		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'load the data table from the reader
		dt.Load(drSourceTable)

		'populate text boxes
		lblPartNumber.Text = dt.Rows(0).Item(2).ToString
		lblPartDescription.Text = dt.Rows(0).Item(3).ToString
		lblQuantity.Text = dt.Rows(0).Item(4).ToString
		lblCostPerUnit.Text = "$" & dt.Rows(0).Item(5).ToString
		intVendorID = dt.Rows(0).Item(1)

		'close connection
		CloseDatabaseConnection()

	End Sub

	Private Sub LoadVendorInfo()

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
		strSelect = "SELECT * FROM vVendors WHERE intVendorID = " & intVendorID

		'Retrieve records 
		cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
		drSourceTable = cmdSelect.ExecuteReader

		'load the data table from the reader
		dt.Load(drSourceTable)

		'populate labels
		lblVendorIdentification.Text = "VID-00" & dt.Rows(0).Item(0).ToString & " - " & dt.Rows(0).Item(1).ToString
		lblVendorName.Text = dt.Rows(0).Item(1).ToString
		lblContactName.Text = dt.Rows(0).Item(2).ToString
		lblAddress.Text = dt.Rows(0).Item(3).ToString
		lblCity.Text = dt.Rows(0).Item(4).ToString
		lblState.Text = dt.Rows(0).Item(5).ToString
		lblZip.Text = dt.Rows(0).Item(6).ToString
		lblPhone.Text = dt.Rows(0).Item(7).ToString
		lblEmail.Text = dt.Rows(0).Item(8).ToString

		'close connection
		CloseDatabaseConnection()

	End Sub

End Class