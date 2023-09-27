Public Class frmNewUnit

    Public fromSender As String = ""

    Private Function checkRequiredFillable() As Boolean
        If txtUnit.Text.Trim = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub frmNewUnit_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.F10) Then
            btn_save.PerformClick()
            txtUnit.Select()
        End If

        If e.KeyCode = Keys.Escape Then
            btnCancel.PerformClick()
        End If

        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmNewUnit_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ActiveControl = Nothing
        clearToDefault(panel_body)
        Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        ActiveControl = Nothing

        If checkRequiredFillable() = True Then
            Dim funcUnit As New unitFunction
            If funcUnit.checkIfUnitExists(txtUnit.Text) Then
                customMessageBox.show(Me, "Failed to add new unit. Unit already exists.", "Add Unit", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUnit.Select()
                Exit Sub
            Else
                Dim modelUnit As New unitModel With {
                    .unit = txtUnit.Text
                }
                If funcUnit.addNewUnit(modelUnit) Then
                    customMessageBox.show(Me, "Successfully added new unit.", "Add Unit", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtUnit.Select()
                    clearToDefault(panel_body)
                    If fromSender = "new product" Then
                        Close()
                    End If
                Else
                    customMessageBox.show(Me, "Failed to add new unit. Please try again.", "Add Unit", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            'customMessageBox.show(Me, "Please fill up all the required information marked with ( * ).", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            customMessageBox.show(Me, "Please enter unit name.", "Add Unit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUnit.Select()
        End If
    End Sub
End Class