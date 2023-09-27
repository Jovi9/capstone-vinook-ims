Public Class frmNewSupplier

    Private Function checkRequiredFillable() As Boolean
        If txtname.Text.Trim = "" Or txtAddress.Text.Trim = "" Then
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        ActiveControl = Nothing
        clearToDefault(panel_body)
        Close()
    End Sub

    Private Sub frmNewSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPhone.Mask = "0000-000-0000"
    End Sub

    Private Sub frmNewSupplier_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.F10) Then
            btn_save.PerformClick()
            txtname.Select()
        End If

        If e.KeyCode = Keys.Escape Then
            btn_close.PerformClick()
        End If

        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txtPhone.MaskCompleted = False Then
            txtPhone.Mask = ""
        End If

        If checkRequiredFillable() = True Then
            Dim funcSupplier As New supplierFunction
            If funcSupplier.checkIfSupplierExists(txtname.Text) Then
                customMessageBox.show(Me, "Failed to add new supplier. Supplier already exists.", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtname.Select()
                Exit Sub
            Else
                Dim modelSupplier As New supplierModel
                With modelSupplier
                    .name = txtname.Text
                    .address = txtAddress.Text
                    .phone = txtPhone.Text
                    .email = txtEmail.Text
                    .other_details = txtOtherDetails.Text
                End With

                If funcSupplier.addNewSupplier(modelSupplier) = True Then
                    customMessageBox.show(Me, "Successfully added new supplier.", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtname.Select()
                    clearToDefault(panel_body)
                Else
                    customMessageBox.show(Me, "Failed to add new supplier. Please try again.", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            customMessageBox.show(Me, "Please fill up all the required information marked with ( * ).", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtname.Select()
        End If
        txtPhone.Mask = "0000-000-0000"
    End Sub
End Class