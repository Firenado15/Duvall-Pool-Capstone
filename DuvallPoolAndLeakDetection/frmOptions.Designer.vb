<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCustomerIntake = New System.Windows.Forms.Button()
        Me.btnPartsOrdering = New System.Windows.Forms.Button()
        Me.btnDispatchOrders = New System.Windows.Forms.Button()
        Me.btnInvoicing = New System.Windows.Forms.Button()
        Me.btnInventoryManagement = New System.Windows.Forms.Button()
        Me.btnEditFinances = New System.Windows.Forms.Button()
        Me.btnCustomerReviews = New System.Windows.Forms.Button()
        Me.btnViewPreviousCustomer = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPreviousPartsOrders = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnViewOrders = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnPreviousInvoices = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnViewFinances = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnEditJobRecords = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select option for process"
        '
        'btnCustomerIntake
        '
        Me.btnCustomerIntake.Location = New System.Drawing.Point(14, 15)
        Me.btnCustomerIntake.Name = "btnCustomerIntake"
        Me.btnCustomerIntake.Size = New System.Drawing.Size(136, 23)
        Me.btnCustomerIntake.TabIndex = 5
        Me.btnCustomerIntake.Text = "Customer Intake"
        Me.btnCustomerIntake.UseVisualStyleBackColor = True
        '
        'btnPartsOrdering
        '
        Me.btnPartsOrdering.Location = New System.Drawing.Point(14, 14)
        Me.btnPartsOrdering.Name = "btnPartsOrdering"
        Me.btnPartsOrdering.Size = New System.Drawing.Size(136, 23)
        Me.btnPartsOrdering.TabIndex = 6
        Me.btnPartsOrdering.Text = "Parts Ordering"
        Me.btnPartsOrdering.UseVisualStyleBackColor = True
        '
        'btnDispatchOrders
        '
        Me.btnDispatchOrders.Location = New System.Drawing.Point(14, 19)
        Me.btnDispatchOrders.Name = "btnDispatchOrders"
        Me.btnDispatchOrders.Size = New System.Drawing.Size(136, 23)
        Me.btnDispatchOrders.TabIndex = 7
        Me.btnDispatchOrders.Text = "Dispatch Orders"
        Me.btnDispatchOrders.UseVisualStyleBackColor = True
        '
        'btnInvoicing
        '
        Me.btnInvoicing.Location = New System.Drawing.Point(14, 19)
        Me.btnInvoicing.Name = "btnInvoicing"
        Me.btnInvoicing.Size = New System.Drawing.Size(136, 23)
        Me.btnInvoicing.TabIndex = 8
        Me.btnInvoicing.Text = "Invoicing"
        Me.btnInvoicing.UseVisualStyleBackColor = True
        '
        'btnInventoryManagement
        '
        Me.btnInventoryManagement.Location = New System.Drawing.Point(94, 19)
        Me.btnInventoryManagement.Name = "btnInventoryManagement"
        Me.btnInventoryManagement.Size = New System.Drawing.Size(136, 23)
        Me.btnInventoryManagement.TabIndex = 9
        Me.btnInventoryManagement.Text = "Inventory Management"
        Me.btnInventoryManagement.UseVisualStyleBackColor = True
        '
        'btnEditFinances
        '
        Me.btnEditFinances.Location = New System.Drawing.Point(14, 18)
        Me.btnEditFinances.Name = "btnEditFinances"
        Me.btnEditFinances.Size = New System.Drawing.Size(136, 23)
        Me.btnEditFinances.TabIndex = 10
        Me.btnEditFinances.Text = "Add Finances"
        Me.btnEditFinances.UseVisualStyleBackColor = True
        '
        'btnCustomerReviews
        '
        Me.btnCustomerReviews.Location = New System.Drawing.Point(300, 467)
        Me.btnCustomerReviews.Name = "btnCustomerReviews"
        Me.btnCustomerReviews.Size = New System.Drawing.Size(136, 23)
        Me.btnCustomerReviews.TabIndex = 13
        Me.btnCustomerReviews.Text = "View Customer Reviews"
        Me.btnCustomerReviews.UseVisualStyleBackColor = True
        '
        'btnViewPreviousCustomer
        '
        Me.btnViewPreviousCustomer.Location = New System.Drawing.Point(177, 15)
        Me.btnViewPreviousCustomer.Name = "btnViewPreviousCustomer"
        Me.btnViewPreviousCustomer.Size = New System.Drawing.Size(136, 23)
        Me.btnViewPreviousCustomer.TabIndex = 5
        Me.btnViewPreviousCustomer.Text = "View Previous Customer"
        Me.btnViewPreviousCustomer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnViewPreviousCustomer)
        Me.GroupBox1.Controls.Add(Me.btnCustomerIntake)
        Me.GroupBox1.Location = New System.Drawing.Point(123, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 53)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer"
        '
        'btnPreviousPartsOrders
        '
        Me.btnPreviousPartsOrders.Location = New System.Drawing.Point(177, 14)
        Me.btnPreviousPartsOrders.Name = "btnPreviousPartsOrders"
        Me.btnPreviousPartsOrders.Size = New System.Drawing.Size(136, 23)
        Me.btnPreviousPartsOrders.TabIndex = 6
        Me.btnPreviousPartsOrders.Text = "View Previous Orders"
        Me.btnPreviousPartsOrders.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPreviousPartsOrders)
        Me.GroupBox2.Controls.Add(Me.btnPartsOrdering)
        Me.GroupBox2.Location = New System.Drawing.Point(123, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 53)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ordering Parts"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnViewOrders)
        Me.GroupBox3.Controls.Add(Me.btnDispatchOrders)
        Me.GroupBox3.Location = New System.Drawing.Point(123, 157)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(340, 53)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Orders"
        '
        'btnViewOrders
        '
        Me.btnViewOrders.Location = New System.Drawing.Point(177, 19)
        Me.btnViewOrders.Name = "btnViewOrders"
        Me.btnViewOrders.Size = New System.Drawing.Size(136, 23)
        Me.btnViewOrders.TabIndex = 29
        Me.btnViewOrders.Text = "View/Update Orders"
        Me.btnViewOrders.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnInventoryManagement)
        Me.GroupBox4.Location = New System.Drawing.Point(123, 216)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(340, 53)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Inventory"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnPreviousInvoices)
        Me.GroupBox5.Controls.Add(Me.btnInvoicing)
        Me.GroupBox5.Location = New System.Drawing.Point(123, 281)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(340, 53)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Invoicing"
        '
        'btnPreviousInvoices
        '
        Me.btnPreviousInvoices.Location = New System.Drawing.Point(177, 19)
        Me.btnPreviousInvoices.Name = "btnPreviousInvoices"
        Me.btnPreviousInvoices.Size = New System.Drawing.Size(136, 23)
        Me.btnPreviousInvoices.TabIndex = 9
        Me.btnPreviousInvoices.Text = "View Previous Invoices"
        Me.btnPreviousInvoices.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnViewFinances)
        Me.GroupBox6.Controls.Add(Me.btnEditFinances)
        Me.GroupBox6.Location = New System.Drawing.Point(123, 340)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(340, 53)
        Me.GroupBox6.TabIndex = 19
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Financial"
        '
        'btnViewFinances
        '
        Me.btnViewFinances.Location = New System.Drawing.Point(177, 19)
        Me.btnViewFinances.Name = "btnViewFinances"
        Me.btnViewFinances.Size = New System.Drawing.Size(136, 23)
        Me.btnViewFinances.TabIndex = 9
        Me.btnViewFinances.Text = "View Finances"
        Me.btnViewFinances.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnEditJobRecords)
        Me.GroupBox7.Location = New System.Drawing.Point(123, 399)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(340, 53)
        Me.GroupBox7.TabIndex = 19
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Jobs"
        '
        'btnEditJobRecords
        '
        Me.btnEditJobRecords.Location = New System.Drawing.Point(94, 19)
        Me.btnEditJobRecords.Name = "btnEditJobRecords"
        Me.btnEditJobRecords.Size = New System.Drawing.Size(136, 23)
        Me.btnEditJobRecords.TabIndex = 11
        Me.btnEditJobRecords.Text = "View/Edit Job Records"
        Me.btnEditJobRecords.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(137, 467)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(136, 23)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 520)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCustomerReviews)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOptions"
        Me.Text = "  Duvall Pool and Leak Detection"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCustomerIntake As Button
    Friend WithEvents btnPartsOrdering As Button
    Friend WithEvents btnDispatchOrders As Button
    Friend WithEvents btnInvoicing As Button
    Friend WithEvents btnInventoryManagement As Button
    Friend WithEvents btnEditFinances As Button
    Friend WithEvents btnCustomerReviews As Button
    Friend WithEvents btnViewPreviousCustomer As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPreviousPartsOrders As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnViewOrders As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnPreviousInvoices As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnViewFinances As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btnEditJobRecords As Button
    Friend WithEvents btnClose As Button
End Class
