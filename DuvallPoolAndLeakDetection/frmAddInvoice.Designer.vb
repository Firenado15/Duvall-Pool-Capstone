<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddInvoice
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddInvoice))
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
		Me.Label15 = New System.Windows.Forms.Label()
		Me.txtTotalCost = New System.Windows.Forms.TextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.txtLeakCost = New System.Windows.Forms.TextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.cboLeak = New System.Windows.Forms.ComboBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtChemCost = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtTestingCost = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtSkimCost = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.txtFilterCost = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtVacuumCost = New System.Windows.Forms.TextBox()
		Me.cboVacuumHours = New System.Windows.Forms.ComboBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtLinerCost = New System.Windows.Forms.TextBox()
		Me.cboInground = New System.Windows.Forms.ComboBox()
		Me.cboAbove = New System.Windows.Forms.ComboBox()
		Me.radInground = New System.Windows.Forms.RadioButton()
		Me.radAbove = New System.Windows.Forms.RadioButton()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.lblEndDate = New System.Windows.Forms.Label()
		Me.lblStartDate = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.dtInvoiceDueDate = New System.Windows.Forms.DateTimePicker()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.lblJobDesc = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnTotal = New System.Windows.Forms.Button()
		Me.dgvAssignedParts = New System.Windows.Forms.DataGridView()
		Me.lblTotalPartCost = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox5.SuspendLayout()
		CType(Me.dgvAssignedParts, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.cboJob)
		Me.GroupBox1.Controls.Add(Me.cboCustomer)
		Me.GroupBox1.Controls.Add(Me.Job)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Location = New System.Drawing.Point(27, 29)
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
		Me.Label1.Location = New System.Drawing.Point(226, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(196, 17)
		Me.Label1.TabIndex = 15
		Me.Label1.Text = "Enter information for invoicing"
		'
		'chkInstallation
		'
		Me.chkInstallation.AutoSize = True
		Me.chkInstallation.Location = New System.Drawing.Point(6, 19)
		Me.chkInstallation.Name = "chkInstallation"
		Me.chkInstallation.Size = New System.Drawing.Size(102, 17)
		Me.chkInstallation.TabIndex = 21
		Me.chkInstallation.Text = "Liner Installation"
		Me.chkInstallation.UseVisualStyleBackColor = True
		'
		'chkTesting
		'
		Me.chkTesting.AutoSize = True
		Me.chkTesting.Location = New System.Drawing.Point(6, 118)
		Me.chkTesting.Name = "chkTesting"
		Me.chkTesting.Size = New System.Drawing.Size(93, 17)
		Me.chkTesting.TabIndex = 21
		Me.chkTesting.Text = "Water Testing"
		Me.chkTesting.UseVisualStyleBackColor = True
		'
		'chkDetection
		'
		Me.chkDetection.AutoSize = True
		Me.chkDetection.Location = New System.Drawing.Point(6, 171)
		Me.chkDetection.Name = "chkDetection"
		Me.chkDetection.Size = New System.Drawing.Size(99, 17)
		Me.chkDetection.TabIndex = 21
		Me.chkDetection.Text = "Leak Detection"
		Me.chkDetection.UseVisualStyleBackColor = True
		'
		'chkVacuumed
		'
		Me.chkVacuumed.AutoSize = True
		Me.chkVacuumed.Location = New System.Drawing.Point(6, 247)
		Me.chkVacuumed.Name = "chkVacuumed"
		Me.chkVacuumed.Size = New System.Drawing.Size(77, 17)
		Me.chkVacuumed.TabIndex = 21
		Me.chkVacuumed.Text = "Vacuumed"
		Me.chkVacuumed.UseVisualStyleBackColor = True
		'
		'chkSkimmed
		'
		Me.chkSkimmed.AutoSize = True
		Me.chkSkimmed.Location = New System.Drawing.Point(6, 324)
		Me.chkSkimmed.Name = "chkSkimmed"
		Me.chkSkimmed.Size = New System.Drawing.Size(69, 17)
		Me.chkSkimmed.TabIndex = 21
		Me.chkSkimmed.Text = "Skimmed"
		Me.chkSkimmed.UseVisualStyleBackColor = True
		'
		'chkChemicals
		'
		Me.chkChemicals.AutoSize = True
		Me.chkChemicals.Location = New System.Drawing.Point(6, 367)
		Me.chkChemicals.Name = "chkChemicals"
		Me.chkChemicals.Size = New System.Drawing.Size(111, 17)
		Me.chkChemicals.TabIndex = 21
		Me.chkChemicals.Text = "Chemical Balance"
		Me.chkChemicals.UseVisualStyleBackColor = True
		'
		'chkFilter
		'
		Me.chkFilter.AutoSize = True
		Me.chkFilter.Location = New System.Drawing.Point(6, 416)
		Me.chkFilter.Name = "chkFilter"
		Me.chkFilter.Size = New System.Drawing.Size(113, 17)
		Me.chkFilter.TabIndex = 21
		Me.chkFilter.Text = "Filter Backwashed"
		Me.chkFilter.UseVisualStyleBackColor = True
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.Label15)
		Me.GroupBox4.Controls.Add(Me.txtTotalCost)
		Me.GroupBox4.Controls.Add(Me.Label14)
		Me.GroupBox4.Controls.Add(Me.txtLeakCost)
		Me.GroupBox4.Controls.Add(Me.Label13)
		Me.GroupBox4.Controls.Add(Me.cboLeak)
		Me.GroupBox4.Controls.Add(Me.Label12)
		Me.GroupBox4.Controls.Add(Me.txtChemCost)
		Me.GroupBox4.Controls.Add(Me.Label11)
		Me.GroupBox4.Controls.Add(Me.txtTestingCost)
		Me.GroupBox4.Controls.Add(Me.Label10)
		Me.GroupBox4.Controls.Add(Me.txtSkimCost)
		Me.GroupBox4.Controls.Add(Me.Label9)
		Me.GroupBox4.Controls.Add(Me.txtFilterCost)
		Me.GroupBox4.Controls.Add(Me.Label8)
		Me.GroupBox4.Controls.Add(Me.txtVacuumCost)
		Me.GroupBox4.Controls.Add(Me.cboVacuumHours)
		Me.GroupBox4.Controls.Add(Me.Label5)
		Me.GroupBox4.Controls.Add(Me.Label4)
		Me.GroupBox4.Controls.Add(Me.txtLinerCost)
		Me.GroupBox4.Controls.Add(Me.cboInground)
		Me.GroupBox4.Controls.Add(Me.cboAbove)
		Me.GroupBox4.Controls.Add(Me.radInground)
		Me.GroupBox4.Controls.Add(Me.radAbove)
		Me.GroupBox4.Controls.Add(Me.chkFilter)
		Me.GroupBox4.Controls.Add(Me.chkChemicals)
		Me.GroupBox4.Controls.Add(Me.chkSkimmed)
		Me.GroupBox4.Controls.Add(Me.chkVacuumed)
		Me.GroupBox4.Controls.Add(Me.chkDetection)
		Me.GroupBox4.Controls.Add(Me.chkTesting)
		Me.GroupBox4.Controls.Add(Me.chkInstallation)
		Me.GroupBox4.Location = New System.Drawing.Point(445, 9)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(257, 503)
		Me.GroupBox4.TabIndex = 23
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Services Performed"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Location = New System.Drawing.Point(26, 480)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(49, 13)
		Me.Label15.TabIndex = 46
		Me.Label15.Text = "Total :  $"
		'
		'txtTotalCost
		'
		Me.txtTotalCost.Location = New System.Drawing.Point(81, 477)
		Me.txtTotalCost.Name = "txtTotalCost"
		Me.txtTotalCost.Size = New System.Drawing.Size(154, 20)
		Me.txtTotalCost.TabIndex = 45
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(32, 224)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(43, 13)
		Me.Label14.TabIndex = 44
		Me.Label14.Text = "Cost:  $"
		'
		'txtLeakCost
		'
		Me.txtLeakCost.Enabled = False
		Me.txtLeakCost.Location = New System.Drawing.Point(81, 221)
		Me.txtLeakCost.Name = "txtLeakCost"
		Me.txtLeakCost.Size = New System.Drawing.Size(154, 20)
		Me.txtLeakCost.TabIndex = 43
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(46, 197)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(29, 13)
		Me.Label13.TabIndex = 42
		Me.Label13.Text = "Sqft:"
		'
		'cboLeak
		'
		Me.cboLeak.Enabled = False
		Me.cboLeak.FormattingEnabled = True
		Me.cboLeak.Items.AddRange(New Object() {"Less than 300 sqft", "Between 300 to 500 sqft", "Greater than 500 sqft"})
		Me.cboLeak.Location = New System.Drawing.Point(81, 194)
		Me.cboLeak.Name = "cboLeak"
		Me.cboLeak.Size = New System.Drawing.Size(154, 21)
		Me.cboLeak.TabIndex = 41
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(32, 393)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(43, 13)
		Me.Label12.TabIndex = 40
		Me.Label12.Text = "Cost:  $"
		'
		'txtChemCost
		'
		Me.txtChemCost.Enabled = False
		Me.txtChemCost.Location = New System.Drawing.Point(81, 390)
		Me.txtChemCost.Name = "txtChemCost"
		Me.txtChemCost.Size = New System.Drawing.Size(154, 20)
		Me.txtChemCost.TabIndex = 39
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(32, 144)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(43, 13)
		Me.Label11.TabIndex = 38
		Me.Label11.Text = "Cost:  $"
		'
		'txtTestingCost
		'
		Me.txtTestingCost.Enabled = False
		Me.txtTestingCost.Location = New System.Drawing.Point(81, 141)
		Me.txtTestingCost.Name = "txtTestingCost"
		Me.txtTestingCost.Size = New System.Drawing.Size(154, 20)
		Me.txtTestingCost.TabIndex = 37
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(32, 344)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(43, 13)
		Me.Label10.TabIndex = 36
		Me.Label10.Text = "Cost:  $"
		'
		'txtSkimCost
		'
		Me.txtSkimCost.Enabled = False
		Me.txtSkimCost.Location = New System.Drawing.Point(81, 341)
		Me.txtSkimCost.Name = "txtSkimCost"
		Me.txtSkimCost.Size = New System.Drawing.Size(154, 20)
		Me.txtSkimCost.TabIndex = 35
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(32, 442)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(43, 13)
		Me.Label9.TabIndex = 34
		Me.Label9.Text = "Cost:  $"
		'
		'txtFilterCost
		'
		Me.txtFilterCost.Enabled = False
		Me.txtFilterCost.Location = New System.Drawing.Point(81, 439)
		Me.txtFilterCost.Name = "txtFilterCost"
		Me.txtFilterCost.Size = New System.Drawing.Size(154, 20)
		Me.txtFilterCost.TabIndex = 33
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(32, 299)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(43, 13)
		Me.Label8.TabIndex = 32
		Me.Label8.Text = "Cost:  $"
		'
		'txtVacuumCost
		'
		Me.txtVacuumCost.Enabled = False
		Me.txtVacuumCost.Location = New System.Drawing.Point(81, 296)
		Me.txtVacuumCost.Name = "txtVacuumCost"
		Me.txtVacuumCost.Size = New System.Drawing.Size(154, 20)
		Me.txtVacuumCost.TabIndex = 31
		'
		'cboVacuumHours
		'
		Me.cboVacuumHours.Enabled = False
		Me.cboVacuumHours.FormattingEnabled = True
		Me.cboVacuumHours.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
		Me.cboVacuumHours.Location = New System.Drawing.Point(81, 269)
		Me.cboVacuumHours.Name = "cboVacuumHours"
		Me.cboVacuumHours.Size = New System.Drawing.Size(154, 21)
		Me.cboVacuumHours.TabIndex = 30
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(32, 272)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(38, 13)
		Me.Label5.TabIndex = 29
		Me.Label5.Text = "Hours:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Enabled = False
		Me.Label4.Location = New System.Drawing.Point(32, 95)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(43, 13)
		Me.Label4.TabIndex = 27
		Me.Label4.Text = "Cost:  $"
		'
		'txtLinerCost
		'
		Me.txtLinerCost.Enabled = False
		Me.txtLinerCost.Location = New System.Drawing.Point(81, 92)
		Me.txtLinerCost.Name = "txtLinerCost"
		Me.txtLinerCost.Size = New System.Drawing.Size(154, 20)
		Me.txtLinerCost.TabIndex = 26
		'
		'cboInground
		'
		Me.cboInground.Enabled = False
		Me.cboInground.FormattingEnabled = True
		Me.cboInground.Items.AddRange(New Object() {"12x24 - 288sqft", "14x28 - 392sqft", "16x32 - 512sqft", "18x36 - 648sqft", "20x40 - 800sqft"})
		Me.cboInground.Location = New System.Drawing.Point(25, 65)
		Me.cboInground.Name = "cboInground"
		Me.cboInground.Size = New System.Drawing.Size(210, 21)
		Me.cboInground.TabIndex = 25
		Me.cboInground.Visible = False
		'
		'cboAbove
		'
		Me.cboAbove.Enabled = False
		Me.cboAbove.FormattingEnabled = True
		Me.cboAbove.Items.AddRange(New Object() {"18' Round", "30' Round", "12x24 Oval", "18x40 Oval"})
		Me.cboAbove.Location = New System.Drawing.Point(25, 65)
		Me.cboAbove.Name = "cboAbove"
		Me.cboAbove.Size = New System.Drawing.Size(210, 21)
		Me.cboAbove.TabIndex = 24
		'
		'radInground
		'
		Me.radInground.AutoSize = True
		Me.radInground.Enabled = False
		Me.radInground.Location = New System.Drawing.Point(168, 42)
		Me.radInground.Name = "radInground"
		Me.radInground.Size = New System.Drawing.Size(67, 17)
		Me.radInground.TabIndex = 23
		Me.radInground.TabStop = True
		Me.radInground.Text = "Inground"
		Me.radInground.UseVisualStyleBackColor = True
		'
		'radAbove
		'
		Me.radAbove.AutoSize = True
		Me.radAbove.Enabled = False
		Me.radAbove.Location = New System.Drawing.Point(25, 42)
		Me.radAbove.Name = "radAbove"
		Me.radAbove.Size = New System.Drawing.Size(94, 17)
		Me.radAbove.TabIndex = 22
		Me.radAbove.TabStop = True
		Me.radAbove.Text = "Above Ground"
		Me.radAbove.UseVisualStyleBackColor = True
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.lblEndDate)
		Me.GroupBox5.Controls.Add(Me.lblStartDate)
		Me.GroupBox5.Controls.Add(Me.Label16)
		Me.GroupBox5.Controls.Add(Me.Label7)
		Me.GroupBox5.Controls.Add(Me.dtInvoiceDueDate)
		Me.GroupBox5.Controls.Add(Me.Label6)
		Me.GroupBox5.Location = New System.Drawing.Point(27, 131)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(395, 119)
		Me.GroupBox5.TabIndex = 24
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Dates"
		'
		'lblEndDate
		'
		Me.lblEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblEndDate.Location = New System.Drawing.Point(170, 56)
		Me.lblEndDate.Name = "lblEndDate"
		Me.lblEndDate.Size = New System.Drawing.Size(201, 23)
		Me.lblEndDate.TabIndex = 24
		'
		'lblStartDate
		'
		Me.lblStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblStartDate.Location = New System.Drawing.Point(170, 21)
		Me.lblStartDate.Name = "lblStartDate"
		Me.lblStartDate.Size = New System.Drawing.Size(201, 23)
		Me.lblStartDate.TabIndex = 23
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Location = New System.Drawing.Point(61, 56)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(90, 16)
		Me.Label16.TabIndex = 22
		Me.Label16.Text = "Job End Date"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(61, 23)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(93, 16)
		Me.Label7.TabIndex = 21
		Me.Label7.Text = "Job Start Date"
		'
		'dtInvoiceDueDate
		'
		Me.dtInvoiceDueDate.Location = New System.Drawing.Point(170, 87)
		Me.dtInvoiceDueDate.MinDate = New Date(2012, 1, 1, 0, 0, 0, 0)
		Me.dtInvoiceDueDate.Name = "dtInvoiceDueDate"
		Me.dtInvoiceDueDate.Size = New System.Drawing.Size(201, 20)
		Me.dtInvoiceDueDate.TabIndex = 20
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(22, 89)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(132, 17)
		Me.Label6.TabIndex = 18
		Me.Label6.Text = "Due Date of Invoice"
		'
		'btnClose
		'
		Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnClose.Location = New System.Drawing.Point(445, 521)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(81, 44)
		Me.btnClose.TabIndex = 26
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSubmit
		'
		Me.btnSubmit.Location = New System.Drawing.Point(621, 521)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(81, 44)
		Me.btnSubmit.TabIndex = 27
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.UseVisualStyleBackColor = True
		'
		'lblJobDesc
		'
		Me.lblJobDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblJobDesc.Location = New System.Drawing.Point(27, 267)
		Me.lblJobDesc.Name = "lblJobDesc"
		Me.lblJobDesc.Size = New System.Drawing.Size(395, 99)
		Me.lblJobDesc.TabIndex = 43
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(24, 254)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(80, 13)
		Me.Label3.TabIndex = 44
		Me.Label3.Text = "Job Description"
		'
		'btnTotal
		'
		Me.btnTotal.Location = New System.Drawing.Point(533, 521)
		Me.btnTotal.Name = "btnTotal"
		Me.btnTotal.Size = New System.Drawing.Size(81, 44)
		Me.btnTotal.TabIndex = 45
		Me.btnTotal.Text = "Total"
		Me.btnTotal.UseVisualStyleBackColor = True
		'
		'dgvAssignedParts
		'
		Me.dgvAssignedParts.AllowUserToAddRows = False
		Me.dgvAssignedParts.AllowUserToDeleteRows = False
		Me.dgvAssignedParts.AllowUserToResizeColumns = False
		Me.dgvAssignedParts.AllowUserToResizeRows = False
		Me.dgvAssignedParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvAssignedParts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
		Me.dgvAssignedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvAssignedParts.Location = New System.Drawing.Point(27, 389)
		Me.dgvAssignedParts.Name = "dgvAssignedParts"
		Me.dgvAssignedParts.Size = New System.Drawing.Size(395, 150)
		Me.dgvAssignedParts.TabIndex = 46
		'
		'lblTotalPartCost
		'
		Me.lblTotalPartCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblTotalPartCost.Location = New System.Drawing.Point(292, 548)
		Me.lblTotalPartCost.Name = "lblTotalPartCost"
		Me.lblTotalPartCost.Size = New System.Drawing.Size(130, 17)
		Me.lblTotalPartCost.TabIndex = 47
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Location = New System.Drawing.Point(203, 549)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(83, 13)
		Me.Label18.TabIndex = 48
		Me.Label18.Text = "Total Part Cost :"
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Location = New System.Drawing.Point(24, 373)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(51, 13)
		Me.Label17.TabIndex = 49
		Me.Label17.Text = "Job Parts"
		'
		'frmAddInvoice
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(721, 574)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.Label18)
		Me.Controls.Add(Me.lblTotalPartCost)
		Me.Controls.Add(Me.dgvAssignedParts)
		Me.Controls.Add(Me.btnTotal)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.lblJobDesc)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSubmit)
		Me.Controls.Add(Me.GroupBox5)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmAddInvoice"
		Me.Text = "Invoicing"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		CType(Me.dgvAssignedParts, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents Label6 As Label
	Friend WithEvents btnClose As Button
	Friend WithEvents btnSubmit As Button
	Friend WithEvents cboJob As ComboBox
	Friend WithEvents cboCustomer As ComboBox
	Friend WithEvents Job As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents dtInvoiceDueDate As DateTimePicker
	Friend WithEvents lblJobDesc As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents radInground As RadioButton
	Friend WithEvents radAbove As RadioButton
	Friend WithEvents cboAbove As ComboBox
	Friend WithEvents cboInground As ComboBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtLinerCost As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents cboVacuumHours As ComboBox
	Friend WithEvents Label8 As Label
	Friend WithEvents txtVacuumCost As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents txtFilterCost As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents txtSkimCost As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents txtTestingCost As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents txtChemCost As TextBox
	Friend WithEvents Label14 As Label
	Friend WithEvents txtLeakCost As TextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents cboLeak As ComboBox
	Friend WithEvents Label15 As Label
	Friend WithEvents txtTotalCost As TextBox
	Friend WithEvents btnTotal As Button
	Friend WithEvents Label16 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents lblEndDate As Label
	Friend WithEvents lblStartDate As Label
	Friend WithEvents dgvAssignedParts As DataGridView
	Friend WithEvents lblTotalPartCost As Label
	Friend WithEvents Label18 As Label
	Friend WithEvents Label17 As Label
End Class
