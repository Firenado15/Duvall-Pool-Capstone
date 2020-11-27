<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
		Me.btnEnter = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.txtUsername = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'btnEnter
		'
		Me.btnEnter.Location = New System.Drawing.Point(263, 131)
		Me.btnEnter.Name = "btnEnter"
		Me.btnEnter.Size = New System.Drawing.Size(146, 59)
		Me.btnEnter.TabIndex = 0
		Me.btnEnter.Text = "Enter"
		Me.btnEnter.UseVisualStyleBackColor = True
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(33, 131)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(146, 59)
		Me.btnClose.TabIndex = 1
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'txtUsername
		'
		Me.txtUsername.Location = New System.Drawing.Point(165, 23)
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.Size = New System.Drawing.Size(244, 20)
		Me.txtUsername.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(30, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(111, 17)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Enter Username"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(30, 82)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(107, 17)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Enter Password"
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(165, 81)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(244, 20)
		Me.txtPassword.TabIndex = 5
		'
		'frmLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(427, 216)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtUsername)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnEnter)
		Me.Name = "frmLogin"
		Me.Text = "Duvall Pool and Leak Detection Login"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnEnter As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
End Class
