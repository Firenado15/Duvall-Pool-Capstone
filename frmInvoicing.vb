' Invoicing form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmInvoicing
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' Close program
        Close()

    End Sub
    
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Validation()
    End Sub

    Function Validation() As Boolean

        txtFirstName.BackColor = Color.White
        txtLastName.BackColor = Color.White
        txtDateStarted.BackColor = Color.White
        txtDateEnded.BackColor = Color.White
        txtClosing.BackColor = Color.White
        txtOpening.BackColor = Color.White
        txtDueDate.BackColor = Color.White


        ' check if something is entered in first name text box
        If txtFirstName.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter first name, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter Customer's first name.")
            txtFirstName.BackColor = Color.Yellow
            txtFirstName.Focus()
            Return False
        End If

        ' check if something is entered in last name text box
        If txtLastName.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter last name, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter Customer's last name.")
            txtLastName.BackColor = Color.Yellow
            txtLastName.Focus()
            Return False
        End If

        ' check if something is entered in date started text box
        If txtDateStarted.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter date started, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter date started.")
            txtDateStarted.BackColor = Color.Yellow
            txtDateStarted.Focus()
            Return False
        End If

        ' check if something is entered in date ended text box
        If txtDateEnded.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter date ended, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter date ended.")
            txtDateEnded.BackColor = Color.Yellow
            txtDateEnded.Focus()
            Return False
        End If

        ' check if something is entered in closing date text box
        If txtClosing.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter closing date, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter closing date.")
            txtClosing.BackColor = Color.Yellow
            txtClosing.Focus()
            Return False
        End If

        ' check if something is entered in opening date text box
        If txtOpening.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter opening date, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter opening date.")
            txtOpening.BackColor = Color.Yellow
            txtOpening.Focus()
            Return False
        End If

        ' check if something is entered in due date text box
        If txtDueDate.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter due date, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter due date of invoice.")
            txtDueDate.BackColor = Color.Yellow
            txtDueDate.Focus()
            Return False
        End If

        Return True ' all is well in the world

    End Function
End Class
