Public Class frmNewOrder

    Dim funcOrder As orderFunction
    Dim modelOrder As orderModel

    Public subTotal As Decimal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        maximizeRestore()
    End Sub

#Region "->Data Grid"

    Private Sub xDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles xDataGrid.CellClick
        Try
            txtSerialNumber.Select()
        Catch ex As System.NullReferenceException

        End Try
    End Sub

    Private Sub xDataGrid_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles xDataGrid.CellMouseMove
        If e.RowIndex > -1 Then
            xDataGrid.Rows(e.RowIndex).DefaultCellStyle.BackColor = rgbColors.buttonColor
            xDataGrid.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        End If
    End Sub

    Private Sub xDataGrid_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles xDataGrid.CellMouseLeave
        If e.RowIndex > -1 Then
            xDataGrid.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            xDataGrid.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub
#End Region
#Region "->Warranty"
    Private Sub getWarranty()
        If checkWarranty.Checked = True Then
            txtStartWarranty.Text = Format(orderDate.Value, "yyyy-MM-dd")
            If dropWarranty.SelectedIndex = 0 Then
                txtEndWarranty.Text = Format(Date.Now.AddMonths(3), "yyyy-MM-dd")
            ElseIf dropWarranty.SelectedIndex = 1 Then
                txtEndWarranty.Text = Format(Date.Now.AddMonths(6), "yyyy-MM-dd")
            ElseIf dropWarranty.SelectedIndex = 2 Then
                txtEndWarranty.Text = Format(Date.Now.AddYears(1), "yyyy-MM-dd")
            End If
        Else
            txtStartWarranty.Clear()
            txtEndWarranty.Clear()
        End If
    End Sub

    Private Sub checkWarranty_CheckedChanged(sender As Object, e As EventArgs) Handles checkWarranty.CheckedChanged
        getWarranty()
    End Sub

    Private Sub orderDate_ValueChanged(sender As Object, e As EventArgs) Handles orderDate.ValueChanged
        getWarranty()
    End Sub

    Private Sub dropWarranty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropWarranty.SelectedIndexChanged
        getWarranty()
    End Sub
