' Login form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmLogin
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' Close program
        Close()

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' create a new instance of the add form
        Dim Options As New frmOptions

		' show the new form so any past data is not still on the form

		Me.Visible = False

		Options.ShowDialog()

		Close()


	End Sub

	Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class
