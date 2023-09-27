Public MustInherit Class customMessageBox
    Public Shared Function show(text As String) As DialogResult
        Dim result As DialogResult
        Using msgform = New frmMessageBox(text)
            result = msgform.ShowDialog()
        End Using
        Return result
    End Function

    Public Shared Function show(text As String, caption As String) As DialogResult
        Dim result As DialogResult
        Using msgform = New frmMessageBox(text, caption)
            result = msgform.ShowDialog()
        End Using
        Return result
    End Function

    Public Shared Function show(text As String, caption As String, buttons As MessageBoxButtons) As DialogResult
        Dim result As DialogResult
        Using msgform = New frmMessageBox(text, caption, buttons)
            result = msgform.ShowDialog()
        End Using
        Return result
    End Function

    Public Shared Function show(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon) As DialogResult
        Dim result As DialogResult
        Using msgform = New frmMessageBox(text, caption, buttons, icon)
            result = msgform.ShowDialog()
        End Using
        Return result
    End Function

    Public Shared Function show(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton) As DialogResult
        Dim result As DialogResult
        Using msgform = New frmMessageBox(text, caption, buttons, icon, defaultButton)
            result = msgform.ShowDialog()
        End Using
        Return result
    End Function

    'IWin32Window Owner
    'show message box sa tapat ning object buda ung mga paramaters
    'para magshow ung dialog box
    Public Shared Function show(owner As IWin32Window, text As String) As DialogResult
        Dim result As DialogResult
        Using msgform = New frmMessageBox(text)
            result = msgform.ShowDialog(owner)
        End Using
        Return result
    End Function

    Public Shared Function show(owner As IWin32Window, text As String, caption As String) As DialogResult
        Dim result As DialogResult
        Using msgform = New frmMessageBox(text, caption)
            result = msgform.ShowDialog(owner)
        End Using
        Return result
    End Function

    Public Shared Function show(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons) As DialogResult
        Dim result As DialogResult
        Using msgform = New frmMessageBox(text, caption, buttons)
            result = msgform.ShowDialog(owner)
        End Using
        Return result
    End Function

    Public Shared Function show(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon) As DialogResult
        Dim result As DialogResult
        Using msgform = New frmMessageBox(text, caption, buttons, icon)
            result = msgform.ShowDialog(owner)
        End Using
        Return result
    End Function

    Public Shared Function show(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton) As DialogResult
        Dim result As DialogResult
        Using msgform = New frmMessageBox(text, caption, buttons, icon, defaultButton)
            result = msgform.ShowDialog(owner)
        End Using
        Return result
    End Function
End Class
