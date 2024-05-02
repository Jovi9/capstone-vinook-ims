<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditCategory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                funcCategory.Dispose()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditCategory))
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.panelControl = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.panel_header.SuspendLayout()
        Me.panelControl.SuspendLayout()
        Me.panel_body.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(9, 59)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(48, 31)
        Me.txtID.TabIndex = 25
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_header.Controls.Add(Me.lable_header_title)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(412, 49)
        Me.panel_header.TabIndex = 26
        '
        'lable_header_title
        '
        Me.lable_header_title.AutoSize = True
        Me.lable_header_title.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable_header_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lable_header_title.Location = New System.Drawing.Point(8, 8)
        Me.lable_header_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lable_header_title.Name = "lable_header_title"
        Me.lable_header_title.Size = New System.Drawing.Size(181, 32)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "Edit Category"
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 224)
        Me.panel_bottom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(412, 4)
        Me.panel_bottom.TabIndex = 27
        '
        'panelControl
        '
        Me.panelControl.Controls.Add(Me.btnCancel)
        Me.panelControl.Controls.Add(Me.btn_update)
        Me.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelControl.Location = New System.Drawing.Point(0, 146)
        Me.panelControl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelControl.Name = "panelControl"
        Me.panelControl.Size = New System.Drawing.Size(412, 78)
        Me.panelControl.TabIndex = 28
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(214, 12)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 54)
        Me.btnCancel.TabIndex = 41
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
        Me.btn_update.Location = New System.Drawing.Point(85, 12)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(112, 54)
        Me.btn_update.TabIndex = 40
        Me.btn_update.TabStop = False
        Me.btn_update.Text = "(F10) Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'panel_body
        '
        Me.panel_body.Controls.Add(Me.txtCategory)
        Me.panel_body.Controls.Add(Me.txtID)
        Me.panel_body.Controls.Add(Me.lbl_name)
        Me.panel_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_body.Location = New System.Drawing.Point(0, 49)
        Me.panel_body.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panel_body.Name = "panel_body"
        Me.panel_body.Size = New System.Drawing.Size(412, 97)
        Me.panel_body.TabIndex = 29
        '
        'txtCategory
        '
        Me.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategory.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(154, 32)
        Me.txtCategory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(211, 31)
        Me.txtCategory.TabIndex = 20
        '
        'lbl_name
        '
        Me.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(20, 37)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(131, 19)
        Me.lbl_name.TabIndex = 21
        Me.lbl_name.Text = "Category Name *"
        '
        'frmEditCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(412, 228)
        Me.Controls.Add(Me.panel_body)
        Me.Controls.Add(Me.panelControl)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.panel_header)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmEditCategory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Category"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panelControl.ResumeLayout(False)
        Me.panel_body.ResumeLayout(False)
        Me.panel_body.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents panel_header As Panel
    Friend WithEvents lable_header_title As Label
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents panelControl As Panel
    Friend WithEvents panel_body As Panel
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btn_update As Button
End Class
