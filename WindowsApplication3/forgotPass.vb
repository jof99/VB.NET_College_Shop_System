Public Class forgotPass
    Dim LoginAdapter As New SystemDatasetTableAdapters.LoginTableAdapter
    Dim LoginTable As SystemDataset.LoginDataTable
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        LoginTable = LoginAdapter.GetUsers(txtEmail.Text)
        Dim secure As String = InputBox(LoginTable.Rows(0).Item(2).ToString)

        If LoginTable.Count > 0 Then
            If secure = Trim(LoginTable.Rows(0).Item(3).ToString) Then
                'MsgBox("Your password is: " & Trim(LoginTable.Rows(0).Item(1)))

            Else
                MsgBox("youre wrong fam")
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        loginForm.Show()
        Me.Close()
    End Sub
End Class