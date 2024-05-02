Public Class frmInventoryReport
    Private funcInventory As New inventoryReportFunction

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        maximizeRestore()

        startDate.Value = Date.Today.AddDays(-7)
        endDate.Value = Date.Now
        btnLastSevenDays.Select()

        funcInventory = New inventoryReportFunction
        startDate.MinDate = funcInventory.getInitialDateIn
        startDate.MaxDate = Date.Today.AddDays(1)
        endDate.MaxDate = Date.Today.AddDays(1)
        loadChartData()

    End Sub

    Private Sub loadChartData()
        Try
            Dim refresh As Boolean = funcInventory.loadData(startDate.Value, endDate.Value)
            If refresh Then
                lblTotalStocksReceived.Text = Format(funcInventory.totalStocks, "g")
                lblStocksAvailable.Text = Format(funcInventory.totalStocksAvailable, "g")

                chartStockInByDate.DataSource = funcInventory.stockByDateList
                chartStockInByDate.Series(0).XValueMember = "DateIn"
                chartStockInByDate.Series(0).YValueMembers = "Stock"
                If (endDate.Value - startDate.Value).Days <= 1 Then
                    chartStockInByDate.ChartAreas(0).AxisX.LabelStyle.Format = "hh:mm tt"
                ElseIf (endDate.Value - startDate.Value).Days <= 30 Then
                    chartStockInByDate.ChartAreas(0).AxisX.LabelStyle.Format = "MMM dd"
                ElseIf (endDate.Value - startDate.Value).Days <= 92 Then
                    chartStockInByDate.ChartAreas(0).AxisX.LabelStyle.Format = "MMM dd"
                ElseIf (endDate.Value - startDate.Value).Days <= (365 * 2) Then
                    chartStockInByDate.ChartAreas(0).AxisX.LabelStyle.Format = "MMM yyyy"
                Else
                    chartStockInByDate.ChartAreas(0).AxisX.LabelStyle.Format = "yyyy"
                End If
                chartStockInByDate.DataBind()

                chartProductStatistics.DataSource = funcInventory.productStatistics
                chartProductStatistics.Series(0).XValueMember = "ProductName"
                chartProductStatistics.Series(0).YValueMembers = "TotalStock"
                chartProductStatistics.Series(1).YValueMembers = "TotalAvailable"
                chartProductStatistics.Series(2).YValueMembers = "TotalSold"

                chartProductStatistics.DataBind()

                'style

                chartStockInByDate.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Helvetica", 10, FontStyle.Bold)
                chartStockInByDate.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Helvetica", 10, FontStyle.Bold)
                chartStockInByDate.Legends(0).Font = New Font("Helvetica", 10, FontStyle.Regular)

                chartProductStatistics.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Helvetica", 10, FontStyle.Bold)
                chartProductStatistics.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Helvetica", 10, FontStyle.Bold)
                chartProductStatistics.Legends(0).Font = New Font("Helvetica", 10, FontStyle.Regular)



                Console.WriteLine("Overview loaded.")
            Else
                Console.WriteLine("Same request, overview not loaded.")
            End If
        Catch ex As InvalidCastException
            If ex.Message.Contains("cannot be cast from DBNull") Then
                Console.WriteLine("System Error: " & ex.Message)
            End If
        End Try
    End Sub

    Private Sub disableCustomDate()
        btnOk.Enabled = False
        startDate.Enabled = False
        endDate.Enabled = False
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

    Public Sub checkLowStock()
        Dim funcInventory As New inventoryFunction
        Dim stockCount As Long = funcInventory.getLowStockCount
        If stockCount = 0 Then
            pnlNotification.Visible = False
        Else
            pnlNotification.Visible = True
            lblNotification.Text = "WARNING " & stockCount & " PRODUCTS ARE LOW ON STOCK!"
        End If
    End Sub
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

    Private Sub frmInventoryReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkLowStock()
    End Sub

    Private Sub frmInventoryReport_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            btn_close.PerformClick()
        End If
        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Try
            startDate.Value = funcInventory.getInitialDateIn
        Catch ex As ArgumentOutOfRangeException
            Console.WriteLine("System Error: " & ex.Message)
        End Try
        endDate.Value = Date.Now
        loadChartData()
        disableCustomDate()
    End Sub

    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        Try
            startDate.Value = Date.Today
        Catch ex As ArgumentOutOfRangeException
        End Try
        endDate.Value = Date.Now
        loadChartData()
        disableCustomDate()
    End Sub

    Private Sub btnLastSevenDays_Click(sender As Object, e As EventArgs) Handles btnLastSevenDays.Click
        Try
            startDate.Value = Date.Today.AddDays(-7)
        Catch ex As ArgumentOutOfRangeException
        End Try
        endDate.Value = Date.Now
        loadChartData()
        disableCustomDate()
    End Sub

    Private Sub btnLastThirtyDays_Click(sender As Object, e As EventArgs) Handles btnLastThirtyDays.Click
        Try
            startDate.Value = Date.Today.AddDays(-30)
        Catch ex As ArgumentOutOfRangeException
        End Try
        endDate.Value = Date.Now
        loadChartData()
        disableCustomDate()
    End Sub

    Private Sub btnThisMonth_Click(sender As Object, e As EventArgs) Handles btnThisMonth.Click
        Try
            startDate.Value = New DateTime(Date.Today.Year, Date.Today.Month, 1)
        Catch ex As ArgumentOutOfRangeException
        End Try
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

    Private Sub lblNotification_Click(sender As Object, e As EventArgs) Handles lblNotification.Click
        ActiveControl = Nothing
        frmViewLowStock.ShowDialog()
    End Sub
End Class