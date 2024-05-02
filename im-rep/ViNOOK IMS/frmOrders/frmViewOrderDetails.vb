Public Class frmViewOrderDetails

    Dim funcOrder As orderFunction

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        xDataGrid.ColumnHeadersDefaultCellStyle.Font = New Font("Helvetica", 11, FontStyle.Regular)
    End Sub

    Private Sub populateFields_FromTransactionCode()
        funcOrder = New orderFunction
        Dim modelOrder As New ordersModel With {
            .transactioncode = Convert.ToInt64(txtTransactionCode.Text)
        }
        funcOrder.getOrderDetails(modelOrder)

        txtInvoiceNo.Text = modelOrder.invoice
        txtname.Text = modelOrder.customername
        Dim totalAmount As String = String.Format("{0:#,##0.00}", modelOrder.totalamountdue)
        txtTotalAmountDue.Text = totalAmount
        If modelOrder.paymenttype = "Cheque" Then
            txtpaymentType.Text = modelOrder.paymenttype & " - No. " & modelOrder.cheque_no
        Else
            txtpaymentType.Text = modelOrder.paymenttype
        End If
        txtAddress.Text = modelOrder.customeraddress
    End Sub

    Public Sub loadDataGrid()
        funcOrder = New orderFunction
        funcOrder.populateOrderItemsDatagrid(xDataGrid, txt_searchbox.Text, Convert.ToInt64(txtTransactionCode.Text))
        xDataGrid.ClearSelection()
    End Sub


#Region "->Data Grid"
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

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        ActiveControl = Nothing
        clearToDefault(group_details)
        Close()
    End Sub

    Private Sub txtTransactionCode_TextChanged(sender As Object, e As EventArgs) Handles txtTransactionCode.TextChanged
        If Not txtTransactionCode.Text.Trim = "" Then
            populateFields_FromTransactionCode()
        End If
    End Sub

    Private Sub txt_searchbox_TextChanged(sender As Object, e As EventArgs) Handles txt_searchbox.TextChanged
        loadDataGrid()
    End Sub

    Private Sub frmViewOrderDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        setDoubleBuffer(xDataGrid)
        loadDataGrid()
        txt_searchbox.Clear()
    End Sub

    Private Sub frmViewOrderDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.E) Then
            txt_searchbox.Select()
            txt_searchbox.SelectAll()
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