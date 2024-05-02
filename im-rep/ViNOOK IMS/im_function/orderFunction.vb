Imports MySql.Data.MySqlClient

Public Class orderFunction : Inherits database
    Dim com As MySqlCommand
    Dim reader As MySqlDataReader

    Private _transactionCode As String
    Private _invoice As String
    Private _orderDate As String
    Private _customerID As String
    Private _totalAmountDue As String
    Private _balance As String
    Private _received_amount As String
    Private _change As String
    Private _paymentType As String
    Private _cheque_no As String
    Private _payStatus As String

    Private _content As String

#Region "->Save Order Flow"
    'start point saving order
    Public Function getQuantityRemainder(detailID As Long, quantity As Long) As Long
        Dim remainder As Long = 0
        Try
            openConnection()
            Dim que As String = "select (on_hand - @qty) as qtyRemainder from products_detail " &
                                "where detail_id=@id"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@id", MySqlDbType.Int64).Value = detailID
                .Parameters.Add("@qty", MySqlDbType.Int64).Value = quantity
            End With
            remainder = com.ExecuteScalar
            Return remainder
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return remainder = 0
        Finally
            closeConnection()
        End Try
    End Function

    Public Function getSerialNumberRowCount(serialNumber As String) As Long
        Dim rowCount As Long = 0
        Try
            openConnection()
            Dim que As String = "select count(serial_number) from products_detail where serial_number=@serial and not _status=@status"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@serial", MySqlDbType.VarChar).Value = serialNumber
                .Parameters.Add("@status", MySqlDbType.VarChar).Value = "Sold"
            End With
            rowCount = com.ExecuteScalar
            Return rowCount
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return rowCount
        Finally
            closeConnection()
        End Try
    End Function

    Public Function updateProductsDetail_Quantity(detailID As Long, quantity As Long, reference As String) As Boolean
        Try
            openConnection()

            Dim que As String = "update products_detail set on_hand=on_hand - @qty, sold_to=@transacode " &
                            "where detail_id=@id"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@id", MySqlDbType.Int64).Value = detailID
                .Parameters.Add("@transacode", MySqlDbType.VarChar).Value = reference
                .Parameters.Add("@qty", MySqlDbType.Int64).Value = quantity
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

    Public Sub repopulateStockDetails_bySerialNumber(order As orderModel, serialnumber As String)
        Try
            openConnection()
            Dim que As String = "select products_detail.detail_id, products_detail.product_id, products._name, products.brand, products.model, categories.category as category, products.on_hand as totalOnHand, products_detail.serial_number, products.price, products_detail.on_hand, products_detail.date_in, products_detail._status " &
                "from products inner join products_detail on products.product_id=products_detail.product_id " &
                "inner join categories on products.category_id=categories.category_id " &
                "where serial_number=@serial and not products_detail._status=@status and (not products.deleted and not products_detail.deleted) " &
                "order by date_in"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@serial", MySqlDbType.VarChar).Value = serialnumber
                .Parameters.Add("@status", MySqlDbType.VarChar).Value = "Sold"
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                order.productdetailid = reader("detail_id")
                order.productid = reader("product_id")
                order.productname = reader("_name")
                order.productbrand = reader("brand")
                order.productmodel = reader("model")
                order.productcategory = reader("category")
                order.serialnumber = reader("serial_number")
                order.price = reader("price")
                order.quantity = reader("on_hand")
                order.totalonhand = reader("totalOnHand")
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Function updateProducts_QuantityOnHand(productID As Long) As Boolean
        Try
            openConnection()
            Dim que As String = "update products set quantity=(select sum(quantity) from products_detail where product_id=@id and not deleted), on_hand=(select sum(on_hand) from products_detail where product_id=@id and not deleted) " &
                            "where product_id=@id"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@id", MySqlDbType.Int64).Value = productID
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
    'end point of save order
#End Region

