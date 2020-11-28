<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBankAccount
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
		Me.Label19 = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.txtRoutingNumber = New System.Windows.Forms.TextBox()
		Me.txtAccountNumber = New System.Windows.Forms.TextBox()
		Me.cboAccountType = New System.Windows.Forms.ComboBox()
		Me.txtNameOnAccount = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.Location = New System.Drawing.Point(12, 95)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(95, 17)
		Me.Label19.TabIndex = 46
		Me.Label19.Text = "Account Type"
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.Location = New System.Drawing.Point(12, 48)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(113, 17)
		Me.Label18.TabIndex = 43
		Me.Label18.Text = "Account Number"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Location = New System.Drawing.Point(12, 9)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(111, 17)
		Me.Label16.TabIndex = 44
		Me.Label16.Text = "Routing Number"
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(12, 135)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(120, 17)
		Me.Label17.TabIndex = 45
		Me.Label17.Text = "Name on Account"
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(70, 178)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 51
		Me.btnClose.Text = "Cancel"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSubmit
		'
		Me.btnSubmit.Location = New System.Drawing.Point(221, 178)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(109, 44)
		Me.btnSubmit.TabIndex = 52
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.UseVisualStyleBackColor = True
		'
		'txtRoutingNumber
		'
		Me.txtRoutingNumber.Location = New System.Drawing.Point(137, 9)
		Me.txtRoutingNumber.Name = "txtRoutingNumber"
		Me.txtRoutingNumber.Size = New System.Drawing.Size(244, 20)
		Me.txtRoutingNumber.TabIndex = 53
		'
		'txtAccountNumber
		'
		Me.txtAccountNumber.Location = New System.Drawing.Point(137, 48)
		Me.txtAccountNumber.Name = "txtAccountNumber"
		Me.txtAccountNumber.Size = New System.Drawing.Size(244, 20)
		Me.txtAccountNumber.TabIndex = 54
		'
		'cboAccountType
		'
		Me.cboAccountType.FormattingEnabled = True
		Me.cboAccountType.Location = New System.Drawing.Point(137, 95)
		Me.cboAccountType.Name = "cboAccountType"
		Me.cboAccountType.Size = New System.Drawing.Size(244, 21)
		Me.cboAccountType.TabIndex = 55
		'
		'txtNameOnAccount
		'
		Me.txtNameOnAccount.Location = New System.Drawing.Point(137, 134)
		Me.txtNameOnAccount.Name = "txtNameOnAccount"
		Me.txtNameOnAccount.Size = New System.Drawing.Size(244, 20)
		Me.txtNameOnAccount.TabIndex = 56
		'
		'frmAddBankAccount
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(395, 233)
		Me.Controls.Add(Me.txtNameOnAccount)
		Me.Controls.Add(Me.cboAccountType)
		Me.Controls.Add(Me.txtAccountNumber)
		Me.Controls.Add(Me.txtRoutingNumber)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSubmit)
		Me.Controls.Add(Me.Label19)
		Me.Controls.Add(Me.Label18)
		Me.Controls.Add(Me.Label16)
		Me.Controls.Add(Me.Label17)
		Me.Name = "frmAddBankAccount"
		Me.Text = "frmAddBankAccount"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label19 As Label
	Friend WithEvents Label18 As Label
	Friend WithEvents Label16 As Label
	Friend WithEvents Label17 As Label
	Friend WithEvents btnClose As Button
	Friend WithEvents btnSubmit As Button
	Friend WithEvents txtRoutingNumber As TextBox
	Friend WithEvents txtAccountNumber As TextBox
	Friend WithEvents cboAccountType As ComboBox
	Friend WithEvents txtNameOnAccount As TextBox
End Class
