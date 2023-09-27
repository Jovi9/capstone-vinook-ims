<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePassword))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.labelOldPassword = New System.Windows.Forms.Label()
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
        Me.panel_header.TabIndex = 51
        '
        'lable_header_title
        '
        Me.lable_header_title.AutoSize = True
        Me.lable_header_title.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable_header_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lable_header_title.Location = New System.Drawing.Point(11, 10)
        Me.lable_header_title.Name = "lable_header_title"
        Me.lable_header_title.Size = New System.Drawing.Size(296, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "Change Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtConfirmPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtConfirmPassword.Location = New System.Drawing.Point(276, 208)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(305, 37)
        Me.txtConfirmPassword.TabIndex = 2
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(35, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 30)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Confirm Password:"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNewPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtNewPassword.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtNewPassword.Location = New System.Drawing.Point(276, 150)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(305, 37)
        Me.txtNewPassword.TabIndex = 1
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(35, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 30)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "New Password:"
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 365)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(622, 5)
        Me.panel_bottom.TabIndex = 52
        '
        'folderBrowser
        '
        Me.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(313, 278)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(220, 70)
        Me.btnCancel.TabIndex = 61
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "(Esc) Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_update.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_update.Location = New System.Drawing.Point(69, 278)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(220, 70)
        Me.btn_update.TabIndex = 60
        Me.btn_update.TabStop = False
        Me.btn_update.Text = "(F10) Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtOldPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtOldPassword.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtOldPassword.Location = New System.Drawing.Point(276, 93)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.Size = New System.Drawing.Size(305, 37)
        Me.txtOldPassword.TabIndex = 0
        Me.txtOldPassword.UseSystemPasswordChar = True
        '
        'labelOldPassword
        '
        Me.labelOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelOldPassword.AutoSize = True
        Me.labelOldPassword.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.labelOldPassword.Location = New System.Drawing.Point(35, 95)
        Me.labelOldPassword.Name = "labelOldPassword"
        Me.labelOldPassword.Size = New System.Drawing.Size(177, 30)
        Me.labelOldPassword.TabIndex = 63
        Me.labelOldPassword.Text = "Old Password:"
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(622, 370)
        Me.Controls.Add(Me.txtOldPassword)
        Me.Controls.Add(Me.labelOldPassword)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.panel_header)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panel_bottom)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmChangePassword"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents lable_header_title As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents folderBrowser As FolderBrowserDialog
    Friend WithEvents btnCancel As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents txtOldPassword As TextBox
    Friend WithEvents labelOldPassword As Label
End Class
