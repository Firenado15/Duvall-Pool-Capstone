<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobDetails
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJobDetails))
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.lblStatus = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblCustomerName = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblJobNumber = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.lblDescription = New System.Windows.Forms.Label()
		Me.lblEmployeeNames = New System.Windows.Forms.Label()
		Me.lblNumberOfEmployees = New System.Windows.Forms.Label()
		Me.lblEndDate = New System.Windows.Forms.Label()
		Me.lblStartDate = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lblStatus)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.lblCustomerName)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.lblJobNumber)
		Me.GroupBox1.Controls.Add(Me.Label14)
		Me.GroupBox1.Controls.Add(Me.lblDescription)
		Me.GroupBox1.Controls.Add(Me.lblEmployeeNames)
		Me.GroupBox1.Controls.Add(Me.lblNumberOfEmployees)
		Me.GroupBox1.Controls.Add(Me.lblEndDate)
		Me.GroupBox1.Controls.Add(Me.lblStartDate)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label13)
		Me.GroupBox1.Controls.Add(Me.Label12)
		Me.GroupBox1.Controls.Add(Me.Label11)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(444, 386)
		Me.GroupBox1.TabIndex = 2
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Job Information"
		'
		'lblStatus
		'
		Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblStatus.Location = New System.Drawing.Point(180, 342)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(244, 28)
		Me.lblStatus.TabIndex = 18
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(16, 342)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(75, 17)
		Me.Label4.TabIndex = 17
		Me.Label4.Text = "Job Status"
		'
		'lblCustomerName
		'
		Me.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCustomerName.Location = New System.Drawing.Point(180, 60)
		Me.lblCustomerName.Name = "lblCustomerName"
		Me.lblCustomerName.Size = New System.Drawing.Size(244, 23)
		Me.lblCustomerName.TabIndex = 16
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(16, 60)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(68, 17)
		Me.Label1.TabIndex = 15
		Me.Label1.Text = "Customer"
		'
		'lblJobNumber
		'
		Me.lblJobNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblJobNumber.Location = New System.Drawing.Point(180, 16)
		Me.lblJobNumber.Name = "lblJobNumber"
		Me.lblJobNumber.Size = New System.Drawing.Size(244, 23)
		Me.lblJobNumber.TabIndex = 14
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(16, 263)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(106, 17)
		Me.Label14.TabIndex = 13
		Me.Label14.Text = "Job Description"
		'
		'lblDescription
		'
		Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDescription.Location = New System.Drawing.Point(180, 263)
		Me.lblDescription.Name = "lblDescription"
		Me.lblDescription.Size = New System.Drawing.Size(244, 58)
		Me.lblDescription.TabIndex = 12
		'
		'lblEmployeeNames
		'
		Me.lblEmployeeNames.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblEmployeeNames.Location = New System.Drawing.Point(180, 220)
		Me.lblEmployeeNames.Name = "lblEmployeeNames"
		Me.lblEmployeeNames.Size = New System.Drawing.Size(244, 28)
		Me.lblEmployeeNames.TabIndex = 12
		'
		'lblNumberOfEmployees
		'
		Me.lblNumberOfEmployees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNumberOfEmployees.Location = New System.Drawing.Point(180, 182)
		Me.lblNumberOfEmployees.Name = "lblNumberOfEmployees"
		Me.lblNumberOfEmployees.Size = New System.Drawing.Size(244, 23)
		Me.lblNumberOfEmployees.TabIndex = 12
		'
		'lblEndDate
		'
		Me.lblEndDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblEndDate.Location = New System.Drawing.Point(180, 143)
		Me.lblEndDate.Name = "lblEndDate"
		Me.lblEndDate.Size = New System.Drawing.Size(244, 23)
		Me.lblEndDate.TabIndex = 12
		'
		'lblStartDate
		'
		Me.lblStartDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblStartDate.Location = New System.Drawing.Point(180, 101)
		Me.lblStartDate.Name = "lblStartDate"
		Me.lblStartDate.Size = New System.Drawing.Size(244, 23)
		Me.lblStartDate.TabIndex = 12
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(16, 16)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(85, 17)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Job Number"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(16, 101)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(72, 17)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Start Date"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Location = New System.Drawing.Point(16, 220)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(118, 17)
		Me.Label13.TabIndex = 11
		Me.Label13.Text = "Employee Names"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(16, 182)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(147, 17)
		Me.Label12.TabIndex = 11
		Me.Label12.Text = "Number of Employees"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(16, 143)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(67, 17)
		Me.Label11.TabIndex = 9
		Me.Label11.Text = "End Date"
		'
		'btnClose
		'
		Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnClose.Location = New System.Drawing.Point(369, 406)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(89, 44)
		Me.btnClose.TabIndex = 34
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'frmJobDetails
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(464, 457)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.GroupBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmJobDetails"
		Me.Text = "Job Details"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label14 As Label
	Friend WithEvents lblDescription As Label
	Friend WithEvents lblEmployeeNames As Label
	Friend WithEvents lblNumberOfEmployees As Label
	Friend WithEvents lblEndDate As Label
	Friend WithEvents lblStartDate As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents lblJobNumber As Label
	Friend WithEvents lblCustomerName As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents lblStatus As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents btnClose As Button
End Class
