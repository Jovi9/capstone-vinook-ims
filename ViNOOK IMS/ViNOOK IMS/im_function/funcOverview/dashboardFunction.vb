
Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class dashboardFunction : Inherits database

    Private startDate As Date
    Private endDate As Date
    Private numberOfDays As Integer

    Private _numCustomersTotal As Integer
    Private _numSuppliersTotal As Integer
    Private _numProductsTotal As Integer
    Private _numStocksTotal As Integer
    Private _numOrdersTotal As Integer

    Private _topProductList As DataTable
    Private _lowProductStockList As DataTable
    Private _salesByDateList As DataTable
    Private _totalSales As Decimal

    Dim groupByFormatter As String
    Public Sub New()

    End Sub

    Public Function getInitialOrderDate() As Date
        Using connection()
            openConnection()
            Using com As New MySqlCommand
                com.Connection = connection()
                com.CommandText = "select order_date
                                    from orders 
                                    order by order_date
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

    Private Sub getNumberOfItems()
        Using connection()
            openConnection()
            Using com As New MySqlCommand
                com.Connection = connection()

                'get total customers
                com.CommandText = "select count(customer_id) as TotalCustomers from customers;"
                numcustomerstotal = Convert.ToInt64(com.ExecuteScalar)

                'get total suppliers
                com.CommandText = "select count(supplier_id) as TotalSuppliers from suppliers;"
                numsupplierstotal = Convert.ToInt64(com.ExecuteScalar)

                'get total products
                com.CommandText = "select count(product_id) as TotalProducts from products;"
                numproductstotal = Convert.ToInt64(com.ExecuteScalar)

                'get total stocks avaiable
                com.CommandText = "select sum(on_hand) as TotalStockAvailable from products;"
                numstockstotal = Convert.ToInt64(com.ExecuteScalar)

                'get total orders
                com.CommandText = "select count(transaction_code) as TotalOrders from orders
                                    where (order_date between @fromDate and @toDate) 
                                    and not _data_status=@dstatus;"
                With com
                    .Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = startDate
                    .Parameters.Add("@toDate", MySqlDbType.DateTime).Value = endDate
                    .Parameters.Add("@dstatus", MySqlDbType.VarChar).Value = "Void"
                End With
                numorderstotal = Convert.ToInt64(com.ExecuteScalar)
            End Using
            closeConnection()
        End Using
    End Sub

    Private Sub getOrderAnalysis()
        salesbydatelist = New DataTable
        salesbydatelist.Columns.Add("order_date", GetType(DateTime))
        salesbydatelist.Columns.Add("TotalAmount", GetType(Decimal))
        totalsales = 0

        If numberOfDays <= 1 Then
            'grp by hour
            groupByFormatter = "%H"
        ElseIf numberOfDays <= 30 Then
            'group by days
            groupByFormatter = "%d"
        ElseIf numberOfDays <= 92 Then
            'group by weeks where firstday is monday
            groupByFormatter = "%u"
        ElseIf numberOfDays <= 365 * 2 Then
            'grp by motnh
            groupByFormatter = "%m%Y"
        Else
            'group by year
            groupByFormatter = "%Y"
        End If

        Using connection()
            openConnection()
            Using com As New MySqlCommand
                With com
                    .Connection = connection()
                    .CommandText = "select order_date, sum(total_amount) as TotalAmount
                                    from orders
                                    where order_date between @fromDate and @toDate
                                    and not _data_status=@dstatus
                                    group by DATE_FORMAT(order_date, @formatter);"
                    .Parameters.Add("@formatter", MySqlDbType.VarChar).Value = groupByFormatter
                    .Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = startDate
                    .Parameters.Add("@toDate", MySqlDbType.DateTime).Value = endDate
                    .Parameters.Add("@dstatus", MySqlDbType.VarChar).Value = "Void"
                End With
                Using reader As MySqlDataReader = com.ExecuteReader
                    While reader.Read
                        salesbydatelist.Rows.Add(Convert.ToDateTime(reader(0)), Convert.ToDecimal(reader(1)))
                        totalsales += Convert.ToDecimal(reader(1))
                    End While

                End Using
            End Using
            closeConnection()
        End Using
    End Sub

    Private Sub getProductAnalysis()
        topproductlist = New DataTable
        lowproductstocklist = New DataTable

        Using connection()
            openConnection()
            Using com As New MySqlCommand
                com.Connection = connection()
                Dim reader As MySqlDataReader
                'gettop product
                With com
                    .CommandText = "select orders_detail._name, sum(orders_detail.quantity) as TotalSold
                                    from orders
                                    inner join orders_detail on orders.transaction_code=orders_detail.transaction_code
                                    where order_date between @fromDate and @toDate
                                    and not orders._data_status=@dstatus
                                    group by orders_detail._name
                                    order by TotalSold desc
                                    limit 5;"
                    .Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = startDate
                    .Parameters.Add("@toDate", MySqlDbType.DateTime).Value = endDate
                    .Parameters.Add("@dstatus", MySqlDbType.VarChar).Value = "Void"
                End With
                reader = com.ExecuteReader
                topproductlist.Load(reader)
                reader.Close()

                'get low stock

                com.CommandText = "select _name, on_hand
                                    from products
                                    where on_hand < 5
                                    and not _data_status='Deleted'
                                    order by on_hand, _name
                                    limit 5;"
                reader = com.ExecuteReader
                lowproductstocklist.Load(reader)
                reader.Close()
            End Using
            closeConnection()
        End Using
    End Sub

    Public Function loadData(startDate As Date, endDate As Date) As Boolean
        endDate = New DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59)
        If Me.startDate <> startDate Or Me.endDate <> endDate Then
            Me.startDate = startDate
            Me.endDate = endDate
            Me.numberOfDays = (endDate - startDate).Days

            getNumberOfItems()
            getProductAnalysis()
            getOrderAnalysis()
            Console.WriteLine("Data Loaded. {0} to {1}", startDate.ToString, endDate.ToString)
            Return True
        Else
            Console.WriteLine("Same request, data not loaded. {0} to {1}", startDate.ToString, endDate.ToString)
            Return False
        End If
    End Function

    Public Property numcustomerstotal As Integer
        Get
            Return _numCustomersTotal
        End Get
        Set(value As Integer)
            _numCustomersTotal = value
        End Set
    End Property

    Public Property numsupplierstotal As Integer
        Get
            Return _numSuppliersTotal
        End Get
        Set(value As Integer)
            _numSuppliersTotal = value
        End Set
    End Property

    Public Property numproductstotal As Integer
        Get
            Return _numProductsTotal
        End Get
        Set(value As Integer)
            _numProductsTotal = value
        End Set
    End Property

    Public Property numstockstotal As Integer
        Get
            Return _numStocksTotal
        End Get
        Set(value As Integer)
            _numStocksTotal = value
        End Set
    End Property

    Public Property numorderstotal As Integer
        Get
            Return _numOrdersTotal
        End Get
        Set(value As Integer)
            _numOrdersTotal = value
        End Set
    End Property

    Public Property totalsales As Decimal
        Get
            Return _totalSales
        End Get
        Set(value As Decimal)
            _totalSales = value
        End Set
    End Property

    Public Property topproductlist As DataTable
        Get
            Return _topProductList
        End Get
        Set(value As DataTable)
            _topProductList = value
        End Set
    End Property

    Public Property lowproductstocklist As DataTable
        Get
            Return _lowProductStockList
        End Get
        Set(value As DataTable)
            _lowProductStockList = value
        End Set
    End Property

    Public Property salesbydatelist As DataTable
        Get
            Return _salesByDateList
        End Get
        Set(value As DataTable)
            _salesByDateList = value
        End Set
    End Property
End Class
