<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccounts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccounts))
        Me.panel_accDetails = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnChangePasswrd = New System.Windows.Forms.Button()
        Me.btnEditAccountDetails = New System.Windows.Forms.Button()
        Me.txtrole = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.panel_accDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_accDetails
        '
        Me.panel_accDetails.Controls.Add(Me.GroupBox1)
        Me.panel_accDetails.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_accDetails.Location = New System.Drawing.Point(0, 0)
        Me.panel_accDetails.Name = "panel_accDetails"
        Me.panel_accDetails.Padding = New System.Windows.Forms.Padding(20)
        Me.panel_accDetails.Size = New System.Drawing.Size(580, 574)
        Me.panel_accDetails.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnChangePasswrd)
        Me.GroupBox1.Controls.Add(Me.btnEditAccountDetails)
        Me.GroupBox1.Controls.Add(Me.txtrole)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtphone)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Helvetica", 20.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 534)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Details"
        '
        'btnChangePasswrd
        '
        Me.btnChangePasswrd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnChangePasswrd.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnChangePasswrd.FlatAppearance.BorderSize = 0
        Me.btnChangePasswrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePasswrd.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnChangePasswrd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnChangePasswrd.Location = New System.Drawing.Point(277, 463)
        Me.btnChangePasswrd.Name = "btnChangePasswrd"
        Me.btnChangePasswrd.Size = New System.Drawing.Size(220, 57)
        Me.btnChangePasswrd.TabIndex = 40
        Me.btnChangePasswrd.TabStop = False
        Me.btnChangePasswrd.Text = "Change Password"
        Me.btnChangePasswrd.UseVisualStyleBackColor = False
        '
        'btnEditAccountDetails
        '
        Me.btnEditAccountDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEditAccountDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnEditAccountDetails.FlatAppearance.BorderSize = 0
        Me.btnEditAccountDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditAccountDetails.Font = New System.Drawing.Font("Helvetica", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditAccountDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnEditAccountDetails.Location = New System.Drawing.Point(37, 463)
        Me.btnEditAccountDetails.Name = "btnEditAccountDetails"
        Me.btnEditAccountDetails.Size = New System.Drawing.Size(220, 57)
        Me.btnEditAccountDetails.TabIndex = 39
        Me.btnEditAccountDetails.TabStop = False
        Me.btnEditAccountDetails.Text = "Edit Account Details"
        Me.btnEditAccountDetails.UseVisualStyleBackColor = False
        '
        'txtrole
        '
        Me.txtrole.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtrole.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtrole.Location = New System.Drawing.Point(192, 349)
        Me.txtrole.Name = "txtrole"
        Me.txtrole.ReadOnly = True
        Me.txtrole.Size = New System.Drawing.Size(305, 37)
        Me.txtrole.TabIndex = 1
        Me.txtrole.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label11.Location = New System.Drawing.Point(32, 351)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 30)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Role:"
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtaddress.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtaddress.Location = New System.Drawing.Point(192, 296)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ReadOnly = True
        Me.txtaddress.Size = New System.Drawing.Size(305, 37)
        Me.txtaddress.TabIndex = 1
        Me.txtaddress.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(32, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 30)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Address:"
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtemail.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtemail.Location = New System.Drawing.Point(192, 244)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.ReadOnly = True
        Me.txtemail.Size = New System.Drawing.Size(305, 37)
        Me.txtemail.TabIndex = 1
        Me.txtemail.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(32, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 30)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Email:"
        '
        'txtphone
        '
        Me.txtphone.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtphone.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtphone.Location = New System.Drawing.Point(192, 189)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.ReadOnly = True
        Me.txtphone.Size = New System.Drawing.Size(305, 37)
        Me.txtphone.TabIndex = 1
        Me.txtphone.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(32, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Phone:"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtname.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtname.Location = New System.Drawing.Point(192, 134)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(305, 37)
        Me.txtname.TabIndex = 1
        Me.txtname.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(32, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name:"
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtusername.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtusername.Location = New System.Drawing.Point(192, 79)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.ReadOnly = True
        Me.txtusername.Size = New System.Drawing.Size(305, 37)
        Me.txtusername.TabIndex = 1
        Me.txtusername.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(32, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'folderBrowser
        '
        Me.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'frmAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1160, 574)
        Me.Controls.Add(Me.panel_accDetails)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Helvetica", 8.25!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmAccounts"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account"
        Me.panel_accDetails.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_accDetails As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtphone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtrole As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents folderBrowser As FolderBrowserDialog
    Friend WithEvents btnEditAccountDetails As Button
    Friend WithEvents btnChangePasswrd As Button
End Class