#Region "->save to database"
    Public Function insertOrderDetails(order As orderModel) As Boolean
        Try
            openConnection()

            order.created_at = Date.Now
            Dim que As String = "insert into orders_detail (transaction_code, serial_number, _name, brand, model, category, supplier, quantity, unit, price, total, warranty_start, warranty_end, product_id, created_at, updated_at) " &
                            "values (@code, @serial, @name, @brand, @model, @category, @supplier, @quantity, @unit, @price, @total, @warrantyStart, @warrantyEnd, @product_id, @created, @updated)"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@code", MySqlDbType.Int64).Value = order.transactionCode
                .Parameters.Add("@serial", MySqlDbType.VarChar).Value = order.serialnumber
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = order.productname
                .Parameters.Add("@brand", MySqlDbType.VarChar).Value = order.productbrand
                .Parameters.Add("@model", MySqlDbType.VarChar).Value = order.productmodel
                .Parameters.Add("@category", MySqlDbType.VarChar).Value = order.productcategory
                .Parameters.Add("@supplier", MySqlDbType.VarChar).Value = order.suppliername
                .Parameters.Add("@quantity", MySqlDbType.Int64).Value = order.quantity
                .Parameters.Add("@unit", MySqlDbType.VarChar).Value = order.unit
                .Parameters.Add("@price", MySqlDbType.Decimal).Value = order.price
                .Parameters.Add("@total", MySqlDbType.Decimal).Value = order.total
                .Parameters.Add("@warrantyStart", MySqlDbType.Date).Value = order.warrantystart
                .Parameters.Add("@warrantyEnd", MySqlDbType.Date).Value = order.warrantyend
                .Parameters.Add("@product_id", MySqlDbType.Int64).Value = order.productid
                .Parameters.Add("@created", MySqlDbType.DateTime).Value = order.created_at
                .Parameters.Add("@updated", MySqlDbType.DateTime).Value = order.created_at
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

    Public Function saveNewOrder(order As ordersModel) As Boolean
        Try
            openConnection()

            order.created_at = Date.Now
            Dim que As String = "insert into orders (transaction_code, invoice_no, order_date, customer, total_amount, balance, received_amount, _change, payment_type, cheque_no, pay_status, created_at, updated_at) " &
                                             "values (@code, @invoice, @orderDate, @customer, @total, @balance, @received, @change, @payment_type, @cheque_no, @paystatus, @created, @updated)"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@code", MySqlDbType.Int64).Value = order.transactioncode
                .Parameters.Add("@invoice", MySqlDbType.Int64).Value = order.invoice
                .Parameters.Add("@orderDate", MySqlDbType.DateTime).Value = order.created_at 'order_date
                .Parameters.Add("@customer", MySqlDbType.Int64).Value = order.customerid
                .Parameters.Add("@total", MySqlDbType.Decimal).Value = order.totalamountdue
                .Parameters.Add("@balance", MySqlDbType.Decimal).Value = order.balance
                .Parameters.Add("@received", MySqlDbType.Decimal).Value = order.received_amount
                .Parameters.Add("@change", MySqlDbType.Decimal).Value = order.change
                .Parameters.Add("@payment_type", MySqlDbType.VarChar).Value = order.paymenttype
                .Parameters.Add("@cheque_no", MySqlDbType.VarChar).Value = order.cheque_no
                .Parameters.Add("@paystatus", MySqlDbType.VarChar).Value = order.paystatus
                .Parameters.Add("@created", MySqlDbType.DateTime).Value = order.created_at
                .Parameters.Add("@updated", MySqlDbType.DateTime).Value = order.created_at
            End With

            _transactionCode = "Transaction Code: " & order.transactioncode & Environment.NewLine
            _invoice = "Invoice Number: " & order.invoice & Environment.NewLine
            _customerID = "Customer: " & order.customername & Environment.NewLine
            _totalAmountDue = "Total Amount: " & order.totalamountdue & Environment.NewLine
            _received_amount = "Received Amount: " & order.received_amount & Environment.NewLine
            _paymentType = "Payment Type: " & order.paymenttype & Environment.NewLine
            If order.cheque_no = "" Then
                _cheque_no = ""
            Else
                _cheque_no = "Cheque Number: " & order.cheque_no
            End If

            _content = _transactionCode & _invoice & _customerID & _totalAmountDue & _received_amount & _paymentType & _cheque_no
            Dim modelHistory As New historyModel(session_username, "CREATE", "ORDER", _content, order.created_at)
            Dim funchistory As New historyFunction

            If com.ExecuteNonQuery = 1 Then
                funchistory.addToHistory(modelHistory)
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

    Public Sub getCustomerDetails(customer As customerModel)
        Try
            openConnection()
            Dim que As String = "select customer_id, _name, address, phone, tinID " &
                            "from customers " &
                            "where _name=@name and not deleted"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = customer.name
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                customer.id = reader(0)
                customer.name = reader(1)
                customer.address = reader(2)
                customer.phone = reader(3).ToString
                customer.tin_id = reader(4).ToString
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    'call from new order form
    Public Sub getProductDetails(order As orderModel)
        Try
            openConnection()
            Dim que As String = "select products_detail.detail_id, products_detail.product_id, products._name, products.brand, products.model, categories.category as category, products.on_hand as totalOnHand, products_detail.serial_number, products.price, products_detail.on_hand, products_detail.date_in, products_detail._status, suppliers._name as supplierName, products.unit " &
                "from products inner join products_detail on products.product_id=products_detail.product_id " &
                "inner join categories on products.category_id=categories.category_id " &
                "inner join suppliers on products_detail.supplier_id=suppliers.supplier_id " &
                "where serial_number=@serial and not products_detail._status=@status and (not products.deleted and not products_detail.deleted) " &
                "order by date_in"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@serial", MySqlDbType.VarChar).Value = order.serialnumber
                .Parameters.Add("@status", MySqlDbType.VarChar).Value = "Sold"
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                order.productdetailid = reader("detail_id")
                order.productid = reader("product_id")
                order.productname = reader("_name")
                order.productbrand = reader("brand")
                order.productmodel = reader("model")
                order.productcategory = reader("category")
                order.serialnumber = reader("serial_number")
                order.price = reader("price")
                order.quantity = reader("on_hand")
                order.totalonhand = reader("totalOnHand")
                order.suppliername = reader("supplierName")
                order.unit = reader("unit")
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub

    Public Sub getOrderDetails(order As ordersModel)
        Try
            openConnection()
            Dim que As String = "select orders.transaction_code, orders.invoice_no, orders.order_date, customers._name, customers.address, orders.total_amount, orders.payment_type, orders.cheque_no " &
                      "from orders inner join customers on orders.customer=customers.customer_id " &
                      "where transaction_code=@code"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = order.transactioncode
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                order.transactioncode = reader("transaction_code")
                order.invoice = reader("invoice_no")
                order.orderdate = reader("order_date")
                order.customername = reader("_name")
                order.customeraddress = reader("address")
                order.totalamountdue = reader("total_amount")
                order.paymenttype = reader("payment_type")
                order.cheque_no = reader("cheque_no")
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Sub populateOrderItemsDatagrid(dgv As DataGridView, search As String, transactionCode As Long)
        Try
            openConnection()
            Dim que As String = "select order_detailID, serial_number, _name, brand, model, category, supplier, quantity, unit, price, total, warranty_start, warranty_end " &
                                "from orders_detail " &
                                "where (serial_number like @serial Or _name like @name Or concat(brand, ' ', model) like @bmodel) and transaction_code=@code and not deleted order by order_detailID"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@code", MySqlDbType.Int64).Value = transactionCode
                .Parameters.Add("@serial", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@bmodel", MySqlDbType.VarChar).Value = "%" & search & "%"
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

    Public Sub populateOrdersDataGrid(dgv As DataGridView, search As String, orderDate As Date)
        Try
            openConnection()
            Dim que As String = "select orders.transaction_code, orders.invoice_no, orders.order_date, customers._name, customers.address, orders.total_amount, orders.payment_type 
                                from orders inner join customers on orders.customer=customers.customer_id 
                                where (_name like @name or transaction_code like @code or invoice_no like @invoice)
                                and DATE(order_date)=@date
                                and (not orders.deleted and not customers.deleted)
                                order by order_date desc, customers._name"

            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@invoice", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@date", MySqlDbType.Date).Value = orderDate
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()
            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    'load datagrid
    Public Sub populateOrdersDataGrid(dgv As DataGridView, search As String, dateFilter As Date, dateFilterEnd As Date)
        Try
            openConnection()
            Dim que As String = "select orders.transaction_code, orders.invoice_no, orders.order_date, customers._name, customers.address, orders.total_amount, orders.payment_type 
                                from orders inner join customers on orders.customer=customers.customer_id 
                                where (_name like @name or transaction_code like @code or invoice_no like @invoice) 
                                and (DATE(order_date) between @date and @dateEnd)
                                and (not orders.deleted and not customers.deleted)
                                order by order_date desc, customers._name"

            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@invoice", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@date", MySqlDbType.Date).Value = dateFilter
                .Parameters.Add("@dateEnd", MySqlDbType.Date).Value = dateFilterEnd
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()
            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    'load datagrid
    Public Sub populateAllOrdersDataGrid(dgv As DataGridView, search As String, category As String, brand As String, model As String, orderDate As Date)
        Try
            openConnection()
            Dim que As String = ""

            If brand = "ALL" And model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where (customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice or serial_number like @serial Or orders_detail._name Like @pname)
                        and DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            ElseIf Not brand = "ALL" And model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where (customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice or serial_number like @serial Or orders_detail._name Like @pname)
                        and brand=@brand
                        and DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            ElseIf Not brand = "ALL" And Not model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where (customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice or serial_number like @serial Or orders_detail._name Like @pname)
                        and brand=@brand and model=@model 
                        and DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            ElseIf Not brand = "ALL" And Not model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where (customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice or serial_number like @serial Or orders_detail._name Like @pname)
                        and brand=@brand and model=@model and category=@category 
                        and DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            ElseIf brand = "ALL" And model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where(customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice Or serial_number Like @serial Or orders_detail._name Like @pname) 
                        And category =@category 
                        and DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            ElseIf Not brand = "ALL" And model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where(customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice Or serial_number Like @serial Or orders_detail._name Like @pname)
                        And brand=@brand and category=@category 
                        and DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            ElseIf brand = "ALL" And Not model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where(customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice Or serial_number Like @serial Or orders_detail._name Like @pname)
                        And model=@model
                        and DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            ElseIf brand = "ALL" And Not model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where (customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice or serial_number like @serial Or orders_detail._name Like @pname) 
                        and model=@model and category=@category
                        and DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            End If
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@invoice", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@serial", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@pname", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@category", MySqlDbType.VarChar).Value = category
                .Parameters.Add("@brand", MySqlDbType.VarChar).Value = brand
                .Parameters.Add("@model", MySqlDbType.VarChar).Value = model
                .Parameters.Add("@orderDate", MySqlDbType.Date).Value = orderDate
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()
            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10), reader(11), reader(12), reader(13), reader(14), reader(15), reader(16))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub

    Public Sub populateAllOrdersDataGrid(dgv As DataGridView, search As String, category As String, brand As String, model As String, startDate As Date, endDate As Date)
        Try
            openConnection()
            Dim que As String = ""

            If brand = "ALL" And model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where (customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice or serial_number like @serial Or orders_detail._name Like @pname)
                        and DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            ElseIf Not brand = "ALL" And model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where (customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice or serial_number like @serial Or orders_detail._name Like @pname)
                        and brand=@brand
                        and DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            ElseIf Not brand = "ALL" And Not model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where (customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice or serial_number like @serial Or orders_detail._name Like @pname)
                        and brand=@brand and model=@model 
                        and DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            ElseIf Not brand = "ALL" And Not model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where (customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice or serial_number like @serial Or orders_detail._name Like @pname)
                        and brand=@brand and model=@model and category=@category 
                        and DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            ElseIf brand = "ALL" And model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where(customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice Or serial_number Like @serial Or orders_detail._name Like @pname) 
                        And category =@category 
                        and DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            ElseIf Not brand = "ALL" And model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where(customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice Or serial_number Like @serial Or orders_detail._name Like @pname)
                        And brand=@brand and category=@category 
                        and DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            ElseIf brand = "ALL" And Not model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where(customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice Or serial_number Like @serial Or orders_detail._name Like @pname)
                        And model=@model
                        and DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            ElseIf brand = "ALL" And Not model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.unit, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where (customers._name Like @name Or orders.transaction_code Like @code Or invoice_no Like @invoice or serial_number like @serial Or orders_detail._name Like @pname) 
                        and model=@model and category=@category
                        and DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"
            End If
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@invoice", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@serial", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@pname", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@category", MySqlDbType.VarChar).Value = category
                .Parameters.Add("@brand", MySqlDbType.VarChar).Value = brand
                .Parameters.Add("@model", MySqlDbType.VarChar).Value = model
                .Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate
                .Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()
            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10), reader(11), reader(12), reader(13), reader(14), reader(15), reader(16))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub

    Public Sub advanceOrdersSearch(dgv As DataGridView, search As String)
        Try
            openConnection()
            Dim que As String = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, concat(orders_detail._name, ' ', orders_detail.brand, ' ', orders_detail.model) as ProductDesc, orders_detail.category, orders_detail.supplier
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where (orders.transaction_code Like @code Or invoice_no Like @invoice or customers._name Like @name or serial_number like @serial or concat(orders_detail._name, ' ', orders_detail.brand, ' ', orders_detail.model) like @prod)
                        and (not orders.deleted and not customers.deleted)
                        order by order_date desc, customers._name"

            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@invoice", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@serial", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@prod", MySqlDbType.VarChar).Value = "%" & search & "%"
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()
            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub
End Class

