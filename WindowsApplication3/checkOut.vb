Public Class checkOut

    Private Sub checkOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = Date.Today.ToString("yyyy-MM-dd")
        txtOrderTime.Text = Format(Now, "hh:mm:ss")

        Dim total As Double
        For Each Str As String In basket.lstPrice.Items
            total = total + CDbl(Str)
        Next

        txtSubTotal.Text = ("£" & total)

        Dim tax As Double = 1.2

        txtTax.Text = ("%" & tax)

        txtTotal.Text = ("£" & tax * total)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        shopStep3.Show()
        Me.Close()
    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        shop.Show()
        shopStep1.Close()
        shopStep2.Close()
        shopStep3.Close()
        basket.Close()
        Me.Close()
    End Sub

    Private Sub btnBackBasket_Click(sender As Object, e As EventArgs) Handles btnBackBasket.Click
        basket.Show()
        Me.Close()
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        receipt.Show()
        Me.Close()
    End Sub
End Class