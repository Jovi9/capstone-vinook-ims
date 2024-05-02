<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryAllItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventoryAllItems))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.panel_left = New System.Windows.Forms.Panel()
        Me.panel_right = New System.Windows.Forms.Panel()
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.checkFilterAllRange = New System.Windows.Forms.CheckBox()
        Me.filterEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.filterStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dropSupplier = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dropCategory = New System.Windows.Forms.ComboBox()
        Me.txt_searchbox = New System.Windows.Forms.TextBox()
        Me.label_category = New System.Windows.Forms.Label()
        Me.label_search = New System.Windows.Forms.Label()
        Me.panel_datagridview = New System.Windows.Forms.Panel()
        Me.xDataGrid = New System.Windows.Forms.DataGridView()
        Me._detailID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._productID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._itemcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._serialNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._onhand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._markup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._dateIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._reference = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.menuBar = New System.Windows.Forms.MenuStrip()
        Me.menuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAdvanceSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.panel_header.SuspendLayout()
        Me.panel_body.SuspendLayout()
        Me.panel_datagridview.SuspendLayout()
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_header.Controls.Add(Me.btn_close)
        Me.panel_header.Controls.Add(Me.lable_header_title)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(1942, 60)
        Me.panel_header.TabIndex = 5
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
        Me.btn_close.Location = New System.Drawing.Point(1891, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btn_close.Size = New System.Drawing.Size(51, 60)
        Me.btn_close.TabIndex = 11
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
        Me.lable_header_title.Size = New System.Drawing.Size(156, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "Inventory"
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 373)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(1942, 10)
        Me.panel_bottom.TabIndex = 35
        '
        'panel_left
        '
        Me.panel_left.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_left.Location = New System.Drawing.Point(0, 100)
        Me.panel_left.Name = "panel_left"
        Me.panel_left.Size = New System.Drawing.Size(10, 273)
        Me.panel_left.TabIndex = 37
        '
        'panel_right
        '
        Me.panel_right.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_right.Location = New System.Drawing.Point(1932, 100)
        Me.panel_right.Name = "panel_right"
        Me.panel_right.Size = New System.Drawing.Size(10, 273)
        Me.panel_right.TabIndex = 38
        '
        'panel_body
        '
        Me.panel_body.Controls.Add(Me.checkFilterAllRange)
        Me.panel_body.Controls.Add(Me.filterEndDate)
        Me.panel_body.Controls.Add(Me.Label3)
        Me.panel_body.Controls.Add(Me.Label2)
        Me.panel_body.Controls.Add(Me.filterStartDate)
        Me.panel_body.Controls.Add(Me.dropSupplier)
        Me.panel_body.Controls.Add(Me.Label1)
        Me.panel_body.Controls.Add(Me.txtID)
        Me.panel_body.Controls.Add(Me.dropCategory)
        Me.panel_body.Controls.Add(Me.txt_searchbox)
        Me.panel_body.Controls.Add(Me.label_category)
        Me.panel_body.Controls.Add(Me.label_search)
        Me.panel_body.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_body.Location = New System.Drawing.Point(10, 100)
        Me.panel_body.Name = "panel_body"
        Me.panel_body.Size = New System.Drawing.Size(1922, 100)
        Me.panel_body.TabIndex = 39
        '
        'checkFilterAllRange
        '
        Me.checkFilterAllRange.AutoSize = True
        Me.checkFilterAllRange.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.checkFilterAllRange.Location = New System.Drawing.Point(1077, 7)
        Me.checkFilterAllRange.Name = "checkFilterAllRange"
        Me.checkFilterAllRange.Size = New System.Drawing.Size(266, 34)
        Me.checkFilterAllRange.TabIndex = 3
        Me.checkFilterAllRange.Text = "Filter by Date Range"
        Me.checkFilterAllRange.UseVisualStyleBackColor = True
        '
        'filterEndDate
        '
        Me.filterEndDate.CustomFormat = "dd-MMM-yyyy"
        Me.filterEndDate.Enabled = False
        Me.filterEndDate.Font = New System.Drawing.Font("Helvetica", 14.0!)
        Me.filterEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.filterEndDate.Location = New System.Drawing.Point(1361, 47)
        Me.filterEndDate.Name = "filterEndDate"
        Me.filterEndDate.Size = New System.Drawing.Size(200, 35)
        Me.filterEndDate.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1310, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 24)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1005, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "From:"
        '
        'filterStartDate
        '
        Me.filterStartDate.CustomFormat = "dd-MMM-yyyy"
        Me.filterStartDate.Font = New System.Drawing.Font("Helvetica", 14.0!)
        Me.filterStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.filterStartDate.Location = New System.Drawing.Point(1077, 47)
        Me.filterStartDate.Name = "filterStartDate"
        Me.filterStartDate.Size = New System.Drawing.Size(200, 35)
        Me.filterStartDate.TabIndex = 4
        '
        'dropSupplier
        '
        Me.dropSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropSupplier.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.dropSupplier.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropSupplier.FormattingEnabled = True
        Me.dropSupplier.Items.AddRange(New Object() {"--Choose Category--", "Inks", "Laptop"})
        Me.dropSupplier.Location = New System.Drawing.Point(668, 46)
        Me.dropSupplier.Name = "dropSupplier"
        Me.dropSupplier.Size = New System.Drawing.Size(280, 35)
        Me.dropSupplier.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(663, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 28)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Supplier:"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(931, 3)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(63, 37)
        Me.txtID.TabIndex = 25
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'dropCategory
        '
        Me.dropCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropCategory.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.dropCategory.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropCategory.FormattingEnabled = True
        Me.dropCategory.Items.AddRange(New Object() {"--Choose Category--", "Inks", "Laptop"})
        Me.dropCategory.Location = New System.Drawing.Point(366, 46)
        Me.dropCategory.Name = "dropCategory"
        Me.dropCategory.Size = New System.Drawing.Size(280, 35)
        Me.dropCategory.TabIndex = 1
        '
        'txt_searchbox
        '
        Me.txt_searchbox.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchbox.Location = New System.Drawing.Point(28, 47)
        Me.txt_searchbox.Name = "txt_searchbox"
        Me.txt_searchbox.Size = New System.Drawing.Size(317, 35)
        Me.txt_searchbox.TabIndex = 0
        '
        'label_category
        '
        Me.label_category.AutoSize = True
        Me.label_category.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_category.Location = New System.Drawing.Point(361, 16)
        Me.label_category.Name = "label_category"
        Me.label_category.Size = New System.Drawing.Size(115, 28)
        Me.label_category.TabIndex = 2
        Me.label_category.Text = "Category:"
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
        'panel_datagridview
        '
        Me.panel_datagridview.Controls.Add(Me.xDataGrid)
        Me.panel_datagridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_datagridview.Location = New System.Drawing.Point(10, 200)
        Me.panel_datagridview.Name = "panel_datagridview"
        Me.panel_datagridview.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.panel_datagridview.Size = New System.Drawing.Size(1922, 173)
        Me.panel_datagridview.TabIndex = 40
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.xDataGrid.ColumnHeadersHeight = 40
        Me.xDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.xDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._detailID, Me._productID, Me._itemcode, Me._name, Me._brand, Me._model, Me._category, Me._serialNumber, Me._onhand, Me._markup, Me._supplier, Me._dateIn, Me._reference, Me._action})
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
        Me.xDataGrid.Size = New System.Drawing.Size(1902, 163)
        Me.xDataGrid.TabIndex = 2
        Me.xDataGrid.TabStop = False
        '
        '_detailID
        '
        Me._detailID.HeaderText = "Detail ID"
        Me._detailID.MinimumWidth = 6
        Me._detailID.Name = "_detailID"
        Me._detailID.ReadOnly = True
        Me._detailID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._detailID.Visible = False
        '
        '_productID
        '
        Me._productID.HeaderText = "Product ID"
        Me._productID.MinimumWidth = 6
        Me._productID.Name = "_productID"
        Me._productID.ReadOnly = True
        Me._productID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._productID.Visible = False
        '
        '_itemcode
        '
        Me._itemcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me._itemcode.HeaderText = "Product Code"
        Me._itemcode.MinimumWidth = 6
        Me._itemcode.Name = "_itemcode"
        Me._itemcode.ReadOnly = True
        Me._itemcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._itemcode.Width = 136
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
        '_serialNumber
        '
        Me._serialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me._serialNumber.HeaderText = "Serial Number"
        Me._serialNumber.MinimumWidth = 6
        Me._serialNumber.Name = "_serialNumber"
        Me._serialNumber.ReadOnly = True
        Me._serialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._serialNumber.Width = 141
        '
        '_onhand
        '
        Me._onhand.HeaderText = "In Stock"
        Me._onhand.MinimumWidth = 6
        Me._onhand.Name = "_onhand"
        Me._onhand.ReadOnly = True
        '
        '_markup
        '
        DataGridViewCellStyle2.Format = "N2"
        Me._markup.DefaultCellStyle = DataGridViewCellStyle2
        Me._markup.HeaderText = "At Cost"
        Me._markup.MinimumWidth = 6
        Me._markup.Name = "_markup"
        Me._markup.ReadOnly = True
        Me._markup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '_supplier
        '
        Me._supplier.HeaderText = "Supplier"
        Me._supplier.MinimumWidth = 6
        Me._supplier.Name = "_supplier"
        Me._supplier.ReadOnly = True
        Me._supplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '_dateIn
        '
        DataGridViewCellStyle3.Format = "yyyy-MMM-dd"
        DataGridViewCellStyle3.NullValue = "None"
        Me._dateIn.DefaultCellStyle = DataGridViewCellStyle3
        Me._dateIn.HeaderText = "Date In"
        Me._dateIn.MinimumWidth = 6
        Me._dateIn.Name = "_dateIn"
        Me._dateIn.ReadOnly = True
        Me._dateIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '_reference
        '
        Me._reference.HeaderText = "Reference"
        Me._reference.MinimumWidth = 6
        Me._reference.Name = "_reference"
        Me._reference.ReadOnly = True
        Me._reference.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._reference.Visible = False
        '
        '_action
        '
        Me._action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me._action.HeaderText = "Action"
        Me._action.MinimumWidth = 6
        Me._action.Name = "_action"
        Me._action.ReadOnly = True
        Me._action.Text = "View"
        Me._action.UseColumnTextForButtonValue = True
        Me._action.Width = 69
        '
        'menuBar
        '
        Me.menuBar.AllowMerge = False
        Me.menuBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuBar.Font = New System.Drawing.Font("Helvetica", 13.0!)
        Me.menuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMenu, Me.menuAdvanceSearch})
        Me.menuBar.Location = New System.Drawing.Point(0, 60)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Padding = New System.Windows.Forms.Padding(10, 5, 0, 5)
        Me.menuBar.Size = New System.Drawing.Size(1942, 40)
        Me.menuBar.TabIndex = 41
        Me.menuBar.Text = "Menu Bar"
        '
        'menuMenu
        '
        Me.menuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuRefresh, Me.menuPrint})
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
        Me.menuRefresh.Size = New System.Drawing.Size(223, 30)
        Me.menuRefresh.Text = "Refresh"
        '
        'menuPrint
        '
        Me.menuPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuPrint.Name = "menuPrint"
        Me.menuPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.menuPrint.Size = New System.Drawing.Size(223, 30)
        Me.menuPrint.Text = "Print"
        '
        'menuAdvanceSearch
        '
        Me.menuAdvanceSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuAdvanceSearch.Name = "menuAdvanceSearch"
        Me.menuAdvanceSearch.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.menuAdvanceSearch.Size = New System.Drawing.Size(186, 30)
        Me.menuAdvanceSearch.Text = "Advance Search"
        '
        'frmInventoryAllItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1942, 383)
        Me.Controls.Add(Me.panel_datagridview)
        Me.Controls.Add(Me.panel_body)
        Me.Controls.Add(Me.panel_right)
        Me.Controls.Add(Me.panel_left)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.menuBar)
        Me.Controls.Add(Me.panel_header)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmInventoryAllItems"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory All Items"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panel_body.ResumeLayout(False)
        Me.panel_body.PerformLayout()
        Me.panel_datagridview.ResumeLayout(False)
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuBar.ResumeLayout(False)
        Me.menuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents lable_header_title As Label
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents panel_left As Panel
    Friend WithEvents panel_right As Panel
    Friend WithEvents panel_body As Panel
    Friend WithEvents txtID As TextBox
    Friend WithEvents dropCategory As ComboBox
    Friend WithEvents txt_searchbox As TextBox
    Friend WithEvents label_category As Label
    Friend WithEvents label_search As Label
    Friend WithEvents dropSupplier As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents panel_datagridview As Panel
    Friend WithEvents xDataGrid As DataGridView
    Friend WithEvents menuBar As MenuStrip
    Friend WithEvents menuMenu As ToolStripMenuItem
    Friend WithEvents menuRefresh As ToolStripMenuItem
    Friend WithEvents menuPrint As ToolStripMenuItem
    Friend WithEvents _detailID As DataGridViewTextBoxColumn
    Friend WithEvents _productID As DataGridViewTextBoxColumn
    Friend WithEvents _itemcode As DataGridViewTextBoxColumn
    Friend WithEvents _name As DataGridViewTextBoxColumn
    Friend WithEvents _brand As DataGridViewTextBoxColumn
    Friend WithEvents _model As DataGridViewTextBoxColumn
    Friend WithEvents _category As DataGridViewTextBoxColumn
    Friend WithEvents _serialNumber As DataGridViewTextBoxColumn
    Friend WithEvents _onhand As DataGridViewTextBoxColumn
    Friend WithEvents _markup As DataGridViewTextBoxColumn
    Friend WithEvents _supplier As DataGridViewTextBoxColumn
    Friend WithEvents _dateIn As DataGridViewTextBoxColumn
    Friend WithEvents _reference As DataGridViewTextBoxColumn
    Friend WithEvents _action As DataGridViewButtonColumn
    Friend WithEvents filterEndDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents filterStartDate As DateTimePicker
    Friend WithEvents checkFilterAllRange As CheckBox
    Friend WithEvents menuAdvanceSearch As ToolStripMenuItem
End Class
