<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewOrder
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewOrder))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.labelDateTime = New System.Windows.Forms.Label()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.panel_right = New System.Windows.Forms.Panel()
        Me.panel_left = New System.Windows.Forms.Panel()
        Me.panel_action_button = New System.Windows.Forms.Panel()
        Me.btn_save_order = New System.Windows.Forms.Button()
        Me.btn_advance_search = New System.Windows.Forms.Button()
        Me.btn_remove_item = New System.Windows.Forms.Button()
        Me.btn_add_item = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.timerDate = New System.Windows.Forms.Timer(Me.components)
        Me.panel_orderDetail = New System.Windows.Forms.Panel()
        Me.group_order_detail = New System.Windows.Forms.GroupBox()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.orderDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dropWarranty = New System.Windows.Forms.ComboBox()
        Me.txtDetailID = New System.Windows.Forms.TextBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtxtProductPrice = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProductCategory = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtProductModel = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProductBrand = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.label_productDetail = New System.Windows.Forms.Label()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.txtEndWarranty = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStartWarranty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.checkWarranty = New System.Windows.Forms.CheckBox()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTransactionCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label_orderdetail = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.NumericUpDown()
        Me.panel_product = New System.Windows.Forms.Panel()
        Me.group_product = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panel_datagridview = New System.Windows.Forms.Panel()
        Me.xDataGrid = New System.Windows.Forms.DataGridView()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me._detailID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._productID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._transaCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.panel_header.SuspendLayout()
        Me.panel_action_button.SuspendLayout()
        Me.panel_orderDetail.SuspendLayout()
        Me.group_order_detail.SuspendLayout()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_product.SuspendLayout()
        Me.group_product.SuspendLayout()
        Me.panel_datagridview.SuspendLayout()
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_header.Controls.Add(Me.labelDateTime)
        Me.panel_header.Controls.Add(Me.lable_header_title)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(1560, 60)
        Me.panel_header.TabIndex = 6
        '
        'labelDateTime
        '
        Me.labelDateTime.AutoSize = True
        Me.labelDateTime.Dock = System.Windows.Forms.DockStyle.Right
        Me.labelDateTime.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDateTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.labelDateTime.Location = New System.Drawing.Point(1407, 0)
        Me.labelDateTime.Name = "labelDateTime"
        Me.labelDateTime.Padding = New System.Windows.Forms.Padding(0, 10, 25, 0)
        Me.labelDateTime.Size = New System.Drawing.Size(153, 40)
        Me.labelDateTime.TabIndex = 2
        Me.labelDateTime.Text = "Date Time"
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
        Me.lable_header_title.Text = "Create Order"
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 911)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(1560, 10)
        Me.panel_bottom.TabIndex = 34
        '
        'panel_right
        '
        Me.panel_right.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_right.Location = New System.Drawing.Point(1550, 60)
        Me.panel_right.Name = "panel_right"
        Me.panel_right.Size = New System.Drawing.Size(10, 851)
        Me.panel_right.TabIndex = 35
        '
        'panel_left
        '
        Me.panel_left.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_left.Location = New System.Drawing.Point(0, 60)
        Me.panel_left.Name = "panel_left"
        Me.panel_left.Size = New System.Drawing.Size(10, 851)
        Me.panel_left.TabIndex = 36
        '
        'panel_action_button
        '
        Me.panel_action_button.Controls.Add(Me.btn_save_order)
        Me.panel_action_button.Controls.Add(Me.btn_advance_search)
        Me.panel_action_button.Controls.Add(Me.btn_remove_item)
        Me.panel_action_button.Controls.Add(Me.btn_add_item)
        Me.panel_action_button.Controls.Add(Me.btn_refresh)
        Me.panel_action_button.Controls.Add(Me.btn_close)
        Me.panel_action_button.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_action_button.Location = New System.Drawing.Point(10, 60)
        Me.panel_action_button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_action_button.Name = "panel_action_button"
        Me.panel_action_button.Padding = New System.Windows.Forms.Padding(5)
        Me.panel_action_button.Size = New System.Drawing.Size(110, 851)
        Me.panel_action_button.TabIndex = 37
        '
        'btn_save_order
        '
        Me.btn_save_order.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_save_order.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_save_order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_save_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save_order.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save_order.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_save_order.Location = New System.Drawing.Point(5, 605)
        Me.btn_save_order.Name = "btn_save_order"
        Me.btn_save_order.Size = New System.Drawing.Size(100, 120)
        Me.btn_save_order.TabIndex = 30
        Me.btn_save_order.TabStop = False
        Me.btn_save_order.Text = "(F10)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Save Order"
        Me.btn_save_order.UseVisualStyleBackColor = False
        '
        'btn_advance_search
        '
        Me.btn_advance_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_advance_search.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_advance_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_advance_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_advance_search.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_advance_search.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_advance_search.Location = New System.Drawing.Point(5, 485)
        Me.btn_advance_search.Name = "btn_advance_search"
        Me.btn_advance_search.Size = New System.Drawing.Size(100, 120)
        Me.btn_advance_search.TabIndex = 29
        Me.btn_advance_search.TabStop = False
        Me.btn_advance_search.Text = "(F4)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Advance Search"
        Me.btn_advance_search.UseVisualStyleBackColor = False
        '
        'btn_remove_item
        '
        Me.btn_remove_item.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_remove_item.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_remove_item.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_remove_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_remove_item.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_remove_item.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_remove_item.Location = New System.Drawing.Point(5, 365)
        Me.btn_remove_item.Name = "btn_remove_item"
        Me.btn_remove_item.Size = New System.Drawing.Size(100, 120)
        Me.btn_remove_item.TabIndex = 28
        Me.btn_remove_item.TabStop = False
        Me.btn_remove_item.Text = "(F3)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remove Item"
        Me.btn_remove_item.UseVisualStyleBackColor = False
        '
        'btn_add_item
        '
        Me.btn_add_item.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_add_item.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_add_item.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_add_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_item.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_add_item.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_add_item.Location = New System.Drawing.Point(5, 245)
        Me.btn_add_item.Name = "btn_add_item"
        Me.btn_add_item.Size = New System.Drawing.Size(100, 120)
        Me.btn_add_item.TabIndex = 27
        Me.btn_add_item.TabStop = False
        Me.btn_add_item.Text = "(F2)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Add Item"
        Me.btn_add_item.UseVisualStyleBackColor = False
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_refresh.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_refresh.Location = New System.Drawing.Point(5, 125)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(100, 120)
        Me.btn_refresh.TabIndex = 26
        Me.btn_refresh.TabStop = False
        Me.btn_refresh.Text = "(F5)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_close.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_close.Location = New System.Drawing.Point(5, 5)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(100, 120)
        Me.btn_close.TabIndex = 25
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "(Esc)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Back"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'timerDate
        '
        Me.timerDate.Enabled = True
        '
        'panel_orderDetail
        '
        Me.panel_orderDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.panel_orderDetail.Controls.Add(Me.group_order_detail)
        Me.panel_orderDetail.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_orderDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.panel_orderDetail.Location = New System.Drawing.Point(120, 60)
        Me.panel_orderDetail.Name = "panel_orderDetail"
        Me.panel_orderDetail.Padding = New System.Windows.Forms.Padding(15, 0, 15, 10)
        Me.panel_orderDetail.Size = New System.Drawing.Size(540, 851)
        Me.panel_orderDetail.TabIndex = 38
        '
        'group_order_detail
        '
        Me.group_order_detail.Controls.Add(Me.txtUnit)
        Me.group_order_detail.Controls.Add(Me.txtSupplier)
        Me.group_order_detail.Controls.Add(Me.Label8)
        Me.group_order_detail.Controls.Add(Me.orderDate)
        Me.group_order_detail.Controls.Add(Me.Label1)
        Me.group_order_detail.Controls.Add(Me.dropWarranty)
        Me.group_order_detail.Controls.Add(Me.txtDetailID)
        Me.group_order_detail.Controls.Add(Me.txtProductID)
        Me.group_order_detail.Controls.Add(Me.txtQuantity)
        Me.group_order_detail.Controls.Add(Me.Label14)
        Me.group_order_detail.Controls.Add(Me.txtxtProductPrice)
        Me.group_order_detail.Controls.Add(Me.Label12)
        Me.group_order_detail.Controls.Add(Me.txtProductCategory)
        Me.group_order_detail.Controls.Add(Me.Label10)
        Me.group_order_detail.Controls.Add(Me.txtProductModel)
        Me.group_order_detail.Controls.Add(Me.Label11)
        Me.group_order_detail.Controls.Add(Me.txtProductBrand)
        Me.group_order_detail.Controls.Add(Me.Label4)
        Me.group_order_detail.Controls.Add(Me.txtProductName)
        Me.group_order_detail.Controls.Add(Me.Label9)
        Me.group_order_detail.Controls.Add(Me.label_productDetail)
        Me.group_order_detail.Controls.Add(Me.txtSerialNumber)
        Me.group_order_detail.Controls.Add(Me.txtEndWarranty)
        Me.group_order_detail.Controls.Add(Me.Label7)
        Me.group_order_detail.Controls.Add(Me.txtStartWarranty)
        Me.group_order_detail.Controls.Add(Me.Label5)
        Me.group_order_detail.Controls.Add(Me.checkWarranty)
        Me.group_order_detail.Controls.Add(Me.txtInvoiceNo)
        Me.group_order_detail.Controls.Add(Me.Label3)
        Me.group_order_detail.Controls.Add(Me.txtTransactionCode)
        Me.group_order_detail.Controls.Add(Me.Label2)
        Me.group_order_detail.Controls.Add(Me.label_orderdetail)
        Me.group_order_detail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.group_order_detail.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_order_detail.Location = New System.Drawing.Point(15, 0)
        Me.group_order_detail.Name = "group_order_detail"
        Me.group_order_detail.Size = New System.Drawing.Size(510, 841)
        Me.group_order_detail.TabIndex = 19
        Me.group_order_detail.TabStop = False
        '
        'txtSupplier
        '
        Me.txtSupplier.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplier.Location = New System.Drawing.Point(212, 731)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.ReadOnly = True
        Me.txtSupplier.Size = New System.Drawing.Size(280, 37)
        Me.txtSupplier.TabIndex = 72
        Me.txtSupplier.TabStop = False
        Me.txtSupplier.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 737)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 24)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Supplier"
        Me.Label8.Visible = False
        '
        'orderDate
        '
        Me.orderDate.CustomFormat = "dd-MMM-yyyy"
        Me.orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.orderDate.Location = New System.Drawing.Point(212, 154)
        Me.orderDate.Name = "orderDate"
        Me.orderDate.Size = New System.Drawing.Size(280, 35)
        Me.orderDate.TabIndex = 71
        Me.orderDate.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Order Date:"
        '
        'dropWarranty
        '
        Me.dropWarranty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropWarranty.FormattingEnabled = True
        Me.dropWarranty.Items.AddRange(New Object() {"3 Months", "6 Months", "1 Year"})
        Me.dropWarranty.Location = New System.Drawing.Point(357, 520)
        Me.dropWarranty.Name = "dropWarranty"
        Me.dropWarranty.Size = New System.Drawing.Size(135, 35)
        Me.dropWarranty.TabIndex = 68
        '
        'txtDetailID
        '
        Me.txtDetailID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetailID.Location = New System.Drawing.Point(107, 679)
        Me.txtDetailID.Name = "txtDetailID"
        Me.txtDetailID.ReadOnly = True
        Me.txtDetailID.Size = New System.Drawing.Size(68, 37)
        Me.txtDetailID.TabIndex = 67
        Me.txtDetailID.TabStop = False
        Me.txtDetailID.Visible = False
        '
        'txtProductID
        '
        Me.txtProductID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductID.Location = New System.Drawing.Point(24, 679)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.ReadOnly = True
        Me.txtProductID.Size = New System.Drawing.Size(68, 37)
        Me.txtProductID.TabIndex = 66
        Me.txtProductID.TabStop = False
        Me.txtProductID.Visible = False
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.SystemColors.Control
        Me.txtQuantity.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtQuantity.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtQuantity.Location = New System.Drawing.Point(402, 286)
        Me.txtQuantity.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(90, 37)
        Me.txtQuantity.TabIndex = 2
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtQuantity.ThousandsSeparator = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(338, 293)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 24)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "Qty."
        '
        'txtxtProductPrice
        '
        Me.txtxtProductPrice.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtxtProductPrice.Location = New System.Drawing.Point(212, 458)
        Me.txtxtProductPrice.Name = "txtxtProductPrice"
        Me.txtxtProductPrice.ReadOnly = True
        Me.txtxtProductPrice.Size = New System.Drawing.Size(280, 37)
        Me.txtxtProductPrice.TabIndex = 62
        Me.txtxtProductPrice.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 464)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 24)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Price"
        '
        'txtProductCategory
        '
        Me.txtProductCategory.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductCategory.Location = New System.Drawing.Point(212, 774)
        Me.txtProductCategory.Name = "txtProductCategory"
        Me.txtProductCategory.ReadOnly = True
        Me.txtProductCategory.Size = New System.Drawing.Size(280, 37)
        Me.txtProductCategory.TabIndex = 58
        Me.txtProductCategory.TabStop = False
        Me.txtProductCategory.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 780)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 24)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Category"
        Me.Label10.Visible = False
        '
        'txtProductModel
        '
        Me.txtProductModel.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductModel.Location = New System.Drawing.Point(212, 415)
        Me.txtProductModel.Name = "txtProductModel"
        Me.txtProductModel.ReadOnly = True
        Me.txtProductModel.Size = New System.Drawing.Size(280, 37)
        Me.txtProductModel.TabIndex = 56
        Me.txtProductModel.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 421)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 24)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Model"
        '
        'txtProductBrand
        '
        Me.txtProductBrand.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductBrand.Location = New System.Drawing.Point(212, 372)
        Me.txtProductBrand.Name = "txtProductBrand"
        Me.txtProductBrand.ReadOnly = True
        Me.txtProductBrand.Size = New System.Drawing.Size(280, 37)
        Me.txtProductBrand.TabIndex = 54
        Me.txtProductBrand.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 24)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Brand"
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(212, 329)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(280, 37)
        Me.txtProductName.TabIndex = 52
        Me.txtProductName.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 24)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Product Name"
        '
        'label_productDetail
        '
        Me.label_productDetail.AutoSize = True
        Me.label_productDetail.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_productDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.label_productDetail.Location = New System.Drawing.Point(19, 239)
        Me.label_productDetail.Name = "label_productDetail"
        Me.label_productDetail.Size = New System.Drawing.Size(350, 30)
        Me.label_productDetail.TabIndex = 31
        Me.label_productDetail.Text = "Scan Product Serial Number"
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerialNumber.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerialNumber.Location = New System.Drawing.Point(24, 286)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(278, 37)
        Me.txtSerialNumber.TabIndex = 1
        '
        'txtEndWarranty
        '
        Me.txtEndWarranty.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndWarranty.Location = New System.Drawing.Point(212, 604)
        Me.txtEndWarranty.Name = "txtEndWarranty"
        Me.txtEndWarranty.ReadOnly = True
        Me.txtEndWarranty.Size = New System.Drawing.Size(280, 37)
        Me.txtEndWarranty.TabIndex = 48
        Me.txtEndWarranty.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 610)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 24)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "End of Warranty"
        '
        'txtStartWarranty
        '
        Me.txtStartWarranty.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartWarranty.Location = New System.Drawing.Point(212, 561)
        Me.txtStartWarranty.Name = "txtStartWarranty"
        Me.txtStartWarranty.ReadOnly = True
        Me.txtStartWarranty.Size = New System.Drawing.Size(280, 37)
        Me.txtStartWarranty.TabIndex = 46
        Me.txtStartWarranty.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 567)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 24)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Start of Warranty"
        '
        'checkWarranty
        '
        Me.checkWarranty.AutoSize = True
        Me.checkWarranty.Location = New System.Drawing.Point(212, 523)
        Me.checkWarranty.Name = "checkWarranty"
        Me.checkWarranty.Size = New System.Drawing.Size(130, 32)
        Me.checkWarranty.TabIndex = 3
        Me.checkWarranty.Text = "Warranty"
        Me.checkWarranty.UseVisualStyleBackColor = True
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(212, 111)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(280, 37)
        Me.txtInvoiceNo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 24)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Invoice No.:"
        '
        'txtTransactionCode
        '
        Me.txtTransactionCode.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionCode.Location = New System.Drawing.Point(212, 68)
        Me.txtTransactionCode.Name = "txtTransactionCode"
        Me.txtTransactionCode.ReadOnly = True
        Me.txtTransactionCode.Size = New System.Drawing.Size(280, 37)
        Me.txtTransactionCode.TabIndex = 32
        Me.txtTransactionCode.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Transaction Code:"
        '
        'label_orderdetail
        '
        Me.label_orderdetail.AutoSize = True
        Me.label_orderdetail.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_orderdetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.label_orderdetail.Location = New System.Drawing.Point(15, 28)
        Me.label_orderdetail.Name = "label_orderdetail"
        Me.label_orderdetail.Size = New System.Drawing.Size(168, 30)
        Me.label_orderdetail.TabIndex = 31
        Me.label_orderdetail.Text = "Order Details"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubTotal.DecimalPlaces = 2
        Me.txtSubTotal.Font = New System.Drawing.Font("Helvetica", 23.0!, System.Drawing.FontStyle.Bold)
        Me.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtSubTotal.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubTotal.InterceptArrowKeys = False
        Me.txtSubTotal.Location = New System.Drawing.Point(283, 33)
        Me.txtSubTotal.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(500, 49)
        Me.txtSubTotal.TabIndex = 42
        Me.txtSubTotal.TabStop = False
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSubTotal.ThousandsSeparator = True
        '
        'panel_product
        '
        Me.panel_product.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.panel_product.Controls.Add(Me.group_product)
        Me.panel_product.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_product.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.panel_product.Location = New System.Drawing.Point(660, 60)
        Me.panel_product.Name = "panel_product"
        Me.panel_product.Padding = New System.Windows.Forms.Padding(15, 0, 15, 10)
        Me.panel_product.Size = New System.Drawing.Size(890, 120)
        Me.panel_product.TabIndex = 39
        '
        'group_product
        '
        Me.group_product.Controls.Add(Me.Label6)
        Me.group_product.Controls.Add(Me.txtSubTotal)
        Me.group_product.Dock = System.Windows.Forms.DockStyle.Fill
        Me.group_product.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_product.Location = New System.Drawing.Point(15, 0)
        Me.group_product.Name = "group_product"
        Me.group_product.Size = New System.Drawing.Size(860, 110)
        Me.group_product.TabIndex = 20
        Me.group_product.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(20, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 30)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Total Amount Due"
        '
        'panel_datagridview
        '
        Me.panel_datagridview.Controls.Add(Me.xDataGrid)
        Me.panel_datagridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_datagridview.Location = New System.Drawing.Point(660, 180)
        Me.panel_datagridview.Name = "panel_datagridview"
        Me.panel_datagridview.Size = New System.Drawing.Size(890, 731)
        Me.panel_datagridview.TabIndex = 40
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.xDataGrid.ColumnHeadersHeight = 40
        Me.xDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.xDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._detailID, Me._productID, Me._transaCode, Me._serialNumber, Me._name, Me._brand, Me._model, Me._category, Me._supplier, Me._quantity, Me._unit, Me._price, Me._total, Me._warrantyStart, Me._warrantyEnd})
        Me.xDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xDataGrid.EnableHeadersVisualStyles = False
        Me.xDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.xDataGrid.MultiSelect = False
        Me.xDataGrid.Name = "xDataGrid"
        Me.xDataGrid.ReadOnly = True
        Me.xDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Helvetica", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.xDataGrid.Size = New System.Drawing.Size(890, 731)
        Me.xDataGrid.TabIndex = 2
        Me.xDataGrid.TabStop = False
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(192, 679)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.ReadOnly = True
        Me.txtUnit.Size = New System.Drawing.Size(70, 37)
        Me.txtUnit.TabIndex = 74
        Me.txtUnit.TabStop = False
        Me.txtUnit.Visible = False
        '
        '_detailID
        '
        Me._detailID.HeaderText = "Detail ID"
        Me._detailID.MinimumWidth = 6
        Me._detailID.Name = "_detailID"
        Me._detailID.ReadOnly = True
        Me._detailID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._detailID.Visible = False
        Me._detailID.Width = 96
        '
        '_productID
        '
        Me._productID.HeaderText = "Product ID"
        Me._productID.MinimumWidth = 6
        Me._productID.Name = "_productID"
        Me._productID.ReadOnly = True
        Me._productID.Visible = False
        Me._productID.Width = 137
        '
        '_transaCode
        '
        Me._transaCode.HeaderText = "Code"
        Me._transaCode.MinimumWidth = 6
        Me._transaCode.Name = "_transaCode"
        Me._transaCode.ReadOnly = True
        Me._transaCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._transaCode.Width = 64
        '
        '_serialNumber
        '
        Me._serialNumber.HeaderText = "Serial Number"
        Me._serialNumber.MinimumWidth = 6
        Me._serialNumber.Name = "_serialNumber"
        Me._serialNumber.ReadOnly = True
        Me._serialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._serialNumber.Width = 146
        '
        '_name
        '
        Me._name.HeaderText = "Name"
        Me._name.MinimumWidth = 6
        Me._name.Name = "_name"
        Me._name.ReadOnly = True
        Me._name.Width = 92
        '
        '_brand
        '
        Me._brand.HeaderText = "Brand"
        Me._brand.MinimumWidth = 6
        Me._brand.Name = "_brand"
        Me._brand.ReadOnly = True
        Me._brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._brand.Width = 69
        '
        '_model
        '
        Me._model.HeaderText = "Model"
        Me._model.MinimumWidth = 6
        Me._model.Name = "_model"
        Me._model.ReadOnly = True
        Me._model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._model.Width = 72
        '
        '_category
        '
        Me._category.HeaderText = "Category"
        Me._category.MinimumWidth = 6
        Me._category.Name = "_category"
        Me._category.ReadOnly = True
        Me._category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._category.Width = 101
        '
        '_supplier
        '
        Me._supplier.HeaderText = "Supplier"
        Me._supplier.MinimumWidth = 6
        Me._supplier.Name = "_supplier"
        Me._supplier.ReadOnly = True
        Me._supplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._supplier.Width = 91
        '
        '_quantity
        '
        Me._quantity.HeaderText = "Quantity"
        Me._quantity.MinimumWidth = 6
        Me._quantity.Name = "_quantity"
        Me._quantity.ReadOnly = True
        Me._quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._quantity.Width = 94
        '
        '_unit
        '
        Me._unit.HeaderText = "Unit"
        Me._unit.MinimumWidth = 6
        Me._unit.Name = "_unit"
        Me._unit.ReadOnly = True
        Me._unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._unit.Width = 53
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
        Me._price.Width = 62
        '
        '_total
        '
        DataGridViewCellStyle3.Format = "N2"
        Me._total.DefaultCellStyle = DataGridViewCellStyle3
        Me._total.HeaderText = "Total"
        Me._total.MinimumWidth = 6
        Me._total.Name = "_total"
        Me._total.ReadOnly = True
        Me._total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._total.Width = 61
        '
        '_warrantyStart
        '
        DataGridViewCellStyle4.Format = "yyyy-MM-dd"
        Me._warrantyStart.DefaultCellStyle = DataGridViewCellStyle4
        Me._warrantyStart.HeaderText = "Warranty Start"
        Me._warrantyStart.MinimumWidth = 6
        Me._warrantyStart.Name = "_warrantyStart"
        Me._warrantyStart.ReadOnly = True
        Me._warrantyStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._warrantyStart.Width = 150
        '
        '_warrantyEnd
        '
        DataGridViewCellStyle5.Format = "yyyy-MM-dd"
        Me._warrantyEnd.DefaultCellStyle = DataGridViewCellStyle5
        Me._warrantyEnd.HeaderText = "Warranty End"
        Me._warrantyEnd.MinimumWidth = 6
        Me._warrantyEnd.Name = "_warrantyEnd"
        Me._warrantyEnd.ReadOnly = True
        Me._warrantyEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._warrantyEnd.Width = 139
        '
        'frmNewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1560, 921)
        Me.Controls.Add(Me.panel_datagridview)
        Me.Controls.Add(Me.panel_product)
        Me.Controls.Add(Me.panel_orderDetail)
        Me.Controls.Add(Me.panel_action_button)
        Me.Controls.Add(Me.panel_left)
        Me.Controls.Add(Me.panel_right)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.panel_header)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(1366, 768)
        Me.Name = "frmNewOrder"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Order"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panel_action_button.ResumeLayout(False)
        Me.panel_orderDetail.ResumeLayout(False)
        Me.group_order_detail.ResumeLayout(False)
        Me.group_order_detail.PerformLayout()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_product.ResumeLayout(False)
        Me.group_product.ResumeLayout(False)
        Me.group_product.PerformLayout()
        Me.panel_datagridview.ResumeLayout(False)
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents lable_header_title As Label
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents panel_right As Panel
    Friend WithEvents panel_left As Panel
    Friend WithEvents panel_action_button As Panel
    Friend WithEvents labelDateTime As Label
    Friend WithEvents timerDate As Timer
    Friend WithEvents panel_orderDetail As Panel
    Friend WithEvents group_order_detail As GroupBox
    Friend WithEvents label_orderdetail As Label
    Friend WithEvents txtTransactionCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSubTotal As NumericUpDown
    Friend WithEvents panel_product As Panel
    Friend WithEvents group_product As GroupBox
    Friend WithEvents label_productDetail As Label
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents panel_datagridview As Panel
    Friend WithEvents xDataGrid As DataGridView
    Friend WithEvents checkWarranty As CheckBox
    Friend WithEvents txtStartWarranty As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEndWarranty As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtxtProductPrice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtProductCategory As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtProductModel As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtProductBrand As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtQuantity As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDetailID As TextBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents dropWarranty As ComboBox
    Friend WithEvents orderDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_add_item As Button
    Friend WithEvents btn_remove_item As Button
    Friend WithEvents btn_advance_search As Button
    Friend WithEvents btn_save_order As Button
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents _detailID As DataGridViewTextBoxColumn
    Friend WithEvents _productID As DataGridViewTextBoxColumn
    Friend WithEvents _transaCode As DataGridViewTextBoxColumn
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
