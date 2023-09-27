Public Class frmViewProductDetails

    Dim funcInventory As inventoryFunction
    Dim modelInventory As inventoryModel

    Private Sub populateComboBox()
        funcInventory = New inventoryFunction
        funcInventory.loadCategoryComboBox(dropCategory, "table")
    End Sub

    Private Sub populateUnitCombobox()
        funcInventory = New inventoryFunction
        funcInventory.loadUnitsComboBox(dropUnit)
    End Sub

    Private Function checkRequiredFillable() As Boolean
        If txtItemCode.Text.Trim = "" Or
            txtName.Text.Trim = "" Or txtBrand.Text.Trim = "" Or
            txtModel.Text.Trim = "" Or dropCategory.Text.Trim = "" Or dropCategory.Text = "ALL" Or
            dropUnit.Text.Trim = "" Or txtPrice.Text.Trim = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub populateFields()
        funcInventory = New inventoryFunction
        modelInventory = New inventoryModel With {
            .productid = Convert.ToInt64(txtID.Text)
        }
        funcInventory.getProductDetails(modelInventory, "id")

        txtItemCode.Text = modelInventory.itemcode
        txtName.Text = modelInventory.name
        txtBrand.Text = modelInventory.brand
        txtModel.Text = modelInventory.model
        dropCategory.SelectedValue = modelInventory.category
        dropUnit.SelectedItem = modelInventory.unit
        txtPrice.Text = modelInventory.price

        Dim totalQuantity As String = Format("{0:#,##0}", modelInventory.quantity)
        Dim inStock As String = Format("{0:#,##0}", modelInventory.onhand)
        label_TotalQuantity.Text = "Total Quantity: " & totalQuantity
        label_InStock.Text = "In Stock: " & inStock

        trackProduct_itemCode = modelInventory.itemcode
        trackProduct_name = modelInventory.name
        trackProduct_brand = modelInventory.brand
        trackProduct_model = modelInventory.model
        trackProduct_category = Convert.ToString(dropCategory.Text)
        trackProduct_unit = modelInventory.unit
        trackProduct_price = modelInventory.price
    End Sub


    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If Not txtID.Text = "" Then
            populateFields()
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        ActiveControl = Nothing
        clearToDefault(Me)
        Close()
    End Sub

    Private Sub frmViewProductDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        populateComboBox()
        populateUnitCombobox()
        populateFields()
    End Sub

    Private Sub frmViewProductDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub txtPrice_Enter(sender As Object, e As EventArgs) Handles txtPrice.Enter
        If txtPrice.Value = 0 Or txtPrice.Value = 1 Then
            txtPrice.ResetText()
        End If
    End Sub

    Private Sub txtItemCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItemCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtName.Select()
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        ActiveControl = Nothing
        If checkRequiredFillable() = True Then
            modelInventory = New inventoryModel With {
                        .productid = Convert.ToInt64(txtID.Text),
                        .itemcode = txtItemCode.Text,
                        .name = txtName.Text,
                        .brand = txtBrand.Text,
                        .model = txtModel.Text,
                        .category = dropCategory.SelectedValue,
                        .categoryname = Convert.ToString(dropCategory.Text),
                        .unit = Convert.ToString(dropUnit.Text),
                        .price = Convert.ToDecimal(txtPrice.Text)
                    }

            funcInventory = New inventoryFunction

            Dim currentDetails(6) As String
            currentDetails(0) = trackProduct_itemCode
            currentDetails(1) = trackProduct_name
            currentDetails(2) = trackProduct_brand
            currentDetails(3) = trackProduct_model
            currentDetails(4) = trackProduct_category
            currentDetails(5) = trackProduct_unit
            currentDetails(6) = trackProduct_price

            Dim newDetails(6) As String
            newDetails(0) = modelInventory.itemcode
            newDetails(1) = modelInventory.name
            newDetails(2) = modelInventory.brand
            newDetails(3) = modelInventory.model
            newDetails(4) = modelInventory.categoryname
            newDetails(5) = modelInventory.unit
            newDetails(6) = modelInventory.price

            If matchCurrent_NewDetails(currentDetails, newDetails) Then
                Exit Sub
            Else
                If funcInventory.updateProductDetail(modelInventory) Then
                    customMessageBox.show(Me, "Successfully updated product details.", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    populateFields()
                Else
                    customMessageBox.show(Me, "Failed to update product details. Please try again.", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    populateFields()
                End If
            End If
        Else
            customMessageBox.show(Me, "Please fill up all the information.", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class