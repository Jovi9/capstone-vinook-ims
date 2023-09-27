Public Class frmPreviewReport
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        maximizeRestore()
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

    Private Sub frmPreviewReport_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub frmPreviewReport_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'prevent alt+f4 exit
        If e.KeyCode = Keys.Escape Then
            btn_close.PerformClick()
        End If
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub
End Class