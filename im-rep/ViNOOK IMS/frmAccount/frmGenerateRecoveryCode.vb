Imports System.IO

Public Class frmGenerateRecoveryCode
    Private Sub frmGenerateRecoveryCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        genProgress.Value = 0
        labelGenPercent.Text = genProgress.Value
        timer.Start()
    End Sub

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

    Private Sub frmGenerateRecoveryCode_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        genProgress.Increment(5)
        labelGenPercent.Text = genProgress.Value & "%"
        Dim funcUser As New userFunction
        Dim modelUser As New userModel
        With modelUser
            .username = session_username
        End With
        'funcUser.generateRecoveryCode(modelUser)
        If genProgress.Value = 100 Then
            timer.Stop()
            Dim res = customMessageBox.show(Me, "Your recovery code has been created. Make sure to save the code in a safe place." & Environment.NewLine & "Export recovery code now?", "Recovery Code", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = DialogResult.Yes Then
                'exportRecoveryCode(funcUser, modelUser)
            End If
            Close()
        End If
    End Sub
End Class