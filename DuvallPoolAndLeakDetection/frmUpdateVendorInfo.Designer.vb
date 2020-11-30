<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateVendorInfo
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateVendorInfo))
		Me.cboState = New System.Windows.Forms.ComboBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.txtPhone = New System.Windows.Forms.TextBox()
		Me.txtZipCode = New System.Windows.Forms.TextBox()
		Me.txtCity = New System.Windows.Forms.TextBox()
		Me.txtAddress = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtContactName = New System.Windows.Forms.TextBox()
		Me.txtVendorName = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'cboState
		'
		Me.cboState.FormattingEnabled = True
		Me.cboState.Location = New System.Drawing.Point(133, 218)
		Me.cboState.Name = "cboState"
		Me.cboState.Size = New System.Drawing.Size(244, 21)
		Me.cboState.TabIndex = 64
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(12, 307)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(103, 17)
		Me.Label9.TabIndex = 73
		Me.Label9.Text = "Phone Number"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(12, 349)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(98, 17)
		Me.Label8.TabIndex = 74
		Me.Label8.Text = "Email Address"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(12, 261)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(65, 17)
		Me.Label7.TabIndex = 75
		Me.Label7.Text = "Zip Code"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(12, 218)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(41, 17)
		Me.Label6.TabIndex = 76
		Me.Label6.Text = "State"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(12, 182)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(31, 17)
		Me.Label5.TabIndex = 77
		Me.Label5.Text = "City"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(12, 143)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(60, 17)
		Me.Label4.TabIndex = 78
		Me.Label4.Text = "Address"
		'
		'txtEmail
		'
		Me.txtEmail.Location = New System.Drawing.Point(133, 346)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(244, 20)
		Me.txtEmail.TabIndex = 68
		'
		'txtPhone
		'
		Me.txtPhone.Location = New System.Drawing.Point(133, 304)
		Me.txtPhone.Name = "txtPhone"
		Me.txtPhone.Size = New System.Drawing.Size(244, 20)
		Me.txtPhone.TabIndex = 67
		'
		'txtZipCode
		'
		Me.txtZipCode.Location = New System.Drawing.Point(133, 260)
		Me.txtZipCode.Name = "txtZipCode"
		Me.txtZipCode.Size = New System.Drawing.Size(244, 20)
		Me.txtZipCode.TabIndex = 66
		'
		'txtCity
		'
		Me.txtCity.Location = New System.Drawing.Point(133, 179)
		Me.txtCity.Name = "txtCity"
		Me.txtCity.Size = New System.Drawing.Size(244, 20)
		Me.txtCity.TabIndex = 63
		'
		'txtAddress
		'
		Me.txtAddress.Location = New System.Drawing.Point(133, 140)
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Size = New System.Drawing.Size(244, 20)
		Me.txtAddress.TabIndex = 62
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(12, 103)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(97, 17)
		Me.Label3.TabIndex = 72
		Me.Label3.Text = "Contact Name"
		'
		'txtContactName
		'
		Me.txtContactName.Location = New System.Drawing.Point(133, 100)
		Me.txtContactName.Name = "txtContactName"
		Me.txtContactName.Size = New System.Drawing.Size(244, 20)
		Me.txtContactName.TabIndex = 61
		'
		'txtVendorName
		'
		Me.txtVendorName.Location = New System.Drawing.Point(133, 60)
		Me.txtVendorName.Name = "txtVendorName"
		Me.txtVendorName.Size = New System.Drawing.Size(244, 20)
		Me.txtVendorName.TabIndex = 60
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(12, 61)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(95, 17)
		Me.Label2.TabIndex = 71
		Me.Label2.Text = "Vendor Name"
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(133, 402)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 70
		Me.btnClose.Text = "Cancel"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSubmit
		'
		Me.btnSubmit.Location = New System.Drawing.Point(284, 402)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(109, 44)
		Me.btnSubmit.TabIndex = 69
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(130, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(185, 17)
		Me.Label1.TabIndex = 65
		Me.Label1.Text = "Enter information for vendor"
		'
		'frmUpdateVendorInfo
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
		Me.Controls.Add(Me.txtEmail)
		Me.Controls.Add(Me.txtPhone)
		Me.Controls.Add(Me.txtZipCode)
		Me.Controls.Add(Me.txtCity)
		Me.Controls.Add(Me.txtAddress)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtContactName)
		Me.Controls.Add(Me.txtVendorName)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSubmit)
		Me.Controls.Add(Me.Label1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmUpdateVendorInfo"
		Me.Text = "Update Vendor Info"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents cboState As ComboBox
	Friend WithEvents Label9 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents txtPhone As TextBox
	Friend WithEvents txtZipCode As TextBox
	Friend WithEvents txtCity As TextBox
	Friend WithEvents txtAddress As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtContactName As TextBox
	Friend WithEvents txtVendorName As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents btnClose As Button
	Friend WithEvents btnSubmit As Button
	Friend WithEvents Label1 As Label
End Class
