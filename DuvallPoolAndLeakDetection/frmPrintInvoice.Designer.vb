<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintInvoice
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintInvoice))
		Me.prdiaInvoice = New System.Windows.Forms.PrintDialog()
		Me.prfrmInvoice = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
		Me.lblName = New System.Windows.Forms.Label()
		Me.lblAddress = New System.Windows.Forms.Label()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.lblCity = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblDate = New System.Windows.Forms.Label()
		Me.lblInvoiceNumber = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.lblServices = New System.Windows.Forms.Label()
		Me.lblBilling = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.lblPhone = New System.Windows.Forms.Label()
		Me.lblEmail = New System.Windows.Forms.Label()
		Me.chkPrintPreview = New System.Windows.Forms.CheckBox()
		Me.lblDescription = New System.Windows.Forms.Label()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'prdiaInvoice
		'
		Me.prdiaInvoice.UseEXDialog = True
		'
		'prfrmInvoice
		'
		Me.prfrmInvoice.DocumentName = "document"
		Me.prfrmInvoice.Form = Me
		Me.prfrmInvoice.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
		Me.prfrmInvoice.PrinterSettings = CType(resources.GetObject("prfrmInvoice.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
		Me.prfrmInvoice.PrintFileName = Nothing
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.BackColor = System.Drawing.Color.White
		Me.lblName.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblName.Location = New System.Drawing.Point(26, 225)
		Me.lblName.Name = "lblName"
		Me.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblName.Size = New System.Drawing.Size(47, 17)
		Me.lblName.TabIndex = 0
		Me.lblName.Text = "Name"
		'
		'lblAddress
		'
		Me.lblAddress.AutoSize = True
		Me.lblAddress.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAddress.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAddress.Location = New System.Drawing.Point(26, 243)
		Me.lblAddress.Name = "lblAddress"
		Me.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAddress.Size = New System.Drawing.Size(62, 17)
		Me.lblAddress.TabIndex = 1
		Me.lblAddress.Text = "Address"
		'
		'btnPrint
		'
		Me.btnPrint.Location = New System.Drawing.Point(697, 926)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(75, 23)
		Me.btnPrint.TabIndex = 2
		Me.btnPrint.Text = "Print"
		Me.btnPrint.UseVisualStyleBackColor = True
		'
		'lblCity
		'
		Me.lblCity.AutoSize = True
		Me.lblCity.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCity.Location = New System.Drawing.Point(26, 261)
		Me.lblCity.Name = "lblCity"
		Me.lblCity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCity.Size = New System.Drawing.Size(101, 17)
		Me.lblCity.TabIndex = 3
		Me.lblCity.Text = "City, State, Zip"
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.White
		Me.PictureBox1.BackgroundImage = Global.DuvallPoolAndLeakDetection.My.Resources.Resources.Untitled
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(287, 170)
		Me.PictureBox1.TabIndex = 4
		Me.PictureBox1.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.White
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.CadetBlue
		Me.Label1.Location = New System.Drawing.Point(574, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(198, 52)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "  INVOICE "
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.CadetBlue
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(23, 193)
		Me.Label2.Name = "Label2"
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.Size = New System.Drawing.Size(227, 22)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "BILL TO"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.CadetBlue
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(387, 94)
		Me.Label3.Name = "Label3"
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.Size = New System.Drawing.Size(179, 22)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "INVOICE #"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.CadetBlue
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(566, 94)
		Me.Label4.Name = "Label4"
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.Size = New System.Drawing.Size(200, 22)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "DUE DATE"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblDate
		'
		Me.lblDate.BackColor = System.Drawing.Color.White
		Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDate.Location = New System.Drawing.Point(566, 116)
		Me.lblDate.Name = "lblDate"
		Me.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDate.Size = New System.Drawing.Size(200, 22)
		Me.lblDate.TabIndex = 10
		Me.lblDate.Text = "mm/dd/yyyy"
		Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblInvoiceNumber
		'
		Me.lblInvoiceNumber.BackColor = System.Drawing.Color.White
		Me.lblInvoiceNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblInvoiceNumber.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInvoiceNumber.Location = New System.Drawing.Point(387, 116)
		Me.lblInvoiceNumber.Name = "lblInvoiceNumber"
		Me.lblInvoiceNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblInvoiceNumber.Size = New System.Drawing.Size(179, 22)
		Me.lblInvoiceNumber.TabIndex = 9
		Me.lblInvoiceNumber.Text = "[123456]"
		Me.lblInvoiceNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.CadetBlue
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(21, 393)
		Me.Label7.Name = "Label7"
		Me.Label7.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.Size = New System.Drawing.Size(587, 30)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "BILL TO"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.CadetBlue
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(608, 393)
		Me.Label8.Name = "Label8"
		Me.Label8.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.Size = New System.Drawing.Size(157, 30)
		Me.Label8.TabIndex = 12
		Me.Label8.Text = "AMOUNT"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblServices
		'
		Me.lblServices.BackColor = System.Drawing.Color.White
		Me.lblServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblServices.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblServices.Location = New System.Drawing.Point(21, 423)
		Me.lblServices.Name = "lblServices"
		Me.lblServices.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
		Me.lblServices.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblServices.Size = New System.Drawing.Size(587, 380)
		Me.lblServices.TabIndex = 13
		Me.lblServices.Text = "Item 1"
		'
		'lblBilling
		'
		Me.lblBilling.BackColor = System.Drawing.Color.White
		Me.lblBilling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblBilling.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBilling.Location = New System.Drawing.Point(608, 423)
		Me.lblBilling.Name = "lblBilling"
		Me.lblBilling.Padding = New System.Windows.Forms.Padding(0, 15, 15, 0)
		Me.lblBilling.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblBilling.Size = New System.Drawing.Size(157, 380)
		Me.lblBilling.TabIndex = 14
		Me.lblBilling.Text = "100"
		Me.lblBilling.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label11
		'
		Me.Label11.BackColor = System.Drawing.Color.White
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(21, 803)
		Me.Label11.Name = "Label11"
		Me.Label11.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.Size = New System.Drawing.Size(472, 40)
		Me.Label11.TabIndex = 15
		Me.Label11.Text = "Thank you for your business!"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.White
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(493, 803)
		Me.Label12.Name = "Label12"
		Me.Label12.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.Size = New System.Drawing.Size(272, 40)
		Me.Label12.TabIndex = 16
		Me.Label12.Text = "TOTAL"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblTotal
		'
		Me.lblTotal.AutoSize = True
		Me.lblTotal.BackColor = System.Drawing.Color.Transparent
		Me.lblTotal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTotal.Location = New System.Drawing.Point(689, 815)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTotal.Size = New System.Drawing.Size(60, 18)
		Me.lblTotal.TabIndex = 17
		Me.lblTotal.Text = "$100.00"
		'
		'Label13
		'
		Me.Label13.BackColor = System.Drawing.Color.White
		Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Location = New System.Drawing.Point(159, 873)
		Me.Label13.Name = "Label13"
		Me.Label13.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
		Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label13.Size = New System.Drawing.Size(472, 40)
		Me.Label13.TabIndex = 18
		Me.Label13.Text = "Please contact us with any questions"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblPhone
		'
		Me.lblPhone.AutoSize = True
		Me.lblPhone.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPhone.Location = New System.Drawing.Point(26, 279)
		Me.lblPhone.Name = "lblPhone"
		Me.lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPhone.Size = New System.Drawing.Size(62, 17)
		Me.lblPhone.TabIndex = 19
		Me.lblPhone.Text = "Phone #"
		'
		'lblEmail
		'
		Me.lblEmail.AutoSize = True
		Me.lblEmail.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEmail.Location = New System.Drawing.Point(26, 297)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(45, 17)
		Me.lblEmail.TabIndex = 20
		Me.lblEmail.Text = "Email"
		'
		'chkPrintPreview
		'
		Me.chkPrintPreview.AutoSize = True
		Me.chkPrintPreview.Location = New System.Drawing.Point(684, 903)
		Me.chkPrintPreview.Name = "chkPrintPreview"
		Me.chkPrintPreview.Size = New System.Drawing.Size(88, 17)
		Me.chkPrintPreview.TabIndex = 55
		Me.chkPrintPreview.Text = "Print Preview"
		Me.chkPrintPreview.UseVisualStyleBackColor = True
		'
		'lblDescription
		'
		Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblDescription.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDescription.Location = New System.Drawing.Point(21, 742)
		Me.lblDescription.Name = "lblDescription"
		Me.lblDescription.Size = New System.Drawing.Size(587, 61)
		Me.lblDescription.TabIndex = 56
		Me.lblDescription.Text = "Job Description"
		'
		'frmPrintInvoice
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(784, 961)
		Me.Controls.Add(Me.lblDescription)
		Me.Controls.Add(Me.chkPrintPreview)
		Me.Controls.Add(Me.lblEmail)
		Me.Controls.Add(Me.lblPhone)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.lblTotal)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.lblBilling)
		Me.Controls.Add(Me.lblServices)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.lblDate)
		Me.Controls.Add(Me.lblInvoiceNumber)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.lblCity)
		Me.Controls.Add(Me.btnPrint)
		Me.Controls.Add(Me.lblAddress)
		Me.Controls.Add(Me.lblName)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmPrintInvoice"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = False
		Me.Text = "Printing Invoice"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents prdiaInvoice As PrintDialog
	Friend WithEvents prfrmInvoice As PowerPacks.Printing.PrintForm
	Friend WithEvents lblName As Label
	Friend WithEvents lblAddress As Label
	Friend WithEvents btnPrint As Button
	Friend WithEvents lblCity As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lblDate As Label
	Friend WithEvents lblInvoiceNumber As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents lblServices As Label
	Friend WithEvents lblBilling As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents lblTotal As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents lblPhone As Label
	Friend WithEvents lblEmail As Label
	Friend WithEvents chkPrintPreview As CheckBox
	Friend WithEvents lblDescription As Label
End Class
