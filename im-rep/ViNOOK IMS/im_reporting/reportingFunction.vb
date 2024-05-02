Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class reportingFunction : Inherits database

#Region "->Low stock"
    Public Sub printLowStock()
        Dim dataSet As New dataSetInventory
        Try
            Dim que As String = "select _name, brand, model, categories.category, on_hand, unit
                                from products
                                inner join categories on products.category_id=categories.category_id
                                where on_hand < 5
                                and not products.deleted
                                order by on_hand, category, brand, model, _name;"
            Using condb
                openConnection()
                Using com As New MySqlCommand(que, condb)
                    Using reader As MySqlDataReader = com.ExecuteReader(CommandBehavior.CloseConnection)
                        dataSet.Tables("low_stock").Load(reader)
                    End Using
                End Using
                closeConnection()
            End Using

            Dim report As New reportLowStock

            report.SetDataSource(dataSet)
            frmPreviewReport.reportViewer.ReportSource = report
            frmPreviewReport.reportViewer.Refresh()
            'frmPrintPreview.reportViewer.Zoom(100)

        Finally
            closeConnection()
        End Try
    End Sub
#End Region

#Region "->inventory"

    Public Sub printInventory(category As String)
        Dim dataSet As New dataSetInventory
        Try
            Dim que As String = ""

            If category = "ALL" Then
                que = "select products.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products.quantity, products.on_hand, products.unit, products.price
                        From products inner Join categories On products.category_id=categories.category_id
                        where not products.deleted
                        Order By category, brand, model, _name"
            Else
                que = "select products.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products.quantity, products.on_hand, products.unit, products.price
                        from products inner join categories On products.category_id=categories.category_id
                        where category=@category
                        and not products.deleted
                        order by category, brand, model, _name"
            End If

            Using condb
                openConnection()
                Using com As New MySqlCommand(que, condb)
                    With com
                        .Parameters.Add("@category", MySqlDbType.VarChar).Value = category
                    End With
                    Using reader As MySqlDataReader = com.ExecuteReader(CommandBehavior.CloseConnection)
                        dataSet.Tables("inventory").Load(reader)
                    End Using
                End Using
                closeConnection()
            End Using

            Dim report As New reportInventory

            report.SetDataSource(dataSet)
            frmPreviewReport.reportViewer.ReportSource = report
            frmPreviewReport.reportViewer.Refresh()
            'frmPrintPreview.reportViewer.Zoom(100)

        Finally
            closeConnection()
        End Try
    End Sub

    Public Sub printAllInventory(category As String, supplier As String, startDate As Date)
        Dim dataSet As New dataSetInventory
        Try
            Dim que As String = ""

            If category = "ALL" And supplier = "ALL" Then
                que = "select products_detail.detail_id, products_detail.product_id, products.item_code, products._name as productName, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) as on_hand, products.unit, products_detail.at_cost, products.price, suppliers._name as supplier, products_detail.date_in, sum(products_detail.quantity) as quantity
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where (not products.deleted and not products_detail.deleted) 
                      and not _status=@status 
                      and DATE(date_in)=@startDate
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            ElseIf category = "ALL" And Not supplier = "ALL" Then
                que = "select products_detail.detail_id, products_detail.product_id, products.item_code, products._name as productName, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) as on_hand, products.unit, products_detail.at_cost, products.price, suppliers._name as supplier, products_detail.date_in, sum(products_detail.quantity) as quantity
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where suppliers._name=@supplier 
                      and (not products.deleted and not products_detail.deleted) 
                      and not _status=@status
                      and DATE(date_in)=@startDate
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            ElseIf Not category = "ALL" And supplier = "ALL" Then
                que = "select products_detail.detail_id, products_detail.product_id, products.item_code, products._name as productName, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) as on_hand, products.unit, products_detail.at_cost, products.price, suppliers._name as supplier, products_detail.date_in, sum(products_detail.quantity) as quantity
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where category=@category 
                      and (not products.deleted and not products_detail.deleted) 
                      and not _status=@status
                      and DATE(date_in)=@startDate
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            Else
                que = "select products_detail.detail_id, products_detail.product_id, products.item_code, products._name as productName, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) as on_hand, products.unit, products_detail.at_cost, products.price, suppliers._name as supplier, products_detail.date_in, sum(products_detail.quantity) as quantity
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where category=@category and suppliers._name=@supplier
                      and (not products.deleted and not products_detail.deleted) 
                      and not _status=@status 
                      and DATE(date_in)=@startDate
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            End If

            Using condb
                openConnection()
                Using com As New MySqlCommand(que, condb)
                    With com
                        .Parameters.Add("@category", MySqlDbType.VarChar).Value = category
                        .Parameters.Add("@supplier", MySqlDbType.VarChar).Value = supplier
                        .Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate
                        .Parameters.Add("@status", MySqlDbType.VarChar).Value = "Sold"
                    End With
                    Using reader As MySqlDataReader = com.ExecuteReader(CommandBehavior.CloseConnection)
                        dataSet.Tables("all_inventory").Load(reader)
                    End Using
                End Using
                closeConnection()
            End Using

            Dim report As New reportInventoryAll
            Dim txtOrdersFrom As TextObject
            txtOrdersFrom = report.ReportDefinition.ReportObjects("txtInventoryFrom")
            txtOrdersFrom.Text = "Date In from " & Format(startDate, "MMMM dd, yyyy")

            report.SetDataSource(dataSet)
            frmPreviewReport.reportViewer.ReportSource = report
            frmPreviewReport.reportViewer.Refresh()
            'frmPrintPreview.reportViewer.Zoom(100)

        Finally
            closeConnection()
        End Try
    End Sub

    Public Sub printAllInventory(category As String, supplier As String, startDate As Date, endDate As Date)
        Dim dataSet As New dataSetInventory
        Try
            Dim que As String = ""

            If category = "ALL" And supplier = "ALL" Then
                que = "select products_detail.detail_id, products_detail.product_id, products.item_code, products._name as productName, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) as on_hand, products.unit, products_detail.at_cost, products.price, suppliers._name as supplier, products_detail.date_in, sum(products_detail.quantity) as quantity
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      where (not products.deleted and not products_detail.deleted) 
                      and not _status=@status 
                      and DATE(date_in) between @startDate and @endDate
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            ElseIf category = "ALL" And Not supplier = "ALL" Then
                que = "select products_detail.detail_id, products_detail.product_id, products.item_code, products._name as productName, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) as on_hand, products.unit, products_detail.at_cost, products.price, suppliers._name as supplier, products_detail.date_in, sum(products_detail.quantity) as quantity
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where suppliers._name=@supplier 
                      and (not products.deleted and not products_detail.deleted) 
                      and not _status=@status
                      and DATE(date_in) between @startDate and @endDate
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            ElseIf Not category = "ALL" And supplier = "ALL" Then
                que = "select products_detail.detail_id, products_detail.product_id, products.item_code, products._name as productName, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) as on_hand, products.unit, products_detail.at_cost, products.price, suppliers._name as supplier, products_detail.date_in, sum(products_detail.quantity) as quantity
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where category=@category 
                      and (not products.deleted and not products_detail.deleted) 
                      and not _status=@status
                      and DATE(date_in) between @startDate and @endDate
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            Else
                que = "select products_detail.detail_id, products_detail.product_id, products.item_code, products._name as productName, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) as on_hand, products.unit, products_detail.at_cost, products.price, suppliers._name as supplier, products_detail.date_in, sum(products_detail.quantity) as quantity
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where category=@category and suppliers._name=@supplier
                      and (not products.deleted and not products_detail.deleted) 
                      and not _status=@status 
                      and DATE(date_in) between @startDate and @endDate
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name"
            End If

            Using condb
                openConnection()
                Using com As New MySqlCommand(que, condb)
                    With com
                        .Parameters.Add("@category", MySqlDbType.VarChar).Value = category
                        .Parameters.Add("@supplier", MySqlDbType.VarChar).Value = supplier
                        .Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate
                        .Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate
                        .Parameters.Add("@status", MySqlDbType.VarChar).Value = "Sold"
                    End With
                    Using reader As MySqlDataReader = com.ExecuteReader(CommandBehavior.CloseConnection)
                        dataSet.Tables("all_inventory").Load(reader)
                    End Using
                End Using
                closeConnection()
            End Using

            Dim report As New reportInventoryAll
            Dim txtOrdersFrom As TextObject
            txtOrdersFrom = report.ReportDefinition.ReportObjects("txtInventoryFrom")
            txtOrdersFrom.Text = "Date In from " & Format(startDate, "MMMM dd, yyyy") & " to " & Format(endDate, "MMMM dd, yyyy")

            report.SetDataSource(dataSet)
            frmPreviewReport.reportViewer.ReportSource = report
            frmPreviewReport.reportViewer.Refresh()
            'frmPrintPreview.reportViewer.Zoom(100)

        Finally
            closeConnection()
        End Try
    End Sub

