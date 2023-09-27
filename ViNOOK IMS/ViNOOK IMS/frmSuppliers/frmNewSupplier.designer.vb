<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewSupplier))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtOtherDetails = New System.Windows.Forms.TextBox()
        Me.label_otherDetails = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.label_address = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.label_email = New System.Windows.Forms.Label()
        Me.label_phone = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.label_name = New System.Windows.Forms.Label()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.panel_header.SuspendLayout()
        Me.panel_body.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_header.Controls.Add(Me.btn_close)
        Me.panel_header.Controls.Add(Me.lable_header_title)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(500, 60)
        Me.panel_header.TabIndex = 6
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
        Me.btn_close.Location = New System.Drawing.Point(449, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btn_close.Size = New System.Drawing.Size(51, 60)
        Me.btn_close.TabIndex = 11
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "r"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'lable_header_title
        '
        Me.lable_header_title.AutoSize = True
        Me.lable_header_title.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable_header_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lable_header_title.Location = New System.Drawing.Point(11, 10)
        Me.lable_header_title.Name = "lable_header_title"
        Me.lable_header_title.Size = New System.Drawing.Size(213, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "Add Supplier"
        '
        'panel_body
        '
        Me.panel_body.Controls.Add(Me.btn_save)
        Me.panel_body.Controls.Add(Me.txtPhone)
        Me.panel_body.Controls.Add(Me.txtOtherDetails)
        Me.panel_body.Controls.Add(Me.label_otherDetails)
        Me.panel_body.Controls.Add(Me.txtAddress)
        Me.panel_body.Controls.Add(Me.label_address)
        Me.panel_body.Controls.Add(Me.txtEmail)
        Me.panel_body.Controls.Add(Me.label_email)
        Me.panel_body.Controls.Add(Me.label_phone)
        Me.panel_body.Controls.Add(Me.txtname)
        Me.panel_body.Controls.Add(Me.label_name)
        Me.panel_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_body.Location = New System.Drawing.Point(0, 60)
        Me.panel_body.Name = "panel_body"
        Me.panel_body.Size = New System.Drawing.Size(500, 525)
        Me.panel_body.TabIndex = 25
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_save.Location = New System.Drawing.Point(200, 451)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(280, 57)
        Me.btn_save.TabIndex = 23
        Me.btn_save.TabStop = False
        Me.btn_save.Text = "(F10) Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'txtPhone
        '
        Me.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPhone.AsciiOnly = True
        Me.txtPhone.BeepOnError = True
        Me.txtPhone.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtPhone.Location = New System.Drawing.Point(200, 208)
        Me.txtPhone.Mask = "0000-000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(280, 37)
        Me.txtPhone.TabIndex = 3
        '
        'txtOtherDetails
        '
        Me.txtOtherDetails.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtOtherDetails.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherDetails.Location = New System.Drawing.Point(200, 294)
        Me.txtOtherDetails.Multiline = True
        Me.txtOtherDetails.Name = "txtOtherDetails"
        Me.txtOtherDetails.Size = New System.Drawing.Size(280, 130)
        Me.txtOtherDetails.TabIndex = 5
        '
        'label_otherDetails
        '
        Me.label_otherDetails.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_otherDetails.AutoSize = True
        Me.label_otherDetails.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_otherDetails.Location = New System.Drawing.Point(18, 294)
        Me.label_otherDetails.Name = "label_otherDetails"
        Me.label_otherDetails.Size = New System.Drawing.Size(127, 24)
        Me.label_otherDetails.TabIndex = 22
        Me.label_otherDetails.Text = "Other Details"
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAddress.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(200, 72)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(280, 130)
        Me.txtAddress.TabIndex = 2
        '
        'label_address
        '
        Me.label_address.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_address.AutoSize = True
        Me.label_address.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_address.Location = New System.Drawing.Point(18, 72)
        Me.label_address.Name = "label_address"
        Me.label_address.Size = New System.Drawing.Size(97, 24)
        Me.label_address.TabIndex = 22
        Me.label_address.Text = "Address *"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtEmail.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(200, 251)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(280, 37)
        Me.txtEmail.TabIndex = 4
        '
        'label_email
        '
        Me.label_email.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_email.AutoSize = True
        Me.label_email.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_email.Location = New System.Drawing.Point(18, 257)
        Me.label_email.Name = "label_email"
        Me.label_email.Size = New System.Drawing.Size(59, 24)
        Me.label_email.TabIndex = 22
        Me.label_email.Text = "Email"
        '
        'label_phone
        '
        Me.label_phone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_phone.AutoSize = True
        Me.label_phone.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_phone.Location = New System.Drawing.Point(18, 214)
        Me.label_phone.Name = "label_phone"
        Me.label_phone.Size = New System.Drawing.Size(67, 24)
        Me.label_phone.TabIndex = 22
        Me.label_phone.Text = "Phone"
        '
        'txtname
        '
        Me.txtname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtname.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(200, 29)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(280, 37)
        Me.txtname.TabIndex = 0
        '
        'label_name
        '
        Me.label_name.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_name.AutoSize = True
        Me.label_name.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_name.Location = New System.Drawing.Point(18, 35)
        Me.label_name.Name = "label_name"
        Me.label_name.Size = New System.Drawing.Size(155, 24)
        Me.label_name.TabIndex = 19
        Me.label_name.Text = "Supplier Name *"
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 585)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(500, 5)
        Me.panel_bottom.TabIndex = 27
        '
        'frmNewSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 590)
        Me.Controls.Add(Me.panel_body)
        Me.Controls.Add(Me.panel_bottom)
        Me.Controls.Add(Me.panel_header)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmNewSupplier"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Supplier"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panel_body.ResumeLayout(False)
        Me.panel_body.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents lable_header_title As Label
    Friend WithEvents panel_body As Panel
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents txtOtherDetails As TextBox
    Friend WithEvents label_otherDetails As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents label_address As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents label_email As Label
    Friend WithEvents label_phone As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents label_name As Label
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents btn_save As Button
End Class
