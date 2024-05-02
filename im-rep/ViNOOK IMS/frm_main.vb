Public Class frm_main

    Private currentButton As Button
    Private ReadOnly leftBorderButton As Panel
    Private counter As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderButton = New Panel With {
            .Size = New Size(10, 60)
        }
        panel_menu.Controls.Add(leftBorderButton)

        'MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        preventFLicker()
        maximizeRestore()
    End Sub

    Public Sub fadein()
        Dim fade As Double
        For fade = 0.0 To 1 Step 0.1
            Opacity = fade
            Refresh()
        Next
    End Sub

    Public Sub preventFLicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub

    Private Sub maximizeRestore()
        Dim isMaximised As Boolean = False
        Dim normalBounds As Rectangle

        If Not isMaximised Then
            normalBounds = Bounds
            Bounds = Screen.PrimaryScreen.WorkingArea
        Else
            Bounds = normalBounds
        End If
    End Sub

    Private Sub openChildForms(formName As Form)
        checkLowStock()
        Dim isOpen As Boolean = False

        Dim openfrm As Form
        For Each openfrm In Application.OpenForms
            If openfrm.Name = formName.Name Then
                isOpen = True
                openfrm.Activate()
                label_header_title.Text = formName.Text
                Exit Sub
            End If
        Next
        If isOpen = False Then
            With formName
                .MdiParent = Me
                .Dock = DockStyle.Fill
            End With
            formName.Show()
            label_header_title.Text = formName.Text
            isOpen = True
        End If

        If MdiChildren.Count > 1 Then
            For Each childForm As Form In MdiChildren
                If childForm IsNot ActiveMdiChild Then
                    childForm.Close()
                End If
            Next
        End If
    End Sub

    Public Sub checkLowStock()
        Dim funcInventory As New inventoryFunction
        Dim stockCount As Long = funcInventory.getLowStockCount
        If stockCount = 0 Then
            pnlNotification.Visible = False
        Else
            timerMarquee.Start()
            timerWaiting.Start()
            pnlNotification.Visible = True
            lblNotification.Text = "WARNING " & stockCount & " PRODUCTS ARE LOW ON STOCK!"
        End If
    End Sub

#Region "->Panel Menu Design"

    'button focus methods
    Private Sub activateButton(senderbtn As Object, customColor As Color)
        If senderbtn IsNot Nothing Then
            deactivateButton()
            'button customize
            currentButton = CType(senderbtn, Button)
            currentButton.BackColor = rgbColors.secondary_dark
            currentButton.ForeColor = customColor
            currentButton.TextAlign = ContentAlignment.MiddleCenter
            currentButton.ImageAlign = ContentAlignment.MiddleLeft
            currentButton.TextImageRelation = TextImageRelation.TextBeforeImage
            'border active
            leftBorderButton.BackColor = customColor
            leftBorderButton.Location = New Point(0, currentButton.Location.Y)
            leftBorderButton.Visible = True
            leftBorderButton.BringToFront()
        End If
    End Sub

    Private Sub deactivateButton()
        If currentButton IsNot Nothing Then
            currentButton.BackColor = rgbColors.main_dark
            currentButton.ForeColor = rgbColors.textPrimary
            currentButton.TextAlign = ContentAlignment.MiddleLeft
            currentButton.ImageAlign = ContentAlignment.MiddleLeft
            currentButton.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    'Private Sub initHideSubMenu()
    '    panelSettingsSubMenu.Visible = False
    'End Sub

    'Private Sub hideSubMenu()
    '    If panelSettingsSubMenu.Visible = True Then
    '        panelSettingsSubMenu.Visible = False
    '    End If
    'End Sub

    'Private Sub showSubMenu(subMenu As Panel)
    '    If subMenu.Visible = False Then
    '        hideSubMenu()
    '        subMenu.Visible = True
    '    Else
    '        subMenu.Visible = False
    '    End If
    'End Sub
#End Region

