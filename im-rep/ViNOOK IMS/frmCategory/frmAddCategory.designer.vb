﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddCategory))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.panelControl = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.panel_header.SuspendLayout()
        Me.panelControl.SuspendLayout()
        Me.panel_body.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_header.Controls.Add(Me.lable_header_title)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(549, 60)
        Me.panel_header.TabIndex = 6
        '
        'lable_header_title
        '
        Me.lable_header_title.AutoSize = True
        Me.lable_header_title.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable_header_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lable_header_title.Location = New System.Drawing.Point(11, 10)
        Me.lable_header_title.Name = "lable_header_title"
        Me.lable_header_title.Size = New System.Drawing.Size(225, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "Add Category"
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 276)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(549, 5)
        Me.panel_bottom.TabIndex = 17
        '
        'panelControl
        '
        Me.panelControl.Controls.Add(Me.btnCancel)
        Me.panelControl.Controls.Add(Me.btn_save)
        Me.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelControl.Location = New System.Drawing.Point(0, 180)
        Me.panelControl.Name = "panelControl"
        Me.panelControl.Size = New System.Drawing.Size(549, 96)
        Me.panelControl.TabIndex = 26
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(286, 16)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 66)
        Me.btnCancel.TabIndex = 39
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "(Esc) Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_save.Location = New System.Drawing.Point(114, 16)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(150, 66)
        Me.btn_save.TabIndex = 38
        Me.btn_save.TabStop = False
        Me.btn_save.Text = "(F10) Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'panel_body
        '
        Me.panel_body.Controls.Add(Me.txtCategory)
        Me.panel_body.Controls.Add(Me.lbl_name)
        Me.panel_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_body.Location = New System.Drawing.Point(0, 60)
        Me.panel_body.Name = "panel_body"
        Me.panel_body.Size = New System.Drawing.Size(549, 120)
        Me.panel_body.TabIndex = 27
        '
        'txtCategory
        '
        Me.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategory.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(205, 39)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(280, 37)
        Me.txtCategory.TabIndex = 20
        '
        'lbl_name
        '
        Me.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(26, 45)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(164, 24)
        Me.lbl_name.TabIndex = 21
        Me.lbl_name.Text = "Category Name *"
        '
        'frmAddCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(549, 281)
        Me.Controls.Add(Me.panel_body)
        Me.Controls.Add(Me.panelControl)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.panel_header)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmAddCategory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Category"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panelControl.ResumeLayout(False)
        Me.panel_body.ResumeLayout(False)
        Me.panel_body.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents lable_header_title As Label
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents panelControl As Panel
    Friend WithEvents panel_body As Panel
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents btnCancel As Button
End Class
