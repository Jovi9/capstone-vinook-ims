<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessageBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMessageBox))
        Me.labelCaption = New System.Windows.Forms.Label()
        Me.panelButtons = New System.Windows.Forms.Panel()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.labelMessage = New System.Windows.Forms.Label()
        Me.pictureBoxIcon = New System.Windows.Forms.PictureBox()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.panelButtons.SuspendLayout()
        Me.panelBody.SuspendLayout()
        CType(Me.pictureBoxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTitleBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelCaption
        '
        Me.labelCaption.AutoSize = True
        Me.labelCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCaption.ForeColor = System.Drawing.Color.White
        Me.labelCaption.Location = New System.Drawing.Point(12, 10)
        Me.labelCaption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelCaption.Name = "labelCaption"
        Me.labelCaption.Size = New System.Drawing.Size(101, 20)
        Me.labelCaption.TabIndex = 4
        Me.labelCaption.Text = "labelCaption"
        '
        'panelButtons
        '
        Me.panelButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.panelButtons.Controls.Add(Me.button3)
        Me.panelButtons.Controls.Add(Me.button2)
        Me.panelButtons.Controls.Add(Me.button1)
        Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelButtons.Location = New System.Drawing.Point(0, 111)
        Me.panelButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(467, 74)
        Me.panelButtons.TabIndex = 5
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.Gray
        Me.button3.FlatAppearance.BorderSize = 0
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.button3.Location = New System.Drawing.Point(308, 15)
        Me.button3.Margin = New System.Windows.Forms.Padding(4)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(133, 43)
        Me.button3.TabIndex = 2
        Me.button3.Text = "button3"
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.Gray
        Me.button2.FlatAppearance.BorderSize = 0
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.button2.Location = New System.Drawing.Point(167, 15)
        Me.button2.Margin = New System.Windows.Forms.Padding(4)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(133, 43)
        Me.button2.TabIndex = 1
        Me.button2.Text = "button2"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.Gray
        Me.button1.FlatAppearance.BorderSize = 0
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.button1.Location = New System.Drawing.Point(25, 15)
        Me.button1.Margin = New System.Windows.Forms.Padding(4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(133, 43)
        Me.button1.TabIndex = 0
        Me.button1.Text = "button1"
        Me.button1.UseVisualStyleBackColor = False
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelBody.Controls.Add(Me.labelMessage)
        Me.panelBody.Controls.Add(Me.pictureBoxIcon)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(0, 43)
        Me.panelBody.Margin = New System.Windows.Forms.Padding(4)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Padding = New System.Windows.Forms.Padding(13, 12, 0, 0)
        Me.panelBody.Size = New System.Drawing.Size(467, 68)
        Me.panelBody.TabIndex = 6
        '
        'labelMessage
        '
        Me.labelMessage.AutoSize = True
        Me.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.labelMessage.Location = New System.Drawing.Point(66, 12)
        Me.labelMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelMessage.MaximumSize = New System.Drawing.Size(800, 0)
        Me.labelMessage.Name = "labelMessage"
        Me.labelMessage.Padding = New System.Windows.Forms.Padding(7, 6, 13, 18)
        Me.labelMessage.Size = New System.Drawing.Size(132, 44)
        Me.labelMessage.TabIndex = 1
        Me.labelMessage.Text = "labelMessage"
        Me.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pictureBoxIcon
        '
        Me.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.pictureBoxIcon.Image = Global.ViNOOK_IMS.My.Resources.Resources.message
        Me.pictureBoxIcon.Location = New System.Drawing.Point(13, 12)
        Me.pictureBoxIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBoxIcon.Name = "pictureBoxIcon"
        Me.pictureBoxIcon.Size = New System.Drawing.Size(53, 56)
        Me.pictureBoxIcon.TabIndex = 0
        Me.pictureBoxIcon.TabStop = False
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.panelTitleBar.Controls.Add(Me.labelCaption)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.panelTitleBar.Margin = New System.Windows.Forms.Padding(4)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(467, 43)
        Me.panelTitleBar.TabIndex = 4
        '
        'frmMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 185)
        Me.Controls.Add(Me.panelBody)
        Me.Controls.Add(Me.panelButtons)
        Me.Controls.Add(Me.panelTitleBar)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(461, 174)
        Me.Name = "frmMessageBox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMessageBox"
        Me.panelButtons.ResumeLayout(False)
        Me.panelBody.ResumeLayout(False)
        Me.panelBody.PerformLayout()
        CType(Me.pictureBoxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents labelCaption As Label
    Private WithEvents panelButtons As Panel
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents panelBody As Panel
    Private WithEvents labelMessage As Label
    Private WithEvents pictureBoxIcon As PictureBox
    Private WithEvents panelTitleBar As Panel
End Class
