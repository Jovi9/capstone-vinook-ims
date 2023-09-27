<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                funcInventory.Dispose()
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.menuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAllItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuBar = New System.Windows.Forms.MenuStrip()
        Me.label_search = New System.Windows.Forms.Label()
        Me.label_category = New System.Windows.Forms.Label()
        Me.txt_searchbox = New System.Windows.Forms.TextBox()
        Me.filter_category = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.checkShowAllProducts = New System.Windows.Forms.CheckBox()
        Me.panel_datagridview = New System.Windows.Forms.Panel()
        Me.xDataGrid = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._itemcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._onHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._viewBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.menuStockReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuBar.SuspendLayout()
        Me.panel_body.SuspendLayout()
        Me.panel_datagridview.SuspendLayout()
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuMenu
        '
        Me.menuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuRefresh, Me.menuNew, Me.menuAllItems, Me.menuPrint})
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
        Me.menuRefresh.Size = New System.Drawing.Size(329, 30)
        Me.menuRefresh.Text = "Refresh"
        '
        'menuNew
        '
        Me.menuNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuNew.Name = "menuNew"
        Me.menuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.menuNew.Size = New System.Drawing.Size(329, 30)
        Me.menuNew.Text = "Add New Stock"
        '
        'menuAllItems
        '
        Me.menuAllItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuAllItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuAllItems.Name = "menuAllItems"
        Me.menuAllItems.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.menuAllItems.Size = New System.Drawing.Size(329, 30)
        Me.menuAllItems.Text = "All Items"
        '
        'menuPrint
        '
        Me.menuPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuPrint.Name = "menuPrint"
        Me.menuPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.menuPrint.Size = New System.Drawing.Size(329, 30)
        Me.menuPrint.Text = "Print"
        '
        'menuBar
        '
        Me.menuBar.AllowMerge = False
        Me.menuBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuBar.Font = New System.Drawing.Font("Helvetica", 13.0!)
        Me.menuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMenu, Me.menuStockReport})
        Me.menuBar.Location = New System.Drawing.Point(0, 0)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Padding = New System.Windows.Forms.Padding(10, 5, 0, 5)
        Me.menuBar.Size = New System.Drawing.Size(1370, 40)
        Me.menuBar.TabIndex = 2
        Me.menuBar.Text = "Menu Bar"
        '
        'label_search
        '
        Me.label_search.AutoSize = True
        Me.label_search.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_search.Location = New System.Drawing.Point(23, 16)
        Me.label_search.Name = "label_search"
        Me.label_search.Size = New System.Drawing.Size(94, 28)
        Me.label_search.TabIndex = 2
        Me.label_search.Text = "Search:"
        '
        'label_category
        '
        Me.label_category.AutoSize = True
        Me.label_category.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_category.Location = New System.Drawing.Point(351, 16)
        Me.label_category.Name = "label_category"
        Me.label_category.Size = New System.Drawing.Size(115, 28)
        Me.label_category.TabIndex = 2
        Me.label_category.Text = "Category:"
        '
        'txt_searchbox
        '
        Me.txt_searchbox.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchbox.Location = New System.Drawing.Point(28, 47)
        Me.txt_searchbox.Name = "txt_searchbox"
        Me.txt_searchbox.Size = New System.Drawing.Size(317, 35)
        Me.txt_searchbox.TabIndex = 0
        '
        'filter_category
        '
        Me.filter_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filter_category.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.filter_category.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filter_category.FormattingEnabled = True
        Me.filter_category.Items.AddRange(New Object() {"--Choose Category--", "Inks", "Laptop"})
        Me.filter_category.Location = New System.Drawing.Point(356, 46)
        Me.filter_category.Name = "filter_category"
        Me.filter_category.Size = New System.Drawing.Size(280, 35)
        Me.filter_category.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(592, 7)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(63, 37)
        Me.txtID.TabIndex = 25
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'panel_body
        '
        Me.panel_body.Controls.Add(Me.checkShowAllProducts)
        Me.panel_body.Controls.Add(Me.txtID)
        Me.panel_body.Controls.Add(Me.filter_category)
        Me.panel_body.Controls.Add(Me.txt_searchbox)
        Me.panel_body.Controls.Add(Me.label_category)
        Me.panel_body.Controls.Add(Me.label_search)
        Me.panel_body.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_body.Location = New System.Drawing.Point(0, 40)
        Me.panel_body.Name = "panel_body"
        Me.panel_body.Size = New System.Drawing.Size(1370, 100)
        Me.panel_body.TabIndex = 4
        '
        'checkShowAllProducts
        '
        Me.checkShowAllProducts.AutoSize = True
        Me.checkShowAllProducts.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkShowAllProducts.Location = New System.Drawing.Point(673, 46)
        Me.checkShowAllProducts.Name = "checkShowAllProducts"
        Me.checkShowAllProducts.Size = New System.Drawing.Size(226, 32)
        Me.checkShowAllProducts.TabIndex = 26
        Me.checkShowAllProducts.Text = "Show All Products"
        Me.checkShowAllProducts.UseVisualStyleBackColor = True
        '
        'panel_datagridview
        '
        Me.panel_datagridview.Controls.Add(Me.xDataGrid)
        Me.panel_datagridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_datagridview.Location = New System.Drawing.Point(0, 140)
        Me.panel_datagridview.Name = "panel_datagridview"
        Me.panel_datagridview.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.panel_datagridview.Size = New System.Drawing.Size(1370, 564)
        Me.panel_datagridview.TabIndex = 2
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.xDataGrid.ColumnHeadersHeight = 40
        Me.xDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.xDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me._itemcode, Me._name, Me._brand, Me._model, Me._category, Me._onHand, Me._unit, Me._price, Me._viewBtn})
        Me.xDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xDataGrid.EnableHeadersVisualStyles = False
        Me.xDataGrid.Location = New System.Drawing.Point(10, 5)
        Me.xDataGrid.MultiSelect = False
        Me.xDataGrid.Name = "xDataGrid"
        Me.xDataGrid.ReadOnly = True
        Me.xDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Helvetica", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.xDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.xDataGrid.RowHeadersVisible = False
        Me.xDataGrid.RowHeadersWidth = 30
        Me.xDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.xDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.xDataGrid.RowTemplate.Height = 35
        Me.xDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.xDataGrid.Size = New System.Drawing.Size(1350, 554)
        Me.xDataGrid.TabIndex = 2
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
        '_itemcode
        '
        Me._itemcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me._itemcode.HeaderText = "Product Code"
        Me._itemcode.MinimumWidth = 6
        Me._itemcode.Name = "_itemcode"
        Me._itemcode.ReadOnly = True
        Me._itemcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._itemcode.Width = 99
        '
        '_name
        '
        Me._name.HeaderText = "Name"
        Me._name.MinimumWidth = 6
        Me._name.Name = "_name"
        Me._name.ReadOnly = True
        '
        '_brand
        '
        Me._brand.HeaderText = "Brand"
        Me._brand.MinimumWidth = 6
        Me._brand.Name = "_brand"
        Me._brand.ReadOnly = True
        '
        '_model
        '
        Me._model.HeaderText = "Model"
        Me._model.MinimumWidth = 6
        Me._model.Name = "_model"
        Me._model.ReadOnly = True
        '
        '_category
        '
        Me._category.HeaderText = "Category"
        Me._category.MinimumWidth = 6
        Me._category.Name = "_category"
        Me._category.ReadOnly = True
        '
        '_onHand
        '
        Me._onHand.HeaderText = "In Stock"
        Me._onHand.MinimumWidth = 6
        Me._onHand.Name = "_onHand"
        Me._onHand.ReadOnly = True
        '
        '_unit
        '
        Me._unit.HeaderText = "Unit"
        Me._unit.MinimumWidth = 6
        Me._unit.Name = "_unit"
        Me._unit.ReadOnly = True
        Me._unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '_price
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me._price.DefaultCellStyle = DataGridViewCellStyle2
        Me._price.HeaderText = "Price"
        Me._price.MinimumWidth = 6
        Me._price.Name = "_price"
        Me._price.ReadOnly = True
        Me._price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '_viewBtn
        '
        Me._viewBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me._viewBtn.DefaultCellStyle = DataGridViewCellStyle3
        Me._viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._viewBtn.HeaderText = "Action"
        Me._viewBtn.MinimumWidth = 6
        Me._viewBtn.Name = "_viewBtn"
        Me._viewBtn.ReadOnly = True
        Me._viewBtn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me._viewBtn.Text = "Edit"
        Me._viewBtn.UseColumnTextForButtonValue = True
        Me._viewBtn.Width = 51
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 704)
        Me.panel_bottom.Margin = New System.Windows.Forms.Padding(2)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(1370, 4)
        Me.panel_bottom.TabIndex = 34
        '
        'menuStockReport
        '
        Me.menuStockReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuStockReport.Name = "menuStockReport"
        Me.menuStockReport.Size = New System.Drawing.Size(152, 30)
        Me.menuStockReport.Text = "Stock Report"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 708)
        Me.Controls.Add(Me.panel_datagridview)
        Me.Controls.Add(Me.panel_body)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.menuBar)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Helvetica", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.menuBar
        Me.Name = "frmInventory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory"
        Me.menuBar.ResumeLayout(False)
        Me.menuBar.PerformLayout()
        Me.panel_body.ResumeLayout(False)
        Me.panel_body.PerformLayout()
        Me.panel_datagridview.ResumeLayout(False)
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuMenu As ToolStripMenuItem
    Friend WithEvents menuRefresh As ToolStripMenuItem
    Friend WithEvents menuNew As ToolStripMenuItem
    Friend WithEvents menuPrint As ToolStripMenuItem
    Friend WithEvents menuBar As MenuStrip
    Friend WithEvents label_search As Label
    Friend WithEvents label_category As Label
    Friend WithEvents txt_searchbox As TextBox
    Friend WithEvents filter_category As ComboBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents panel_body As Panel
    Friend WithEvents panel_datagridview As Panel
    Friend WithEvents xDataGrid As DataGridView
    Friend WithEvents menuAllItems As ToolStripMenuItem
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents checkShowAllProducts As CheckBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents _itemcode As DataGridViewTextBoxColumn
    Friend WithEvents _name As DataGridViewTextBoxColumn
    Friend WithEvents _brand As DataGridViewTextBoxColumn
    Friend WithEvents _model As DataGridViewTextBoxColumn
    Friend WithEvents _category As DataGridViewTextBoxColumn
    Friend WithEvents _onHand As DataGridViewTextBoxColumn
    Friend WithEvents _unit As DataGridViewTextBoxColumn
    Friend WithEvents _price As DataGridViewTextBoxColumn
    Friend WithEvents _viewBtn As DataGridViewButtonColumn
    Friend WithEvents menuStockReport As ToolStripMenuItem
End Class
