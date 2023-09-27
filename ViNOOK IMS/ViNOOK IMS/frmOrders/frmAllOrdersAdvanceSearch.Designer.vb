<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAllOrdersAdvanceSearch
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAllOrdersAdvanceSearch))
        Me.panel_top = New System.Windows.Forms.Panel()
        Me.panel_left = New System.Windows.Forms.Panel()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.panel_right = New System.Windows.Forms.Panel()
        Me.panel_search = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_searchbox = New System.Windows.Forms.TextBox()
        Me.label_search = New System.Windows.Forms.Label()
        Me.panel_datagridview = New System.Windows.Forms.Panel()
        Me.xDataGrid = New System.Windows.Forms.DataGridView()
        Me._orderDetailID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._transacode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._invoice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._orderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._custName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._serialNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._productName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.panel_search.SuspendLayout()
        Me.panel_datagridview.SuspendLayout()
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(1500, 10)
        Me.panel_top.TabIndex = 44
        '
        'panel_left
        '
        Me.panel_left.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_left.Location = New System.Drawing.Point(0, 10)
        Me.panel_left.Name = "panel_left"
        Me.panel_left.Size = New System.Drawing.Size(10, 490)
        Me.panel_left.TabIndex = 45
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(10, 490)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(1490, 10)
        Me.panel_bottom.TabIndex = 46
        '
        'panel_right
        '
        Me.panel_right.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_right.Location = New System.Drawing.Point(1490, 10)
        Me.panel_right.Name = "panel_right"
        Me.panel_right.Size = New System.Drawing.Size(10, 480)
        Me.panel_right.TabIndex = 47
        '
        'panel_search
        '
        Me.panel_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.panel_search.Controls.Add(Me.btn_close)
        Me.panel_search.Controls.Add(Me.Label6)
        Me.panel_search.Controls.Add(Me.txt_searchbox)
        Me.panel_search.Controls.Add(Me.label_search)
        Me.panel_search.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_search.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.panel_search.Location = New System.Drawing.Point(10, 10)
        Me.panel_search.Name = "panel_search"
        Me.panel_search.Size = New System.Drawing.Size(1480, 122)
        Me.panel_search.TabIndex = 48
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.AutoSize = True
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_close.Location = New System.Drawing.Point(1430, -1)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btn_close.Size = New System.Drawing.Size(50, 50)
        Me.btn_close.TabIndex = 47
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "r"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(135, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(512, 22)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Transaction Code / Invoice No. / Customer / Serial Number"
        '
        'txt_searchbox
        '
        Me.txt_searchbox.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchbox.Location = New System.Drawing.Point(28, 59)
        Me.txt_searchbox.Name = "txt_searchbox"
        Me.txt_searchbox.Size = New System.Drawing.Size(513, 35)
        Me.txt_searchbox.TabIndex = 3
        '
        'label_search
        '
        Me.label_search.AutoSize = True
        Me.label_search.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_search.Location = New System.Drawing.Point(23, 28)
        Me.label_search.Name = "label_search"
        Me.label_search.Size = New System.Drawing.Size(94, 28)
        Me.label_search.TabIndex = 4
        Me.label_search.Text = "Search:"
        '
        'panel_datagridview
        '
        Me.panel_datagridview.Controls.Add(Me.xDataGrid)
        Me.panel_datagridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_datagridview.Location = New System.Drawing.Point(10, 132)
        Me.panel_datagridview.Margin = New System.Windows.Forms.Padding(4)
        Me.panel_datagridview.Name = "panel_datagridview"
        Me.panel_datagridview.Size = New System.Drawing.Size(1480, 358)
        Me.panel_datagridview.TabIndex = 49
        '
        'xDataGrid
        '
        Me.xDataGrid.AllowUserToAddRows = False
        Me.xDataGrid.AllowUserToDeleteRows = False
        Me.xDataGrid.AllowUserToResizeColumns = False
        Me.xDataGrid.AllowUserToResizeRows = False
        Me.xDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.xDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.xDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.xDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.xDataGrid.ColumnHeadersHeight = 40
        Me.xDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.xDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._orderDetailID, Me._transacode, Me._invoice, Me._orderDate, Me._custName, Me._serialNumber, Me._productName, Me._category, Me._supplier, Me._action})
        Me.xDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xDataGrid.EnableHeadersVisualStyles = False
        Me.xDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.xDataGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.xDataGrid.MultiSelect = False
        Me.xDataGrid.Name = "xDataGrid"
        Me.xDataGrid.ReadOnly = True
        Me.xDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.xDataGrid.RowTemplate.Height = 35
        Me.xDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.xDataGrid.Size = New System.Drawing.Size(1480, 358)
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
        '
        '_transacode
        '
        Me._transacode.HeaderText = "Transaction Code"
        Me._transacode.MinimumWidth = 6
        Me._transacode.Name = "_transacode"
        Me._transacode.ReadOnly = True
        Me._transacode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '_invoice
        '
        Me._invoice.HeaderText = "Invoice No."
        Me._invoice.MinimumWidth = 6
        Me._invoice.Name = "_invoice"
        Me._invoice.ReadOnly = True
        Me._invoice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        '
        '_custName
        '
        Me._custName.HeaderText = "Customer"
        Me._custName.MinimumWidth = 6
        Me._custName.Name = "_custName"
        Me._custName.ReadOnly = True
        Me._custName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '_serialNumber
        '
        Me._serialNumber.HeaderText = "Serial Number"
        Me._serialNumber.MinimumWidth = 6
        Me._serialNumber.Name = "_serialNumber"
        Me._serialNumber.ReadOnly = True
        Me._serialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '_productName
        '
        Me._productName.HeaderText = "Product Description"
        Me._productName.MinimumWidth = 6
        Me._productName.Name = "_productName"
        Me._productName.ReadOnly = True
        Me._productName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '_category
        '
        Me._category.HeaderText = "Category"
        Me._category.MinimumWidth = 6
        Me._category.Name = "_category"
        Me._category.ReadOnly = True
        Me._category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '_supplier
        '
        Me._supplier.HeaderText = "Supplier"
        Me._supplier.MinimumWidth = 6
        Me._supplier.Name = "_supplier"
        Me._supplier.ReadOnly = True
        Me._supplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '_action
        '
        Me._action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me._action.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._action.HeaderText = "Action"
        Me._action.MinimumWidth = 6
        Me._action.Name = "_action"
        Me._action.ReadOnly = True
        Me._action.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me._action.Text = "View"
        Me._action.UseColumnTextForButtonValue = True
        Me._action.Width = 69
        '
        'frmAllOrdersAdvanceSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1500, 500)
        Me.Controls.Add(Me.panel_datagridview)
        Me.Controls.Add(Me.panel_search)
        Me.Controls.Add(Me.panel_right)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.panel_left)
        Me.Controls.Add(Me.panel_top)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmAllOrdersAdvanceSearch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advance Search"
        Me.panel_search.ResumeLayout(False)
        Me.panel_search.PerformLayout()
        Me.panel_datagridview.ResumeLayout(False)
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Panel
    Friend WithEvents panel_left As Panel
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents panel_right As Panel
    Friend WithEvents panel_search As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_searchbox As TextBox
    Friend WithEvents label_search As Label
    Friend WithEvents panel_datagridview As Panel
    Friend WithEvents xDataGrid As DataGridView
    Friend WithEvents _orderDetailID As DataGridViewTextBoxColumn
    Friend WithEvents _transacode As DataGridViewTextBoxColumn
    Friend WithEvents _invoice As DataGridViewTextBoxColumn
    Friend WithEvents _orderDate As DataGridViewTextBoxColumn
    Friend WithEvents _custName As DataGridViewTextBoxColumn
    Friend WithEvents _serialNumber As DataGridViewTextBoxColumn
    Friend WithEvents _productName As DataGridViewTextBoxColumn
    Friend WithEvents _category As DataGridViewTextBoxColumn
    Friend WithEvents _supplier As DataGridViewTextBoxColumn
    Friend WithEvents _action As DataGridViewButtonColumn
End Class
