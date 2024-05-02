Imports System.Runtime.InteropServices

Public Class frmMessageBox
    'field or body
    Private _primaryColor As Color = Color.CornflowerBlue
    Private ReadOnly _borderSize As Integer = 2

    'properties
    Public Property primaryColor As Color
        Get
            Return _primaryColor
        End Get
        Set(value As Color)
            _primaryColor = value
            BackColor = primaryColor 'border
            panelTitleBar.BackColor = primaryColor 'titlebar
        End Set
    End Property

    'functions
    Private Sub initializeItems()
        FormBorderStyle = FormBorderStyle.None
        Padding = New Padding(_borderSize) 'setting border size
        labelMessage.MaximumSize = New Size(550, 0)
        button1.DialogResult = DialogResult.OK
        button1.Visible = False
        button2.Visible = False
        button3.Visible = False
    End Sub

    Private Sub setFormSize()
        Dim width As Integer = labelMessage.Width + pictureBoxIcon.Width + panelBody.Padding.Left
        Dim height As Integer = panelTitleBar.Height + labelMessage.Height + panelButtons.Height + panelBody.Padding.Top
        Size = New Size(width, height)
    End Sub

    Private Sub setDefaultButton(defaultButton As MessageBoxDefaultButton)
        Select Case defaultButton
            Case MessageBoxDefaultButton.Button1
                button1.Select()
                button1.ForeColor = Color.White
                button1.Font = New Font(button1.Font, FontStyle.Underline)

            Case MessageBoxDefaultButton.Button2
                button2.Select()
                button2.ForeColor = Color.White
                button2.Font = New Font(button2.Font, FontStyle.Underline)

            Case MessageBoxDefaultButton.Button3
                button3.Select()
                button3.ForeColor = Color.White
                button3.Font = New Font(button3.Font, FontStyle.Underline)

        End Select
    End Sub

    Private Sub setIcon(icon As MessageBoxIcon)
        Select Case icon
            Case MessageBoxIcon.Error
                pictureBoxIcon.Image = My.Resources.close
                primaryColor = Color.FromArgb(224, 79, 95)

            Case MessageBoxIcon.Information
                pictureBoxIcon.Image = My.Resources.information
                primaryColor = Color.FromArgb(38, 191, 166)

            Case MessageBoxIcon.Question
                pictureBoxIcon.Image = My.Resources.question
                primaryColor = Color.FromArgb(100, 119, 232)

            Case MessageBoxIcon.Warning
                pictureBoxIcon.Image = My.Resources.warning
                primaryColor = Color.FromArgb(255, 140, 0)

            Case MessageBoxIcon.None
                pictureBoxIcon.Image = My.Resources.message
                primaryColor = Color.FromArgb(22, 137, 252)
        End Select
    End Sub

    Private Sub setButtons(buttons As MessageBoxButtons, defaultButton As MessageBoxDefaultButton)
        Dim xCenter As Integer = (panelButtons.Width - button1.Width) / 2
        Dim yCenter As Integer = (panelButtons.Height - button1.Height) / 2

        Select Case buttons
            Case MessageBoxButtons.OK
                'btn ok
                button1.Visible = True
                button1.Location = New Point(xCenter, yCenter)
                button1.Text = "&Ok"
                button1.DialogResult = DialogResult.OK
                'set default btn
                setDefaultButton(defaultButton)

            Case MessageBoxButtons.OKCancel
                button1.Visible = True
                button1.Location = New Point(xCenter - (button1.Width / 2) - 5, yCenter)
                button1.Text = "&Ok"
                button1.DialogResult = DialogResult.OK

                button2.Visible = True
                button2.Location = New Point(xCenter + (button2.Width / 2) + 5, yCenter)
                button2.Text = "&Cancel"
                button2.DialogResult = DialogResult.Cancel
                button2.BackColor = Color.DimGray

                If defaultButton <> MessageBoxDefaultButton.Button3 Then
                    setDefaultButton(defaultButton)
                Else
                    setDefaultButton(MessageBoxDefaultButton.Button1)
                End If

            Case MessageBoxButtons.RetryCancel
                button1.Visible = True
                button1.Location = New Point(xCenter - (button1.Width / 2) - 5, yCenter)
                button1.Text = "&Retry"
                button1.DialogResult = DialogResult.Retry

                button2.Visible = True
                button2.Location = New Point(xCenter + (button2.Width / 2) + 5, yCenter)
                button2.Text = "&Cancel"
                button2.DialogResult = DialogResult.Cancel
                button2.BackColor = Color.DimGray

                If defaultButton <> MessageBoxDefaultButton.Button3 Then
                    setDefaultButton(defaultButton)
                Else
                    setDefaultButton(MessageBoxDefaultButton.Button1)
                End If

            Case MessageBoxButtons.YesNo
                button1.Visible = True
                button1.Location = New Point(xCenter - (button1.Width / 2) - 5, yCenter)
                button1.Text = "&Yes"
                button1.DialogResult = DialogResult.Yes

                button2.Visible = True
                button2.Location = New Point(xCenter + (button2.Width / 2) + 5, yCenter)
                button2.Text = "&No"
                button2.DialogResult = DialogResult.No
                button2.BackColor = Color.FromArgb(224, 79, 95)

                If defaultButton <> MessageBoxDefaultButton.Button3 Then
                    setDefaultButton(defaultButton)
                Else
                    setDefaultButton(MessageBoxDefaultButton.Button1)
                End If

                'Case MessageBoxButtons.AbortRetryIgnore
                '    button1.Visible = True
                '    button1.Location = New Point(xCenter - button1.Width - 5, yCenter)
                '    button1.Text = "Abort"
                '    button1.DialogResult = DialogResult.Abort

                '    button2.Visible = True
                '    button2.Location = New Point(xCenter, yCenter)
                '    button2.Text = "Retry"
                '    button2.DialogResult = DialogResult.Retry

                '    button3.Visible = True
                '    button3.Location = New Point(xCenter + button2.Width + 5, yCenter)
                '    button3.Text = "Ignore"
                '    button3.DialogResult = DialogResult.Ignore

                '    setDefaultButton(defaultButton)
            Case Else
                'btn ok
                button1.Visible = True
                button1.Location = New Point(xCenter, yCenter)
                button1.Text = "&Ok"
                button1.DialogResult = DialogResult.OK
                'set default btn
                setDefaultButton(defaultButton)
        End Select
    End Sub

    'constructor
    Public Sub New(text As String)
        InitializeComponent()
        initializeItems()
        primaryColor = _primaryColor
        labelMessage.Text = text
        labelCaption.Text = ""
        setFormSize()
        setButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1)
    End Sub

    Public Sub New(text As String, caption As String)
        InitializeComponent()
        initializeItems()
        primaryColor = _primaryColor
        labelMessage.Text = text
        labelCaption.Text = caption
        setFormSize()
        setButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1)
    End Sub

    Public Sub New(text As String, caption As String, buttons As MessageBoxButtons)
        InitializeComponent()
        initializeItems()
        primaryColor = _primaryColor
        labelMessage.Text = text
        labelCaption.Text = caption
        setFormSize()
        setButtons(buttons, MessageBoxDefaultButton.Button1)
    End Sub

    Public Sub New(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon)
        InitializeComponent()
        initializeItems()
        primaryColor = _primaryColor
        labelMessage.Text = text
        labelCaption.Text = caption
        setFormSize()
        setButtons(buttons, MessageBoxDefaultButton.Button1)
        setIcon(icon)
    End Sub

    Public Sub New(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton)
        InitializeComponent()
        initializeItems()
        primaryColor = _primaryColor
        labelMessage.Text = text
        labelCaption.Text = caption
        setFormSize()
        setButtons(buttons, defaultButton)
        setIcon(icon)
    End Sub

End Class