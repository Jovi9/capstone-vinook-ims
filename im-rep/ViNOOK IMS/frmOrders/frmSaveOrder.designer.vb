<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaveOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaveOrder))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.panel_left = New System.Windows.Forms.Panel()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.panel_right = New System.Windows.Forms.Panel()
        Me.panel_save = New System.Windows.Forms.Panel()
        Me.group_save = New System.Windows.Forms.GroupBox()
        Me.txtChequeNo = New System.Windows.Forms.TextBox()
        Me.lblChequeNo = New System.Windows.Forms.Label()
        Me.btn_choose_customer = New System.Windows.Forms.Button()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.dropPaymentType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.table_action = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save_order = New System.Windows.Forms.Button()
        Me.txtChange = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAmountReceived = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalAmountDue = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTINiD = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.label_address = New System.Windows.Forms.Label()
        Me.label_phone = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.label_firstName = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTransactionCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label_orderdetail = New System.Windows.Forms.Label()
        Me.panel_header.SuspendLayout()
        Me.panel_save.SuspendLayout()
        Me.group_save.SuspendLayout()
        Me.table_action.SuspendLayout()
        CType(Me.txtChange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountReceived, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalAmountDue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_header.Controls.Add(Me.lable_header_title)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(1047, 60)
        Me.panel_header.TabIndex = 7
        '
        'lable_header_title
        '
        Me.lable_header_title.AutoSize = True
        Me.lable_header_title.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable_header_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lable_header_title.Location = New System.Drawing.Point(11, 10)
        Me.lable_header_title.Name = "lable_header_title"
        Me.lable_header_title.Size = New System.Drawing.Size(190, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "Save Order"
        '
        'panel_left
        '
        Me.panel_left.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_left.Location = New System.Drawing.Point(0, 60)
        Me.panel_left.Name = "panel_left"
        Me.panel_left.Size = New System.Drawing.Size(10, 529)
        Me.panel_left.TabIndex = 37
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 589)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(1047, 10)
        Me.panel_bottom.TabIndex = 38
        '
        'panel_right
        '
        Me.panel_right.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_right.Location = New System.Drawing.Point(1037, 60)
        Me.panel_right.Name = "panel_right"
        Me.panel_right.Size = New System.Drawing.Size(10, 529)
        Me.panel_right.TabIndex = 39
        '
        'panel_save
        '
        Me.panel_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.panel_save.Controls.Add(Me.group_save)
        Me.panel_save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.panel_save.Location = New System.Drawing.Point(10, 60)
        Me.panel_save.Name = "panel_save"
        Me.panel_save.Padding = New System.Windows.Forms.Padding(15, 0, 15, 10)
        Me.panel_save.Size = New System.Drawing.Size(1027, 529)
        Me.panel_save.TabIndex = 40
        '
        'group_save
        '
        Me.group_save.Controls.Add(Me.txtChequeNo)
        Me.group_save.Controls.Add(Me.lblChequeNo)
        Me.group_save.Controls.Add(Me.btn_choose_customer)
        Me.group_save.Controls.Add(Me.txtCustomerID)
        Me.group_save.Controls.Add(Me.dropPaymentType)
        Me.group_save.Controls.Add(Me.Label8)
        Me.group_save.Controls.Add(Me.table_action)
        Me.group_save.Controls.Add(Me.txtChange)
        Me.group_save.Controls.Add(Me.Label7)
        Me.group_save.Controls.Add(Me.txtAmountReceived)
        Me.group_save.Controls.Add(Me.Label6)
        Me.group_save.Controls.Add(Me.txtBalance)
        Me.group_save.Controls.Add(Me.Label5)
        Me.group_save.Controls.Add(Me.txtTotalAmountDue)
        Me.group_save.Controls.Add(Me.Label12)
        Me.group_save.Controls.Add(Me.Label4)
        Me.group_save.Controls.Add(Me.txtTINiD)
        Me.group_save.Controls.Add(Me.Label1)
        Me.group_save.Controls.Add(Me.txtPhone)
        Me.group_save.Controls.Add(Me.txtAddress)
        Me.group_save.Controls.Add(Me.label_address)
        Me.group_save.Controls.Add(Me.label_phone)
        Me.group_save.Controls.Add(Me.txtname)
        Me.group_save.Controls.Add(Me.label_firstName)
        Me.group_save.Controls.Add(Me.txtInvoiceNo)
        Me.group_save.Controls.Add(Me.Label3)
        Me.group_save.Controls.Add(Me.txtTransactionCode)
        Me.group_save.Controls.Add(Me.Label2)
        Me.group_save.Controls.Add(Me.label_orderdetail)
        Me.group_save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.group_save.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_save.Location = New System.Drawing.Point(15, 0)
        Me.group_save.Name = "group_save"
        Me.group_save.Size = New System.Drawing.Size(997, 519)
        Me.group_save.TabIndex = 20
        Me.group_save.TabStop = False
        '
        'txtChequeNo
        '
        Me.txtChequeNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtChequeNo.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNo.Location = New System.Drawing.Point(215, 375)
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(280, 37)
        Me.txtChequeNo.TabIndex = 2
        Me.txtChequeNo.Visible = False
        '
        'lblChequeNo
        '
        Me.lblChequeNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblChequeNo.AutoSize = True
        Me.lblChequeNo.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequeNo.Location = New System.Drawing.Point(23, 381)
        Me.lblChequeNo.Name = "lblChequeNo"
        Me.lblChequeNo.Size = New System.Drawing.Size(116, 24)
        Me.lblChequeNo.TabIndex = 78
        Me.lblChequeNo.Text = "Cheque No."
        Me.lblChequeNo.Visible = False
        '
        'btn_choose_customer
        '
        Me.btn_choose_customer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_choose_customer.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_choose_customer.FlatAppearance.BorderSize = 0
        Me.btn_choose_customer.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_choose_customer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_choose_customer.Location = New System.Drawing.Point(688, 71)
        Me.btn_choose_customer.Name = "btn_choose_customer"
        Me.btn_choose_customer.Size = New System.Drawing.Size(280, 37)
        Me.btn_choose_customer.TabIndex = 43
        Me.btn_choose_customer.TabStop = False
        Me.btn_choose_customer.Text = "(F4) Choose Customer"
        Me.btn_choose_customer.UseVisualStyleBackColor = False
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCustomerID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(622, 337)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(280, 37)
        Me.txtCustomerID.TabIndex = 76
        Me.txtCustomerID.TabStop = False
        Me.txtCustomerID.Visible = False
        '
        'dropPaymentType
        '
        Me.dropPaymentType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dropPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropPaymentType.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropPaymentType.FormattingEnabled = True
        Me.dropPaymentType.Items.AddRange(New Object() {"Cash", "Cheque"})
        Me.dropPaymentType.Location = New System.Drawing.Point(214, 331)
        Me.dropPaymentType.Name = "dropPaymentType"
        Me.dropPaymentType.Size = New System.Drawing.Size(280, 38)
        Me.dropPaymentType.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 337)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 24)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Payment Type"
        '
        'table_action
        '
        Me.table_action.ColumnCount = 2
        Me.table_action.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_action.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_action.Controls.Add(Me.btn_cancel, 0, 0)
        Me.table_action.Controls.Add(Me.btn_save_order, 0, 0)
        Me.table_action.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.table_action.Location = New System.Drawing.Point(3, 436)
        Me.table_action.Name = "table_action"
        Me.table_action.Padding = New System.Windows.Forms.Padding(50, 10, 50, 10)
        Me.table_action.RowCount = 1
        Me.table_action.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_action.Size = New System.Drawing.Size(991, 80)
        Me.table_action.TabIndex = 74
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_cancel.Location = New System.Drawing.Point(498, 13)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(440, 54)
        Me.btn_cancel.TabIndex = 42
        Me.btn_cancel.TabStop = False
        Me.btn_cancel.Text = "(Esc) Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_save_order
        '
        Me.btn_save_order.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_save_order.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_save_order.FlatAppearance.BorderSize = 0
        Me.btn_save_order.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save_order.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_save_order.Location = New System.Drawing.Point(53, 13)
        Me.btn_save_order.Name = "btn_save_order"
        Me.btn_save_order.Size = New System.Drawing.Size(439, 54)
        Me.btn_save_order.TabIndex = 41
        Me.btn_save_order.TabStop = False
        Me.btn_save_order.Text = "(F10) Save Order"
        Me.btn_save_order.UseVisualStyleBackColor = False
        '
        'txtChange
        '
        Me.txtChange.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtChange.BackColor = System.Drawing.SystemColors.Control
        Me.txtChange.DecimalPlaces = 2
        Me.txtChange.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtChange.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtChange.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtChange.InterceptArrowKeys = False
        Me.txtChange.Location = New System.Drawing.Point(214, 288)
        Me.txtChange.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(280, 37)
        Me.txtChange.TabIndex = 72
        Me.txtChange.TabStop = False
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtChange.ThousandsSeparator = True
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 24)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Change"
        '
        'txtAmountReceived
        '
        Me.txtAmountReceived.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAmountReceived.BackColor = System.Drawing.SystemColors.Control
        Me.txtAmountReceived.DecimalPlaces = 2
        Me.txtAmountReceived.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtAmountReceived.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAmountReceived.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAmountReceived.Location = New System.Drawing.Point(214, 245)
        Me.txtAmountReceived.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.txtAmountReceived.Name = "txtAmountReceived"
        Me.txtAmountReceived.Size = New System.Drawing.Size(280, 37)
        Me.txtAmountReceived.TabIndex = 0
        Me.txtAmountReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAmountReceived.ThousandsSeparator = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 24)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Amount Received"
        '
        'txtBalance
        '
        Me.txtBalance.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBalance.BackColor = System.Drawing.SystemColors.Control
        Me.txtBalance.DecimalPlaces = 2
        Me.txtBalance.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtBalance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBalance.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBalance.InterceptArrowKeys = False
        Me.txtBalance.Location = New System.Drawing.Point(214, 202)
        Me.txtBalance.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(280, 37)
        Me.txtBalance.TabIndex = 68
        Me.txtBalance.TabStop = False
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBalance.ThousandsSeparator = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 24)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Balance"
        '
        'txtTotalAmountDue
        '
        Me.txtTotalAmountDue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotalAmountDue.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotalAmountDue.DecimalPlaces = 2
        Me.txtTotalAmountDue.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalAmountDue.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotalAmountDue.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalAmountDue.InterceptArrowKeys = False
        Me.txtTotalAmountDue.Location = New System.Drawing.Point(214, 159)
        Me.txtTotalAmountDue.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.txtTotalAmountDue.Name = "txtTotalAmountDue"
        Me.txtTotalAmountDue.Size = New System.Drawing.Size(280, 37)
        Me.txtTotalAmountDue.TabIndex = 66
        Me.txtTotalAmountDue.TabStop = False
        Me.txtTotalAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalAmountDue.ThousandsSeparator = True
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 24)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Total Amount Due"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(562, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 30)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Customer Details"
        '
        'txtTINiD
        '
        Me.txtTINiD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTINiD.AsciiOnly = True
        Me.txtTINiD.BeepOnError = True
        Me.txtTINiD.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtTINiD.Location = New System.Drawing.Point(688, 288)
        Me.txtTINiD.Mask = "000-000-000-000"
        Me.txtTINiD.Name = "txtTINiD"
        Me.txtTINiD.ReadOnly = True
        Me.txtTINiD.Size = New System.Drawing.Size(280, 37)
        Me.txtTINiD.TabIndex = 49
        Me.txtTINiD.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(563, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 24)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "TIN ID:"
        '
        'txtPhone
        '
        Me.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPhone.AsciiOnly = True
        Me.txtPhone.BeepOnError = True
        Me.txtPhone.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtPhone.Location = New System.Drawing.Point(688, 245)
        Me.txtPhone.Mask = "0000-000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(280, 37)
        Me.txtPhone.TabIndex = 43
        Me.txtPhone.TabStop = False
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAddress.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(688, 159)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(280, 80)
        Me.txtAddress.TabIndex = 42
        Me.txtAddress.TabStop = False
        '
        'label_address
        '
        Me.label_address.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_address.AutoSize = True
        Me.label_address.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_address.Location = New System.Drawing.Point(563, 159)
        Me.label_address.Name = "label_address"
        Me.label_address.Size = New System.Drawing.Size(83, 24)
        Me.label_address.TabIndex = 45
        Me.label_address.Text = "Address"
        '
        'label_phone
        '
        Me.label_phone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_phone.AutoSize = True
        Me.label_phone.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_phone.Location = New System.Drawing.Point(563, 251)
        Me.label_phone.Name = "label_phone"
        Me.label_phone.Size = New System.Drawing.Size(67, 24)
        Me.label_phone.TabIndex = 46
        Me.label_phone.Text = "Phone"
        '
        'txtname
        '
        Me.txtname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtname.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(688, 114)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(280, 37)
        Me.txtname.TabIndex = 41
        Me.txtname.TabStop = False
        '
        'label_firstName
        '
        Me.label_firstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_firstName.AutoSize = True
        Me.label_firstName.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_firstName.Location = New System.Drawing.Point(563, 120)
        Me.label_firstName.Name = "label_firstName"
        Me.label_firstName.Size = New System.Drawing.Size(63, 24)
        Me.label_firstName.TabIndex = 44
        Me.label_firstName.Text = "Name"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(214, 114)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(280, 37)
        Me.txtInvoiceNo.TabIndex = 0
        Me.txtInvoiceNo.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 24)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Invoice No.:"
        '
        'txtTransactionCode
        '
        Me.txtTransactionCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTransactionCode.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionCode.Location = New System.Drawing.Point(214, 71)
        Me.txtTransactionCode.Name = "txtTransactionCode"
        Me.txtTransactionCode.ReadOnly = True
        Me.txtTransactionCode.Size = New System.Drawing.Size(280, 37)
        Me.txtTransactionCode.TabIndex = 38
        Me.txtTransactionCode.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 24)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Transaction Code:"
        '
        'label_orderdetail
        '
        Me.label_orderdetail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_orderdetail.AutoSize = True
        Me.label_orderdetail.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_orderdetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.label_orderdetail.Location = New System.Drawing.Point(17, 31)
        Me.label_orderdetail.Name = "label_orderdetail"
        Me.label_orderdetail.Size = New System.Drawing.Size(168, 30)
        Me.label_orderdetail.TabIndex = 37
        Me.label_orderdetail.Text = "Order Details"
        '
        'frmSaveOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1047, 599)
        Me.Controls.Add(Me.panel_save)
        Me.Controls.Add(Me.panel_right)
        Me.Controls.Add(Me.panel_left)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.panel_header)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmSaveOrder"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Save Order"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panel_save.ResumeLayout(False)
        Me.group_save.ResumeLayout(False)
        Me.group_save.PerformLayout()
        Me.table_action.ResumeLayout(False)
        CType(Me.txtChange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountReceived, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalAmountDue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents lable_header_title As Label
    Friend WithEvents panel_left As Panel
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents panel_right As Panel
    Friend WithEvents panel_save As Panel
    Friend WithEvents group_save As GroupBox
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTransactionCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents label_orderdetail As Label
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents label_address As Label
    Friend WithEvents label_phone As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents label_firstName As Label
    Friend WithEvents txtTINiD As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotalAmountDue As NumericUpDown
    Friend WithEvents txtChange As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAmountReceived As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBalance As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents table_action As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents dropPaymentType As ComboBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents btn_save_order As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_choose_customer As Button
    Friend WithEvents txtChequeNo As TextBox
    Friend WithEvents lblChequeNo As Label
End Class
