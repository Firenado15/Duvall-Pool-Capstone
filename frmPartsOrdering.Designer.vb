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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartsOrdering))
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.radNo = New System.Windows.Forms.RadioButton()
		Me.cboState = New System.Windows.Forms.ComboBox()
		Me.radYes = New System.Windows.Forms.RadioButton()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtPhone = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.txtZip = New System.Windows.Forms.TextBox()
		Me.txtCity = New System.Windows.Forms.TextBox()
		Me.txtAddress = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtContactName = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtVendorName = New System.Windows.Forms.TextBox()
		Me.lblContactName = New System.Windows.Forms.Label()
		Me.lblEmail = New System.Windows.Forms.Label()
		Me.lblZip = New System.Windows.Forms.Label()
		Me.lblState = New System.Windows.Forms.Label()
		Me.lblCity = New System.Windows.Forms.Label()
		Me.lblAddress = New System.Windows.Forms.Label()
		Me.cboVendor = New System.Windows.Forms.ComboBox()
		Me.lblPhone = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.txtUnitCost = New System.Windows.Forms.TextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtQuantity = New System.Windows.Forms.TextBox()
		Me.txtPartName = New System.Windows.Forms.TextBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.txtSerialNumber = New System.Windows.Forms.TextBox()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.btnEditVendorInfo = New System.Windows.Forms.Button()
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
		Me.GroupBox1.Controls.Add(Me.txtPhone)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.txtEmail)
		Me.GroupBox1.Controls.Add(Me.txtZip)
		Me.GroupBox1.Controls.Add(Me.txtCity)
		Me.GroupBox1.Controls.Add(Me.txtAddress)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.txtContactName)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.txtVendorName)
		Me.GroupBox1.Controls.Add(Me.lblContactName)
		Me.GroupBox1.Controls.Add(Me.lblEmail)
		Me.GroupBox1.Controls.Add(Me.lblZip)
		Me.GroupBox1.Controls.Add(Me.lblState)
		Me.GroupBox1.Controls.Add(Me.lblCity)
		Me.GroupBox1.Controls.Add(Me.lblAddress)
		Me.GroupBox1.Controls.Add(Me.cboVendor)
		Me.GroupBox1.Controls.Add(Me.lblPhone)
		Me.GroupBox1.Location = New System.Drawing.Point(13, 29)
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
		Me.Label9.Location = New System.Drawing.Point(25, 302)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(103, 17)
		Me.Label9.TabIndex = 11
		Me.Label9.Text = "Phone Number"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(25, 340)
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
		'txtPhone
		'
		Me.txtPhone.Location = New System.Drawing.Point(146, 296)
		Me.txtPhone.Name = "txtPhone"
		Me.txtPhone.Size = New System.Drawing.Size(244, 20)
		Me.txtPhone.TabIndex = 8
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
		'txtEmail
		'
		Me.txtEmail.Location = New System.Drawing.Point(146, 336)
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
		'txtVendorName
		'
		Me.txtVendorName.Location = New System.Drawing.Point(147, 56)
		Me.txtVendorName.Name = "txtVendorName"
		Me.txtVendorName.Size = New System.Drawing.Size(244, 20)
		Me.txtVendorName.TabIndex = 1
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
		'lblEmail
		'
		Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblEmail.Location = New System.Drawing.Point(145, 338)
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
		'cboVendor
		'
		Me.cboVendor.FormattingEnabled = True
		Me.cboVendor.Location = New System.Drawing.Point(147, 55)
		Me.cboVendor.Name = "cboVendor"
		Me.cboVendor.Size = New System.Drawing.Size(244, 21)
		Me.cboVendor.TabIndex = 29
		Me.cboVendor.Visible = False
		'
		'lblPhone
		'
		Me.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPhone.Location = New System.Drawing.Point(145, 299)
		Me.lblPhone.Name = "lblPhone"
		Me.lblPhone.Size = New System.Drawing.Size(244, 23)
		Me.lblPhone.TabIndex = 43
		Me.lblPhone.Visible = False
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
		Me.GroupBox2.Controls.Add(Me.txtUnitCost)
		Me.GroupBox2.Controls.Add(Me.Label14)
		Me.GroupBox2.Controls.Add(Me.Label15)
		Me.GroupBox2.Controls.Add(Me.Label12)
		Me.GroupBox2.Controls.Add(Me.txtQuantity)
		Me.GroupBox2.Controls.Add(Me.txtPartName)
		Me.GroupBox2.Controls.Add(Me.Label17)
		Me.GroupBox2.Controls.Add(Me.txtSerialNumber)
		Me.GroupBox2.Location = New System.Drawing.Point(437, 29)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(408, 195)
		Me.GroupBox2.TabIndex = 16
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Part Information"
		'
		'txtUnitCost
		'
		Me.txtUnitCost.Location = New System.Drawing.Point(138, 138)
		Me.txtUnitCost.Name = "txtUnitCost"
		Me.txtUnitCost.Size = New System.Drawing.Size(244, 20)
		Me.txtUnitCost.TabIndex = 12
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(6, 133)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(91, 17)
		Me.Label14.TabIndex = 11
		Me.Label14.Text = "Cost Per Unit"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(6, 94)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(61, 17)
		Me.Label15.TabIndex = 11
		Me.Label15.Text = "Quantity"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(6, 55)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(75, 17)
		Me.Label12.TabIndex = 11
		Me.Label12.Text = "Part Name"
		'
		'txtQuantity
		'
		Me.txtQuantity.Location = New System.Drawing.Point(138, 98)
		Me.txtQuantity.Name = "txtQuantity"
		Me.txtQuantity.Size = New System.Drawing.Size(244, 20)
		Me.txtQuantity.TabIndex = 11
		'
		'txtPartName
		'
		Me.txtPartName.Location = New System.Drawing.Point(138, 58)
		Me.txtPartName.Name = "txtPartName"
		Me.txtPartName.Size = New System.Drawing.Size(244, 20)
		Me.txtPartName.TabIndex = 10
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(6, 16)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(98, 17)
		Me.Label17.TabIndex = 9
		Me.Label17.Text = "Serial Number"
		'
		'txtSerialNumber
		'
		Me.txtSerialNumber.Location = New System.Drawing.Point(138, 18)
		Me.txtSerialNumber.Name = "txtSerialNumber"
		Me.txtSerialNumber.Size = New System.Drawing.Size(244, 20)
		Me.txtSerialNumber.TabIndex = 9
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(609, 365)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 14
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSubmit
		'
		Me.btnSubmit.Location = New System.Drawing.Point(736, 365)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(109, 44)
		Me.btnSubmit.TabIndex = 13
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.UseVisualStyleBackColor = True
		'
		'btnEditVendorInfo
		'
		Me.btnEditVendorInfo.Location = New System.Drawing.Point(479, 365)
		Me.btnEditVendorInfo.Name = "btnEditVendorInfo"
		Me.btnEditVendorInfo.Size = New System.Drawing.Size(109, 44)
		Me.btnEditVendorInfo.TabIndex = 15
		Me.btnEditVendorInfo.Text = "Edit Vendor"
		Me.btnEditVendorInfo.UseVisualStyleBackColor = True
		Me.btnEditVendorInfo.Visible = False
		'
		'frmPartsOrdering
		'
		Me.AcceptButton = Me.btnSubmit
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(863, 431)
		Me.Controls.Add(Me.btnEditVendorInfo)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSubmit)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
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
	Friend WithEvents Label14 As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents txtQuantity As TextBox
	Friend WithEvents Label17 As Label
	Friend WithEvents txtSerialNumber As TextBox
	Friend WithEvents btnClose As Button
	Friend WithEvents btnSubmit As Button
	Friend WithEvents radNo As RadioButton
	Friend WithEvents radYes As RadioButton
	Friend WithEvents Label10 As Label
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
	Friend WithEvents txtUnitCost As TextBox
	Friend WithEvents btnEditVendorInfo As Button
End Class
