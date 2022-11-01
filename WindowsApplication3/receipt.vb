Public Class receipt

    Dim orderAdapter As New SystemDatasetTableAdapters.OrderTableAdapter
    Dim orderTable As SystemDataset.OrderDataTable

    Dim orderItemsAdapter As New SystemDatasetTableAdapters.OrderItemsTableAdapter
    Dim orderItemsTable As SystemDataset.OrderItemsDataTable
    Private Sub receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtReceipt.AppendText("=============================================" + vbNewLine)
        txtReceipt.AppendText(" " + vbNewLine)
        txtReceipt.AppendText("STATION GRILL SHOPPING SYSTEM")
        txtReceipt.AppendText(" " + vbNewLine)
        txtReceipt.AppendText("=============================================" + vbNewLine)
        txtReceipt.AppendText(vbNewLine)
        txtReceipt.AppendText("Name:" + vbTab & shopStep1.txtName.Text + vbNewLine)
        txtReceipt.AppendText("Phone No:" + vbTab & shopStep1.txtPhoneNumber.Text + vbNewLine)
        txtReceipt.AppendText("Order_Date:" + vbTab & checkOut.txtDate.Text + vbNewLine)
        txtReceipt.AppendText("Order_Time: " + vbTab & checkOut.txtOrderTime.Text + vbNewLine)
        txtReceipt.AppendText("Payment_Type:" + vbTab & shopStep1.cmbPaymentType.Text + vbNewLine)
        txtReceipt.AppendText(" " + vbNewLine)
        txtReceipt.AppendText("Order Sub Total: " + vbTab & checkOut.txtSubTotal.Text + vbNewLine)
        txtReceipt.AppendText("Tax on Order: " + vbTab & checkOut.txtTax.Text + vbNewLine)
        txtReceipt.AppendText("Total : " + vbTab & checkOut.txtTotal.Text + vbNewLine)
        txtReceipt.AppendText("=============================================" + vbNewLine)
        txtReceipt.AppendText(" " + vbNewLine)
        txtReceipt.AppendText("STATION GRILL SHOPPING RECEIPT")
        txtReceipt.AppendText(" " + vbNewLine)
        txtReceipt.AppendText("=============================================" + vbNewLine)
        txtReceipt.AppendText(" " + vbNewLine)

        orderAdapter.InsertQuery(shopStep1.txtName.Text, shopStep3.txtNoteToChef.Text, shopStep1.txtPhoneNumber.Text, checkOut.txtDate.Text, checkOut.txtOrderTime.Text, checkOut.txtTotal.Text)
        orderTable = orderAdapter.getLatestOrder
        Dim currentOrder, counter As Integer
        currentOrder = orderTable.Rows(0).Item(0)
        For Each row In lstItem.Items
            Dim myquant, myproduct As Integer

            myquant = Mid(row.ToString, 1, row.ToString.IndexOf("x"))
            myproduct = lstID.Items.Item(counter)
            orderItemsAdapter.InsertQuery(currentOrder, myproduct, myquant)
            counter += 1
        Next

        Dim noChefNote As String = "No Note Was Left For Chef :3"

        If shopStep3.txtNoteToChef.Text = "" Then
            txtReceipt.AppendText("NOTE SENT TO CHEF:")
            txtReceipt.AppendText(" " + vbNewLine)
            txtReceipt.AppendText(noChefNote + vbNewLine)

        Else
            txtReceipt.AppendText("NOTE SENT TO CHEF:")
            txtReceipt.AppendText(" " + vbNewLine)
            txtReceipt.AppendText(shopStep3.txtNoteToChef.Text + vbNewLine)
        End If


        txtReceipt.AppendText(" " + vbNewLine)
        txtReceipt.AppendText("TIME YOU COLLECT:")
        txtReceipt.AppendText(" " + vbNewLine)
        txtReceipt.AppendText(shopStep3.tmeOfCollection.Text + vbNewLine)
        txtReceipt.AppendText(" " + vbNewLine)
        txtReceipt.AppendText("ORDER ID (Show To Cook):" + vbTab & checkOut.txtOrderID.Text + vbNewLine)
        txtReceipt.AppendText(" " + vbNewLine)


    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        shop.Show()
        Me.Close()

    End Sub
End Class