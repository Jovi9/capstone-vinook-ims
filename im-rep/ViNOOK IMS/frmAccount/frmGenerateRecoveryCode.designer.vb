<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerateRecoveryCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerateRecoveryCode))
        Me.genProgress = New System.Windows.Forms.ProgressBar()
        Me.lblGenerating = New System.Windows.Forms.Label()
        Me.labelGenPercent = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'genProgress
        '
        Me.genProgress.Location = New System.Drawing.Point(19, 52)
        Me.genProgress.Name = "genProgress"
        Me.genProgress.Size = New System.Drawing.Size(595, 35)
        Me.genProgress.TabIndex = 0
        '
        'lblGenerating
        '
        Me.lblGenerating.AutoSize = True
        Me.lblGenerating.Font = New System.Drawing.Font("Helvetica", 20.0!)
        Me.lblGenerating.Location = New System.Drawing.Point(12, 9)
        Me.lblGenerating.Name = "lblGenerating"
        Me.lblGenerating.Size = New System.Drawing.Size(429, 40)
        Me.lblGenerating.TabIndex = 1
        Me.lblGenerating.Text = "Generating Recovery Code"
        '
        'labelGenPercent
        '
        Me.labelGenPercent.AutoSize = True
        Me.labelGenPercent.Font = New System.Drawing.Font("Helvetica", 20.0!)
        Me.labelGenPercent.Location = New System.Drawing.Point(510, 9)
        Me.labelGenPercent.Name = "labelGenPercent"
        Me.labelGenPercent.Size = New System.Drawing.Size(104, 40)
        Me.labelGenPercent.TabIndex = 2
        Me.labelGenPercent.Text = "100%"
        '
        'timer
        '
        '
        'folderBrowser
        '
        Me.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'frmGenerateRecoveryCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(638, 108)
        Me.Controls.Add(Me.labelGenPercent)
        Me.Controls.Add(Me.lblGenerating)
        Me.Controls.Add(Me.genProgress)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Helvetica", 8.25!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(638, 108)
        Me.MinimumSize = New System.Drawing.Size(638, 108)
        Me.Name = "frmGenerateRecoveryCode"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generating Recovery Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents genProgress As ProgressBar
    Friend WithEvents lblGenerating As Label
    Friend WithEvents labelGenPercent As Label
    Friend WithEvents timer As Timer
    Friend WithEvents folderBrowser As FolderBrowserDialog
End Class
