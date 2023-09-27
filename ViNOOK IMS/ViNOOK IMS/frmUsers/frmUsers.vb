Public Class frmUsers

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        'frmMain.preventFLicker()
        'frmMain.fadein()

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        ActiveControl = Nothing
        Close()
    End Sub
End Class