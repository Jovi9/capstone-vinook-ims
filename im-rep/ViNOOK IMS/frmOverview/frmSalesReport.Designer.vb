<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesReport))
        Me.panel_date_filter = New System.Windows.Forms.Panel()
        Me.panel_action_date_filter = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.endDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.startDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCustom = New System.Windows.Forms.Button()
        Me.btnThisMonth = New System.Windows.Forms.Button()
        Me.btnLastThirtyDays = New System.Windows.Forms.Button()
        Me.btnLastSevenDays = New System.Windows.Forms.Button()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.panel_dash_totals = New System.Windows.Forms.Panel()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panel_right = New System.Windows.Forms.Panel()
        Me.panel_left = New System.Windows.Forms.Panel()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.panel_main = New System.Windows.Forms.Panel()
        Me.table_panel_main = New System.Windows.Forms.TableLayoutPanel()
        Me.chartAllProductsSold = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartSalesSummary = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.panel_chart_top_products = New System.Windows.Forms.Panel()
        Me.chartTopSellingProducts = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.panel_date_filter.SuspendLayout()
        Me.panel_action_date_filter.SuspendLayout()
        Me.panel_header.SuspendLayout()
        Me.panel_dash_totals.SuspendLayout()
        Me.panel_total_customers.SuspendLayout()
        Me.panel_total_orders.SuspendLayout()
        Me.panel_total_sales.SuspendLayout()
        Me.panel_main.SuspendLayout()
        Me.table_panel_main.SuspendLayout()
        CType(Me.chartAllProductsSold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartSalesSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_chart_top_products.SuspendLayout()
        CType(Me.chartTopSellingProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_date_filter
        '
        Me.panel_date_filter.BackColor = System.Drawing.Color.Transparent
        Me.panel_date_filter.Controls.Add(Me.panel_action_date_filter)
        Me.panel_date_filter.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_date_filter.Location = New System.Drawing.Point(10, 60)
        Me.panel_date_filter.Name = "panel_date_filter"
        Me.panel_date_filter.Padding = New System.Windows.Forms.Padding(15)
        Me.panel_date_filter.Size = New System.Drawing.Size(1803, 70)
        Me.panel_date_filter.TabIndex = 2
        '
        'panel_action_date_filter
        '
        Me.panel_action_date_filter.BackColor = System.Drawing.Color.Transparent
        Me.panel_action_date_filter.Controls.Add(Me.Button1)
        Me.panel_action_date_filter.Controls.Add(Me.btnOk)
        Me.panel_action_date_filter.Controls.Add(Me.endDate)
        Me.panel_action_date_filter.Controls.Add(Me.Label2)
        Me.panel_action_date_filter.Controls.Add(Me.startDate)
        Me.panel_action_date_filter.Controls.Add(Me.Label1)
        Me.panel_action_date_filter.Controls.Add(Me.btnCustom)
        Me.panel_action_date_filter.Controls.Add(Me.btnThisMonth)
        Me.panel_action_date_filter.Controls.Add(Me.btnLastThirtyDays)
        Me.panel_action_date_filter.Controls.Add(Me.btnLastSevenDays)
        Me.panel_action_date_filter.Controls.Add(Me.btnToday)
        Me.panel_action_date_filter.Controls.Add(Me.btnAll)
        Me.panel_action_date_filter.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_action_date_filter.ForeColor = System.Drawing.Color.Black
        Me.panel_action_date_filter.Location = New System.Drawing.Point(15, 15)
        Me.panel_action_date_filter.Name = "panel_action_date_filter"
        Me.panel_action_date_filter.Size = New System.Drawing.Size(1773, 40)
        Me.panel_action_date_filter.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Helvetica", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1593, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 40)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "PRINT"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOk.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOk.Enabled = False
        Me.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Helvetica", 10.0!)
        Me.btnOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnOk.Location = New System.Drawing.Point(1488, 0)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(50, 40)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'endDate
        '
        Me.endDate.CustomFormat = "MMM dd, yyyy"
        Me.endDate.Dock = System.Windows.Forms.DockStyle.Left
        Me.endDate.Enabled = False
        Me.endDate.Font = New System.Drawing.Font("Helvetica", 14.0!)
        Me.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endDate.Location = New System.Drawing.Point(1278, 0)
        Me.endDate.Name = "endDate"
        Me.endDate.Size = New System.Drawing.Size(210, 35)
        Me.endDate.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1225, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 30)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "To: "
        '
        'startDate
        '
        Me.startDate.CustomFormat = "MMM dd, yyyy"
        Me.startDate.Dock = System.Windows.Forms.DockStyle.Left
        Me.startDate.Enabled = False
        Me.startDate.Font = New System.Drawing.Font("Helvetica", 14.0!)
        Me.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.startDate.Location = New System.Drawing.Point(1015, 0)
        Me.startDate.Name = "startDate"
        Me.startDate.Size = New System.Drawing.Size(210, 35)
        Me.startDate.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(930, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "From: "
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
        Me.btnCustom.Location = New System.Drawing.Point(775, 0)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(155, 40)
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
        Me.btnThisMonth.Location = New System.Drawing.Point(620, 0)
        Me.btnThisMonth.Name = "btnThisMonth"
        Me.btnThisMonth.Size = New System.Drawing.Size(155, 40)
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
        Me.btnLastThirtyDays.Location = New System.Drawing.Point(465, 0)
        Me.btnLastThirtyDays.Name = "btnLastThirtyDays"
        Me.btnLastThirtyDays.Size = New System.Drawing.Size(155, 40)
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
        Me.btnLastSevenDays.Location = New System.Drawing.Point(310, 0)
        Me.btnLastSevenDays.Name = "btnLastSevenDays"
        Me.btnLastSevenDays.Size = New System.Drawing.Size(155, 40)
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
        Me.btnToday.Location = New System.Drawing.Point(155, 0)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(155, 40)
        Me.btnToday.TabIndex = 0
        Me.btnToday.Text = "Today"
        Me.btnToday.UseVisualStyleBackColor = False
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.Transparent
        Me.btnAll.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAll.Font = New System.Drawing.Font("Helvetica", 10.0!)
        Me.btnAll.ForeColor = System.Drawing.Color.Black
        Me.btnAll.Location = New System.Drawing.Point(0, 0)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(155, 40)
        Me.btnAll.TabIndex = 10
        Me.btnAll.Text = "All Sales"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_header.Controls.Add(Me.btn_close)
        Me.panel_header.Controls.Add(Me.lable_header_title)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(1823, 60)
        Me.panel_header.TabIndex = 37
        '
        'btn_close
        '
        Me.btn_close.AutoSize = True
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_close.Location = New System.Drawing.Point(1759, 0)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btn_close.Size = New System.Drawing.Size(64, 60)
        Me.btn_close.TabIndex = 13
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "r"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'lable_header_title
        '
        Me.lable_header_title.AutoSize = True
        Me.lable_header_title.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable_header_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lable_header_title.Location = New System.Drawing.Point(11, 10)
        Me.lable_header_title.Name = "lable_header_title"
        Me.lable_header_title.Size = New System.Drawing.Size(214, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "Sales Report"
        '
        'panel_dash_totals
        '
        Me.panel_dash_totals.Controls.Add(Me.panel_total_customers)
        Me.panel_dash_totals.Controls.Add(Me.panel_separatorB)
        Me.panel_dash_totals.Controls.Add(Me.panel_total_orders)
        Me.panel_dash_totals.Controls.Add(Me.panel_separatorA)
        Me.panel_dash_totals.Controls.Add(Me.panel_total_sales)
        Me.panel_dash_totals.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_dash_totals.Location = New System.Drawing.Point(10, 130)
        Me.panel_dash_totals.Name = "panel_dash_totals"
        Me.panel_dash_totals.Padding = New System.Windows.Forms.Padding(10)
        Me.panel_dash_totals.Size = New System.Drawing.Size(1803, 110)
        Me.panel_dash_totals.TabIndex = 38
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
        Me.panel_total_sales.Controls.Add(Me.Label3)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 13.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Sales"
        '
        'panel_right
        '
        Me.panel_right.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_right.Location = New System.Drawing.Point(1813, 60)
        Me.panel_right.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_right.Name = "panel_right"
        Me.panel_right.Size = New System.Drawing.Size(10, 687)
        Me.panel_right.TabIndex = 40
        '
        'panel_left
        '
        Me.panel_left.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_left.Location = New System.Drawing.Point(0, 60)
        Me.panel_left.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_left.Name = "panel_left"
        Me.panel_left.Size = New System.Drawing.Size(10, 687)
        Me.panel_left.TabIndex = 41
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(10, 737)
        Me.panel_bottom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(1803, 10)
        Me.panel_bottom.TabIndex = 42
        '
        'panel_main
        '
        Me.panel_main.Controls.Add(Me.table_panel_main)
        Me.panel_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_main.Location = New System.Drawing.Point(10, 240)
        Me.panel_main.Name = "panel_main"
        Me.panel_main.Padding = New System.Windows.Forms.Padding(20)
        Me.panel_main.Size = New System.Drawing.Size(1299, 497)
        Me.panel_main.TabIndex = 43
        '
        'table_panel_main
        '
        Me.table_panel_main.ColumnCount = 1
        Me.table_panel_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_panel_main.Controls.Add(Me.chartAllProductsSold, 0, 1)
        Me.table_panel_main.Controls.Add(Me.chartSalesSummary, 0, 0)
        Me.table_panel_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.table_panel_main.Location = New System.Drawing.Point(20, 20)
        Me.table_panel_main.Name = "table_panel_main"
        Me.table_panel_main.RowCount = 2
        Me.table_panel_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_panel_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_panel_main.Size = New System.Drawing.Size(1259, 457)
        Me.table_panel_main.TabIndex = 0
        '
        'chartAllProductsSold
        '
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.IntervalOffset = 1.0R
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.ScaleView.Size = 10.0R
        ChartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.Gray
        ChartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        ChartArea1.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll
        ChartArea1.AxisX.ScrollBar.IsPositionedInside = False
        ChartArea1.Name = "ChartArea1"
        Me.chartAllProductsSold.ChartAreas.Add(ChartArea1)
        Me.chartAllProductsSold.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Name = "Legend1"
        Me.chartAllProductsSold.Legends.Add(Legend1)
        Me.chartAllProductsSold.Location = New System.Drawing.Point(3, 231)
        Me.chartAllProductsSold.Name = "chartAllProductsSold"
        Me.chartAllProductsSold.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.chartAllProductsSold.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(138, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(219, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(161, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(152, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(201, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(192, Byte), Integer))}
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Series1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Series1.ChartArea = "ChartArea1"
        Series1.Font = Nothing
        Series1.Legend = "Legend1"
        Series1.Name = "Number of Products Sold"
        Series1.YValuesPerPoint = 4
        Me.chartAllProductsSold.Series.Add(Series1)
        Me.chartAllProductsSold.Size = New System.Drawing.Size(1253, 223)
        Me.chartAllProductsSold.TabIndex = 3
        Me.chartAllProductsSold.Text = "Chart1"
        Title1.Alignment = System.Drawing.ContentAlignment.TopLeft
        Title1.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Title1.Name = "Title1"
        Title1.Text = "Products Sold"
        Me.chartAllProductsSold.Titles.Add(Title1)
        '
        'chartSalesSummary
        '
        ChartArea2.AxisX.IsMarginVisible = False
        ChartArea2.Name = "ChartArea1"
        Me.chartSalesSummary.ChartAreas.Add(ChartArea2)
        Me.chartSalesSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.Name = "Legend1"
        Me.chartSalesSummary.Legends.Add(Legend2)
        Me.chartSalesSummary.Location = New System.Drawing.Point(3, 3)
        Me.chartSalesSummary.Name = "chartSalesSummary"
        Me.chartSalesSummary.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.chartSalesSummary.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.SeaGreen, System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(190, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(204, Byte), Integer)), System.Drawing.Color.Lime, System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(214, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(234, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(227, Byte), Integer))}
        Series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Series2.BackSecondaryColor = System.Drawing.Color.LimeGreen
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
        Series2.Font = Nothing
        Series2.Legend = "Legend1"
        Series2.Name = "Sales"
        Series2.ShadowColor = System.Drawing.Color.Empty
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
        Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.chartSalesSummary.Series.Add(Series2)
        Me.chartSalesSummary.Size = New System.Drawing.Size(1253, 222)
        Me.chartSalesSummary.TabIndex = 2
        Me.chartSalesSummary.Text = "Chart1"
        Title2.Alignment = System.Drawing.ContentAlignment.TopLeft
        Title2.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Title2.Name = "Title1"
        Title2.Text = "Sales by Date"
        Me.chartSalesSummary.Titles.Add(Title2)
        '
        'panel_chart_top_products
        '
        Me.panel_chart_top_products.Controls.Add(Me.chartTopSellingProducts)
        Me.panel_chart_top_products.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_chart_top_products.Location = New System.Drawing.Point(1309, 240)
        Me.panel_chart_top_products.Name = "panel_chart_top_products"
        Me.panel_chart_top_products.Padding = New System.Windows.Forms.Padding(20)
        Me.panel_chart_top_products.Size = New System.Drawing.Size(504, 497)
        Me.panel_chart_top_products.TabIndex = 44
        '
        'chartTopSellingProducts
        '
        ChartArea3.Name = "ChartArea1"
        Me.chartTopSellingProducts.ChartAreas.Add(ChartArea3)
        Me.chartTopSellingProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend3.Name = "Legend1"
        Me.chartTopSellingProducts.Legends.Add(Legend3)
        Me.chartTopSellingProducts.Location = New System.Drawing.Point(20, 20)
        Me.chartTopSellingProducts.Name = "chartTopSellingProducts"
        Me.chartTopSellingProducts.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.chartTopSellingProducts.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(101, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(12, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(78, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(101, Byte), Integer))}
        Series3.BorderColor = System.Drawing.Color.White
        Series3.BorderWidth = 6
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series3.Font = New System.Drawing.Font("Helvetica", 13.0!)
        Series3.IsValueShownAsLabel = True
        Series3.LabelForeColor = System.Drawing.Color.WhiteSmoke
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Series3.YValuesPerPoint = 6
        Me.chartTopSellingProducts.Series.Add(Series3)
        Me.chartTopSellingProducts.Size = New System.Drawing.Size(464, 457)
        Me.chartTopSellingProducts.TabIndex = 2
        Me.chartTopSellingProducts.Text = "Chart1"
        Title3.Alignment = System.Drawing.ContentAlignment.TopLeft
        Title3.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Title3.Name = "Title1"
        Title3.Text = "Top 5 Products Sold"
        Me.chartTopSellingProducts.Titles.Add(Title3)
        '
        'frmSalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1823, 747)
        Me.Controls.Add(Me.panel_main)
        Me.Controls.Add(Me.panel_chart_top_products)
        Me.Controls.Add(Me.panel_dash_totals)
        Me.Controls.Add(Me.panel_date_filter)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.panel_left)
        Me.Controls.Add(Me.panel_right)
        Me.Controls.Add(Me.panel_header)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmSalesReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Report"
        Me.panel_date_filter.ResumeLayout(False)
        Me.panel_action_date_filter.ResumeLayout(False)
        Me.panel_action_date_filter.PerformLayout()
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panel_dash_totals.ResumeLayout(False)
        Me.panel_total_customers.ResumeLayout(False)
        Me.panel_total_customers.PerformLayout()
        Me.panel_total_orders.ResumeLayout(False)
        Me.panel_total_orders.PerformLayout()
        Me.panel_total_sales.ResumeLayout(False)
        Me.panel_total_sales.PerformLayout()
        Me.panel_main.ResumeLayout(False)
        Me.table_panel_main.ResumeLayout(False)
        CType(Me.chartAllProductsSold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartSalesSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_chart_top_products.ResumeLayout(False)
        CType(Me.chartTopSellingProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_date_filter As Panel
    Friend WithEvents panel_action_date_filter As Panel
    Friend WithEvents btnOk As Button
    Friend WithEvents endDate As DateTimePicker
    Friend WithEvents startDate As DateTimePicker
    Friend WithEvents btnCustom As Button
    Friend WithEvents btnThisMonth As Button
    Friend WithEvents btnLastThirtyDays As Button
    Friend WithEvents btnLastSevenDays As Button
    Friend WithEvents btnToday As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents panel_header As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents lable_header_title As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents panel_dash_totals As Panel
    Friend WithEvents panel_total_customers As Panel
    Friend WithEvents lblTotalCustomers As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents panel_separatorB As Panel
    Friend WithEvents panel_total_orders As Panel
    Friend WithEvents lblTotalOrders As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents panel_separatorA As Panel
    Friend WithEvents panel_total_sales As Panel
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents panel_right As Panel
    Friend WithEvents panel_left As Panel
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents panel_main As Panel
    Friend WithEvents table_panel_main As TableLayoutPanel
    Friend WithEvents chartSalesSummary As DataVisualization.Charting.Chart
    Friend WithEvents panel_chart_top_products As Panel
    Friend WithEvents chartTopSellingProducts As DataVisualization.Charting.Chart
    Friend WithEvents btnAll As Button
    Friend WithEvents chartAllProductsSold As DataVisualization.Charting.Chart
End Class
