Imports MySql.Data.MySqlClient

Public Class inventoryFunction : Inherits database
    Dim com As MySqlCommand
    Dim reader As MySqlDataReader

    'product
    Dim _productID As String
    Dim _itemCode As String
    Dim _name As String
    Dim _brand As String
    Dim _model As String
    Dim _category As String
    Dim _quantity As String
    Dim _unit As String
    Dim _price As String
    'details
    Dim _detailID As String
    Dim _serialNumber As String
    Dim _atCost As String
    Dim _supplier As String
    Dim _content As String

    Dim _newContent
    Dim new_itemCode As String
    Dim new_name As String
    Dim new_brand As String
    Dim new_model As String
    Dim new_category As String
    Dim new_unit As String
    Dim new_price As String
    Dim new_serialNumber As String
    Dim new_atCost As String
    Dim new_supplier As String

#Region "->combobox"
    'globe
    'Public Sub populateCombobox(ByVal colname As String, ByVal tblname As String, ByVal cbo As ComboBox)
    '    openConnection()
    '    Dim ex As String = $"select {colname} from {tblname} order by {colname}"
    '    com = New MySqlCommand(ex, connection)

    '    reader = com.ExecuteReader(CommandBehavior.CloseConnection)
    '    cbo.Items.Clear()
    '    cbo.Items.Add("ALL")
    '    Do While reader.Read = True
    '        cbo.Items.Add(reader(colname))
    '    Loop
    '    closeConnection()
    'End Sub
    Public Sub loadUnitsComboBox(cbo As ComboBox)
        Try
            openConnection()
            Dim que As String = "select units from units where not deleted"
            com = New MySqlCommand(que, connection)
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            cbo.Items.Clear()
            Do While reader.Read = True
                cbo.Items.Add(reader(0))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Sub loadStatusComboBox(cbo As ComboBox)
        Try
            openConnection()
            Dim que As String = "select distinct _status from products_detail order by _status"
            com = New MySqlCommand(que, connection)
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            cbo.Items.Clear()
            Do While reader.Read = True
                cbo.Items.Add(reader(0))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Sub loadSupplierComboBox(cbo As ComboBox, opt As String)
        Try
            openConnection()
            Dim que As String = "select supplier_id, _name from suppliers where not deleted order by _name"
            com = New MySqlCommand(que, connection)
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)

            If opt = "reader" Then
                cbo.Items.Clear()
                cbo.Items.Add("ALL")
                Do While reader.Read = True
                    cbo.Items.Add(reader(1))
                Loop
                cbo.SelectedIndex = 0
            ElseIf opt = "table" Then
                Dim dt As New DataTable
                dt.Load(reader)
                cbo.DataSource = dt
                cbo.DisplayMember = "_name"
                cbo.ValueMember = "supplier_id"
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Sub loadBrandComboBox(cbo As ComboBox)
        Try
            openConnection()
            Dim que As String = "select distinct brand from products order by brand"
            com = New MySqlCommand(que, connection)
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            cbo.Items.Clear()
            cbo.Items.Add("ALL")
            Do While reader.Read = True
                cbo.Items.Add(reader(0))
            Loop
            cbo.SelectedIndex = 0
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Sub loadModelComboBox(cbo As ComboBox, brand As String)
        Try
            If brand = "ALL" Then
                brand = ""
            End If
            openConnection()
            Dim que As String = "select distinct model from products where brand=@brand order by model"
            com = New MySqlCommand(que, connection)
            com.Parameters.Add("@brand", MySqlDbType.VarChar).Value = brand
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            cbo.Items.Clear()
            cbo.Items.Add("ALL")
            Do While reader.Read = True
                cbo.Items.Add(reader(0))
            Loop
            cbo.SelectedIndex = 0
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Sub loadCategoryComboBox(cbo As ComboBox, opt As String)
        Try
            openConnection()
            Dim que As String = "select category_id, category from categories where not deleted order by category"
            com = New MySqlCommand(que, connection)
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)

            If opt = "reader" Then
                cbo.Items.Clear()
                cbo.Items.Add("ALL")
                Do While reader.Read = True
                    cbo.Items.Add(reader(1))
                Loop
                cbo.SelectedIndex = 0
            ElseIf opt = "table" Then
                Dim dt As New DataTable
                dt.Load(reader)
                cbo.DataSource = dt
                cbo.DisplayMember = "category"
                cbo.ValueMember = "category_id"
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub

    Public Function getInitialDateIn() As Date
        Using connection()
            openConnection()
            Using com As New MySqlCommand
                com.Connection = connection()
                com.CommandText = "select date_in
                                    from products_detail 
                                    order by date_in
                                    limit 1;"
                Dim lowestDate As Date
                Using reader As MySqlDataReader = com.ExecuteReader(CommandBehavior.CloseConnection)
                    If reader.Read = True Then
                        lowestDate = reader(0)
                    End If
                End Using
                Return lowestDate
            End Using
            closeConnection()
        End Using
    End Function
