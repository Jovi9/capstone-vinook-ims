Public Class frmOrders

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        menuBar.Renderer = New ToolStripProfessionalRenderer(New menuBarCustomColor)
        xDataGrid.ColumnHeadersDefaultCellStyle.Font = New Font("Helvetica", 12, FontStyle.Regular)

        Dim funcDashboard As New dashboardFunction
        filterDateOrder.MinDate = funcDashboard.getInitialOrderDate

        filterDateOrder.MaxDate = Date.Today.AddDays(1)
        filterDateOrderEnd.MaxDate = Date.Today.AddDays(1)
    End Sub

#Region "->Menu bar"
    Private Sub menuRefresh_Click(sender As Object, e As EventArgs) Handles menuRefresh.Click
        txt_searchbox.Clear()
        txt_searchbox.Select()
        checkFilterAllRange.Checked = False
        filterDateOrder.Value = Date.Now
        filterDateOrderEnd.Value = Date.Now
    End Sub

    Private Sub menuNew_Click(sender As Object, e As EventArgs) Handles menuNew.Click
        ActiveControl = Nothing
        frmNewOrder.ShowDialog()
        loadDataGrid()
    End Sub

    Private Sub menuAllOrders_Click(sender As Object, e As EventArgs) Handles menuAllOrders.Click
        ActiveControl = Nothing
        frmAllOrders.ShowDialog()

    End Sub

    Private Sub menuPrint_Click(sender As Object, e As EventArgs) Handles menuPrint.Click
        If checkFilterAllRange.Checked = False Then
            frmLoadingPreview.senderFrom = "orders_A"
        Else
            frmLoadingPreview.senderFrom = "orders_B"
        End If
        frmLoadingPreview.startDate = filterDateOrder.Value
        frmLoadingPreview.endDate = filterDateOrderEnd.Value
        frmLoadingPreview.ShowDialog()
    End Sub

    Private Sub menuSalesReport_Click(sender As Object, e As EventArgs) Handles menuSalesReport.Click
        ActiveControl = Nothing
        frmSalesReport.ShowDialog()
    End Sub

#End Region
#Region "->Data Grid"

    Private Sub xDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles xDataGrid.CellClick
        Try
            txtID.Text = xDataGrid.CurrentRow.Cells(0).Value
            If xDataGrid.Columns(e.ColumnIndex).HeaderText = "Action" Then
                frmViewOrderDetails.txtTransactionCode.Text = txtID.Text
                frmViewOrderDetails.ShowDialog()
                loadDataGrid()
            End If
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
#Region "->Remove Flicker"
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

#End Region

    Public Sub loadDataGrid()
        Dim funcOrder As New orderFunction
        If checkFilterAllRange.Checked = False Then
            funcOrder.populateOrdersDataGrid(xDataGrid, txt_searchbox.Text, filterDateOrder.Value)
        Else
            funcOrder.populateOrdersDataGrid(xDataGrid, txt_searchbox.Text, Format(filterDateOrder.Value, "yyyy-MM-dd"), Format(filterDateOrderEnd.Value, "yyyy-MM-dd"))
        End If
        xDataGrid.ClearSelection()
        txtID.Clear()
    End Sub

    Private Sub frmOrders_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        frm_main.btn_orders.PerformClick()
    End Sub

    Private Sub frmOrders_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.E) Then
            txt_searchbox.Select()
            txt_searchbox.SelectAll()
        End If

        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmOrders_Load(sender As Object, e As EventArgs) Handles Me.Load
        setDoubleBuffer(xDataGrid)
        filterDateOrderEnd.MinDate = filterDateOrder.Value
        loadDataGrid()
    End Sub

    Private Sub txt_searchbox_TextChanged(sender As Object, e As EventArgs) Handles txt_searchbox.TextChanged
        loadDataGrid()
    End Sub

    Private Sub filterDateOrder_ValueChanged(sender As Object, e As EventArgs) Handles filterDateOrder.ValueChanged
        loadDataGrid()
        filterDateOrderEnd.MinDate = filterDateOrder.Value
    End Sub

    Private Sub filterDateOrderEnd_ValueChanged(sender As Object, e As EventArgs) Handles filterDateOrderEnd.ValueChanged
        loadDataGrid()
    End Sub

    Private Sub checkFilterAllRange_CheckedChanged(sender As Object, e As EventArgs) Handles checkFilterAllRange.CheckedChanged
        If checkFilterAllRange.Checked = True Then
            filterDateOrderEnd.Enabled = True
            filterDateOrderEnd.Value = Date.Now
        Else
            filterDateOrderEnd.Enabled = False
            filterDateOrderEnd.Value = Date.Now
        End If
    End Sub


    'Private Sub checkShowAll_CheckedChanged(sender As Object, e As EventArgs) Handles checkShowAll.CheckedChanged
    '    If checkShowAll.Checked = True Then
    '        filterDateOrder.Enabled = False
    '        filterDateOrder.Value = Date.Now
    '        filterDateOrderEnd.Enabled = False
    '        filterDateOrderEnd.Value = Date.Now
    '        loadDataGrid()
    '    Else
    '        filterDateOrder.Enabled = True
    '        filterDateOrder.Value = Date.Now
    '        filterDateOrderEnd.Enabled = True
    '        filterDateOrderEnd.Value = Date.Now
    '        loadDataGrid()
    '    End If
    'End Sub

End Class