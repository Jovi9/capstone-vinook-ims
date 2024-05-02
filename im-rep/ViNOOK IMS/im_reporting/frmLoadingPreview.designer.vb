<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoadingPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoadingPreview))
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.labelGenPercent = New System.Windows.Forms.Label()
        Me.labelGenerating = New System.Windows.Forms.Label()
        Me.genProgress = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'folderBrowser
        '
        Me.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'timer
        '
        '
        'labelGenPercent
        '
        Me.labelGenPercent.AutoSize = True
        Me.labelGenPercent.Font = New System.Drawing.Font("Helvetica", 20.0!)
        Me.labelGenPercent.Location = New System.Drawing.Point(516, 15)
        Me.labelGenPercent.Name = "labelGenPercent"
        Me.labelGenPercent.Size = New System.Drawing.Size(104, 40)
        Me.labelGenPercent.TabIndex = 5
        Me.labelGenPercent.Text = "100%"
        '
        'labelGenerating
        '
        Me.labelGenerating.AutoSize = True
        Me.labelGenerating.Font = New System.Drawing.Font("Helvetica", 20.0!)
        Me.labelGenerating.Location = New System.Drawing.Point(18, 15)
        Me.labelGenerating.Name = "labelGenerating"
        Me.labelGenerating.Size = New System.Drawing.Size(349, 40)
        Me.labelGenerating.TabIndex = 4
        Me.labelGenerating.Text = "Loading Print Preview"
        '
        'genProgress
        '
        Me.genProgress.Location = New System.Drawing.Point(25, 58)
        Me.genProgress.Name = "genProgress"
        Me.genProgress.Size = New System.Drawing.Size(595, 35)
        Me.genProgress.TabIndex = 3
        Me.genProgress.Value = 60
        '
        'frmLoadingPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(638, 108)
        Me.Controls.Add(Me.labelGenPercent)
        Me.Controls.Add(Me.labelGenerating)
        Me.Controls.Add(Me.genProgress)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Helvetica", 8.25!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(638, 108)
        Me.MinimumSize = New System.Drawing.Size(638, 108)
        Me.Name = "frmLoadingPreview"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading Print Preview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents folderBrowser As FolderBrowserDialog
    Friend WithEvents timer As Timer
    Friend WithEvents labelGenPercent As Label
    Friend WithEvents labelGenerating As Label
    Friend WithEvents genProgress As ProgressBar
End Class
