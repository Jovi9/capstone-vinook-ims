<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSuppliers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                funcSupplier.Dispose()
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuppliers))
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.panel_total_customers = New System.Windows.Forms.Panel()
        Me.lblTotalSuppliers = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txt_searchbox = New System.Windows.Forms.TextBox()
        Me.label_search = New System.Windows.Forms.Label()
        Me.panel_datagridview = New System.Windows.Forms.Panel()
        Me.xDataGrid = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._actionBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.menuBar = New System.Windows.Forms.MenuStrip()
        Me.menuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.table_datagridview = New System.Windows.Forms.TableLayoutPanel()
        Me.panel_chart = New System.Windows.Forms.Panel()
        Me.chartTopSuppliers = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.panel_body.SuspendLayout()
        Me.panel_total_customers.SuspendLayout()
        Me.panel_datagridview.SuspendLayout()
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuBar.SuspendLayout()
        Me.table_datagridview.SuspendLayout()
        Me.panel_chart.SuspendLayout()
        CType(Me.chartTopSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_body
        '
        Me.panel_body.Controls.Add(Me.panel_total_customers)
        Me.panel_body.Controls.Add(Me.txtID)
        Me.panel_body.Controls.Add(Me.txt_searchbox)
        Me.panel_body.Controls.Add(Me.label_search)
        Me.panel_body.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_body.Location = New System.Drawing.Point(0, 40)
        Me.panel_body.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_body.Name = "panel_body"
        Me.panel_body.Size = New System.Drawing.Size(1015, 100)
        Me.panel_body.TabIndex = 6
        '
        'panel_total_customers
        '
        Me.panel_total_customers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_total_customers.BackColor = System.Drawing.SystemColors.Window
        Me.panel_total_customers.Controls.Add(Me.lblTotalSuppliers)
        Me.panel_total_customers.Controls.Add(Me.Label6)
        Me.panel_total_customers.Location = New System.Drawing.Point(797, 7)
        Me.panel_total_customers.Name = "panel_total_customers"
        Me.panel_total_customers.Padding = New System.Windows.Forms.Padding(5)
        Me.panel_total_customers.Size = New System.Drawing.Size(200, 90)
        Me.panel_total_customers.TabIndex = 5
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 13.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Total Suppliers"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Helvetica", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(534, 26)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(105, 39)
        Me.txtID.TabIndex = 3
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'txt_searchbox
        '
        Me.txt_searchbox.Font = New System.Drawing.Font("Helvetica", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchbox.Location = New System.Drawing.Point(28, 47)
        Me.txt_searchbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_searchbox.Name = "txt_searchbox"
        Me.txt_searchbox.Size = New System.Drawing.Size(317, 39)
        Me.txt_searchbox.TabIndex = 0
        '
        'label_search
        '
        Me.label_search.AutoSize = True
        Me.label_search.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_search.Location = New System.Drawing.Point(23, 16)
        Me.label_search.Name = "label_search"
        Me.label_search.Size = New System.Drawing.Size(187, 28)
        Me.label_search.TabIndex = 2
        Me.label_search.Text = "Search Supplier:"
        '
        'panel_datagridview
        '
        Me.panel_datagridview.Controls.Add(Me.xDataGrid)
        Me.panel_datagridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_datagridview.Location = New System.Drawing.Point(3, 2)
        Me.panel_datagridview.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_datagridview.Name = "panel_datagridview"
        Me.panel_datagridview.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.panel_datagridview.Size = New System.Drawing.Size(603, 601)
        Me.panel_datagridview.TabIndex = 11
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
        Me.xDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me._name, Me.address, Me.phone, Me.email, Me._actionBtn})
        Me.xDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xDataGrid.EnableHeadersVisualStyles = False
        Me.xDataGrid.Location = New System.Drawing.Point(10, 5)
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
        Me.xDataGrid.Size = New System.Drawing.Size(583, 591)
        Me.xDataGrid.TabIndex = 0
        Me.xDataGrid.TabStop = False
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.id.Visible = False
        Me.id.Width = 28
        '
        '_name
        '
        Me._name.HeaderText = "Name"
        Me._name.MinimumWidth = 6
        Me._name.Name = "_name"
        Me._name.ReadOnly = True
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.MinimumWidth = 6
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'phone
        '
        Me.phone.HeaderText = "Phone"
        Me.phone.MinimumWidth = 6
        Me.phone.Name = "phone"
        Me.phone.ReadOnly = True
        Me.phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.MinimumWidth = 6
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '_actionBtn
        '
        Me._actionBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me._actionBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._actionBtn.HeaderText = "Action"
        Me._actionBtn.MinimumWidth = 6
        Me._actionBtn.Name = "_actionBtn"
        Me._actionBtn.ReadOnly = True
        Me._actionBtn.Text = "Edit"
        Me._actionBtn.UseColumnTextForButtonValue = True
        Me._actionBtn.Width = 51
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 745)
        Me.panel_bottom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(1015, 5)
        Me.panel_bottom.TabIndex = 28
        '
        'menuBar
        '
        Me.menuBar.AllowMerge = False
        Me.menuBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuBar.Font = New System.Drawing.Font("Helvetica", 13.0!)
        Me.menuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMenu})
        Me.menuBar.Location = New System.Drawing.Point(0, 0)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Padding = New System.Windows.Forms.Padding(10, 5, 0, 5)
        Me.menuBar.Size = New System.Drawing.Size(1015, 40)
        Me.menuBar.TabIndex = 35
        Me.menuBar.Text = "Menu Bar"
        '
        'menuMenu
        '
        Me.menuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuRefresh, Me.menuNew, Me.menuPrint})
        Me.menuMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuMenu.Name = "menuMenu"
        Me.menuMenu.Size = New System.Drawing.Size(80, 30)
        Me.menuMenu.Text = "Menu"
        '
        'menuRefresh
        '
        Me.menuRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuRefresh.Name = "menuRefresh"
        Me.menuRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.menuRefresh.Size = New System.Drawing.Size(354, 30)
        Me.menuRefresh.Text = "Refresh"
        '
        'menuNew
        '
        Me.menuNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuNew.Name = "menuNew"
        Me.menuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.menuNew.Size = New System.Drawing.Size(354, 30)
        Me.menuNew.Text = "Add New Supplier"
        '
        'menuPrint
        '
        Me.menuPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuPrint.Name = "menuPrint"
        Me.menuPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.menuPrint.Size = New System.Drawing.Size(354, 30)
        Me.menuPrint.Text = "Print"
        '
        'table_datagridview
        '
        Me.table_datagridview.ColumnCount = 2
        Me.table_datagridview.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.table_datagridview.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.table_datagridview.Controls.Add(Me.panel_chart, 0, 0)
        Me.table_datagridview.Controls.Add(Me.panel_datagridview, 0, 0)
        Me.table_datagridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.table_datagridview.Location = New System.Drawing.Point(0, 140)
        Me.table_datagridview.Name = "table_datagridview"
        Me.table_datagridview.RowCount = 1
        Me.table_datagridview.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.table_datagridview.Size = New System.Drawing.Size(1015, 605)
        Me.table_datagridview.TabIndex = 36
        '
        'panel_chart
        '
        Me.panel_chart.Controls.Add(Me.chartTopSuppliers)
        Me.panel_chart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_chart.Location = New System.Drawing.Point(612, 3)
        Me.panel_chart.Name = "panel_chart"
        Me.panel_chart.Padding = New System.Windows.Forms.Padding(15, 5, 15, 15)
        Me.panel_chart.Size = New System.Drawing.Size(400, 599)
        Me.panel_chart.TabIndex = 35
        '
        'chartTopSuppliers
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartTopSuppliers.ChartAreas.Add(ChartArea1)
        Me.chartTopSuppliers.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Name = "Legend1"
        Me.chartTopSuppliers.Legends.Add(Legend1)
        Me.chartTopSuppliers.Location = New System.Drawing.Point(15, 5)
        Me.chartTopSuppliers.Name = "chartTopSuppliers"
        Me.chartTopSuppliers.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.chartTopSuppliers.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(101, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(12, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(78, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(101, Byte), Integer))}
        Series1.BorderColor = System.Drawing.Color.White
        Series1.BorderWidth = 6
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Font = New System.Drawing.Font("Helvetica", 13.0!)
        Series1.IsValueShownAsLabel = True
        Series1.LabelForeColor = System.Drawing.Color.WhiteSmoke
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.YValuesPerPoint = 6
        Me.chartTopSuppliers.Series.Add(Series1)
        Me.chartTopSuppliers.Size = New System.Drawing.Size(370, 579)
        Me.chartTopSuppliers.TabIndex = 4
        Me.chartTopSuppliers.Text = "Chart1"
        Title1.Alignment = System.Drawing.ContentAlignment.TopLeft
        Title1.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Title1.Name = "Title1"
        Title1.Text = "Top 5 Suppliers"
        Me.chartTopSuppliers.Titles.Add(Title1)
        '
        'frmSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1015, 750)
        Me.Controls.Add(Me.table_datagridview)
        Me.Controls.Add(Me.panel_body)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.menuBar)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Helvetica", 8.25!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmSuppliers"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suppliers"
        Me.panel_body.ResumeLayout(False)
        Me.panel_body.PerformLayout()
        Me.panel_total_customers.ResumeLayout(False)
        Me.panel_total_customers.PerformLayout()
        Me.panel_datagridview.ResumeLayout(False)
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuBar.ResumeLayout(False)
        Me.menuBar.PerformLayout()
        Me.table_datagridview.ResumeLayout(False)
        Me.panel_chart.ResumeLayout(False)
        CType(Me.chartTopSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel_body As Panel
    Friend WithEvents txt_searchbox As TextBox
    Friend WithEvents label_search As Label
    Friend WithEvents panel_datagridview As Panel
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents txtID As TextBox
    Friend WithEvents xDataGrid As DataGridView
    Friend WithEvents menuBar As MenuStrip
    Friend WithEvents menuMenu As ToolStripMenuItem
    Friend WithEvents menuRefresh As ToolStripMenuItem
    Friend WithEvents menuNew As ToolStripMenuItem
    Friend WithEvents menuPrint As ToolStripMenuItem
    Friend WithEvents table_datagridview As TableLayoutPanel
    Friend WithEvents panel_chart As Panel
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents _name As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents _actionBtn As DataGridViewButtonColumn
    Friend WithEvents panel_total_customers As Panel
    Friend WithEvents lblTotalSuppliers As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chartTopSuppliers As DataVisualization.Charting.Chart
End Class
