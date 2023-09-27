Public Class frmInventory

    Dim funcInventory As inventoryFunction

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        menuBar.Renderer = New ToolStripProfessionalRenderer(New menuBarCustomColor)
        xDataGrid.ColumnHeadersDefaultCellStyle.Font = New Font("Helvetica", 12, FontStyle.Regular)

    End Sub

#Region "->Menu BAr"
    Private Sub menuRefresh_Click(sender As Object, e As EventArgs) Handles menuRefresh.Click
        txt_searchbox.Clear()
        txt_searchbox.Select()
        populateComboBox()
        filter_category.SelectedIndex = 0
        funcInventory = New inventoryFunction
        funcInventory.updateAllProducts_QuantityInStock()
        loadDataGrid()
        checkShowAllProducts.Checked = False
        hideRows_ZeroInStock(True)
    End Sub

    Private Sub menuNew_Click(sender As Object, e As EventArgs) Handles menuNew.Click
        ActiveControl = Nothing
        frmNewStock.ShowDialog()
        loadDataGrid()
        hideRows_ZeroInStock(True)
    End Sub

    Private Sub menuAllItems_Click(sender As Object, e As EventArgs) Handles menuAllItems.Click
        ActiveControl = Nothing
        frmInventoryAllItems.ShowDialog()
    End Sub

    Private Sub menuPrint_Click(sender As Object, e As EventArgs) Handles menuPrint.Click
        frmLoadingPreview.senderFrom = "inventory"
        frmLoadingPreview.category = Convert.ToString(filter_category.Text)
        frmLoadingPreview.ShowDialog()
    End Sub

    Private Sub menuStockReport_Click(sender As Object, e As EventArgs) Handles menuStockReport.Click
        ActiveControl = Nothing
        frmInventoryReport.ShowDialog()
    End Sub
#End Region
#Region "->Data Grid"

    Private Sub xDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles xDataGrid.CellClick
        Try
            txtID.Text = xDataGrid.CurrentRow.Cells(0).Value
            If xDataGrid.Columns(e.ColumnIndex).HeaderText = "Action" Then
                frmViewProductDetails.txtID.Text = txtID.Text
                frmViewProductDetails.ShowDialog()
                loadDataGrid()
                hideRows_ZeroInStock(True)
            End If
        Catch ex As System.NullReferenceException
            Exit Sub
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
#Region "->Remove Flicker"
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
#End Region

    Private Sub populateComboBox()
        funcInventory = New inventoryFunction
        funcInventory.loadCategoryComboBox(filter_category, "reader")
    End Sub

    Public Sub loadDataGrid()
        funcInventory = New inventoryFunction
        funcInventory.populateDGVInventory(xDataGrid, txt_searchbox.Text, Convert.ToString(filter_category.Text))
        xDataGrid.ClearSelection()
        txtID.Clear()
    End Sub

    Private Sub hideRows_ZeroInStock(visibility As Boolean)
        If visibility = True Then
            For Each row As DataGridViewRow In xDataGrid.Rows
                If row.Cells("_onHand").Value.ToString = "0" Then
                    row.Visible = False
                End If
            Next
        Else
            For Each row As DataGridViewRow In xDataGrid.Rows
                row.Visible = True
            Next
        End If
    End Sub

    Private Sub frmInventory_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        frm_main.btn_inventory.PerformClick()
    End Sub

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setDoubleBuffer(xDataGrid)
        populateComboBox()
        filter_category.SelectedIndex = 0
        checkShowAllProducts.Checked = False
        loadDataGrid()
        hideRows_ZeroInStock(True)
        'menuRefresh.PerformClick()
    End Sub

    Private Sub frmInventory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.E) Then
            txt_searchbox.Select()
            txt_searchbox.SelectAll()
        End If

        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_searchbox_TextChanged(sender As Object, e As EventArgs) Handles txt_searchbox.TextChanged
        loadDataGrid()
        If checkShowAllProducts.Checked = True Then
            hideRows_ZeroInStock(False)
        Else
            hideRows_ZeroInStock(True)
        End If
    End Sub

    Private Sub filter_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filter_category.SelectedIndexChanged
        loadDataGrid()
        If checkShowAllProducts.Checked = True Then
            hideRows_ZeroInStock(False)
        Else
            hideRows_ZeroInStock(True)
        End If
    End Sub

    Private Sub checkShowAllProducts_CheckedChanged(sender As Object, e As EventArgs) Handles checkShowAllProducts.CheckedChanged
        If checkShowAllProducts.Checked = False Then
            hideRows_ZeroInStock(True)
        Else
            hideRows_ZeroInStock(False)
        End If
    End Sub

End Class