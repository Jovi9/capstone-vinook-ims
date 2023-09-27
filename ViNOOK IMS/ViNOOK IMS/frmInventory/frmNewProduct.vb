Public Class frmNewProduct
    Dim funcInventory As inventoryFunction

    Private Sub populateComboBox()
        funcInventory = New inventoryFunction
        funcInventory.loadCategoryComboBox(dropCategory, "table")
    End Sub

    Private Sub populateUnitCombobox()
        funcInventory = New inventoryFunction
        funcInventory.loadUnitsComboBox(dropUnit)
        Try
            dropUnit.SelectedIndex = 0
        Catch ex As Exception
            Console.WriteLine("System Error: " & ex.Message)
        End Try
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

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        ActiveControl = Nothing
        clearToDefault(Me)
        Close()
    End Sub

    Public senderFrom As String = ""

    Private Sub frmNewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateComboBox()
        populateUnitCombobox()
        txtItemCode.Select()
        btnAddCategory.TabStop = False
        btnAddUnit.TabStop = False
    End Sub

    Private Sub frmNewProduct_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.F10) Then
            btn_save_product.PerformClick()
            txtName.Select()
        End If

        If e.KeyCode = Keys.Escape Then
            btn_close.PerformClick()
        End If

        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        ActiveControl = Nothing
        frmAddCategory.ShowDialog()
    End Sub

    Private Sub dropCategory_DropDown(sender As Object, e As EventArgs) Handles dropCategory.DropDown
        populateComboBox()
    End Sub

    Private Sub dropUnit_DropDown(sender As Object, e As EventArgs) Handles dropUnit.DropDown
        populateUnitCombobox()
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

    Private Sub btn_save_product_Click(sender As Object, e As EventArgs) Handles btn_save_product.Click
        If checkRequiredFillable() Then
            funcInventory = New inventoryFunction
            'Dim modelInventory As New inventoryModel(txtName.Text, txtBrand.Text, txtModel.Text, Convert.ToString(dropCategory.Text), Convert.ToString(dropUnit.Text), Convert.ToDecimal(txtPrice.Text))
            Dim modelInventory As New inventoryModel
            With modelInventory
                .itemcode = txtItemCode.Text
                .name = txtName.Text
                .brand = txtBrand.Text
                .model = txtModel.Text
                .category = dropCategory.SelectedValue
                .categoryname = Convert.ToString(dropCategory.Text)
                .unit = Convert.ToString(dropUnit.Text)
                .price = Convert.ToDecimal(txtPrice.Value)
            End With

            If funcInventory.addNewProduct(modelInventory) Then
                customMessageBox.show(Me, "Successfully added new product.", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtName.Select()
                clearToDefault(Me)
                If senderFrom = "new stock" Then
                    frmNewStock.txtItemCode.Text = modelInventory.itemcode
                    frmNewStock.populateProductDetails()
                    senderFrom = ""
                    Close()
                End If
            Else
                customMessageBox.show(Me, "Failed to add new product. Please try again.", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            customMessageBox.show(Me, "Please fill up all the information.", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Select()
        End If
    End Sub

    Private Sub btnAddUnit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnAddUnit.LinkClicked
        frmNewUnit.fromSender = "new product"
        frmNewUnit.ShowDialog()
    End Sub

    Private Sub txtItemCode_Leave(sender As Object, e As EventArgs) Handles txtItemCode.Leave
        If txtItemCode.Text.Trim = "" Then
            txtItemCode.Select()
        End If
    End Sub
End Class