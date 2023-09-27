Public Class frmAllOrders
    'Private filterDate As Boolean = False
    Private senderFrom As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        menuBar.Renderer = New ToolStripProfessionalRenderer(New menuBarCustomColor)
        xDataGrid.ColumnHeadersDefaultCellStyle.Font = New Font("Helvetica", 12, FontStyle.Regular)
        maximizeRestore()

        Dim funcDashboard As New dashboardFunction
        filterDateOrder.MinDate = funcDashboard.getInitialOrderDate
        filterDateOrderStart.MinDate = funcDashboard.getInitialOrderDate

        filterDateOrder.MaxDate = Date.Today.AddDays(1)
        filterDateOrderStart.MaxDate = Date.Today.AddDays(1)
        filterDateOrderEnd.MaxDate = Date.Today.AddDays(1)
    End Sub

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

    Private Sub populateCategoryComboBox()
        Dim funcInventory As New inventoryFunction
        funcInventory.loadCategoryComboBox(filter_category, "reader")
    End Sub

    Private Sub populateBrandComboBox()
        Dim funcInventory As New inventoryFunction
        funcInventory.loadBrandComboBox(dropBrand)
    End Sub
    Private Sub populateModelComboBox()
        Dim funcInventory As New inventoryFunction
        funcInventory.loadModelComboBox(dropModel, Convert.ToString(dropBrand.Text))
    End Sub

    Public Sub loadDataGrid()
        Dim funcOrder As New orderFunction
        If filterByOrderDate.Checked = True Then
            funcOrder.populateAllOrdersDataGrid(xDataGrid, txt_searchbox.Text, Convert.ToString(filter_category.Text), Convert.ToString(dropBrand.Text), Convert.ToString(dropModel.Text), Format(filterDateOrder.Value, "yyyy-MM-dd"))
            senderFrom = "all_orders_A"
        ElseIf filterByOrderDateRange.Checked = True Then
            funcOrder.populateAllOrdersDataGrid(xDataGrid, txt_searchbox.Text, Convert.ToString(filter_category.Text), Convert.ToString(dropBrand.Text), Convert.ToString(dropModel.Text), Format(filterDateOrderStart.Value, "yyyy-MM-dd"), Format(filterDateOrderEnd.Value, "yyyy-MM-dd"))
            senderFrom = "all_orders_B"
        End If
        xDataGrid.ClearSelection()
    End Sub

#Region "->Menu bar"

    Private Sub menuRefresh_Click(sender As Object, e As EventArgs) Handles menuRefresh.Click
        txt_searchbox.Clear()
        txt_searchbox.Select()
        filter_category.SelectedIndex = 0
        dropBrand.SelectedIndex = 0
        dropModel.SelectedIndex = 0
        'checkDateFilter.Checked = False
        filterByOrderDate.Checked = True
    End Sub

    Private Sub menuPrint_Click(sender As Object, e As EventArgs) Handles menuPrint.Click
        frmLoadingPreview.senderFrom = senderFrom
        frmLoadingPreview.category = Convert.ToString(filter_category.Text)
        frmLoadingPreview.brand = Convert.ToString(dropBrand.Text)
        frmLoadingPreview.model = Convert.ToString(dropModel.Text)
        frmLoadingPreview.orderDate = filterDateOrder.Value
        frmLoadingPreview.startDate = filterDateOrderStart.Value
        frmLoadingPreview.endDate = filterDateOrderEnd.Value
        frmLoadingPreview.ShowDialog()
    End Sub

    Private Sub menuAdvanceSearch_Click(sender As Object, e As EventArgs) Handles menuAdvanceSearch.Click
        ActiveControl = Nothing
        frmAllOrdersAdvanceSearch.ShowDialog()
    End Sub
#End Region

#Region "->Filter"
    Private Sub txt_searchbox_TextChanged(sender As Object, e As EventArgs) Handles txt_searchbox.TextChanged
        loadDataGrid()
    End Sub

    Private Sub filter_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filter_category.SelectedIndexChanged
        loadDataGrid()
    End Sub

    Private Sub dropBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropBrand.SelectedIndexChanged
        populateModelComboBox()
        loadDataGrid()
    End Sub

    Private Sub dropModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropModel.SelectedIndexChanged
        loadDataGrid()
    End Sub

    Private Sub filterByOrderDate_CheckedChanged(sender As Object, e As EventArgs) Handles filterByOrderDate.CheckedChanged
        If filterByOrderDate.Checked = True Then
            filterDateOrder.Enabled = True
            filterDateOrder.Value = Date.Now

            filterByOrderDateRange.Checked = False
            filterDateOrderStart.Enabled = False
            filterDateOrderEnd.Enabled = False
            filterDateOrderStart.Value = Date.Now
            filterDateOrderEnd.Value = Date.Now
        End If
    End Sub

    Private Sub filterDateOrder_ValueChanged(sender As Object, e As EventArgs) Handles filterDateOrder.ValueChanged
        loadDataGrid()
    End Sub

    Private Sub filterByOrderDateRange_CheckedChanged(sender As Object, e As EventArgs) Handles filterByOrderDateRange.CheckedChanged
        If filterByOrderDateRange.Checked = True Then
            filterByOrderDate.Checked = False
            filterDateOrder.Enabled = False
            filterDateOrder.Value = Date.Now

            filterDateOrderStart.Enabled = True
            filterDateOrderEnd.Enabled = True
            filterDateOrderStart.Value = Date.Now
            filterDateOrderEnd.Value = Date.Now
        End If
    End Sub

    Private Sub filterDateOrderStart_ValueChanged(sender As Object, e As EventArgs) Handles filterDateOrderStart.ValueChanged
        loadDataGrid()
        filterDateOrderEnd.MinDate = filterDateOrderStart.Value
    End Sub

    Private Sub filterDateOrderEnd_ValueChanged(sender As Object, e As EventArgs) Handles filterDateOrderEnd.ValueChanged
        loadDataGrid()
    End Sub
#End Region
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

    Private Sub frmAllOrders_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub frmAllOrders_Load(sender As Object, e As EventArgs) Handles Me.Load
        setDoubleBuffer(xDataGrid)
        populateCategoryComboBox()
        populateBrandComboBox()
        populateModelComboBox()
        filter_category.SelectedIndex = 0
        filterByOrderDate.Checked = True
        filterDateOrder.Value = Date.Now
        filterDateOrderEnd.MinDate = filterDateOrderStart.Value
        loadDataGrid()
        'checkDateFilter.Checked = False
        txt_searchbox.Clear()
        txt_searchbox.Select()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

End Class