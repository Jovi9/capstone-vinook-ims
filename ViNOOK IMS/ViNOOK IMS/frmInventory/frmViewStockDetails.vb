Public Class frmViewStockDetails

    Dim funcInventory As inventoryFunction
    Dim modelInventory As inventoryModel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Function requireFillable() As Boolean
        If txtDID.Text.Trim = "" Or dropSupplier.Text.Trim = "" Or txtMarkUp.Value = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub populateComboBox()
        funcInventory = New inventoryFunction
        funcInventory.loadSupplierComboBox(dropSupplier, "table")
    End Sub

    Private Sub populateFields()
        funcInventory = New inventoryFunction
        modelInventory = New inventoryModel With {
            .reference_id = txtReference.Text
        }
        funcInventory.getStockDetails_JoinProducts(modelInventory)

        'txtReference.Text = modelInventory.reference_id
        txtID.Text = modelInventory.productid
        txtDID.Text = modelInventory.detailid
        txtDateIn.Text = Format(modelInventory.datein, "yyyy-MMM-dd")
        txtProductCode.Text = modelInventory.itemcode
        txtname.Text = modelInventory.name
        txtBrand.Text = modelInventory.brand
        txtModel.Text = modelInventory.model
        txtCategory.Text = modelInventory.categoryname
        txtPrice.Text = modelInventory.price
        txtSerialNumber.Text = modelInventory.serialnumber
        txtTotalQuantity.Text = modelInventory.quantity
        txtOnHand.Text = modelInventory.onhand
        txtUnit.Text = modelInventory.unit
        dropSupplier.SelectedValue = modelInventory.supplier
        txtMarkUp.Value = modelInventory.atCost
        'If modelInventory.status = "Sold" Then
        '    dropSupplier.Enabled = False
        '    txtMarkUp.Enabled = False
        '    btn_update.Enabled = False
        'Else
        '    dropSupplier.Enabled = True
        '    txtMarkUp.Enabled = True
        '    btn_update.Enabled = True
        'End If

        trackStock_serialNumber = modelInventory.serialnumber
        trackStock_supplier = modelInventory.supplier
        trackStock_suppliername = modelInventory.suppliername
        trackStock_atCost = modelInventory.atCost
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ActiveControl = Nothing
        clearToDefault(Me)
        Close()
    End Sub

    Private Sub frmViewStockDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateComboBox()
        populateFields()
    End Sub

    Private Sub frmViewStockDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            btnClose.PerformClick()
        End If

        If e.KeyCode = Keys.F10 Then
            btn_update.PerformClick()
        End If

        'prevent alt+f4 exit
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    'Private Sub txtDID_TextChanged(sender As Object, e As EventArgs) Handles txtDID.TextChanged
    '    If Not txtDID.Text.Trim = "" Then
    '        populateFields()
    '    End If
    'End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If requireFillable() = True Then
            modelInventory = New inventoryModel
            With modelInventory
                .reference_id = txtReference.Text
                .detailid = Convert.ToInt64(txtDID.Text)
                .productid = Convert.ToInt64(txtID.Text)
                .name = txtBrand.Text & " " & txtModel.Text
                .serialnumber = txtSerialNumber.Text
                .supplier = Convert.ToInt64(dropSupplier.SelectedValue)
                .suppliername = Convert.ToString(dropSupplier.Text)
                .atCost = Convert.ToDecimal(txtMarkUp.Value)
            End With
            funcInventory = New inventoryFunction

            Dim currentDetails(1) As String
            currentDetails(0) = trackStock_suppliername
            currentDetails(1) = trackStock_atCost

            Dim newDetails(1) As String
            newDetails(0) = modelInventory.suppliername
            newDetails(1) = modelInventory.atCost

            If matchCurrent_NewDetails(currentDetails, newDetails) Then
                Exit Sub
            Else
                If funcInventory.updateStockDetail(modelInventory) Then
                    customMessageBox.show(Me, "Successfully updated product details.", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    populateFields()
                    frmInventoryAllItems.loadDataGrid()
                    frmInventoryAdvanceSearch.loadDataGrid()
                    Close()
                Else
                    customMessageBox.show(Me, "Failed to update product details. Please try again.", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    populateFields()
                    Close()
                End If
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtReference_TextChanged(sender As Object, e As EventArgs) Handles txtReference.TextChanged
        If Not txtReference.Text.Trim = "" Then
            populateFields()
        End If
    End Sub
End Class