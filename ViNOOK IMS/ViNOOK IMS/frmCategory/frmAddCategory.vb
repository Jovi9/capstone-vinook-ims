Public Class frmAddCategory

    Private Function checkRequiredFillable() As Boolean
        If txtCategory.Text.Trim = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub frmAddCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.F10) Then
            btn_save.PerformClick()
            txtCategory.Select()
        End If

        If e.KeyCode = Keys.Escape Then
            btnCancel.PerformClick()
        End If

        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        ActiveControl = Nothing

        If checkRequiredFillable() = True Then
            Dim funcCategory As New categoryFunction
            If funcCategory.checkIfCategoryExists(txtCategory.Text) Then
                customMessageBox.show(Me, "Failed to add new category. Category already exists.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCategory.Select()
                Exit Sub
            Else
                Dim modelCategory As New categoryModel With {
                    .category = txtCategory.Text
                }

                If funcCategory.addNewCategory(modelCategory) Then
                    customMessageBox.show(Me, "Successfully added new category.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCategory.Select()
                    clearToDefault(panel_body)
                    frmCategories.loadCategoryDataGrid()
                Else
                    customMessageBox.show(Me, "Failed to add new category. Please try again.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            'customMessageBox.show(Me, "Please fill up all the required information marked with ( * ).", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            customMessageBox.show(Me, "Please enter category name.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCategory.Select()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ActiveControl = Nothing
        clearToDefault(panel_body)
        Close()
    End Sub

End Class