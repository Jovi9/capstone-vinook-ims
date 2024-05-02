<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.btn_quit = New System.Windows.Forms.Button()
        Me.img_logo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnForgotPassword = New System.Windows.Forms.LinkLabel()
        Me.lblemptypass = New System.Windows.Forms.Label()
        Me.lblemptyuser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_header.SuspendLayout()
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(21, 149)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(136, 30)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username:"
        '
        'lbl_password
        '
        Me.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_password.Location = New System.Drawing.Point(21, 266)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(131, 30)
        Me.lbl_password.TabIndex = 0
        Me.lbl_password.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUsername.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(26, 190)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(350, 47)
        Me.txtUsername.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(26, 307)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(350, 47)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_header.Controls.Add(Me.lbl_title)
        Me.panel_header.Controls.Add(Me.btn_minimize)
        Me.panel_header.Controls.Add(Me.btn_quit)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(1063, 45)
        Me.panel_header.TabIndex = 3
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_title.Font = New System.Drawing.Font("Helvetica", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(0, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Padding = New System.Windows.Forms.Padding(6, 10, 6, 6)
        Me.lbl_title.Size = New System.Drawing.Size(202, 42)
        Me.lbl_title.TabIndex = 8
        Me.lbl_title.Text = "Virtual Nook Login"
        Me.lbl_title.Visible = False
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btn_minimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_minimize.Location = New System.Drawing.Point(951, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.btn_minimize.Size = New System.Drawing.Size(56, 45)
        Me.btn_minimize.TabIndex = 5
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.Text = "0"
        Me.btn_minimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_minimize.UseVisualStyleBackColor = False
        Me.btn_minimize.Visible = False
        '
        'btn_quit
        '
        Me.btn_quit.BackColor = System.Drawing.Color.Transparent
        Me.btn_quit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_quit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_quit.FlatAppearance.BorderSize = 0
        Me.btn_quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_quit.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btn_quit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_quit.Location = New System.Drawing.Point(1007, 0)
        Me.btn_quit.Name = "btn_quit"
        Me.btn_quit.Size = New System.Drawing.Size(56, 45)
        Me.btn_quit.TabIndex = 4
        Me.btn_quit.TabStop = False
        Me.btn_quit.Text = "r"
        Me.btn_quit.UseVisualStyleBackColor = False
        '
        'img_logo
        '
        Me.img_logo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.img_logo.Image = CType(resources.GetObject("img_logo.Image"), System.Drawing.Image)
        Me.img_logo.Location = New System.Drawing.Point(68, 182)
        Me.img_logo.Name = "img_logo"
        Me.img_logo.Size = New System.Drawing.Size(460, 300)
        Me.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_logo.TabIndex = 8
        Me.img_logo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.btnForgotPassword)
        Me.Panel1.Controls.Add(Me.lblemptypass)
        Me.Panel1.Controls.Add(Me.lblemptyuser)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.lbl_password)
        Me.Panel1.Location = New System.Drawing.Point(607, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 555)
        Me.Panel1.TabIndex = 11
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(26, 414)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(350, 60)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnForgotPassword
        '
        Me.btnForgotPassword.ActiveLinkColor = System.Drawing.Color.Black
        Me.btnForgotPassword.AutoSize = True
        Me.btnForgotPassword.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForgotPassword.LinkColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnForgotPassword.Location = New System.Drawing.Point(115, 513)
        Me.btnForgotPassword.Name = "btnForgotPassword"
        Me.btnForgotPassword.Size = New System.Drawing.Size(172, 24)
        Me.btnForgotPassword.TabIndex = 15
        Me.btnForgotPassword.TabStop = True
        Me.btnForgotPassword.Text = "Forgot Password?"
        Me.btnForgotPassword.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        '
        'lblemptypass
        '
        Me.lblemptypass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblemptypass.AutoSize = True
        Me.lblemptypass.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemptypass.ForeColor = System.Drawing.Color.Red
        Me.lblemptypass.Location = New System.Drawing.Point(22, 356)
        Me.lblemptypass.Name = "lblemptypass"
        Me.lblemptypass.Size = New System.Drawing.Size(177, 22)
        Me.lblemptypass.TabIndex = 13
        Me.lblemptypass.Text = "Password is empty."
        Me.lblemptypass.Visible = False
        '
        'lblemptyuser
        '
        Me.lblemptyuser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblemptyuser.AutoSize = True
        Me.lblemptyuser.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemptyuser.ForeColor = System.Drawing.Color.Red
        Me.lblemptyuser.Location = New System.Drawing.Point(22, 239)
        Me.lblemptyuser.Name = "lblemptyuser"
        Me.lblemptyuser.Size = New System.Drawing.Size(181, 22)
        Me.lblemptyuser.TabIndex = 12
        Me.lblemptyuser.Text = "Username is empty."
        Me.lblemptyuser.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(141, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 49)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Login"
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1063, 672)
        Me.Controls.Add(Me.img_logo)
        Me.Controls.Add(Me.panel_header)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Helvetica", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents panel_header As Panel
    Friend WithEvents btn_minimize As Button
    Friend WithEvents btn_quit As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents img_logo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblemptyuser As Label
    Friend WithEvents lblemptypass As Label
    Friend WithEvents btnForgotPassword As LinkLabel
    Friend WithEvents btnLogin As Button
End Class
