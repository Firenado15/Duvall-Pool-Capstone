<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoicing
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoicing))
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.cboJob = New System.Windows.Forms.ComboBox()
		Me.cboCustomer = New System.Windows.Forms.ComboBox()
		Me.Job = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.chkInstallation = New System.Windows.Forms.CheckBox()
		Me.chkTesting = New System.Windows.Forms.CheckBox()
		Me.chkDetection = New System.Windows.Forms.CheckBox()
		Me.chkVacuumed = New System.Windows.Forms.CheckBox()
		Me.chkSkimmed = New System.Windows.Forms.CheckBox()
		Me.chkChemicals = New System.Windows.Forms.CheckBox()
		Me.chkFilter = New System.Windows.Forms.CheckBox()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.radNo = New System.Windows.Forms.RadioButton()
		Me.radYes = New System.Windows.Forms.RadioButton()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.dtInvoiceDueDate = New System.Windows.Forms.DateTimePicker()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox5.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.cboJob)
		Me.GroupBox1.Controls.Add(Me.cboCustomer)
		Me.GroupBox1.Controls.Add(Me.Job)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Location = New System.Drawing.Point(27, 60)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(395, 96)
		Me.GroupBox1.TabIndex = 14
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Contact Information"
		'
		'cboJob
		'
		Me.cboJob.FormattingEnabled = True
		Me.cboJob.Location = New System.Drawing.Point(127, 59)
		Me.cboJob.Name = "cboJob"
		Me.cboJob.Size = New System.Drawing.Size(254, 21)
		Me.cboJob.TabIndex = 15
		'
		'cboCustomer
		'
		Me.cboCustomer.FormattingEnabled = True
		Me.cboCustomer.Location = New System.Drawing.Point(127, 19)
		Me.cboCustomer.Name = "cboCustomer"
		Me.cboCustomer.Size = New System.Drawing.Size(254, 21)
		Me.cboCustomer.TabIndex = 14
		'
		'Job
		'
		Me.Job.AutoSize = True
		Me.Job.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Job.Location = New System.Drawing.Point(16, 59)
		Me.Job.Name = "Job"
		Me.Job.Size = New System.Drawing.Size(31, 17)
		Me.Job.TabIndex = 13
		Me.Job.Text = "Job"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(16, 17)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(68, 17)
		Me.Label2.TabIndex = 12
		Me.Label2.Text = "Customer"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(272, 27)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(196, 17)
		Me.Label1.TabIndex = 15
		Me.Label1.Text = "Enter information for invoicing"
		'
		'chkInstallation
		'
		Me.chkInstallation.AutoSize = True
		Me.chkInstallation.Location = New System.Drawing.Point(48, 18)
		Me.chkInstallation.Name = "chkInstallation"
		Me.chkInstallation.Size = New System.Drawing.Size(102, 17)
		Me.chkInstallation.TabIndex = 21
		Me.chkInstallation.Text = "Liner Installation"
		Me.chkInstallation.UseVisualStyleBackColor = True
		'
		'chkTesting
		'
		Me.chkTesting.AutoSize = True
		Me.chkTesting.Location = New System.Drawing.Point(48, 58)
		Me.chkTesting.Name = "chkTesting"
		Me.chkTesting.Size = New System.Drawing.Size(93, 17)
		Me.chkTesting.TabIndex = 21
		Me.chkTesting.Text = "Water Testing"
		Me.chkTesting.UseVisualStyleBackColor = True
		'
		'chkDetection
		'
		Me.chkDetection.AutoSize = True
		Me.chkDetection.Location = New System.Drawing.Point(48, 97)
		Me.chkDetection.Name = "chkDetection"
		Me.chkDetection.Size = New System.Drawing.Size(99, 17)
		Me.chkDetection.TabIndex = 21
		Me.chkDetection.Text = "Leak Detection"
		Me.chkDetection.UseVisualStyleBackColor = True
		'
		'chkVacuumed
		'
		Me.chkVacuumed.AutoSize = True
		Me.chkVacuumed.Location = New System.Drawing.Point(48, 139)
		Me.chkVacuumed.Name = "chkVacuumed"
		Me.chkVacuumed.Size = New System.Drawing.Size(77, 17)
		Me.chkVacuumed.TabIndex = 21
		Me.chkVacuumed.Text = "Vacuumed"
		Me.chkVacuumed.UseVisualStyleBackColor = True
		'
		'chkSkimmed
		'
		Me.chkSkimmed.AutoSize = True
		Me.chkSkimmed.Location = New System.Drawing.Point(48, 179)
		Me.chkSkimmed.Name = "chkSkimmed"
		Me.chkSkimmed.Size = New System.Drawing.Size(69, 17)
		Me.chkSkimmed.TabIndex = 21
		Me.chkSkimmed.Text = "Skimmed"
		Me.chkSkimmed.UseVisualStyleBackColor = True
		'
		'chkChemicals
		'
		Me.chkChemicals.AutoSize = True
		Me.chkChemicals.Location = New System.Drawing.Point(48, 218)
		Me.chkChemicals.Name = "chkChemicals"
		Me.chkChemicals.Size = New System.Drawing.Size(108, 17)
		Me.chkChemicals.TabIndex = 21
		Me.chkChemicals.Text = "Chemicals Added"
		Me.chkChemicals.UseVisualStyleBackColor = True
		'
		'chkFilter
		'
		Me.chkFilter.AutoSize = True
		Me.chkFilter.Location = New System.Drawing.Point(48, 255)
		Me.chkFilter.Name = "chkFilter"
		Me.chkFilter.Size = New System.Drawing.Size(113, 17)
		Me.chkFilter.TabIndex = 21
		Me.chkFilter.Text = "Filter Backwashed"
		Me.chkFilter.UseVisualStyleBackColor = True
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.chkFilter)
		Me.GroupBox4.Controls.Add(Me.chkChemicals)
		Me.GroupBox4.Controls.Add(Me.chkSkimmed)
		Me.GroupBox4.Controls.Add(Me.chkVacuumed)
		Me.GroupBox4.Controls.Add(Me.chkDetection)
		Me.GroupBox4.Controls.Add(Me.chkTesting)
		Me.GroupBox4.Controls.Add(Me.chkInstallation)
		Me.GroupBox4.Location = New System.Drawing.Point(483, 60)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(186, 282)
		Me.GroupBox4.TabIndex = 23
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Services Performed"
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.dtInvoiceDueDate)
		Me.GroupBox5.Controls.Add(Me.radNo)
		Me.GroupBox5.Controls.Add(Me.radYes)
		Me.GroupBox5.Controls.Add(Me.Label7)
		Me.GroupBox5.Controls.Add(Me.Label6)
		Me.GroupBox5.Location = New System.Drawing.Point(27, 170)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(395, 86)
		Me.GroupBox5.TabIndex = 24
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Invoice"
		'
		'radNo
		'
		Me.radNo.AutoSize = True
		Me.radNo.Location = New System.Drawing.Point(338, 56)
		Me.radNo.Name = "radNo"
		Me.radNo.Size = New System.Drawing.Size(39, 17)
		Me.radNo.TabIndex = 19
		Me.radNo.TabStop = True
		Me.radNo.Text = "No"
		Me.radNo.UseVisualStyleBackColor = True
		'
		'radYes
		'
		Me.radYes.AutoSize = True
		Me.radYes.Location = New System.Drawing.Point(272, 56)
		Me.radYes.Name = "radYes"
		Me.radYes.Size = New System.Drawing.Size(43, 17)
		Me.radYes.TabIndex = 19
		Me.radYes.TabStop = True
		Me.radYes.Text = "Yes"
		Me.radYes.UseVisualStyleBackColor = True
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(10, 56)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(241, 17)
		Me.Label7.TabIndex = 16
		Me.Label7.Text = "Send Automated Invoice to Customer"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(10, 16)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(132, 17)
		Me.Label6.TabIndex = 18
		Me.Label6.Text = "Due Date of Invoice"
		'
		'btnClose
		'
		Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnClose.Location = New System.Drawing.Point(445, 449)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 26
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSubmit
		'
		Me.btnSubmit.Location = New System.Drawing.Point(560, 449)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(109, 44)
		Me.btnSubmit.TabIndex = 27
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.UseVisualStyleBackColor = True
		'
		'dtInvoiceDueDate
		'
		Me.dtInvoiceDueDate.Location = New System.Drawing.Point(176, 19)
		Me.dtInvoiceDueDate.MinDate = New Date(2012, 1, 1, 0, 0, 0, 0)
		Me.dtInvoiceDueDate.Name = "dtInvoiceDueDate"
		Me.dtInvoiceDueDate.Size = New System.Drawing.Size(201, 20)
		Me.dtInvoiceDueDate.TabIndex = 20
		'
		'frmInvoicing
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(719, 523)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSubmit)
		Me.Controls.Add(Me.GroupBox5)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmInvoicing"
		Me.Text = "Invoicing"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label1 As Label
	Friend WithEvents chkInstallation As CheckBox
	Friend WithEvents chkTesting As CheckBox
	Friend WithEvents chkDetection As CheckBox
	Friend WithEvents chkVacuumed As CheckBox
	Friend WithEvents chkSkimmed As CheckBox
	Friend WithEvents chkChemicals As CheckBox
	Friend WithEvents chkFilter As CheckBox
	Friend WithEvents GroupBox4 As GroupBox
	Friend WithEvents GroupBox5 As GroupBox
	Friend WithEvents radNo As RadioButton
	Friend WithEvents radYes As RadioButton
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents btnClose As Button
	Friend WithEvents btnSubmit As Button
	Friend WithEvents cboJob As ComboBox
	Friend WithEvents cboCustomer As ComboBox
	Friend WithEvents Job As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents dtInvoiceDueDate As DateTimePicker
End Class
