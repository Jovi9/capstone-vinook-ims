Public Class frmAllOrdersAdvanceSearch

    Public Sub loadDataGrid()
        Dim funcOrder As New orderFunction
        funcOrder.advanceOrdersSearch(xDataGrid, txt_searchbox.Text)
        xDataGrid.ClearSelection()
    End Sub

#Region "->Data Grid"

    Private Sub xDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles xDataGrid.CellClick
        Try
            If xDataGrid.Columns(e.ColumnIndex).HeaderText = "Action" Then
                frmViewOrderDetails.txtTransactionCode.Text = xDataGrid.CurrentRow.Cells("_transacode").Value
                frmViewOrderDetails.ShowDialog()
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
        txt_searchbox.Clear()
        Close()
    End Sub

    Private Sub txt_searchbox_TextChanged(sender As Object, e As EventArgs) Handles txt_searchbox.TextChanged
        If Not txt_searchbox.Text.Trim = "" Then
            loadDataGrid()
        Else
            xDataGrid.Rows.Clear()
        End If
    End Sub

    Private Sub frmAllOrdersAdvanceSearch_Load(sender As Object, e As EventArgs) Handles Me.Load
        setDoubleBuffer(xDataGrid)
        txt_searchbox.Select()
    End Sub

    Private Sub frmAllOrdersAdvanceSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.E) Then
            txt_searchbox.Select()
            txt_searchbox.SelectAll()
        End If

        If e.KeyCode = Keys.F5 Then
            txt_searchbox.Clear()
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