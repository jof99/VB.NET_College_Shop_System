<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class emailAlerts
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
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(12, 81)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(369, 168)
        Me.txtMessage.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(61, 48)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(320, 20)
        Me.TextBox4.TabIndex = 5
        '
        'txtSubject
        '
        Me.txtSubject.AutoSize = True
        Me.txtSubject.Location = New System.Drawing.Point(9, 51)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(46, 13)
        Me.txtSubject.TabIndex = 6
        Me.txtSubject.Text = "Subject:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(61, 22)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(320, 20)
        Me.txtEmail.TabIndex = 7
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(9, 22)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(35, 13)
        Me.Email.TabIndex = 8
        Me.Email.Text = "Email:"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(12, 256)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(369, 41)
        Me.btnSend.TabIndex = 9
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 303)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(369, 41)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'emailAlerts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 350)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.txtMessage)
        Me.Name = "emailAlerts"
        Me.Text = "emails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtSubject As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Email As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents btnBack As Button
End Class
