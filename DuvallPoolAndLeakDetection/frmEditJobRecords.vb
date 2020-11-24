' Edit job Records form
' Last Updated: 11/4/2020
' Last modified by Matthew Estes

Public Class frmEditJobRecords
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' Close program
        Close()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

		Validation()
	End Sub

	Function Validation() As Boolean

		txtStartDate.BackColor = Color.White
		txtEndDate.BackColor = Color.White
		txtNumberEmployees.BackColor = Color.White
		txtEmployeeNames.BackColor = Color.White
		txtFirstName.BackColor = Color.White
		txtLastName.BackColor = Color.White
		txtAddress.BackColor = Color.White
		txtCity.BackColor = Color.White
		txtZip.BackColor = Color.White
		'txtEmail.BackColor = Color.White
		txtPhone.BackColor = Color.White

		' check if something is entered in date started text box
		If txtStartDate.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter date started, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter start date.")
			txtStartDate.BackColor = Color.Yellow
			txtStartDate.Focus()
			Return False
		End If

		' check if something is entered in date ended text box
		If txtEndDate.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter date ended, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter end date.")
			txtEndDate.BackColor = Color.Yellow
			txtEndDate.Focus()
			Return False
		End If

		' check if something is entered in number of employees text box
		If txtNumberEmployees.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter number of employees, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter number of employees.")
			txtNumberEmployees.BackColor = Color.Yellow
			txtNumberEmployees.Focus()
			Return False
		End If

		' check if something is entered in employee names text box
		If txtEmployeeNames.Text <> String.Empty Then

		Else
			' text box is blank so tell user to enter employee names, change back color to yellow,
			' put focus in text box and return false we don't want to continue
			MessageBox.Show("Please enter employee names.")
			txtEmployeeNames.BackColor = Color.Yellow
			txtEmployeeNames.Focus()
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

		' check if something is entered in email text box
		'If txtEmail.Text <> String.Empty Then

		'Else
		'	' text box is blank so tell user to enter email, change back color to yellow,
		'	' put focus in text box and return false we don't want to continue
		'	MessageBox.Show("Please enter Customer's email.")
		'	txtEmail.BackColor = Color.Yellow
		'	txtEmail.Focus()
		'	Return False
		'End If

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
