Public Class frmSalesReport
    Private funcSales As salesReportFunction

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        maximizeRestore()

        startDate.Value = Date.Today.AddDays(-7)
        endDate.Value = Date.Now
        btnLastSevenDays.Select()

        funcSales = New salesReportFunction
        startDate.MinDate = funcSales.getInitialOrderDate
        startDate.MaxDate = Date.Today.AddDays(1)
        endDate.MaxDate = Date.Today.AddDays(1)
        loadSalesChart()

    End Sub

    Private Sub loadSalesChart()
        Try
            Dim refresh As Boolean = funcSales.loadData(startDate.Value, endDate.Value)
            If refresh Then
                lblTotalSales.Text = Format(funcSales.totalSales, "n")
                lblTotalOrders.Text = Format(funcSales.totalOrders, "g")
                lblTotalCustomers.Text = Format(funcSales.totalCustomer, "g")

                chartSalesSummary.DataSource = funcSales.salesByDateList
                chartSalesSummary.Series(0).XValueMember = "OrderDate"
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

                chartAllProductsSold.DataSource = funcSales.soldProductsList
                chartAllProductsSold.Series(0).XValueMember = "ProductName"
                chartAllProductsSold.Series(0).YValueMembers = "TotalSold"
                chartAllProductsSold.DataBind()

                chartTopSellingProducts.DataSource = funcSales.topProductsList
                chartTopSellingProducts.Series(0).XValueMember = "ProductName"
                chartTopSellingProducts.Series(0).YValueMembers = "TotalSold"
                chartTopSellingProducts.DataBind()

                'style
                chartSalesSummary.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Helvetica", 10, FontStyle.Bold)

                chartSalesSummary.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Helvetica", 10, FontStyle.Bold)
                chartSalesSummary.ChartAreas(0).AxisY.LabelStyle.Format = "{0:#,#}"
                chartSalesSummary.Legends(0).Font = New Font("Helvetica", 11, FontStyle.Regular)


                chartAllProductsSold.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Helvetica", 10, FontStyle.Bold)
                chartAllProductsSold.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Helvetica", 10, FontStyle.Bold)
                chartAllProductsSold.Legends(0).Font = New Font("Helvetica", 11, FontStyle.Regular)

                chartTopSellingProducts.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Helvetica", 10, FontStyle.Bold)
                chartTopSellingProducts.Legends(0).Font = New Font("Helvetica", 11, FontStyle.Regular)

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
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

    Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub frmSalesReport_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
            startDate.Value = funcSales.getInitialOrderDate
        Catch ex As ArgumentOutOfRangeException
            Console.WriteLine("System Error: " & ex.Message)
        End Try
        endDate.Value = Date.Now
        loadSalesChart()
        disableCustomDate()
    End Sub
    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        Try
            startDate.Value = Date.Today
        Catch ex As ArgumentOutOfRangeException
        End Try
        endDate.Value = Date.Now
        loadSalesChart()
        disableCustomDate()
    End Sub

    Private Sub btnLastSevenDays_Click(sender As Object, e As EventArgs) Handles btnLastSevenDays.Click
        Try
            startDate.Value = Date.Today.AddDays(-7)
        Catch ex As ArgumentOutOfRangeException
        End Try
        endDate.Value = Date.Now
        loadSalesChart()
        disableCustomDate()
    End Sub

    Private Sub btnLastThirtyDays_Click(sender As Object, e As EventArgs) Handles btnLastThirtyDays.Click
        Try
            startDate.Value = Date.Today.AddDays(-30)
        Catch ex As ArgumentOutOfRangeException
        End Try
        endDate.Value = Date.Now
        loadSalesChart()
        disableCustomDate()
    End Sub

    Private Sub btnThisMonth_Click(sender As Object, e As EventArgs) Handles btnThisMonth.Click
        Try
            startDate.Value = New DateTime(Date.Today.Year, Date.Today.Month, 1)
        Catch ex As ArgumentOutOfRangeException
        End Try
        endDate.Value = Date.Now
        loadSalesChart()
        disableCustomDate()
    End Sub

    Private Sub btnCustom_Click(sender As Object, e As EventArgs) Handles btnCustom.Click
        btnOk.Enabled = True
        startDate.Enabled = True
        endDate.Enabled = True
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        loadSalesChart()
    End Sub

    Private Sub startDate_ValueChanged(sender As Object, e As EventArgs) Handles startDate.ValueChanged
        endDate.MinDate = startDate.Value
    End Sub

End Class