Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class Form1

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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginBtn.Click

        Dim MyEmail As String = txtEmail.Text
        If EmailCheck(MyEmail) = False Then
            MsgBox("Invalid Email Or Password!")

            Exit Sub
        End If

        Dim uname As String = ""
        Dim pword As String



        If Me.txtEmail.Text = "" Or txtPass.Text = "" Then
            MsgBox("Fill in all information")
        Else
            uname = Me.txtEmail.Text
            pword = txtPass.Text
            LoginTable = LoginAdapter.GetUsers(uname)
            If LoginTable.Count <> 0 Then

                If txtEmail.Text = "joel.fraser@hotmail.co.uk" Then
                    If LoginTable.Count <> 0 Then
                        If (pword = LoginTable.Rows(0).Item(1).ToString) Then
                            MsgBox("Admin Mode Enabled")
                            Form4.Show()
                            If Form4.Visible = True Then
                                Me.Hide()
                            End If
                        End If
                    End If

                ElseIf (pword = LoginTable.Rows(0).Item(1).ToString) Then
                    MsgBox("Login success")
                    Form2.Show()
                    If Form2.Visible = True Then
                        Me.Hide()
                    End If
                End If
            Else
                MsgBox("Login Failed")
                Me.txtEmail.Clear()
                txtPass.Clear()
            End If
        End If



    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles NewBtn.Click

        Form3.Show()
        If Form3.Visible Then
            Me.Hide()
        End If

    End Sub

    Private Sub lblForgot_MouseHover(sender As Object, e As EventArgs) Handles lblForgot.MouseHover
        lblForgot.ForeColor = Color.Blue
    End Sub

    Private Sub lblForgot_MouseLeave(sender As Object, e As EventArgs) Handles lblForgot.MouseLeave
        lblForgot.ForeColor = Color.Black
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblForgot_Click(sender As Object, e As EventArgs) Handles lblForgot.Click

    End Sub
End Class

