Imports System.Text.RegularExpressions
Public Class frmForgotPassword

    Private Sub frmForgotPassword_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtEmail.Select()
        btnSendVerificationCode.Text = "Send Verification Code"
        btnSendVerificationCode.Enabled = True
        genProgress.Value = 0
        labelGenPercent.Text = genProgress.Value
        lblGenerating.Text = "Sending Verification Code"
        panel_progress.Enabled = False
        panel_progress.Visible = False
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If txtEmail.Text.Trim = "" Or txtVerificationCode.Text.Trim = "" Then
            txtEmail.Select()
            txtEmail.SelectAll()
            Exit Sub
        Else
            Dim funcUser As New userFunction
            Dim modelUser As New userModel

            If funcUser.verifyEmail(txtEmail.Text) Then
                With modelUser
                    .email = txtEmail.Text
                    .recoverycode = txtVerificationCode.Text
                End With
                If funcUser.getExpiryDate(txtEmail.Text, txtVerificationCode.Text) > DateTime.Now Then
                    If funcUser.verifyOTP(modelUser) Then
                        session_email = modelUser.email
                        frmChangePassword.senderFrom = "forgot password"
                        frmChangePassword.txtOldPassword.Visible = False
                        frmChangePassword.txtOldPassword.Enabled = False
                        frmChangePassword.labelOldPassword.Visible = False
                        btnSendVerificationCode.Enabled = True
                        frmChangePassword.ShowDialog()
                    Else
                        customMessageBox.show(Me, "Invalid credentials. Please try again.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        modelUser.username = ""
                        modelUser.recoverycode = ""
                    End If
                Else
                    customMessageBox.show(Me, "Invalid credentials. Please try again or resend verifcation code.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    modelUser.username = ""
                    modelUser.recoverycode = ""
                End If
            Else
                customMessageBox.show(Me, "Invalid credential. Please try again.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearToDefault(Me)
        panel_progress.Enabled = False
        panel_progress.Visible = False
        timer.Stop()
        Close()
    End Sub

    Private Sub btnSendVerificationCode_Click(sender As Object, e As EventArgs) Handles btnSendVerificationCode.Click
        If validateEmail(txtEmail.Text) Then
            Dim funcUser As New userFunction
            Dim modelUser As New userModel

            If funcUser.verifyEmail(txtEmail.Text) Then
                btnSendVerificationCode.Enabled = False
                genProgress.Value = 0
                lblGenerating.Text = "Sending Verification Code"
                panel_progress.Enabled = True
                panel_progress.Visible = True
                timer.Start()
            End If
        Else
            customMessageBox.show(Me, "Please enter a valid email.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        genProgress.Increment(5)
        labelGenPercent.Text = genProgress.Value & "%"
        Dim funcUser As New userFunction
        Dim modelUser As New userModel

        Dim otp As String = funcUser.generateOTP

        If genProgress.Value = "80" Then
            funcUser.sendOTP_ToMail(txtEmail.Text, otp)
        End If

        modelUser.email = txtEmail.Text
        modelUser.recoverycode = otp

        If genProgress.Value = 100 Then
            funcUser.updateOTP_byEmail(modelUser)
            panel_progress.Enabled = False
            panel_progress.Visible = False
            lblGenerating.Text = "Please wait..."
            timer.Stop()
        End If
    End Sub
End Class