#End Region

#Region "->orders"
    Public Sub printOrders(startDate As Date)
        Dim dataSet As New dataSetOrders
        Try
            Dim que As String = "select orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, customers.address as customerAddress, orders.total_amount, orders.payment_type,
                                (select count(transaction_code) from orders_detail where orders_detail.transaction_code=orders.transaction_code) as numItems
                                from orders
                                inner join customers on orders.customer=customers.customer_id
                                where DATE(order_date)=@startDate
                                and not orders.deleted
                                order by order_date, customerName;"
            Using condb
                openConnection()
                Using com As New MySqlCommand(que, condb)
                    With com
                        .Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate
                    End With
                    Using reader As MySqlDataReader = com.ExecuteReader(CommandBehavior.CloseConnection)
                        dataSet.Tables("orders").Load(reader)
                    End Using
                End Using
                closeConnection()
            End Using

            Dim report As New reportOrders
            Dim txtOrdersFrom As TextObject
            txtOrdersFrom = report.ReportDefinition.ReportObjects("txtOrdersFrom")
            txtOrdersFrom.Text = "All sales from " & Format(startDate, "MMMM dd, yyyy")

            report.SetDataSource(dataSet)
            frmPreviewReport.reportViewer.ReportSource = report
            frmPreviewReport.reportViewer.Refresh()
            'frmPrintPreview.reportViewer.Zoom(100)

        Finally
            closeConnection()
        End Try
    End Sub

    Public Sub printOrders(startDate As Date, endDate As Date)
        Dim dataSet As New dataSetOrders
        Try
            Dim que As String = "select orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, customers.address as customerAddress, orders.total_amount, orders.payment_type,
                                (select count(transaction_code) from orders_detail where orders_detail.transaction_code=orders.transaction_code) as numItems
                                from orders
                                inner join customers on orders.customer=customers.customer_id
                                where DATE(order_date) between @startDate and @endDate
                                and not orders.deleted
                                order by order_date, customerName;"
            Using condb
                openConnection()
                Using com As New MySqlCommand(que, condb)
                    With com
                        .Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate
                        .Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate
                    End With
                    Using reader As MySqlDataReader = com.ExecuteReader(CommandBehavior.CloseConnection)
                        dataSet.Tables("orders").Load(reader)
                    End Using
                End Using
                closeConnection()
            End Using

            Dim report As New reportOrders
            Dim txtOrdersFrom As TextObject
            txtOrdersFrom = report.ReportDefinition.ReportObjects("txtOrdersFrom")
            txtOrdersFrom.Text = "All sales from " & Format(startDate, "MMMM dd, yyyy") & " to " & Format(endDate, "MMMM dd, yyyy")

            report.SetDataSource(dataSet)
            frmPreviewReport.reportViewer.ReportSource = report
            frmPreviewReport.reportViewer.Refresh()
            'frmPrintPreview.reportViewer.Zoom(100)

        Finally
            closeConnection()
        End Try
    End Sub

    Public Sub printAllOrders(category As String, brand As String, model As String, orderDate As Date)
        Dim dataSet As New dataSetOrders
        Try
            Dim que As String = ""

            If brand = "ALL" And model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            ElseIf Not brand = "ALL" And model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where brand=@brand
                        and DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            ElseIf Not brand = "ALL" And Not model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where brand=@brand and model=@model 
                        and DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            ElseIf Not brand = "ALL" And Not model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where brand=@brand and model=@model and category=@category 
                        and DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            ElseIf brand = "ALL" And model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where category=@category 
                        and DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            ElseIf Not brand = "ALL" And model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where brand=@brand and category=@category 
                        and DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            ElseIf brand = "ALL" And Not model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where model=@model
                        and DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            ElseIf brand = "ALL" And Not model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where model=@model and category=@category
                        and DATE(order_date)=@orderDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            End If

            Using condb
                openConnection()
                Using com As New MySqlCommand(que, condb)
                    With com
                        .Parameters.Add("@category", MySqlDbType.VarChar).Value = category
                        .Parameters.Add("@brand", MySqlDbType.VarChar).Value = brand
                        .Parameters.Add("@model", MySqlDbType.VarChar).Value = model
                        .Parameters.Add("@orderDate", MySqlDbType.Date).Value = orderDate
                    End With
                    Using reader As MySqlDataReader = com.ExecuteReader(CommandBehavior.CloseConnection)
                        dataSet.Tables("all_orders").Load(reader)
                    End Using
                End Using
                closeConnection()
            End Using

            Dim report As New reportOrdersAll
            Dim txtOrdersFrom As TextObject
            txtOrdersFrom = report.ReportDefinition.ReportObjects("txtOrdersFrom")
            txtOrdersFrom.Text = "All sales from " & Format(orderDate, "MMMM dd, yyyy")

            report.SetDataSource(dataSet)
            frmPreviewReport.reportViewer.ReportSource = report
            frmPreviewReport.reportViewer.Refresh()
            'frmPrintPreview.reportViewer.Zoom(100)

        Finally
            closeConnection()
        End Try
    End Sub

    Public Sub printAllOrders(category As String, brand As String, model As String, startDate As Date, endDate As Date)
        Dim dataSet As New dataSetOrders
        Try
            Dim que As String = ""

            If brand = "ALL" And model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            ElseIf Not brand = "ALL" And model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where brand=@brand
                        and DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            ElseIf Not brand = "ALL" And Not model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where brand=@brand and model=@model 
                        and DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            ElseIf Not brand = "ALL" And Not model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where brand=@brand and model=@model and category=@category 
                        and DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            ElseIf brand = "ALL" And model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code
                        where category=@category 
                        and DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            ElseIf Not brand = "ALL" And model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where brand=@brand and category=@category 
                        and DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            ElseIf brand = "ALL" And Not model = "ALL" And category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where model=@model
                        and DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            ElseIf brand = "ALL" And Not model = "ALL" And Not category = "ALL" Then
                que = "select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end, orders_detail.unit
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where model=@model and category=@category
                        and DATE(order_date) between @startDate and @endDate
                        and (not orders.deleted and not customers.deleted)
                        order by order_date, customers._name"
            End If

            Using condb
                openConnection()
                Using com As New MySqlCommand(que, condb)
                    With com
                        .Parameters.Add("@category", MySqlDbType.VarChar).Value = category
                        .Parameters.Add("@brand", MySqlDbType.VarChar).Value = brand
                        .Parameters.Add("@model", MySqlDbType.VarChar).Value = model
                        .Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate
                        .Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate
                    End With
                    Using reader As MySqlDataReader = com.ExecuteReader(CommandBehavior.CloseConnection)
                        dataSet.Tables("all_orders").Load(reader)
                    End Using
                End Using
                closeConnection()
            End Using

            Dim report As New reportOrdersAll
            Dim txtOrdersFrom As TextObject
            txtOrdersFrom = report.ReportDefinition.ReportObjects("txtOrdersFrom")
            txtOrdersFrom.Text = "All sales from " & Format(startDate, "MMMM dd, yyyy") & " to " & Format(endDate, "MMMM dd, yyyy")

            report.SetDataSource(dataSet)
            frmPreviewReport.reportViewer.ReportSource = report
            frmPreviewReport.reportViewer.Refresh()
            'frmPrintPreview.reportViewer.Zoom(100)

        Finally
            closeConnection()
        End Try
    End Sub
