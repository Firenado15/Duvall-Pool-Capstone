<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDispatchOrders
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDispatchOrders))
		Me.btnRemoveFromJob = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.lstAssigned = New System.Windows.Forms.ListBox()
		Me.lstAvailable = New System.Windows.Forms.ListBox()
		Me.cboJob = New System.Windows.Forms.ComboBox()
		Me.cboName = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnRemoveFromJob
		'
		Me.btnRemoveFromJob.Location = New System.Drawing.Point(248, 239)
		Me.btnRemoveFromJob.Name = "btnRemoveFromJob"
		Me.btnRemoveFromJob.Size = New System.Drawing.Size(88, 23)
		Me.btnRemoveFromJob.TabIndex = 12
		Me.btnRemoveFromJob.Text = "<<"
		Me.btnRemoveFromJob.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(248, 192)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(88, 23)
		Me.Button1.TabIndex = 11
		Me.Button1.Text = ">>"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'lstAssigned
		'
		Me.lstAssigned.FormattingEnabled = True
		Me.lstAssigned.Location = New System.Drawing.Point(342, 111)
		Me.lstAssigned.Name = "lstAssigned"
		Me.lstAssigned.Size = New System.Drawing.Size(230, 238)
		Me.lstAssigned.TabIndex = 10
		'
		'lstAvailable
		'
		Me.lstAvailable.FormattingEnabled = True
		Me.lstAvailable.Location = New System.Drawing.Point(12, 111)
		Me.lstAvailable.Name = "lstAvailable"
		Me.lstAvailable.Size = New System.Drawing.Size(230, 238)
		Me.lstAvailable.TabIndex = 9
		'
		'cboJob
		'
		Me.cboJob.FormattingEnabled = True
		Me.cboJob.Location = New System.Drawing.Point(170, 48)
		Me.cboJob.Name = "cboJob"
		Me.cboJob.Size = New System.Drawing.Size(230, 21)
		Me.cboJob.TabIndex = 8
		'
		'cboName
		'
		Me.cboName.FormattingEnabled = True
		Me.cboName.Location = New System.Drawing.Point(170, 12)
		Me.cboName.Name = "cboName"
		Me.cboName.Size = New System.Drawing.Size(230, 21)
		Me.cboName.TabIndex = 7
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(76, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(88, 13)
		Me.Label1.TabIndex = 13
		Me.Label1.Text = "Customer Name :"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(94, 51)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(70, 13)
		Me.Label2.TabIndex = 14
		Me.Label2.Text = "Job Number :"
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(469, 355)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(103, 35)
		Me.btnClose.TabIndex = 15
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(9, 95)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(104, 13)
		Me.Label3.TabIndex = 16
		Me.Label3.Text = "Available Employees"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(339, 95)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(104, 13)
		Me.Label4.TabIndex = 17
		Me.Label4.Text = "Assigned Employees"
		'
		'frmDispatchOrders
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(587, 402)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnRemoveFromJob)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.lstAssigned)
		Me.Controls.Add(Me.lstAvailable)
		Me.Controls.Add(Me.cboJob)
		Me.Controls.Add(Me.cboName)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmDispatchOrders"
		Me.Text = "Dispatch Orders"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnRemoveFromJob As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents lstAssigned As ListBox
	Friend WithEvents lstAvailable As ListBox
	Friend WithEvents cboJob As ComboBox
	Friend WithEvents cboName As ComboBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents btnClose As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
End Class
