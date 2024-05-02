Public Class frmAdvanceProductSearch
    Dim funcInventory As inventoryFunction
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        xDataGrid.ColumnHeadersDefaultCellStyle.Font = New Font("Helvetica", 12, FontStyle.Regular)
    End Sub

    Private Sub populateComboBox()
        funcInventory = New inventoryFunction
        funcInventory.loadCategoryComboBox(dropCategory, "reader")
    End Sub

    Public Sub loadDataGrid()
        funcInventory = New inventoryFunction
        funcInventory.populateSearchProductsDataGrid(xDataGrid, txt_searchbox.Text, Convert.ToString(dropCategory.Text))
        For i As Integer = 0 To xDataGrid.RowCount - 1
            If xDataGrid.Rows(i).Cells("_onHand").Value.ToString = "0" Then
                xDataGrid.Rows(i).Visible = False
            End If
        Next
        xDataGrid.ClearSelection()
    End Sub

#Region "->Data Grid"

    Private Sub xDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles xDataGrid.CellClick
        Try
            Dim pid As Long = xDataGrid.CurrentRow.Cells(0).Value
            If xDataGrid.Columns(e.ColumnIndex).HeaderText = "Action" Then
                funcInventory = New inventoryFunction
                Dim modelInventory As New inventoryModel With {
                    .productid = pid
                }
                funcInventory.getStockDetails(modelInventory, "product_id")
                frmNewOrder.txtSerialNumber.Text = modelInventory.serialnumber
                Close()
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

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

    Private Sub frmOrdersAdvanceSearch_Load(sender As Object, e As EventArgs) Handles Me.Load
        setDoubleBuffer(xDataGrid)
        populateComboBox()
        loadDataGrid()
        txt_searchbox.Clear()
        txt_searchbox.Select()
    End Sub

    Private Sub frmOrdersAdvanceSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
End Class