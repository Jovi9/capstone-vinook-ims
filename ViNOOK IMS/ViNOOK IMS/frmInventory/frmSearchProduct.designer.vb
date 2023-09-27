<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearchProduct
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchProduct))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.dropCategory = New System.Windows.Forms.ComboBox()
        Me.label_category = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txt_searchbox = New System.Windows.Forms.TextBox()
        Me.label_search = New System.Windows.Forms.Label()
        Me.panel_datagridview = New System.Windows.Forms.Panel()
        Me.xDataGrid = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._itemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._onHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._actionbtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.panel_header.SuspendLayout()
        Me.panel_body.SuspendLayout()
        Me.panel_datagridview.SuspendLayout()
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lable_header_title.Size = New System.Drawing.Size(251, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "Search Product"
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 695)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(1100, 5)
        Me.panel_bottom.TabIndex = 16
        '
        'panel_body
        '
        Me.panel_body.Controls.Add(Me.btn_new)
        Me.panel_body.Controls.Add(Me.dropCategory)
        Me.panel_body.Controls.Add(Me.label_category)
        Me.panel_body.Controls.Add(Me.txtID)
        Me.panel_body.Controls.Add(Me.txt_searchbox)
        Me.panel_body.Controls.Add(Me.label_search)
        Me.panel_body.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_body.Location = New System.Drawing.Point(0, 64)
        Me.panel_body.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_body.Name = "panel_body"
        Me.panel_body.Padding = New System.Windows.Forms.Padding(10)
        Me.panel_body.Size = New System.Drawing.Size(1100, 105)
        Me.panel_body.TabIndex = 32
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_new.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_new.FlatAppearance.BorderSize = 0
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_new.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_new.Location = New System.Drawing.Point(980, 10)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(110, 85)
        Me.btn_new.TabIndex = 26
        Me.btn_new.TabStop = False
        Me.btn_new.Text = "New Product" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(CTRL + N)"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'dropCategory
        '
        Me.dropCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropCategory.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.dropCategory.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropCategory.FormattingEnabled = True
        Me.dropCategory.Items.AddRange(New Object() {"--Choose Category--", "Inks", "Laptop"})
        Me.dropCategory.Location = New System.Drawing.Point(406, 52)
        Me.dropCategory.Name = "dropCategory"
        Me.dropCategory.Size = New System.Drawing.Size(280, 38)
        Me.dropCategory.TabIndex = 5
        '
        'label_category
        '
        Me.label_category.AutoSize = True
        Me.label_category.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_category.Location = New System.Drawing.Point(401, 17)
        Me.label_category.Name = "label_category"
        Me.label_category.Size = New System.Drawing.Size(115, 28)
        Me.label_category.TabIndex = 6
        Me.label_category.Text = "Category:"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Helvetica", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(264, 10)
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
        Me.txt_searchbox.Location = New System.Drawing.Point(52, 52)
        Me.txt_searchbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_searchbox.Name = "txt_searchbox"
        Me.txt_searchbox.Size = New System.Drawing.Size(317, 39)
        Me.txt_searchbox.TabIndex = 0
        '
        'label_search
        '
        Me.label_search.AutoSize = True
        Me.label_search.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_search.Location = New System.Drawing.Point(47, 17)
        Me.label_search.Name = "label_search"
        Me.label_search.Size = New System.Drawing.Size(183, 28)
        Me.label_search.TabIndex = 2
        Me.label_search.Text = "Search Product:"
        '
        'panel_datagridview
        '
        Me.panel_datagridview.Controls.Add(Me.xDataGrid)
        Me.panel_datagridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_datagridview.Location = New System.Drawing.Point(0, 169)
        Me.panel_datagridview.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_datagridview.Name = "panel_datagridview"
        Me.panel_datagridview.Padding = New System.Windows.Forms.Padding(5)
        Me.panel_datagridview.Size = New System.Drawing.Size(1100, 526)
        Me.panel_datagridview.TabIndex = 34
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.xDataGrid.ColumnHeadersHeight = 40
        Me.xDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.xDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me._itemCode, Me._name, Me._brand, Me._model, Me._category, Me._onHand, Me._unit, Me._price, Me._actionbtn})
        Me.xDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xDataGrid.EnableHeadersVisualStyles = False
        Me.xDataGrid.Location = New System.Drawing.Point(5, 5)
        Me.xDataGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.xDataGrid.MultiSelect = False
        Me.xDataGrid.Name = "xDataGrid"
        Me.xDataGrid.ReadOnly = True
        Me.xDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.xDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.xDataGrid.RowHeadersVisible = False
        Me.xDataGrid.RowHeadersWidth = 30
        Me.xDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.xDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.xDataGrid.RowTemplate.Height = 35
        Me.xDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.xDataGrid.Size = New System.Drawing.Size(1090, 516)
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
        Me.id.Width = 35
        '
        '_itemCode
        '
        Me._itemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me._itemCode.HeaderText = "Product Code"
        Me._itemCode.MinimumWidth = 6
        Me._itemCode.Name = "_itemCode"
        Me._itemCode.ReadOnly = True
        Me._itemCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me._itemCode.Width = 133
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
        '_actionbtn
        '
        Me._actionbtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me._actionbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._actionbtn.HeaderText = "Action"
        Me._actionbtn.MinimumWidth = 6
        Me._actionbtn.Name = "_actionbtn"
        Me._actionbtn.ReadOnly = True
        Me._actionbtn.Text = "Select"
        Me._actionbtn.UseColumnTextForButtonValue = True
        Me._actionbtn.Width = 68
        '
        'frmSearchProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.panel_datagridview)
        Me.Controls.Add(Me.panel_body)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.panel_header)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmSearchProduct"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Product"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panel_body.ResumeLayout(False)
        Me.panel_body.PerformLayout()
        Me.panel_datagridview.ResumeLayout(False)
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents lable_header_title As Label
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents panel_body As Panel
    Friend WithEvents txtID As TextBox
    Friend WithEvents txt_searchbox As TextBox
    Friend WithEvents label_search As Label
    Friend WithEvents panel_datagridview As Panel
    Friend WithEvents xDataGrid As DataGridView
    Friend WithEvents dropCategory As ComboBox
    Friend WithEvents label_category As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents _itemCode As DataGridViewTextBoxColumn
    Friend WithEvents _name As DataGridViewTextBoxColumn
    Friend WithEvents _brand As DataGridViewTextBoxColumn
    Friend WithEvents _model As DataGridViewTextBoxColumn
    Friend WithEvents _category As DataGridViewTextBoxColumn
    Friend WithEvents _onHand As DataGridViewTextBoxColumn
    Friend WithEvents _unit As DataGridViewTextBoxColumn
    Friend WithEvents _price As DataGridViewTextBoxColumn
    Friend WithEvents _actionbtn As DataGridViewButtonColumn
    Friend WithEvents btn_new As Button
End Class