#End Region

#Region "->customers"
    Public Sub printCustomers()
        Dim dataSet As New dataSetReporting
        Try
            Dim que As String = "select customer_id, _name, address, phone, tinID
                                    from customers 
                                    where not deleted
                                    order by _name;"
            Using condb
                openConnection()
                Using com As New MySqlCommand(que, condb)
                    Using reader As MySqlDataReader = com.ExecuteReader(CommandBehavior.CloseConnection)
                        dataSet.Tables("tblcustomers").Load(reader)
                    End Using
                End Using
                closeConnection()
            End Using

            Dim report As New reportCustomers
            report.SetDataSource(dataSet)
            frmPreviewReport.reportViewer.ReportSource = report
            frmPreviewReport.reportViewer.Refresh()
            'frmPrintPreview.reportViewer.Zoom(100)

        Finally
            closeConnection()
        End Try
    End Sub
#End Region

#Region "->suppliers"
    Public Sub printSuppliers()
        Dim dataSet As New dataSetReporting
        Try
            Dim que As String = "select supplier_id, _name, address, phone, email,
                                (select sum(quantity) from products_detail
                                where products_detail.supplier_id=suppliers.supplier_id
                                and not products_detail.deleted) as numProducts
                                from suppliers 
                                order by _name;"
            Using condb
                openConnection()
                Using com As New MySqlCommand(que, condb)
                    Using reader As MySqlDataReader = com.ExecuteReader(CommandBehavior.CloseConnection)
                        dataSet.Tables("tblsuppliers").Load(reader)
                    End Using
                End Using
                closeConnection()
            End Using

            Dim report As New reportSuppliers
            report.SetDataSource(dataSet)
            frmPreviewReport.reportViewer.ReportSource = report
            frmPreviewReport.reportViewer.Refresh()
            'frmPrintPreview.reportViewer.Zoom(100)

        Finally
            closeConnection()
        End Try
    End Sub
#End Region

#Region "->category"
    Public Sub printCategory()
        Dim dataSet As New dataSetReporting
        Try
            Dim que As String = "select categories.category_id, categories.category,
                                (select count(category_id) from products
                                inner join products_detail on products.product_id=products_detail.product_id
                                where products.category_id=categories.category_id
                                and not _status=@status) as availableStock
                                from categories
                                where not deleted
                                order by categories.category;"
            Using condb
                openConnection()
                Using com = New MySqlCommand(que, condb)
                    com.Parameters.Add("@status", MySqlDbType.VarChar).Value = "Sold"
                    Using reader = com.ExecuteReader(CommandBehavior.CloseConnection)
                        dataSet.Tables("tblcategories").Load(reader)
                    End Using
                End Using
                closeConnection()
            End Using

            Dim report As New reportCategory
            report.SetDataSource(dataSet)
            frmPreviewReport.reportViewer.ReportSource = report
            frmPreviewReport.reportViewer.Refresh()
            'frmPrintPreview.reportViewer.Zoom(100)
        Finally
            closeConnection()
        End Try
    End Sub
#End Region
End Class
