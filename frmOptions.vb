' Options form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmOptions

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		' Close program
		Application.Exit()
		End

	End Sub

	Private Sub btnCustomerIntake_Click(sender As Object, e As EventArgs) Handles btnCustomerIntake.Click

		' create a new instance of the customer intake form
		Dim CustomerIntake As New frmCustomerIntake

		' show the new form so any past data is not still on the form
		CustomerIntake.ShowDialog()

	End Sub

	Private Sub btnViewPreviousCustomer_Click(sender As Object, e As EventArgs) Handles btnViewPreviousCustomer.Click

		' create a new instance of the previous customer form
		Dim PreviousCustomer As New frmPreviousCustomer

		' show the new form so any past data is not still on the form
		PreviousCustomer.ShowDialog()

	End Sub

	Private Sub btnPartsOrdering_Click(sender As Object, e As EventArgs) Handles btnPartsOrdering.Click

		' create a new instance of the parts ordering form
		Dim PartsOrdering As New frmPartsOrdering

		' show the new form so any past data is not still on the form
		PartsOrdering.ShowDialog()

	End Sub

	Private Sub btnPreviousPartsOrders_Click(sender As Object, e As EventArgs) Handles btnPreviousPartsOrders.Click

		' create a new instance of the previous orders form
		Dim PreviousOrders As New frmPreviousOrders

		' show the new form so any past data is not still on the form
		PreviousOrders.ShowDialog()

	End Sub

	Private Sub btnDispatchOrders_Click_1(sender As Object, e As EventArgs) Handles btnDispatchOrders.Click

		' create a new instance of the dispatch orders form
		Dim DispatchOrders As New frmDispatchOrders

		' show the new form so any past data is not still on the form
		DispatchOrders.ShowDialog()

	End Sub

	Private Sub btnViewOrders_Click(sender As Object, e As EventArgs) Handles btnViewOrders.Click

		' create a new instance of the view and update dispatched orders form
		Dim ViewAndUpdateDispatchedOrders As New frmViewAndUpdateDispatchedOrders

		' show the new form so any past data is not still on the form
		ViewAndUpdateDispatchedOrders.ShowDialog()

	End Sub

	Private Sub btnInventoryManagement_Click(sender As Object, e As EventArgs) Handles btnInventoryManagement.Click

		' create a new instance of the inventory management form
		Dim InventoryManagement As New frmInventoryManagement

		' show the new form so any past data is not still on the form
		InventoryManagement.ShowDialog()

	End Sub

	Private Sub btnInvoicing_Click(sender As Object, e As EventArgs) Handles btnInvoicing.Click

		' create a new instance of the invoicing form
		Dim Invoicing As New frmInvoicing

		' show the new form so any past data is not still on the form
		Invoicing.ShowDialog()

	End Sub

	Private Sub btnPreviousInvoices_Click(sender As Object, e As EventArgs) Handles btnPreviousInvoices.Click

		' create a new instance of the previous invoices form
		Dim PreviousInvoices As New frmPreviousInvoices

		' show the new form so any past data is not still on the form
		PreviousInvoices.ShowDialog()

	End Sub

	Private Sub btnEditFinances_Click(sender As Object, e As EventArgs) Handles btnEditFinances.Click

		' create a new instance of the edit finances form
		Dim EditFinances As New frmEditFinances

		' show the new form so any past data is not still on the form
		EditFinances.ShowDialog()

	End Sub

	Private Sub btnViewFinances_Click(sender As Object, e As EventArgs) Handles btnViewFinances.Click

		' create a new instance of the view finances form
		Dim ViewFinances As New frmViewFinances

		' show the new form so any past data is not still on the form
		ViewFinances.ShowDialog()

	End Sub

	Private Sub btnEditJobRecords_Click(sender As Object, e As EventArgs) Handles btnEditJobRecords.Click

		' create a new instance of the edit job records form
		Dim EditJobRecords As New frmEditJobRecords

		' show the new form so any past data is not still on the form
		EditJobRecords.ShowDialog()

	End Sub

	Private Sub btnCustomerReviews_Click(sender As Object, e As EventArgs) Handles btnCustomerReviews.Click

		Dim webAddress As String = "https://www.womply.com/biz/duvall-pool-and-leak-detection-olive-branch-MS/"
		Process.Start(webAddress)

	End Sub

	Private Sub frmOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load



	End Sub
End Class