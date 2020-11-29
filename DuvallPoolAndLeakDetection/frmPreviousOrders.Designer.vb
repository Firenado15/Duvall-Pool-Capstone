<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreviousOrders
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreviousOrders))
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSearch = New System.Windows.Forms.Button()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label26 = New System.Windows.Forms.Label()
		Me.lblVendorIdentification = New System.Windows.Forms.Label()
		Me.lblCostPerUnit = New System.Windows.Forms.Label()
		Me.lblQuantity = New System.Windows.Forms.Label()
		Me.lblPartName = New System.Windows.Forms.Label()
		Me.lblPartDescription = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.lblPhone = New System.Windows.Forms.Label()
		Me.lblEmail = New System.Windows.Forms.Label()
		Me.lblZip = New System.Windows.Forms.Label()
		Me.lblState = New System.Windows.Forms.Label()
		Me.lblCity = New System.Windows.Forms.Label()
		Me.lblAddress = New System.Windows.Forms.Label()
		Me.lblContactName = New System.Windows.Forms.Label()
		Me.lblVendorName = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.cboOrderNumber = New System.Windows.Forms.ComboBox()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(35, 360)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 31
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSearch
		'
		Me.btnSearch.Location = New System.Drawing.Point(388, 360)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(109, 44)
		Me.btnSearch.TabIndex = 32
		Me.btnSearch.Text = "Search"
		Me.btnSearch.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label26)
		Me.GroupBox2.Controls.Add(Me.lblVendorIdentification)
		Me.GroupBox2.Controls.Add(Me.lblCostPerUnit)
		Me.GroupBox2.Controls.Add(Me.lblQuantity)
		Me.GroupBox2.Controls.Add(Me.lblPartName)
		Me.GroupBox2.Controls.Add(Me.lblPartDescription)
		Me.GroupBox2.Controls.Add(Me.Label13)
		Me.GroupBox2.Controls.Add(Me.Label14)
		Me.GroupBox2.Controls.Add(Me.Label15)
		Me.GroupBox2.Controls.Add(Me.Label16)
		Me.GroupBox2.Location = New System.Drawing.Point(35, 150)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(462, 206)
		Me.GroupBox2.TabIndex = 30
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Part Information"
		'
		'Label26
		'
		Me.Label26.AutoSize = True
		Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label26.Location = New System.Drawing.Point(28, 23)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(75, 17)
		Me.Label26.TabIndex = 46
		Me.Label26.Text = "Part Name"
		'
		'lblVendorIdentification
		'
		Me.lblVendorIdentification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVendorIdentification.Location = New System.Drawing.Point(212, 174)
		Me.lblVendorIdentification.Name = "lblVendorIdentification"
		Me.lblVendorIdentification.Size = New System.Drawing.Size(244, 23)
		Me.lblVendorIdentification.TabIndex = 44
		'
		'lblCostPerUnit
		'
		Me.lblCostPerUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCostPerUnit.Location = New System.Drawing.Point(212, 131)
		Me.lblCostPerUnit.Name = "lblCostPerUnit"
		Me.lblCostPerUnit.Size = New System.Drawing.Size(244, 23)
		Me.lblCostPerUnit.TabIndex = 44
		'
		'lblQuantity
		'
		Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblQuantity.Location = New System.Drawing.Point(212, 95)
		Me.lblQuantity.Name = "lblQuantity"
		Me.lblQuantity.Size = New System.Drawing.Size(244, 23)
		Me.lblQuantity.TabIndex = 43
		'
		'lblPartName
		'
		Me.lblPartName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPartName.Location = New System.Drawing.Point(212, 24)
		Me.lblPartName.Name = "lblPartName"
		Me.lblPartName.Size = New System.Drawing.Size(244, 23)
		Me.lblPartName.TabIndex = 43
		'
		'lblPartDescription
		'
		Me.lblPartDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPartDescription.Location = New System.Drawing.Point(212, 56)
		Me.lblPartDescription.Name = "lblPartDescription"
		Me.lblPartDescription.Size = New System.Drawing.Size(244, 23)
		Me.lblPartDescription.TabIndex = 43
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Location = New System.Drawing.Point(28, 173)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(137, 17)
		Me.Label13.TabIndex = 11
		Me.Label13.Text = "Vendor Identification"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(28, 130)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(91, 17)
		Me.Label14.TabIndex = 11
		Me.Label14.Text = "Cost Per Unit"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(28, 94)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(61, 17)
		Me.Label15.TabIndex = 11
		Me.Label15.Text = "Quantity"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Location = New System.Drawing.Point(28, 55)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(109, 17)
		Me.Label16.TabIndex = 11
		Me.Label16.Text = "Part Description"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(346, 21)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(191, 17)
		Me.Label1.TabIndex = 29
		Me.Label1.Text = "Look up previous part orders"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lblPhone)
		Me.GroupBox1.Controls.Add(Me.lblEmail)
		Me.GroupBox1.Controls.Add(Me.lblZip)
		Me.GroupBox1.Controls.Add(Me.lblState)
		Me.GroupBox1.Controls.Add(Me.lblCity)
		Me.GroupBox1.Controls.Add(Me.lblAddress)
		Me.GroupBox1.Controls.Add(Me.lblContactName)
		Me.GroupBox1.Controls.Add(Me.lblVendorName)
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Location = New System.Drawing.Point(527, 71)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(397, 333)
		Me.GroupBox1.TabIndex = 28
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Vendor Information"
		'
		'lblPhone
		'
		Me.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPhone.Location = New System.Drawing.Point(147, 304)
		Me.lblPhone.Name = "lblPhone"
		Me.lblPhone.Size = New System.Drawing.Size(244, 23)
		Me.lblPhone.TabIndex = 43
		'
		'lblEmail
		'
		Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblEmail.Location = New System.Drawing.Point(147, 262)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(244, 23)
		Me.lblEmail.TabIndex = 43
		'
		'lblZip
		'
		Me.lblZip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblZip.Location = New System.Drawing.Point(147, 218)
		Me.lblZip.Name = "lblZip"
		Me.lblZip.Size = New System.Drawing.Size(244, 23)
		Me.lblZip.TabIndex = 43
		'
		'lblState
		'
		Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblState.Location = New System.Drawing.Point(147, 175)
		Me.lblState.Name = "lblState"
		Me.lblState.Size = New System.Drawing.Size(244, 23)
		Me.lblState.TabIndex = 43
		'
		'lblCity
		'
		Me.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCity.Location = New System.Drawing.Point(147, 139)
		Me.lblCity.Name = "lblCity"
		Me.lblCity.Size = New System.Drawing.Size(244, 23)
		Me.lblCity.TabIndex = 43
		'
		'lblAddress
		'
		Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblAddress.Location = New System.Drawing.Point(147, 100)
		Me.lblAddress.Name = "lblAddress"
		Me.lblAddress.Size = New System.Drawing.Size(244, 23)
		Me.lblAddress.TabIndex = 43
		'
		'lblContactName
		'
		Me.lblContactName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblContactName.Location = New System.Drawing.Point(147, 60)
		Me.lblContactName.Name = "lblContactName"
		Me.lblContactName.Size = New System.Drawing.Size(244, 23)
		Me.lblContactName.TabIndex = 43
		'
		'lblVendorName
		'
		Me.lblVendorName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVendorName.Location = New System.Drawing.Point(147, 18)
		Me.lblVendorName.Name = "lblVendorName"
		Me.lblVendorName.Size = New System.Drawing.Size(244, 23)
		Me.lblVendorName.TabIndex = 43
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(16, 303)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(103, 17)
		Me.Label9.TabIndex = 11
		Me.Label9.Text = "Phone Number"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(16, 261)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(98, 17)
		Me.Label8.TabIndex = 11
		Me.Label8.Text = "Email Address"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(16, 217)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(65, 17)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "Zip Code"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(16, 174)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(41, 17)
		Me.Label6.TabIndex = 11
		Me.Label6.Text = "State"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(16, 138)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(31, 17)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "City"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(16, 99)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(60, 17)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Address"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(16, 59)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(97, 17)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Contact Name"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(16, 17)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(95, 17)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Vendor Name"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.Label10)
		Me.GroupBox3.Controls.Add(Me.cboOrderNumber)
		Me.GroupBox3.Location = New System.Drawing.Point(35, 71)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(462, 61)
		Me.GroupBox3.TabIndex = 33
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Search Information"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(6, 26)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(163, 17)
		Me.Label10.TabIndex = 13
		Me.Label10.Text = "Purchase Order Number"
		'
		'cboOrderNumber
		'
		Me.cboOrderNumber.FormattingEnabled = True
		Me.cboOrderNumber.Location = New System.Drawing.Point(200, 25)
		Me.cboOrderNumber.Name = "cboOrderNumber"
		Me.cboOrderNumber.Size = New System.Drawing.Size(244, 21)
		Me.cboOrderNumber.TabIndex = 12
		'
		'frmPreviousOrders
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(948, 432)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmPreviousOrders"
		Me.Text = "Previous Part Orders"
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnClose As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboOrderNumber As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblVendorIdentification As Label
    Friend WithEvents lblCostPerUnit As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblPartDescription As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContactName As Label
    Friend WithEvents lblVendorName As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lblPartName As Label
End Class
