<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAllOrders
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAllOrders))
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.filterByOrderDateRange = New System.Windows.Forms.RadioButton()
        Me.filterByOrderDate = New System.Windows.Forms.RadioButton()
        Me.filterDateOrderEnd = New System.Windows.Forms.DateTimePicker()
        Me.filterDateOrderStart = New System.Windows.Forms.DateTimePicker()
        Me.dropModel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dropBrand = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_searchbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.filter_category = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.filterDateOrder = New System.Windows.Forms.DateTimePicker()
        Me.label_category = New System.Windows.Forms.Label()
        Me.label_search = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel_datagridview = New System.Windows.Forms.Panel()
        Me.xDataGrid = New System.Windows.Forms.DataGridView()
        Me._orderDetailID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._transacode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._invoice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._orderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._custName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._serialNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._productName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._warrantyStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._warrantyEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menuBar = New System.Windows.Forms.MenuStrip()
        Me.menuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrintAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAdvanceSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.panel_header.SuspendLayout()
        Me.panel_body.SuspendLayout()
        Me.panel_datagridview.SuspendLayout()
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 823)
        Me.panel_bottom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(1033, 13)
        Me.panel_bottom.TabIndex = 35
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
        Me.panel_header.Size = New System.Drawing.Size(1033, 60)
        Me.panel_header.TabIndex = 36
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
        Me.btn_close.Location = New System.Drawing.Point(969, 0)
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
        Me.lable_header_title.Size = New System.Drawing.Size(151, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "All Sales"
        '
        'panel_body
        '
        Me.panel_body.Controls.Add(Me.filterByOrderDateRange)
        Me.panel_body.Controls.Add(Me.filterByOrderDate)
        Me.panel_body.Controls.Add(Me.filterDateOrderEnd)
        Me.panel_body.Controls.Add(Me.filterDateOrderStart)
        Me.panel_body.Controls.Add(Me.dropModel)
        Me.panel_body.Controls.Add(Me.Label4)
        Me.panel_body.Controls.Add(Me.dropBrand)
        Me.panel_body.Controls.Add(Me.Label1)
        Me.panel_body.Controls.Add(Me.txt_searchbox)
        Me.panel_body.Controls.Add(Me.Label3)
        Me.panel_body.Controls.Add(Me.filter_category)
        Me.panel_body.Controls.Add(Me.txtID)
        Me.panel_body.Controls.Add(Me.filterDateOrder)
        Me.panel_body.Controls.Add(Me.label_category)
        Me.panel_body.Controls.Add(Me.label_search)
        Me.panel_body.Controls.Add(Me.Label2)
        Me.panel_body.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_body.Location = New System.Drawing.Point(0, 100)
        Me.panel_body.Margin = New System.Windows.Forms.Padding(4)
        Me.panel_body.Name = "panel_body"
        Me.panel_body.Size = New System.Drawing.Size(380, 723)
        Me.panel_body.TabIndex = 37
        '
        'filterByOrderDateRange
        '
        Me.filterByOrderDateRange.AutoSize = True
        Me.filterByOrderDateRange.Font = New System.Drawing.Font("Helvetica", 14.0!)
        Me.filterByOrderDateRange.Location = New System.Drawing.Point(23, 438)
        Me.filterByOrderDateRange.Name = "filterByOrderDateRange"
        Me.filterByOrderDateRange.Size = New System.Drawing.Size(257, 32)
        Me.filterByOrderDateRange.TabIndex = 6
        Me.filterByOrderDateRange.TabStop = True
        Me.filterByOrderDateRange.Text = "Sales by Date Range"
        Me.filterByOrderDateRange.UseVisualStyleBackColor = True
        '
        'filterByOrderDate
        '
        Me.filterByOrderDate.AutoSize = True
        Me.filterByOrderDate.Font = New System.Drawing.Font("Helvetica", 14.0!)
        Me.filterByOrderDate.Location = New System.Drawing.Point(23, 336)
        Me.filterByOrderDate.Name = "filterByOrderDate"
        Me.filterByOrderDate.Size = New System.Drawing.Size(181, 32)
        Me.filterByOrderDate.TabIndex = 4
        Me.filterByOrderDate.TabStop = True
        Me.filterByOrderDate.Text = "Sales by Date"
        Me.filterByOrderDate.UseVisualStyleBackColor = True
        '
        'filterDateOrderEnd
        '
        Me.filterDateOrderEnd.CustomFormat = "dd-MMM-yyyy"
        Me.filterDateOrderEnd.Enabled = False
        Me.filterDateOrderEnd.Font = New System.Drawing.Font("Helvetica", 14.0!)
        Me.filterDateOrderEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.filterDateOrderEnd.Location = New System.Drawing.Point(23, 568)
        Me.filterDateOrderEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.filterDateOrderEnd.Name = "filterDateOrderEnd"
        Me.filterDateOrderEnd.Size = New System.Drawing.Size(265, 35)
        Me.filterDateOrderEnd.TabIndex = 8
        '
        'filterDateOrderStart
        '
        Me.filterDateOrderStart.CustomFormat = "dd-MMM-yyyy"
        Me.filterDateOrderStart.Enabled = False
        Me.filterDateOrderStart.Font = New System.Drawing.Font("Helvetica", 14.0!)
        Me.filterDateOrderStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.filterDateOrderStart.Location = New System.Drawing.Point(23, 501)
        Me.filterDateOrderStart.Margin = New System.Windows.Forms.Padding(4)
        Me.filterDateOrderStart.Name = "filterDateOrderStart"
        Me.filterDateOrderStart.Size = New System.Drawing.Size(265, 35)
        Me.filterDateOrderStart.TabIndex = 7
        '
        'dropModel
        '
        Me.dropModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropModel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.dropModel.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropModel.FormattingEnabled = True
        Me.dropModel.Items.AddRange(New Object() {"--Choose Category--", "Inks", "Laptop"})
        Me.dropModel.Location = New System.Drawing.Point(23, 278)
        Me.dropModel.Margin = New System.Windows.Forms.Padding(4)
        Me.dropModel.Name = "dropModel"
        Me.dropModel.Size = New System.Drawing.Size(332, 35)
        Me.dropModel.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 246)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 28)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Model:"
        '
        'dropBrand
        '
        Me.dropBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropBrand.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.dropBrand.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropBrand.FormattingEnabled = True
        Me.dropBrand.Items.AddRange(New Object() {"--Choose Category--", "Inks", "Laptop"})
        Me.dropBrand.Location = New System.Drawing.Point(23, 207)
        Me.dropBrand.Margin = New System.Windows.Forms.Padding(4)
        Me.dropBrand.Name = "dropBrand"
        Me.dropBrand.Size = New System.Drawing.Size(332, 35)
        Me.dropBrand.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 175)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 28)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Brand:"
        '
        'txt_searchbox
        '
        Me.txt_searchbox.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchbox.Location = New System.Drawing.Point(23, 65)
        Me.txt_searchbox.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_searchbox.Name = "txt_searchbox"
        Me.txt_searchbox.Size = New System.Drawing.Size(332, 35)
        Me.txt_searchbox.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 540)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 24)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "To:"
        '
        'filter_category
        '
        Me.filter_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filter_category.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.filter_category.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filter_category.FormattingEnabled = True
        Me.filter_category.Items.AddRange(New Object() {"--Choose Category--", "Inks", "Laptop"})
        Me.filter_category.Location = New System.Drawing.Point(23, 136)
        Me.filter_category.Margin = New System.Windows.Forms.Padding(4)
        Me.filter_category.Name = "filter_category"
        Me.filter_category.Size = New System.Drawing.Size(332, 35)
        Me.filter_category.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(267, 20)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(83, 37)
        Me.txtID.TabIndex = 25
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'filterDateOrder
        '
        Me.filterDateOrder.CustomFormat = "dd-MMM-yyyy"
        Me.filterDateOrder.Font = New System.Drawing.Font("Helvetica", 14.0!)
        Me.filterDateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.filterDateOrder.Location = New System.Drawing.Point(23, 376)
        Me.filterDateOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.filterDateOrder.Name = "filterDateOrder"
        Me.filterDateOrder.Size = New System.Drawing.Size(265, 35)
        Me.filterDateOrder.TabIndex = 5
        '
        'label_category
        '
        Me.label_category.AutoSize = True
        Me.label_category.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_category.Location = New System.Drawing.Point(23, 104)
        Me.label_category.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_category.Name = "label_category"
        Me.label_category.Size = New System.Drawing.Size(115, 28)
        Me.label_category.TabIndex = 31
        Me.label_category.Text = "Category:"
        '
        'label_search
        '
        Me.label_search.AutoSize = True
        Me.label_search.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_search.Location = New System.Drawing.Point(23, 27)
        Me.label_search.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_search.Name = "label_search"
        Me.label_search.Size = New System.Drawing.Size(94, 28)
        Me.label_search.TabIndex = 2
        Me.label_search.Text = "Search:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 473)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 24)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "From:"
        '
        'panel_datagridview
        '
        Me.panel_datagridview.Controls.Add(Me.xDataGrid)
        Me.panel_datagridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_datagridview.Location = New System.Drawing.Point(380, 100)
        Me.panel_datagridview.Margin = New System.Windows.Forms.Padding(4)
        Me.panel_datagridview.Name = "panel_datagridview"
        Me.panel_datagridview.Padding = New System.Windows.Forms.Padding(13, 6, 13, 6)
        Me.panel_datagridview.Size = New System.Drawing.Size(653, 723)
        Me.panel_datagridview.TabIndex = 38
        '
        'xDataGrid
        '
        Me.xDataGrid.AllowUserToAddRows = False
        Me.xDataGrid.AllowUserToDeleteRows = False
        Me.xDataGrid.AllowUserToResizeColumns = False
        Me.xDataGrid.AllowUserToResizeRows = False
        Me.xDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.xDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.xDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.xDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.xDataGrid.ColumnHeadersHeight = 40
        Me.xDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.xDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._orderDetailID, Me._transacode, Me._invoice, Me._orderDate, Me._custName, Me._serialNumber, Me._productName, Me._brand, Me._model, Me._category, Me._supplier, Me._quantity, Me._unit, Me._price, Me._total, Me._warrantyStart, Me._warrantyEnd})
        Me.xDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xDataGrid.EnableHeadersVisualStyles = False
        Me.xDataGrid.Location = New System.Drawing.Point(13, 6)
        Me.xDataGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.xDataGrid.MultiSelect = False
        Me.xDataGrid.Name = "xDataGrid"
        Me.xDataGrid.ReadOnly = True
        Me.xDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.xDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.xDataGrid.RowHeadersVisible = False
        Me.xDataGrid.RowHeadersWidth = 30
        Me.xDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.xDataGrid.RowTemplate.Height = 35
        Me.xDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.xDataGrid.Size = New System.Drawing.Size(627, 711)
        Me.xDataGrid.TabIndex = 2
        Me.xDataGrid.TabStop = False
        '
        '_orderDetailID
        '
        Me._orderDetailID.HeaderText = "Detail ID"
        Me._orderDetailID.MinimumWidth = 6
        Me._orderDetailID.Name = "_orderDetailID"
        Me._orderDetailID.ReadOnly = True
        Me._orderDetailID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._orderDetailID.Visible = False
        Me._orderDetailID.Width = 67
        '
        '_transacode
        '
        Me._transacode.HeaderText = "Transaction Code"
        Me._transacode.MinimumWidth = 6
        Me._transacode.Name = "_transacode"
        Me._transacode.ReadOnly = True
        Me._transacode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._transacode.Width = 124
        '
        '_invoice
        '
        Me._invoice.HeaderText = "Invoice No."
        Me._invoice.MinimumWidth = 6
        Me._invoice.Name = "_invoice"
        Me._invoice.ReadOnly = True
        Me._invoice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._invoice.Width = 82
        '
        '_orderDate
        '
        DataGridViewCellStyle2.Format = "yyyy-MMM-dd"
        Me._orderDate.DefaultCellStyle = DataGridViewCellStyle2
        Me._orderDate.HeaderText = "Order Date"
        Me._orderDate.MinimumWidth = 6
        Me._orderDate.Name = "_orderDate"
        Me._orderDate.ReadOnly = True
        Me._orderDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._orderDate.Width = 83
        '
        '_custName
        '
        Me._custName.HeaderText = "Customer"
        Me._custName.MinimumWidth = 6
        Me._custName.Name = "_custName"
        Me._custName.ReadOnly = True
        Me._custName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._custName.Width = 72
        '
        '_serialNumber
        '
        Me._serialNumber.HeaderText = "Serial Number"
        Me._serialNumber.MinimumWidth = 6
        Me._serialNumber.Name = "_serialNumber"
        Me._serialNumber.ReadOnly = True
        Me._serialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._serialNumber.Width = 102
        '
        '_productName
        '
        Me._productName.HeaderText = "Product Name"
        Me._productName.MinimumWidth = 6
        Me._productName.Name = "_productName"
        Me._productName.ReadOnly = True
        Me._productName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._productName.Width = 102
        '
        '_brand
        '
        Me._brand.HeaderText = "Brand"
        Me._brand.MinimumWidth = 6
        Me._brand.Name = "_brand"
        Me._brand.ReadOnly = True
        Me._brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._brand.Width = 50
        '
        '_model
        '
        Me._model.HeaderText = "Model"
        Me._model.MinimumWidth = 6
        Me._model.Name = "_model"
        Me._model.ReadOnly = True
        Me._model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._model.Width = 50
        '
        '_category
        '
        Me._category.HeaderText = "Category"
        Me._category.MinimumWidth = 6
        Me._category.Name = "_category"
        Me._category.ReadOnly = True
        Me._category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._category.Width = 69
        '
        '_supplier
        '
        Me._supplier.HeaderText = "Supplier"
        Me._supplier.MinimumWidth = 6
        Me._supplier.Name = "_supplier"
        Me._supplier.ReadOnly = True
        Me._supplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._supplier.Width = 64
        '
        '_quantity
        '
        Me._quantity.HeaderText = "Quantity"
        Me._quantity.MinimumWidth = 6
        Me._quantity.Name = "_quantity"
        Me._quantity.ReadOnly = True
        Me._quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._quantity.Width = 65
        '
        '_unit
        '
        Me._unit.HeaderText = "Unit"
        Me._unit.MinimumWidth = 6
        Me._unit.Name = "_unit"
        Me._unit.ReadOnly = True
        Me._unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._unit.Width = 37
        '
        '_price
        '
        DataGridViewCellStyle3.Format = "N2"
        Me._price.DefaultCellStyle = DataGridViewCellStyle3
        Me._price.HeaderText = "Price"
        Me._price.MinimumWidth = 6
        Me._price.Name = "_price"
        Me._price.ReadOnly = True
        Me._price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._price.Width = 44
        '
        '_total
        '
        DataGridViewCellStyle4.Format = "N2"
        Me._total.DefaultCellStyle = DataGridViewCellStyle4
        Me._total.HeaderText = "Total"
        Me._total.MinimumWidth = 6
        Me._total.Name = "_total"
        Me._total.ReadOnly = True
        Me._total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._total.Width = 44
        '
        '_warrantyStart
        '
        DataGridViewCellStyle5.Format = "yyyy-MMM-dd"
        DataGridViewCellStyle5.NullValue = "None"
        Me._warrantyStart.DefaultCellStyle = DataGridViewCellStyle5
        Me._warrantyStart.HeaderText = "Start of Warranty"
        Me._warrantyStart.MinimumWidth = 6
        Me._warrantyStart.Name = "_warrantyStart"
        Me._warrantyStart.ReadOnly = True
        Me._warrantyStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._warrantyStart.Width = 120
        '
        '_warrantyEnd
        '
        DataGridViewCellStyle6.Format = "yyyy-MMM-dd"
        DataGridViewCellStyle6.NullValue = "None"
        Me._warrantyEnd.DefaultCellStyle = DataGridViewCellStyle6
        Me._warrantyEnd.HeaderText = "End of Warranty"
        Me._warrantyEnd.MinimumWidth = 6
        Me._warrantyEnd.Name = "_warrantyEnd"
        Me._warrantyEnd.ReadOnly = True
        Me._warrantyEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._warrantyEnd.Width = 115
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
        Me.menuBar.Size = New System.Drawing.Size(1033, 40)
        Me.menuBar.TabIndex = 39
        Me.menuBar.Text = "Menu Bar"
        '
        'menuMenu
        '
        Me.menuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuRefresh, Me.menuPrint, Me.menuPrintAll})
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
        Me.menuRefresh.Size = New System.Drawing.Size(297, 30)
        Me.menuRefresh.Text = "Refresh"
        '
        'menuPrint
        '
        Me.menuPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuPrint.Name = "menuPrint"
        Me.menuPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.menuPrint.Size = New System.Drawing.Size(297, 30)
        Me.menuPrint.Text = "Print"
        '
        'menuPrintAll
        '
        Me.menuPrintAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuPrintAll.Enabled = False
        Me.menuPrintAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuPrintAll.Name = "menuPrintAll"
        Me.menuPrintAll.Size = New System.Drawing.Size(297, 30)
        Me.menuPrintAll.Text = "Print All Transaction"
        Me.menuPrintAll.Visible = False
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
        'frmAllOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1033, 836)
        Me.Controls.Add(Me.panel_datagridview)
        Me.Controls.Add(Me.panel_body)
        Me.Controls.Add(Me.menuBar)
        Me.Controls.Add(Me.panel_header)
        Me.Controls.Add(Me.panel_bottom)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAllOrders"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All Orders"
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

    Friend WithEvents panel_bottom As Panel
    Friend WithEvents panel_header As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents lable_header_title As Label
    Friend WithEvents panel_body As Panel
    Friend WithEvents filterDateOrderEnd As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents filterDateOrder As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txt_searchbox As TextBox
    Friend WithEvents label_search As Label
    Friend WithEvents panel_datagridview As Panel
    Friend WithEvents xDataGrid As DataGridView
    Friend WithEvents filter_category As ComboBox
    Friend WithEvents label_category As Label
    Friend WithEvents menuBar As MenuStrip
    Friend WithEvents menuMenu As ToolStripMenuItem
    Friend WithEvents menuRefresh As ToolStripMenuItem
    Friend WithEvents menuPrint As ToolStripMenuItem
    Friend WithEvents dropBrand As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dropModel As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents filterDateOrderStart As DateTimePicker
    Friend WithEvents filterByOrderDate As RadioButton
    Friend WithEvents filterByOrderDateRange As RadioButton
    Friend WithEvents menuPrintAll As ToolStripMenuItem
    Friend WithEvents _orderDetailID As DataGridViewTextBoxColumn
    Friend WithEvents _transacode As DataGridViewTextBoxColumn
    Friend WithEvents _invoice As DataGridViewTextBoxColumn
    Friend WithEvents _orderDate As DataGridViewTextBoxColumn
    Friend WithEvents _custName As DataGridViewTextBoxColumn
    Friend WithEvents _serialNumber As DataGridViewTextBoxColumn
    Friend WithEvents _productName As DataGridViewTextBoxColumn
    Friend WithEvents _brand As DataGridViewTextBoxColumn
    Friend WithEvents _model As DataGridViewTextBoxColumn
    Friend WithEvents _category As DataGridViewTextBoxColumn
    Friend WithEvents _supplier As DataGridViewTextBoxColumn
    Friend WithEvents _quantity As DataGridViewTextBoxColumn
    Friend WithEvents _unit As DataGridViewTextBoxColumn
    Friend WithEvents _price As DataGridViewTextBoxColumn
    Friend WithEvents _total As DataGridViewTextBoxColumn
    Friend WithEvents _warrantyStart As DataGridViewTextBoxColumn
    Friend WithEvents _warrantyEnd As DataGridViewTextBoxColumn
    Friend WithEvents menuAdvanceSearch As ToolStripMenuItem
End Class
