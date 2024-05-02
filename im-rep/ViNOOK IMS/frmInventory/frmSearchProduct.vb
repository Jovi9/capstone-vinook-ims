Public Class frmSearchProduct
#Region "->Data Grid"

    Private Sub xDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles xDataGrid.CellClick
        Try
            If xDataGrid.Columns(e.ColumnIndex).HeaderText = "Action" Then
                frmNewStock.txtItemCode.Text = xDataGrid.CurrentRow.Cells(1).Value
                frmNewStock.txtSerialNumber.Select()
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
    Dim funcInventory As inventoryFunction

    Private Sub populateComboBox()
        funcInventory = New inventoryFunction
        funcInventory.loadCategoryComboBox(dropCategory, "reader")
    End Sub

    Private Sub loadDataGrid()
        funcInventory = New inventoryFunction
        funcInventory.populateSearchProductsDataGrid(xDataGrid, txt_searchbox.Text, Convert.ToString(dropCategory.Text))
        xDataGrid.ClearSelection()
        txtID.Clear()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

    Private Sub frmSearchProduct_Load(sender As Object, e As EventArgs) Handles Me.Load
        setDoubleBuffer(xDataGrid)
        populateComboBox()
        loadDataGrid()
        txt_searchbox.Clear()
        txt_searchbox.Select()
    End Sub

    Private Sub frmSearchProduct_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.E) Then
            txt_searchbox.Select()
            txt_searchbox.SelectAll()
        End If

        If (e.Control AndAlso e.KeyCode = Keys.N) Then
            btn_new.PerformClick()
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

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        ActiveControl = Nothing
        frmNewProduct.senderFrom = "new stock"
        frmNewProduct.ShowDialog()
    End Sub
End Class