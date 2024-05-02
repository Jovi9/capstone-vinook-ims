<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOverview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOverview))
        Me.panel_action_date_filter = New System.Windows.Forms.Panel()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.endDate = New System.Windows.Forms.DateTimePicker()
        Me.startDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCustom = New System.Windows.Forms.Button()
        Me.btnThisMonth = New System.Windows.Forms.Button()
        Me.btnLastThirtyDays = New System.Windows.Forms.Button()
        Me.btnLastSevenDays = New System.Windows.Forms.Button()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.panel_date_filter = New System.Windows.Forms.Panel()
        Me.chartTopSellingProducts = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.panel_dash_totals = New System.Windows.Forms.Panel()
        Me.panel_stocks_avaialbe = New System.Windows.Forms.Panel()
        Me.lblTotalStocksAvailable = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.panel_separatorE = New System.Windows.Forms.Panel()
        Me.panel_total_products = New System.Windows.Forms.Panel()
        Me.lblTotalProducts = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.panel_separatorD = New System.Windows.Forms.Panel()
        Me.panel_total_suppliers = New System.Windows.Forms.Panel()
        Me.lblTotalSuppliers = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panel_separatorC = New System.Windows.Forms.Panel()
        Me.panel_total_customers = New System.Windows.Forms.Panel()
        Me.lblTotalCustomers = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panel_separatorB = New System.Windows.Forms.Panel()
        Me.panel_total_orders = New System.Windows.Forms.Panel()
        Me.lblTotalOrders = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panel_separatorA = New System.Windows.Forms.Panel()
        Me.panel_total_sales = New System.Windows.Forms.Panel()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_chart_top_products = New System.Windows.Forms.Panel()
        Me.panel_main = New System.Windows.Forms.Panel()
        Me.table_panel_main = New System.Windows.Forms.TableLayoutPanel()
        Me.chartSalesSummary = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.table_panel_second_row = New System.Windows.Forms.TableLayoutPanel()
        Me.panel_datagridview = New System.Windows.Forms.Panel()
        Me.xDataGrid = New System.Windows.Forms.DataGridView()
        Me._productName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._available = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.table_lowstock = New System.Windows.Forms.TableLayoutPanel()
        Me.btnViewAllLowStock = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel_action_date_filter.SuspendLayout()
        Me.panel_date_filter.SuspendLayout()
        CType(Me.chartTopSellingProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_dash_totals.SuspendLayout()
        Me.panel_stocks_avaialbe.SuspendLayout()
        Me.panel_total_products.SuspendLayout()
        Me.panel_total_suppliers.SuspendLayout()
        Me.panel_total_customers.SuspendLayout()
        Me.panel_total_orders.SuspendLayout()
        Me.panel_total_sales.SuspendLayout()
        Me.panel_chart_top_products.SuspendLayout()
        Me.panel_main.SuspendLayout()
        Me.table_panel_main.SuspendLayout()
        CType(Me.chartSalesSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.table_panel_second_row.SuspendLayout()
        Me.panel_datagridview.SuspendLayout()
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.table_lowstock.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_action_date_filter
        '
        Me.panel_action_date_filter.BackColor = System.Drawing.Color.Transparent
        Me.panel_action_date_filter.Controls.Add(Me.btnOk)
        Me.panel_action_date_filter.Controls.Add(Me.endDate)
        Me.panel_action_date_filter.Controls.Add(Me.startDate)
        Me.panel_action_date_filter.Controls.Add(Me.btnCustom)
        Me.panel_action_date_filter.Controls.Add(Me.btnThisMonth)
        Me.panel_action_date_filter.Controls.Add(Me.btnLastThirtyDays)
        Me.panel_action_date_filter.Controls.Add(Me.btnLastSevenDays)
        Me.panel_action_date_filter.Controls.Add(Me.btnToday)
        Me.panel_action_date_filter.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_action_date_filter.ForeColor = System.Drawing.Color.Black
        Me.panel_action_date_filter.Location = New System.Drawing.Point(15, 15)
        Me.panel_action_date_filter.Name = "panel_action_date_filter"
        Me.panel_action_date_filter.Size = New System.Drawing.Size(1488, 50)
        Me.panel_action_date_filter.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOk.Enabled = False
        Me.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Helvetica", 10.0!)
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.Location = New System.Drawing.Point(700, 0)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(50, 50)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'endDate
        '
        Me.endDate.CustomFormat = "MMM dd, yyyy"
        Me.endDate.Enabled = False
        Me.endDate.Font = New System.Drawing.Font("Helvetica", 12.0!)
        Me.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endDate.Location = New System.Drawing.Point(1014, 10)
        Me.endDate.Name = "endDate"
        Me.endDate.Size = New System.Drawing.Size(200, 31)
        Me.endDate.TabIndex = 7
        '
        'startDate
        '
        Me.startDate.CustomFormat = "MMM dd, yyyy"
        Me.startDate.Enabled = False
        Me.startDate.Font = New System.Drawing.Font("Helvetica", 12.0!)
        Me.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.startDate.Location = New System.Drawing.Point(771, 10)
        Me.startDate.Name = "startDate"
        Me.startDate.Size = New System.Drawing.Size(200, 31)
        Me.startDate.TabIndex = 6
        '
        'btnCustom
        '
        Me.btnCustom.BackColor = System.Drawing.Color.Transparent
        Me.btnCustom.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCustom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnCustom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustom.Font = New System.Drawing.Font("Helvetica", 10.0!)
        Me.btnCustom.ForeColor = System.Drawing.Color.Black
        Me.btnCustom.Location = New System.Drawing.Point(560, 0)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(140, 50)
        Me.btnCustom.TabIndex = 4
        Me.btnCustom.Text = "Custom"
        Me.btnCustom.UseVisualStyleBackColor = False
        '
        'btnThisMonth
        '
        Me.btnThisMonth.BackColor = System.Drawing.Color.Transparent
        Me.btnThisMonth.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnThisMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnThisMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThisMonth.Font = New System.Drawing.Font("Helvetica", 10.0!)
        Me.btnThisMonth.ForeColor = System.Drawing.Color.Black
        Me.btnThisMonth.Location = New System.Drawing.Point(420, 0)
        Me.btnThisMonth.Name = "btnThisMonth"
        Me.btnThisMonth.Size = New System.Drawing.Size(140, 50)
        Me.btnThisMonth.TabIndex = 3
        Me.btnThisMonth.Text = "This Month"
        Me.btnThisMonth.UseVisualStyleBackColor = False
        '
        'btnLastThirtyDays
        '
        Me.btnLastThirtyDays.BackColor = System.Drawing.Color.Transparent
        Me.btnLastThirtyDays.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLastThirtyDays.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnLastThirtyDays.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnLastThirtyDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLastThirtyDays.Font = New System.Drawing.Font("Helvetica", 10.0!)
        Me.btnLastThirtyDays.ForeColor = System.Drawing.Color.Black
        Me.btnLastThirtyDays.Location = New System.Drawing.Point(280, 0)
        Me.btnLastThirtyDays.Name = "btnLastThirtyDays"
        Me.btnLastThirtyDays.Size = New System.Drawing.Size(140, 50)
        Me.btnLastThirtyDays.TabIndex = 2
        Me.btnLastThirtyDays.Text = "Last 30 Days"
        Me.btnLastThirtyDays.UseVisualStyleBackColor = False
        '
        'btnLastSevenDays
        '
        Me.btnLastSevenDays.BackColor = System.Drawing.Color.Transparent
        Me.btnLastSevenDays.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLastSevenDays.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnLastSevenDays.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnLastSevenDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLastSevenDays.Font = New System.Drawing.Font("Helvetica", 10.0!)
        Me.btnLastSevenDays.ForeColor = System.Drawing.Color.Black
        Me.btnLastSevenDays.Location = New System.Drawing.Point(140, 0)
        Me.btnLastSevenDays.Name = "btnLastSevenDays"
        Me.btnLastSevenDays.Size = New System.Drawing.Size(140, 50)
        Me.btnLastSevenDays.TabIndex = 1
        Me.btnLastSevenDays.Text = "Last 7 Days"
        Me.btnLastSevenDays.UseVisualStyleBackColor = False
        '
        'btnToday
        '
        Me.btnToday.BackColor = System.Drawing.Color.Transparent
        Me.btnToday.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnToday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToday.Font = New System.Drawing.Font("Helvetica", 10.0!)
        Me.btnToday.ForeColor = System.Drawing.Color.Black
        Me.btnToday.Location = New System.Drawing.Point(0, 0)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(140, 50)
        Me.btnToday.TabIndex = 0
        Me.btnToday.Text = "Today"
        Me.btnToday.UseVisualStyleBackColor = False
        '
        'panel_date_filter
        '
        Me.panel_date_filter.BackColor = System.Drawing.Color.Transparent
        Me.panel_date_filter.Controls.Add(Me.panel_action_date_filter)
        Me.panel_date_filter.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_date_filter.Location = New System.Drawing.Point(0, 0)
        Me.panel_date_filter.Name = "panel_date_filter"
        Me.panel_date_filter.Padding = New System.Windows.Forms.Padding(15)
        Me.panel_date_filter.Size = New System.Drawing.Size(1518, 80)
        Me.panel_date_filter.TabIndex = 1
        '
        'chartTopSellingProducts
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartTopSellingProducts.ChartAreas.Add(ChartArea1)
        Me.chartTopSellingProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Name = "Legend1"
        Me.chartTopSellingProducts.Legends.Add(Legend1)
        Me.chartTopSellingProducts.Location = New System.Drawing.Point(20, 20)
        Me.chartTopSellingProducts.Name = "chartTopSellingProducts"
        Series1.BorderColor = System.Drawing.Color.Black
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Font = New System.Drawing.Font("Helvetica", 10.0!)
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.YValuesPerPoint = 6
        Me.chartTopSellingProducts.Series.Add(Series1)
        Me.chartTopSellingProducts.Size = New System.Drawing.Size(464, 517)
        Me.chartTopSellingProducts.TabIndex = 2
        Me.chartTopSellingProducts.Text = "Chart1"
        Title1.Alignment = System.Drawing.ContentAlignment.TopLeft
        Title1.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Title1.Name = "Title1"
        Title1.Text = "Top 5 Products"
        Me.chartTopSellingProducts.Titles.Add(Title1)
        '
        'panel_dash_totals
        '
        Me.panel_dash_totals.Controls.Add(Me.panel_stocks_avaialbe)
        Me.panel_dash_totals.Controls.Add(Me.panel_separatorE)
        Me.panel_dash_totals.Controls.Add(Me.panel_total_products)
        Me.panel_dash_totals.Controls.Add(Me.panel_separatorD)
        Me.panel_dash_totals.Controls.Add(Me.panel_total_suppliers)
        Me.panel_dash_totals.Controls.Add(Me.panel_separatorC)
        Me.panel_dash_totals.Controls.Add(Me.panel_total_customers)
        Me.panel_dash_totals.Controls.Add(Me.panel_separatorB)
        Me.panel_dash_totals.Controls.Add(Me.panel_total_orders)
        Me.panel_dash_totals.Controls.Add(Me.panel_separatorA)
        Me.panel_dash_totals.Controls.Add(Me.panel_total_sales)
        Me.panel_dash_totals.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_dash_totals.Location = New System.Drawing.Point(0, 80)
        Me.panel_dash_totals.Name = "panel_dash_totals"
        Me.panel_dash_totals.Padding = New System.Windows.Forms.Padding(10)
        Me.panel_dash_totals.Size = New System.Drawing.Size(1518, 110)
        Me.panel_dash_totals.TabIndex = 2
        '
        'panel_stocks_avaialbe
        '
        Me.panel_stocks_avaialbe.BackColor = System.Drawing.SystemColors.Window
        Me.panel_stocks_avaialbe.Controls.Add(Me.lblTotalStocksAvailable)
        Me.panel_stocks_avaialbe.Controls.Add(Me.Label12)
        Me.panel_stocks_avaialbe.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_stocks_avaialbe.Location = New System.Drawing.Point(1285, 10)
        Me.panel_stocks_avaialbe.Name = "panel_stocks_avaialbe"
        Me.panel_stocks_avaialbe.Padding = New System.Windows.Forms.Padding(5)
        Me.panel_stocks_avaialbe.Size = New System.Drawing.Size(200, 90)
        Me.panel_stocks_avaialbe.TabIndex = 9
        '
        'lblTotalStocksAvailable
        '
        Me.lblTotalStocksAvailable.AutoSize = True
        Me.lblTotalStocksAvailable.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotalStocksAvailable.Font = New System.Drawing.Font("Helvetica", 20.0!)
        Me.lblTotalStocksAvailable.ForeColor = System.Drawing.Color.Black
        Me.lblTotalStocksAvailable.Location = New System.Drawing.Point(5, 45)
        Me.lblTotalStocksAvailable.Name = "lblTotalStocksAvailable"
        Me.lblTotalStocksAvailable.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblTotalStocksAvailable.Size = New System.Drawing.Size(56, 40)
        Me.lblTotalStocksAvailable.TabIndex = 3
        Me.lblTotalStocksAvailable.Text = "0"
        Me.lblTotalStocksAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Helvetica", 13.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(5, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(172, 26)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Stocks Available"
        '
        'panel_separatorE
        '
        Me.panel_separatorE.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_separatorE.Location = New System.Drawing.Point(1270, 10)
        Me.panel_separatorE.Name = "panel_separatorE"
        Me.panel_separatorE.Size = New System.Drawing.Size(15, 90)
        Me.panel_separatorE.TabIndex = 10
        '
        'panel_total_products
        '
        Me.panel_total_products.BackColor = System.Drawing.SystemColors.Window
        Me.panel_total_products.Controls.Add(Me.lblTotalProducts)
        Me.panel_total_products.Controls.Add(Me.Label10)
        Me.panel_total_products.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_total_products.Location = New System.Drawing.Point(1070, 10)
        Me.panel_total_products.Name = "panel_total_products"
        Me.panel_total_products.Padding = New System.Windows.Forms.Padding(5)
        Me.panel_total_products.Size = New System.Drawing.Size(200, 90)
        Me.panel_total_products.TabIndex = 7
        '
        'lblTotalProducts
        '
        Me.lblTotalProducts.AutoSize = True
        Me.lblTotalProducts.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotalProducts.Font = New System.Drawing.Font("Helvetica", 20.0!)
        Me.lblTotalProducts.ForeColor = System.Drawing.Color.Black
        Me.lblTotalProducts.Location = New System.Drawing.Point(5, 45)
        Me.lblTotalProducts.Name = "lblTotalProducts"
        Me.lblTotalProducts.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblTotalProducts.Size = New System.Drawing.Size(56, 40)
        Me.lblTotalProducts.TabIndex = 3
        Me.lblTotalProducts.Text = "0"
        Me.lblTotalProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Helvetica", 13.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(5, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 26)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Total Products"
        '
        'panel_separatorD
        '
        Me.panel_separatorD.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_separatorD.Location = New System.Drawing.Point(1055, 10)
        Me.panel_separatorD.Name = "panel_separatorD"
        Me.panel_separatorD.Size = New System.Drawing.Size(15, 90)
        Me.panel_separatorD.TabIndex = 8
        '
        'panel_total_suppliers
        '
        Me.panel_total_suppliers.BackColor = System.Drawing.SystemColors.Window
        Me.panel_total_suppliers.Controls.Add(Me.lblTotalSuppliers)
        Me.panel_total_suppliers.Controls.Add(Me.Label8)
        Me.panel_total_suppliers.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_total_suppliers.Location = New System.Drawing.Point(855, 10)
        Me.panel_total_suppliers.Name = "panel_total_suppliers"
        Me.panel_total_suppliers.Padding = New System.Windows.Forms.Padding(5)
        Me.panel_total_suppliers.Size = New System.Drawing.Size(200, 90)
        Me.panel_total_suppliers.TabIndex = 5
        '
        'lblTotalSuppliers
        '
        Me.lblTotalSuppliers.AutoSize = True
        Me.lblTotalSuppliers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotalSuppliers.Font = New System.Drawing.Font("Helvetica", 20.0!)
        Me.lblTotalSuppliers.ForeColor = System.Drawing.Color.Black
        Me.lblTotalSuppliers.Location = New System.Drawing.Point(5, 45)
        Me.lblTotalSuppliers.Name = "lblTotalSuppliers"
        Me.lblTotalSuppliers.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblTotalSuppliers.Size = New System.Drawing.Size(56, 40)
        Me.lblTotalSuppliers.TabIndex = 3
        Me.lblTotalSuppliers.Text = "0"
        Me.lblTotalSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Helvetica", 13.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(5, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 26)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total Suppliers"
        '
        'panel_separatorC
        '
        Me.panel_separatorC.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_separatorC.Location = New System.Drawing.Point(840, 10)
        Me.panel_separatorC.Name = "panel_separatorC"
        Me.panel_separatorC.Size = New System.Drawing.Size(15, 90)
        Me.panel_separatorC.TabIndex = 6
        '
        'panel_total_customers
        '
        Me.panel_total_customers.BackColor = System.Drawing.SystemColors.Window
        Me.panel_total_customers.Controls.Add(Me.lblTotalCustomers)
        Me.panel_total_customers.Controls.Add(Me.Label6)
        Me.panel_total_customers.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_total_customers.Location = New System.Drawing.Point(640, 10)
        Me.panel_total_customers.Name = "panel_total_customers"
        Me.panel_total_customers.Padding = New System.Windows.Forms.Padding(5)
        Me.panel_total_customers.Size = New System.Drawing.Size(200, 90)
        Me.panel_total_customers.TabIndex = 3
        '
        'lblTotalCustomers
        '
        Me.lblTotalCustomers.AutoSize = True
        Me.lblTotalCustomers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotalCustomers.Font = New System.Drawing.Font("Helvetica", 20.0!)
        Me.lblTotalCustomers.ForeColor = System.Drawing.Color.Black
        Me.lblTotalCustomers.Location = New System.Drawing.Point(5, 45)
        Me.lblTotalCustomers.Name = "lblTotalCustomers"
        Me.lblTotalCustomers.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblTotalCustomers.Size = New System.Drawing.Size(56, 40)
        Me.lblTotalCustomers.TabIndex = 3
        Me.lblTotalCustomers.Text = "0"
        Me.lblTotalCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 13.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Total Customers"
        '
        'panel_separatorB
        '
        Me.panel_separatorB.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_separatorB.Location = New System.Drawing.Point(625, 10)
        Me.panel_separatorB.Name = "panel_separatorB"
        Me.panel_separatorB.Size = New System.Drawing.Size(15, 90)
        Me.panel_separatorB.TabIndex = 4
        '
        'panel_total_orders
        '
        Me.panel_total_orders.BackColor = System.Drawing.SystemColors.Window
        Me.panel_total_orders.Controls.Add(Me.lblTotalOrders)
        Me.panel_total_orders.Controls.Add(Me.Label4)
        Me.panel_total_orders.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_total_orders.Location = New System.Drawing.Point(425, 10)
        Me.panel_total_orders.Name = "panel_total_orders"
        Me.panel_total_orders.Padding = New System.Windows.Forms.Padding(5)
        Me.panel_total_orders.Size = New System.Drawing.Size(200, 90)
        Me.panel_total_orders.TabIndex = 1
        '
        'lblTotalOrders
        '
        Me.lblTotalOrders.AutoSize = True
        Me.lblTotalOrders.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotalOrders.Font = New System.Drawing.Font("Helvetica", 20.0!)
        Me.lblTotalOrders.ForeColor = System.Drawing.Color.Black
        Me.lblTotalOrders.Location = New System.Drawing.Point(5, 45)
        Me.lblTotalOrders.Name = "lblTotalOrders"
        Me.lblTotalOrders.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblTotalOrders.Size = New System.Drawing.Size(56, 40)
        Me.lblTotalOrders.TabIndex = 3
        Me.lblTotalOrders.Text = "0"
        Me.lblTotalOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 13.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 26)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total Orders"
        '
        'panel_separatorA
        '
        Me.panel_separatorA.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_separatorA.Location = New System.Drawing.Point(410, 10)
        Me.panel_separatorA.Name = "panel_separatorA"
        Me.panel_separatorA.Size = New System.Drawing.Size(15, 90)
        Me.panel_separatorA.TabIndex = 2
        '
        'panel_total_sales
        '
        Me.panel_total_sales.BackColor = System.Drawing.SystemColors.Window
        Me.panel_total_sales.Controls.Add(Me.lblTotalSales)
        Me.panel_total_sales.Controls.Add(Me.Label1)
        Me.panel_total_sales.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_total_sales.Location = New System.Drawing.Point(10, 10)
        Me.panel_total_sales.Name = "panel_total_sales"
        Me.panel_total_sales.Padding = New System.Windows.Forms.Padding(5)
        Me.panel_total_sales.Size = New System.Drawing.Size(400, 90)
        Me.panel_total_sales.TabIndex = 0
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotalSales.Font = New System.Drawing.Font("Helvetica", 20.0!)
        Me.lblTotalSales.ForeColor = System.Drawing.Color.Black
        Me.lblTotalSales.Location = New System.Drawing.Point(5, 45)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblTotalSales.Size = New System.Drawing.Size(103, 40)
        Me.lblTotalSales.TabIndex = 3
        Me.lblTotalSales.Text = "0.00"
        Me.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 13.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Sales"
        '
        'panel_chart_top_products
        '
        Me.panel_chart_top_products.Controls.Add(Me.chartTopSellingProducts)
        Me.panel_chart_top_products.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_chart_top_products.Location = New System.Drawing.Point(1014, 190)
        Me.panel_chart_top_products.Name = "panel_chart_top_products"
        Me.panel_chart_top_products.Padding = New System.Windows.Forms.Padding(20)
        Me.panel_chart_top_products.Size = New System.Drawing.Size(504, 557)
        Me.panel_chart_top_products.TabIndex = 3
        '
        'panel_main
        '
        Me.panel_main.Controls.Add(Me.table_panel_main)
        Me.panel_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_main.Location = New System.Drawing.Point(0, 190)
        Me.panel_main.Name = "panel_main"
        Me.panel_main.Padding = New System.Windows.Forms.Padding(20)
        Me.panel_main.Size = New System.Drawing.Size(1014, 557)
        Me.panel_main.TabIndex = 1
        '
        'table_panel_main
        '
        Me.table_panel_main.ColumnCount = 1
        Me.table_panel_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_panel_main.Controls.Add(Me.chartSalesSummary, 0, 0)
        Me.table_panel_main.Controls.Add(Me.table_panel_second_row, 0, 1)
        Me.table_panel_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.table_panel_main.Location = New System.Drawing.Point(20, 20)
        Me.table_panel_main.Name = "table_panel_main"
        Me.table_panel_main.RowCount = 2
        Me.table_panel_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_panel_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_panel_main.Size = New System.Drawing.Size(974, 517)
        Me.table_panel_main.TabIndex = 0
        '
        'chartSalesSummary
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartSalesSummary.ChartAreas.Add(ChartArea2)
        Me.chartSalesSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.Name = "Legend1"
        Me.chartSalesSummary.Legends.Add(Legend2)
        Me.chartSalesSummary.Location = New System.Drawing.Point(3, 3)
        Me.chartSalesSummary.Name = "chartSalesSummary"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
        Series2.Font = Nothing
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
        Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.chartSalesSummary.Series.Add(Series2)
        Me.chartSalesSummary.Size = New System.Drawing.Size(968, 252)
        Me.chartSalesSummary.TabIndex = 2
        Me.chartSalesSummary.Text = "Chart1"
        Title2.Alignment = System.Drawing.ContentAlignment.TopLeft
        Title2.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Title2.Name = "Title1"
        Title2.Text = "Sales order by Date"
        Me.chartSalesSummary.Titles.Add(Title2)
        '
        'table_panel_second_row
        '
        Me.table_panel_second_row.BackColor = System.Drawing.SystemColors.Window
        Me.table_panel_second_row.ColumnCount = 2
        Me.table_panel_second_row.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_panel_second_row.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_panel_second_row.Controls.Add(Me.panel_datagridview, 1, 0)
        Me.table_panel_second_row.Dock = System.Windows.Forms.DockStyle.Fill
        Me.table_panel_second_row.Location = New System.Drawing.Point(3, 261)
        Me.table_panel_second_row.Name = "table_panel_second_row"
        Me.table_panel_second_row.RowCount = 1
        Me.table_panel_second_row.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_panel_second_row.Size = New System.Drawing.Size(968, 253)
        Me.table_panel_second_row.TabIndex = 3
        '
        'panel_datagridview
        '
        Me.panel_datagridview.Controls.Add(Me.xDataGrid)
        Me.panel_datagridview.Controls.Add(Me.table_lowstock)
        Me.panel_datagridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_datagridview.Location = New System.Drawing.Point(487, 2)
        Me.panel_datagridview.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_datagridview.Name = "panel_datagridview"
        Me.panel_datagridview.Padding = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.panel_datagridview.Size = New System.Drawing.Size(478, 249)
        Me.panel_datagridview.TabIndex = 12
        '
        'xDataGrid
        '
        Me.xDataGrid.AllowUserToAddRows = False
        Me.xDataGrid.AllowUserToDeleteRows = False
        Me.xDataGrid.AllowUserToResizeColumns = False
        Me.xDataGrid.AllowUserToResizeRows = False
        Me.xDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.xDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.xDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.xDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.xDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.xDataGrid.ColumnHeadersHeight = 40
        Me.xDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.xDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._productName, Me._available})
        Me.xDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xDataGrid.EnableHeadersVisualStyles = False
        Me.xDataGrid.Location = New System.Drawing.Point(10, 55)
        Me.xDataGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.xDataGrid.MultiSelect = False
        Me.xDataGrid.Name = "xDataGrid"
        Me.xDataGrid.ReadOnly = True
        Me.xDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Helvetica", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.xDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.xDataGrid.RowHeadersVisible = False
        Me.xDataGrid.RowHeadersWidth = 30
        Me.xDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.xDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.xDataGrid.RowTemplate.Height = 35
        Me.xDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.xDataGrid.Size = New System.Drawing.Size(468, 194)
        Me.xDataGrid.TabIndex = 0
        Me.xDataGrid.TabStop = False
        '
        '_productName
        '
        Me._productName.HeaderText = "Product Name"
        Me._productName.MinimumWidth = 6
        Me._productName.Name = "_productName"
        Me._productName.ReadOnly = True
        '
        '_available
        '
        Me._available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me._available.HeaderText = "Available"
        Me._available.MinimumWidth = 6
        Me._available.Name = "_available"
        Me._available.ReadOnly = True
        Me._available.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._available.Width = 69
        '
        'table_lowstock
        '
        Me.table_lowstock.ColumnCount = 2
        Me.table_lowstock.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_lowstock.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_lowstock.Controls.Add(Me.btnViewAllLowStock, 0, 0)
        Me.table_lowstock.Controls.Add(Me.Label2, 0, 0)
        Me.table_lowstock.Dock = System.Windows.Forms.DockStyle.Top
        Me.table_lowstock.Location = New System.Drawing.Point(10, 10)
        Me.table_lowstock.Name = "table_lowstock"
        Me.table_lowstock.RowCount = 1
        Me.table_lowstock.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_lowstock.Size = New System.Drawing.Size(468, 45)
        Me.table_lowstock.TabIndex = 1
        '
        'btnViewAllLowStock
        '
        Me.btnViewAllLowStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnViewAllLowStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnViewAllLowStock.FlatAppearance.BorderSize = 0
        Me.btnViewAllLowStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAllLowStock.Font = New System.Drawing.Font("Helvetica", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnViewAllLowStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnViewAllLowStock.Location = New System.Drawing.Point(237, 3)
        Me.btnViewAllLowStock.Name = "btnViewAllLowStock"
        Me.btnViewAllLowStock.Size = New System.Drawing.Size(228, 39)
        Me.btnViewAllLowStock.TabIndex = 49
        Me.btnViewAllLowStock.TabStop = False
        Me.btnViewAllLowStock.Text = "View All"
        Me.btnViewAllLowStock.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Top 5 Low on Stock"
        '
        'frmOverview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1518, 747)
        Me.Controls.Add(Me.panel_main)
        Me.Controls.Add(Me.panel_chart_top_products)
        Me.Controls.Add(Me.panel_dash_totals)
        Me.Controls.Add(Me.panel_date_filter)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmOverview"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Overview"
        Me.panel_action_date_filter.ResumeLayout(False)
        Me.panel_date_filter.ResumeLayout(False)
        CType(Me.chartTopSellingProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_dash_totals.ResumeLayout(False)
        Me.panel_stocks_avaialbe.ResumeLayout(False)
        Me.panel_stocks_avaialbe.PerformLayout()
        Me.panel_total_products.ResumeLayout(False)
        Me.panel_total_products.PerformLayout()
        Me.panel_total_suppliers.ResumeLayout(False)
        Me.panel_total_suppliers.PerformLayout()
        Me.panel_total_customers.ResumeLayout(False)
        Me.panel_total_customers.PerformLayout()
        Me.panel_total_orders.ResumeLayout(False)
        Me.panel_total_orders.PerformLayout()
        Me.panel_total_sales.ResumeLayout(False)
        Me.panel_total_sales.PerformLayout()
        Me.panel_chart_top_products.ResumeLayout(False)
        Me.panel_main.ResumeLayout(False)
        Me.table_panel_main.ResumeLayout(False)
        CType(Me.chartSalesSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.table_panel_second_row.ResumeLayout(False)
        Me.panel_datagridview.ResumeLayout(False)
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.table_lowstock.ResumeLayout(False)
        Me.table_lowstock.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_action_date_filter As Panel
    Friend WithEvents startDate As DateTimePicker
    Friend WithEvents btnThisMonth As Button
    Friend WithEvents endDate As DateTimePicker
    Friend WithEvents btnLastThirtyDays As Button
    Friend WithEvents btnToday As Button
    Friend WithEvents btnLastSevenDays As Button
    Friend WithEvents btnCustom As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents panel_date_filter As Panel
    Friend WithEvents chartTopSellingProducts As DataVisualization.Charting.Chart
    Friend WithEvents panel_dash_totals As Panel
    Friend WithEvents panel_total_sales As Panel
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents panel_total_orders As Panel
    Friend WithEvents lblTotalOrders As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents panel_separatorA As Panel
    Friend WithEvents panel_total_customers As Panel
    Friend WithEvents lblTotalCustomers As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents panel_separatorB As Panel
    Friend WithEvents panel_total_suppliers As Panel
    Friend WithEvents lblTotalSuppliers As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents panel_separatorC As Panel
    Friend WithEvents panel_stocks_avaialbe As Panel
    Friend WithEvents lblTotalStocksAvailable As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents panel_separatorE As Panel
    Friend WithEvents panel_total_products As Panel
    Friend WithEvents lblTotalProducts As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents panel_separatorD As Panel
    Friend WithEvents panel_chart_top_products As Panel
    Friend WithEvents panel_main As Panel
    Friend WithEvents table_panel_main As TableLayoutPanel
    Friend WithEvents panel_datagridview As Panel
    Friend WithEvents xDataGrid As DataGridView
    Friend WithEvents chartSalesSummary As DataVisualization.Charting.Chart
    Friend WithEvents table_panel_second_row As TableLayoutPanel
    Friend WithEvents _productName As DataGridViewTextBoxColumn
    Friend WithEvents _available As DataGridViewTextBoxColumn
    Friend WithEvents table_lowstock As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnViewAllLowStock As Button
End Class
