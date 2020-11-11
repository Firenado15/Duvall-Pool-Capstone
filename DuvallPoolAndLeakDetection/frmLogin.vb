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
        Options.ShowDialog()

    End Sub

End Class
