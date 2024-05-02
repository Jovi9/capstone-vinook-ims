<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                funcUser.Dispose()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditAccount))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.panel_header.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_header.Controls.Add(Me.lable_header_title)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(622, 60)
        Me.panel_header.TabIndex = 6
        '
        'lable_header_title
        '
        Me.lable_header_title.AutoSize = True
        Me.lable_header_title.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable_header_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lable_header_title.Location = New System.Drawing.Point(11, 10)
        Me.lable_header_title.Name = "lable_header_title"
        Me.lable_header_title.Size = New System.Drawing.Size(206, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "Edit Account"
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 527)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(622, 5)
        Me.panel_bottom.TabIndex = 34
        '
        'txtaddress
        '
        Me.txtaddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtaddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtaddress.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtaddress.Location = New System.Drawing.Point(232, 368)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(305, 37)
        Me.txtaddress.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(57, 370)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 30)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Address:"
        '
        'txtemail
        '
        Me.txtemail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtemail.BackColor = System.Drawing.SystemColors.Window
        Me.txtemail.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtemail.Location = New System.Drawing.Point(232, 314)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(305, 37)
        Me.txtemail.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(57, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 30)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Email: *"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(57, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 30)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Phone: *"
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.Window
        Me.txtFirstName.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(232, 144)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(305, 37)
        Me.txtFirstName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(57, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 30)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "First Name: *"
        '
        'txtusername
        '
        Me.txtusername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtusername.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtusername.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtusername.Location = New System.Drawing.Point(232, 89)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.ReadOnly = True
        Me.txtusername.Size = New System.Drawing.Size(305, 37)
        Me.txtusername.TabIndex = 46
        Me.txtusername.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(57, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 30)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Username:"
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLastName.BackColor = System.Drawing.SystemColors.Window
        Me.txtLastName.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtLastName.Location = New System.Drawing.Point(232, 201)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(305, 37)
        Me.txtLastName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(57, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 30)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Last Name: *"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhone.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtPhone.Location = New System.Drawing.Point(232, 259)
        Me.txtPhone.Mask = "0000-000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(305, 37)
        Me.txtPhone.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(312, 440)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(220, 70)
        Me.btnCancel.TabIndex = 63
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "(Esc) Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_update.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_update.Location = New System.Drawing.Point(68, 440)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(220, 70)
        Me.btn_update.TabIndex = 62
        Me.btn_update.TabStop = False
        Me.btn_update.Text = "(F10) Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'frmEditAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(622, 532)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.panel_header)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmEditAccount"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Account"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents lable_header_title As Label
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btn_update As Button
End Class
