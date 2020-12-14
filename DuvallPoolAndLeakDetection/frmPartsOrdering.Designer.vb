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
        Me.chkVerify = New System.Windows.Forms.CheckBox()
        Me.radPartNo = New System.Windows.Forms.RadioButton()
        Me.radPartYes = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtUnitCostBus = New System.Windows.Forms.TextBox()
        Me.txtUnitCostCust = New System.Windows.Forms.TextBox()
        Me.lblCostPerUnitBus = New System.Windows.Forms.Label()
        Me.lblCostPerUnitCust = New System.Windows.Forms.Label()
        Me.txtPartDescription = New System.Windows.Forms.TextBox()
        Me.lblPartDescription = New System.Windows.Forms.Label()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.lblSerialNumber = New System.Windows.Forms.Label()
        Me.txtPartName = New System.Windows.Forms.TextBox()
        Me.cboPartName = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnEditVendorInfo = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.radDelivered = New System.Windows.Forms.RadioButton()
        Me.radTransit = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtDateDelivered = New System.Windows.Forms.DateTimePicker()
        Me.dtDateOrdered = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnEditPart = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.GroupBox1.TabIndex = 0
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
        Me.radNo.TabIndex = 1
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
        Me.cboState.TabIndex = 6
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Location = New System.Drawing.Point(187, 19)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(43, 17)
        Me.radYes.TabIndex = 0
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
        Me.txtEmail.TabIndex = 9
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(147, 257)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(244, 20)
        Me.txtZip.TabIndex = 7
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(147, 176)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(244, 20)
        Me.txtCity.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(147, 136)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(244, 20)
        Me.txtAddress.TabIndex = 4
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
        Me.txtContactName.TabIndex = 3
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
        Me.txtVendorName.TabIndex = 2
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
        Me.Label1.Location = New System.Drawing.Point(323, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Enter information for ordering parts"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkVerify)
        Me.GroupBox2.Controls.Add(Me.radPartNo)
        Me.GroupBox2.Controls.Add(Me.radPartYes)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtQuantity)
        Me.GroupBox2.Controls.Add(Me.txtUnitCostBus)
        Me.GroupBox2.Controls.Add(Me.txtUnitCostCust)
        Me.GroupBox2.Controls.Add(Me.lblCostPerUnitBus)
        Me.GroupBox2.Controls.Add(Me.lblCostPerUnitCust)
        Me.GroupBox2.Controls.Add(Me.txtPartDescription)
        Me.GroupBox2.Controls.Add(Me.lblPartDescription)
        Me.GroupBox2.Controls.Add(Me.txtSerialNumber)
        Me.GroupBox2.Controls.Add(Me.lblSerialNumber)
        Me.GroupBox2.Controls.Add(Me.txtPartName)
        Me.GroupBox2.Controls.Add(Me.cboPartName)
        Me.GroupBox2.Location = New System.Drawing.Point(437, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 368)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Part Information"
        '
        'chkVerify
        '
        Me.chkVerify.AutoSize = True
        Me.chkVerify.Location = New System.Drawing.Point(265, 341)
        Me.chkVerify.Name = "chkVerify"
        Me.chkVerify.Size = New System.Drawing.Size(44, 17)
        Me.chkVerify.TabIndex = 36
        Me.chkVerify.Text = "Yes"
        Me.chkVerify.UseVisualStyleBackColor = True
        '
        'radPartNo
        '
        Me.radPartNo.AutoSize = True
        Me.radPartNo.Checked = True
        Me.radPartNo.Location = New System.Drawing.Point(265, 19)
        Me.radPartNo.Name = "radPartNo"
        Me.radPartNo.Size = New System.Drawing.Size(39, 17)
        Me.radPartNo.TabIndex = 1
        Me.radPartNo.TabStop = True
        Me.radPartNo.Text = "No"
        Me.radPartNo.UseVisualStyleBackColor = True
        '
        'radPartYes
        '
        Me.radPartYes.AutoSize = True
        Me.radPartYes.Location = New System.Drawing.Point(170, 19)
        Me.radPartYes.Name = "radPartYes"
        Me.radPartYes.Size = New System.Drawing.Size(43, 17)
        Me.radPartYes.TabIndex = 0
        Me.radPartYes.Text = "Yes"
        Me.radPartYes.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(7, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 17)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Previous Part"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 340)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(182, 17)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Verify Information Is Correct"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 297)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(161, 17)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Cost Per Unit(Customer)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 254)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(158, 17)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Cost Per Unit(Business)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 214)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 17)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Quantity"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 151)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(109, 17)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Part Description"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Part Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 97)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 17)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Serial Number"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(173, 213)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(210, 20)
        Me.txtQuantity.TabIndex = 5
        '
        'txtUnitCostBus
        '
        Me.txtUnitCostBus.Location = New System.Drawing.Point(173, 253)
        Me.txtUnitCostBus.Name = "txtUnitCostBus"
        Me.txtUnitCostBus.Size = New System.Drawing.Size(210, 20)
        Me.txtUnitCostBus.TabIndex = 6
        '
        'txtUnitCostCust
        '
        Me.txtUnitCostCust.Location = New System.Drawing.Point(173, 296)
        Me.txtUnitCostCust.Name = "txtUnitCostCust"
        Me.txtUnitCostCust.Size = New System.Drawing.Size(210, 20)
        Me.txtUnitCostCust.TabIndex = 7
        '
        'lblCostPerUnitBus
        '
        Me.lblCostPerUnitBus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCostPerUnitBus.Location = New System.Drawing.Point(173, 253)
        Me.lblCostPerUnitBus.Name = "lblCostPerUnitBus"
        Me.lblCostPerUnitBus.Size = New System.Drawing.Size(210, 19)
        Me.lblCostPerUnitBus.TabIndex = 33
        Me.lblCostPerUnitBus.Visible = False
        '
        'lblCostPerUnitCust
        '
        Me.lblCostPerUnitCust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCostPerUnitCust.Location = New System.Drawing.Point(173, 296)
        Me.lblCostPerUnitCust.Name = "lblCostPerUnitCust"
        Me.lblCostPerUnitCust.Size = New System.Drawing.Size(210, 19)
        Me.lblCostPerUnitCust.TabIndex = 33
        Me.lblCostPerUnitCust.Visible = False
        '
        'txtPartDescription
        '
        Me.txtPartDescription.Location = New System.Drawing.Point(173, 135)
        Me.txtPartDescription.Multiline = True
        Me.txtPartDescription.Name = "txtPartDescription"
        Me.txtPartDescription.Size = New System.Drawing.Size(210, 60)
        Me.txtPartDescription.TabIndex = 4
        '
        'lblPartDescription
        '
        Me.lblPartDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPartDescription.Location = New System.Drawing.Point(173, 136)
        Me.lblPartDescription.Name = "lblPartDescription"
        Me.lblPartDescription.Size = New System.Drawing.Size(210, 59)
        Me.lblPartDescription.TabIndex = 34
        Me.lblPartDescription.Visible = False
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Location = New System.Drawing.Point(173, 96)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(210, 20)
        Me.txtSerialNumber.TabIndex = 3
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSerialNumber.Location = New System.Drawing.Point(173, 97)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(210, 19)
        Me.lblSerialNumber.TabIndex = 33
        Me.lblSerialNumber.Visible = False
        '
        'txtPartName
        '
        Me.txtPartName.Location = New System.Drawing.Point(173, 58)
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.Size = New System.Drawing.Size(210, 20)
        Me.txtPartName.TabIndex = 2
        '
        'cboPartName
        '
        Me.cboPartName.FormattingEnabled = True
        Me.cboPartName.Location = New System.Drawing.Point(173, 57)
        Me.cboPartName.Name = "cboPartName"
        Me.cboPartName.Size = New System.Drawing.Size(210, 21)
        Me.cboPartName.TabIndex = 35
        Me.cboPartName.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(711, 500)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(109, 44)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(711, 435)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(109, 44)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnEditVendorInfo
        '
        Me.btnEditVendorInfo.Location = New System.Drawing.Point(447, 435)
        Me.btnEditVendorInfo.Name = "btnEditVendorInfo"
        Me.btnEditVendorInfo.Size = New System.Drawing.Size(109, 44)
        Me.btnEditVendorInfo.TabIndex = 6
        Me.btnEditVendorInfo.Text = "Edit Vendor"
        Me.btnEditVendorInfo.UseVisualStyleBackColor = True
        Me.btnEditVendorInfo.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Date Ordered"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(149, 17)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Date Expected/Arrived"
        '
        'radDelivered
        '
        Me.radDelivered.AutoSize = True
        Me.radDelivered.Location = New System.Drawing.Point(320, 99)
        Me.radDelivered.Name = "radDelivered"
        Me.radDelivered.Size = New System.Drawing.Size(70, 17)
        Me.radDelivered.TabIndex = 3
        Me.radDelivered.Text = "Delivered"
        Me.radDelivered.UseVisualStyleBackColor = True
        '
        'radTransit
        '
        Me.radTransit.AutoSize = True
        Me.radTransit.Location = New System.Drawing.Point(171, 99)
        Me.radTransit.Name = "radTransit"
        Me.radTransit.Size = New System.Drawing.Size(69, 17)
        Me.radTransit.TabIndex = 2
        Me.radTransit.Text = "In-Transit"
        Me.radTransit.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 99)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 17)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Shipping"
        '
        'dtDateDelivered
        '
        Me.dtDateDelivered.CustomFormat = "MM/dd/yyyy  hh:mm tt"
        Me.dtDateDelivered.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateDelivered.Location = New System.Drawing.Point(171, 59)
        Me.dtDateDelivered.Name = "dtDateDelivered"
        Me.dtDateDelivered.ShowUpDown = True
        Me.dtDateDelivered.Size = New System.Drawing.Size(219, 20)
        Me.dtDateDelivered.TabIndex = 1
        Me.dtDateDelivered.Value = New Date(2020, 12, 10, 12, 0, 0, 0)
        '
        'dtDateOrdered
        '
        Me.dtDateOrdered.CustomFormat = "MM/dd/yyyy  hh:mm tt"
        Me.dtDateOrdered.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateOrdered.Location = New System.Drawing.Point(171, 20)
        Me.dtDateOrdered.Name = "dtDateOrdered"
        Me.dtDateOrdered.ShowUpDown = True
        Me.dtDateOrdered.Size = New System.Drawing.Size(219, 20)
        Me.dtDateOrdered.TabIndex = 0
        Me.dtDateOrdered.Value = New Date(2020, 12, 10, 12, 0, 0, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtDateOrdered)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.dtDateDelivered)
        Me.GroupBox3.Controls.Add(Me.radDelivered)
        Me.GroupBox3.Controls.Add(Me.radTransit)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 415)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(398, 126)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Delivery Information"
        '
        'btnEditPart
        '
        Me.btnEditPart.Location = New System.Drawing.Point(447, 500)
        Me.btnEditPart.Name = "btnEditPart"
        Me.btnEditPart.Size = New System.Drawing.Size(109, 44)
        Me.btnEditPart.TabIndex = 7
        Me.btnEditPart.Text = "Edit Part"
        Me.btnEditPart.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(584, 500)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(109, 44)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmPartsOrdering
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 568)
        Me.Controls.Add(Me.btnEditPart)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnEditVendorInfo)
        Me.Controls.Add(Me.btnReset)
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
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
	Friend WithEvents txtUnitCostBus As TextBox
	Friend WithEvents btnEditVendorInfo As Button
	Friend WithEvents radTransit As RadioButton
	Friend WithEvents radDelivered As RadioButton
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dtDateDelivered As DateTimePicker
    Friend WithEvents dtDateOrdered As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPartDescription As TextBox
    Friend WithEvents radPartNo As RadioButton
    Friend WithEvents radPartYes As RadioButton
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtUnitCostCust As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents lblSerialNumber As Label
    Friend WithEvents lblCostPerUnitBus As Label
    Friend WithEvents lblCostPerUnitCust As Label
    Friend WithEvents lblPartDescription As Label
    Friend WithEvents cboPartName As ComboBox
    Friend WithEvents btnEditPart As Button
    Friend WithEvents chkVerify As CheckBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btnReset As Button
End Class
