<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentType
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
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.radCreditDebit = New System.Windows.Forms.RadioButton()
		Me.radBankTransfer = New System.Windows.Forms.RadioButton()
		Me.radCheck = New System.Windows.Forms.RadioButton()
		Me.radCash = New System.Windows.Forms.RadioButton()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.GroupBox3.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.radCreditDebit)
		Me.GroupBox3.Controls.Add(Me.radBankTransfer)
		Me.GroupBox3.Controls.Add(Me.radCheck)
		Me.GroupBox3.Controls.Add(Me.radCash)
		Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(287, 76)
		Me.GroupBox3.TabIndex = 30
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Payment Type"
		'
		'radCreditDebit
		'
		Me.radCreditDebit.AutoSize = True
		Me.radCreditDebit.Location = New System.Drawing.Point(178, 16)
		Me.radCreditDebit.Name = "radCreditDebit"
		Me.radCreditDebit.Size = New System.Drawing.Size(82, 17)
		Me.radCreditDebit.TabIndex = 20
		Me.radCreditDebit.Text = "Credit/Debit"
		Me.radCreditDebit.UseVisualStyleBackColor = True
		'
		'radBankTransfer
		'
		Me.radBankTransfer.AutoSize = True
		Me.radBankTransfer.Location = New System.Drawing.Point(178, 45)
		Me.radBankTransfer.Name = "radBankTransfer"
		Me.radBankTransfer.Size = New System.Drawing.Size(92, 17)
		Me.radBankTransfer.TabIndex = 20
		Me.radBankTransfer.Text = "Bank Transfer"
		Me.radBankTransfer.UseVisualStyleBackColor = True
		'
		'radCheck
		'
		Me.radCheck.AutoSize = True
		Me.radCheck.Location = New System.Drawing.Point(37, 48)
		Me.radCheck.Name = "radCheck"
		Me.radCheck.Size = New System.Drawing.Size(56, 17)
		Me.radCheck.TabIndex = 20
		Me.radCheck.Text = "Check"
		Me.radCheck.UseVisualStyleBackColor = True
		'
		'radCash
		'
		Me.radCash.AutoSize = True
		Me.radCash.Checked = True
		Me.radCash.Location = New System.Drawing.Point(37, 16)
		Me.radCash.Name = "radCash"
		Me.radCash.Size = New System.Drawing.Size(49, 17)
		Me.radCash.TabIndex = 20
		Me.radCash.TabStop = True
		Me.radCash.Text = "Cash"
		Me.radCash.UseVisualStyleBackColor = True
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(30, 108)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 31
		Me.btnClose.Text = "Cancel"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSubmit
		'
		Me.btnSubmit.Location = New System.Drawing.Point(181, 108)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(109, 44)
		Me.btnSubmit.TabIndex = 32
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.UseVisualStyleBackColor = True
		'
		'frmPaymentType
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ClientSize = New System.Drawing.Size(318, 164)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSubmit)
		Me.Controls.Add(Me.GroupBox3)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmPaymentType"
		Me.Text = "Payment Type"
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents radCreditDebit As RadioButton
	Friend WithEvents radBankTransfer As RadioButton
	Friend WithEvents radCheck As RadioButton
	Friend WithEvents radCash As RadioButton
	Friend WithEvents btnClose As Button
	Friend WithEvents btnSubmit As Button
End Class