#End Region

#Region "->save to database"
#Region "->save product"
    'not included to history
    Public Function updateStockDetails_Status() As Boolean
        Try
            openConnection()
            Dim que As String = "update products_detail set _status=@status where on_hand=0"
            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@status", MySqlDbType.VarChar).Value = "Sold"
            End With
            If com.ExecuteNonQuery = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            closeConnection()
        End Try
    End Function

    Public Sub updateAllProducts_QuantityInStock()
        Try
            openConnection()
            Dim que As String = "update products set quantity=(select sum(quantity) from products_detail where product_id=products.product_id and not deleted), on_hand=(select sum(on_hand) from products_detail where product_id=products.product_id and not deleted)"
            com = New MySqlCommand(que, connection)
            com.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub

    Public Function updateProductDetail_StockQuantity(inventory As inventoryModel) As Boolean
        Try
            openConnection()

            Dim que As String = "update products set quantity=(select sum(quantity) from products_detail where product_id=@id and not deleted), on_hand=(select sum(on_hand) from products_detail where product_id=@id and not deleted) " &
                        "where product_id=@id"
            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@id", MySqlDbType.Int64).Value = inventory.productid
            End With
            If com.ExecuteNonQuery = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            closeConnection()
        End Try
    End Function

    'inlucde to history
    Public Function updateProductDetail(inventory As inventoryModel) As Boolean
        Try
            openConnection()
            inventory.updated_at = Date.Now
            Dim que As String = "update products set item_code=@code, _name=@name, brand=@brand, model=@model, category_id=@category, unit=@unit, price=@price, updated_at=@updated where product_id=@id"
            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@id", MySqlDbType.Int64).Value = inventory.productid
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = inventory.itemcode
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = inventory.name
                .Parameters.Add("@brand", MySqlDbType.VarChar).Value = inventory.brand
                .Parameters.Add("@model", MySqlDbType.VarChar).Value = inventory.model
                .Parameters.Add("@category", MySqlDbType.Int64).Value = inventory.category
                .Parameters.Add("@unit", MySqlDbType.VarChar).Value = inventory.unit
                .Parameters.Add("@price", MySqlDbType.Decimal).Value = inventory.price
                .Parameters.Add("@updated", MySqlDbType.DateTime).Value = inventory.updated_at
            End With

            If String.Equals(trackProduct_itemCode, inventory.itemcode) Then
                _itemCode = "Product Code: " & trackProduct_itemCode & Environment.NewLine
            Else
                _itemCode = "Product Code: " & trackProduct_itemCode & Environment.NewLine
                new_itemCode = "Product Code: " & inventory.itemcode & Environment.NewLine
            End If

            If String.Equals(trackProduct_name, inventory.name) Then
                _name = "Product Name: " & trackProduct_name & Environment.NewLine
            Else
                _name = "Product Name: " & trackProduct_name & Environment.NewLine
                new_name = "Product Name: " & inventory.name & Environment.NewLine
            End If

            If String.Equals(trackProduct_brand, inventory.brand) Then
                _brand = ""
            Else
                _brand = "Brand: " & trackProduct_brand & Environment.NewLine
                new_brand = "Brand: " & inventory.brand & Environment.NewLine
            End If

            If String.Equals(trackProduct_model, inventory.model) Then
                _model = ""
            Else
                _model = "Model: " & trackProduct_model & Environment.NewLine
                new_model = "Model: " & inventory.model & Environment.NewLine
            End If

            If String.Equals(trackProduct_category, inventory.categoryname) Then
                _category = ""
            Else
                _category = "Category: " & trackProduct_category & Environment.NewLine
                new_category = "Category: " & inventory.categoryname & Environment.NewLine
            End If

            If String.Equals(trackProduct_unit, inventory.unit) Then
                _unit = ""
            Else
                _unit = "Unit: " & trackProduct_unit & Environment.NewLine
                new_unit = "Unit: " & inventory.unit & Environment.NewLine
            End If

            If String.Equals(Convert.ToString(trackProduct_price), Convert.ToString(inventory.price)) Then
                _price = ""
            Else
                _price = "Price: " & Format(trackProduct_price, "n")
                new_price = "Price: " & Format(inventory.price, "n")
            End If

            _productID = "Product ID: " & inventory.productid & Environment.NewLine

            _content = _itemCode & _name & _brand & _model & _category & _unit & _price
            _newContent = new_itemCode & new_name & new_brand & new_model & new_category & new_unit & new_price

            Dim modelHistory As New historyModel(session_username, "UPDATE", "PRODUCT", _content, _newContent, inventory.updated_at)
            Dim funcHistory As New historyFunction

            If com.ExecuteNonQuery = 1 Then
                funcHistory.addToHistory(modelHistory)
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            closeConnection()
        End Try
    End Function

    Public Function addNewProduct(inventory As inventoryModel) As Boolean
        Try
            openConnection()

            inventory.created_at = Date.Now
            Dim que As String = "insert into products (item_code, _name, brand, model, category_id, unit, price, created_at, updated_at) " &
                            "values(@code, @name, @brand, @model, @category, @unit, @price, @created, @updated)"
            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = inventory.itemcode
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = inventory.name
                .Parameters.Add("@brand", MySqlDbType.VarChar).Value = inventory.brand
                .Parameters.Add("@model", MySqlDbType.VarChar).Value = inventory.model
                .Parameters.Add("@category", MySqlDbType.Int64).Value = inventory.category
                .Parameters.Add("@unit", MySqlDbType.VarChar).Value = inventory.unit
                .Parameters.Add("@price", MySqlDbType.Decimal).Value = inventory.price
                .Parameters.Add("@created", MySqlDbType.DateTime).Value = inventory.created_at
                .Parameters.Add("@updated", MySqlDbType.DateTime).Value = inventory.created_at
            End With

            _itemCode = "Product Code: " & inventory.itemcode & Environment.NewLine
            _name = "Product Name: " & inventory.name & Environment.NewLine
            _brand = "Brand: " & inventory.brand & Environment.NewLine
            _model = "Model: " & inventory.model & Environment.NewLine
            _category = "Category: " & inventory.categoryname & Environment.NewLine
            _unit = "Unit: " & inventory.unit & Environment.NewLine
            _price = "Price: " & Format(inventory.price, "n")

            _content = _itemCode & _name & _brand & _model & _category & _unit & _price
            Dim modelHistory As New historyModel(session_username, "CREATE", "PRODUCT", _content, inventory.created_at)
            Dim funcHistory As New historyFunction

            If com.ExecuteNonQuery = 1 Then
                funcHistory.addToHistory(modelHistory)
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            closeConnection()
        End Try
    End Function
