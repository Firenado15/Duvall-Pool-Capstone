Public Class frmAddCreditCard
	'variable for intCustomerID, restricted to this form
	Dim receiveCustomerID As Integer

	Public Sub New(ByVal passedCustomerID As Integer)

		'Receive current intCustomerID from whichever form called this one
		InitializeComponent()
		receiveCustomerID = passedCustomerID

	End Sub

	Private Sub frmAddCreditCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class