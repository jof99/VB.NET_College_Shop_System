Public Class shopStep3
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        basket.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click

        Dim noteToChef As String = txtNoteToChef.Text
        Dim collectionDate As String = tmeOfCollection.Text
        checkOut.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        shop.Show()
        shopStep1.Close()
        basket.Close()
        checkOut.Close()
        Me.Close()
    End Sub
End Class