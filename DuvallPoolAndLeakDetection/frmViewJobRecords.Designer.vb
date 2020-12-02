<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewJobRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewJobRecords))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEditJobRecord = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblEmployeeNames = New System.Windows.Forms.Label()
        Me.lblNumberOfEmployees = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.cboJobNumber = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radCompleted = New System.Windows.Forms.RadioButton()
        Me.radInProgress = New System.Windows.Forms.RadioButton()
        Me.radScheduled = New System.Windows.Forms.RadioButton()
        Me.btnNameSearch = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(565, 379)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(109, 44)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnEditJobRecord
        '
        Me.btnEditJobRecord.Location = New System.Drawing.Point(733, 379)
        Me.btnEditJobRecord.Name = "btnEditJobRecord"
        Me.btnEditJobRecord.Size = New System.Drawing.Size(109, 44)
        Me.btnEditJobRecord.TabIndex = 4
        Me.btnEditJobRecord.Text = "Edit Job Record"
        Me.btnEditJobRecord.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(417, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(284, 17)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Search by customer name, then job number"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPhone)
        Me.GroupBox2.Controls.Add(Me.lblEmail)
        Me.GroupBox2.Controls.Add(Me.lblZip)
        Me.GroupBox2.Controls.Add(Me.lblState)
        Me.GroupBox2.Controls.Add(Me.lblCity)
        Me.GroupBox2.Controls.Add(Me.lblAddress)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cboName)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Location = New System.Drawing.Point(554, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 295)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Information"
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
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Controls.Add(Me.lblEmployeeNames)
        Me.GroupBox1.Controls.Add(Me.lblNumberOfEmployees)
        Me.GroupBox1.Controls.Add(Me.lblEndDate)
        Me.GroupBox1.Controls.Add(Me.lblStartDate)
        Me.GroupBox1.Controls.Add(Me.cboJobNumber)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 296)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Job Information"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 237)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Job Description"
        '
        'lblDescription
        '
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Location = New System.Drawing.Point(180, 221)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(244, 58)
        Me.lblDescription.TabIndex = 12
        '
        'lblEmployeeNames
        '
        Me.lblEmployeeNames.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeNames.Location = New System.Drawing.Point(180, 178)
        Me.lblEmployeeNames.Name = "lblEmployeeNames"
        Me.lblEmployeeNames.Size = New System.Drawing.Size(244, 28)
        Me.lblEmployeeNames.TabIndex = 12
        '
        'lblNumberOfEmployees
        '
        Me.lblNumberOfEmployees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumberOfEmployees.Location = New System.Drawing.Point(180, 140)
        Me.lblNumberOfEmployees.Name = "lblNumberOfEmployees"
        Me.lblNumberOfEmployees.Size = New System.Drawing.Size(244, 23)
        Me.lblNumberOfEmployees.TabIndex = 12
        '
        'lblEndDate
        '
        Me.lblEndDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEndDate.Location = New System.Drawing.Point(180, 101)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(244, 23)
        Me.lblEndDate.TabIndex = 12
        '
        'lblStartDate
        '
        Me.lblStartDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStartDate.Location = New System.Drawing.Point(180, 59)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(244, 23)
        Me.lblStartDate.TabIndex = 12
        '
        'cboJobNumber
        '
        Me.cboJobNumber.FormattingEnabled = True
        Me.cboJobNumber.Location = New System.Drawing.Point(180, 16)
        Me.cboJobNumber.Name = "cboJobNumber"
        Me.cboJobNumber.Size = New System.Drawing.Size(244, 21)
        Me.cboJobNumber.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Job Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Start Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 183)
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
        Me.Label11.Size = New System.Drawing.Size(67, 17)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "End Date"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radCompleted)
        Me.GroupBox3.Controls.Add(Me.radInProgress)
        Me.GroupBox3.Controls.Add(Me.radScheduled)
        Me.GroupBox3.Location = New System.Drawing.Point(51, 367)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(444, 59)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Job Status"
        '
        'radCompleted
        '
        Me.radCompleted.AutoSize = True
        Me.radCompleted.Location = New System.Drawing.Point(324, 26)
        Me.radCompleted.Name = "radCompleted"
        Me.radCompleted.Size = New System.Drawing.Size(75, 17)
        Me.radCompleted.TabIndex = 47
        Me.radCompleted.TabStop = True
        Me.radCompleted.Text = "Completed"
        Me.radCompleted.UseVisualStyleBackColor = True
        '
        'radInProgress
        '
        Me.radInProgress.AutoSize = True
        Me.radInProgress.Location = New System.Drawing.Point(180, 26)
        Me.radInProgress.Name = "radInProgress"
        Me.radInProgress.Size = New System.Drawing.Size(78, 17)
        Me.radInProgress.TabIndex = 48
        Me.radInProgress.TabStop = True
        Me.radInProgress.Text = "In Progress"
        Me.radInProgress.UseVisualStyleBackColor = True
        '
        'radScheduled
        '
        Me.radScheduled.AutoSize = True
        Me.radScheduled.Location = New System.Drawing.Point(19, 26)
        Me.radScheduled.Name = "radScheduled"
        Me.radScheduled.Size = New System.Drawing.Size(76, 17)
        Me.radScheduled.TabIndex = 49
        Me.radScheduled.TabStop = True
        Me.radScheduled.Text = "Scheduled"
        Me.radScheduled.UseVisualStyleBackColor = True
        '
        'btnNameSearch
        '
        Me.btnNameSearch.Location = New System.Drawing.Point(869, 379)
        Me.btnNameSearch.Name = "btnNameSearch"
        Me.btnNameSearch.Size = New System.Drawing.Size(109, 44)
        Me.btnNameSearch.TabIndex = 47
        Me.btnNameSearch.Text = "Search for Customer"
        Me.btnNameSearch.UseVisualStyleBackColor = True
        '
        'frmViewJobRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 455)
        Me.Controls.Add(Me.btnNameSearch)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnEditJobRecord)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewJobRecords"
        Me.Text = "View Job Records"
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
    Friend WithEvents btnEditJobRecord As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboJobNumber As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboName As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblEmployeeNames As Label
    Friend WithEvents lblNumberOfEmployees As Label
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents radCompleted As RadioButton
    Friend WithEvents radInProgress As RadioButton
    Friend WithEvents radScheduled As RadioButton
    Friend WithEvents btnNameSearch As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents lblDescription As Label
End Class
