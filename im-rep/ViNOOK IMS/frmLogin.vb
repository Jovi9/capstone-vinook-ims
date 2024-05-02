Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLogin.TabStop = False
        btnForgotPassword.TabStop = False
    End Sub

    Private Sub btn_quit_Click(sender As Object, e As EventArgs) Handles btn_quit.Click
        Application.Exit()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        If Not txtUsername.Text.Trim = "" Then
            txtUsername.SelectAll()
        End If
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If Not txtPassword.Text.Trim = "" Then
            txtPassword.SelectAll()
        End If
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        ActiveControl = Nothing
        frmForgotPassword.ShowDialog()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usern As String = txtUsername.Text
        Dim pass As String = txtPassword.Text

        If usern.Trim = "" And pass = "" Then
            lblemptyuser.Visible = True
            lblemptypass.Visible = True
            txtUsername.Select()
            txtUsername.SelectAll()
        ElseIf usern.Trim() = "" And Not pass = "" Then
            lblemptyuser.Visible = True
            txtUsername.Select()
            txtUsername.SelectAll()
        ElseIf Not usern.Trim() = "" And pass = "" Then
            lblemptypass.Visible = True
            txtPassword.Select()
            txtPassword.SelectAll()
        Else
            btnLogin.Text = "Verifying...."
            Dim userModel As New userModel(usern, pass)
            Dim user As New userFunction
            If user.verifyLoginCredential(userModel) = True Then
                user.updateLoginTime(session_username)
                If session_role = 0 Then
                    frm_main.btn_account.Text = session_username
                    frm_main.Show()
                    Close()
                Else
                    frm_main.btn_account.Text = session_username
                    frm_main.Show()
                    Close()
                End If
            Else
                customMessageBox.show("Login Denied: Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnLogin.Text = "Login"
                txtUsername.Select()
                txtUsername.SelectAll()
            End If
        End If
    End Sub
End Class
