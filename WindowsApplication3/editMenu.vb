Public Class editMenu

    Dim itemsAdapter As New SystemDatasetTableAdapters.itemsTableAdapter
    Dim itemTable As SystemDataset.itemsDataTable
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtName.Text = "" Then
            MsgBox("Please Ensure All Boxes Are Filled In")
        ElseIf IsNumeric(txtPrice.Text) = False Then
            MsgBox("Price Must Not Contain Letters")
        ElseIf IsNumeric(txtCal.Text) = False Then
            MsgBox("Calories Must Be A Whole Integer")
        Else
            Try
            itemsAdapter.QueryInsert(txtPrice.Text, txtName.Text, chkVeg.Checked, txtCal.Text)
            MsgBox("Item Added")
            dgvIList.DataSource = itemsAdapter.GetData

            txtName.Clear()
            txtPrice.Clear()
            chkVeg.Checked = False
            txtCal.Clear()



        Catch ex As Exception
            MsgBox("Error")
        End Try

        End If




    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            itemsAdapter.UpdateItemQuery(txtPrice.Text, txtName.Text, chkVeg.Checked, txtCal.Text, txtID.Text)
            dgvIList.DataSource = itemsAdapter.GetData
            MsgBox("Item Edited")
        Catch
            MsgBox("Error")
        End Try
    End Sub



    Private Sub dgvIList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvIList.CellContentClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow
            row = Me.dgvIList.Rows(e.RowIndex)

            txtID.Text = row.Cells(0).Value.ToString
            txtPrice.Text = row.Cells(1).Value.ToString
            txtName.Text = row.Cells(2).Value.ToString

            If row.Cells(3).Value = True Then
                chkVeg.Checked = True
            Else
                chkVeg.Checked = False
            End If

            txtCal.Text = row.Cells(4).Value.ToString


        End If

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        adminView.Show()
        Me.Hide()

    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        itemTable = itemsAdapter.getID(txtID.Text)

        itemsAdapter.queryDelete(txtID.Text)
        MsgBox("Item Deleted")
        dgvIList.DataSource = itemsAdapter.GetData

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        itemTable = itemsAdapter.getItem(txtSearch.Text)
        If itemTable.Count <> 0 Then
            MsgBox("Found!")
            dgvIList.DataSource = itemTable
        Else
            MsgBox("Item Not Found")
        End If
    End Sub

    Dim operation As String
    Dim firstNum As Double
    Dim secondNum As Double
    Dim result As Double


    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click
        Dim button As Button = sender
        If lblScreen.Text = "0" Then
            lblScreen.Text = button.Text
        Else
            lblScreen.Text = lblScreen.Text + button.Text
        End If
    End Sub

    Private Sub arithmetic_operations(sender As Object, e As EventArgs) Handles TabPage1.Click, btnPlus.Click, btnMultiply.Click, btnMinus.Click, btnDivide.Click
        Dim operations As Button = sender
        firstNum = lblScreen.Text
        lblCalcShow.Text = lblScreen.Text
        lblScreen.Text = ""
        operation = operations.Text
        lblCalcShow.Text = lblCalcShow.Text + " " + operation
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblScreen.Text = "0"
        lblCalcShow.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If lblScreen.Text.Length > 0 Then
            lblScreen.Text = lblScreen.Text.Remove(lblScreen.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        If InStr(lblScreen.Text, ".") = 0 Then
            lblScreen.Text = lblScreen.Text = "."
        End If
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        secondNum = lblScreen.Text
        If operation = "+" Then
            result = firstNum + secondNum
            lblScreen.Text = result
            lblCalcShow.Text = ""
        ElseIf operation = "-" Then
            result = firstNum - secondNum
            lblScreen.Text = result
            lblCalcShow.Text = ""
        ElseIf operation = "*" Then
            result = firstNum * secondNum
            lblScreen.Text = result
            lblCalcShow.Text = ""
        ElseIf operation = "/" Then
            result = firstNum / secondNum
            lblScreen.Text = result
            lblCalcShow.Text = ""
        End If
    End Sub

    Private Sub lblScreen_TextChanged(sender As Object, e As EventArgs) Handles lblScreen.TextChanged
        If lblScreen.Text = "" Then
            lblScreen.Text = 0
        End If
    End Sub
End Class