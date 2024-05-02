<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewCustomerDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                funcCustomer.Dispose()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewCustomerDetails))
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lable_header_title = New System.Windows.Forms.Label()
        Me.panel_bottom = New System.Windows.Forms.Panel()
        Me.panel_contrl = New System.Windows.Forms.Panel()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.txtTinID = New System.Windows.Forms.MaskedTextBox()
        Me.label_otherDetails = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.label_address = New System.Windows.Forms.Label()
        Me.label_phone = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.label_firstName = New System.Windows.Forms.Label()
        Me.panel_header.SuspendLayout()
        Me.panel_contrl.SuspendLayout()
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
        Me.panel_header.Size = New System.Drawing.Size(545, 60)
        Me.panel_header.TabIndex = 5
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
        Me.btn_close.Location = New System.Drawing.Point(494, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btn_close.Size = New System.Drawing.Size(51, 60)
        Me.btn_close.TabIndex = 7
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
        Me.lable_header_title.Size = New System.Drawing.Size(122, 40)
        Me.lable_header_title.TabIndex = 0
        Me.lable_header_title.Text = "Details"
        '
        'panel_bottom
        '
        Me.panel_bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_bottom.Location = New System.Drawing.Point(0, 517)
        Me.panel_bottom.Name = "panel_bottom"
        Me.panel_bottom.Size = New System.Drawing.Size(545, 5)
        Me.panel_bottom.TabIndex = 16
        '
        'panel_contrl
        '
        Me.panel_contrl.Controls.Add(Me.btn_edit)
        Me.panel_contrl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_contrl.Location = New System.Drawing.Point(0, 421)
        Me.panel_contrl.Name = "panel_contrl"
        Me.panel_contrl.Size = New System.Drawing.Size(545, 96)
        Me.panel_contrl.TabIndex = 23
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Font = New System.Drawing.Font("Helvetica", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_edit.Location = New System.Drawing.Point(171, 16)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(280, 57)
        Me.btn_edit.TabIndex = 39
        Me.btn_edit.TabStop = False
        Me.btn_edit.Text = "(F10) Update"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(36, 299)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(63, 37)
        Me.txtID.TabIndex = 24
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'panel_body
        '
        Me.panel_body.Controls.Add(Me.txtTinID)
        Me.panel_body.Controls.Add(Me.label_otherDetails)
        Me.panel_body.Controls.Add(Me.txtID)
        Me.panel_body.Controls.Add(Me.txtPhone)
        Me.panel_body.Controls.Add(Me.txtAddress)
        Me.panel_body.Controls.Add(Me.label_address)
        Me.panel_body.Controls.Add(Me.label_phone)
        Me.panel_body.Controls.Add(Me.txtname)
        Me.panel_body.Controls.Add(Me.label_firstName)
        Me.panel_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_body.Location = New System.Drawing.Point(0, 60)
        Me.panel_body.Name = "panel_body"
        Me.panel_body.Size = New System.Drawing.Size(545, 361)
        Me.panel_body.TabIndex = 25
        '
        'txtTinID
        '
        Me.txtTinID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTinID.AsciiOnly = True
        Me.txtTinID.BeepOnError = True
        Me.txtTinID.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtTinID.Location = New System.Drawing.Point(171, 242)
        Me.txtTinID.Mask = "000-000-000-00000"
        Me.txtTinID.Name = "txtTinID"
        Me.txtTinID.Size = New System.Drawing.Size(280, 37)
        Me.txtTinID.TabIndex = 26
        '
        'label_otherDetails
        '
        Me.label_otherDetails.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_otherDetails.AutoSize = True
        Me.label_otherDetails.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_otherDetails.Location = New System.Drawing.Point(47, 248)
        Me.label_otherDetails.Name = "label_otherDetails"
        Me.label_otherDetails.Size = New System.Drawing.Size(68, 24)
        Me.label_otherDetails.TabIndex = 25
        Me.label_otherDetails.Text = "TIN ID"
        '
        'txtPhone
        '
        Me.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPhone.AsciiOnly = True
        Me.txtPhone.BeepOnError = True
        Me.txtPhone.Font = New System.Drawing.Font("Helvetica", 15.0!)
        Me.txtPhone.Location = New System.Drawing.Point(172, 199)
        Me.txtPhone.Mask = "0000-000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(280, 37)
        Me.txtPhone.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAddress.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(172, 63)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(280, 130)
        Me.txtAddress.TabIndex = 1
        '
        'label_address
        '
        Me.label_address.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_address.AutoSize = True
        Me.label_address.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_address.Location = New System.Drawing.Point(47, 63)
        Me.label_address.Name = "label_address"
        Me.label_address.Size = New System.Drawing.Size(97, 24)
        Me.label_address.TabIndex = 22
        Me.label_address.Text = "Address *"
        '
        'label_phone
        '
        Me.label_phone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_phone.AutoSize = True
        Me.label_phone.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_phone.Location = New System.Drawing.Point(47, 205)
        Me.label_phone.Name = "label_phone"
        Me.label_phone.Size = New System.Drawing.Size(67, 24)
        Me.label_phone.TabIndex = 22
        Me.label_phone.Text = "Phone"
        '
        'txtname
        '
        Me.txtname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtname.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(172, 20)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(280, 37)
        Me.txtname.TabIndex = 0
        '
        'label_firstName
        '
        Me.label_firstName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_firstName.AutoSize = True
        Me.label_firstName.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_firstName.Location = New System.Drawing.Point(47, 26)
        Me.label_firstName.Name = "label_firstName"
        Me.label_firstName.Size = New System.Drawing.Size(77, 24)
        Me.label_firstName.TabIndex = 19
        Me.label_firstName.Text = "Name *"
        '
        'frmViewCustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(545, 522)
        Me.Controls.Add(Me.panel_body)
        Me.Controls.Add(Me.panel_contrl)
        Me.Controls.Add(Me.panel_header)
        Me.Controls.Add(Me.panel_bottom)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmViewCustomerDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Details"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panel_contrl.ResumeLayout(False)
        Me.panel_body.ResumeLayout(False)
        Me.panel_body.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents lable_header_title As Label
    Friend WithEvents panel_bottom As Panel
    Friend WithEvents panel_contrl As Panel
    Friend WithEvents txtID As TextBox
    Friend WithEvents panel_body As Panel
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents label_address As Label
    Friend WithEvents label_phone As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents label_firstName As Label
    Friend WithEvents txtTinID As MaskedTextBox
    Friend WithEvents label_otherDetails As Label
    Friend WithEvents btn_edit As Button
End Class
