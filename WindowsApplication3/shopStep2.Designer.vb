<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class shopStep2
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
        Me.components = New System.ComponentModel.Container()
        Me.gbMenu = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvMenu = New System.Windows.Forms.DataGridView()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ItemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SystemDatasetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SystemDataset = New WindowsApplication3.SystemDataset()
        Me.ItemsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter = New WindowsApplication3.SystemDatasetTableAdapters.itemsTableAdapter()
        Me.ItemsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon2 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon3 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btnBasket = New System.Windows.Forms.Button()
        Me.gbMenu.SuspendLayout()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemDatasetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbMenu
        '
        Me.gbMenu.Controls.Add(Me.btnRefresh)
        Me.gbMenu.Controls.Add(Me.dgvMenu)
        Me.gbMenu.Controls.Add(Me.btnGo)
        Me.gbMenu.Controls.Add(Me.txtSearch)
        Me.gbMenu.Controls.Add(Me.Label7)
        Me.gbMenu.Location = New System.Drawing.Point(12, 12)
        Me.gbMenu.Name = "gbMenu"
        Me.gbMenu.Size = New System.Drawing.Size(574, 262)
        Me.gbMenu.TabIndex = 6
        Me.gbMenu.TabStop = False
        Me.gbMenu.Text = "Store"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(5, 19)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(560, 44)
        Me.btnRefresh.TabIndex = 22
        Me.btnRefresh.Text = "Click To View Menu"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvMenu
        '
        Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenu.Location = New System.Drawing.Point(6, 99)
        Me.dgvMenu.Name = "dgvMenu"
        Me.dgvMenu.Size = New System.Drawing.Size(559, 153)
        Me.dgvMenu.TabIndex = 18
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(492, 71)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(73, 23)
        Me.btnGo.TabIndex = 19
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(73, 73)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(413, 20)
        Me.txtSearch.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Search Menu"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(388, 280)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(189, 44)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "Cancel Order"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(207, 280)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(175, 44)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "Previous Page"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ItemsBindingSource1
        '
        Me.ItemsBindingSource1.DataMember = "items"
        Me.ItemsBindingSource1.DataSource = Me.SystemDatasetBindingSource
        '
        'SystemDatasetBindingSource
        '
        Me.SystemDatasetBindingSource.DataSource = Me.SystemDataset
        Me.SystemDatasetBindingSource.Position = 0
        '
        'SystemDataset
        '
        Me.SystemDataset.DataSetName = "SystemDataset"
        Me.SystemDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsBindingSource3
        '
        Me.ItemsBindingSource3.DataMember = "items"
        Me.ItemsBindingSource3.DataSource = Me.SystemDataset
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "items"
        Me.ItemsBindingSource.DataSource = Me.SystemDatasetBindingSource
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'ItemsBindingSource2
        '
        Me.ItemsBindingSource2.DataMember = "items"
        Me.ItemsBindingSource2.DataSource = Me.SystemDatasetBindingSource
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'NotifyIcon2
        '
        Me.NotifyIcon2.Text = "NotifyIcon2"
        Me.NotifyIcon2.Visible = True
        '
        'NotifyIcon3
        '
        Me.NotifyIcon3.Text = "NotifyIcon3"
        Me.NotifyIcon3.Visible = True
        '
        'btnBasket
        '
        Me.btnBasket.Location = New System.Drawing.Point(18, 280)
        Me.btnBasket.Name = "btnBasket"
        Me.btnBasket.Size = New System.Drawing.Size(183, 44)
        Me.btnBasket.TabIndex = 30
        Me.btnBasket.Text = "My Basket"
        Me.btnBasket.UseVisualStyleBackColor = True
        '
        'shopStep2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 336)
        Me.Controls.Add(Me.btnBasket)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gbMenu)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "shopStep2"
        Me.Text = "shopStep2"
        Me.gbMenu.ResumeLayout(False)
        Me.gbMenu.PerformLayout()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemDatasetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbMenu As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnGo As Button
    Friend WithEvents dgvMenu As DataGridView
    Friend WithEvents SystemDatasetBindingSource As BindingSource
    Friend WithEvents SystemDataset As SystemDataset
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As SystemDatasetTableAdapters.itemsTableAdapter
    Friend WithEvents ItemsBindingSource1 As BindingSource
    Friend WithEvents ItemsBindingSource3 As BindingSource
    Friend WithEvents ItemsBindingSource2 As BindingSource
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents NotifyIcon2 As NotifyIcon
    Friend WithEvents NotifyIcon3 As NotifyIcon
    Friend WithEvents btnBasket As Button
End Class
