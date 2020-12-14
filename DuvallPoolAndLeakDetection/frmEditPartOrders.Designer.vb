<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditPartOrders
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtDateOrdered = New System.Windows.Forms.DateTimePicker()
        Me.dtDateDelivered = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.radDelivered = New System.Windows.Forms.RadioButton()
        Me.radTransit = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboPartName = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboOrderNumber = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblTotalPurchaseCost = New System.Windows.Forms.Label()
        Me.lblPartDescription = New System.Windows.Forms.Label()
        Me.lblSerialNumber = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblVendorName = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblContactName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtDateOrdered)
        Me.GroupBox4.Controls.Add(Me.dtDateDelivered)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.radDelivered)
        Me.GroupBox4.Controls.Add(Me.radTransit)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 403)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(462, 126)
        Me.GroupBox4.TabIndex = 42
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Delivery Information"
        '
        'dtDateOrdered
        '
        Me.dtDateOrdered.CustomFormat = "MM/dd/yyyy  hh:mm tt"
        Me.dtDateOrdered.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateOrdered.Location = New System.Drawing.Point(212, 23)
        Me.dtDateOrdered.Name = "dtDateOrdered"
        Me.dtDateOrdered.ShowUpDown = True
        Me.dtDateOrdered.Size = New System.Drawing.Size(226, 20)
        Me.dtDateOrdered.TabIndex = 15
        Me.dtDateOrdered.Value = New Date(2020, 12, 10, 12, 0, 0, 0)
        '
        'dtDateDelivered
        '
        Me.dtDateDelivered.CustomFormat = "MM/dd/yyyy  hh:mm tt"
        Me.dtDateDelivered.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateDelivered.Location = New System.Drawing.Point(212, 62)
        Me.dtDateDelivered.Name = "dtDateDelivered"
        Me.dtDateDelivered.ShowUpDown = True
        Me.dtDateDelivered.Size = New System.Drawing.Size(226, 20)
        Me.dtDateDelivered.TabIndex = 16
        Me.dtDateDelivered.Value = New Date(2020, 12, 10, 12, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(28, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Date Expected/Arrived"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(28, 99)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 17)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Shipping"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(28, 27)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 17)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Date Ordered"
        '
        'radDelivered
        '
        Me.radDelivered.AutoSize = True
        Me.radDelivered.Location = New System.Drawing.Point(368, 99)
        Me.radDelivered.Name = "radDelivered"
        Me.radDelivered.Size = New System.Drawing.Size(70, 17)
        Me.radDelivered.TabIndex = 13
        Me.radDelivered.Text = "Delivered"
        Me.radDelivered.UseVisualStyleBackColor = True
        '
        'radTransit
        '
        Me.radTransit.AutoSize = True
        Me.radTransit.Location = New System.Drawing.Point(212, 99)
        Me.radTransit.Name = "radTransit"
        Me.radTransit.Size = New System.Drawing.Size(69, 17)
        Me.radTransit.TabIndex = 14
        Me.radTransit.Text = "In-Transit"
        Me.radTransit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.cboPartName)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cboOrderNumber)
        Me.GroupBox3.Location = New System.Drawing.Point(498, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(465, 92)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search Information"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 17)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Part Name"
        '
        'cboPartName
        '
        Me.cboPartName.FormattingEnabled = True
        Me.cboPartName.Location = New System.Drawing.Point(212, 19)
        Me.cboPartName.Name = "cboPartName"
        Me.cboPartName.Size = New System.Drawing.Size(226, 21)
        Me.cboPartName.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Purchase Order Number"
        '
        'cboOrderNumber
        '
        Me.cboOrderNumber.FormattingEnabled = True
        Me.cboOrderNumber.Location = New System.Drawing.Point(212, 58)
        Me.cboOrderNumber.Name = "cboOrderNumber"
        Me.cboOrderNumber.Size = New System.Drawing.Size(226, 21)
        Me.cboOrderNumber.TabIndex = 12
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(529, 431)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(109, 44)
        Me.btnClose.TabIndex = 39
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(827, 431)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(109, 44)
        Me.btnSubmit.TabIndex = 40
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtQuantity)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.lblTotalPurchaseCost)
        Me.GroupBox2.Controls.Add(Me.lblPartDescription)
        Me.GroupBox2.Controls.Add(Me.lblSerialNumber)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(498, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 222)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Part Information"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(212, 134)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(226, 20)
        Me.txtQuantity.TabIndex = 47
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(28, 23)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(98, 17)
        Me.Label26.TabIndex = 46
        Me.Label26.Text = "Serial Number"
        '
        'lblTotalPurchaseCost
        '
        Me.lblTotalPurchaseCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPurchaseCost.Location = New System.Drawing.Point(212, 182)
        Me.lblTotalPurchaseCost.Name = "lblTotalPurchaseCost"
        Me.lblTotalPurchaseCost.Size = New System.Drawing.Size(226, 23)
        Me.lblTotalPurchaseCost.TabIndex = 44
        '
        'lblPartDescription
        '
        Me.lblPartDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPartDescription.Location = New System.Drawing.Point(212, 66)
        Me.lblPartDescription.Name = "lblPartDescription"
        Me.lblPartDescription.Size = New System.Drawing.Size(226, 55)
        Me.lblPartDescription.TabIndex = 43
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSerialNumber.Location = New System.Drawing.Point(212, 24)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(226, 23)
        Me.lblSerialNumber.TabIndex = 43
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(28, 182)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 17)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Total Purchase Cost"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(28, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 17)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Quantity"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(28, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 17)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Part Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(415, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Update part orders"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblZip)
        Me.GroupBox1.Controls.Add(Me.lblState)
        Me.GroupBox1.Controls.Add(Me.lblVendorName)
        Me.GroupBox1.Controls.Add(Me.lblCity)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.lblContactName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 333)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vendor Information"
        '
        'lblPhone
        '
        Me.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhone.Location = New System.Drawing.Point(212, 304)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(226, 23)
        Me.lblPhone.TabIndex = 43
        '
        'lblEmail
        '
        Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmail.Location = New System.Drawing.Point(212, 265)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(226, 23)
        Me.lblEmail.TabIndex = 43
        '
        'lblZip
        '
        Me.lblZip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZip.Location = New System.Drawing.Point(212, 221)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(226, 23)
        Me.lblZip.TabIndex = 43
        '
        'lblState
        '
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblState.Location = New System.Drawing.Point(212, 178)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(226, 23)
        Me.lblState.TabIndex = 43
        '
        'lblVendorName
        '
        Me.lblVendorName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVendorName.Location = New System.Drawing.Point(212, 21)
        Me.lblVendorName.Name = "lblVendorName"
        Me.lblVendorName.Size = New System.Drawing.Size(226, 23)
        Me.lblVendorName.TabIndex = 43
        '
        'lblCity
        '
        Me.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCity.Location = New System.Drawing.Point(212, 142)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(226, 23)
        Me.lblCity.TabIndex = 43
        '
        'lblAddress
        '
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddress.Location = New System.Drawing.Point(212, 103)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(226, 23)
        Me.lblAddress.TabIndex = 43
        '
        'lblContactName
        '
        Me.lblContactName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblContactName.Location = New System.Drawing.Point(212, 63)
        Me.lblContactName.Name = "lblContactName"
        Me.lblContactName.Size = New System.Drawing.Size(226, 23)
        Me.lblContactName.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 306)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Phone Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Email Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Zip Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "State"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "City"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Contact Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Vendor Name"
        '
        'frmEditPartOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 555)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEditPartOrders"
        Me.Text = "Edit Part Orders"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents radDelivered As RadioButton
    Friend WithEvents radTransit As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cboPartName As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboOrderNumber As ComboBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents lblTotalPurchaseCost As Label
    Friend WithEvents lblPartDescription As Label
    Friend WithEvents lblSerialNumber As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblVendorName As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContactName As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtDateOrdered As DateTimePicker
    Friend WithEvents dtDateDelivered As DateTimePicker
    Friend WithEvents txtQuantity As TextBox
End Class
