Imports System.Text.RegularExpressions
Public Class shopStep1

    Function mobileNumberCheck(ByVal emailAddress As String) As Boolean

        Dim pattern As String = "^(\+44\s?7\d{3}|\(?07\d{3}\)?)\s?\d{3}\s?\d{3}$"
        Dim mobileNumberMatch As Match = Regex.Match(emailAddress, pattern)

        If mobileNumberMatch.Success Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Dim phoneNumber As String = txtPhoneNumber.Text
        If txtName.Text = "" And txtPhoneNumber.Text = "" And (cmbPaymentType.SelectedIndex = -1) Then
            MsgBox("All Fields Cannot Be Blank")
        ElseIf txtName.Text = "" Then
            MsgBox("You Must Enter A Name")
        ElseIf txtName.Text.Count >= 20 Then
            MsgBox("Name Too Long For System, Please Enter A Nickname")
        ElseIf txtPhoneNumber.Text = "" Then
            MsgBox("You Must Enter A Phone Number")
        ElseIf mobileNumberCheck(phoneNumber) = False Then
            MsgBox("Invalid Mobile Number")
            txtPhoneNumber.Focus()
        ElseIf (cmbPaymentType.SelectedIndex = -1) Then
            MsgBox("Please Select A Method Of Payment")

        Else
            Try
                shopStep2.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox("Error 404")
            End Try
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        shop.Show()
        shopStep2.Close()
        shopStep3.Close()
        basket.Close()
        checkOut.Close()
        Me.Close()
    End Sub
End Class

