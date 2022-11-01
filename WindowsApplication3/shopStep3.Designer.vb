<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shopStep3
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tmeOfCollection = New System.Windows.Forms.DateTimePicker()
        Me.txtNoteToChef = New System.Windows.Forms.TextBox()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnBack)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.btnCheckOut)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.tmeOfCollection)
        Me.GroupBox3.Controls.Add(Me.txtNoteToChef)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(317, 384)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Additional Information"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(6, 267)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(305, 50)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(209, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "When Do You Want To Collect Your Order"
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Location = New System.Drawing.Point(6, 211)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(305, 50)
        Me.btnCheckOut.TabIndex = 25
        Me.btnCheckOut.Text = "Check Out"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Notes To Chef"
        '
        'tmeOfCollection
        '
        Me.tmeOfCollection.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.tmeOfCollection.Location = New System.Drawing.Point(6, 185)
        Me.tmeOfCollection.Name = "tmeOfCollection"
        Me.tmeOfCollection.ShowUpDown = True
        Me.tmeOfCollection.Size = New System.Drawing.Size(305, 20)
        Me.tmeOfCollection.TabIndex = 1
        '
        'txtNoteToChef
        '
        Me.txtNoteToChef.Location = New System.Drawing.Point(6, 55)
        Me.txtNoteToChef.Multiline = True
        Me.txtNoteToChef.Name = "txtNoteToChef"
        Me.txtNoteToChef.Size = New System.Drawing.Size(305, 98)
        Me.txtNoteToChef.TabIndex = 0
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Location = New System.Drawing.Point(18, 335)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(305, 50)
        Me.btnCancelOrder.TabIndex = 27
        Me.btnCancelOrder.Text = "Cancel Order"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'shopStep3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 398)
        Me.Controls.Add(Me.btnCancelOrder)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "shopStep3"
        Me.Text = "shopStep2"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tmeOfCollection As DateTimePicker
    Friend WithEvents txtNoteToChef As TextBox
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCancelOrder As Button
End Class
