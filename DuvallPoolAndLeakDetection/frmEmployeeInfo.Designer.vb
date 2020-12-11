<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeInfo
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeInfo))
		Me.btnClose = New System.Windows.Forms.Button()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.lblEstimatedDuration = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.cboEmployee = New System.Windows.Forms.ComboBox()
		Me.btnAddPartToJob = New System.Windows.Forms.Button()
		Me.dgvJobs = New System.Windows.Forms.DataGridView()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(728, 474)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 34
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(275, 30)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(429, 17)
		Me.Label8.TabIndex = 33
		Me.Label8.Text = "Look up dispatched orders and add parts to them or just view them"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lblEstimatedDuration)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Location = New System.Drawing.Point(528, 72)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(444, 61)
		Me.GroupBox1.TabIndex = 31
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Job Information"
		'
		'lblEstimatedDuration
		'
		Me.lblEstimatedDuration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblEstimatedDuration.Location = New System.Drawing.Point(180, 28)
		Me.lblEstimatedDuration.Name = "lblEstimatedDuration"
		Me.lblEstimatedDuration.Size = New System.Drawing.Size(244, 23)
		Me.lblEstimatedDuration.TabIndex = 46
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(16, 27)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(128, 17)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Estimated Duration"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.Label12)
		Me.GroupBox3.Controls.Add(Me.cboEmployee)
		Me.GroupBox3.Location = New System.Drawing.Point(54, 72)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(444, 61)
		Me.GroupBox3.TabIndex = 36
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Search Information"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(16, 27)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(70, 17)
		Me.Label12.TabIndex = 14
		Me.Label12.Text = "Employee"
		'
		'cboEmployee
		'
		Me.cboEmployee.FormattingEnabled = True
		Me.cboEmployee.Location = New System.Drawing.Point(180, 26)
		Me.cboEmployee.Name = "cboEmployee"
		Me.cboEmployee.Size = New System.Drawing.Size(244, 21)
		Me.cboEmployee.TabIndex = 12
		'
		'btnAddPartToJob
		'
		Me.btnAddPartToJob.Location = New System.Drawing.Point(843, 474)
		Me.btnAddPartToJob.Name = "btnAddPartToJob"
		Me.btnAddPartToJob.Size = New System.Drawing.Size(109, 44)
		Me.btnAddPartToJob.TabIndex = 35
		Me.btnAddPartToJob.Text = "Add Employee"
		Me.btnAddPartToJob.UseVisualStyleBackColor = True
		'
		'dgvJobs
		'
		Me.dgvJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvJobs.Location = New System.Drawing.Point(12, 139)
		Me.dgvJobs.Name = "dgvJobs"
		Me.dgvJobs.ReadOnly = True
		Me.dgvJobs.Size = New System.Drawing.Size(581, 372)
		Me.dgvJobs.TabIndex = 44
		'
		'frmEmployeeInfo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1005, 539)
		Me.Controls.Add(Me.dgvJobs)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnAddPartToJob)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.GroupBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmEmployeeInfo"
		Me.Text = "View and Update Dispatched Orders"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnClose As Button
	Friend WithEvents Label8 As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label3 As Label
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents Label12 As Label
	Friend WithEvents cboEmployee As ComboBox
	Friend WithEvents lblEstimatedDuration As Label
	Friend WithEvents btnAddPartToJob As Button
	Friend WithEvents dgvJobs As DataGridView
End Class
