' Dispatch Orders form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmDispatchOrders
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' Close program
        Close()

    End Sub
    
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Validation()

    End Sub

    Function Validation() As Boolean

        txtJobNumber.BackColor = Color.White
        txtEstimatedDuration.BackColor = Color.White
        txtFirstName.BackColor = Color.White
        txtLastName.BackColor = Color.White
        txtAddress.BackColor = Color.White
        txtCity.BackColor = Color.White
        txtZip.BackColor = Color.White
        txtPhone.BackColor = Color.White


        ' check if something is entered in job number text box
        If txtJobNumber.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter job number, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter job number.")
            txtJobNumber.BackColor = Color.Yellow
            txtJobNumber.Focus()
            Return False
        End If

        ' check if something is entered in estimated duration text box
        If txtEstimatedDuration.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter estimated duration, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter estimated duration.")
            txtEstimatedDuration.BackColor = Color.Yellow
            txtEstimatedDuration.Focus()
            Return False
        End If

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

        ' check if something is entered in street address text box
        If txtAddress.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter street address, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter Customer's street address.")
            txtAddress.BackColor = Color.Yellow
            txtAddress.Focus()
            Return False
        End If

        ' check if something is entered in city text box
        If txtCity.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter city, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter Customer's city.")
            txtCity.BackColor = Color.Yellow
            txtCity.Focus()
            Return False
        End If

        ' check if something is entered in zip text box
        If txtZip.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter zip, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter Customer's zip.")
            txtZip.BackColor = Color.Yellow
            txtZip.Focus()
            Return False
        End If

        ' check if something is entered in phone number text box
        If txtPhone.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter phone number, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter Customer's phone number.")
            txtPhone.BackColor = Color.Yellow
            txtPhone.Focus()
            Return False
        End If

        Return True ' all is well in the world

    End Function
End Class
