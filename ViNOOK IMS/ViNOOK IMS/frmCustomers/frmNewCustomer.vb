Public Class frmNewCustomer

    Public senderFrom As String = ""

    Private Function checkRequiredFillable() As Boolean
        If txtname.Text.Trim = "" Or txtAddress.Text.Trim = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub frmNewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        ActiveControl = Nothing
        clearToDefault(panel_body)
        Close()
    End Sub

    Private Sub frmNewCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.F10) Then
            btn_save_customer.PerformClick()
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

    Private Sub btn_save_customer_Click(sender As Object, e As EventArgs) Handles btn_save_customer.Click
        If txtPhone.MaskCompleted = False Then
            txtPhone.Mask = ""
        End If
        If txtTinID.MaskCompleted = False Then
            txtTinID.Mask = ""
        End If

        If checkRequiredFillable() = True Then
            Dim funcCustomer As New customerFunction
            If funcCustomer.checkIfCustomerExists(txtname.Text) Then
                customMessageBox.show(Me, "Failed to add new customer. Customer already exists.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtname.Select()
                Exit Sub
            Else
                Dim modelCustomer As New customerModel With {
                    .name = txtname.Text,
                    .address = txtAddress.Text,
                    .phone = txtPhone.Text,
                    .tin_id = txtTinID.Text
                }

                If funcCustomer.addNewCustomer(modelCustomer) Then
                    customMessageBox.show(Me, "Successfully added new customer.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If senderFrom = "order" Then
                        frmSaveOrder.txtname.Text = txtname.Text
                        clearToDefault(panel_body)
                        Close()
                        frmChooseCustomer.Close()
                    Else
                        txtname.Select()
                        clearToDefault(panel_body)
                        frmCustomers.loadCustomerDataGrid()
                    End If
                Else
                    customMessageBox.show(Me, "Failed to add new customer. Please try again.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            customMessageBox.show(Me, "Please fill up all the required information marked with ( * ).", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtname.Select()
        End If
        txtPhone.Mask = "0000-000-0000"
        txtTinID.Mask = "000-000-000-00000"
    End Sub

End Class