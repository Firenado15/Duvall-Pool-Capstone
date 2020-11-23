<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerIntake
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.cboState = New System.Windows.Forms.ComboBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.txtZipCode = New System.Windows.Forms.TextBox()
		Me.txtCity = New System.Windows.Forms.TextBox()
		Me.txtAddress = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtLastName = New System.Windows.Forms.TextBox()
		Me.txtFirstName = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(97, 12)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(199, 17)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Enter information for customer"
		'
		'btnSubmit
		'
		Me.btnSubmit.Location = New System.Drawing.Point(300, 399)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(109, 44)
		Me.btnSubmit.TabIndex = 24
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.UseVisualStyleBackColor = True
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(149, 399)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 24
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'cboState
		'
		Me.cboState.FormattingEnabled = True
		Me.cboState.Location = New System.Drawing.Point(149, 215)
		Me.cboState.Name = "cboState"
		Me.cboState.Size = New System.Drawing.Size(244, 21)
		Me.cboState.TabIndex = 5
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(28, 344)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(103, 17)
		Me.Label9.TabIndex = 35
		Me.Label9.Text = "Phone Number"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(28, 302)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(98, 17)
		Me.Label8.TabIndex = 36
		Me.Label8.Text = "Email Address"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(28, 258)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(65, 17)
		Me.Label7.TabIndex = 37
		Me.Label7.Text = "Zip Code"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(28, 215)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(41, 17)
		Me.Label6.TabIndex = 38
		Me.Label6.Text = "State"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(28, 179)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(31, 17)
		Me.Label5.TabIndex = 39
		Me.Label5.Text = "City"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(28, 140)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(60, 17)
		Me.Label4.TabIndex = 40
		Me.Label4.Text = "Address"
		'
		'txtPhoneNumber
		'
		Me.txtPhoneNumber.Location = New System.Drawing.Point(149, 343)
		Me.txtPhoneNumber.Name = "txtPhoneNumber"
		Me.txtPhoneNumber.Size = New System.Drawing.Size(244, 20)
		Me.txtPhoneNumber.TabIndex = 8
		'
		'txtEmail
		'
		Me.txtEmail.Location = New System.Drawing.Point(149, 301)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(244, 20)
		Me.txtEmail.TabIndex = 7
		'
		'txtZipCode
		'
		Me.txtZipCode.Location = New System.Drawing.Point(149, 257)
		Me.txtZipCode.Name = "txtZipCode"
		Me.txtZipCode.Size = New System.Drawing.Size(244, 20)
		Me.txtZipCode.TabIndex = 6
		'
		'txtCity
		'
		Me.txtCity.Location = New System.Drawing.Point(149, 176)
		Me.txtCity.Name = "txtCity"
		Me.txtCity.Size = New System.Drawing.Size(244, 20)
		Me.txtCity.TabIndex = 4
		'
		'txtAddress
		'
		Me.txtAddress.Location = New System.Drawing.Point(149, 137)
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Size = New System.Drawing.Size(244, 20)
		Me.txtAddress.TabIndex = 3
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(28, 100)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(76, 17)
		Me.Label3.TabIndex = 34
		Me.Label3.Text = "Last Name"
		'
		'txtLastName
		'
		Me.txtLastName.Location = New System.Drawing.Point(149, 97)
		Me.txtLastName.Name = "txtLastName"
		Me.txtLastName.Size = New System.Drawing.Size(244, 20)
		Me.txtLastName.TabIndex = 2
		'
		'txtFirstName
		'
		Me.txtFirstName.Location = New System.Drawing.Point(149, 57)
		Me.txtFirstName.Name = "txtFirstName"
		Me.txtFirstName.Size = New System.Drawing.Size(244, 20)
		Me.txtFirstName.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(28, 58)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(76, 17)
		Me.Label2.TabIndex = 31
		Me.Label2.Text = "First Name"
		'
		'frmCustomerIntake
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(433, 465)
		Me.Controls.Add(Me.cboState)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtPhoneNumber)
		Me.Controls.Add(Me.txtEmail)
		Me.Controls.Add(Me.txtZipCode)
		Me.Controls.Add(Me.txtCity)
		Me.Controls.Add(Me.txtAddress)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtLastName)
		Me.Controls.Add(Me.txtFirstName)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSubmit)
		Me.Controls.Add(Me.Label1)
		Me.Name = "frmCustomerIntake"
		Me.Text = "Customer Intake"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents btnSubmit As Button
	Friend WithEvents btnClose As Button
	Friend WithEvents cboState As ComboBox
	Friend WithEvents Label9 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtPhoneNumber As TextBox
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents txtZipCode As TextBox
	Friend WithEvents txtCity As TextBox
	Friend WithEvents txtAddress As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtLastName As TextBox
	Friend WithEvents txtFirstName As TextBox
	Friend WithEvents Label2 As Label
End Class
