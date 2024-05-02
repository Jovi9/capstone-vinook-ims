<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewStockDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewStockDetails))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.txtDateIn = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dropSupplier = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDID = New System.Windows.Forms.TextBox()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.labelQuantity = New System.Windows.Forms.Label()
        Me.label_markup = New System.Windows.Forms.Label()
        Me.label_unit = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.txtTotalQuantity = New System.Windows.Forms.TextBox()
        Me.txtOnHand = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label_supplier = New System.Windows.Forms.Label()
        Me.label_name = New System.Windows.Forms.Label()
        Me.txtMarkUp = New System.Windows.Forms.NumericUpDown()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.panel_header.SuspendLayout()
        CType(Me.txtMarkUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_header.Controls.Add(Me.btnClose)
        Me.panel_header.Controls.Add(Me.lable_header_title)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(1027, 60)
        Me.panel_header.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(976, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnClose.Size = New System.Drawing.Size(51, 60)
        Me.btnClose.TabIndex = 5
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "r"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lable_header_title
        '
        Me.lable_header_title.AutoSize = True
        Me.lable_header_title.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable_header_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lable_header_title.Location = New System.Drawing.Point(11, 10)
        Me.lable_header_title.Name = "lable_header_title"
        Me.lable_header_title.Size = New System.Drawing.Size(216, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "Stock Details"
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 472)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(1027, 5)
        Me.panel_bottom.TabIndex = 16
        '
        'txtDateIn
        '
        Me.txtDateIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtDateIn.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateIn.Location = New System.Drawing.Point(182, 84)
        Me.txtDateIn.Name = "txtDateIn"
        Me.txtDateIn.ReadOnly = True
        Me.txtDateIn.Size = New System.Drawing.Size(280, 37)
        Me.txtDateIn.TabIndex = 125
        Me.txtDateIn.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 24)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "Date In"
        '
        'dropSupplier
        '
        Me.dropSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropSupplier.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.dropSupplier.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropSupplier.FormattingEnabled = True
        Me.dropSupplier.Items.AddRange(New Object() {"--Choose Category--", "Inks", "Laptop"})
        Me.dropSupplier.Location = New System.Drawing.Point(713, 299)
        Me.dropSupplier.Name = "dropSupplier"
        Me.dropSupplier.Size = New System.Drawing.Size(280, 38)
        Me.dropSupplier.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(497, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 28)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "Supplier:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(497, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 24)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Serial Number"
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtSerialNumber.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerialNumber.Location = New System.Drawing.Point(713, 127)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.ReadOnly = True
        Me.txtSerialNumber.Size = New System.Drawing.Size(280, 37)
        Me.txtSerialNumber.TabIndex = 121
        Me.txtSerialNumber.TabStop = False
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtPrice.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(182, 343)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(280, 37)
        Me.txtPrice.TabIndex = 120
        Me.txtPrice.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 24)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "Price"
        '
        'txtDID
        '
        Me.txtDID.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtDID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDID.Location = New System.Drawing.Point(717, 84)
        Me.txtDID.Name = "txtDID"
        Me.txtDID.ReadOnly = True
        Me.txtDID.Size = New System.Drawing.Size(63, 37)
        Me.txtDID.TabIndex = 118
        Me.txtDID.TabStop = False
        Me.txtDID.Visible = False
        '
        'txtProductCode
        '
        Me.txtProductCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtProductCode.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductCode.Location = New System.Drawing.Point(182, 127)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.ReadOnly = True
        Me.txtProductCode.Size = New System.Drawing.Size(280, 37)
        Me.txtProductCode.TabIndex = 101
        Me.txtProductCode.TabStop = False
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtname.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(182, 170)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(280, 37)
        Me.txtname.TabIndex = 100
        Me.txtname.TabStop = False
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(648, 84)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(63, 37)
        Me.txtID.TabIndex = 117
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'labelQuantity
        '
        Me.labelQuantity.AutoSize = True
        Me.labelQuantity.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelQuantity.Location = New System.Drawing.Point(35, 262)
        Me.labelQuantity.Name = "labelQuantity"
        Me.labelQuantity.Size = New System.Drawing.Size(64, 24)
        Me.labelQuantity.TabIndex = 109
        Me.labelQuantity.Text = "Model"
        '
        'label_markup
        '
        Me.label_markup.AutoSize = True
        Me.label_markup.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_markup.Location = New System.Drawing.Point(35, 219)
        Me.label_markup.Name = "label_markup"
        Me.label_markup.Size = New System.Drawing.Size(63, 24)
        Me.label_markup.TabIndex = 107
        Me.label_markup.Text = "Brand"
        '
        'label_unit
        '
        Me.label_unit.AutoSize = True
        Me.label_unit.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_unit.Location = New System.Drawing.Point(497, 262)
        Me.label_unit.Name = "label_unit"
        Me.label_unit.Size = New System.Drawing.Size(45, 24)
        Me.label_unit.TabIndex = 116
        Me.label_unit.Text = "Unit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(497, 349)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "At Cost"
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtCategory.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(182, 299)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(280, 37)
        Me.txtCategory.TabIndex = 113
        Me.txtCategory.TabStop = False
        '
        'txtBrand
        '
        Me.txtBrand.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBrand.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrand.Location = New System.Drawing.Point(182, 213)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.ReadOnly = True
        Me.txtBrand.Size = New System.Drawing.Size(280, 37)
        Me.txtBrand.TabIndex = 102
        Me.txtBrand.TabStop = False
        '
        'txtTotalQuantity
        '
        Me.txtTotalQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtTotalQuantity.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalQuantity.Location = New System.Drawing.Point(713, 170)
        Me.txtTotalQuantity.Name = "txtTotalQuantity"
        Me.txtTotalQuantity.ReadOnly = True
        Me.txtTotalQuantity.Size = New System.Drawing.Size(280, 37)
        Me.txtTotalQuantity.TabIndex = 114
        Me.txtTotalQuantity.TabStop = False
        '
        'txtOnHand
        '
        Me.txtOnHand.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtOnHand.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOnHand.Location = New System.Drawing.Point(713, 213)
        Me.txtOnHand.Name = "txtOnHand"
        Me.txtOnHand.ReadOnly = True
        Me.txtOnHand.Size = New System.Drawing.Size(280, 37)
        Me.txtOnHand.TabIndex = 115
        Me.txtOnHand.TabStop = False
        '
        'txtModel
        '
        Me.txtModel.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModel.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Location = New System.Drawing.Point(182, 256)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(280, 37)
        Me.txtModel.TabIndex = 103
        Me.txtModel.TabStop = False
        '
        'txtUnit
        '
        Me.txtUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtUnit.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(713, 256)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.ReadOnly = True
        Me.txtUnit.Size = New System.Drawing.Size(280, 37)
        Me.txtUnit.TabIndex = 112
        Me.txtUnit.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(497, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 24)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Total Stock Received"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(497, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 24)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "In Stock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 24)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Product Code"
        '
        'label_supplier
        '
        Me.label_supplier.AutoSize = True
        Me.label_supplier.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_supplier.Location = New System.Drawing.Point(35, 306)
        Me.label_supplier.Name = "label_supplier"
        Me.label_supplier.Size = New System.Drawing.Size(91, 24)
        Me.label_supplier.TabIndex = 106
        Me.label_supplier.Text = "Category"
        '
        'label_name
        '
        Me.label_name.AutoSize = True
        Me.label_name.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_name.Location = New System.Drawing.Point(35, 176)
        Me.label_name.Name = "label_name"
        Me.label_name.Size = New System.Drawing.Size(63, 24)
        Me.label_name.TabIndex = 104
        Me.label_name.Text = "Name"
        '
        'txtMarkUp
        '
        Me.txtMarkUp.DecimalPlaces = 2
        Me.txtMarkUp.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtMarkUp.Location = New System.Drawing.Point(712, 344)
        Me.txtMarkUp.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.txtMarkUp.Name = "txtMarkUp"
        Me.txtMarkUp.Size = New System.Drawing.Size(281, 37)
        Me.txtMarkUp.TabIndex = 1
        Me.txtMarkUp.ThousandsSeparator = True
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_update.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_update.Location = New System.Drawing.Point(713, 398)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(280, 57)
        Me.btn_update.TabIndex = 127
        Me.btn_update.TabStop = False
        Me.btn_update.Text = "(F10) Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'txtReference
        '
        Me.txtReference.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtReference.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReference.Location = New System.Drawing.Point(786, 84)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.ReadOnly = True
        Me.txtReference.Size = New System.Drawing.Size(63, 37)
        Me.txtReference.TabIndex = 128
        Me.txtReference.TabStop = False
        Me.txtReference.Visible = False
        '
        'frmViewStockDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1027, 477)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txtMarkUp)
        Me.Controls.Add(Me.txtDateIn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dropSupplier)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSerialNumber)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDID)
        Me.Controls.Add(Me.txtProductCode)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.labelQuantity)
        Me.Controls.Add(Me.label_markup)
        Me.Controls.Add(Me.label_unit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.txtTotalQuantity)
        Me.Controls.Add(Me.txtOnHand)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label_supplier)
        Me.Controls.Add(Me.label_name)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.panel_header)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmViewStockDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Details"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        CType(Me.txtMarkUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel_header As Panel
    Friend WithEvents lable_header_title As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents txtDateIn As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dropSupplier As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDID As TextBox
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents labelQuantity As Label
    Friend WithEvents label_markup As Label
    Friend WithEvents label_unit As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents txtTotalQuantity As TextBox
    Friend WithEvents txtOnHand As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label_supplier As Label
    Friend WithEvents label_name As Label
    Friend WithEvents txtMarkUp As NumericUpDown
    Friend WithEvents btn_update As Button
    Friend WithEvents txtReference As TextBox
End Class