#Region "->Panel Menu"

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim user As New userFunction
        user.updateLoginTime(session_username)
        frmLogin.Show()
        Close()
    End Sub

    Private Sub btnOverview_Click(sender As Object, e As EventArgs) Handles btnOverview.Click
        ActiveControl = Nothing
        activateButton(sender, rgbColors.green_like)
        openChildForms(New frmOverview)
    End Sub

    Private Sub btn_inventory_Click(sender As Object, e As EventArgs) Handles btn_inventory.Click
        ActiveControl = Nothing
        activateButton(sender, rgbColors.green_like)
        openChildForms(New frmInventory)
    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click
        ActiveControl = Nothing
        activateButton(sender, rgbColors.green_like)
        openChildForms(New frmOrders)
    End Sub

    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click
        ActiveControl = Nothing
        activateButton(sender, rgbColors.green_like)
        openChildForms(New frmCustomers)
    End Sub

    Private Sub btn_suppliers_Click(sender As Object, e As EventArgs) Handles btn_suppliers.Click
        ActiveControl = Nothing
        activateButton(sender, rgbColors.green_like)
        openChildForms(New frmSuppliers)
    End Sub

    Private Sub btn_categories_Click(sender As Object, e As EventArgs) Handles btn_categories.Click
        ActiveControl = Nothing
        activateButton(sender, rgbColors.green_like)
        openChildForms(New frmCategories)
    End Sub

    Private Sub btn_account_Click(sender As Object, e As EventArgs) Handles btn_account.Click
        ActiveControl = Nothing
        activateButton(sender, rgbColors.green_like)
        openChildForms(New frmAccounts)
    End Sub

    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        ActiveControl = Nothing
        activateButton(sender, rgbColors.green_like)
        openChildForms(New frmHistory)
    End Sub
#End Region

#Region "->Header Control, Minimize, Resize, Close"

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_resize_Click(sender As Object, e As EventArgs) Handles btn_resize.Click
        ActiveControl = Nothing
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ActiveControl = Nothing
        Dim res As DialogResult = customMessageBox.show(Me, "Are you sure you want to Exit application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            Dim user As New userFunction
            user.updateLoginTime(session_username)
            Application.Exit()
        End If
    End Sub

#End Region

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        fadein()
        openChildForms(New frmInventory)
        pnlNotification.Location = New Point(1200, 0)
        checkLowStock()
    End Sub

    Private Sub frm_main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ActiveControl = Nothing
        If WindowState = FormWindowState.Maximized Then
            btn_resize.Text = 2
        Else
            btn_resize.Text = 1
        End If
    End Sub

    Private Sub frm_main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub lblNotification_Click(sender As Object, e As EventArgs) Handles lblNotification.Click
        ActiveControl = Nothing
        frmViewLowStock.ShowDialog()
    End Sub

    Private Sub timerMarquee_Tick(sender As Object, e As EventArgs) Handles timerMarquee.Tick
        pnlNotification.Location = New Point(pnlNotification.Location.X - 10, pnlNotification.Location.Y)
        'Console.WriteLine(pnlNotification.Location.ToString)

        If counter = 3 Then
            If pnlNotification.Location.ToString = "{X=10,Y=0}" Then
                timerMarquee.Stop()
                pnlNotification.Visible = True
                pnlNotification.BringToFront()
                notification_timeout = Date.Now.AddSeconds(30)
                counter = 1
            End If
        Else
            If pnlNotification.Location.ToString = "{X=-500,Y=0}" Then
                counter += 1
                pnlNotification.Visible = True
                pnlNotification.Location = New Point(1320, 0)
                pnlNotification.BringToFront()
                notification_timeout = Date.Now.AddSeconds(30)
            End If
        End If
        'Console.WriteLine("Counter: " & counter)
    End Sub

    Private Sub timerWaiting_Tick(sender As Object, e As EventArgs) Handles timerWaiting.Tick
        If notification_timeout < Date.Now Then
            timerMarquee.Start()
        End If
    End Sub
End Class