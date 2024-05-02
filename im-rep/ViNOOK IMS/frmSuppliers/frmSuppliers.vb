Public Class frmSuppliers

    Dim funcSupplier As supplierFunction
    'Dim modelSupplier As supplierModel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        menuBar.Renderer = New ToolStripProfessionalRenderer(New menuBarCustomColor)
        xDataGrid.ColumnHeadersDefaultCellStyle.Font = New Font("Helvetica", 12, FontStyle.Regular)

        loadChartSupplier()
    End Sub

    Private Sub loadChartSupplier()
        funcSupplier = New supplierFunction
        chartTopSuppliers.DataSource = funcSupplier.getTopSupplier
        chartTopSuppliers.Series(0).XValueMember = "supplier"
        chartTopSuppliers.Series(0).YValueMembers = "stock"
        chartTopSuppliers.DataBind()
        chartTopSuppliers.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Helvetica", 10, FontStyle.Bold)
        chartTopSuppliers.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Helvetica", 10, FontStyle.Bold)
        chartTopSuppliers.Legends(0).Font = New Font("Helvetica", 11, FontStyle.Regular)

        lblTotalSuppliers.Text = funcSupplier.totalSuppliers
    End Sub


#Region "->Menu bar"
    Private Sub menuRefresh_Click(sender As Object, e As EventArgs) Handles menuRefresh.Click
        txt_searchbox.Clear()
        txt_searchbox.Select()
        loadSupplierDataGrid()
    End Sub

    Private Sub menuNew_Click(sender As Object, e As EventArgs) Handles menuNew.Click
        ActiveControl = Nothing
        frmNewSupplier.ShowDialog()
        loadSupplierDataGrid()
        loadChartSupplier()
    End Sub

    Private Sub menuPrint_Click(sender As Object, e As EventArgs) Handles menuPrint.Click
        frmLoadingPreview.senderFrom = "suppliers"
        frmLoadingPreview.ShowDialog()
    End Sub
#End Region
#Region "->Data Grid"
    Private Sub xDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles xDataGrid.CellClick
        Try
            txtID.Text = xDataGrid.CurrentRow.Cells(0).Value
            If xDataGrid.Columns(e.ColumnIndex).HeaderText = "Action" Then
                frmViewSupplierDetails.txtID.Text = txtID.Text
                frmViewSupplierDetails.ShowDialog()
                loadSupplierDataGrid()
                loadChartSupplier()
            End If
        Catch ex As System.NullReferenceException

        End Try
    End Sub

    'Private Sub xDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles xDataGrid.CellDoubleClick
    '    Try
    '        txtID.Text = xDataGrid.CurrentRow.Cells(0).Value
    '        frmViewSupplierDetails.txtID.Text = txtID.Text
    '        frmViewSupplierDetails.ShowDialog()
    '        loadSupplierDataGrid()
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

    Public Sub loadSupplierDataGrid()
        funcSupplier = New supplierFunction
        funcSupplier.populateDGVSupplier(xDataGrid, txt_searchbox.Text)
        xDataGrid.ClearSelection()
        txtID.Clear()
    End Sub

    Private Sub frmSuppliers_Load(sender As Object, e As EventArgs) Handles Me.Load
        setDoubleBuffer(xDataGrid)
        loadSupplierDataGrid()
    End Sub

    Private Sub txt_searchbox_TextChanged(sender As Object, e As EventArgs) Handles txt_searchbox.TextChanged
        loadSupplierDataGrid()
    End Sub

    Private Sub frmSuppliers_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.E) Then
            txt_searchbox.Select()
            txt_searchbox.SelectAll()
        End If

        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub
End Class