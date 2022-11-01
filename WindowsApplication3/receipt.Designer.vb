<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class receipt
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
        Me.txtReceipt = New System.Windows.Forms.TextBox()
        Me.lstItem = New System.Windows.Forms.ListBox()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lstID = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtReceipt
        '
        Me.txtReceipt.Enabled = False
        Me.txtReceipt.Location = New System.Drawing.Point(12, 12)
        Me.txtReceipt.Multiline = True
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.Size = New System.Drawing.Size(304, 381)
        Me.txtReceipt.TabIndex = 0
        '
        'lstItem
        '
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.Location = New System.Drawing.Point(322, 12)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(210, 381)
        Me.lstItem.TabIndex = 4
        '
        'lstPrice
        '
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.Location = New System.Drawing.Point(538, 12)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(57, 381)
        Me.lstPrice.TabIndex = 5
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(12, 410)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(583, 23)
        Me.btnHome.TabIndex = 6
        Me.btnHome.Text = "Back To Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'lstID
        '
        Me.lstID.FormattingEnabled = True
        Me.lstID.Location = New System.Drawing.Point(557, 461)
        Me.lstID.Name = "lstID"
        Me.lstID.Size = New System.Drawing.Size(38, 17)
        Me.lstID.TabIndex = 8
        Me.lstID.Visible = False
        '
        'receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 490)
        Me.Controls.Add(Me.lstID)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lstItem)
        Me.Controls.Add(Me.txtReceipt)
        Me.Name = "receipt"
        Me.Text = "reciept"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtReceipt As TextBox
    Friend WithEvents lstItem As ListBox
    Friend WithEvents lstPrice As ListBox
    Friend WithEvents btnHome As Button
    Friend WithEvents lstID As ListBox
End Class
