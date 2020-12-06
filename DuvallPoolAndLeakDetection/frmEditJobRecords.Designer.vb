<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditJobRecords
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditJobRecords))
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.radCompleted = New System.Windows.Forms.RadioButton()
		Me.radInProgress = New System.Windows.Forms.RadioButton()
		Me.radScheduled = New System.Windows.Forms.RadioButton()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.lblJobNumber = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.dtEndDate = New System.Windows.Forms.DateTimePicker()
		Me.dtStartDate = New System.Windows.Forms.DateTimePicker()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtJobDescription = New System.Windows.Forms.TextBox()
		Me.txtEmployeeNames = New System.Windows.Forms.TextBox()
		Me.txtNumberEmployees = New System.Windows.Forms.TextBox()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.radCompleted)
		Me.GroupBox3.Controls.Add(Me.radInProgress)
		Me.GroupBox3.Controls.Add(Me.radScheduled)
		Me.GroupBox3.Location = New System.Drawing.Point(12, 331)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(444, 59)
		Me.GroupBox3.TabIndex = 47
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Job Status"
		'
		'radCompleted
		'
		Me.radCompleted.AutoSize = True
		Me.radCompleted.Location = New System.Drawing.Point(328, 29)
		Me.radCompleted.Name = "radCompleted"
		Me.radCompleted.Size = New System.Drawing.Size(75, 17)
		Me.radCompleted.TabIndex = 2
		Me.radCompleted.TabStop = True
		Me.radCompleted.Text = "Completed"
		Me.radCompleted.UseVisualStyleBackColor = True
		'
		'radInProgress
		'
		Me.radInProgress.AutoSize = True
		Me.radInProgress.Location = New System.Drawing.Point(180, 29)
		Me.radInProgress.Name = "radInProgress"
		Me.radInProgress.Size = New System.Drawing.Size(78, 17)
		Me.radInProgress.TabIndex = 1
		Me.radInProgress.TabStop = True
		Me.radInProgress.Text = "In Progress"
		Me.radInProgress.UseVisualStyleBackColor = True
		'
		'radScheduled
		'
		Me.radScheduled.AutoSize = True
		Me.radScheduled.Location = New System.Drawing.Point(19, 29)
		Me.radScheduled.Name = "radScheduled"
		Me.radScheduled.Size = New System.Drawing.Size(76, 17)
		Me.radScheduled.TabIndex = 0
		Me.radScheduled.TabStop = True
		Me.radScheduled.Text = "Scheduled"
		Me.radScheduled.UseVisualStyleBackColor = True
		'
		'btnClose
		'
		Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnClose.Location = New System.Drawing.Point(192, 414)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 51
		Me.btnClose.Text = "Cancel"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSubmit
		'
		Me.btnSubmit.Location = New System.Drawing.Point(335, 414)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(109, 44)
		Me.btnSubmit.TabIndex = 49
		Me.btnSubmit.Text = "Update"
		Me.btnSubmit.UseVisualStyleBackColor = True
		'
		'lblJobNumber
		'
		Me.lblJobNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblJobNumber.Location = New System.Drawing.Point(180, 18)
		Me.lblJobNumber.Name = "lblJobNumber"
		Me.lblJobNumber.Size = New System.Drawing.Size(244, 23)
		Me.lblJobNumber.TabIndex = 1
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.dtEndDate)
		Me.GroupBox1.Controls.Add(Me.dtStartDate)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label14)
		Me.GroupBox1.Controls.Add(Me.lblJobNumber)
		Me.GroupBox1.Controls.Add(Me.Label15)
		Me.GroupBox1.Controls.Add(Me.Label13)
		Me.GroupBox1.Controls.Add(Me.Label12)
		Me.GroupBox1.Controls.Add(Me.Label11)
		Me.GroupBox1.Controls.Add(Me.txtJobDescription)
		Me.GroupBox1.Controls.Add(Me.txtEmployeeNames)
		Me.GroupBox1.Controls.Add(Me.txtNumberEmployees)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(444, 313)
		Me.GroupBox1.TabIndex = 46
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Job Information"
		'
		'dtEndDate
		'
		Me.dtEndDate.Location = New System.Drawing.Point(180, 97)
		Me.dtEndDate.Name = "dtEndDate"
		Me.dtEndDate.Size = New System.Drawing.Size(244, 20)
		Me.dtEndDate.TabIndex = 15
		'
		'dtStartDate
		'
		Me.dtStartDate.Location = New System.Drawing.Point(180, 59)
		Me.dtStartDate.Name = "dtStartDate"
		Me.dtStartDate.Size = New System.Drawing.Size(244, 20)
		Me.dtStartDate.TabIndex = 14
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(16, 17)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(85, 17)
		Me.Label2.TabIndex = 13
		Me.Label2.Text = "Job Number"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(16, 56)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(147, 17)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Start Date (estimated)"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(16, 239)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(106, 17)
		Me.Label14.TabIndex = 11
		Me.Label14.Text = "Job Description"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(16, 193)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(142, 17)
		Me.Label15.TabIndex = 11
		Me.Label15.Text = "(First Last, First Last)"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Location = New System.Drawing.Point(16, 176)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(118, 17)
		Me.Label13.TabIndex = 11
		Me.Label13.Text = "Employee Names"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(16, 139)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(147, 17)
		Me.Label12.TabIndex = 11
		Me.Label12.Text = "Number of Employees"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(16, 100)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(146, 17)
		Me.Label11.TabIndex = 9
		Me.Label11.Text = "End Date (estimated) "
		'
		'txtJobDescription
		'
		Me.txtJobDescription.Location = New System.Drawing.Point(180, 221)
		Me.txtJobDescription.Multiline = True
		Me.txtJobDescription.Name = "txtJobDescription"
		Me.txtJobDescription.Size = New System.Drawing.Size(244, 71)
		Me.txtJobDescription.TabIndex = 4
		'
		'txtEmployeeNames
		'
		Me.txtEmployeeNames.Location = New System.Drawing.Point(180, 173)
		Me.txtEmployeeNames.Name = "txtEmployeeNames"
		Me.txtEmployeeNames.Size = New System.Drawing.Size(244, 20)
		Me.txtEmployeeNames.TabIndex = 3
		'
		'txtNumberEmployees
		'
		Me.txtNumberEmployees.Location = New System.Drawing.Point(180, 135)
		Me.txtNumberEmployees.Name = "txtNumberEmployees"
		Me.txtNumberEmployees.Size = New System.Drawing.Size(244, 20)
		Me.txtNumberEmployees.TabIndex = 2
		'
		'frmEditJobRecords
		'
		Me.AcceptButton = Me.btnSubmit
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnClose
		Me.ClientSize = New System.Drawing.Size(480, 483)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSubmit)
		Me.Controls.Add(Me.GroupBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmEditJobRecords"
		Me.Text = "Edit Job Details"
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents radCompleted As RadioButton
	Friend WithEvents radInProgress As RadioButton
	Friend WithEvents radScheduled As RadioButton
	Friend WithEvents btnClose As Button
	Friend WithEvents btnSubmit As Button
	Friend WithEvents lblJobNumber As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents txtJobDescription As TextBox
	Friend WithEvents txtEmployeeNames As TextBox
	Friend WithEvents txtNumberEmployees As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents dtEndDate As DateTimePicker
	Friend WithEvents dtStartDate As DateTimePicker
End Class
