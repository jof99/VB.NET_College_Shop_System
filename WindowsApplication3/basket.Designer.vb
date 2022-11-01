<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class basket
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
        Me.lstItem = New System.Windows.Forms.ListBox()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnItemsClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstItem
        '
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.Location = New System.Drawing.Point(12, 34)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(212, 95)
        Me.lstItem.TabIndex = 0
        '
        'lstPrice
        '
        Me.lstPrice.Enabled = False
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.Location = New System.Drawing.Point(230, 34)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(42, 95)
        Me.lstPrice.TabIndex = 1
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Location = New System.Drawing.Point(12, 162)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(260, 45)
        Me.btnRemoveItem.TabIndex = 2
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 307)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(260, 41)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back To Menu"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnItemsClear
        '
        Me.btnItemsClear.Location = New System.Drawing.Point(12, 213)
        Me.btnItemsClear.Name = "btnItemsClear"
        Me.btnItemsClear.Size = New System.Drawing.Size(260, 41)
        Me.btnItemsClear.TabIndex = 4
        Me.btnItemsClear.Text = "Clear Basket"
        Me.btnItemsClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Price (£)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Items"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(12, 260)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(260, 41)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Location = New System.Drawing.Point(12, 354)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(260, 41)
        Me.btnCancelOrder.TabIndex = 8
        Me.btnCancelOrder.Text = "Cancel Order"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(52, 136)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(220, 20)
        Me.txtTotal.TabIndex = 10
        '
        'basket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 399)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelOrder)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnItemsClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lstItem)
        Me.Name = "basket"
        Me.Text = "basket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstItem As ListBox
    Friend WithEvents lstPrice As ListBox
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnItemsClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotal As TextBox
End Class
