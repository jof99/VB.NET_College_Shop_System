Public Class shopStep2

    Dim itemsAdapter As New SystemDatasetTableAdapters.itemsTableAdapter
    Dim itemTable As SystemDataset.itemsDataTable

    Private Sub btnRefresh_Click_1(sender As Object, e As EventArgs) Handles btnRefresh.Click

        dgvMenu.DataSource = itemsAdapter.GetData

    End Sub

    Private Sub dgvMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellContentClick
        Dim row As DataGridViewRow
        row = Me.dgvMenu.Rows(e.RowIndex)

        Dim myQuantity As Integer



        Try
            myQuantity = InputBox("Please Enter Quantity")
            If myQuantity < 1 Then
                MsgBox("Quantity Must Be Greater Than 1")
            Else
                basket.lstPrice.Items.Add("£" & row.Cells(1).Value.ToString * myQuantity)
                basket.lstItem.Items.Add(myQuantity & " x " & row.Cells(2).Value.ToString)
                receipt.lstItem.Items.Add(myQuantity & " x " & row.Cells(2).Value.ToString)
                receipt.lstID.Items.Add(row.Cells(0).Value.ToString)
                receipt.lstPrice.Items.Add("£" & row.Cells(1).Value.ToString * myQuantity)
                MsgBox(myQuantity & " " & row.Cells(2).Value.ToString().Trim & " Added To Basket!")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        shop.Show()
        shopStep1.Close()
        shopStep3.Close()
        basket.Close()
        checkOut.Close()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        shopStep1.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs)
        checkOut.Show()
        Me.Hide()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        itemTable = itemsAdapter.getItem(txtSearch.Text)
        If itemTable.Count <> 0 Then
            MsgBox("Found!")
            dgvMenu.DataSource = itemTable
        Else
            MsgBox("Item Not Found")
        End If
    End Sub

    Private Sub btnBasket_Click(sender As Object, e As EventArgs) Handles btnBasket.Click
        basket.updateTotal()
        basket.Show()
        Me.Hide()
    End Sub
End Class

