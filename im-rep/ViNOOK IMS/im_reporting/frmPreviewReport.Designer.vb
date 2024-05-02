<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPreviewReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreviewReport))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.panel_top = New System.Windows.Forms.Panel()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.panel_right = New System.Windows.Forms.Panel()
        Me.panel_left = New System.Windows.Forms.Panel()
        Me.reportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.panel_header.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_header.Controls.Add(Me.btn_close)
        Me.panel_header.Controls.Add(Me.lable_header_title)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Margin = New System.Windows.Forms.Padding(4)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(925, 49)
        Me.panel_header.TabIndex = 7
        '
        'btn_close
        '
        Me.btn_close.AutoSize = True
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_close.Location = New System.Drawing.Point(857, 0)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_close.Size = New System.Drawing.Size(68, 49)
        Me.btn_close.TabIndex = 8
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "r"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'lable_header_title
        '
        Me.lable_header_title.AutoSize = True
        Me.lable_header_title.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable_header_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lable_header_title.Location = New System.Drawing.Point(16, 5)
        Me.lable_header_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lable_header_title.Name = "lable_header_title"
        Me.lable_header_title.Size = New System.Drawing.Size(218, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "Print Preview"
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.Location = New System.Drawing.Point(0, 49)
        Me.panel_top.Margin = New System.Windows.Forms.Padding(4)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(925, 6)
        Me.panel_top.TabIndex = 38
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 544)
        Me.panel_bottom.Margin = New System.Windows.Forms.Padding(4)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(925, 10)
        Me.panel_bottom.TabIndex = 39
        '
        'panel_right
        '
        Me.panel_right.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_right.Location = New System.Drawing.Point(915, 55)
        Me.panel_right.Margin = New System.Windows.Forms.Padding(4)
        Me.panel_right.Name = "panel_right"
        Me.panel_right.Size = New System.Drawing.Size(10, 489)
        Me.panel_right.TabIndex = 40
        '
        'panel_left
        '
        Me.panel_left.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_left.Location = New System.Drawing.Point(0, 55)
        Me.panel_left.Margin = New System.Windows.Forms.Padding(4)
        Me.panel_left.Name = "panel_left"
        Me.panel_left.Size = New System.Drawing.Size(10, 489)
        Me.panel_left.TabIndex = 41
        '
        'reportViewer
        '
        Me.reportViewer.ActiveViewIndex = -1
        Me.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportViewer.Location = New System.Drawing.Point(10, 55)
        Me.reportViewer.Name = "reportViewer"
        Me.reportViewer.ShowCloseButton = False
        Me.reportViewer.ShowCopyButton = False
        Me.reportViewer.ShowLogo = False
        Me.reportViewer.ShowParameterPanelButton = False
        Me.reportViewer.Size = New System.Drawing.Size(905, 489)
        Me.reportViewer.TabIndex = 42
        Me.reportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmPreviewReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 554)
        Me.Controls.Add(Me.reportViewer)
        Me.Controls.Add(Me.panel_left)
        Me.Controls.Add(Me.panel_right)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.panel_top)
        Me.Controls.Add(Me.panel_header)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPreviewReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Preview"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents lable_header_title As Label
    Friend WithEvents panel_top As Panel
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents panel_right As Panel
    Friend WithEvents panel_left As Panel
    Friend WithEvents reportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
