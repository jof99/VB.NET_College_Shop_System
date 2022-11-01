Public Class adminView

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        loginForm.Show()
        Me.Hide()

        loginForm.txtPass.Clear()
        loginForm.txtEmail.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEditMenu.Click
        editMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewSales_Click(sender As Object, e As EventArgs)
        salesAnalytics.Show()
        Me.Hide()
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        emailAlerts.Show()
        Me.Hide()
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        pendingOrders.Show()
        Me.Hide()
    End Sub

End Class