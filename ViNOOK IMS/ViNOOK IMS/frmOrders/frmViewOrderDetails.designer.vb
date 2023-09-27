<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewOrderDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                funcOrder.Dispose()
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewOrderDetails))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.panel_details = New System.Windows.Forms.Panel()
        Me.group_details = New System.Windows.Forms.GroupBox()
        Me.txtTotalAmountDue = New System.Windows.Forms.TextBox()
        Me.txtpaymentType = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.label_address = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.label_firstName = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTransactionCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel_items = New System.Windows.Forms.Panel()
        Me.group_items = New System.Windows.Forms.GroupBox()
        Me.xDataGrid = New System.Windows.Forms.DataGridView()
        Me._orderDetailID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._serialNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._name = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.panel_items_search = New System.Windows.Forms.Panel()
        Me.panel_action = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_searchbox = New System.Windows.Forms.TextBox()
        Me.label_search = New System.Windows.Forms.Label()
        Me.panel_header.SuspendLayout()
        Me.panel_details.SuspendLayout()
        Me.group_details.SuspendLayout()
        Me.panel_items.SuspendLayout()
        Me.group_items.SuspendLayout()
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_items_search.SuspendLayout()
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
        Me.panel_header.Size = New System.Drawing.Size(1070, 60)
        Me.panel_header.TabIndex = 7
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
        Me.btn_close.Location = New System.Drawing.Point(1006, 0)
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
        Me.lable_header_title.Size = New System.Drawing.Size(217, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "Order Details"
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 694)
        Me.panel_bottom.Margin = New System.Windows.Forms.Padding(4)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(1070, 6)
        Me.panel_bottom.TabIndex = 46
        '
        'panel_details
        '
        Me.panel_details.Controls.Add(Me.group_details)
        Me.panel_details.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_details.Location = New System.Drawing.Point(0, 60)
        Me.panel_details.Name = "panel_details"
        Me.panel_details.Padding = New System.Windows.Forms.Padding(10)
        Me.panel_details.Size = New System.Drawing.Size(1070, 218)
        Me.panel_details.TabIndex = 90
        '
        'group_details
        '
        Me.group_details.Controls.Add(Me.txtTotalAmountDue)
        Me.group_details.Controls.Add(Me.txtpaymentType)
        Me.group_details.Controls.Add(Me.Label8)
        Me.group_details.Controls.Add(Me.Label12)
        Me.group_details.Controls.Add(Me.txtAddress)
        Me.group_details.Controls.Add(Me.label_address)
        Me.group_details.Controls.Add(Me.txtname)
        Me.group_details.Controls.Add(Me.label_firstName)
        Me.group_details.Controls.Add(Me.txtInvoiceNo)
        Me.group_details.Controls.Add(Me.Label3)
        Me.group_details.Controls.Add(Me.txtTransactionCode)
        Me.group_details.Controls.Add(Me.Label2)
        Me.group_details.Dock = System.Windows.Forms.DockStyle.Fill
        Me.group_details.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_details.Location = New System.Drawing.Point(10, 10)
        Me.group_details.Name = "group_details"
        Me.group_details.Size = New System.Drawing.Size(1050, 198)
        Me.group_details.TabIndex = 21
        Me.group_details.TabStop = False
        Me.group_details.Text = "Order Details"
        '
        'txtTotalAmountDue
        '
        Me.txtTotalAmountDue.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtTotalAmountDue.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmountDue.Location = New System.Drawing.Point(732, 51)
        Me.txtTotalAmountDue.Name = "txtTotalAmountDue"
        Me.txtTotalAmountDue.ReadOnly = True
        Me.txtTotalAmountDue.Size = New System.Drawing.Size(280, 37)
        Me.txtTotalAmountDue.TabIndex = 77
        Me.txtTotalAmountDue.TabStop = False
        Me.txtTotalAmountDue.Text = "0.00"
        Me.txtTotalAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpaymentType
        '
        Me.txtpaymentType.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtpaymentType.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaymentType.Location = New System.Drawing.Point(732, 94)
        Me.txtpaymentType.Name = "txtpaymentType"
        Me.txtpaymentType.ReadOnly = True
        Me.txtpaymentType.Size = New System.Drawing.Size(280, 37)
        Me.txtpaymentType.TabIndex = 76
        Me.txtpaymentType.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(553, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 24)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Payment Type"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(553, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 24)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Total Amount"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtAddress.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(732, 137)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(280, 37)
        Me.txtAddress.TabIndex = 42
        Me.txtAddress.TabStop = False
        '
        'label_address
        '
        Me.label_address.AutoSize = True
        Me.label_address.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_address.Location = New System.Drawing.Point(553, 145)
        Me.label_address.Name = "label_address"
        Me.label_address.Size = New System.Drawing.Size(83, 24)
        Me.label_address.TabIndex = 45
        Me.label_address.Text = "Address"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtname.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(221, 137)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(280, 37)
        Me.txtname.TabIndex = 41
        Me.txtname.TabStop = False
        '
        'label_firstName
        '
        Me.label_firstName.AutoSize = True
        Me.label_firstName.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_firstName.Location = New System.Drawing.Point(31, 145)
        Me.label_firstName.Name = "label_firstName"
        Me.label_firstName.Size = New System.Drawing.Size(63, 24)
        Me.label_firstName.TabIndex = 44
        Me.label_firstName.Text = "Name"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(221, 94)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(280, 37)
        Me.txtInvoiceNo.TabIndex = 0
        Me.txtInvoiceNo.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 24)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Invoice No.:"
        '
        'txtTransactionCode
        '
        Me.txtTransactionCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtTransactionCode.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionCode.Location = New System.Drawing.Point(221, 51)
        Me.txtTransactionCode.Name = "txtTransactionCode"
        Me.txtTransactionCode.ReadOnly = True
        Me.txtTransactionCode.Size = New System.Drawing.Size(280, 37)
        Me.txtTransactionCode.TabIndex = 38
        Me.txtTransactionCode.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 24)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Transaction Code:"
        '
        'panel_items
        '
        Me.panel_items.Controls.Add(Me.group_items)
        Me.panel_items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_items.Location = New System.Drawing.Point(0, 278)
        Me.panel_items.Name = "panel_items"
        Me.panel_items.Padding = New System.Windows.Forms.Padding(10)
        Me.panel_items.Size = New System.Drawing.Size(1070, 416)
        Me.panel_items.TabIndex = 91
        '
        'group_items
        '
        Me.group_items.Controls.Add(Me.xDataGrid)
        Me.group_items.Controls.Add(Me.panel_items_search)
        Me.group_items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.group_items.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_items.Location = New System.Drawing.Point(10, 10)
        Me.group_items.Name = "group_items"
        Me.group_items.Padding = New System.Windows.Forms.Padding(15)
        Me.group_items.Size = New System.Drawing.Size(1050, 396)
        Me.group_items.TabIndex = 21
        Me.group_items.TabStop = False
        Me.group_items.Text = "Items Purchased"
        '
        'xDataGrid
        '
        Me.xDataGrid.AllowUserToAddRows = False
        Me.xDataGrid.AllowUserToDeleteRows = False
        Me.xDataGrid.AllowUserToResizeColumns = False
        Me.xDataGrid.AllowUserToResizeRows = False
        Me.xDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.xDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.xDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.xDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.xDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.xDataGrid.ColumnHeadersHeight = 40
        Me.xDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.xDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._orderDetailID, Me._serialNumber, Me._name, Me._brand, Me._model, Me._category, Me._supplier, Me._quantity, Me._unit, Me._price, Me._total, Me._warrantyStart, Me._warrantyEnd})
        Me.xDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xDataGrid.EnableHeadersVisualStyles = False
        Me.xDataGrid.Location = New System.Drawing.Point(15, 148)
        Me.xDataGrid.MultiSelect = False
        Me.xDataGrid.Name = "xDataGrid"
        Me.xDataGrid.ReadOnly = True
        Me.xDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.xDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.xDataGrid.RowHeadersVisible = False
        Me.xDataGrid.RowHeadersWidth = 30
        Me.xDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.xDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.xDataGrid.RowTemplate.Height = 35
        Me.xDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.xDataGrid.Size = New System.Drawing.Size(1020, 233)
        Me.xDataGrid.TabIndex = 52
        Me.xDataGrid.TabStop = False
        '
        '_orderDetailID
        '
        Me._orderDetailID.HeaderText = "Order Detail ID"
        Me._orderDetailID.MinimumWidth = 6
        Me._orderDetailID.Name = "_orderDetailID"
        Me._orderDetailID.ReadOnly = True
        Me._orderDetailID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._orderDetailID.Visible = False
        Me._orderDetailID.Width = 177
        '
        '_serialNumber
        '
        Me._serialNumber.HeaderText = "Serial Number"
        Me._serialNumber.MinimumWidth = 6
        Me._serialNumber.Name = "_serialNumber"
        Me._serialNumber.ReadOnly = True
        Me._serialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._serialNumber.Width = 167
        '
        '_name
        '
        Me._name.HeaderText = "Name"
        Me._name.MinimumWidth = 6
        Me._name.Name = "_name"
        Me._name.ReadOnly = True
        Me._name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._name.Width = 79
        '
        '_brand
        '
        Me._brand.HeaderText = "Brand"
        Me._brand.MinimumWidth = 6
        Me._brand.Name = "_brand"
        Me._brand.ReadOnly = True
        Me._brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._brand.Width = 79
        '
        '_model
        '
        Me._model.HeaderText = "Model"
        Me._model.MinimumWidth = 6
        Me._model.Name = "_model"
        Me._model.ReadOnly = True
        Me._model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._model.Width = 80
        '
        '_category
        '
        Me._category.HeaderText = "Category"
        Me._category.MinimumWidth = 6
        Me._category.Name = "_category"
        Me._category.ReadOnly = True
        Me._category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._category.Width = 112
        '
        '_supplier
        '
        Me._supplier.HeaderText = "Supplier"
        Me._supplier.MinimumWidth = 6
        Me._supplier.Name = "_supplier"
        Me._supplier.ReadOnly = True
        Me._supplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._supplier.Width = 102
        '
        '_quantity
        '
        Me._quantity.HeaderText = "Quantity"
        Me._quantity.MinimumWidth = 6
        Me._quantity.Name = "_quantity"
        Me._quantity.ReadOnly = True
        Me._quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._quantity.Width = 105
        '
        '_unit
        '
        Me._unit.HeaderText = "Unit"
        Me._unit.MinimumWidth = 6
        Me._unit.Name = "_unit"
        Me._unit.ReadOnly = True
        Me._unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._unit.Width = 58
        '
        '_price
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me._price.DefaultCellStyle = DataGridViewCellStyle2
        Me._price.HeaderText = "Price"
        Me._price.MinimumWidth = 6
        Me._price.Name = "_price"
        Me._price.ReadOnly = True
        Me._price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._price.Width = 70
        '
        '_total
        '
        DataGridViewCellStyle3.Format = "N2"
        Me._total.DefaultCellStyle = DataGridViewCellStyle3
        Me._total.HeaderText = "Total Amount"
        Me._total.MinimumWidth = 6
        Me._total.Name = "_total"
        Me._total.ReadOnly = True
        Me._total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._total.Width = 154
        '
        '_warrantyStart
        '
        DataGridViewCellStyle4.Format = "yyyy-MMM-dd"
        DataGridViewCellStyle4.NullValue = "None"
        Me._warrantyStart.DefaultCellStyle = DataGridViewCellStyle4
        Me._warrantyStart.HeaderText = "Start of Warranty"
        Me._warrantyStart.MinimumWidth = 6
        Me._warrantyStart.Name = "_warrantyStart"
        Me._warrantyStart.ReadOnly = True
        Me._warrantyStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._warrantyStart.Width = 197
        '
        '_warrantyEnd
        '
        DataGridViewCellStyle5.Format = "yyyy-MMM-dd"
        DataGridViewCellStyle5.NullValue = "None"
        Me._warrantyEnd.DefaultCellStyle = DataGridViewCellStyle5
        Me._warrantyEnd.HeaderText = "End of Warranty"
        Me._warrantyEnd.MinimumWidth = 6
        Me._warrantyEnd.Name = "_warrantyEnd"
        Me._warrantyEnd.ReadOnly = True
        Me._warrantyEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._warrantyEnd.Width = 188
        '
        'panel_items_search
        '
        Me.panel_items_search.Controls.Add(Me.panel_action)
        Me.panel_items_search.Controls.Add(Me.Label1)
        Me.panel_items_search.Controls.Add(Me.txt_searchbox)
        Me.panel_items_search.Controls.Add(Me.label_search)
        Me.panel_items_search.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_items_search.Location = New System.Drawing.Point(15, 43)
        Me.panel_items_search.Name = "panel_items_search"
        Me.panel_items_search.Size = New System.Drawing.Size(1020, 105)
        Me.panel_items_search.TabIndex = 53
        '
        'panel_action
        '
        Me.panel_action.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_action.Location = New System.Drawing.Point(880, 0)
        Me.panel_action.Name = "panel_action"
        Me.panel_action.Padding = New System.Windows.Forms.Padding(10)
        Me.panel_action.Size = New System.Drawing.Size(140, 105)
        Me.panel_action.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Serial Number / Item"
        '
        'txt_searchbox
        '
        Me.txt_searchbox.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchbox.Location = New System.Drawing.Point(31, 50)
        Me.txt_searchbox.Name = "txt_searchbox"
        Me.txt_searchbox.Size = New System.Drawing.Size(427, 35)
        Me.txt_searchbox.TabIndex = 0
        '
        'label_search
        '
        Me.label_search.AutoSize = True
        Me.label_search.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_search.Location = New System.Drawing.Point(26, 19)
        Me.label_search.Name = "label_search"
        Me.label_search.Size = New System.Drawing.Size(94, 28)
        Me.label_search.TabIndex = 29
        Me.label_search.Text = "Search:"
        '
        'frmViewOrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 700)
        Me.Controls.Add(Me.panel_items)
        Me.Controls.Add(Me.panel_details)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.panel_header)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmViewOrderDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Details"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panel_details.ResumeLayout(False)
        Me.group_details.ResumeLayout(False)
        Me.group_details.PerformLayout()
        Me.panel_items.ResumeLayout(False)
        Me.group_items.ResumeLayout(False)
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_items_search.ResumeLayout(False)
        Me.panel_items_search.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents lable_header_title As Label
    Friend WithEvents btn_close As Button
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents panel_details As Panel
    Friend WithEvents group_details As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents label_address As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents label_firstName As Label
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTransactionCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents panel_items As Panel
    Friend WithEvents group_items As GroupBox
    Friend WithEvents xDataGrid As DataGridView
    Friend WithEvents panel_items_search As Panel
    Friend WithEvents txtpaymentType As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_searchbox As TextBox
    Friend WithEvents label_search As Label
    Friend WithEvents panel_action As Panel
    Friend WithEvents txtTotalAmountDue As TextBox
    Friend WithEvents _orderDetailID As DataGridViewTextBoxColumn
    Friend WithEvents _serialNumber As DataGridViewTextBoxColumn
    Friend WithEvents _name As DataGridViewTextBoxColumn
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
End Class
