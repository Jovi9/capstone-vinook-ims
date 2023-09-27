Public Class frmSaveOrder

    Dim funcOrder As orderFunction
    Dim modelOrder As orderModel
    Dim modelOrders As ordersModel

    Private Sub getBalance()
        Try
            txtBalance.Value = txtTotalAmountDue.Value - txtAmountReceived.Value
        Catch ex As ArgumentOutOfRangeException
            txtBalance.Value = 0
        End Try
    End Sub

    Private Sub getChange()
        Try
            txtChange.Value = txtAmountReceived.Value - txtTotalAmountDue.Value
        Catch ex As ArgumentOutOfRangeException
            txtChange.Value = 0
        End Try
    End Sub

    Private Sub populateFieldsFromName()
        funcOrder = New orderFunction
        Dim modelCustomer As New customerModel With {
            .name = txtname.Text
        }
        funcOrder.getCustomerDetails(modelCustomer)

        txtCustomerID.Text = modelCustomer.id
        txtname.Text = modelCustomer.name
        txtAddress.Text = modelCustomer.address
        txtPhone.Text = modelCustomer.phone
        txtTINiD.Text = modelCustomer.tin_id
    End Sub

    Private Sub frmSaveOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtAmountReceived.Select()
        dropPaymentType.SelectedIndex = 0
        'txtTotalAmountDue.Controls(0).Visible = False
        'txtBalance.Controls(0).Visible = False
        'txtAmountReceived.Controls(0).Visible = False
        'txtChange.Controls(0).Visible = False
    End Sub

    Private Sub frmSaveOrder_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 Then
            btn_choose_customer.PerformClick()
        End If
        If e.KeyCode = Keys.F10 Then
            btn_save_order.PerformClick()
        End If
        If e.KeyCode = Keys.Escape Then
            btn_cancel.PerformClick()
        End If
        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTotalAmountDue_ValueChanged(sender As Object, e As EventArgs) Handles txtTotalAmountDue.ValueChanged
        getBalance()
        getChange()
    End Sub

    Private Sub txtAmountReceived_ValueChanged(sender As Object, e As EventArgs) Handles txtAmountReceived.ValueChanged
        getBalance()
        getChange()
    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged
        populateFieldsFromName()
    End Sub

    Private Sub btn_save_order_Click(sender As Object, e As EventArgs) Handles btn_save_order.Click
        If txtCustomerID.Text.Trim = "" Or txtname.Text.Trim = "" Then
            customMessageBox.show(Me, "Please enter customer details.", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtAmountReceived.Value = 0 Or txtAmountReceived.Text.Trim = "" Then
            Exit Sub
        Else
            If dropPaymentType.SelectedIndex = 1 And txtChequeNo.Text.Trim = "" Then
                customMessageBox.show(Me, "Please enter cheque number.", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            funcOrder = New orderFunction
            modelOrders = New ordersModel With {
                .transactioncode = txtTransactionCode.Text,
                .invoice = txtInvoiceNo.Text,
                .orderdate = Convert.ToDateTime(frmNewOrder.orderDate.Value),
                .customerid = Convert.ToInt64(txtCustomerID.Text),
                .customername = txtname.Text,
                .totalamountdue = Convert.ToDecimal(txtTotalAmountDue.Value),
                .balance = Convert.ToDecimal(txtBalance.Value),
                .received_amount = Convert.ToDecimal(txtAmountReceived.Value),
                .change = Convert.ToDecimal(txtChange.Value),
                .paymenttype = Convert.ToString(dropPaymentType.Text),
                .cheque_no = Convert.ToString(txtChequeNo.Text)
            }
            If Not txtBalance.Value = 0 Then
                modelOrders.paystatus = "Not Paid"
            Else
                modelOrders.paystatus = "Paid"
            End If

            If funcOrder.saveNewOrder(modelOrders) Then
                For i As Integer = 0 To frmNewOrder.xDataGrid.RowCount - 1
                    modelOrder = New orderModel With {
                        .productdetailid = Convert.ToInt64(frmNewOrder.xDataGrid.Rows(i).Cells("_detailID").Value),
                        .productid = Convert.ToInt64(frmNewOrder.xDataGrid.Rows(i).Cells("_productID").Value),
                        .transactionCode = Convert.ToInt64(frmNewOrder.xDataGrid.Rows(i).Cells("_transaCode").Value),
                        .serialnumber = Convert.ToString(frmNewOrder.xDataGrid.Rows(i).Cells("_serialNumber").Value),
                        .productname = Convert.ToString(frmNewOrder.xDataGrid.Rows(i).Cells("_name").Value),
                        .productbrand = Convert.ToString(frmNewOrder.xDataGrid.Rows(i).Cells("_brand").Value),
                        .productmodel = Convert.ToString(frmNewOrder.xDataGrid.Rows(i).Cells("_model").Value),
                        .productcategory = Convert.ToString(frmNewOrder.xDataGrid.Rows(i).Cells("_category").Value),
                        .suppliername = Convert.ToString(frmNewOrder.xDataGrid.Rows(i).Cells("_supplier").Value),
                        .quantity = Convert.ToInt64(frmNewOrder.xDataGrid.Rows(i).Cells("_quantity").Value),
                        .unit = Convert.ToString(frmNewOrder.xDataGrid.Rows(i).Cells("_unit").Value),
                        .price = Convert.ToDecimal(frmNewOrder.xDataGrid.Rows(i).Cells("_price").Value),
                        .total = Convert.ToDecimal(frmNewOrder.xDataGrid.Rows(i).Cells("_total").Value)
                    }
                    If Not frmNewOrder.xDataGrid.Rows(i).Cells("_warrantyStart").Value = "" Then
                        modelOrder.warrantystart = frmNewOrder.xDataGrid.Rows(i).Cells("_warrantyStart").Value
                    End If
                    If Not frmNewOrder.xDataGrid.Rows(i).Cells("_warrantyEnd").Value = "" Then
                        modelOrder.warrantyend = frmNewOrder.xDataGrid.Rows(i).Cells("_warrantyEnd").Value
                    End If

                    Dim serialNumberr As String = frmNewOrder.xDataGrid.Rows(i).Cells("_serialNumber").Value
                    Dim productID As Long = Convert.ToInt64(frmNewOrder.xDataGrid.Rows(i).Cells("_productID").Value)
                    Dim quantity As Long = Convert.ToInt64(frmNewOrder.xDataGrid.Rows(i).Cells("_quantity").Value)

                    If funcOrder.insertOrderDetails(modelOrder) Then

                        Dim funcInventory As New inventoryFunction

                        Do While funcOrder.getQuantityRemainder(modelOrder.productdetailid, quantity) < 0
                            Dim qtyRemainder As Long = Math.Abs(funcOrder.getQuantityRemainder(modelOrder.productdetailid, quantity))
                            quantity -= qtyRemainder
                            funcOrder.updateProductsDetail_Quantity(modelOrder.productdetailid, quantity, modelOrders.transactioncode)
                            funcInventory.updateStockDetails_Status()
                            funcOrder.repopulateStockDetails_bySerialNumber(modelOrder, serialNumberr)
                            quantity = qtyRemainder
                        Loop
                        funcOrder.updateProductsDetail_Quantity(modelOrder.productdetailid, quantity, modelOrders.transactioncode)
                        funcInventory.updateStockDetails_Status()
                        funcOrder.updateProducts_QuantityOnHand(productID)
                    Else
                        customMessageBox.show(Me, "Failed to save order. Please try again.", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit For
                    End If
                Next
                customMessageBox.show(Me, "Order saved successfully.", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btn_cancel.PerformClick()
                frmNewOrder.btn_refresh.PerformClick()
            Else
                customMessageBox.show(Me, "Failed to save order. Please try again.", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        txtAmountReceived.Value = 0
        Close()
    End Sub

    Private Sub btn_choose_customer_Click(sender As Object, e As EventArgs) Handles btn_choose_customer.Click
        ActiveControl = Nothing
        frmChooseCustomer.ShowDialog()
    End Sub

    Private Sub txtChequeNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtChequeNo.KeyPress
        onlyAcceptNumber(e)
    End Sub

    Private Sub dropPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropPaymentType.SelectedIndexChanged
        If dropPaymentType.SelectedIndex = 1 Then
            lblChequeNo.Visible = True
            txtChequeNo.Visible = True
        Else
            lblChequeNo.Visible = False
            txtChequeNo.Visible = False
        End If
    End Sub
End Class