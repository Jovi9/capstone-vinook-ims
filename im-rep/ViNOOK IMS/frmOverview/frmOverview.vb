Public Class frmOverview
    Private funcDashboard As dashboardFunction

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        xDataGrid.ColumnHeadersDefaultCellStyle.Font = New Font("Helvetica", 11, FontStyle.Regular)
        startDate.Value = Date.Today.AddDays(-7)
        endDate.Value = Date.Now
        btnLastSevenDays.Select()

        funcDashboard = New dashboardFunction
        startDate.MinDate = funcDashboard.getInitialOrderDate
        startDate.MaxDate = Date.Today.AddDays(1)
        endDate.MaxDate = Date.Today.AddDays(1)
        loadChartData()

    End Sub

    Private Sub loadChartData()
        Try
            Dim refresh As Boolean = funcDashboard.loadData(startDate.Value, endDate.Value)
            If refresh Then
                lblTotalSales.Text = Format(funcDashboard.totalsales, "n")
                lblTotalOrders.Text = Format(funcDashboard.numorderstotal, "g")
                lblTotalCustomers.Text = Format(funcDashboard.numcustomerstotal, "g")
                lblTotalSuppliers.Text = Format(funcDashboard.numsupplierstotal, "g")
                lblTotalProducts.Text = Format(funcDashboard.numproductstotal, "g")
                lblTotalStocksAvailable.Text = Format(funcDashboard.numstockstotal, "g")

                chartSalesSummary.DataSource = funcDashboard.salesbydatelist
                chartSalesSummary.Series(0).XValueMember = "order_date"
                chartSalesSummary.Series(0).YValueMembers = "TotalAmount"
                If (endDate.Value - startDate.Value).Days <= 1 Then
                    chartSalesSummary.ChartAreas(0).AxisX.LabelStyle.Format = "hh:mm tt"
                ElseIf (endDate.Value - startDate.Value).Days <= 30 Then
                    chartSalesSummary.ChartAreas(0).AxisX.LabelStyle.Format = "MMM dd"
                ElseIf (endDate.Value - startDate.Value).Days <= 92 Then
                    chartSalesSummary.ChartAreas(0).AxisX.LabelStyle.Format = "MMM dd"
                ElseIf (endDate.Value - startDate.Value).Days <= (365 * 2) Then
                    chartSalesSummary.ChartAreas(0).AxisX.LabelStyle.Format = "MMM yyyy"
                Else
                    chartSalesSummary.ChartAreas(0).AxisX.LabelStyle.Format = "yyyy"
                End If
                chartSalesSummary.DataBind()

                chartTopSellingProducts.DataSource = funcDashboard.topproductlist
                chartTopSellingProducts.Series(0).XValueMember = "_name"
                chartTopSellingProducts.Series(0).YValueMembers = "TotalSold"
                chartTopSellingProducts.DataBind()

                xDataGrid.Rows.Clear()
                For Each row As DataRow In funcDashboard.lowproductstocklist.Rows
                    xDataGrid.Rows.Add(row(0), row(1))
                Next

                Console.WriteLine("Overview loaded.")
            Else
                Console.WriteLine("Same request, overview not loaded.")
            End If
        Catch ex As InvalidCastException
            If ex.Message.Contains("cannot be cast from DBNull") Then
                customMessageBox.show(Me, "Empty Data.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
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
#Region "->Remove Flicker"
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
#End Region

    Private Sub disableCustomDate()
        btnOk.Enabled = False
        startDate.Enabled = False
        endDate.Enabled = False
    End Sub

    Private Sub frmOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disableCustomDate()
        endDate.MinDate = startDate.Value
    End Sub

    Private Sub frmOverview_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        frm_main.btnOverview.PerformClick()
    End Sub

    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        startDate.Value = Date.Today
        endDate.Value = Date.Now
        loadChartData()
        disableCustomDate()
    End Sub

    Private Sub btnLastSevenDays_Click(sender As Object, e As EventArgs) Handles btnLastSevenDays.Click
        startDate.Value = Date.Today.AddDays(-7)
        endDate.Value = Date.Now
        loadChartData()
        disableCustomDate()
    End Sub

    Private Sub btnLastThirtyDays_Click(sender As Object, e As EventArgs) Handles btnLastThirtyDays.Click
        startDate.Value = Date.Today.AddDays(-30)
        endDate.Value = Date.Now
        loadChartData()
        disableCustomDate()
    End Sub

    Private Sub btnThisMonth_Click(sender As Object, e As EventArgs) Handles btnThisMonth.Click
        startDate.Value = New DateTime(Date.Today.Year, Date.Today.Month, 1)
        endDate.Value = Date.Now
        loadChartData()
        disableCustomDate()
    End Sub

    Private Sub btnCustom_Click(sender As Object, e As EventArgs) Handles btnCustom.Click
        btnOk.Enabled = True
        startDate.Enabled = True
        endDate.Enabled = True
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        loadChartData()
    End Sub

    Private Sub startDate_ValueChanged(sender As Object, e As EventArgs) Handles startDate.ValueChanged
        endDate.MinDate = startDate.Value
    End Sub

    Private Sub frmOverview_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnViewAllLowStock_Click(sender As Object, e As EventArgs) Handles btnViewAllLowStock.Click
        ActiveControl = Nothing
        frmViewLowStock.ShowDialog()
    End Sub
End Class