#End Region
#Region "->save stock"
    Public Function updateStockDetail(inventory As inventoryModel) As Boolean
        Try
            openConnection()
            inventory.updated_at = Date.Now

            Dim que As String = "update products_detail set serial_number=@serial, at_cost=@cost, supplier_id=@supplier, updated_at=@updated where reference=@id;"
            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@id", MySqlDbType.VarChar).Value = inventory.reference_id
                .Parameters.Add("@serial", MySqlDbType.VarChar).Value = inventory.serialnumber
                .Parameters.Add("@cost", MySqlDbType.Decimal).Value = inventory.atCost
                .Parameters.Add("@supplier", MySqlDbType.VarChar).Value = inventory.supplier
                .Parameters.Add("@updated", MySqlDbType.DateTime).Value = inventory.updated_at
            End With

            If String.Equals(trackStock_serialNumber, inventory.serialnumber) Then
                _serialNumber = "Serial Number: " & inventory.serialnumber & Environment.NewLine
            Else
                _serialNumber = "Serial Number: " & trackStock_serialNumber & Environment.NewLine
                new_serialNumber = "Serial Number: " & inventory.serialnumber & Environment.NewLine
            End If
            If trackStock_atCost <> inventory.atCost Then
                _atCost = "At Cost: " & Format(trackStock_atCost, "n") & Environment.NewLine
                new_atCost = "At Cost: " & Format(inventory.atCost, "n") & Environment.NewLine
            Else
                _atCost = ""
            End If
            If String.Equals(trackStock_suppliername, inventory.suppliername) Then
                _supplier = "Supplier: " & trackStock_suppliername
            Else
                _supplier = "Supplier: " & trackStock_suppliername
                new_supplier = "Supplier: " & inventory.suppliername
            End If

            _detailID = "Product Detail ID: " & inventory.detailid & Environment.NewLine
            _name = "Product Name: " & inventory.name & Environment.NewLine

            _content = _name & _serialNumber & _atCost & _supplier
            _newContent = new_serialNumber & new_atCost & new_supplier

            com.ExecuteNonQuery()

            Dim modelHistory As New historyModel(session_username, "UPDATE", "STOCK", _content, _newContent, inventory.updated_at)
            Dim funcHistory As New historyFunction
            funcHistory.addToHistory(modelHistory)

            Return True
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            closeConnection()
        End Try
    End Function

    Public Function addNewStock(inventory As inventoryModel) As Boolean
        Try
            openConnection()

            inventory.created_at = Date.Now
            Dim que As String = "insert into products_detail (product_id, serial_number, at_cost, date_in, supplier_id, _status, reference, created_at, updated_at) " &
                                "values(@id, @serial, @cost, @datein, @supplier, @status, @reference, @created, @updated)"
            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@id", MySqlDbType.Int64).Value = inventory.productid
                .Parameters.Add("@serial", MySqlDbType.VarChar).Value = inventory.serialnumber
                .Parameters.Add("@cost", MySqlDbType.Decimal).Value = inventory.atCost
                '.Parameters.Add("@quantity", MySqlDbType.Int64).Value = inventory.quantity
                '.Parameters.Add("@onhand", MySqlDbType.Int64).Value = inventory.onhand
                .Parameters.Add("@datein", MySqlDbType.DateTime).Value = inventory.created_at
                .Parameters.Add("@supplier", MySqlDbType.VarChar).Value = inventory.supplier
                .Parameters.Add("@status", MySqlDbType.VarChar).Value = inventory.status
                .Parameters.Add("@reference", MySqlDbType.VarChar).Value = Format(Date.Now, "yyyyMMddHHmmss")
                .Parameters.Add("@created", MySqlDbType.DateTime).Value = inventory.created_at
                .Parameters.Add("@updated", MySqlDbType.DateTime).Value = inventory.created_at
            End With

            _productID = "Product ID: " & inventory.productid & Environment.NewLine
            _name = "Product Name: " & inventory.name & Environment.NewLine
            _serialNumber = "Serial Number: " & inventory.serialnumber & Environment.NewLine
            _atCost = "At Cost: " & Format(inventory.atCost, "n") & Environment.NewLine
            _quantity = "Quantity: " & inventory.quantity & Environment.NewLine
            _supplier = "Supplier: " & inventory.suppliername

            _content = _productID & _name & _serialNumber & _atCost & _quantity & _supplier
            Dim modelHistory As New historyModel(session_username, "ADD", "STOCK", _content, inventory.created_at)
            Dim funcHistory As New historyFunction

            Do While inventory.quantity >= 1
                com.ExecuteNonQuery()
                inventory.quantity -= 1
            Loop

            funcHistory.addToHistory(modelHistory)
            Return True
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            closeConnection()
        End Try
    End Function
