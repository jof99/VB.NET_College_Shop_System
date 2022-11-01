Imports System.Net.Mail
Public Class emailAlerts

    Dim LoginAdapter As New SystemDatasetTableAdapters.LoginTableAdapter
    Dim LoginTable As SystemDataset.LoginDataTable
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        Dim emailSent As Boolean

        For i As Integer = 1 To LoginAdapter.queryScalar()

            Dim email As New MailMessage()

            LoginTable = LoginAdapter.getEmail(i)

            Try
                email.From = New MailAddress("stationgrillonline@gmail.com")
                email.To.Add(Trim(LoginTable.Rows(0).Item(3).ToString))
                email.Subject = txtSubject.Text
                email.Body = txtMessage.Text
                Dim smtp As New SmtpClient("smtp.gmail.com")
                smtp.Port = 587
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential("stationgrillonline@gmail.com", "doublezinger")
                smtp.Send(email)
                emailSent = True


            Catch ex As Exception
                emailSent = False


            End Try
        Next

        If emailSent = False Then
            MsgBox("Email failed to send")
        Else
            MsgBox("Email Sent")
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        adminView.Show()
        Me.Hide()
    End Sub

End Class

