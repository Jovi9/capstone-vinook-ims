
Public Class frmCategories
    Private funcCategory As categoryFunction
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        menuBar.Renderer = New ToolStripProfessionalRenderer(New menuBarCustomColor)
        xDataGrid.ColumnHeadersDefaultCellStyle.Font = New Font("Helvetica", 12, FontStyle.Regular)

        loadChartCategory()
    End Sub

    Private Sub loadChartCategory()
        funcCategory = New categoryFunction
        chartTopCategories.DataSource = funcCategory.getTopCategories
        chartTopCategories.Series(0).XValueMember = "category"
        chartTopCategories.Series(0).YValueMembers = "stock"
        chartTopCategories.DataBind()
        chartTopCategories.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Helvetica", 10, FontStyle.Bold)
        chartTopCategories.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Helvetica", 10, FontStyle.Bold)
        chartTopCategories.Legends(0).Font = New Font("Helvetica", 11, FontStyle.Regular)

        lblTotalCategories.Text = funcCategory.totalCategories
    End Sub

    Public Sub loadCategoryDataGrid()
        funcCategory = New categoryFunction
        funcCategory.populateDGVCategory(xDataGrid, txt_searchbox.Text)
        xDataGrid.ClearSelection()
        txtID.Clear()
    End Sub

#Region "->Menu Bar"

    Private Sub menuRefresh_Click(sender As Object, e As EventArgs) Handles menuRefresh.Click
        txt_searchbox.Clear()
        txt_searchbox.Select()
        loadCategoryDataGrid()
    End Sub

    Private Sub menuNew_Click(sender As Object, e As EventArgs) Handles menuNew.Click
        ActiveControl = Nothing
        frmAddCategory.ShowDialog()
        loadCategoryDataGrid()
        loadCategoryDataGrid()
    End Sub

    Private Sub menuPrint_Click(sender As Object, e As EventArgs) Handles menuPrint.Click
        frmLoadingPreview.senderFrom = "category"
        frmLoadingPreview.ShowDialog()
    End Sub
#End Region
#Region "->Data Grid"
    Private Sub xDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles xDataGrid.CellClick
        Try
            txtID.Text = xDataGrid.CurrentRow.Cells(0).Value
            If xDataGrid.Columns(e.ColumnIndex).HeaderText = "Action" Then
                frmEditCategory.txtID.Text = txtID.Text
                frmEditCategory.ShowDialog()
                loadCategoryDataGrid()
                loadChartCategory()
            End If
        Catch ex As System.NullReferenceException

        End Try
    End Sub

    'Private Sub xDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles xDataGrid.CellDoubleClick
    '    Try
    '        txtID.Text = xDataGrid.CurrentRow.Cells(0).Value
    '        frmEditCategory.txtID.Text = txtID.Text
    '        frmEditCategory.ShowDialog()
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

    Private Sub frmCategories_Load(sender As Object, e As EventArgs) Handles Me.Load
        setDoubleBuffer(xDataGrid)
        loadCategoryDataGrid()
    End Sub

    Private Sub frmCategories_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
        loadCategoryDataGrid()
    End Sub
End Class