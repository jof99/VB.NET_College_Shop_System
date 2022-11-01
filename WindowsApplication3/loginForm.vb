Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class loginForm

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



                If chkIsStaff.Checked = True Then
                    If LoginTable.Count <> 0 Then

                        If InputBox("Please Enter The Unique Staff Code") = "123" Then
                            adminView.Show()
                            Me.Hide()
                            If (pword = LoginTable.Rows(0).Item(1).ToString) Then

                                MsgBox("Admin Mode Enabled")
                                adminView.Show()
                                If adminView.Visible = True Then
                                    Me.Hide()
                                End If
                            End If
                        Else MsgBox("Incorrect code")

                        End If
                    End If
                ElseIf (pword = LoginTable.Rows(0).Item(2).ToString) Then



                    MsgBox("Login success")
                    shop.Show()
                    If shop.Visible = True Then
                        Me.txtPass.Clear()
                        Me.txtEmail.Clear()
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

        newAccount.Show()
        If newAccount.Visible Then
            Me.Hide()
        End If

    End Sub

    Private Sub btnForgot_Click(sender As Object, e As EventArgs) Handles btnForgot.Click
        forgotPass.Show()
        Me.Hide()

    End Sub

End Class

