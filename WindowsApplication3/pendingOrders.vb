Public Class pendingOrders

    Dim orderAdapter As New SystemDatasetTableAdapters.OrderTableAdapter
    Dim orderTable As SystemDataset.OrderDataTable

    Dim orderItemsAdapter As New SystemDatasetTableAdapters.OrderItemsTableAdapter
    Dim orderItemsTable As SystemDataset.OrderItemsDataTable

    Dim itemsAdapter As New SystemDatasetTableAdapters.itemsTableAdapter
    Dim itemTable As SystemDataset.itemsDataTable
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        dgvPendingOrders.DataSource = orderAdapter.GetData
        dgvPendingOrders2.DataSource = orderItemsAdapter.GetData
        dgvMenu.DataSource = itemsAdapter.GetData
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)

        adminView.Show()
        Me.Hide()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        itemTable = itemsAdapter.getItem(txtIDSearch.Text)
        If itemTable.Count <> 0 Then
            MsgBox("Found!")
            dgvMenu.DataSource = itemTable
        Else
            MsgBox("Item Not Found")
        End If
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        adminView.Show()
        Me.Hide()
    End Sub


    Private Sub dgvPendingOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPendingOrders.CellContentClick

        Dim row As DataGridViewRow
        row = Me.dgvPendingOrders.Rows(e.RowIndex)

        txtID.Text = row.Cells(0).Value.ToString


    End Sub
    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click

        orderAdapter.deleteItemQuery(txtID.Text)
        orderItemsAdapter.DeleteQuery(txtID.Text)

        MsgBox("Order Completed!")

        dgvPendingOrders.DataSource = orderAdapter.GetData
        dgvPendingOrders2.DataSource = orderItemsAdapter.GetData
    End Sub

End Class