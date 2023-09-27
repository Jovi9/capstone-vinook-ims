<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewProduct))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.dropCategory = New System.Windows.Forms.ComboBox()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.label_serial = New System.Windows.Forms.Label()
        Me.label_name = New System.Windows.Forms.Label()
        Me.label_supplier = New System.Windows.Forms.Label()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.label_markup = New System.Windows.Forms.Label()
        Me.label_unit = New System.Windows.Forms.Label()
        Me.labelQuantity = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dropUnit = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.txtPrice = New System.Windows.Forms.NumericUpDown()
        Me.btnAddCategory = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.btn_save_product = New System.Windows.Forms.Button()
        Me.btnAddUnit = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panel_header.SuspendLayout()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panel_header.Size = New System.Drawing.Size(641, 60)
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
        Me.btn_close.Location = New System.Drawing.Point(590, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btn_close.Size = New System.Drawing.Size(51, 60)
        Me.btn_close.TabIndex = 8
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
        Me.lable_header_title.Size = New System.Drawing.Size(212, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "New Product"
        '
        'dropCategory
        '
        Me.dropCategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dropCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropCategory.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropCategory.FormattingEnabled = True
        Me.dropCategory.Location = New System.Drawing.Point(211, 284)
        Me.dropCategory.Name = "dropCategory"
        Me.dropCategory.Size = New System.Drawing.Size(370, 38)
        Me.dropCategory.TabIndex = 4
        '
        'txtProductId
        '
        Me.txtProductId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtProductId.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductId.Location = New System.Drawing.Point(103, 499)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.Size = New System.Drawing.Size(60, 37)
        Me.txtProductId.TabIndex = 7
        Me.txtProductId.TabStop = False
        Me.txtProductId.Visible = False
        '
        'label_serial
        '
        Me.label_serial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_serial.AutoSize = True
        Me.label_serial.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_serial.Location = New System.Drawing.Point(54, 507)
        Me.label_serial.Name = "label_serial"
        Me.label_serial.Size = New System.Drawing.Size(43, 24)
        Me.label_serial.TabIndex = 29
        Me.label_serial.Text = "PID"
        Me.label_serial.Visible = False
        '
        'label_name
        '
        Me.label_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_name.AutoSize = True
        Me.label_name.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_name.Location = New System.Drawing.Point(60, 161)
        Me.label_name.Name = "label_name"
        Me.label_name.Size = New System.Drawing.Size(63, 24)
        Me.label_name.TabIndex = 24
        Me.label_name.Text = "Name"
        '
        'label_supplier
        '
        Me.label_supplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_supplier.AutoSize = True
        Me.label_supplier.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_supplier.Location = New System.Drawing.Point(60, 291)
        Me.label_supplier.Name = "label_supplier"
        Me.label_supplier.Size = New System.Drawing.Size(91, 24)
        Me.label_supplier.TabIndex = 25
        Me.label_supplier.Text = "Category"
        '
        'txtBrand
        '
        Me.txtBrand.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBrand.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrand.Location = New System.Drawing.Point(211, 198)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(370, 37)
        Me.txtBrand.TabIndex = 2
        '
        'label_markup
        '
        Me.label_markup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_markup.AutoSize = True
        Me.label_markup.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_markup.Location = New System.Drawing.Point(60, 204)
        Me.label_markup.Name = "label_markup"
        Me.label_markup.Size = New System.Drawing.Size(63, 24)
        Me.label_markup.TabIndex = 26
        Me.label_markup.Text = "Brand"
        '
        'label_unit
        '
        Me.label_unit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_unit.AutoSize = True
        Me.label_unit.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_unit.Location = New System.Drawing.Point(60, 359)
        Me.label_unit.Name = "label_unit"
        Me.label_unit.Size = New System.Drawing.Size(45, 24)
        Me.label_unit.TabIndex = 27
        Me.label_unit.Text = "Unit"
        '
        'labelQuantity
        '
        Me.labelQuantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelQuantity.AutoSize = True
        Me.labelQuantity.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelQuantity.Location = New System.Drawing.Point(60, 247)
        Me.labelQuantity.Name = "labelQuantity"
        Me.labelQuantity.Size = New System.Drawing.Size(64, 24)
        Me.labelQuantity.TabIndex = 28
        Me.labelQuantity.Text = "Model"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(211, 155)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(370, 37)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 426)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 24)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Markup"
        '
        'dropUnit
        '
        Me.dropUnit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dropUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropUnit.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropUnit.FormattingEnabled = True
        Me.dropUnit.Items.AddRange(New Object() {"pcs"})
        Me.dropUnit.Location = New System.Drawing.Point(211, 352)
        Me.dropUnit.Name = "dropUnit"
        Me.dropUnit.Size = New System.Drawing.Size(370, 38)
        Me.dropUnit.TabIndex = 6
        '
        'txtModel
        '
        Me.txtModel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModel.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Location = New System.Drawing.Point(211, 241)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(370, 37)
        Me.txtModel.TabIndex = 3
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 586)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(641, 5)
        Me.panel_bottom.TabIndex = 33
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice.DecimalPlaces = 2
        Me.txtPrice.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtPrice.Location = New System.Drawing.Point(211, 420)
        Me.txtPrice.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.txtPrice.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(370, 37)
        Me.txtPrice.TabIndex = 7
        Me.txtPrice.ThousandsSeparator = True
        Me.txtPrice.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnAddCategory
        '
        Me.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddCategory.AutoSize = True
        Me.btnAddCategory.Font = New System.Drawing.Font("Helvetica", 12.0!)
        Me.btnAddCategory.Location = New System.Drawing.Point(207, 325)
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.Size = New System.Drawing.Size(132, 24)
        Me.btnAddCategory.TabIndex = 5
        Me.btnAddCategory.TabStop = True
        Me.btnAddCategory.Text = "Add Category"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 24)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Product Code:"
        '
        'txtItemCode
        '
        Me.txtItemCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemCode.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Location = New System.Drawing.Point(211, 112)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(370, 37)
        Me.txtItemCode.TabIndex = 0
        '
        'btn_save_product
        '
        Me.btn_save_product.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save_product.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_save_product.FlatAppearance.BorderSize = 0
        Me.btn_save_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save_product.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save_product.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_save_product.Location = New System.Drawing.Point(211, 479)
        Me.btn_save_product.Name = "btn_save_product"
        Me.btn_save_product.Size = New System.Drawing.Size(370, 70)
        Me.btn_save_product.TabIndex = 37
        Me.btn_save_product.TabStop = False
        Me.btn_save_product.Text = "(F10) Save"
        Me.btn_save_product.UseVisualStyleBackColor = False
        '
        'btnAddUnit
        '
        Me.btnAddUnit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddUnit.AutoSize = True
        Me.btnAddUnit.Font = New System.Drawing.Font("Helvetica", 12.0!)
        Me.btnAddUnit.Location = New System.Drawing.Point(207, 393)
        Me.btnAddUnit.Name = "btnAddUnit"
        Me.btnAddUnit.Size = New System.Drawing.Size(86, 24)
        Me.btnAddUnit.TabIndex = 38
        Me.btnAddUnit.TabStop = True
        Me.btnAddUnit.Text = "Add Unit"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(207, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 22)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Type or Scan Product Code"
        '
        'frmNewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(641, 591)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAddUnit)
        Me.Controls.Add(Me.btn_save_product)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.btnAddCategory)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.dropUnit)
        Me.Controls.Add(Me.dropCategory)
        Me.Controls.Add(Me.txtProductId)
        Me.Controls.Add(Me.label_serial)
        Me.Controls.Add(Me.label_name)
        Me.Controls.Add(Me.label_supplier)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label_markup)
        Me.Controls.Add(Me.label_unit)
        Me.Controls.Add(Me.labelQuantity)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.panel_header)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmNewProduct"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Product"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents lable_header_title As Label
    Friend WithEvents dropCategory As ComboBox
    Friend WithEvents txtProductId As TextBox
    Friend WithEvents label_serial As Label
    Friend WithEvents label_name As Label
    Friend WithEvents label_supplier As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents label_markup As Label
    Friend WithEvents label_unit As Label
    Friend WithEvents labelQuantity As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dropUnit As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents txtPrice As NumericUpDown
    Friend WithEvents btnAddCategory As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents btn_save_product As Button
    Friend WithEvents btnAddUnit As LinkLabel
    Friend WithEvents Label3 As Label
End Class
