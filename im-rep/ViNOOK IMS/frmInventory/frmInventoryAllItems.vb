Public Class frmInventoryAllItems

    Dim funcInventory As inventoryFunction

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        menuBar.Renderer = New ToolStripProfessionalRenderer(New menuBarCustomColor)
        maximizeRestore()
        funcInventory = New inventoryFunction
        filterStartDate.MinDate = funcInventory.getInitialDateIn
        filterStartDate.MaxDate = Date.Today.AddDays(1)
        filterEndDate.MaxDate = Date.Today.AddDays(1)
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
        'funcInventory = New inventoryFunction
        funcInventory.loadCategoryComboBox(dropCategory, "reader")
        dropCategory.SelectedIndex = 0
    End Sub

    Private Sub populateSupplierComboBox()
        'funcInventory = New inventoryFunction
        funcInventory.loadSupplierComboBox(dropSupplier, "reader")
        dropSupplier.SelectedIndex = 0
    End Sub

    Public Sub loadDataGrid()
        'funcInventory = New inventoryFunction
        If checkFilterAllRange.Checked = False Then
            funcInventory.populateInventoryAllItems(xDataGrid, txt_searchbox.Text, Convert.ToString(dropCategory.Text), Convert.ToString(dropSupplier.Text), filterStartDate.Value)
        Else
            funcInventory.populateInventoryAllItems(xDataGrid, txt_searchbox.Text, Convert.ToString(dropCategory.Text), Convert.ToString(dropSupplier.Text), filterStartDate.Value, filterEndDate.Value)
        End If
        xDataGrid.ClearSelection()
        txtID.Clear()
    End Sub

#Region "->Data Grid"

    Private Sub xDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles xDataGrid.CellClick
        Try
            txtID.Text = xDataGrid.CurrentRow.Cells("_reference").Value
            If xDataGrid.Columns(e.ColumnIndex).HeaderText = "Action" Then
                frmViewStockDetails.txtReference.Text = txtID.Text
                frmViewStockDetails.ShowDialog()
            End If
        Catch ex As System.NullReferenceException

        End Try
    End Sub

    'Private Sub xDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles xDataGrid.CellDoubleClick
    '    Try
    '        txtID.Text = xDataGrid.CurrentRow.Cells(0).Value
    '        frmViewStockDetails.txtID.Text = txtID.Text
    '        frmViewStockDetails.ShowDialog()
    '    Catch ex As System.NullReferenceException

    '    End Try
    'End Sub

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

#Region "->Menu bar"

    Private Sub menuRefresh_Click(sender As Object, e As EventArgs) Handles menuRefresh.Click
        txt_searchbox.Clear()
        txtID.Clear()
        dropCategory.SelectedIndex = 0
        dropSupplier.SelectedIndex = 0
        checkFilterAllRange.Checked = False
        filterStartDate.Value = Date.Now
        filterEndDate.Value = Date.Now
        txt_searchbox.Select()
    End Sub

    Private Sub menuAdvanceSearch_Click(sender As Object, e As EventArgs) Handles menuAdvanceSearch.Click
        ActiveControl = Nothing
        frmInventoryAdvanceSearch.ShowDialog()
    End Sub

    Private Sub menuPrint_Click(sender As Object, e As EventArgs) Handles menuPrint.Click
        If checkFilterAllRange.Checked = False Then
            frmLoadingPreview.senderFrom = "all_inventory_A"
        Else
            frmLoadingPreview.senderFrom = "all_inventory_B"
        End If
        frmLoadingPreview.category = Convert.ToString(dropCategory.Text)
        frmLoadingPreview.supplier = Convert.ToString(dropSupplier.Text)
        frmLoadingPreview.startDate = filterStartDate.Value
        frmLoadingPreview.endDate = filterEndDate.Value
        frmLoadingPreview.ShowDialog()
    End Sub

#End Region

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        txt_searchbox.Clear()
        txtID.Clear()
        Try
            dropCategory.SelectedIndex = 0
            dropSupplier.SelectedIndex = 0
        Catch ex As ArgumentOutOfRangeException
        End Try
        Close()
    End Sub

    Private Sub frmInventoryAllItems_Load(sender As Object, e As EventArgs) Handles Me.Load
        setDoubleBuffer(xDataGrid)
        populateCategoryComboBox()
        populateSupplierComboBox()
        filterStartDate.Value = Date.Now
        filterEndDate.Value = Date.Now
        loadDataGrid()
    End Sub

    Private Sub frmInventoryAllItems_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub txt_searchbox_TextChanged(sender As Object, e As EventArgs) Handles txt_searchbox.TextChanged
        loadDataGrid()
    End Sub

    Private Sub dropCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropCategory.SelectedIndexChanged
        loadDataGrid()
    End Sub

    Private Sub dropSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropSupplier.SelectedIndexChanged
        loadDataGrid()
    End Sub

    Private Sub filterStartDate_ValueChanged(sender As Object, e As EventArgs) Handles filterStartDate.ValueChanged
        loadDataGrid()
        filterEndDate.MinDate = filterStartDate.Value
    End Sub

    Private Sub filterEndDate_ValueChanged(sender As Object, e As EventArgs) Handles filterEndDate.ValueChanged
        loadDataGrid()
    End Sub

    Private Sub checkFilterAllRange_CheckedChanged(sender As Object, e As EventArgs) Handles checkFilterAllRange.CheckedChanged
        If checkFilterAllRange.Checked = True Then
            filterEndDate.Enabled = True
            filterEndDate.Value = Date.Now
        Else
            filterEndDate.Enabled = False
            filterEndDate.Value = Date.Now
        End If
    End Sub

    'Private Sub checkShowAll_CheckedChanged(sender As Object, e As EventArgs) Handles checkShowAll.CheckedChanged
    '    If checkShowAll.Checked = True Then
    '        filterStartDate.Enabled = False
    '        filterStartDate.Value = Date.Now
    '        filterEndDate.Enabled = False
    '        filterEndDate.Value = Date.Now
    '        loadDataGrid()
    '    Else
    '        filterStartDate.Enabled = True
    '        filterStartDate.Value = Date.Now
    '        filterEndDate.Enabled = True
    '        filterEndDate.Value = Date.Now
    '        loadDataGrid()
    '    End If
    'End Sub
End Class