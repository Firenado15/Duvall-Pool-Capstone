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
		Me.btnNameSearch = New System.Windows.Forms.Button()
		Me.dgvJobs = New System.Windows.Forms.DataGridView()
		Me.GroupBox2.SuspendLayout()
		CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(205, 355)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(109, 44)
		Me.btnClose.TabIndex = 5
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
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
		Me.GroupBox2.Location = New System.Drawing.Point(26, 41)
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
		'btnNameSearch
		'
		Me.btnNameSearch.Location = New System.Drawing.Point(341, 355)
		Me.btnNameSearch.Name = "btnNameSearch"
		Me.btnNameSearch.Size = New System.Drawing.Size(109, 44)
		Me.btnNameSearch.TabIndex = 47
		Me.btnNameSearch.Text = "Search for Customer"
		Me.btnNameSearch.UseVisualStyleBackColor = True
		'
		'dgvJobs
		'
		Me.dgvJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvJobs.Location = New System.Drawing.Point(485, 57)
		Me.dgvJobs.Name = "dgvJobs"
		Me.dgvJobs.ReadOnly = True
		Me.dgvJobs.Size = New System.Drawing.Size(568, 382)
		Me.dgvJobs.TabIndex = 48
		'
		'frmViewJobRecords
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1065, 449)
		Me.Controls.Add(Me.dgvJobs)
		Me.Controls.Add(Me.btnNameSearch)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.GroupBox2)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmViewJobRecords"
		Me.Text = "View Job Records"
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnClose As Button
	Friend WithEvents Label8 As Label
	Friend WithEvents GroupBox2 As GroupBox
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
	Friend WithEvents btnNameSearch As Button
	Friend WithEvents dgvJobs As DataGridView
End Class
