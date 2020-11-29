<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartsOrdering
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.radNo = New System.Windows.Forms.RadioButton()
		Me.cboState = New System.Windows.Forms.ComboBox()
		Me.radYes = New System.Windows.Forms.RadioButton()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtPhone = New System.Windows.Forms.TextBox()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.txtZip = New System.Windows.Forms.TextBox()
		Me.txtCity = New System.Windows.Forms.TextBox()
		Me.txtAddress = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtContactName = New System.Windows.Forms.TextBox()
		Me.txtVendorName = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.cboCostPerUnit = New System.Windows.Forms.ComboBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.txtVendorIdentification = New System.Windows.Forms.TextBox()
		Me.txtQuantity = New System.Windows.Forms.TextBox()
		Me.txtPartName = New System.Windows.Forms.TextBox()
		Me.txtPartDescription = New System.Windows.Forms.TextBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.txtJobNumber = New System.Windows.Forms.TextBox()
		Me.txtPurchaseOrder = New System.Windows.Forms.TextBox()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.cboVendor = New System.Windows.Forms.ComboBox()
		Me.lblContactName = New System.Windows.Forms.Label()
		Me.lblPhone = New System.Windows.Forms.Label()
		Me.lblEmail = New System.Windows.Forms.Label()
		Me.lblZip = New System.Windows.Forms.Label()
		Me.lblState = New System.Windows.Forms.Label()
		Me.lblCity = New System.Windows.Forms.Label()
		Me.lblAddress = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.radNo)
		Me.GroupBox1.Controls.Add(Me.cboState)
		Me.GroupBox1.Controls.Add(Me.radYes)
		Me.GroupBox1.Controls.Add(Me.Label10)
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.txtPhone)
		Me.GroupBox1.Controls.Add(Me.txtEmail)
		Me.GroupBox1.Controls.Add(Me.txtZip)
		Me.GroupBox1.Controls.Add(Me.txtCity)
		Me.GroupBox1.Controls.Add(Me.txtAddress)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.txtContactName)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.cboVendor)
		Me.GroupBox1.Controls.Add(Me.txtVendorName)
		Me.GroupBox1.Controls.Add(Me.lblContactName)
		Me.GroupBox1.Controls.Add(Me.lblPhone)
		Me.GroupBox1.Controls.Add(Me.lblEmail)
		Me.GroupBox1.Controls.Add(Me.lblZip)
		Me.GroupBox1.Controls.Add(Me.lblState)
		Me.GroupBox1.Controls.Add(Me.lblCity)
		Me.GroupBox1.Controls.Add(Me.lblAddress)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 83)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(397, 380)
		Me.GroupBox1.TabIndex = 14
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Vendor Information"
		'
		'radNo
		'
		Me.radNo.AutoSize = True
		Me.radNo.Checked = True
		Me.radNo.Location = New System.Drawing.Point(282, 19)
		Me.radNo.Name = "radNo"
		Me.radNo.Size = New System.Drawing.Size(39, 17)
		Me.radNo.TabIndex = 30
		Me.radNo.TabStop = True
		Me.radNo.Text = "No"
		Me.radNo.UseVisualStyleBackColor = True
		'
		'cboState
		'
		Me.cboState.FormattingEnabled = True
		Me.cboState.Location = New System.Drawing.Point(147, 216)
		Me.cboState.Name = "cboState"
		Me.cboState.Size = New System.Drawing.Size(244, 21)
		Me.cboState.TabIndex = 5
		'
		'radYes
		'
		Me.radYes.AutoSize = True
		Me.radYes.Location = New System.Drawing.Point(187, 19)
		Me.radYes.Name = "radYes"
		Me.radYes.Size = New System.Drawing.Size(43, 17)
		Me.radYes.TabIndex = 29
		Me.radYes.Text = "Yes"
		Me.radYes.UseVisualStyleBackColor = True
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(24, 19)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(113, 17)
		Me.Label10.TabIndex = 28
		Me.Label10.Text = "Previous Vendor"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(26, 343)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(103, 17)
		Me.Label9.TabIndex = 11
		Me.Label9.Text = "Phone Number"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(26, 301)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(98, 17)
		Me.Label8.TabIndex = 11
		Me.Label8.Text = "Email Address"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(26, 257)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(65, 17)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "Zip Code"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(26, 214)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(41, 17)
		Me.Label6.TabIndex = 11
		Me.Label6.Text = "State"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(26, 178)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(31, 17)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "City"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(26, 139)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(60, 17)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Address"
		'
		'txtPhone
		'
		Me.txtPhone.Location = New System.Drawing.Point(147, 337)
		Me.txtPhone.Name = "txtPhone"
		Me.txtPhone.Size = New System.Drawing.Size(244, 20)
		Me.txtPhone.TabIndex = 8
		'
		'txtEmail
		'
		Me.txtEmail.Location = New System.Drawing.Point(147, 297)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(244, 20)
		Me.txtEmail.TabIndex = 7
		'
		'txtZip
		'
		Me.txtZip.Location = New System.Drawing.Point(147, 257)
		Me.txtZip.Name = "txtZip"
		Me.txtZip.Size = New System.Drawing.Size(244, 20)
		Me.txtZip.TabIndex = 6
		'
		'txtCity
		'
		Me.txtCity.Location = New System.Drawing.Point(147, 176)
		Me.txtCity.Name = "txtCity"
		Me.txtCity.Size = New System.Drawing.Size(244, 20)
		Me.txtCity.TabIndex = 4
		'
		'txtAddress
		'
		Me.txtAddress.Location = New System.Drawing.Point(147, 136)
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Size = New System.Drawing.Size(244, 20)
		Me.txtAddress.TabIndex = 3
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(26, 99)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(97, 17)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Contact Name"
		'
		'txtContactName
		'
		Me.txtContactName.Location = New System.Drawing.Point(147, 96)
		Me.txtContactName.Name = "txtContactName"
		Me.txtContactName.Size = New System.Drawing.Size(244, 20)
		Me.txtContactName.TabIndex = 2
		'
		'txtVendorName
		'
		Me.txtVendorName.Location = New System.Drawing.Point(147, 56)
		Me.txtVendorName.Name = "txtVendorName"
		Me.txtVendorName.Size = New System.Drawing.Size(244, 20)
		Me.txtVendorName.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(26, 57)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(95, 17)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Vendor Name"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(358, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(230, 17)
		Me.Label1.TabIndex = 15
		Me.Label1.Text = "Enter information for ordering parts"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.cboCostPerUnit)
		Me.GroupBox2.Controls.Add(Me.Label13)
		Me.GroupBox2.Controls.Add(Me.Label14)
		Me.GroupBox2.Controls.Add(Me.Label15)
		Me.GroupBox2.Controls.Add(Me.Label12)
		Me.GroupBox2.Controls.Add(Me.Label16)
		Me.GroupBox2.Controls.Add(Me.txtVendorIdentification)
		Me.GroupBox2.Controls.Add(Me.txtQuantity)
		Me.GroupBox2.Controls.Add(Me.txtPartName)
		Me.GroupBox2.Controls.Add(Me.txtPartDescription)
		Me.GroupBox2.Controls.Add(Me.Label17)
		Me.GroupBox2.Controls.Add(Me.txtJobNumber)
		Me.GroupBox2.Controls.Add(Me.txtPurchaseOrder)
		Me.GroupBox2.Controls.Add(Me.Label18)
		Me.GroupBox2.Location = New System.Drawing.Point(435, 53)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(462, 280)
		Me.GroupBox2.TabIndex = 16
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Related Job Information"
		'
		'cboCostPerUnit
		'
		Me.cboCostPerUnit.FormattingEnabled = True
		Me.cboCostPerUnit.ItemHeight = 13
		Me.cboCostPerUnit.Location = New System.Drawing.Point(200, 204)
		Me.cboCostPerUnit.Name = "cboCostPerUnit"
		Me.cboCostPerUnit.Size = New System.Drawing.Size(244, 21)
		Me.cboCostPerUnit.TabIndex = 12
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Location = New System.Drawing.Point(16, 248)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(137, 17)
		Me.Label13.TabIndex = 11
		Me.Label13.Text = "Vendor Identification"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(16, 205)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(91, 17)
		Me.Label14.TabIndex = 11
		Me.Label14.Text = "Cost Per Unit"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(16, 169)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(61, 17)
		Me.Label15.TabIndex = 11
		Me.Label15.Text = "Quantity"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(16, 90)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(75, 17)
		Me.Label12.TabIndex = 11
		Me.Label12.Text = "Part Name"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Location = New System.Drawing.Point(16, 130)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(109, 17)
		Me.Label16.TabIndex = 11
		Me.Label16.Text = "Part Description"
		'
		'txtVendorIdentification
		'
		Me.txtVendorIdentification.Location = New System.Drawing.Point(200, 246)
		Me.txtVendorIdentification.Name = "txtVendorIdentification"
		Me.txtVendorIdentification.Size = New System.Drawing.Size(244, 20)
		Me.txtVendorIdentification.TabIndex = 15
		'
		'txtQuantity
		'
		Me.txtQuantity.Location = New System.Drawing.Point(200, 165)
		Me.txtQuantity.Name = "txtQuantity"
		Me.txtQuantity.Size = New System.Drawing.Size(244, 20)
		Me.txtQuantity.TabIndex = 13
		'
		'txtPartName
		'
		Me.txtPartName.Location = New System.Drawing.Point(200, 86)
		Me.txtPartName.Name = "txtPartName"
		Me.txtPartName.Size = New System.Drawing.Size(244, 20)
		Me.txtPartName.TabIndex = 11
		'
		'txtPartDescription
		'
		Me.txtPartDescription.Location = New System.Drawing.Point(200, 126)
		Me.txtPartDescription.Name = "txtPartDescription"
		Me.txtPartDescription.Size = New System.Drawing.Size(244, 20)
		Me.txtPartDescription.TabIndex = 12
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(16, 49)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(85, 17)
		Me.Label17.TabIndex = 9
		Me.Label17.Text = "Job Number"
		'
		'txtJobNumber
		'
		Me.txtJobNumber.Location = New System.Drawing.Point(200, 48)
		Me.txtJobNumber.Name = "txtJobNumber"
		Me.txtJobNumber.Size = New System.Drawing.Size(244, 20)
		Me.txtJobNumber.TabIndex = 10
		'
		'txtPurchaseOrder
		'
		Me.txtPurchaseOrder.Location = New System.Drawing.Point(200, 15)
		Me.txtPurchaseOrder.Name = "txtPurchaseOrder"
		Me.txtPurchaseOrder.Size = New System.Drawing.Size(244, 20)
		Me.txtPurchaseOrder.TabIndex = 9
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.Location = New System.Drawing.Point(16, 17)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(163, 17)
		Me.Label18.TabIndex = 6
		Me.Label18.Text = "Purchase Order Number"
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(436, 370)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 17
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSubmit
		'
		Me.btnSubmit.Location = New System.Drawing.Point(770, 370)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(109, 44)
		Me.btnSubmit.TabIndex = 16
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.UseVisualStyleBackColor = True
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(19, 53)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(390, 17)
		Me.Label11.TabIndex = 28
		Me.Label11.Text = "If previous Vendor just enter name under Vendor Information"
		'
		'cboVendor
		'
		Me.cboVendor.FormattingEnabled = True
		Me.cboVendor.Location = New System.Drawing.Point(147, 55)
		Me.cboVendor.Name = "cboVendor"
		Me.cboVendor.Size = New System.Drawing.Size(244, 21)
		Me.cboVendor.TabIndex = 29
		Me.cboVendor.Visible = False
		'
		'lblContactName
		'
		Me.lblContactName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblContactName.Location = New System.Drawing.Point(147, 94)
		Me.lblContactName.Name = "lblContactName"
		Me.lblContactName.Size = New System.Drawing.Size(244, 23)
		Me.lblContactName.TabIndex = 50
		Me.lblContactName.Visible = False
		'
		'lblPhone
		'
		Me.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPhone.Location = New System.Drawing.Point(146, 340)
		Me.lblPhone.Name = "lblPhone"
		Me.lblPhone.Size = New System.Drawing.Size(244, 23)
		Me.lblPhone.TabIndex = 43
		Me.lblPhone.Visible = False
		'
		'lblEmail
		'
		Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblEmail.Location = New System.Drawing.Point(146, 299)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(244, 23)
		Me.lblEmail.TabIndex = 44
		Me.lblEmail.Visible = False
		'
		'lblZip
		'
		Me.lblZip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblZip.Location = New System.Drawing.Point(146, 258)
		Me.lblZip.Name = "lblZip"
		Me.lblZip.Size = New System.Drawing.Size(244, 23)
		Me.lblZip.TabIndex = 45
		Me.lblZip.Visible = False
		'
		'lblState
		'
		Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblState.Location = New System.Drawing.Point(146, 217)
		Me.lblState.Name = "lblState"
		Me.lblState.Size = New System.Drawing.Size(244, 23)
		Me.lblState.TabIndex = 46
		Me.lblState.Visible = False
		'
		'lblCity
		'
		Me.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCity.Location = New System.Drawing.Point(146, 176)
		Me.lblCity.Name = "lblCity"
		Me.lblCity.Size = New System.Drawing.Size(244, 23)
		Me.lblCity.TabIndex = 47
		Me.lblCity.Visible = False
		'
		'lblAddress
		'
		Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblAddress.Location = New System.Drawing.Point(147, 135)
		Me.lblAddress.Name = "lblAddress"
		Me.lblAddress.Size = New System.Drawing.Size(244, 23)
		Me.lblAddress.TabIndex = 48
		Me.lblAddress.Visible = False
		'
		'frmPartsOrdering
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(924, 476)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSubmit)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "frmPartsOrdering"
		Me.Text = "Parts Ordering"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboState As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContactName As TextBox
    Friend WithEvents txtVendorName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboCostPerUnit As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtVendorIdentification As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPartDescription As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtJobNumber As TextBox
    Friend WithEvents txtPurchaseOrder As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents radNo As RadioButton
    Friend WithEvents radYes As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPartName As TextBox
	Friend WithEvents cboVendor As ComboBox
	Friend WithEvents lblContactName As Label
	Friend WithEvents lblPhone As Label
	Friend WithEvents lblEmail As Label
	Friend WithEvents lblZip As Label
	Friend WithEvents lblState As Label
	Friend WithEvents lblCity As Label
	Friend WithEvents lblAddress As Label
End Class
