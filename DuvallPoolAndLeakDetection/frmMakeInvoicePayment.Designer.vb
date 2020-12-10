<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMakeInvoicePayment
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMakeInvoicePayment))
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtPaymentAmount = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(12, 63)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 9
		Me.btnClose.Text = "Cancel"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSubmit
		'
		Me.btnSubmit.Location = New System.Drawing.Point(127, 63)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(109, 44)
		Me.btnSubmit.TabIndex = 8
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(18, 26)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(93, 13)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "Payment Amount :"
		'
		'txtPaymentAmount
		'
		Me.txtPaymentAmount.Location = New System.Drawing.Point(117, 23)
		Me.txtPaymentAmount.Name = "txtPaymentAmount"
		Me.txtPaymentAmount.Size = New System.Drawing.Size(126, 20)
		Me.txtPaymentAmount.TabIndex = 11
		'
		'frmMakePayment
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(255, 124)
		Me.Controls.Add(Me.txtPaymentAmount)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSubmit)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(271, 163)
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(271, 163)
		Me.Name = "frmMakePayment"
		Me.ShowInTaskbar = False
		Me.Text = "Make a payment"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnClose As Button
	Friend WithEvents btnSubmit As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents txtPaymentAmount As TextBox
End Class
