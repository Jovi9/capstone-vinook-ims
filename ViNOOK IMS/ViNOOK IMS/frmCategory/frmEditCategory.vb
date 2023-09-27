Imports MySql.Data.MySqlClient

Public Class frmEditCategory
    Dim funcCategory As categoryFunction
    Dim modelCategory As categoryModel

    Private Function checkRequiredFillable() As Boolean
        If txtCategory.Text.Trim = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub populateFields()
        funcCategory = New categoryFunction
        modelCategory = New categoryModel With {
            .id = Convert.ToInt64(txtID.Text)
        }
        funcCategory.getCategoryDetails(modelCategory)

        txtCategory.Text = modelCategory.category

        trackCategory_name = modelCategory.category
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If Not txtID.Text = "" Then
            populateFields()
        End If
    End Sub

    Private Sub frmEditCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.F10) Then
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
        Try
            If checkRequiredFillable() = True Then
                modelCategory = New categoryModel
                With modelCategory
                    .id = Convert.ToInt64(txtID.Text)
                    .category = txtCategory.Text
                End With

                funcCategory = New categoryFunction

                If String.Equals(trackCategory_name, modelCategory.category) Then
                    Exit Sub
                Else
                    If funcCategory.updateCategoryDetail(modelCategory) Then
                        customMessageBox.show(Me, "Successfully updated category.", "Edit Category", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        populateFields()
                        frmCategories.loadCategoryDataGrid()
                    Else
                        customMessageBox.show(Me, "Failed to update category. Please try again.", "Edit Category", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        populateFields()
                    End If
                End If
            Else
                customMessageBox.show(Me, "Please enter category name.", "Edit Category", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCategory.Select()
            End If

        Catch ex As MySqlException
            If ex.Message.Contains("Duplicate entry") Then
                customMessageBox.show(Me, "Failed to update category. Category already exists.", "Edit Category", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCategory.Select()
            End If
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ActiveControl = Nothing
        clearToDefault(panel_body)
        Close()
    End Sub

End Class