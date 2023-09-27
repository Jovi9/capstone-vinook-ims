<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgotPassword
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForgotPassword))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVerificationCode = New System.Windows.Forms.TextBox()
        Me.fileBrowser = New System.Windows.Forms.OpenFileDialog()
        Me.btnSendVerificationCode = New System.Windows.Forms.Button()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.panel_progress = New System.Windows.Forms.Panel()
        Me.labelGenPercent = New System.Windows.Forms.Label()
        Me.lblGenerating = New System.Windows.Forms.Label()
        Me.genProgress = New System.Windows.Forms.ProgressBar()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.panel_header.SuspendLayout()
        Me.panel_progress.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_header.Controls.Add(Me.lable_header_title)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(727, 60)
        Me.panel_header.TabIndex = 7
        '
        'lable_header_title
        '
        Me.lable_header_title.AutoSize = True
        Me.lable_header_title.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable_header_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lable_header_title.Location = New System.Drawing.Point(11, 10)
        Me.lable_header_title.Name = "lable_header_title"
        Me.lable_header_title.Size = New System.Drawing.Size(274, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "Forgot Password"
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 375)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(727, 5)
        Me.panel_bottom.TabIndex = 35
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtEmail.Location = New System.Drawing.Point(360, 87)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(305, 37)
        Me.txtEmail.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(59, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 30)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Enter Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(59, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 30)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Enter Verification Code:"
        '
        'txtVerificationCode
        '
        Me.txtVerificationCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerificationCode.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtVerificationCode.Location = New System.Drawing.Point(360, 153)
        Me.txtVerificationCode.Name = "txtVerificationCode"
        Me.txtVerificationCode.Size = New System.Drawing.Size(305, 37)
        Me.txtVerificationCode.TabIndex = 1
        '
        'fileBrowser
        '
        Me.fileBrowser.FileName = "fileBrowser"
        '
        'btnSendVerificationCode
        '
        Me.btnSendVerificationCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnSendVerificationCode.FlatAppearance.BorderSize = 0
        Me.btnSendVerificationCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendVerificationCode.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSendVerificationCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnSendVerificationCode.Location = New System.Drawing.Point(360, 207)
        Me.btnSendVerificationCode.Name = "btnSendVerificationCode"
        Me.btnSendVerificationCode.Size = New System.Drawing.Size(305, 50)
        Me.btnSendVerificationCode.TabIndex = 2
        Me.btnSendVerificationCode.Text = "Send Verification Code"
        Me.btnSendVerificationCode.UseVisualStyleBackColor = False
        '
        'btn_submit
        '
        Me.btn_submit.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_submit.FlatAppearance.BorderSize = 0
        Me.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_submit.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_submit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_submit.Location = New System.Drawing.Point(95, 283)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(240, 70)
        Me.btn_submit.TabIndex = 64
        Me.btn_submit.TabStop = False
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(364, 283)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(240, 70)
        Me.btnCancel.TabIndex = 65
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "(Esc) Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUsername.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtUsername.Location = New System.Drawing.Point(30, 212)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(305, 37)
        Me.txtUsername.TabIndex = 66
        Me.txtUsername.TabStop = False
        Me.txtUsername.Visible = False
        '
        'panel_progress
        '
        Me.panel_progress.Controls.Add(Me.labelGenPercent)
        Me.panel_progress.Controls.Add(Me.lblGenerating)
        Me.panel_progress.Controls.Add(Me.genProgress)
        Me.panel_progress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_progress.Location = New System.Drawing.Point(0, 60)
        Me.panel_progress.Name = "panel_progress"
        Me.panel_progress.Size = New System.Drawing.Size(727, 315)
        Me.panel_progress.TabIndex = 67
        '
        'labelGenPercent
        '
        Me.labelGenPercent.AutoSize = True
        Me.labelGenPercent.Font = New System.Drawing.Font("Helvetica", 20.0!)
        Me.labelGenPercent.Location = New System.Drawing.Point(560, 118)
        Me.labelGenPercent.Name = "labelGenPercent"
        Me.labelGenPercent.Size = New System.Drawing.Size(104, 40)
        Me.labelGenPercent.TabIndex = 5
        Me.labelGenPercent.Text = "100%"
        '
        'lblGenerating
        '
        Me.lblGenerating.AutoSize = True
        Me.lblGenerating.Font = New System.Drawing.Font("Helvetica", 20.0!)
        Me.lblGenerating.Location = New System.Drawing.Point(62, 118)
        Me.lblGenerating.Name = "lblGenerating"
        Me.lblGenerating.Size = New System.Drawing.Size(410, 40)
        Me.lblGenerating.TabIndex = 4
        Me.lblGenerating.Text = "Sending Verification Code"
        '
        'genProgress
        '
        Me.genProgress.Location = New System.Drawing.Point(69, 161)
        Me.genProgress.Name = "genProgress"
        Me.genProgress.Size = New System.Drawing.Size(595, 35)
        Me.genProgress.TabIndex = 3
        '
        'timer
        '
        '
        'folderBrowser
        '
        Me.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'frmForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(727, 380)
        Me.Controls.Add(Me.panel_progress)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.btnSendVerificationCode)
        Me.Controls.Add(Me.txtVerificationCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.panel_header)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmForgotPassword"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Password"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panel_progress.ResumeLayout(False)
        Me.panel_progress.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents lable_header_title As Label
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVerificationCode As TextBox
    Friend WithEvents fileBrowser As OpenFileDialog
    Friend WithEvents btnSendVerificationCode As Button
    Friend WithEvents btn_submit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents panel_progress As Panel
    Friend WithEvents labelGenPercent As Label
    Friend WithEvents lblGenerating As Label
    Friend WithEvents genProgress As ProgressBar
    Friend WithEvents timer As Timer
    Friend WithEvents folderBrowser As FolderBrowserDialog
End Class
