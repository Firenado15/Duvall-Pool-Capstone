<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddFinances
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddFinances))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblOutstandingRevenue = New System.Windows.Forms.Label()
        Me.lblPaidRevenue = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.txtUtilities = New System.Windows.Forms.TextBox()
        Me.txtRent = New System.Windows.Forms.TextBox()
        Me.txtFuel = New System.Windows.Forms.TextBox()
        Me.txtVehicle = New System.Windows.Forms.TextBox()
        Me.txtProject = New System.Windows.Forms.TextBox()
        Me.txtInsurance = New System.Windows.Forms.TextBox()
        Me.txtPayroll = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnEditFinances = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblInventoryCost = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(74, 570)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(109, 44)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblOutstandingRevenue)
        Me.GroupBox3.Controls.Add(Me.lblPaidRevenue)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label55)
        Me.GroupBox3.Location = New System.Drawing.Point(55, 458)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(444, 86)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Revenue for Month"
        '
        'lblOutstandingRevenue
        '
        Me.lblOutstandingRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutstandingRevenue.Location = New System.Drawing.Point(175, 51)
        Me.lblOutstandingRevenue.Name = "lblOutstandingRevenue"
        Me.lblOutstandingRevenue.Size = New System.Drawing.Size(244, 23)
        Me.lblOutstandingRevenue.TabIndex = 47
        '
        'lblPaidRevenue
        '
        Me.lblPaidRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPaidRevenue.Location = New System.Drawing.Point(175, 18)
        Me.lblPaidRevenue.Name = "lblPaidRevenue"
        Me.lblPaidRevenue.Size = New System.Drawing.Size(244, 23)
        Me.lblPaidRevenue.TabIndex = 47
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(16, 24)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(124, 17)
        Me.Label55.TabIndex = 6
        Me.Label55.Text = "Total Amount Paid"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(179, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 17)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Add finances for next month"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtOther)
        Me.GroupBox2.Controls.Add(Me.lblInventoryCost)
        Me.GroupBox2.Controls.Add(Me.txtUtilities)
        Me.GroupBox2.Controls.Add(Me.txtRent)
        Me.GroupBox2.Controls.Add(Me.txtFuel)
        Me.GroupBox2.Controls.Add(Me.txtVehicle)
        Me.GroupBox2.Controls.Add(Me.txtProject)
        Me.GroupBox2.Controls.Add(Me.txtInsurance)
        Me.GroupBox2.Controls.Add(Me.txtPayroll)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(55, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 379)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Expenses for Month"
        '
        'txtOther
        '
        Me.txtOther.Location = New System.Drawing.Point(175, 344)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(244, 20)
        Me.txtOther.TabIndex = 8
        '
        'txtUtilities
        '
        Me.txtUtilities.Location = New System.Drawing.Point(175, 300)
        Me.txtUtilities.Name = "txtUtilities"
        Me.txtUtilities.Size = New System.Drawing.Size(244, 20)
        Me.txtUtilities.TabIndex = 7
        '
        'txtRent
        '
        Me.txtRent.Location = New System.Drawing.Point(175, 260)
        Me.txtRent.Name = "txtRent"
        Me.txtRent.Size = New System.Drawing.Size(244, 20)
        Me.txtRent.TabIndex = 6
        '
        'txtFuel
        '
        Me.txtFuel.Location = New System.Drawing.Point(175, 216)
        Me.txtFuel.Name = "txtFuel"
        Me.txtFuel.Size = New System.Drawing.Size(244, 20)
        Me.txtFuel.TabIndex = 5
        '
        'txtVehicle
        '
        Me.txtVehicle.Location = New System.Drawing.Point(175, 173)
        Me.txtVehicle.Name = "txtVehicle"
        Me.txtVehicle.Size = New System.Drawing.Size(244, 20)
        Me.txtVehicle.TabIndex = 4
        '
        'txtProject
        '
        Me.txtProject.Location = New System.Drawing.Point(175, 137)
        Me.txtProject.Name = "txtProject"
        Me.txtProject.Size = New System.Drawing.Size(244, 20)
        Me.txtProject.TabIndex = 3
        '
        'txtInsurance
        '
        Me.txtInsurance.Location = New System.Drawing.Point(175, 98)
        Me.txtInsurance.Name = "txtInsurance"
        Me.txtInsurance.Size = New System.Drawing.Size(244, 20)
        Me.txtInsurance.TabIndex = 2
        '
        'txtPayroll
        '
        Me.txtPayroll.Location = New System.Drawing.Point(175, 15)
        Me.txtPayroll.Name = "txtPayroll"
        Me.txtPayroll.Size = New System.Drawing.Size(244, 20)
        Me.txtPayroll.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Other"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Utilities"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Shop Rent"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Fuel"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Vehicle Maintenance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Project Costs"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Insurance"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Inventory"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 17)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Payroll"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(365, 570)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(109, 44)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnEditFinances
        '
        Me.btnEditFinances.Location = New System.Drawing.Point(230, 570)
        Me.btnEditFinances.Name = "btnEditFinances"
        Me.btnEditFinances.Size = New System.Drawing.Size(109, 44)
        Me.btnEditFinances.TabIndex = 4
        Me.btnEditFinances.Text = "Edit Existing Finances"
        Me.btnEditFinances.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 17)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Outstanding"
        '
        'lblInventoryCost
        '
        Me.lblInventoryCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInventoryCost.Location = New System.Drawing.Point(175, 60)
        Me.lblInventoryCost.Name = "lblInventoryCost"
        Me.lblInventoryCost.Size = New System.Drawing.Size(244, 23)
        Me.lblInventoryCost.TabIndex = 47
        '
        'frmAddFinances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 626)
        Me.Controls.Add(Me.btnEditFinances)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddFinances"
        Me.Text = "Add finances for current month"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label55 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtOther As TextBox
    Friend WithEvents txtUtilities As TextBox
    Friend WithEvents txtRent As TextBox
    Friend WithEvents txtFuel As TextBox
    Friend WithEvents txtVehicle As TextBox
    Friend WithEvents txtProject As TextBox
    Friend WithEvents txtInsurance As TextBox
    Friend WithEvents txtPayroll As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnEditFinances As Button
    Friend WithEvents lblOutstandingRevenue As Label
    Friend WithEvents lblPaidRevenue As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblInventoryCost As Label
End Class
