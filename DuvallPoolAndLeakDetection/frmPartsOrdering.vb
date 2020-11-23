' Parts Ordering form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmPartsOrdering
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' Close program
        Close()

    End Sub
    
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        
        ' After Validation, run submit and assign values to variables
        Validation()
    End Sub

    Function Validation() As Boolean

        txtVendorName.BackColor = Color.White
        txtContactName.BackColor = Color.White
        txtAddress.BackColor = Color.White
        txtCity.BackColor = Color.White
        txtZip.BackColor = Color.White
        txtEmail.BackColor = Color.White
        txtPhone.BackColor = Color.White
        txtPurchaseOrder.BackColor = Color.White
        txtJobNumber.BackColor = Color.White
        txtPartName.BackColor = Color.White
        txtPartDescription.BackColor = Color.White
        txtQuantity.BackColor = Color.White
        txtCostPerUnit.BackColor = Color.White
        txtVendorIdentification.BackColor = Color.White

        ' check if something is entered in vendor name text box
        If txtVendorName.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter vendor name, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter Vendor's name.")
            txtVendorName.BackColor = Color.Yellow
            txtVendorName.Focus()
            Return False
        End If

        ' check if something is entered in contact name text box
        If txtContactName.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter contact name, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter Contact's name.")
            txtContactName.BackColor = Color.Yellow
            txtContactName.Focus()
            Return False
        End If

        ' check if something is entered in street address text box
        If txtAddress.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter street address, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter Vendor's street address.")
            txtAddress.BackColor = Color.Yellow
            txtAddress.Focus()
            Return False
        End If

        ' check if something is entered in city text box
        If txtCity.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter city, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter Vendor's city.")
            txtCity.BackColor = Color.Yellow
            txtCity.Focus()
            Return False
        End If

        ' check if something is entered in zip text box
        If txtZip.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter zip, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter Vendor's zip.")
            txtZip.BackColor = Color.Yellow
            txtZip.Focus()
            Return False
        End If

        ' check if something is entered in email text box
        If txtEmail.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter email, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter Vendor's email.")
            txtEmail.BackColor = Color.Yellow
            txtEmail.Focus()
            Return False
        End If

        ' check if something is entered in phone number text box
        If txtPhone.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter phone number, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter Vendor's phone number.")
            txtPhone.BackColor = Color.Yellow
            txtPhone.Focus()
            Return False
        End If

        ' check if something is entered in purchase order text box
        If txtPurchaseOrder.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter purchase order, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter purchase order.")
            txtPurchaseOrder.BackColor = Color.Yellow
            txtPurchaseOrder.Focus()
            Return False
        End If

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

        ' check if something is entered in part name text box
        If txtPartName.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter part name, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter part name.")
            txtPartName.BackColor = Color.Yellow
            txtPartName.Focus()
            Return False
        End If

        ' check if something is entered in part description text box
        If txtPartDescription.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter part description, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter part description.")
            txtPartDescription.BackColor = Color.Yellow
            txtPartDescription.Focus()
            Return False
        End If

        ' check if something is entered in quantity text box
        If txtQuantity.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter quantity, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter quantity.")
            txtQuantity.BackColor = Color.Yellow
            txtQuantity.Focus()
            Return False
        End If

        ' check if something is entered in cost per unit text box
        If txtCostPerUnit.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter cost per unit, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter cost per unit.")
            txtCostPerUnit.BackColor = Color.Yellow
            txtCostPerUnit.Focus()
            Return False
        End If

        ' check if something is entered in identification number text box
        If txtVendorIdentification.Text <> String.Empty Then

        Else
            ' text box is blank so tell user to enter identification number, change back color to yellow,
            ' put focus in text box and return false we don't want to continue
            MessageBox.Show("Please enter Vendor's identification number.")
            txtVendorIdentification.BackColor = Color.Yellow
            txtVendorIdentification.Focus()
            Return False
        End If

        Return True ' all is well in the world

    End Function
End Class
