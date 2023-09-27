<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategories
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategories))
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.panel_total_customers = New System.Windows.Forms.Panel()
        Me.lblTotalCategories = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txt_searchbox = New System.Windows.Forms.TextBox()
        Me.label_search = New System.Windows.Forms.Label()
        Me.panel_datagridview = New System.Windows.Forms.Panel()
        Me.xDataGrid = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._viewBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.table_datagridview = New System.Windows.Forms.TableLayoutPanel()
        Me.panel_chart = New System.Windows.Forms.Panel()
        Me.chartTopCategories = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.menuBar = New System.Windows.Forms.MenuStrip()
        Me.menuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.panel_body.SuspendLayout()
        Me.panel_total_customers.SuspendLayout()
        Me.panel_datagridview.SuspendLayout()
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.table_datagridview.SuspendLayout()
        Me.panel_chart.SuspendLayout()
        CType(Me.chartTopCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 671)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(992, 5)
        Me.panel_bottom.TabIndex = 30
        '
        'panel_body
        '
        Me.panel_body.Controls.Add(Me.panel_total_customers)
        Me.panel_body.Controls.Add(Me.txtID)
        Me.panel_body.Controls.Add(Me.txt_searchbox)
        Me.panel_body.Controls.Add(Me.label_search)
        Me.panel_body.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_body.Location = New System.Drawing.Point(0, 40)
        Me.panel_body.Name = "panel_body"
        Me.panel_body.Size = New System.Drawing.Size(992, 100)
        Me.panel_body.TabIndex = 32
        '
        'panel_total_customers
        '
        Me.panel_total_customers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_total_customers.BackColor = System.Drawing.SystemColors.Window
        Me.panel_total_customers.Controls.Add(Me.lblTotalCategories)
        Me.panel_total_customers.Controls.Add(Me.Label6)
        Me.panel_total_customers.Location = New System.Drawing.Point(774, 7)
        Me.panel_total_customers.Name = "panel_total_customers"
        Me.panel_total_customers.Padding = New System.Windows.Forms.Padding(5)
        Me.panel_total_customers.Size = New System.Drawing.Size(200, 90)
        Me.panel_total_customers.TabIndex = 6
        '
        'lblTotalCategories
        '
        Me.lblTotalCategories.AutoSize = True
        Me.lblTotalCategories.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotalCategories.Font = New System.Drawing.Font("Helvetica", 20.0!)
        Me.lblTotalCategories.ForeColor = System.Drawing.Color.Black
        Me.lblTotalCategories.Location = New System.Drawing.Point(5, 45)
        Me.lblTotalCategories.Name = "lblTotalCategories"
        Me.lblTotalCategories.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblTotalCategories.Size = New System.Drawing.Size(56, 40)
        Me.lblTotalCategories.TabIndex = 3
        Me.lblTotalCategories.Text = "0"
        Me.lblTotalCategories.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label6.Text = "Total Categories"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Helvetica", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(361, 9)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(106, 39)
        Me.txtID.TabIndex = 3
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'txt_searchbox
        '
        Me.txt_searchbox.Font = New System.Drawing.Font("Helvetica", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchbox.Location = New System.Drawing.Point(28, 47)
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
        Me.label_search.Size = New System.Drawing.Size(185, 28)
        Me.label_search.TabIndex = 2
        Me.label_search.Text = "Category Name:"
        '
        'panel_datagridview
        '
        Me.panel_datagridview.Controls.Add(Me.xDataGrid)
        Me.panel_datagridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_datagridview.Location = New System.Drawing.Point(3, 3)
        Me.panel_datagridview.Name = "panel_datagridview"
        Me.panel_datagridview.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.panel_datagridview.Size = New System.Drawing.Size(390, 525)
        Me.panel_datagridview.TabIndex = 33
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
        Me.xDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me._name, Me._viewBtn})
        Me.xDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xDataGrid.EnableHeadersVisualStyles = False
        Me.xDataGrid.Location = New System.Drawing.Point(10, 5)
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
        Me.xDataGrid.Size = New System.Drawing.Size(370, 515)
        Me.xDataGrid.TabIndex = 1
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
        Me._name.FillWeight = 141.1765!
        Me._name.HeaderText = "Category Name"
        Me._name.MinimumWidth = 6
        Me._name.Name = "_name"
        Me._name.ReadOnly = True
        '
        '_viewBtn
        '
        Me._viewBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me._viewBtn.FillWeight = 58.82353!
        Me._viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._viewBtn.HeaderText = "Action"
        Me._viewBtn.MinimumWidth = 6
        Me._viewBtn.Name = "_viewBtn"
        Me._viewBtn.ReadOnly = True
        Me._viewBtn.Text = "Edit"
        Me._viewBtn.UseColumnTextForButtonValue = True
        Me._viewBtn.Width = 51
        '
        'table_datagridview
        '
        Me.table_datagridview.ColumnCount = 2
        Me.table_datagridview.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.table_datagridview.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.table_datagridview.Controls.Add(Me.panel_datagridview, 0, 0)
        Me.table_datagridview.Controls.Add(Me.panel_chart, 1, 0)
        Me.table_datagridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.table_datagridview.Location = New System.Drawing.Point(0, 140)
        Me.table_datagridview.Name = "table_datagridview"
        Me.table_datagridview.RowCount = 1
        Me.table_datagridview.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.table_datagridview.Size = New System.Drawing.Size(992, 531)
        Me.table_datagridview.TabIndex = 33
        '
        'panel_chart
        '
        Me.panel_chart.Controls.Add(Me.chartTopCategories)
        Me.panel_chart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_chart.Location = New System.Drawing.Point(399, 3)
        Me.panel_chart.Name = "panel_chart"
        Me.panel_chart.Padding = New System.Windows.Forms.Padding(15, 5, 15, 15)
        Me.panel_chart.Size = New System.Drawing.Size(590, 525)
        Me.panel_chart.TabIndex = 34
        '
        'chartTopCategories
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartTopCategories.ChartAreas.Add(ChartArea1)
        Me.chartTopCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Name = "Legend1"
        Me.chartTopCategories.Legends.Add(Legend1)
        Me.chartTopCategories.Location = New System.Drawing.Point(15, 5)
        Me.chartTopCategories.Name = "chartTopCategories"
        Me.chartTopCategories.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.chartTopCategories.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(101, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(12, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(78, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(101, Byte), Integer))}
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
        Me.chartTopCategories.Series.Add(Series1)
        Me.chartTopCategories.Size = New System.Drawing.Size(560, 505)
        Me.chartTopCategories.TabIndex = 5
        Me.chartTopCategories.Text = "Chart1"
        Title1.Alignment = System.Drawing.ContentAlignment.TopLeft
        Title1.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Title1.Name = "Title1"
        Title1.Text = "Top 5 Product Categories"
        Me.chartTopCategories.Titles.Add(Title1)
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
        Me.menuBar.Size = New System.Drawing.Size(992, 40)
        Me.menuBar.TabIndex = 34
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
        Me.menuRefresh.Size = New System.Drawing.Size(362, 30)
        Me.menuRefresh.Text = "Refresh"
        '
        'menuNew
        '
        Me.menuNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuNew.Name = "menuNew"
        Me.menuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.menuNew.Size = New System.Drawing.Size(362, 30)
        Me.menuNew.Text = "Add New Category"
        '
        'menuPrint
        '
        Me.menuPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuPrint.Name = "menuPrint"
        Me.menuPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.menuPrint.Size = New System.Drawing.Size(362, 30)
        Me.menuPrint.Text = "Print"
        '
        'frmCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(992, 676)
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
        Me.Name = "frmCategories"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categories"
        Me.panel_body.ResumeLayout(False)
        Me.panel_body.PerformLayout()
        Me.panel_total_customers.ResumeLayout(False)
        Me.panel_total_customers.PerformLayout()
        Me.panel_datagridview.ResumeLayout(False)
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.table_datagridview.ResumeLayout(False)
        Me.panel_chart.ResumeLayout(False)
        CType(Me.chartTopCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuBar.ResumeLayout(False)
        Me.menuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents panel_body As Panel
    Friend WithEvents txtID As TextBox
    Friend WithEvents txt_searchbox As TextBox
    Friend WithEvents label_search As Label
    Friend WithEvents panel_datagridview As Panel
    Friend WithEvents xDataGrid As DataGridView
    Friend WithEvents table_datagridview As TableLayoutPanel
    Friend WithEvents menuBar As MenuStrip
    Friend WithEvents menuMenu As ToolStripMenuItem
    Friend WithEvents menuRefresh As ToolStripMenuItem
    Friend WithEvents menuNew As ToolStripMenuItem
    Friend WithEvents menuPrint As ToolStripMenuItem
    Friend WithEvents panel_chart As Panel
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents _name As DataGridViewTextBoxColumn
    Friend WithEvents _viewBtn As DataGridViewButtonColumn
    Friend WithEvents panel_total_customers As Panel
    Friend WithEvents lblTotalCategories As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chartTopCategories As DataVisualization.Charting.Chart
End Class
