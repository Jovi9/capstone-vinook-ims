Public Class frmLoadingPreview

    Public senderFrom As String = ""

    Public category As String = ""
    Public brand As String = ""
    Public model As String = ""
    Public orderDate As Date
    Public startDate As Date
    Public endDate As Date
    Public supplier As String

    Private Sub frmLoadingPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelGenerating.Text = "Loading Print Preview"
        genProgress.Value = 60
        labelGenPercent.Text = genProgress.Value
        timer.Start()
    End Sub

    Private Sub frmLoadingPreview_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        genProgress.Increment(10)
        labelGenPercent.Text = genProgress.Value & "%"

        Dim print As New reportingFunction

        If genProgress.Value = 70 Then
            If senderFrom = "category" Then
                print.printCategory()
                frmPreviewReport.ShowDialog()
            ElseIf senderFrom = "suppliers" Then
                print.printSuppliers()
                frmPreviewReport.ShowDialog()
            ElseIf senderFrom = "customers" Then
                print.printCustomers()
                frmPreviewReport.ShowDialog()
            ElseIf senderFrom = "orders_A" Then
                print.printOrders(startDate)
                frmPreviewReport.ShowDialog()
            ElseIf senderFrom = "orders_B" Then
                print.printOrders(startDate, endDate)
                frmPreviewReport.ShowDialog()
            ElseIf senderFrom = "all_orders_A" Then
                print.printAllOrders(category, brand, model, orderDate)
                frmPreviewReport.ShowDialog()
            ElseIf senderFrom = "all_orders_B" Then
                print.printAllOrders(category, brand, model, startDate, endDate)
                frmPreviewReport.ShowDialog()
            ElseIf senderFrom = "inventory" Then
                print.printInventory(category)
                frmPreviewReport.ShowDialog()
            ElseIf senderFrom = "all_inventory_A" Then
                print.printAllInventory(category, supplier, startDate)
                frmPreviewReport.ShowDialog()
            ElseIf senderFrom = "all_inventory_B" Then
                print.printAllInventory(category, supplier, startDate, endDate)
                frmPreviewReport.ShowDialog()
            ElseIf senderFrom = "low_stock" Then
                print.printLowStock()
                frmPreviewReport.ShowDialog()
            End If

        End If
        If genProgress.Value = 100 Then
            _timer.Stop()
            labelGenerating.Text = "Please wait..."
            Close()
        End If
    End Sub
End Class