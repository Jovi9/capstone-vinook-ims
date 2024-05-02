Imports System.IO

Public Class frmChangePassword

    Public senderFrom As String = ""
    Private Function requiredFillable() As Boolean
        If txtOldPassword.Text.Trim = "" Or txtNewPassword.Text.Trim = "" Or txtConfirmPassword.Text.Trim = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function checkPasswordMatch() As Boolean
        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            Return False
        Else
            Return True
        End If
    End Function

    'Private Sub exportRecoveryCode(funcUser As userFunction, modelUser As userModel)
    '    Dim fileName As String = "vinook_" & modelUser.username & "_recovery_code"
    '    Dim dataWriter As StreamWriter
    '    folderBrowser.Description = "Choose path to save recovery code."
    '    If folderBrowser.ShowDialog = DialogResult.OK Then
    '        Dim recoveryPath As String = folderBrowser.SelectedPath
    '        funcUser.exportRecoveryCode(modelUser)
    '        dataWriter = File.CreateText(recoveryPath & "\" & fileName)
    '        dataWriter.Write(modelUser.recoverycode)
    '        dataWriter.Close()
    '        customMessageBox.show(Me, "Recovery code saved to " & recoveryPath & "\" & fileName, "Export Recovery Code", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Process.Start(recoveryPath)
    '    Else
    '        customMessageBox.show(Me, "Export operation cancelled. Export recovery code by clicking the Export Recovery Code Button", "Export Recovery Code", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOldPassword.Clear()
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
        If Not senderFrom = "forgot password" Then
            txtOldPassword.Visible = True
            txtOldPassword.Enabled = True
            labelOldPassword.Visible = True
        End If
    End Sub

    Private Sub frmChangePassword_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F10 Then
            btn_update.PerformClick()
        End If

        If e.KeyCode = Keys.Escape Then
            btnCancel.PerformClick()
        End If
        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim funcUser As New userFunction
        Dim modelUser As New userModel
        If senderFrom = "forgot password" Then
            If txtNewPassword.Text.Trim = "" Or txtConfirmPassword.Text.Trim = "" Then
                txtNewPassword.Select()
            Else
                If checkPasswordMatch() Then
                    With modelUser
                        .email = session_email
                        .userpassword = txtNewPassword.Text
                    End With

                    funcUser.getUsername_byEmail(modelUser.email)

                    If funcUser.changePassword_byEmail(modelUser) Then
                        Dim otp As String = funcUser.generateOTP
                        modelUser.email = session_email
                        modelUser.recoverycode = otp
                        funcUser.updateOTP_byEmail(modelUser)
                        customMessageBox.show(Me, "Password updated.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        senderFrom = ""
                        clearToDefault(Me)
                        frmForgotPassword.btnCancel.PerformClick()
                        Close()
                    Else
                        customMessageBox.show(Me, "Failed to changed to password. Please try again.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    customMessageBox.show(Me, "Password do not match.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If requiredFillable() = True Then
                With modelUser
                    .username = session_username
                    .userpassword = txtOldPassword.Text
                End With
                If funcUser.verifyLoginCredential(modelUser) Then
                    If checkPasswordMatch() Then
                        With modelUser
                            .username = session_username
                            .userpassword = txtNewPassword.Text
                        End With
                        If funcUser.changePassword(modelUser) Then
                            Dim otp As String = funcUser.generateOTP
                            modelUser.email = session_email
                            modelUser.recoverycode = otp
                            funcUser.updateOTP_byEmail(modelUser)
                            customMessageBox.show(Me, "Password updated.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Question)
                            clearToDefault(Me)
                            Close()
                        Else
                            customMessageBox.show(Me, "Failed to changed to password. Please try again.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        customMessageBox.show(Me, "Password do not match.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    customMessageBox.show(Me, "Old password is invalid. Please try again.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearToDefault(Me)
        Close()
    End Sub

End Class