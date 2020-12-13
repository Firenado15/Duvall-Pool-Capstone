<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPreviousInvoices
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
		Me.components = New System.ComponentModel.Container()
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox7 = New System.Windows.Forms.GroupBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.cboInvoice = New System.Windows.Forms.ComboBox()
		Me.cboName = New System.Windows.Forms.ComboBox()
		Me.Label38 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.prfrmInvoice = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
		Me.prdiaInvoice = New System.Windows.Forms.PrintDialog()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.lblPaid = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnPayment = New System.Windows.Forms.Button()
		Me.btnDeleteInvoice = New System.Windows.Forms.Button()
		Me.GroupBox5.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox7.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(107, 333)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 34
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSearch
		'
		Me.btnSearch.Location = New System.Drawing.Point(567, 333)
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
		Me.GroupBox5.Location = New System.Drawing.Point(57, 159)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(398, 55)
		Me.GroupBox5.TabIndex = 33
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Invoice"
		'
		'lblDueDate
		'
		Me.lblDueDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDueDate.Location = New System.Drawing.Point(173, 17)
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
		Me.GroupBox7.Controls.Add(Me.cboInvoice)
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
		Me.Label8.Location = New System.Drawing.Point(10, 72)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(52, 17)
		Me.Label8.TabIndex = 39
		Me.Label8.Text = "Invoice"
		'
		'cboInvoice
		'
		Me.cboInvoice.FormattingEnabled = True
		Me.cboInvoice.Location = New System.Drawing.Point(173, 71)
		Me.cboInvoice.Name = "cboInvoice"
		Me.cboInvoice.Size = New System.Drawing.Size(215, 21)
		Me.cboInvoice.TabIndex = 38
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
		Me.Label38.Location = New System.Drawing.Point(6, 27)
		Me.Label38.Name = "Label38"
		Me.Label38.Size = New System.Drawing.Size(68, 17)
		Me.Label38.TabIndex = 37
		Me.Label38.Text = "Customer"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(452, 333)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(109, 44)
		Me.Button1.TabIndex = 53
		Me.Button1.Text = "Print"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'prfrmInvoice
		'
		Me.prfrmInvoice.DocumentName = "document"
		Me.prfrmInvoice.Form = Me
		Me.prfrmInvoice.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
		Me.prfrmInvoice.PrinterSettings = CType(resources.GetObject("prfrmInvoice.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
		Me.prfrmInvoice.PrintFileName = Nothing
		'
		'prdiaInvoice
		'
		Me.prdiaInvoice.UseEXDialog = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lblPaid)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.lblTotal)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Location = New System.Drawing.Point(57, 227)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(398, 100)
		Me.GroupBox1.TabIndex = 54
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Payment"
		'
		'lblPaid
		'
		Me.lblPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPaid.Location = New System.Drawing.Point(173, 58)
		Me.lblPaid.Name = "lblPaid"
		Me.lblPaid.Size = New System.Drawing.Size(215, 23)
		Me.lblPaid.TabIndex = 47
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(10, 64)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(88, 17)
		Me.Label5.TabIndex = 46
		Me.Label5.Text = "Amount Paid"
		'
		'lblTotal
		'
		Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTotal.Location = New System.Drawing.Point(173, 16)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(215, 23)
		Me.lblTotal.TabIndex = 45
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(10, 22)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(88, 17)
		Me.Label3.TabIndex = 44
		Me.Label3.Text = "Invoice Total"
		'
		'btnPayment
		'
		Me.btnPayment.Location = New System.Drawing.Point(337, 333)
		Me.btnPayment.Name = "btnPayment"
		Me.btnPayment.Size = New System.Drawing.Size(109, 44)
		Me.btnPayment.TabIndex = 55
		Me.btnPayment.Text = "Make Payment"
		Me.btnPayment.UseVisualStyleBackColor = True
		'
		'btnDeleteInvoice
		'
		Me.btnDeleteInvoice.Location = New System.Drawing.Point(222, 332)
		Me.btnDeleteInvoice.Name = "btnDeleteInvoice"
		Me.btnDeleteInvoice.Size = New System.Drawing.Size(109, 44)
		Me.btnDeleteInvoice.TabIndex = 56
		Me.btnDeleteInvoice.Text = "Delete Invoice"
		Me.btnDeleteInvoice.UseVisualStyleBackColor = True
		'
		'frmPreviousInvoices
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(700, 388)
		Me.Controls.Add(Me.btnDeleteInvoice)
		Me.Controls.Add(Me.btnPayment)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.GroupBox7)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.GroupBox5)
		Me.Controls.Add(Me.GroupBox4)
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
		Me.GroupBox7.ResumeLayout(False)
		Me.GroupBox7.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
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
	Friend WithEvents Label1 As Label
	Friend WithEvents GroupBox7 As GroupBox
	Friend WithEvents Label8 As Label
	Friend WithEvents cboInvoice As ComboBox
	Friend WithEvents cboName As ComboBox
	Friend WithEvents Label38 As Label
	Friend WithEvents lblDueDate As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents prfrmInvoice As PowerPacks.Printing.PrintForm
	Friend WithEvents prdiaInvoice As PrintDialog
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents lblPaid As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents lblTotal As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents btnPayment As Button
	Friend WithEvents btnDeleteInvoice As Button
End Class
