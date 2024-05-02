Imports MySql.Data.MySqlClient

Public Class frmViewCustomerDetails

    Dim funcCustomer As customerFunction
    Dim modelCustomer As customerModel

    Private Function checkRequiredFillable() As Boolean
        If txtID.Text.Trim = "" Or txtname.Text.Trim = "" Or txtAddress.Text.Trim = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub populateFields()
        funcCustomer = New customerFunction
        modelCustomer = New customerModel With {
            .id = Convert.ToInt64(txtID.Text)
        }
        funcCustomer.getCustomerDetails(modelCustomer)

        txtname.Text = modelCustomer.name
        txtAddress.Text = modelCustomer.address
        txtPhone.Text = modelCustomer.phone
        txtTinID.Text = modelCustomer.tin_id

        trackCustomer_name = modelCustomer.name
        trackCustomer_address = modelCustomer.address
        trackCustomer_phone = modelCustomer.phone
        trackCustomer_tinID = modelCustomer.tin_id
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If Not txtID.Text = "" Then
            populateFields()
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        clearToDefault(panel_body)
        Close()
    End Sub

    Private Sub frmViewCustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmViewCustomerDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.F10) Then
            btn_edit.PerformClick()
        End If

        If e.KeyCode = Keys.Escape Then
            btn_close.PerformClick()
        End If

        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        ActiveControl = Nothing
        Try
            If checkRequiredFillable() = True Then
                If txtPhone.MaskCompleted = False Then
                    txtPhone.Mask = ""
                End If
                If txtTinID.MaskCompleted = False Then
                    txtTinID.Mask = ""
                End If

                modelCustomer = New customerModel With {
                        .id = Convert.ToInt64(txtID.Text),
                        .name = txtname.Text,
                        .address = txtAddress.Text,
                        .phone = txtPhone.Text,
                        .tin_id = txtTinID.Text
                    }
                funcCustomer = New customerFunction

                Dim currentDetails(3) As String
                currentDetails(0) = trackCustomer_name
                currentDetails(1) = trackCustomer_address
                currentDetails(2) = trackCustomer_phone
                currentDetails(3) = trackCustomer_tinID

                Dim newDetails(3) As String
                newDetails(0) = modelCustomer.name
                newDetails(1) = modelCustomer.address
                newDetails(2) = modelCustomer.phone
                newDetails(3) = modelCustomer.tin_id

                If matchCurrent_NewDetails(currentDetails, newDetails) Then
                    txtPhone.Mask = "0000-000-0000"
                    txtTinID.Mask = "000-000-000-00000"
                    Exit Sub
                Else
                    If funcCustomer.updateCustomerDetail(modelCustomer) Then
                        customMessageBox.show(Me, "Successfully updated customer details.", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        populateFields()
                        Close()
                    Else
                        customMessageBox.show(Me, "Failed to update customer details. Please try again.", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        populateFields()
                    End If
                End If
            Else
                customMessageBox.show(Me, "Please fill up all the required information marked with ( * ).", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As MySqlException
            If ex.Message.Contains("Duplicate entry") Then
                customMessageBox.show(Me, "Failed to update customer details. Customer already exists.", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtname.Select()
            End If
        End Try
        txtPhone.Mask = "0000-000-0000"
        txtTinID.Mask = "000-000-000-00000"
    End Sub

End Class