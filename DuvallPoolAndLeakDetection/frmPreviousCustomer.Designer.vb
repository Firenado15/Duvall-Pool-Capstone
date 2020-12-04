<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreviousCustomer
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreviousCustomer))
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSearch = New System.Windows.Forms.Button()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.lblNameOnAccount = New System.Windows.Forms.Label()
		Me.lblAcccountType = New System.Windows.Forms.Label()
		Me.lblAccountNumber = New System.Windows.Forms.Label()
		Me.lblRoutingNumber = New System.Windows.Forms.Label()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.lblCVCNumber = New System.Windows.Forms.Label()
		Me.lblExpiration = New System.Windows.Forms.Label()
		Me.lblCardNumber = New System.Windows.Forms.Label()
		Me.lblCardholderName = New System.Windows.Forms.Label()
		Me.radAmericanExpress = New System.Windows.Forms.RadioButton()
		Me.radMastercard = New System.Windows.Forms.RadioButton()
		Me.radVisa = New System.Windows.Forms.RadioButton()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.radCreditDebit = New System.Windows.Forms.RadioButton()
		Me.radBankTransfer = New System.Windows.Forms.RadioButton()
		Me.radCheck = New System.Windows.Forms.RadioButton()
		Me.radCash = New System.Windows.Forms.RadioButton()
		Me.lblPhone = New System.Windows.Forms.Label()
		Me.lblEmail = New System.Windows.Forms.Label()
		Me.lblAddress = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox7 = New System.Windows.Forms.GroupBox()
		Me.cboName = New System.Windows.Forms.ComboBox()
		Me.Label38 = New System.Windows.Forms.Label()
		Me.btnEditContact = New System.Windows.Forms.Button()
		Me.btnUpdatePayment = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblFirstName = New System.Windows.Forms.Label()
		Me.lblLastName = New System.Windows.Forms.Label()
		Me.dgvJobs = New System.Windows.Forms.DataGridView()
		Me.GroupBox5.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox7.SuspendLayout()
		CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnClose
		'
		Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnClose.Location = New System.Drawing.Point(16, 470)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(89, 44)
		Me.btnClose.TabIndex = 33
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSearch
		'
		Me.btnSearch.Location = New System.Drawing.Point(331, 470)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(89, 44)
		Me.btnSearch.TabIndex = 34
		Me.btnSearch.Text = "Search"
		Me.btnSearch.UseVisualStyleBackColor = True
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.lblNameOnAccount)
		Me.GroupBox5.Controls.Add(Me.lblAcccountType)
		Me.GroupBox5.Controls.Add(Me.lblAccountNumber)
		Me.GroupBox5.Controls.Add(Me.lblRoutingNumber)
		Me.GroupBox5.Controls.Add(Me.Label19)
		Me.GroupBox5.Controls.Add(Me.Label18)
		Me.GroupBox5.Controls.Add(Me.Label16)
		Me.GroupBox5.Controls.Add(Me.Label17)
		Me.GroupBox5.Location = New System.Drawing.Point(12, 335)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(406, 129)
		Me.GroupBox5.TabIndex = 31
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Check/ Bank Transfer"
		'
		'lblNameOnAccount
		'
		Me.lblNameOnAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNameOnAccount.Location = New System.Drawing.Point(139, 89)
		Me.lblNameOnAccount.Name = "lblNameOnAccount"
		Me.lblNameOnAccount.Size = New System.Drawing.Size(244, 23)
		Me.lblNameOnAccount.TabIndex = 42
		'
		'lblAcccountType
		'
		Me.lblAcccountType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblAcccountType.Location = New System.Drawing.Point(139, 66)
		Me.lblAcccountType.Name = "lblAcccountType"
		Me.lblAcccountType.Size = New System.Drawing.Size(244, 23)
		Me.lblAcccountType.TabIndex = 42
		'
		'lblAccountNumber
		'
		Me.lblAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblAccountNumber.Location = New System.Drawing.Point(139, 43)
		Me.lblAccountNumber.Name = "lblAccountNumber"
		Me.lblAccountNumber.Size = New System.Drawing.Size(244, 23)
		Me.lblAccountNumber.TabIndex = 42
		'
		'lblRoutingNumber
		'
		Me.lblRoutingNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblRoutingNumber.Location = New System.Drawing.Point(139, 20)
		Me.lblRoutingNumber.Name = "lblRoutingNumber"
		Me.lblRoutingNumber.Size = New System.Drawing.Size(244, 23)
		Me.lblRoutingNumber.TabIndex = 42
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.Location = New System.Drawing.Point(46, 73)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(79, 15)
		Me.Label19.TabIndex = 11
		Me.Label19.Text = "Account Type"
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.Location = New System.Drawing.Point(27, 50)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(98, 15)
		Me.Label18.TabIndex = 6
		Me.Label18.Text = "Account Number"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Location = New System.Drawing.Point(27, 27)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(98, 15)
		Me.Label16.TabIndex = 6
		Me.Label16.Text = "Routing Number"
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(21, 96)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(104, 15)
		Me.Label17.TabIndex = 6
		Me.Label17.Text = "Name on Account"
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.lblCVCNumber)
		Me.GroupBox4.Controls.Add(Me.lblExpiration)
		Me.GroupBox4.Controls.Add(Me.lblCardNumber)
		Me.GroupBox4.Controls.Add(Me.lblCardholderName)
		Me.GroupBox4.Controls.Add(Me.radAmericanExpress)
		Me.GroupBox4.Controls.Add(Me.radMastercard)
		Me.GroupBox4.Controls.Add(Me.radVisa)
		Me.GroupBox4.Controls.Add(Me.Label15)
		Me.GroupBox4.Controls.Add(Me.Label14)
		Me.GroupBox4.Controls.Add(Me.Label13)
		Me.GroupBox4.Controls.Add(Me.Label12)
		Me.GroupBox4.Location = New System.Drawing.Point(12, 186)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(406, 143)
		Me.GroupBox4.TabIndex = 30
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Credit/Debit"
		'
		'lblCVCNumber
		'
		Me.lblCVCNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCVCNumber.Location = New System.Drawing.Point(139, 102)
		Me.lblCVCNumber.Name = "lblCVCNumber"
		Me.lblCVCNumber.Size = New System.Drawing.Size(244, 23)
		Me.lblCVCNumber.TabIndex = 42
		'
		'lblExpiration
		'
		Me.lblExpiration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblExpiration.Location = New System.Drawing.Point(139, 79)
		Me.lblExpiration.Name = "lblExpiration"
		Me.lblExpiration.Size = New System.Drawing.Size(244, 23)
		Me.lblExpiration.TabIndex = 42
		'
		'lblCardNumber
		'
		Me.lblCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCardNumber.Location = New System.Drawing.Point(139, 56)
		Me.lblCardNumber.Name = "lblCardNumber"
		Me.lblCardNumber.Size = New System.Drawing.Size(244, 23)
		Me.lblCardNumber.TabIndex = 42
		'
		'lblCardholderName
		'
		Me.lblCardholderName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCardholderName.Location = New System.Drawing.Point(139, 33)
		Me.lblCardholderName.Name = "lblCardholderName"
		Me.lblCardholderName.Size = New System.Drawing.Size(244, 23)
		Me.lblCardholderName.TabIndex = 42
		'
		'radAmericanExpress
		'
		Me.radAmericanExpress.AutoSize = True
		Me.radAmericanExpress.Location = New System.Drawing.Point(258, 13)
		Me.radAmericanExpress.Name = "radAmericanExpress"
		Me.radAmericanExpress.Size = New System.Drawing.Size(109, 17)
		Me.radAmericanExpress.TabIndex = 20
		Me.radAmericanExpress.Text = "American Express"
		Me.radAmericanExpress.UseVisualStyleBackColor = True
		'
		'radMastercard
		'
		Me.radMastercard.AutoSize = True
		Me.radMastercard.Location = New System.Drawing.Point(139, 13)
		Me.radMastercard.Name = "radMastercard"
		Me.radMastercard.Size = New System.Drawing.Size(78, 17)
		Me.radMastercard.TabIndex = 20
		Me.radMastercard.Text = "Mastercard"
		Me.radMastercard.UseVisualStyleBackColor = True
		'
		'radVisa
		'
		Me.radVisa.AutoSize = True
		Me.radVisa.Location = New System.Drawing.Point(37, 13)
		Me.radVisa.Name = "radVisa"
		Me.radVisa.Size = New System.Drawing.Size(45, 17)
		Me.radVisa.TabIndex = 20
		Me.radVisa.Text = "Visa"
		Me.radVisa.UseVisualStyleBackColor = True
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(63, 79)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(62, 15)
		Me.Label15.TabIndex = 11
		Me.Label15.Text = "Expiration"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(44, 56)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(81, 15)
		Me.Label14.TabIndex = 6
		Me.Label14.Text = "Card Number"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Location = New System.Drawing.Point(22, 102)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(103, 15)
		Me.Label13.TabIndex = 6
		Me.Label13.Text = "CVV/CVC Number"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(20, 33)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(105, 15)
		Me.Label12.TabIndex = 6
		Me.Label12.Text = "Cardholder Name"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.radCreditDebit)
		Me.GroupBox3.Controls.Add(Me.radBankTransfer)
		Me.GroupBox3.Controls.Add(Me.radCheck)
		Me.GroupBox3.Controls.Add(Me.radCash)
		Me.GroupBox3.Location = New System.Drawing.Point(12, 116)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(406, 64)
		Me.GroupBox3.TabIndex = 29
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Active Payment Type"
		'
		'radCreditDebit
		'
		Me.radCreditDebit.AutoSize = True
		Me.radCreditDebit.Location = New System.Drawing.Point(226, 19)
		Me.radCreditDebit.Name = "radCreditDebit"
		Me.radCreditDebit.Size = New System.Drawing.Size(82, 17)
		Me.radCreditDebit.TabIndex = 20
		Me.radCreditDebit.TabStop = True
		Me.radCreditDebit.Text = "Credit/Debit"
		Me.radCreditDebit.UseVisualStyleBackColor = True
		'
		'radBankTransfer
		'
		Me.radBankTransfer.AutoSize = True
		Me.radBankTransfer.Location = New System.Drawing.Point(226, 39)
		Me.radBankTransfer.Name = "radBankTransfer"
		Me.radBankTransfer.Size = New System.Drawing.Size(92, 17)
		Me.radBankTransfer.TabIndex = 20
		Me.radBankTransfer.TabStop = True
		Me.radBankTransfer.Text = "Bank Transfer"
		Me.radBankTransfer.UseVisualStyleBackColor = True
		'
		'radCheck
		'
		Me.radCheck.AutoSize = True
		Me.radCheck.Location = New System.Drawing.Point(37, 39)
		Me.radCheck.Name = "radCheck"
		Me.radCheck.Size = New System.Drawing.Size(56, 17)
		Me.radCheck.TabIndex = 20
		Me.radCheck.TabStop = True
		Me.radCheck.Text = "Check"
		Me.radCheck.UseVisualStyleBackColor = True
		'
		'radCash
		'
		Me.radCash.AutoSize = True
		Me.radCash.Location = New System.Drawing.Point(37, 16)
		Me.radCash.Name = "radCash"
		Me.radCash.Size = New System.Drawing.Size(49, 17)
		Me.radCash.TabIndex = 20
		Me.radCash.TabStop = True
		Me.radCash.Text = "Cash"
		Me.radCash.UseVisualStyleBackColor = True
		'
		'lblPhone
		'
		Me.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPhone.Location = New System.Drawing.Point(778, 85)
		Me.lblPhone.Name = "lblPhone"
		Me.lblPhone.Size = New System.Drawing.Size(244, 23)
		Me.lblPhone.TabIndex = 41
		'
		'lblEmail
		'
		Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblEmail.Location = New System.Drawing.Point(505, 86)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(171, 23)
		Me.lblEmail.TabIndex = 41
		'
		'lblAddress
		'
		Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblAddress.Location = New System.Drawing.Point(778, 29)
		Me.lblAddress.Name = "lblAddress"
		Me.lblAddress.Size = New System.Drawing.Size(244, 52)
		Me.lblAddress.TabIndex = 41
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(681, 92)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(91, 15)
		Me.Label9.TabIndex = 11
		Me.Label9.Text = "Phone Number"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(413, 86)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(86, 15)
		Me.Label8.TabIndex = 11
		Me.Label8.Text = "Email Address"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(718, 28)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(51, 15)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Address"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(330, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(179, 17)
		Me.Label1.TabIndex = 26
		Me.Label1.Text = "Look up previous customer"
		'
		'GroupBox7
		'
		Me.GroupBox7.Controls.Add(Me.cboName)
		Me.GroupBox7.Controls.Add(Me.Label38)
		Me.GroupBox7.Location = New System.Drawing.Point(12, 39)
		Me.GroupBox7.Name = "GroupBox7"
		Me.GroupBox7.Size = New System.Drawing.Size(398, 61)
		Me.GroupBox7.TabIndex = 40
		Me.GroupBox7.TabStop = False
		Me.GroupBox7.Text = "Search Information"
		'
		'cboName
		'
		Me.cboName.FormattingEnabled = True
		Me.cboName.Location = New System.Drawing.Point(129, 26)
		Me.cboName.Name = "cboName"
		Me.cboName.Size = New System.Drawing.Size(215, 21)
		Me.cboName.TabIndex = 38
		'
		'Label38
		'
		Me.Label38.AutoSize = True
		Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label38.Location = New System.Drawing.Point(63, 27)
		Me.Label38.Name = "Label38"
		Me.Label38.Size = New System.Drawing.Size(60, 15)
		Me.Label38.TabIndex = 37
		Me.Label38.Text = "Customer"
		'
		'btnEditContact
		'
		Me.btnEditContact.Location = New System.Drawing.Point(226, 470)
		Me.btnEditContact.Name = "btnEditContact"
		Me.btnEditContact.Size = New System.Drawing.Size(89, 44)
		Me.btnEditContact.TabIndex = 41
		Me.btnEditContact.Text = "Update Contact Info"
		Me.btnEditContact.UseVisualStyleBackColor = True
		'
		'btnUpdatePayment
		'
		Me.btnUpdatePayment.Location = New System.Drawing.Point(121, 470)
		Me.btnUpdatePayment.Name = "btnUpdatePayment"
		Me.btnUpdatePayment.Size = New System.Drawing.Size(89, 44)
		Me.btnUpdatePayment.TabIndex = 42
		Me.btnUpdatePayment.Text = "Update Payment Info"
		Me.btnUpdatePayment.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(432, 39)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(67, 15)
		Me.Label2.TabIndex = 36
		Me.Label2.Text = "First Name"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(432, 63)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(67, 15)
		Me.Label3.TabIndex = 39
		Me.Label3.Text = "Last Name"
		'
		'lblFirstName
		'
		Me.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblFirstName.Location = New System.Drawing.Point(505, 31)
		Me.lblFirstName.Name = "lblFirstName"
		Me.lblFirstName.Size = New System.Drawing.Size(171, 23)
		Me.lblFirstName.TabIndex = 42
		'
		'lblLastName
		'
		Me.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblLastName.Location = New System.Drawing.Point(505, 58)
		Me.lblLastName.Name = "lblLastName"
		Me.lblLastName.Size = New System.Drawing.Size(171, 23)
		Me.lblLastName.TabIndex = 42
		'
		'dgvJobs
		'
		Me.dgvJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvJobs.Location = New System.Drawing.Point(435, 116)
		Me.dgvJobs.Name = "dgvJobs"
		Me.dgvJobs.ReadOnly = True
		Me.dgvJobs.Size = New System.Drawing.Size(587, 398)
		Me.dgvJobs.TabIndex = 43
		'
		'frmPreviousCustomer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnClose
		Me.ClientSize = New System.Drawing.Size(1038, 526)
		Me.Controls.Add(Me.dgvJobs)
		Me.Controls.Add(Me.lblPhone)
		Me.Controls.Add(Me.lblLastName)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.lblEmail)
		Me.Controls.Add(Me.lblFirstName)
		Me.Controls.Add(Me.btnUpdatePayment)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.btnEditContact)
		Me.Controls.Add(Me.lblAddress)
		Me.Controls.Add(Me.GroupBox7)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.GroupBox5)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.Label1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmPreviousCustomer"
		Me.Text = "Previous Customers"
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox7.ResumeLayout(False)
		Me.GroupBox7.PerformLayout()
		CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnClose As Button
	Friend WithEvents btnSearch As Button
	Friend WithEvents GroupBox5 As GroupBox
	Friend WithEvents Label19 As Label
	Friend WithEvents Label18 As Label
	Friend WithEvents Label16 As Label
	Friend WithEvents Label17 As Label
	Friend WithEvents GroupBox4 As GroupBox
	Friend WithEvents radAmericanExpress As RadioButton
	Friend WithEvents radMastercard As RadioButton
	Friend WithEvents radVisa As RadioButton
	Friend WithEvents Label15 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents radCreditDebit As RadioButton
	Friend WithEvents radBankTransfer As RadioButton
	Friend WithEvents radCheck As RadioButton
	Friend WithEvents radCash As RadioButton
	Friend WithEvents Label9 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents GroupBox7 As GroupBox
	Friend WithEvents lblNameOnAccount As Label
	Friend WithEvents lblAcccountType As Label
	Friend WithEvents lblAccountNumber As Label
	Friend WithEvents lblRoutingNumber As Label
	Friend WithEvents lblCVCNumber As Label
	Friend WithEvents lblExpiration As Label
	Friend WithEvents lblCardNumber As Label
	Friend WithEvents lblCardholderName As Label
	Friend WithEvents lblPhone As Label
	Friend WithEvents lblEmail As Label
	Friend WithEvents lblAddress As Label
	Friend WithEvents Label38 As Label
	Friend WithEvents cboName As ComboBox
	Friend WithEvents btnEditContact As Button
	Friend WithEvents btnUpdatePayment As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lblFirstName As Label
	Friend WithEvents lblLastName As Label
	Friend WithEvents dgvJobs As DataGridView
End Class
