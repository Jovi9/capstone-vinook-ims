<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.panel_menu = New System.Windows.Forms.Panel()
        Me.btn_account = New System.Windows.Forms.Button()
        Me.btn_history = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_categories = New System.Windows.Forms.Button()
        Me.btn_suppliers = New System.Windows.Forms.Button()
        Me.btn_customers = New System.Windows.Forms.Button()
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.btn_inventory = New System.Windows.Forms.Button()
        Me.panelSettingsSubMenu = New System.Windows.Forms.Panel()
        Me.btnOverview = New System.Windows.Forms.Button()
        Me.panel_logo = New System.Windows.Forms.Panel()
        Me.img_logo = New System.Windows.Forms.PictureBox()
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.panel_notif = New System.Windows.Forms.Panel()
        Me.pnlNotification = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblNotification = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label_header_title = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.btn_resize = New System.Windows.Forms.Button()
        Me.childControlBox = New System.Windows.Forms.MenuStrip()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.timerMarquee = New System.Windows.Forms.Timer(Me.components)
        Me.timerWaiting = New System.Windows.Forms.Timer(Me.components)
        Me.panel_menu.SuspendLayout()
        Me.panel_logo.SuspendLayout()
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_header.SuspendLayout()
        Me.panel_notif.SuspendLayout()
        Me.pnlNotification.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_menu
        '
        Me.panel_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_menu.Controls.Add(Me.btn_account)
        Me.panel_menu.Controls.Add(Me.btn_history)
        Me.panel_menu.Controls.Add(Me.btn_logout)
        Me.panel_menu.Controls.Add(Me.btn_categories)
        Me.panel_menu.Controls.Add(Me.btn_suppliers)
        Me.panel_menu.Controls.Add(Me.btn_customers)
        Me.panel_menu.Controls.Add(Me.btn_orders)
        Me.panel_menu.Controls.Add(Me.btn_inventory)
        Me.panel_menu.Controls.Add(Me.panelSettingsSubMenu)
        Me.panel_menu.Controls.Add(Me.btnOverview)
        Me.panel_menu.Controls.Add(Me.panel_logo)
        Me.panel_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_menu.Location = New System.Drawing.Point(0, 0)
        Me.panel_menu.Name = "panel_menu"
        Me.panel_menu.Size = New System.Drawing.Size(200, 710)
        Me.panel_menu.TabIndex = 0
        '
        'btn_account
        '
        Me.btn_account.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_account.FlatAppearance.BorderSize = 0
        Me.btn_account.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_account.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_account.Image = Global.ViNOOK_IMS.My.Resources.Resources.account
        Me.btn_account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_account.Location = New System.Drawing.Point(0, 504)
        Me.btn_account.Name = "btn_account"
        Me.btn_account.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_account.Size = New System.Drawing.Size(200, 60)
        Me.btn_account.TabIndex = 19
        Me.btn_account.Text = "Account"
        Me.btn_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_account.UseVisualStyleBackColor = True
        '
        'btn_history
        '
        Me.btn_history.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_history.FlatAppearance.BorderSize = 0
        Me.btn_history.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_history.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_history.Image = Global.ViNOOK_IMS.My.Resources.Resources.history1
        Me.btn_history.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_history.Location = New System.Drawing.Point(0, 564)
        Me.btn_history.Name = "btn_history"
        Me.btn_history.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_history.Size = New System.Drawing.Size(200, 60)
        Me.btn_history.TabIndex = 20
        Me.btn_history.Text = "History"
        Me.btn_history.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_history.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_history.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Image = Global.ViNOOK_IMS.My.Resources.Resources.logout1
        Me.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.Location = New System.Drawing.Point(0, 624)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_logout.Size = New System.Drawing.Size(200, 60)
        Me.btn_logout.TabIndex = 21
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_categories
        '
        Me.btn_categories.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_categories.FlatAppearance.BorderSize = 0
        Me.btn_categories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_categories.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_categories.Image = Global.ViNOOK_IMS.My.Resources.Resources.categories
        Me.btn_categories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_categories.Location = New System.Drawing.Point(0, 390)
        Me.btn_categories.Name = "btn_categories"
        Me.btn_categories.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_categories.Size = New System.Drawing.Size(200, 60)
        Me.btn_categories.TabIndex = 18
        Me.btn_categories.Text = "Product Categories"
        Me.btn_categories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_categories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btn_categories, "View product categories.")
        Me.btn_categories.UseVisualStyleBackColor = True
        '
        'btn_suppliers
        '
        Me.btn_suppliers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_suppliers.FlatAppearance.BorderSize = 0
        Me.btn_suppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_suppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_suppliers.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suppliers.Image = Global.ViNOOK_IMS.My.Resources.Resources.suppliersss
        Me.btn_suppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_suppliers.Location = New System.Drawing.Point(0, 330)
        Me.btn_suppliers.Name = "btn_suppliers"
        Me.btn_suppliers.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_suppliers.Size = New System.Drawing.Size(200, 60)
        Me.btn_suppliers.TabIndex = 17
        Me.btn_suppliers.Text = "Suppliers"
        Me.btn_suppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_suppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btn_suppliers, "View Supplier Details")
        Me.btn_suppliers.UseVisualStyleBackColor = True
        '
        'btn_customers
        '
        Me.btn_customers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_customers.FlatAppearance.BorderSize = 0
        Me.btn_customers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_customers.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customers.Image = Global.ViNOOK_IMS.My.Resources.Resources.customer
        Me.btn_customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_customers.Location = New System.Drawing.Point(0, 270)
        Me.btn_customers.Name = "btn_customers"
        Me.btn_customers.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_customers.Size = New System.Drawing.Size(200, 60)
        Me.btn_customers.TabIndex = 16
        Me.btn_customers.Text = "Customers"
        Me.btn_customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btn_customers, "View customer details.")
        Me.btn_customers.UseVisualStyleBackColor = True
        '
        'btn_orders
        '
        Me.btn_orders.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_orders.FlatAppearance.BorderSize = 0
        Me.btn_orders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_orders.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orders.Image = Global.ViNOOK_IMS.My.Resources.Resources.dashboard1
        Me.btn_orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_orders.Location = New System.Drawing.Point(0, 210)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_orders.Size = New System.Drawing.Size(200, 60)
        Me.btn_orders.TabIndex = 15
        Me.btn_orders.Text = "Sales"
        Me.btn_orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_orders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btn_orders, "View and add sales.")
        Me.btn_orders.UseVisualStyleBackColor = True
        '
        'btn_inventory
        '
        Me.btn_inventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_inventory.FlatAppearance.BorderSize = 0
        Me.btn_inventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inventory.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inventory.Image = Global.ViNOOK_IMS.My.Resources.Resources.inventory
        Me.btn_inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_inventory.Location = New System.Drawing.Point(0, 150)
        Me.btn_inventory.Name = "btn_inventory"
        Me.btn_inventory.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_inventory.Size = New System.Drawing.Size(200, 60)
        Me.btn_inventory.TabIndex = 14
        Me.btn_inventory.Text = "Inventory"
        Me.btn_inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip.SetToolTip(Me.btn_inventory, "View inventory details.")
        Me.btn_inventory.UseVisualStyleBackColor = True
        '
        'panelSettingsSubMenu
        '
        Me.panelSettingsSubMenu.BackColor = System.Drawing.Color.Gray
        Me.panelSettingsSubMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelSettingsSubMenu.Location = New System.Drawing.Point(0, 684)
        Me.panelSettingsSubMenu.Name = "panelSettingsSubMenu"
        Me.panelSettingsSubMenu.Size = New System.Drawing.Size(200, 26)
        Me.panelSettingsSubMenu.TabIndex = 9
        Me.panelSettingsSubMenu.Visible = False
        '
        'btnOverview
        '
        Me.btnOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOverview.Enabled = False
        Me.btnOverview.FlatAppearance.BorderSize = 0
        Me.btnOverview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOverview.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverview.Image = Global.ViNOOK_IMS.My.Resources.Resources.dashboard1
        Me.btnOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOverview.Location = New System.Drawing.Point(0, 90)
        Me.btnOverview.Name = "btnOverview"
        Me.btnOverview.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnOverview.Size = New System.Drawing.Size(200, 60)
        Me.btnOverview.TabIndex = 22
        Me.btnOverview.TabStop = False
        Me.btnOverview.Text = "Overview"
        Me.btnOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOverview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOverview.UseVisualStyleBackColor = True
        Me.btnOverview.Visible = False
        '
        'panel_logo
        '
        Me.panel_logo.Controls.Add(Me.img_logo)
        Me.panel_logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_logo.Location = New System.Drawing.Point(0, 0)
        Me.panel_logo.Name = "panel_logo"
        Me.panel_logo.Size = New System.Drawing.Size(200, 90)
        Me.panel_logo.TabIndex = 0
        '
        'img_logo
        '
        Me.img_logo.Image = Global.ViNOOK_IMS.My.Resources.Resources.splash
        Me.img_logo.Location = New System.Drawing.Point(30, 16)
        Me.img_logo.Name = "img_logo"
        Me.img_logo.Size = New System.Drawing.Size(120, 50)
        Me.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_logo.TabIndex = 0
        Me.img_logo.TabStop = False
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_header.Controls.Add(Me.panel_notif)
        Me.panel_header.Controls.Add(Me.label_header_title)
        Me.panel_header.Controls.Add(Me.btnExit)
        Me.panel_header.Controls.Add(Me.btn_minimize)
        Me.panel_header.Controls.Add(Me.btn_resize)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(200, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(876, 90)
        Me.panel_header.TabIndex = 2
        '
        'panel_notif
        '
        Me.panel_notif.Controls.Add(Me.pnlNotification)
        Me.panel_notif.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_notif.Location = New System.Drawing.Point(0, 60)
        Me.panel_notif.Name = "panel_notif"
        Me.panel_notif.Size = New System.Drawing.Size(876, 30)
        Me.panel_notif.TabIndex = 9
        '
        'pnlNotification
        '
        Me.pnlNotification.AutoSize = True
        Me.pnlNotification.BackColor = System.Drawing.Color.Transparent
        Me.pnlNotification.Controls.Add(Me.PictureBox2)
        Me.pnlNotification.Controls.Add(Me.lblNotification)
        Me.pnlNotification.Controls.Add(Me.PictureBox1)
        Me.pnlNotification.ForeColor = System.Drawing.Color.Yellow
        Me.pnlNotification.Location = New System.Drawing.Point(6, 0)
        Me.pnlNotification.Name = "pnlNotification"
        Me.pnlNotification.Size = New System.Drawing.Size(815, 25)
        Me.pnlNotification.TabIndex = 7
        Me.pnlNotification.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.ViNOOK_IMS.My.Resources.Resources.warning
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Location = New System.Drawing.Point(285, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'lblNotification
        '
        Me.lblNotification.AutoSize = True
        Me.lblNotification.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNotification.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblNotification.Font = New System.Drawing.Font("Helvetica", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotification.ForeColor = System.Drawing.Color.Yellow
        Me.lblNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNotification.Location = New System.Drawing.Point(30, 0)
        Me.lblNotification.Name = "lblNotification"
        Me.lblNotification.Size = New System.Drawing.Size(255, 28)
        Me.lblNotification.TabIndex = 10
        Me.lblNotification.Text = "Inventory Management"
        Me.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.toolTip.SetToolTip(Me.lblNotification, "View All Low Stock")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ViNOOK_IMS.My.Resources.Resources.warning
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'label_header_title
        '
        Me.label_header_title.AutoSize = True
        Me.label_header_title.Font = New System.Drawing.Font("Helvetica", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_header_title.Location = New System.Drawing.Point(3, 26)
        Me.label_header_title.Name = "label_header_title"
        Me.label_header_title.Size = New System.Drawing.Size(324, 36)
        Me.label_header_title.TabIndex = 7
        Me.label_header_title.Text = "Inventory Management"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.AutoSize = True
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(825, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnExit.Size = New System.Drawing.Size(51, 45)
        Me.btnExit.TabIndex = 8
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "r"
        Me.toolTip.SetToolTip(Me.btnExit, "Close")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btn_minimize
        '
        Me.btn_minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimize.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btn_minimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_minimize.Location = New System.Drawing.Point(716, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Padding = New System.Windows.Forms.Padding(0, 0, 2, 4)
        Me.btn_minimize.Size = New System.Drawing.Size(56, 45)
        Me.btn_minimize.TabIndex = 6
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.Text = "0"
        Me.btn_minimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.toolTip.SetToolTip(Me.btn_minimize, "Minimize")
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'btn_resize
        '
        Me.btn_resize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_resize.AutoSize = True
        Me.btn_resize.BackColor = System.Drawing.Color.Transparent
        Me.btn_resize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_resize.FlatAppearance.BorderSize = 0
        Me.btn_resize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_resize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_resize.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btn_resize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_resize.Location = New System.Drawing.Point(773, 0)
        Me.btn_resize.Name = "btn_resize"
        Me.btn_resize.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btn_resize.Size = New System.Drawing.Size(51, 45)
        Me.btn_resize.TabIndex = 4
        Me.btn_resize.TabStop = False
        Me.btn_resize.Text = "1"
        Me.btn_resize.UseVisualStyleBackColor = False
        '
        'childControlBox
        '
        Me.childControlBox.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.childControlBox.Location = New System.Drawing.Point(0, 0)
        Me.childControlBox.Name = "childControlBox"
        Me.childControlBox.Size = New System.Drawing.Size(1076, 30)
        Me.childControlBox.TabIndex = 5
        Me.childControlBox.Text = "MenuStrip1"
        Me.childControlBox.Visible = False
        '
        'toolTip
        '
        Me.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'timerMarquee
        '
        '
        'timerWaiting
        '
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1076, 710)
        Me.Controls.Add(Me.panel_header)
        Me.Controls.Add(Me.panel_menu)
        Me.Controls.Add(Me.childControlBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Helvetica", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.childControlBox
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViNOOK Inventory"
        Me.panel_menu.ResumeLayout(False)
        Me.panel_logo.ResumeLayout(False)
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panel_notif.ResumeLayout(False)
        Me.panel_notif.PerformLayout()
        Me.pnlNotification.ResumeLayout(False)
        Me.pnlNotification.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_menu As Panel
    Friend WithEvents panel_logo As Panel
    Friend WithEvents img_logo As PictureBox
    Friend WithEvents panel_header As Panel
    Friend WithEvents childControlBox As MenuStrip
    Friend WithEvents btn_resize As Button
    Friend WithEvents btn_minimize As Button
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents label_header_title As Label
    Friend WithEvents panelSettingsSubMenu As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btn_inventory As Button
    Friend WithEvents btn_orders As Button
    Friend WithEvents btn_suppliers As Button
    Friend WithEvents btn_customers As Button
    Friend WithEvents btn_categories As Button
    Friend WithEvents btn_account As Button
    Friend WithEvents btn_history As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents btnOverview As Button
    Friend WithEvents panel_notif As Panel
    Friend WithEvents lblNotification As Label
    Friend WithEvents timerMarquee As Timer
    Friend WithEvents pnlNotification As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents timerWaiting As Timer
End Class