#End Region
#End Region

#Region "->Products"
    Public Sub getProductDetails(inventory As inventoryModel, opt As String)
        Try
            openConnection()
            Dim que As String = ""
            If opt = "id" Then
                que = "select products.product_id, products.item_code, products._name, products.brand, products.model, categories.category_id, categories.category, products.quantity, products.on_hand, products.unit, products.price " &
                        "from products inner join categories on products.category_id=categories.category_id " &
                        "where product_id=@id"
            ElseIf opt = "itemcode" Then
                que = "select products.product_id, products.item_code, products._name, products.brand, products.model, categories.category_id, categories.category, products.quantity, products.on_hand, products.unit, products.price " &
                        "from products inner join categories on products.category_id=categories.category_id " &
                        "where item_code=@code"
            End If
            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@id", MySqlDbType.Int64).Value = inventory.productid
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = inventory.itemcode
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                inventory.productid = reader("product_id")
                inventory.itemcode = reader("item_code")
                inventory.name = reader("_name")
                inventory.brand = reader("brand")
                inventory.model = reader("model")
                inventory.category = reader("category_id")
                inventory.categoryname = reader("category")
                inventory.quantity = reader("quantity")
                inventory.onhand = reader("on_hand")
                inventory.unit = reader("unit")
                inventory.price = reader("price")
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Sub populateSearchProductsDataGrid(dgv As DataGridView, search As String, category As String)
        Try
            openConnection()
            Dim que As String = ""
            If category = "ALL" Then
                que = "select products.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products.on_hand, products.unit, products.price " &
                        "from products inner join categories on products.category_id=categories.category_id " &
                        "where (item_code like @code or _name like @name or concat(brand, ' ', model) like @bmodel)
                            and not products.deleted
                            order by category, brand, _name"
            Else
                que = "select products.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products.on_hand, products.unit, products.price " &
                        "from products inner join categories on products.category_id=categories.category_id " &
                        "where (item_code like @code or _name like @name or concat(brand, ' ', model) like @bmodel) and category=@category
                            and not products.deleted
                            order by category, brand, _name"
            End If
            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@bmodel", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@category", MySqlDbType.VarChar).Value = category
            End With

            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()

            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Function checkIfProductExist(productId As Long) As Boolean
        Try
            openConnection()
            Dim que As String = "select product_id from products_detail where product_id=@id"
            com = New MySqlCommand(que, connection)
            com.Parameters.Add("@id", MySqlDbType.Int64).Value = productId
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            closeConnection()
        End Try
    End Function

    Public Sub getProductsDetails_NewStock(inventory As inventoryModel)
        Try
            openConnection()
            Dim que As String = "select products.product_id, products.item_code, products._name, products.brand, products.model, categories.category_id, categories.category, products.quantity, products.on_hand, products.unit, products.price " &
                        "from products inner join categories on products.category_id=categories.category_id " &
                        "where item_code=@code and not products.deleted"
            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@id", MySqlDbType.Int64).Value = inventory.productid
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = inventory.itemcode
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                inventory.productid = reader("product_id")
                inventory.itemcode = reader("item_code")
                inventory.name = reader("_name")
                inventory.brand = reader("brand")
                inventory.model = reader("model")
                inventory.category = reader("category_id")
                inventory.categoryname = reader("category")
                inventory.quantity = reader("quantity")
                inventory.onhand = reader("on_hand")
                inventory.unit = reader("unit")
                inventory.price = reader("price")
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub
#End Region

