<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrders))
        Me.menuBar = New System.Windows.Forms.MenuStrip()
        Me.menuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAllOrders = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSalesReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.checkFilterAllRange = New System.Windows.Forms.CheckBox()
        Me.filterDateOrderEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.filterDateOrder = New System.Windows.Forms.DateTimePicker()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txt_searchbox = New System.Windows.Forms.TextBox()
        Me.label_search = New System.Windows.Forms.Label()
        Me.panel_datagridview = New System.Windows.Forms.Panel()
        Me.xDataGrid = New System.Windows.Forms.DataGridView()
        Me._transacode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._invoice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._orderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._custName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._custAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._totalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._payType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._actionBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.menuBar.SuspendLayout()
        Me.panel_body.SuspendLayout()
        Me.panel_datagridview.SuspendLayout()
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuBar
        '
        Me.menuBar.AllowMerge = False
        Me.menuBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuBar.Font = New System.Drawing.Font("Helvetica", 13.0!)
        Me.menuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMenu, Me.menuSalesReport})
        Me.menuBar.Location = New System.Drawing.Point(0, 0)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Padding = New System.Windows.Forms.Padding(10, 5, 0, 5)
        Me.menuBar.Size = New System.Drawing.Size(1370, 40)
        Me.menuBar.TabIndex = 3
        Me.menuBar.Text = "Menu Bar"
        '
        'menuMenu
        '
        Me.menuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuRefresh, Me.menuNew, Me.menuAllOrders, Me.menuPrint})
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
        Me.menuRefresh.Size = New System.Drawing.Size(284, 30)
        Me.menuRefresh.Text = "Refresh"
        '
        'menuNew
        '
        Me.menuNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuNew.Name = "menuNew"
        Me.menuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.menuNew.Size = New System.Drawing.Size(284, 30)
        Me.menuNew.Text = "New Order"
        '
        'menuAllOrders
        '
        Me.menuAllOrders.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuAllOrders.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuAllOrders.Name = "menuAllOrders"
        Me.menuAllOrders.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.menuAllOrders.Size = New System.Drawing.Size(284, 30)
        Me.menuAllOrders.Text = "All Sales"
        '
        'menuPrint
        '
        Me.menuPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menuPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuPrint.Name = "menuPrint"
        Me.menuPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.menuPrint.Size = New System.Drawing.Size(284, 30)
        Me.menuPrint.Text = "Print"
        '
        'menuSalesReport
        '
        Me.menuSalesReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menuSalesReport.Name = "menuSalesReport"
        Me.menuSalesReport.Size = New System.Drawing.Size(152, 30)
        Me.menuSalesReport.Text = "Sales Report"
        '
        'panel_body
        '
        Me.panel_body.Controls.Add(Me.checkFilterAllRange)
        Me.panel_body.Controls.Add(Me.filterDateOrderEnd)
        Me.panel_body.Controls.Add(Me.Label3)
        Me.panel_body.Controls.Add(Me.Label2)
        Me.panel_body.Controls.Add(Me.Label1)
        Me.panel_body.Controls.Add(Me.filterDateOrder)
        Me.panel_body.Controls.Add(Me.txtID)
        Me.panel_body.Controls.Add(Me.txt_searchbox)
        Me.panel_body.Controls.Add(Me.label_search)
        Me.panel_body.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_body.Location = New System.Drawing.Point(0, 40)
        Me.panel_body.Name = "panel_body"
        Me.panel_body.Size = New System.Drawing.Size(1370, 100)
        Me.panel_body.TabIndex = 5
        '
        'checkFilterAllRange
        '
        Me.checkFilterAllRange.AutoSize = True
        Me.checkFilterAllRange.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.checkFilterAllRange.Location = New System.Drawing.Point(571, 8)
        Me.checkFilterAllRange.Name = "checkFilterAllRange"
        Me.checkFilterAllRange.Size = New System.Drawing.Size(337, 34)
        Me.checkFilterAllRange.TabIndex = 1
        Me.checkFilterAllRange.Text = "Filter Sales by Date Range"
        Me.checkFilterAllRange.UseVisualStyleBackColor = True
        '
        'filterDateOrderEnd
        '
        Me.filterDateOrderEnd.CustomFormat = "dd-MMM-yyyy"
        Me.filterDateOrderEnd.Enabled = False
        Me.filterDateOrderEnd.Font = New System.Drawing.Font("Helvetica", 14.0!)
        Me.filterDateOrderEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.filterDateOrderEnd.Location = New System.Drawing.Point(855, 45)
        Me.filterDateOrderEnd.Name = "filterDateOrderEnd"
        Me.filterDateOrderEnd.Size = New System.Drawing.Size(200, 35)
        Me.filterDateOrderEnd.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(811, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 24)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(506, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 24)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "From:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Transaction Code / Invoice / Customer"
        '
        'filterDateOrder
        '
        Me.filterDateOrder.CustomFormat = "dd-MMM-yyyy"
        Me.filterDateOrder.Font = New System.Drawing.Font("Helvetica", 14.0!)
        Me.filterDateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.filterDateOrder.Location = New System.Drawing.Point(571, 45)
        Me.filterDateOrder.Name = "filterDateOrder"
        Me.filterDateOrder.Size = New System.Drawing.Size(200, 35)
        Me.filterDateOrder.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(1122, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(63, 37)
        Me.txtID.TabIndex = 25
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'txt_searchbox
        '
        Me.txt_searchbox.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchbox.Location = New System.Drawing.Point(28, 47)
        Me.txt_searchbox.Name = "txt_searchbox"
        Me.txt_searchbox.Size = New System.Drawing.Size(427, 35)
        Me.txt_searchbox.TabIndex = 0
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
        Me.panel_datagridview.Location = New System.Drawing.Point(0, 140)
        Me.panel_datagridview.Name = "panel_datagridview"
        Me.panel_datagridview.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.panel_datagridview.Size = New System.Drawing.Size(1370, 473)
        Me.panel_datagridview.TabIndex = 6
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Helvetica", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.xDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.xDataGrid.ColumnHeadersHeight = 40
        Me.xDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.xDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._transacode, Me._invoice, Me._orderDate, Me._custName, Me._custAddress, Me._totalAmount, Me._payType, Me._actionBtn})
        Me.xDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xDataGrid.EnableHeadersVisualStyles = False
        Me.xDataGrid.Location = New System.Drawing.Point(10, 5)
        Me.xDataGrid.MultiSelect = False
        Me.xDataGrid.Name = "xDataGrid"
        Me.xDataGrid.ReadOnly = True
        Me.xDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Helvetica", 8.25!)
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
        Me.xDataGrid.Size = New System.Drawing.Size(1350, 463)
        Me.xDataGrid.TabIndex = 2
        Me.xDataGrid.TabStop = False
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
        '_custAddress
        '
        Me._custAddress.HeaderText = "Address"
        Me._custAddress.MinimumWidth = 6
        Me._custAddress.Name = "_custAddress"
        Me._custAddress.ReadOnly = True
        Me._custAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '_totalAmount
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me._totalAmount.DefaultCellStyle = DataGridViewCellStyle3
        Me._totalAmount.HeaderText = "Total Amount"
        Me._totalAmount.MinimumWidth = 6
        Me._totalAmount.Name = "_totalAmount"
        Me._totalAmount.ReadOnly = True
        Me._totalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '_payType
        '
        Me._payType.HeaderText = "Paid By"
        Me._payType.MinimumWidth = 6
        Me._payType.Name = "_payType"
        Me._payType.ReadOnly = True
        Me._payType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '_actionBtn
        '
        Me._actionBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me._actionBtn.HeaderText = "Action"
        Me._actionBtn.MinimumWidth = 6
        Me._actionBtn.Name = "_actionBtn"
        Me._actionBtn.ReadOnly = True
        Me._actionBtn.Text = "View Details"
        Me._actionBtn.UseColumnTextForButtonValue = True
        Me._actionBtn.Width = 51
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 613)
        Me.panel_bottom.Margin = New System.Windows.Forms.Padding(2)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(1370, 4)
        Me.panel_bottom.TabIndex = 35
        '
        'frmOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 617)
        Me.Controls.Add(Me.panel_datagridview)
        Me.Controls.Add(Me.panel_body)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.menuBar)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Helvetica", 8.25!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmOrders"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales"
        Me.menuBar.ResumeLayout(False)
        Me.menuBar.PerformLayout()
        Me.panel_body.ResumeLayout(False)
        Me.panel_body.PerformLayout()
        Me.panel_datagridview.ResumeLayout(False)
        CType(Me.xDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuBar As MenuStrip
    Friend WithEvents menuMenu As ToolStripMenuItem
    Friend WithEvents menuRefresh As ToolStripMenuItem
    Friend WithEvents menuNew As ToolStripMenuItem
    Friend WithEvents menuPrint As ToolStripMenuItem
    Friend WithEvents panel_body As Panel
    Friend WithEvents txtID As TextBox
    Friend WithEvents txt_searchbox As TextBox
    Friend WithEvents label_search As Label
    Friend WithEvents panel_datagridview As Panel
    Friend WithEvents xDataGrid As DataGridView
    Friend WithEvents filterDateOrder As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents _transacode As DataGridViewTextBoxColumn
    Friend WithEvents _invoice As DataGridViewTextBoxColumn
    Friend WithEvents _orderDate As DataGridViewTextBoxColumn
    Friend WithEvents _custName As DataGridViewTextBoxColumn
    Friend WithEvents _custAddress As DataGridViewTextBoxColumn
    Friend WithEvents _totalAmount As DataGridViewTextBoxColumn
    Friend WithEvents _payType As DataGridViewTextBoxColumn
    Friend WithEvents _actionBtn As DataGridViewButtonColumn
    Friend WithEvents menuAllOrders As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents filterDateOrderEnd As DateTimePicker
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents checkFilterAllRange As CheckBox
    Friend WithEvents menuSalesReport As ToolStripMenuItem
End Class
