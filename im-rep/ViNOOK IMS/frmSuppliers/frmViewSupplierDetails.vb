Imports MySql.Data.MySqlClient

Public Class frmViewSupplierDetails

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Dim funcSupplier As supplierFunction
    Dim modelSupplier As supplierModel

    Private Function checkRequiredFillable() As Boolean
        If txtID.Text.Trim = "" Or txtname.Text.Trim = "" Or txtAddress.Text.Trim = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub populateFields()
        funcSupplier = New supplierFunction
        modelSupplier = New supplierModel With {
            .supplierid = Convert.ToInt64(txtID.Text)
        }
        funcSupplier.getSupplierDetails(modelSupplier)

        txtname.Text = modelSupplier.name
        txtAddress.Text = modelSupplier.address
        txtPhone.Text = modelSupplier.phone
        txtEmail.Text = modelSupplier.email
        txtOtherDetails.Text = modelSupplier.other_details

        tracking_Suppliername = modelSupplier.name
        tracking_Supplieraddress = modelSupplier.address
        tracking_Supplierphone = modelSupplier.phone
        tracking_Supplieremail = modelSupplier.email
        tracking_SupplierotherDetails = modelSupplier.other_details
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        clearToDefault(panel_body)
        Close()
    End Sub

    Private Sub frmViewSupplierDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If (e.KeyCode = Keys.F10) Then
            btn_update.PerformClick()
        End If

        If e.KeyCode = Keys.Escape Then
            btn_close.PerformClick()
        End If

        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If Not txtID.Text.Trim = "" Then
            populateFields()
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        ActiveControl = Nothing
        Try
            If checkRequiredFillable() = True Then
                If txtPhone.MaskCompleted = False Then
                    txtPhone.Mask = ""
                End If

                modelSupplier = New supplierModel With {
                        .supplierid = Convert.ToInt64(txtID.Text),
                        .name = txtname.Text,
                        .address = txtAddress.Text,
                        .phone = txtPhone.Text,
                        .email = txtEmail.Text,
                        .other_details = txtOtherDetails.Text
                    }

                funcSupplier = New supplierFunction

                Dim currentDetails(4) As String
                currentDetails(0) = tracking_Suppliername
                currentDetails(1) = tracking_Supplieraddress
                currentDetails(2) = tracking_Supplierphone
                currentDetails(3) = tracking_Supplieremail
                currentDetails(4) = tracking_SupplierotherDetails
                Dim newDetails(4) As String
                newDetails(0) = modelSupplier.name
                newDetails(1) = modelSupplier.address
                newDetails(2) = modelSupplier.phone
                newDetails(3) = modelSupplier.email
                newDetails(4) = modelSupplier.other_details

                If matchCurrent_NewDetails(currentDetails, newDetails) Then
                    txtPhone.Mask = "0000-000-0000"
                    Exit Sub
                Else
                    If funcSupplier.updateSupplierDetail(modelSupplier) Then
                        customMessageBox.show(Me, "Successfully updated supplier details.", "Edit Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        populateFields()
                        Close()
                    Else
                        customMessageBox.show(Me, "Failed to update supplier details. Please try again.", "Edit Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        populateFields()
                    End If
                End If
            Else
                customMessageBox.show(Me, "Please fill up all the required information marked with ( * ).", "Edit Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As MySqlException
            If ex.Message.Contains("Duplicate entry") Then
                customMessageBox.show(Me, "Failed to update supplier details. Supplier already exists.", "Edit Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtname.Select()
            End If
        End Try
        txtPhone.Mask = "0000-000-0000"
    End Sub
End Class