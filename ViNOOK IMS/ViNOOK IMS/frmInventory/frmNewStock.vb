Imports MySql.Data.MySqlClient

Public Class frmNewStock
    Dim funcInventory As inventoryFunction
    Dim modelInventory As inventoryModel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub populateProductDetails()
        funcInventory = New inventoryFunction
        modelInventory = New inventoryModel With {
            .itemcode = txtItemCode.Text
        }
        funcInventory.getProductDetails(modelInventory, "itemcode")
        txtID.Text = modelInventory.productid
        txtName.Text = modelInventory.name
        txtBrand.Text = modelInventory.brand
        txtModel.Text = modelInventory.model
        txtCategory.Text = modelInventory.categoryname
        Dim price As String = String.Format("{0:#,##0.00}", modelInventory.price)
        txtPrice.Text = price

    End Sub

    Private Sub populateComboBox()
        funcInventory = New inventoryFunction
        funcInventory.loadSupplierComboBox(dropSupplier, "table")
    End Sub

    Private Function checkRequiredFillable() As Boolean
        If txtID.Text.Trim = "" Or txtID.Text = "0" Or txtSerialNumber.Text.Trim = "" Or
                dropSupplier.Text.Trim = "" Or txtMarkUp.Value = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub frmNewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateComboBox()
        txtItemCode.Select()
        btnAddProduct.TabStop = False
        btnAddSupplier.TabStop = False
        btnSearchProduct.TabStop = False
    End Sub

    Private Sub frmNewStock_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.E) Then
            btnSearchProduct_LinkClicked(btnSearchProduct, Nothing)
        End If

        If (e.Control AndAlso e.KeyCode = Keys.N) Then
            btnAddProduct_LinkClicked(btnAddProduct, Nothing)
        End If

        If (e.KeyCode = Keys.F10) Then
            btn_save_stock.PerformClick()
            txtItemCode.Select()
        End If

        If e.KeyCode = Keys.F5 Then
            txtItemCode.Clear()
            txtSerialNumber.Clear()
            txtMarkUp.Enabled = False
            dropSupplier.Enabled = False
            btnAddSupplier.Enabled = False
            txtQuantity.Enabled = False

            ActiveControl = txtItemCode
            txtItemCode.Select()
        End If

        If e.KeyCode = Keys.Escape Then
            btn_close.PerformClick()
        End If

        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        ActiveControl = Nothing
        clearToDefault(group_product_details)
        disableAllControls(group_product_details)
        txtItemCode.Select()
        txtItemCode.Enabled = True
        Close()
    End Sub

    Private Sub dropSupplier_DropDown(sender As Object, e As EventArgs) Handles dropSupplier.DropDown
        populateComboBox()
    End Sub

#Region "->New stock"
    Private Sub txtItemCode_TextChanged(sender As Object, e As EventArgs) Handles txtItemCode.TextChanged
        populateProductDetails()
        funcInventory = New inventoryFunction
        If funcInventory.checkIfProductExist(Convert.ToInt64(txtID.Text)) Then
            modelInventory = New inventoryModel With {
            .productid = Convert.ToInt64(txtID.Text)
        }
            funcInventory.getStockDetails(modelInventory, "product_id")

            txtDetailID.Text = modelInventory.detailid

            txtMarkUp.Value = modelInventory.atCost
            If Not modelInventory.supplier = "" Then
                dropSupplier.SelectedValue = modelInventory.supplier
            End If
        Else
            txtMarkUp.Value = 0
            dropSupplier.SelectedValue = 1
        End If
    End Sub

    Private Sub txtItemCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItemCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSerialNumber.Select()
        End If
        If e.KeyCode = Keys.Tab Then
            txtSerialNumber.Select()
        End If
    End Sub

    Private Sub txtItemCode_Leave(sender As Object, e As EventArgs) Handles txtItemCode.Leave
        If txtItemCode.Text.Trim = "" Or txtID.Text.Trim = "" Or txtID.Text = "0" Then
            txtItemCode.Select()
        Else
            txtSerialNumber.Enabled = True
        End If
    End Sub

    Private Sub btnAddProduct_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnAddProduct.LinkClicked
        ActiveControl = Nothing
        frmNewProduct.senderFrom = "new stock"
        frmNewProduct.ShowDialog()
        txtSerialNumber.Select()
    End Sub

    Private Sub btnSearchProduct_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnSearchProduct.LinkClicked
        ActiveControl = Nothing
        frmSearchProduct.ShowDialog()
    End Sub

    Private Sub txtSerialNumber_TextChanged(sender As Object, e As EventArgs) Handles txtSerialNumber.TextChanged
        'populateFields_FromStockDetails_bySerialNumber()
    End Sub

    Private Sub txtSerialNumber_Leave(sender As Object, e As EventArgs) Handles txtSerialNumber.Leave
        If Not txtSerialNumber.Text.Trim = "" Then
            txtMarkUp.Enabled = True
            dropSupplier.Enabled = True
            btnAddSupplier.Enabled = True
            txtQuantity.Enabled = True
        End If
    End Sub

    Private Sub txtSerialNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSerialNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMarkUp.Select()
        End If
        If e.KeyCode = Keys.Tab Then
            txtMarkUp.Select()
        End If
    End Sub

    Private Sub btnAddSupplier_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnAddSupplier.LinkClicked
        ActiveControl = Nothing
        frmNewSupplier.ShowDialog()
    End Sub

    Private Sub txtMarkUp_Enter(sender As Object, e As EventArgs) Handles txtMarkUp.Enter
        If txtMarkUp.Value = 0 Then
            txtMarkUp.ResetText()
        End If
    End Sub

    Private Sub btn_save_stock_Click(sender As Object, e As EventArgs) Handles btn_save_stock.Click
        Try
            If checkRequiredFillable() Then
                funcInventory = New inventoryFunction
                'Dim modelInventory As New inventoryModel(txtName.Text, txtBrand.Text, txtModel.Text, Convert.ToString(dropCategory.Text), Convert.ToString(dropUnit.Text), Convert.ToDecimal(txtPrice.Text))
                Dim modelInventory As New inventoryModel With {
                    .productid = Convert.ToInt64(txtID.Text),
                    .name = txtName.Text,
                    .serialnumber = txtSerialNumber.Text,
                    .atCost = Convert.ToDecimal(txtMarkUp.Value),
                    .quantity = Convert.ToInt64(txtQuantity.Value),
                    .onhand = Convert.ToInt64(txtQuantity.Value),
                    .supplier = dropSupplier.SelectedValue,
                    .suppliername = Convert.ToString(dropSupplier.Text),
                    .status = "Available"
                }

                If funcInventory.addNewStock(modelInventory) Then
                    If funcInventory.updateProductDetail_StockQuantity(modelInventory) Then
                        customMessageBox.show(Me, "Successfully added new stock.", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        clearToDefault(group_product_details)

                        txtMarkUp.Enabled = False
                        dropSupplier.Enabled = False
                        btnAddSupplier.Enabled = False
                        txtQuantity.Enabled = False

                        ActiveControl = txtItemCode
                        txtItemCode.Select()
                    Else
                        customMessageBox.show(Me, "Failed to add new stock. Please try again.", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    customMessageBox.show(Me, "Failed to add new stock. Please try again.", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                customMessageBox.show(Me, "Please fill up all the information.", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSerialNumber.Select()
            End If
        Catch ex As MySqlException
            If ex.Message.Contains("cannot be null") Then
                customMessageBox.show(Me, "Please fill up all the information.", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try
    End Sub

#End Region

End Class