#Region "->Inventory"
    Public Sub getStockDetails_JoinProducts(inventory As inventoryModel)
        Try
            openConnection()
            Dim que As String = "select products_detail.detail_id, products_detail.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products.price, products_detail.serial_number, sum(products_detail.quantity) as quantity, sum(products_detail.on_hand) as on_hand, products.unit, suppliers.supplier_id, suppliers._name as supplierName, products_detail.at_cost,  products_detail.date_in, products_detail._status, reference
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner join categories on products.category_id=categories.category_id 
                      inner join suppliers on products_detail.supplier_id=suppliers.supplier_id
                      where reference=@id
                      group by reference;"

            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@id", MySqlDbType.VarChar).Value = inventory.reference_id
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)

            If reader.Read = True Then
                inventory.detailid = reader("detail_id")
                inventory.productid = reader("product_id")
                inventory.itemcode = reader("item_code")
                inventory.name = reader("_name")
                inventory.brand = reader("brand")
                inventory.model = reader("model")
                inventory.categoryname = reader("category")
                inventory.price = reader("price")
                inventory.serialnumber = reader("serial_number")
                inventory.quantity = reader("quantity")
                inventory.onhand = reader("on_hand")
                inventory.unit = reader("unit")
                inventory.supplier = reader("supplier_id")
                inventory.suppliername = reader("supplierName")
                inventory.atCost = reader("at_cost")
                inventory.datein = reader("date_in")
                inventory.status = reader("_status")
                inventory.reference_id = reader("reference")
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Sub getStockDetails(inventory As inventoryModel, opt As String)
        Try
            openConnection()
            Dim que As String = ""
            If opt = "detail_id" Then
                que = "select products_detail.detail_id, products_detail.product_id, products_detail.serial_number, products_detail.at_cost, suppliers.supplier_id, suppliers._name " &
                        "From products_detail inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id " &
                        "where detail_id=@id and not products_detail._status=@status and (not products_detail.deleted) order by products_detail.date_in desc"
            ElseIf opt = "serial" Then
                que = "select products_detail.detail_id, products_detail.product_id, products_detail.serial_number, products_detail.at_cost, suppliers.supplier_id, suppliers._name " &
                        "From products_detail inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id " &
                        "where serial_number=@serial and not products_detail._status=@status and (not products_detail.deleted) order by products_detail.date_in desc"
            ElseIf opt = "product_id" Then
                que = "select products_detail.detail_id, products_detail.product_id, products_detail.serial_number, products_detail.at_cost, suppliers.supplier_id, suppliers._name " &
                        "From products_detail inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id " &
                        "where product_id=@pid and not products_detail._status=@status and (not products_detail.deleted) order by products_detail.date_in desc"
            End If
            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@id", MySqlDbType.VarChar).Value = inventory.detailid
                .Parameters.Add("@pid", MySqlDbType.VarChar).Value = inventory.productid
                .Parameters.Add("@serial", MySqlDbType.VarChar).Value = inventory.serialnumber
                .Parameters.Add("@status", MySqlDbType.VarChar).Value = "Sold"
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)

            If reader.Read = True Then
                inventory.detailid = reader("detail_id")
                inventory.productid = reader("product_id")
                inventory.serialnumber = reader("serial_number")
                inventory.atCost = reader("at_cost")
                inventory.supplier = reader("supplier_id")
                inventory.suppliername = reader("_name")
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Sub populateDGVInventory(dgv As DataGridView, search As String, category As String)
        Try
            openConnection()
            Dim que As String = ""

            If category = "ALL" Then
                que = "select products.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products.on_hand, products.unit, products.price
                        From products inner Join categories On products.category_id=categories.category_id
                        Where (item_code Like @code or _name like @name or concat(brand, ' ', model) like @bmodel)
                        and not products.deleted
                        Order By category, brand, model, _name"
            Else
                que = "Select products.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products.on_hand, products.unit, products.price
                        from products inner join categories On products.category_id=categories.category_id
                        where(item_code Like @code Or _name Like @name Or concat(brand, ' ', model) like @bmodel) and category=@category
                        and not products.deleted
                        order by category, brand, model, _name"
            End If

            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@bmodel", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@category", MySqlDbType.VarChar).Value = category
            End With

            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()

            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Sub populateInventoryAllItems(dgv As DataGridView, search As String, category As String, supplier As String, startDate As Date)
        Try
            openConnection()
            Dim que As String = ""
            If category = "ALL" And supplier = "ALL" Then
                que = "select products_detail.detail_id, products_detail.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) as TotalOnHand, products_detail.at_cost, suppliers._name, products_detail.date_in, reference
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where (item_code Like @code Or products._name Like @name Or concat(brand, ' ', model) like @bmodel or serial_number like @serial) 
                    and DATE(date_in)=@startDate
                    and (not products.deleted and not products_detail.deleted) 
                    and not _status=@status
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            ElseIf category = "ALL" And Not supplier = "ALL" Then
                que = "Select products_detail.detail_id, products_detail.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) As TotalOnHand, products_detail.at_cost, suppliers._name, products_detail.date_in, reference 
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where (item_code Like @code Or products._name Like @name Or concat(brand, ' ', model) like @bmodel or serial_number like @serial) 
                    and DATE(date_in)=@startDate
                    and suppliers._name=@supplier 
                    and (not products.deleted and not products_detail.deleted)
                    and not _status=@status
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            ElseIf Not category = "ALL" And supplier = "ALL" Then
                que = "Select products_detail.detail_id, products_detail.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) As TotalOnHand, products_detail.at_cost, suppliers._name, products_detail.date_in, reference 
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where (item_code Like @code Or products._name Like @name Or concat(brand, ' ', model) like @bmodel or serial_number like @serial)
                    and DATE(date_in)=@startDate
                      and category=@category 
                      and (not products.deleted and not products_detail.deleted)
                    and not _status=@status
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            Else
                que = "Select products_detail.detail_id, products_detail.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) As TotalOnHand, products_detail.at_cost, suppliers._name, products_detail.date_in, reference 
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where (item_code Like @code Or products._name Like @name Or concat(brand, ' ', model) like @bmodel or serial_number like @serial) 
                    and DATE(date_in)=@startDate
                    and category=@category and suppliers._name=@supplier
                    and (not products.deleted and not products_detail.deleted)
                    and not _status=@status 
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            End If

            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@bmodel", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@serial", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@category", MySqlDbType.VarChar).Value = category
                .Parameters.Add("@supplier", MySqlDbType.VarChar).Value = supplier
                .Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate
                .Parameters.Add("@status", MySqlDbType.VarChar).Value = "Sold"
            End With

            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()

            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10), reader(11), reader(12))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Sub populateInventoryAllItems(dgv As DataGridView, search As String, category As String, supplier As String, startDate As Date, endDate As Date)
        Try
            openConnection()
            Dim que As String = ""
            If category = "ALL" And supplier = "ALL" Then
                que = "select products_detail.detail_id, products_detail.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) as TotalOnHand, products_detail.at_cost, suppliers._name, products_detail.date_in, reference
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where (item_code Like @code Or products._name Like @name Or concat(brand, ' ', model) like @bmodel or serial_number like @serial) 
                    and (not products.deleted and not products_detail.deleted)
                    and not _status=@status 
                      and DATE(date_in) between @startDate and @endDate
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            ElseIf category = "ALL" And Not supplier = "ALL" Then
                que = "Select products_detail.detail_id, products_detail.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) As TotalOnHand, products_detail.at_cost, suppliers._name, products_detail.date_in, reference 
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where (item_code Like @code Or products._name Like @name Or concat(brand, ' ', model) like @bmodel or serial_number like @serial) 
                    and suppliers._name=@supplier 
                    and (not products.deleted and not products_detail.deleted)
                    and not _status=@status
                      and DATE(date_in) between @startDate and @endDate
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            ElseIf Not category = "ALL" And supplier = "ALL" Then
                que = "Select products_detail.detail_id, products_detail.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) As TotalOnHand, products_detail.at_cost, suppliers._name, products_detail.date_in, reference 
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where (item_code Like @code Or products._name Like @name Or concat(brand, ' ', model) like @bmodel or serial_number like @serial)
                      and category=@category 
                    and (not products.deleted and not products_detail.deleted)
                    and not _status=@status
                      and DATE(date_in) between @startDate and @endDate
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            Else
                que = "Select products_detail.detail_id, products_detail.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) As TotalOnHand, products_detail.at_cost, suppliers._name, products_detail.date_in, reference 
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where (item_code Like @code Or products._name Like @name Or concat(brand, ' ', model) like @bmodel or serial_number like @serial) 
                    and category=@category and suppliers._name=@supplier
                    and (not products.deleted and not products_detail.deleted)
                    and not _status=@status 
                      and DATE(date_in) between @startDate and @endDate
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            End If

            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@bmodel", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@serial", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@category", MySqlDbType.VarChar).Value = category
                .Parameters.Add("@supplier", MySqlDbType.VarChar).Value = supplier
                .Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate
                .Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate
                .Parameters.Add("@status", MySqlDbType.VarChar).Value = "Sold"
            End With

            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()

            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10), reader(11), reader(12))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Sub advanceSearchInventory(dgv As DataGridView, search As String)
        Try
            openConnection()
            Dim que As String = "select reference, products_detail.detail_id, products_detail.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products_detail.serial_number, suppliers._name, date_in, sum(products_detail.on_hand) as on_hand
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where (item_code Like @code Or products._name Like @name or serial_number like @serial) 
                      and (not products.deleted and not products_detail.deleted)
                      and not _status=@status 
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"

            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@serial", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@status", MySqlDbType.VarChar).Value = "Sold"
            End With

            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()

            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10), reader(11))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

#End Region

#Region "->Low Stock"
    Public Function getLowStockCount() As Long
        Dim stockCount As Long
        Try
            openConnection()
            Dim que As String = "select count(on_hand) as TotalAvailable
                                from products
                                where on_hand < 5 and not deleted;"
            com = New MySqlCommand(que, connection)
            stockCount = com.ExecuteScalar
            Return stockCount
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Stock Count Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return stockCount = 0
        Finally
            closeConnection()
        End Try
    End Function

    Public Sub loadLowStockDataGrid(dgv As DataGridView, search As String)
        Try
            openConnection()
            Dim que As String = "select _name, brand, model, categories.category, on_hand, unit
                                from products
                                inner join categories on products.category_id=categories.category_id
                                where on_hand < 5
                                and (_name like @name or concat(brand, ' ', model) like @bmodel)
                                and not products.deleted
                                order by on_hand, _name;"

            com = New MySqlCommand(que, connection)
            With com
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@bmodel", MySqlDbType.VarChar).Value = "%" & search & "%"
            End With

            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()

            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub
#End Region

End Class