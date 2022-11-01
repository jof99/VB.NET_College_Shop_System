Imports System.Data.OleDb
Imports System.Data
Imports System.Text.RegularExpressions
Public Class newAccount

    Function EmailCheck(ByVal emailAddress As String) As Boolean

        Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)

        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If

    End Function


    Dim LoginAdapter As New SystemDatasetTableAdapters.LoginTableAdapter
    Dim LoginTable As SystemDataset.LoginDataTable

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Dim MyEmail As String = txtEmail.Text

        If txtEmail.Text = "" Or passWord.Text = "" Or passWord2.Text = "" Then
            MsgBox("Please Fill In All Information")

        ElseIf passWord.Text <> passWord2.Text Then
            MsgBox("Passwords Do Not Match")
        ElseIf EmailCheck(MyEmail) = False Then
            MsgBox("Invalid Email")
            txtEmail.Focus()
        ElseIf (cmbQuestion.SelectedIndex = -1) Then
            MsgBox("Please Enter A Security Question")
        ElseIf txtAnswer.Text = "" Then
            MsgBox("Please Enter A Memorable Answer")
        Else
            Try
                LoginAdapter.InsertUser(txtEmail.Text, passWord.Text, cmbQuestion.Text, txtAnswer.Text)
                MsgBox("Create Success")
                Me.Close()
            Catch ex As Exception
                MsgBox("Error")
            End Try

        End If
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        loginForm.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        loginForm.Show()
        Me.Hide()
    End Sub

End Class