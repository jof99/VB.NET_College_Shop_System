<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pendingOrders
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
        Me.dgvPendingOrders = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvPendingOrders2 = New System.Windows.Forms.DataGridView()
        Me.dgvMenu = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtIDSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnComplete = New System.Windows.Forms.Button()
        CType(Me.dgvPendingOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPendingOrders2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPendingOrders
        '
        Me.dgvPendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPendingOrders.Location = New System.Drawing.Point(7, 68)
        Me.dgvPendingOrders.Name = "dgvPendingOrders"
        Me.dgvPendingOrders.Size = New System.Drawing.Size(500, 435)
        Me.dgvPendingOrders.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(7, 566)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(1514, 49)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvPendingOrders2
        '
        Me.dgvPendingOrders2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPendingOrders2.Location = New System.Drawing.Point(514, 68)
        Me.dgvPendingOrders2.Name = "dgvPendingOrders2"
        Me.dgvPendingOrders2.Size = New System.Drawing.Size(501, 435)
        Me.dgvPendingOrders2.TabIndex = 3
        '
        'dgvMenu
        '
        Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenu.Location = New System.Drawing.Point(1021, 67)
        Me.dgvMenu.Name = "dgvMenu"
        Me.dgvMenu.Size = New System.Drawing.Size(501, 436)
        Me.dgvMenu.TabIndex = 4
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(7, 621)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(1515, 49)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Order Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(511, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Order Items"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1018, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Item Menu"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(1341, 34)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtIDSearch
        '
        Me.txtIDSearch.Location = New System.Drawing.Point(1422, 36)
        Me.txtIDSearch.Name = "txtIDSearch"
        Me.txtIDSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtIDSearch.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1419, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Search Items By ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(188, 527)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(164, 530)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ID"
        '
        'btnComplete
        '
        Me.btnComplete.Location = New System.Drawing.Point(295, 527)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(111, 23)
        Me.btnComplete.TabIndex = 14
        Me.btnComplete.Text = "Order Complete"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'pendingOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1542, 682)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIDSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvMenu)
        Me.Controls.Add(Me.dgvPendingOrders2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvPendingOrders)
        Me.Name = "pendingOrders"
        Me.Text = "pendingOrders"
        CType(Me.dgvPendingOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPendingOrders2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPendingOrders As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvPendingOrders2 As DataGridView
    Friend WithEvents dgvMenu As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtIDSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnComplete As Button
End Class
