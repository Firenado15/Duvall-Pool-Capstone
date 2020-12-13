<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditJobParts
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditJobParts))
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnRemovePart = New System.Windows.Forms.Button()
		Me.btnAssignPart = New System.Windows.Forms.Button()
		Me.cboJob = New System.Windows.Forms.ComboBox()
		Me.cboName = New System.Windows.Forms.ComboBox()
		Me.dgvAvailableParts = New System.Windows.Forms.DataGridView()
		Me.dgvAssignedParts = New System.Windows.Forms.DataGridView()
		Me.txtPartSearch = New System.Windows.Forms.TextBox()
		Me.btnPartSearch = New System.Windows.Forms.Button()
		Me.txtAddQnty = New System.Windows.Forms.TextBox()
		Me.txtRemoveQnty = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.lblDescription = New System.Windows.Forms.Label()
		CType(Me.dgvAvailableParts, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvAssignedParts, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(463, 95)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(77, 13)
		Me.Label4.TabIndex = 28
		Me.Label4.Text = "Assigned Parts"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(8, 95)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(77, 13)
		Me.Label3.TabIndex = 27
		Me.Label3.Text = "Available Parts"
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(718, 355)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(103, 35)
		Me.btnClose.TabIndex = 26
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(60, 51)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(70, 13)
		Me.Label2.TabIndex = 25
		Me.Label2.Text = "Job Number :"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(42, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(88, 13)
		Me.Label1.TabIndex = 24
		Me.Label1.Text = "Customer Name :"
		'
		'btnRemovePart
		'
		Me.btnRemovePart.Location = New System.Drawing.Point(372, 326)
		Me.btnRemovePart.Name = "btnRemovePart"
		Me.btnRemovePart.Size = New System.Drawing.Size(88, 23)
		Me.btnRemovePart.TabIndex = 23
		Me.btnRemovePart.Text = "<<"
		Me.btnRemovePart.UseVisualStyleBackColor = True
		'
		'btnAssignPart
		'
		Me.btnAssignPart.Location = New System.Drawing.Point(369, 154)
		Me.btnAssignPart.Name = "btnAssignPart"
		Me.btnAssignPart.Size = New System.Drawing.Size(88, 23)
		Me.btnAssignPart.TabIndex = 22
		Me.btnAssignPart.Text = ">>"
		Me.btnAssignPart.UseVisualStyleBackColor = True
		'
		'cboJob
		'
		Me.cboJob.FormattingEnabled = True
		Me.cboJob.Location = New System.Drawing.Point(136, 48)
		Me.cboJob.Name = "cboJob"
		Me.cboJob.Size = New System.Drawing.Size(230, 21)
		Me.cboJob.TabIndex = 19
		'
		'cboName
		'
		Me.cboName.FormattingEnabled = True
		Me.cboName.Location = New System.Drawing.Point(136, 12)
		Me.cboName.Name = "cboName"
		Me.cboName.Size = New System.Drawing.Size(230, 21)
		Me.cboName.TabIndex = 18
		'
		'dgvAvailableParts
		'
		Me.dgvAvailableParts.AllowUserToAddRows = False
		Me.dgvAvailableParts.AllowUserToDeleteRows = False
		Me.dgvAvailableParts.AllowUserToResizeColumns = False
		Me.dgvAvailableParts.AllowUserToResizeRows = False
		Me.dgvAvailableParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvAvailableParts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
		Me.dgvAvailableParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvAvailableParts.Location = New System.Drawing.Point(11, 112)
		Me.dgvAvailableParts.Name = "dgvAvailableParts"
		Me.dgvAvailableParts.ShowEditingIcon = False
		Me.dgvAvailableParts.Size = New System.Drawing.Size(355, 237)
		Me.dgvAvailableParts.TabIndex = 29
		'
		'dgvAssignedParts
		'
		Me.dgvAssignedParts.AllowUserToAddRows = False
		Me.dgvAssignedParts.AllowUserToDeleteRows = False
		Me.dgvAssignedParts.AllowUserToResizeColumns = False
		Me.dgvAssignedParts.AllowUserToResizeRows = False
		Me.dgvAssignedParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvAssignedParts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
		Me.dgvAssignedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvAssignedParts.Location = New System.Drawing.Point(466, 112)
		Me.dgvAssignedParts.Name = "dgvAssignedParts"
		Me.dgvAssignedParts.Size = New System.Drawing.Size(355, 237)
		Me.dgvAssignedParts.TabIndex = 30
		'
		'txtPartSearch
		'
		Me.txtPartSearch.Location = New System.Drawing.Point(12, 355)
		Me.txtPartSearch.Name = "txtPartSearch"
		Me.txtPartSearch.Size = New System.Drawing.Size(228, 20)
		Me.txtPartSearch.TabIndex = 31
		'
		'btnPartSearch
		'
		Me.btnPartSearch.Location = New System.Drawing.Point(246, 353)
		Me.btnPartSearch.Name = "btnPartSearch"
		Me.btnPartSearch.Size = New System.Drawing.Size(120, 23)
		Me.btnPartSearch.TabIndex = 32
		Me.btnPartSearch.Text = "Part Search"
		Me.btnPartSearch.UseVisualStyleBackColor = True
		'
		'txtAddQnty
		'
		Me.txtAddQnty.Location = New System.Drawing.Point(369, 128)
		Me.txtAddQnty.Name = "txtAddQnty"
		Me.txtAddQnty.Size = New System.Drawing.Size(88, 20)
		Me.txtAddQnty.TabIndex = 33
		'
		'txtRemoveQnty
		'
		Me.txtRemoveQnty.Location = New System.Drawing.Point(372, 300)
		Me.txtRemoveQnty.Name = "txtRemoveQnty"
		Me.txtRemoveQnty.Size = New System.Drawing.Size(88, 20)
		Me.txtRemoveQnty.TabIndex = 34
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(369, 112)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(69, 13)
		Me.Label5.TabIndex = 35
		Me.Label5.Text = "Amnt To Add"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(372, 284)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(90, 13)
		Me.Label6.TabIndex = 36
		Me.Label6.Text = "Amnt To Remove"
		'
		'lblDescription
		'
		Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDescription.Location = New System.Drawing.Point(466, 15)
		Me.lblDescription.Name = "lblDescription"
		Me.lblDescription.Size = New System.Drawing.Size(351, 68)
		Me.lblDescription.TabIndex = 37
		'
		'frmEditJobParts
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(829, 398)
		Me.Controls.Add(Me.lblDescription)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtRemoveQnty)
		Me.Controls.Add(Me.txtAddQnty)
		Me.Controls.Add(Me.btnPartSearch)
		Me.Controls.Add(Me.txtPartSearch)
		Me.Controls.Add(Me.dgvAssignedParts)
		Me.Controls.Add(Me.dgvAvailableParts)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnRemovePart)
		Me.Controls.Add(Me.btnAssignPart)
		Me.Controls.Add(Me.cboJob)
		Me.Controls.Add(Me.cboName)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(845, 437)
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(845, 437)
		Me.Name = "frmEditJobParts"
		Me.Text = "Assign Parts to Jobs"
		CType(Me.dgvAvailableParts, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvAssignedParts, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents btnClose As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents btnRemovePart As Button
	Friend WithEvents btnAssignPart As Button
	Friend WithEvents cboJob As ComboBox
	Friend WithEvents cboName As ComboBox
	Friend WithEvents dgvAvailableParts As DataGridView
	Friend WithEvents dgvAssignedParts As DataGridView
	Friend WithEvents txtPartSearch As TextBox
	Friend WithEvents btnPartSearch As Button
	Friend WithEvents txtAddQnty As TextBox
	Friend WithEvents txtRemoveQnty As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents lblDescription As Label
End Class
