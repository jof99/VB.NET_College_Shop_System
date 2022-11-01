Public Class shop
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        shopStep1.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        loginForm.Show()
        Me.Close()
    End Sub
End Class