<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreviousInvoices
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreviousInvoices))
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSearch = New System.Windows.Forms.Button()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.lblDueDate = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.chkFilter = New System.Windows.Forms.CheckBox()
		Me.chkChemicals = New System.Windows.Forms.CheckBox()
		Me.chkSkimmed = New System.Windows.Forms.CheckBox()
		Me.chkVacuumed = New System.Windows.Forms.CheckBox()
		Me.chkDetection = New System.Windows.Forms.CheckBox()
		Me.chkTesting = New System.Windows.Forms.CheckBox()
		Me.chkInstallation = New System.Windows.Forms.CheckBox()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.lblPoolOpening = New System.Windows.Forms.Label()
		Me.lblPoolClosing = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.lblDateServiceEnded = New System.Windows.Forms.Label()
		Me.lblDateServiceStarted = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox7 = New System.Windows.Forms.GroupBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.cboDateServiceStarted = New System.Windows.Forms.ComboBox()
		Me.cboName = New System.Windows.Forms.ComboBox()
		Me.Label38 = New System.Windows.Forms.Label()
		Me.GroupBox5.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox7.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(524, 413)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 34
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSearch
		'
		Me.btnSearch.Location = New System.Drawing.Point(524, 336)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(109, 44)
		Me.btnSearch.TabIndex = 35
		Me.btnSearch.Text = "Search"
		Me.btnSearch.UseVisualStyleBackColor = True
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.lblDueDate)
		Me.GroupBox5.Controls.Add(Me.Label6)
		Me.GroupBox5.Location = New System.Drawing.Point(60, 402)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(395, 55)
		Me.GroupBox5.TabIndex = 33
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Invoice"
		'
		'lblDueDate
		'
		Me.lblDueDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDueDate.Location = New System.Drawing.Point(170, 17)
		Me.lblDueDate.Name = "lblDueDate"
		Me.lblDueDate.Size = New System.Drawing.Size(215, 23)
		Me.lblDueDate.TabIndex = 43
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
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.chkFilter)
		Me.GroupBox4.Controls.Add(Me.chkChemicals)
		Me.GroupBox4.Controls.Add(Me.chkSkimmed)
		Me.GroupBox4.Controls.Add(Me.chkVacuumed)
		Me.GroupBox4.Controls.Add(Me.chkDetection)
		Me.GroupBox4.Controls.Add(Me.chkTesting)
		Me.GroupBox4.Controls.Add(Me.chkInstallation)
		Me.GroupBox4.Location = New System.Drawing.Point(492, 45)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(186, 282)
		Me.GroupBox4.TabIndex = 32
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Services Performed"
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
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.lblPoolOpening)
		Me.GroupBox3.Controls.Add(Me.lblPoolClosing)
		Me.GroupBox3.Controls.Add(Me.Label4)
		Me.GroupBox3.Controls.Add(Me.Label5)
		Me.GroupBox3.Location = New System.Drawing.Point(60, 290)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(395, 90)
		Me.GroupBox3.TabIndex = 31
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Date for Pool"
		'
		'lblPoolOpening
		'
		Me.lblPoolOpening.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPoolOpening.Location = New System.Drawing.Point(170, 59)
		Me.lblPoolOpening.Name = "lblPoolOpening"
		Me.lblPoolOpening.Size = New System.Drawing.Size(215, 23)
		Me.lblPoolOpening.TabIndex = 43
		'
		'lblPoolClosing
		'
		Me.lblPoolClosing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPoolClosing.Location = New System.Drawing.Point(170, 19)
		Me.lblPoolClosing.Name = "lblPoolClosing"
		Me.lblPoolClosing.Size = New System.Drawing.Size(215, 23)
		Me.lblPoolClosing.TabIndex = 43
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(16, 58)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(94, 17)
		Me.Label4.TabIndex = 16
		Me.Label4.Text = "Pool Opening"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(16, 18)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(86, 17)
		Me.Label5.TabIndex = 17
		Me.Label5.Text = "Pool Closing"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.lblDateServiceEnded)
		Me.GroupBox2.Controls.Add(Me.lblDateServiceStarted)
		Me.GroupBox2.Controls.Add(Me.Label10)
		Me.GroupBox2.Controls.Add(Me.Label11)
		Me.GroupBox2.Location = New System.Drawing.Point(60, 177)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(395, 90)
		Me.GroupBox2.TabIndex = 30
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Date Services Performed"
		'
		'lblDateServiceEnded
		'
		Me.lblDateServiceEnded.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDateServiceEnded.Location = New System.Drawing.Point(170, 59)
		Me.lblDateServiceEnded.Name = "lblDateServiceEnded"
		Me.lblDateServiceEnded.Size = New System.Drawing.Size(215, 23)
		Me.lblDateServiceEnded.TabIndex = 43
		'
		'lblDateServiceStarted
		'
		Me.lblDateServiceStarted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDateServiceStarted.Location = New System.Drawing.Point(170, 19)
		Me.lblDateServiceStarted.Name = "lblDateServiceStarted"
		Me.lblDateServiceStarted.Size = New System.Drawing.Size(215, 23)
		Me.lblDateServiceStarted.TabIndex = 43
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(16, 58)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(134, 17)
		Me.Label10.TabIndex = 16
		Me.Label10.Text = "Date Service Ended"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(16, 18)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(139, 17)
		Me.Label11.TabIndex = 17
		Me.Label11.Text = "Date Service Started"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(270, 22)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(257, 17)
		Me.Label1.TabIndex = 29
		Me.Label1.Text = "Look up previous invoices using search"
		'
		'GroupBox7
		'
		Me.GroupBox7.Controls.Add(Me.Label8)
		Me.GroupBox7.Controls.Add(Me.cboDateServiceStarted)
		Me.GroupBox7.Controls.Add(Me.cboName)
		Me.GroupBox7.Controls.Add(Me.Label38)
		Me.GroupBox7.Location = New System.Drawing.Point(57, 42)
		Me.GroupBox7.Name = "GroupBox7"
		Me.GroupBox7.Size = New System.Drawing.Size(398, 111)
		Me.GroupBox7.TabIndex = 41
		Me.GroupBox7.TabStop = False
		Me.GroupBox7.Text = "Search Information"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(15, 72)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(139, 17)
		Me.Label8.TabIndex = 39
		Me.Label8.Text = "Date Service Started"
		'
		'cboDateServiceStarted
		'
		Me.cboDateServiceStarted.FormattingEnabled = True
		Me.cboDateServiceStarted.Location = New System.Drawing.Point(173, 71)
		Me.cboDateServiceStarted.Name = "cboDateServiceStarted"
		Me.cboDateServiceStarted.Size = New System.Drawing.Size(215, 21)
		Me.cboDateServiceStarted.TabIndex = 38
		'
		'cboName
		'
		Me.cboName.FormattingEnabled = True
		Me.cboName.Location = New System.Drawing.Point(173, 26)
		Me.cboName.Name = "cboName"
		Me.cboName.Size = New System.Drawing.Size(215, 21)
		Me.cboName.TabIndex = 38
		'
		'Label38
		'
		Me.Label38.AutoSize = True
		Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label38.Location = New System.Drawing.Point(15, 27)
		Me.Label38.Name = "Label38"
		Me.Label38.Size = New System.Drawing.Size(152, 17)
		Me.Label38.TabIndex = 37
		Me.Label38.Text = "Last Name, First Name"
		'
		'frmPreviousInvoices
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(712, 478)
		Me.Controls.Add(Me.GroupBox7)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.GroupBox5)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Label1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmPreviousInvoices"
		Me.Text = "Previous Invoices"
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox7.ResumeLayout(False)
		Me.GroupBox7.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnClose As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkFilter As CheckBox
    Friend WithEvents chkChemicals As CheckBox
    Friend WithEvents chkSkimmed As CheckBox
    Friend WithEvents chkVacuumed As CheckBox
    Friend WithEvents chkDetection As CheckBox
    Friend WithEvents chkTesting As CheckBox
    Friend WithEvents chkInstallation As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboDateServiceStarted As ComboBox
    Friend WithEvents cboName As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents lblPoolOpening As Label
    Friend WithEvents lblPoolClosing As Label
    Friend WithEvents lblDateServiceEnded As Label
    Friend WithEvents lblDateServiceStarted As Label
End Class
