<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddJobRecords
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
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.radCompleted = New System.Windows.Forms.RadioButton()
		Me.radInProgress = New System.Windows.Forms.RadioButton()
		Me.radScheduled = New System.Windows.Forms.RadioButton()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.chkCustomer = New System.Windows.Forms.CheckBox()
		Me.lblPhone = New System.Windows.Forms.Label()
		Me.lblEmail = New System.Windows.Forms.Label()
		Me.lblZip = New System.Windows.Forms.Label()
		Me.lblState = New System.Windows.Forms.Label()
		Me.lblCity = New System.Windows.Forms.Label()
		Me.lblAddress = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.cboName = New System.Windows.Forms.ComboBox()
		Me.Label38 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtJobDescription = New System.Windows.Forms.TextBox()
		Me.txtEmployeeNames = New System.Windows.Forms.TextBox()
		Me.txtNumberEmployees = New System.Windows.Forms.TextBox()
		Me.btnSearch = New System.Windows.Forms.Button()
		Me.dtEndDate = New System.Windows.Forms.DateTimePicker()
		Me.dtStartDate = New System.Windows.Forms.DateTimePicker()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.radCompleted)
		Me.GroupBox3.Controls.Add(Me.radInProgress)
		Me.GroupBox3.Controls.Add(Me.radScheduled)
		Me.GroupBox3.Location = New System.Drawing.Point(23, 363)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(444, 59)
		Me.GroupBox3.TabIndex = 1
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Job Status"
		'
		'radCompleted
		'
		Me.radCompleted.AutoSize = True
		Me.radCompleted.Location = New System.Drawing.Point(328, 29)
		Me.radCompleted.Name = "radCompleted"
		Me.radCompleted.Size = New System.Drawing.Size(75, 17)
		Me.radCompleted.TabIndex = 2
		Me.radCompleted.TabStop = True
		Me.radCompleted.Text = "Completed"
		Me.radCompleted.UseVisualStyleBackColor = True
		'
		'radInProgress
		'
		Me.radInProgress.AutoSize = True
		Me.radInProgress.Location = New System.Drawing.Point(180, 29)
		Me.radInProgress.Name = "radInProgress"
		Me.radInProgress.Size = New System.Drawing.Size(78, 17)
		Me.radInProgress.TabIndex = 1
		Me.radInProgress.TabStop = True
		Me.radInProgress.Text = "In Progress"
		Me.radInProgress.UseVisualStyleBackColor = True
		'
		'radScheduled
		'
		Me.radScheduled.AutoSize = True
		Me.radScheduled.Location = New System.Drawing.Point(19, 29)
		Me.radScheduled.Name = "radScheduled"
		Me.radScheduled.Size = New System.Drawing.Size(76, 17)
		Me.radScheduled.TabIndex = 0
		Me.radScheduled.TabStop = True
		Me.radScheduled.Text = "Scheduled"
		Me.radScheduled.UseVisualStyleBackColor = True
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(42, 428)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 5
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnSubmit
		'
		Me.btnSubmit.Location = New System.Drawing.Point(841, 428)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(109, 44)
		Me.btnSubmit.TabIndex = 3
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.UseVisualStyleBackColor = True
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(389, 20)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(195, 17)
		Me.Label8.TabIndex = 45
		Me.Label8.Text = "Enter information to add a job"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.chkCustomer)
		Me.GroupBox2.Controls.Add(Me.lblPhone)
		Me.GroupBox2.Controls.Add(Me.lblEmail)
		Me.GroupBox2.Controls.Add(Me.lblZip)
		Me.GroupBox2.Controls.Add(Me.lblState)
		Me.GroupBox2.Controls.Add(Me.lblCity)
		Me.GroupBox2.Controls.Add(Me.lblAddress)
		Me.GroupBox2.Controls.Add(Me.Label10)
		Me.GroupBox2.Controls.Add(Me.Label9)
		Me.GroupBox2.Controls.Add(Me.Label1)
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Controls.Add(Me.cboName)
		Me.GroupBox2.Controls.Add(Me.Label38)
		Me.GroupBox2.Location = New System.Drawing.Point(526, 64)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(444, 344)
		Me.GroupBox2.TabIndex = 2
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Customer Information"
		'
		'chkCustomer
		'
		Me.chkCustomer.AutoSize = True
		Me.chkCustomer.Location = New System.Drawing.Point(180, 314)
		Me.chkCustomer.Name = "chkCustomer"
		Me.chkCustomer.Size = New System.Drawing.Size(60, 17)
		Me.chkCustomer.TabIndex = 1
		Me.chkCustomer.Text = "Correct"
		Me.chkCustomer.UseVisualStyleBackColor = True
		'
		'lblPhone
		'
		Me.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPhone.Location = New System.Drawing.Point(179, 263)
		Me.lblPhone.Name = "lblPhone"
		Me.lblPhone.Size = New System.Drawing.Size(244, 23)
		Me.lblPhone.TabIndex = 6
		'
		'lblEmail
		'
		Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblEmail.Location = New System.Drawing.Point(179, 221)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(244, 23)
		Me.lblEmail.TabIndex = 5
		'
		'lblZip
		'
		Me.lblZip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblZip.Location = New System.Drawing.Point(179, 177)
		Me.lblZip.Name = "lblZip"
		Me.lblZip.Size = New System.Drawing.Size(244, 23)
		Me.lblZip.TabIndex = 4
		'
		'lblState
		'
		Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblState.Location = New System.Drawing.Point(179, 134)
		Me.lblState.Name = "lblState"
		Me.lblState.Size = New System.Drawing.Size(244, 23)
		Me.lblState.TabIndex = 3
		'
		'lblCity
		'
		Me.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblCity.Location = New System.Drawing.Point(179, 98)
		Me.lblCity.Name = "lblCity"
		Me.lblCity.Size = New System.Drawing.Size(244, 23)
		Me.lblCity.TabIndex = 2
		'
		'lblAddress
		'
		Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblAddress.Location = New System.Drawing.Point(180, 59)
		Me.lblAddress.Name = "lblAddress"
		Me.lblAddress.Size = New System.Drawing.Size(244, 23)
		Me.lblAddress.TabIndex = 1
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(8, 314)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(106, 17)
		Me.Label10.TabIndex = 42
		Me.Label10.Text = "Verify customer"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(8, 262)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(103, 17)
		Me.Label9.TabIndex = 42
		Me.Label9.Text = "Phone Number"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(8, 220)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(98, 17)
		Me.Label1.TabIndex = 43
		Me.Label1.Text = "Email Address"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(8, 176)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(65, 17)
		Me.Label7.TabIndex = 44
		Me.Label7.Text = "Zip Code"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(8, 133)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(41, 17)
		Me.Label6.TabIndex = 45
		Me.Label6.Text = "State"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(8, 97)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(31, 17)
		Me.Label5.TabIndex = 46
		Me.Label5.Text = "City"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(8, 58)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(60, 17)
		Me.Label4.TabIndex = 47
		Me.Label4.Text = "Address"
		'
		'cboName
		'
		Me.cboName.FormattingEnabled = True
		Me.cboName.Location = New System.Drawing.Point(179, 16)
		Me.cboName.Name = "cboName"
		Me.cboName.Size = New System.Drawing.Size(245, 21)
		Me.cboName.TabIndex = 0
		'
		'Label38
		'
		Me.Label38.AutoSize = True
		Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label38.Location = New System.Drawing.Point(8, 17)
		Me.Label38.Name = "Label38"
		Me.Label38.Size = New System.Drawing.Size(152, 17)
		Me.Label38.TabIndex = 39
		Me.Label38.Text = "Last Name, First Name"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.dtEndDate)
		Me.GroupBox1.Controls.Add(Me.dtStartDate)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label14)
		Me.GroupBox1.Controls.Add(Me.Label15)
		Me.GroupBox1.Controls.Add(Me.Label13)
		Me.GroupBox1.Controls.Add(Me.Label12)
		Me.GroupBox1.Controls.Add(Me.Label11)
		Me.GroupBox1.Controls.Add(Me.txtJobDescription)
		Me.GroupBox1.Controls.Add(Me.txtEmployeeNames)
		Me.GroupBox1.Controls.Add(Me.txtNumberEmployees)
		Me.GroupBox1.Location = New System.Drawing.Point(23, 64)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(444, 293)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Job Information"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(78, 17)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(262, 17)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Job Number is automatically genereated"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(16, 56)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(147, 17)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Start Date (estimated)"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(16, 241)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(106, 17)
		Me.Label14.TabIndex = 11
		Me.Label14.Text = "Job Description"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(16, 193)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(142, 17)
		Me.Label15.TabIndex = 11
		Me.Label15.Text = "(First Last, First Last)"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Location = New System.Drawing.Point(16, 176)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(118, 17)
		Me.Label13.TabIndex = 11
		Me.Label13.Text = "Employee Names"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(16, 139)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(147, 17)
		Me.Label12.TabIndex = 11
		Me.Label12.Text = "Number of Employees"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(16, 100)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(146, 17)
		Me.Label11.TabIndex = 9
		Me.Label11.Text = "End Date (estimated) "
		'
		'txtJobDescription
		'
		Me.txtJobDescription.Location = New System.Drawing.Point(180, 215)
		Me.txtJobDescription.Multiline = True
		Me.txtJobDescription.Name = "txtJobDescription"
		Me.txtJobDescription.Size = New System.Drawing.Size(244, 64)
		Me.txtJobDescription.TabIndex = 4
		'
		'txtEmployeeNames
		'
		Me.txtEmployeeNames.Location = New System.Drawing.Point(180, 176)
		Me.txtEmployeeNames.Name = "txtEmployeeNames"
		Me.txtEmployeeNames.Size = New System.Drawing.Size(244, 20)
		Me.txtEmployeeNames.TabIndex = 3
		'
		'txtNumberEmployees
		'
		Me.txtNumberEmployees.Location = New System.Drawing.Point(180, 137)
		Me.txtNumberEmployees.Name = "txtNumberEmployees"
		Me.txtNumberEmployees.Size = New System.Drawing.Size(244, 20)
		Me.txtNumberEmployees.TabIndex = 2
		'
		'btnSearch
		'
		Me.btnSearch.Location = New System.Drawing.Point(705, 428)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(109, 44)
		Me.btnSearch.TabIndex = 4
		Me.btnSearch.Text = "Search for Customer"
		Me.btnSearch.UseVisualStyleBackColor = True
		'
		'dtEndDate
		'
		Me.dtEndDate.Location = New System.Drawing.Point(180, 98)
		Me.dtEndDate.Name = "dtEndDate"
		Me.dtEndDate.Size = New System.Drawing.Size(244, 20)
		Me.dtEndDate.TabIndex = 17
		'
		'dtStartDate
		'
		Me.dtStartDate.Location = New System.Drawing.Point(180, 59)
		Me.dtStartDate.Name = "dtStartDate"
		Me.dtStartDate.Size = New System.Drawing.Size(244, 20)
		Me.dtStartDate.TabIndex = 16
		'
		'frmAddJobRecords
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(990, 484)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSubmit)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "frmAddJobRecords"
		Me.Text = "frmAddJobRecords"
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSubmit As Button
	Friend WithEvents Label8 As Label
	Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkCustomer As CheckBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboName As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEmployeeNames As TextBox
    Friend WithEvents txtNumberEmployees As TextBox
    Friend WithEvents radCompleted As RadioButton
    Friend WithEvents radInProgress As RadioButton
    Friend WithEvents radScheduled As RadioButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtJobDescription As TextBox
    Friend WithEvents Label15 As Label
	Friend WithEvents dtEndDate As DateTimePicker
	Friend WithEvents dtStartDate As DateTimePicker
End Class
