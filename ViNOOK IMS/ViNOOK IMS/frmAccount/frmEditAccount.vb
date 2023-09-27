Public Class frmEditAccount
    Dim funcUser As userFunction
    Dim modelUser As userModel

    Public Sub populateFields()
        funcUser = New userFunction
        modelUser = New userModel With {
            .username = session_username
        }
        funcUser.getAccountDetails(modelUser)
        txtusername.Text = modelUser.username
        txtFirstName.Text = modelUser.firstname
        txtLastName.Text = modelUser.lastname
        txtphone.Text = modelUser.phone
        txtemail.Text = modelUser.email
        txtaddress.Text = modelUser.address

        trackAccount_username = modelUser.username
        trackAccount_firstname = modelUser.firstname
        trackAccount_lastname = modelUser.lastname
        trackAccount_phone = modelUser.phone
        trackAccount_email = modelUser.email
        trackAccount_address = modelUser.address
    End Sub

    Private Function requiredFillable() As Boolean
        If txtFirstName.Text.Trim = "" Or txtLastName.Text.Trim = "" Or
           txtPhone.Text.Trim = "" Or txtemail.Text.Trim = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub frmEditAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateFields()
        txtPhone.Mask = "0000-000-0000"
        txtFirstName.Select()
        txtFirstName.SelectAll()
    End Sub

    Private Sub frmEditAccount_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
        If requiredFillable() = True Then
            If validateEmail(txtemail.Text) Then
                If txtPhone.MaskCompleted = False Then
                    txtPhone.Mask = ""
                End If
                funcUser = New userFunction
                modelUser = New userModel
                With modelUser
                    .username = txtusername.Text
                    .firstname = txtFirstName.Text
                    .lastname = txtLastName.Text
                    .phone = txtPhone.Text
                    .email = txtemail.Text
                    .address = txtaddress.Text
                End With

                Dim currentDetails(4) As String
                currentDetails(0) = trackAccount_firstname
                currentDetails(1) = trackAccount_lastname
                currentDetails(2) = trackAccount_phone
                currentDetails(3) = trackAccount_email
                currentDetails(4) = trackAccount_address

                Dim newDetails(4) As String
                newDetails(0) = modelUser.firstname
                newDetails(1) = modelUser.lastname
                newDetails(2) = modelUser.phone
                newDetails(3) = modelUser.email
                newDetails(4) = modelUser.address

                If matchCurrent_NewDetails(currentDetails, newDetails) Then
                    txtPhone.Mask = "0000-000-0000"
                    Exit Sub
                Else
                    If funcUser.updateAccountDetails(modelUser) Then
                        customMessageBox.show(Me, "Account details updated.", "Edit Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        clearToDefault(Me)
                        Close()
                    Else
                        customMessageBox.show(Me, "Failed to update account details. Please try again.", "Edit Account", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                customMessageBox.show(Me, "Please enter a valid email.", "Edit Account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            customMessageBox.show(Me, "Please fill up the required fields marked with ( * ).", "Edit Account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        txtPhone.Mask = "0000-000-0000"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearToDefault(Me)
        Close()
    End Sub

End Class