Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Hide()

        Form1.txtPass.Clear()
        Form1.txtEmail.Clear()

    End Sub

End Class