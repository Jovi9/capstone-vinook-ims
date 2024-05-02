Imports System.IO

Public Class frmAccounts
    Dim funcUser As userFunction
    Dim modelUser As userModel
    Public Sub populateFields()
        funcUser = New userFunction
        modelUser = New userModel With {
            .username = session_username
        }
        funcUser.getAccountDetails(modelUser)
        txtusername.Text = modelUser.username
        txtname.Text = modelUser.name
        txtphone.Text = modelUser.phone
        txtemail.Text = modelUser.email
        txtaddress.Text = modelUser.address
        txtrole.Text = modelUser.role
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

#Region "->Remove Flicker"
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
#End Region
#Region "->Actions"
    Private Sub btnEditAccountDetails_Click(sender As Object, e As EventArgs) Handles btnEditAccountDetails.Click
        ActiveControl = Nothing
        frmEditAccount.ShowDialog()
        populateFields()
    End Sub

    Private Sub btnChangePasswrd_Click(sender As Object, e As EventArgs) Handles btnChangePasswrd.Click
        ActiveControl = Nothing
        frmChangePassword.ShowDialog()
    End Sub

#End Region

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateFields()
    End Sub
End Class