<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminView
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnEditMenu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(7, 203)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(242, 55)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnEditMenu
        '
        Me.btnEditMenu.Location = New System.Drawing.Point(6, 80)
        Me.btnEditMenu.Name = "btnEditMenu"
        Me.btnEditMenu.Size = New System.Drawing.Size(242, 55)
        Me.btnEditMenu.TabIndex = 5
        Me.btnEditMenu.Text = "Edit Menu"
        Me.btnEditMenu.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOrders)
        Me.GroupBox1.Controls.Add(Me.btnEmail)
        Me.GroupBox1.Controls.Add(Me.btnLogout)
        Me.GroupBox1.Controls.Add(Me.btnEditMenu)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 267)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Admin View"
        '
        'btnOrders
        '
        Me.btnOrders.Location = New System.Drawing.Point(6, 19)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(242, 55)
        Me.btnOrders.TabIndex = 9
        Me.btnOrders.Text = "Pending Orders"
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnEmail
        '
        Me.btnEmail.Location = New System.Drawing.Point(7, 142)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(242, 55)
        Me.btnEmail.TabIndex = 8
        Me.btnEmail.Text = "Emails"
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'adminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 286)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "adminView"
        Me.Text = "Form4"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents btnEditMenu As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEmail As Button
    Friend WithEvents btnOrders As Button
End Class
