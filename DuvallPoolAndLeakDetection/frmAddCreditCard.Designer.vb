<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCreditCard
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
		Me.radAmericanExpress = New System.Windows.Forms.RadioButton()
		Me.radMastercard = New System.Windows.Forms.RadioButton()
		Me.radVisa = New System.Windows.Forms.RadioButton()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtCardholderName = New System.Windows.Forms.TextBox()
		Me.txtCardNumber = New System.Windows.Forms.TextBox()
		Me.txtExpiration = New System.Windows.Forms.TextBox()
		Me.txtCVV = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cboCardType = New System.Windows.Forms.ComboBox()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'radAmericanExpress
		'
		Me.radAmericanExpress.AutoSize = True
		Me.radAmericanExpress.Location = New System.Drawing.Point(252, 12)
		Me.radAmericanExpress.Name = "radAmericanExpress"
		Me.radAmericanExpress.Size = New System.Drawing.Size(109, 17)
		Me.radAmericanExpress.TabIndex = 47
		Me.radAmericanExpress.Text = "American Express"
		Me.radAmericanExpress.UseVisualStyleBackColor = True
		'
		'radMastercard
		'
		Me.radMastercard.AutoSize = True
		Me.radMastercard.Location = New System.Drawing.Point(133, 12)
		Me.radMastercard.Name = "radMastercard"
		Me.radMastercard.Size = New System.Drawing.Size(78, 17)
		Me.radMastercard.TabIndex = 48
		Me.radMastercard.Text = "Mastercard"
		Me.radMastercard.UseVisualStyleBackColor = True
		'
		'radVisa
		'
		Me.radVisa.AutoSize = True
		Me.radVisa.Checked = True
		Me.radVisa.Location = New System.Drawing.Point(31, 12)
		Me.radVisa.Name = "radVisa"
		Me.radVisa.Size = New System.Drawing.Size(45, 17)
		Me.radVisa.TabIndex = 49
		Me.radVisa.TabStop = True
		Me.radVisa.Text = "Visa"
		Me.radVisa.UseVisualStyleBackColor = True
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(8, 130)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(70, 17)
		Me.Label15.TabIndex = 46
		Me.Label15.Text = "Expiration"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(8, 87)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(92, 17)
		Me.Label14.TabIndex = 43
		Me.Label14.Text = "Card Number"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Location = New System.Drawing.Point(8, 174)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(120, 17)
		Me.Label13.TabIndex = 44
		Me.Label13.Text = "CVV/CVC Number"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(8, 48)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(119, 17)
		Me.Label12.TabIndex = 45
		Me.Label12.Text = "Cardholder Name"
		'
		'txtCardholderName
		'
		Me.txtCardholderName.Location = New System.Drawing.Point(133, 47)
		Me.txtCardholderName.Name = "txtCardholderName"
		Me.txtCardholderName.Size = New System.Drawing.Size(244, 20)
		Me.txtCardholderName.TabIndex = 1
		'
		'txtCardNumber
		'
		Me.txtCardNumber.Location = New System.Drawing.Point(133, 84)
		Me.txtCardNumber.MaxLength = 20
		Me.txtCardNumber.Name = "txtCardNumber"
		Me.txtCardNumber.Size = New System.Drawing.Size(244, 20)
		Me.txtCardNumber.TabIndex = 2
		'
		'txtExpiration
		'
		Me.txtExpiration.Location = New System.Drawing.Point(133, 127)
		Me.txtExpiration.MaxLength = 5
		Me.txtExpiration.Name = "txtExpiration"
		Me.txtExpiration.Size = New System.Drawing.Size(244, 20)
		Me.txtExpiration.TabIndex = 3
		'
		'txtCVV
		'
		Me.txtCVV.Location = New System.Drawing.Point(134, 171)
		Me.txtCVV.MaxLength = 3
		Me.txtCVV.Name = "txtCVV"
		Me.txtCVV.Size = New System.Drawing.Size(243, 20)
		Me.txtCVV.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(7, 210)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(74, 17)
		Me.Label1.TabIndex = 57
		Me.Label1.Text = "Card Type"
		'
		'cboCardType
		'
		Me.cboCardType.FormattingEnabled = True
		Me.cboCardType.Location = New System.Drawing.Point(133, 209)
		Me.cboCardType.Name = "cboCardType"
		Me.cboCardType.Size = New System.Drawing.Size(244, 21)
		Me.cboCardType.TabIndex = 5
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(68, 242)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 7
		Me.btnClose.Text = "Cancel"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSubmit
		'
		Me.btnSubmit.Location = New System.Drawing.Point(219, 242)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(109, 44)
		Me.btnSubmit.TabIndex = 6
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.UseVisualStyleBackColor = True
		'
		'frmAddCreditCard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(400, 298)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSubmit)
		Me.Controls.Add(Me.cboCardType)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtCVV)
		Me.Controls.Add(Me.txtExpiration)
		Me.Controls.Add(Me.txtCardNumber)
		Me.Controls.Add(Me.txtCardholderName)
		Me.Controls.Add(Me.radAmericanExpress)
		Me.Controls.Add(Me.radMastercard)
		Me.Controls.Add(Me.radVisa)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.Label12)
		Me.Name = "frmAddCreditCard"
		Me.Text = "Add Credit / Debit Card"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents radAmericanExpress As RadioButton
	Friend WithEvents radMastercard As RadioButton
	Friend WithEvents radVisa As RadioButton
	Friend WithEvents Label15 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents txtCardholderName As TextBox
	Friend WithEvents txtCardNumber As TextBox
	Friend WithEvents txtExpiration As TextBox
	Friend WithEvents txtCVV As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents cboCardType As ComboBox
	Friend WithEvents btnClose As Button
	Friend WithEvents btnSubmit As Button
End Class
