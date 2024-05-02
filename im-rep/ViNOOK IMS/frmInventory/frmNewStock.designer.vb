<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewStock))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.label_name = New System.Windows.Forms.Label()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.label_serial = New System.Windows.Forms.Label()
        Me.group_product_details = New System.Windows.Forms.GroupBox()
        Me.btn_save_stock = New System.Windows.Forms.Button()
        Me.btnSearchProduct = New System.Windows.Forms.LinkLabel()
        Me.btnAddProduct = New System.Windows.Forms.LinkLabel()
        Me.btnAddSupplier = New System.Windows.Forms.LinkLabel()
        Me.txtMarkUp = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDetailID = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dropSupplier = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.NumericUpDown()
        Me.label_supplier = New System.Windows.Forms.Label()
        Me.label_markup = New System.Windows.Forms.Label()
        Me.labelQuantity = New System.Windows.Forms.Label()
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panel_header.SuspendLayout()
        Me.group_product_details.SuspendLayout()
        CType(Me.txtMarkUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_body.SuspendLayout()
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
        Me.panel_header.Size = New System.Drawing.Size(1100, 64)
        Me.panel_header.TabIndex = 4
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
        Me.btn_close.Location = New System.Drawing.Point(1049, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btn_close.Size = New System.Drawing.Size(51, 64)
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
        Me.lable_header_title.Location = New System.Drawing.Point(11, 11)
        Me.lable_header_title.Name = "lable_header_title"
        Me.lable_header_title.Size = New System.Drawing.Size(180, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "New Stock"
        '
        'txtItemCode
        '
        Me.txtItemCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemCode.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Location = New System.Drawing.Point(175, 76)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(320, 37)
        Me.txtItemCode.TabIndex = 0
        '
        'label_name
        '
        Me.label_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_name.AutoSize = True
        Me.label_name.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_name.Location = New System.Drawing.Point(15, 83)
        Me.label_name.Name = "label_name"
        Me.label_name.Size = New System.Drawing.Size(132, 24)
        Me.label_name.TabIndex = 10
        Me.label_name.Text = "Product Code"
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 514)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(1100, 5)
        Me.panel_bottom.TabIndex = 15
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSerialNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerialNumber.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerialNumber.Location = New System.Drawing.Point(708, 74)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(320, 37)
        Me.txtSerialNumber.TabIndex = 1
        '
        'label_serial
        '
        Me.label_serial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_serial.AutoSize = True
        Me.label_serial.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_serial.Location = New System.Drawing.Point(551, 81)
        Me.label_serial.Name = "label_serial"
        Me.label_serial.Size = New System.Drawing.Size(137, 24)
        Me.label_serial.TabIndex = 17
        Me.label_serial.Text = "Serial Number"
        '
        'group_product_details
        '
        Me.group_product_details.Controls.Add(Me.Label7)
        Me.group_product_details.Controls.Add(Me.Label6)
        Me.group_product_details.Controls.Add(Me.btn_save_stock)
        Me.group_product_details.Controls.Add(Me.btnSearchProduct)
        Me.group_product_details.Controls.Add(Me.btnAddProduct)
        Me.group_product_details.Controls.Add(Me.btnAddSupplier)
        Me.group_product_details.Controls.Add(Me.txtMarkUp)
        Me.group_product_details.Controls.Add(Me.Label5)
        Me.group_product_details.Controls.Add(Me.Label4)
        Me.group_product_details.Controls.Add(Me.Label3)
        Me.group_product_details.Controls.Add(Me.Label2)
        Me.group_product_details.Controls.Add(Me.txtPrice)
        Me.group_product_details.Controls.Add(Me.txtCategory)
        Me.group_product_details.Controls.Add(Me.txtModel)
        Me.group_product_details.Controls.Add(Me.txtBrand)
        Me.group_product_details.Controls.Add(Me.Label1)
        Me.group_product_details.Controls.Add(Me.txtName)
        Me.group_product_details.Controls.Add(Me.txtDetailID)
        Me.group_product_details.Controls.Add(Me.txtID)
        Me.group_product_details.Controls.Add(Me.dropSupplier)
        Me.group_product_details.Controls.Add(Me.txtQuantity)
        Me.group_product_details.Controls.Add(Me.txtSerialNumber)
        Me.group_product_details.Controls.Add(Me.label_serial)
        Me.group_product_details.Controls.Add(Me.label_name)
        Me.group_product_details.Controls.Add(Me.label_supplier)
        Me.group_product_details.Controls.Add(Me.label_markup)
        Me.group_product_details.Controls.Add(Me.labelQuantity)
        Me.group_product_details.Controls.Add(Me.txtItemCode)
        Me.group_product_details.Dock = System.Windows.Forms.DockStyle.Fill
        Me.group_product_details.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_product_details.Location = New System.Drawing.Point(15, 16)
        Me.group_product_details.Name = "group_product_details"
        Me.group_product_details.Size = New System.Drawing.Size(1070, 418)
        Me.group_product_details.TabIndex = 18
        Me.group_product_details.TabStop = False
        Me.group_product_details.Text = "Product Details"
        '
        'btn_save_stock
        '
        Me.btn_save_stock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save_stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_save_stock.FlatAppearance.BorderSize = 0
        Me.btn_save_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save_stock.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save_stock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_save_stock.Location = New System.Drawing.Point(708, 337)
        Me.btn_save_stock.Name = "btn_save_stock"
        Me.btn_save_stock.Size = New System.Drawing.Size(320, 61)
        Me.btn_save_stock.TabIndex = 44
        Me.btn_save_stock.TabStop = False
        Me.btn_save_stock.Text = "(F10) Save"
        Me.btn_save_stock.UseVisualStyleBackColor = False
        '
        'btnSearchProduct
        '
        Me.btnSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearchProduct.AutoSize = True
        Me.btnSearchProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchProduct.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchProduct.Location = New System.Drawing.Point(335, 116)
        Me.btnSearchProduct.Name = "btnSearchProduct"
        Me.btnSearchProduct.Size = New System.Drawing.Size(148, 24)
        Me.btnSearchProduct.TabIndex = 7
        Me.btnSearchProduct.TabStop = True
        Me.btnSearchProduct.Text = "Search Product"
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddProduct.AutoSize = True
        Me.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProduct.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.Location = New System.Drawing.Point(183, 116)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(120, 24)
        Me.btnAddProduct.TabIndex = 6
        Me.btnAddProduct.TabStop = True
        Me.btnAddProduct.Text = "Add Product"
        '
        'btnAddSupplier
        '
        Me.btnAddSupplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddSupplier.AutoSize = True
        Me.btnAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddSupplier.Enabled = False
        Me.btnAddSupplier.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSupplier.Location = New System.Drawing.Point(704, 207)
        Me.btnAddSupplier.Name = "btnAddSupplier"
        Me.btnAddSupplier.Size = New System.Drawing.Size(123, 24)
        Me.btnAddSupplier.TabIndex = 4
        Me.btnAddSupplier.TabStop = True
        Me.btnAddSupplier.Text = "Add Supplier"
        '
        'txtMarkUp
        '
        Me.txtMarkUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMarkUp.DecimalPlaces = 2
        Me.txtMarkUp.Enabled = False
        Me.txtMarkUp.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtMarkUp.Location = New System.Drawing.Point(708, 120)
        Me.txtMarkUp.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.txtMarkUp.Name = "txtMarkUp"
        Me.txtMarkUp.Size = New System.Drawing.Size(320, 37)
        Me.txtMarkUp.TabIndex = 2
        Me.txtMarkUp.ThousandsSeparator = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 24)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Price"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 24)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Category"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Model"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 24)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Brand"
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrice.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(175, 333)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(320, 37)
        Me.txtPrice.TabIndex = 42
        Me.txtPrice.TabStop = False
        '
        'txtCategory
        '
        Me.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategory.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(175, 290)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(320, 37)
        Me.txtCategory.TabIndex = 42
        Me.txtCategory.TabStop = False
        '
        'txtModel
        '
        Me.txtModel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModel.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Location = New System.Drawing.Point(175, 244)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(320, 37)
        Me.txtModel.TabIndex = 42
        Me.txtModel.TabStop = False
        '
        'txtBrand
        '
        Me.txtBrand.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBrand.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrand.Location = New System.Drawing.Point(175, 198)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.ReadOnly = True
        Me.txtBrand.Size = New System.Drawing.Size(320, 37)
        Me.txtBrand.TabIndex = 42
        Me.txtBrand.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 24)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(175, 152)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(320, 37)
        Me.txtName.TabIndex = 40
        Me.txtName.TabStop = False
        '
        'txtDetailID
        '
        Me.txtDetailID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDetailID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetailID.Location = New System.Drawing.Point(708, 290)
        Me.txtDetailID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDetailID.Name = "txtDetailID"
        Me.txtDetailID.ReadOnly = True
        Me.txtDetailID.Size = New System.Drawing.Size(79, 37)
        Me.txtDetailID.TabIndex = 39
        Me.txtDetailID.TabStop = False
        Me.txtDetailID.Visible = False
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(502, 290)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(79, 37)
        Me.txtID.TabIndex = 38
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'dropSupplier
        '
        Me.dropSupplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dropSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropSupplier.Enabled = False
        Me.dropSupplier.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropSupplier.FormattingEnabled = True
        Me.dropSupplier.Location = New System.Drawing.Point(708, 166)
        Me.dropSupplier.Name = "dropSupplier"
        Me.dropSupplier.Size = New System.Drawing.Size(320, 38)
        Me.dropSupplier.TabIndex = 3
        '
        'txtQuantity
        '
        Me.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQuantity.Enabled = False
        Me.txtQuantity.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(708, 243)
        Me.txtQuantity.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.txtQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(320, 37)
        Me.txtQuantity.TabIndex = 5
        Me.txtQuantity.ThousandsSeparator = True
        Me.txtQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label_supplier
        '
        Me.label_supplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_supplier.AutoSize = True
        Me.label_supplier.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_supplier.Location = New System.Drawing.Point(551, 173)
        Me.label_supplier.Name = "label_supplier"
        Me.label_supplier.Size = New System.Drawing.Size(82, 24)
        Me.label_supplier.TabIndex = 12
        Me.label_supplier.Text = "Supplier"
        '
        'label_markup
        '
        Me.label_markup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_markup.AutoSize = True
        Me.label_markup.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_markup.Location = New System.Drawing.Point(551, 126)
        Me.label_markup.Name = "label_markup"
        Me.label_markup.Size = New System.Drawing.Size(76, 24)
        Me.label_markup.TabIndex = 12
        Me.label_markup.Text = "At Cost"
        '
        'labelQuantity
        '
        Me.labelQuantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelQuantity.AutoSize = True
        Me.labelQuantity.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelQuantity.Location = New System.Drawing.Point(551, 249)
        Me.labelQuantity.Name = "labelQuantity"
        Me.labelQuantity.Size = New System.Drawing.Size(85, 24)
        Me.labelQuantity.TabIndex = 12
        Me.labelQuantity.Text = "Quantity"
        '
        'panel_body
        '
        Me.panel_body.AutoScroll = True
        Me.panel_body.Controls.Add(Me.group_product_details)
        Me.panel_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_body.Location = New System.Drawing.Point(0, 64)
        Me.panel_body.Name = "panel_body"
        Me.panel_body.Padding = New System.Windows.Forms.Padding(15, 16, 15, 16)
        Me.panel_body.Size = New System.Drawing.Size(1100, 450)
        Me.panel_body.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(171, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(249, 22)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Type or Scan Product Code"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(704, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(253, 22)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Type or Scan Serial Number"
        '
        'frmNewStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 519)
        Me.Controls.Add(Me.panel_body)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.panel_header)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmNewStock"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Stock"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.group_product_details.ResumeLayout(False)
        Me.group_product_details.PerformLayout()
        CType(Me.txtMarkUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_body.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents lable_header_title As Label
    Friend WithEvents btn_close As Button
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents label_name As Label
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents label_serial As Label
    Friend WithEvents group_product_details As GroupBox
    Friend WithEvents panel_body As Panel
    Friend WithEvents label_supplier As Label
    Friend WithEvents labelQuantity As Label
    Friend WithEvents dropSupplier As ComboBox
    Friend WithEvents txtQuantity As NumericUpDown
    Friend WithEvents label_markup As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtDetailID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtMarkUp As NumericUpDown
    Friend WithEvents btnAddSupplier As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents btnAddProduct As LinkLabel
    Friend WithEvents btnSearchProduct As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btn_save_stock As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
