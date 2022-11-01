Public Class basket

    Private Sub basket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim total As Double
        For Each Str As String In lstPrice.Items
            total = total + CDbl(Str)
        Next

        txtTotal.Text = ("£" & total)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        shopStep2.Show()
        Me.Hide()
    End Sub


    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click

        Try
            Dim index As Integer = lstItem.SelectedIndex
            lstItem.Items.RemoveAt(index)
            lstPrice.Items.RemoveAt(index)
            receipt.lstItem.Items.RemoveAt(index)
            receipt.lstPrice.Items.RemoveAt(index)
        Catch ex As Exception

        End Try

        Dim total As Double

        For Each Str As String In lstPrice.Items
            total = total + CDbl(Str)
        Next

        txtTotal.Text = ("£" & total)

    End Sub

    Private Sub btnItemsClear_Click(sender As Object, e As EventArgs) Handles btnItemsClear.Click
        lstItem.Items.Clear()
        lstPrice.Items.Clear()
        receipt.lstItem.Items.Clear()
        receipt.lstPrice.Items.Clear()
        txtTotal.Text = ("Basket Empty")
        MsgBox("All Items Cleared From Basket")
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click



        If lstItem.Items.Count < 1 Then
            MsgBox("You Must Select 1 Or More Items From The Menu To Proceed")
        Else
            Try
                shopStep3.Show()
                Me.Hide()
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        shop.Show()
        shopStep1.Close()
        shopStep2.Close()
        shopStep3.Close()
        checkOut.Close()
        Me.Close()
    End Sub

    Public Sub updateTotal()
        Dim total As Double
        For Each Str As String In lstPrice.Items
            total = total + CDbl(Str)
        Next

        txtTotal.Text = ("£" & total)
    End Sub
End Class