#End Region
#Region "->Menu"
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Dim res = customMessageBox.show(Me, "Are you sure you want to exit current transaction? All changes will be discarded.", "Cancel Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            btn_refresh.PerformClick()
            frmSaveOrder.txtname.Clear()
            Close()
        End If
        txtSerialNumber.Select()
        txtSerialNumber.SelectAll()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        ActiveControl = Nothing
        txtSubTotal.Value = 0
        setTransactionCode()
        txtInvoiceNo.Clear()
        txtInvoiceNo.Select()
        orderDate.Value = Date.Now
        txtSerialNumber.Clear()
        txtQuantity.Value = 0
        checkWarranty.Checked = False
        dropWarranty.SelectedIndex = 0
        xDataGrid.Rows.Clear()
        frmSaveOrder.txtname.Clear()
    End Sub

    Private Sub btn_add_item_Click(sender As Object, e As EventArgs) Handles btn_add_item.Click
        If txtDetailID.Text.Trim = "" Or txtDetailID.Text = "0" Or
              txtProductID.Text.Trim = "" Or txtProductID.Text = "0" Then
            customMessageBox.show(Me, "No Item Selected.", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSerialNumber.Select()
            txtSerialNumber.SelectAll()
        Else
            If checkIfItemIsAdded() Then
                customMessageBox.show(Me, "Item is already added.", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSerialNumber.Clear()
                txtSerialNumber.Select()
                txtSerialNumber.SelectAll()
            Else
                If txtQuantity.Value = 0 Or txtQuantity.Text.Trim = "" Then
                    customMessageBox.show(Me, "Please enter Quantity.", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtQuantity.Select()
                Else
                    getSubTotalandMarkup()
                    xDataGrid.Rows.Add(txtDetailID.Text, txtProductID.Text, txtTransactionCode.Text, txtSerialNumber.Text, txtProductName.Text, txtProductBrand.Text, txtProductModel.Text, txtProductCategory.Text, txtSupplier.Text, Convert.ToInt64(txtQuantity.Value), txtUnit.Text, Convert.ToDecimal(txtxtProductPrice.Text), subTotal, txtStartWarranty.Text, txtEndWarranty.Text)
                    getTotalAmountDue()
                    txtSerialNumber.Clear()
                    txtSerialNumber.Select()
                    checkWarranty.Checked = False
                    xDataGrid.ClearSelection()
                End If
            End If
        End If
    End Sub

    Private Sub btn_remove_item_Click(sender As Object, e As EventArgs) Handles btn_remove_item.Click
        For Each row As DataGridViewRow In xDataGrid.SelectedRows
            xDataGrid.Rows.Remove(row)

        Next
        getTotalAmountDue()
        xDataGrid.ClearSelection()
        ActiveControl = Nothing
        txtSerialNumber.Select()
        txtSerialNumber.SelectAll()
    End Sub

    Private Sub btn_advance_search_Click(sender As Object, e As EventArgs) Handles btn_advance_search.Click
        ActiveControl = Nothing
        frmAdvanceProductSearch.ShowDialog()
    End Sub

    Private Sub btn_save_order_Click(sender As Object, e As EventArgs) Handles btn_save_order.Click
        If txtSubTotal.Value = 0 Or txtSubTotal.Text.Trim = "" Then
            customMessageBox.show(Me, "No Items Added.", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txtInvoiceNo.Text.Trim = "" Then
            customMessageBox.show(Me, "Invoice is empty.", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtInvoiceNo.Select()
            Exit Sub
        Else
            frmSaveOrder.txtTransactionCode.Text = txtTransactionCode.Text
            frmSaveOrder.txtInvoiceNo.Text = txtInvoiceNo.Text
            frmSaveOrder.txtTotalAmountDue.Value = txtSubTotal.Value
            'frmSaveOrder.txtBalance.Value = txtSubTotal.Value

            frmSaveOrder.ShowDialog()
        End If
    End Sub
#End Region
#Region "->Order"
    Private Sub timerDate_Tick(sender As Object, e As EventArgs) Handles timerDate.Tick
        labelDateTime.Text = Format(DateTime.Now, "dddd, dd-MMM-yyyy hh:mm:ss tt")
    End Sub

    Private Sub txtInvoiceNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInvoiceNo.KeyPress
        onlyAcceptNumber(e)
    End Sub

    Private Sub txtSerialNumber_TextChanged(sender As Object, e As EventArgs) Handles txtSerialNumber.TextChanged
        populateFields()
        xDataGrid.ClearSelection()
    End Sub

    Private Sub txtQuantity_ValueChanged(sender As Object, e As EventArgs) Handles txtQuantity.ValueChanged
        getSubTotalandMarkup()
    End Sub
#End Region

    Private Sub populateFields()
        funcOrder = New orderFunction
        modelOrder = New orderModel With {
            .serialnumber = txtSerialNumber.Text
        }
        funcOrder.getProductDetails(modelOrder)

        txtProductID.Text = modelOrder.productid
        txtDetailID.Text = modelOrder.productdetailid

        txtProductName.Text = modelOrder.productname
        txtProductBrand.Text = modelOrder.productbrand
        txtProductModel.Text = modelOrder.productmodel
        txtProductCategory.Text = modelOrder.productcategory
        txtUnit.Text = modelOrder.unit
        txtSupplier.Text = modelOrder.suppliername
        Dim price As String = String.Format("{0:#,##0.00}", modelOrder.price)
        txtxtProductPrice.Text = price

        If funcOrder.getSerialNumberRowCount(txtSerialNumber.Text) = 1 Then
            txtQuantity.Minimum = 1
            txtQuantity.Maximum = modelOrder.quantity
        Else
            txtQuantity.Minimum = 1
            txtQuantity.Maximum = modelOrder.totalonhand
        End If
    End Sub

    Private Sub getTotalAmountDue()
        Dim total As Decimal = 0
        For i As Integer = 0 To xDataGrid.RowCount - 1
            total += Val(xDataGrid.Rows(i).Cells("_total").Value)
        Next
        txtSubTotal.Value = total
    End Sub

    Private Sub getSubTotalandMarkup()
        Try
            subTotal = Convert.ToInt64(txtQuantity.Value) * Convert.ToDecimal(txtxtProductPrice.Text)
        Catch ex As FormatException

        End Try
    End Sub

    Private Function checkIfItemIsAdded() As Boolean
        For Each row As DataGridViewRow In xDataGrid.Rows
            If txtSerialNumber.Text = row.Cells(3).Value.ToString Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function

    Private Sub maximizeRestore()
        Dim isMaximised As Boolean = False
        Dim normalBounds As Rectangle

        If Not isMaximised Then
            normalBounds = Bounds
            Bounds = Screen.PrimaryScreen.WorkingArea
        Else
            Bounds = normalBounds
        End If
    End Sub

    Private Sub setTransactionCode()
        txtTransactionCode.Text = Format(DateTime.Now, "yyddMMmmHHss")
    End Sub

    Private Sub frmNewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerDate.Start()
        txtSubTotal.Controls(0).Visible = False
        setTransactionCode()
        txtInvoiceNo.Select()
        dropWarranty.SelectedIndex = 0
    End Sub

    Private Sub frmNewOrder_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btn_refresh.PerformClick()
        End If

        If e.KeyCode = Keys.F2 Then
            btn_add_item.PerformClick()
        End If

        If e.KeyCode = Keys.F3 Then
            btn_remove_item.PerformClick()
        End If

        If e.KeyCode = Keys.F4 Then
            btn_advance_search.PerformClick()
        End If

        If e.KeyCode = Keys.F10 Then
            btn_save_order.PerformClick()
        End If

        If e.KeyCode = Keys.Escape Then
            btn_close.PerformClick()
        End If
        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

End Class