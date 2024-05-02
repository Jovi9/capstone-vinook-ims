Imports MySql.Data.MySqlClient

Public Class salesReportFunction : Inherits database
    Private startDate As Date
    Private endDate As Date
    Private numberOfDays As Long
    Private groupByFormatter As String

    Public Property totalSales As Decimal
    Public Property totalOrders As Long
    Public Property totalCustomer As Long
    Public Property salesByDateList As DataTable
    Public Property topProductsList As DataTable
    Public Property soldProductsList As DataTable

    Public Sub New()
    End Sub

    Public Function getInitialOrderDate() As Date
        Using connection()
            openConnection()
            Using com As New MySqlCommand
                com.Connection = connection()
                com.CommandText = "select DATE(order_date)
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

                'get total orders
                With com
                    .CommandText = "select count(transaction_code) as TotalOrders from orders
                                    where DATE(order_date) between @fromDate and @toDate
                                    and not deleted;"
                    .Parameters.Add("@fromDate", MySqlDbType.Date).Value = startDate
                    .Parameters.Add("@toDate", MySqlDbType.Date).Value = endDate
                End With
                totalOrders = Convert.ToInt64(com.ExecuteScalar)

                With com
                    .CommandText = "select count(distinct(customer)) as TotalCustomers
                                    from orders
                                    where DATE(order_date) between @fromDate and @toDate
                                    and not deleted;"
                End With
                totalCustomer = Convert.ToInt64(com.ExecuteScalar)

            End Using
            closeConnection()
        End Using
    End Sub

    Private Sub getOrderAnalysis()
        salesByDateList = New DataTable
        salesByDateList.Columns.Add("OrderDate", GetType(DateTime))
        salesByDateList.Columns.Add("TotalAmount", GetType(Decimal))
        totalSales = 0

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
                                    where DATE(order_date) between @fromDate and @toDate
                                    and not deleted
                                    group by DATE_FORMAT(order_date, @formatter) order by order_date;"
                    .Parameters.Add("@formatter", MySqlDbType.VarChar).Value = groupByFormatter
                    .Parameters.Add("@fromDate", MySqlDbType.Date).Value = startDate
                    .Parameters.Add("@toDate", MySqlDbType.Date).Value = endDate
                End With
                Using reader As MySqlDataReader = com.ExecuteReader
                    While reader.Read
                        salesByDateList.Rows.Add(Convert.ToDateTime(reader(0)), Convert.ToDecimal(reader(1)))
                        totalSales += Convert.ToDecimal(reader(1))
                    End While

                End Using
            End Using
            closeConnection()
        End Using
    End Sub

    Private Sub getProductAnalysis()
        topProductsList = New DataTable
        With topProductsList
            .Columns.Add("ProductName", GetType(String))
            .Columns.Add("TotalSold", GetType(Long))
        End With

        soldProductsList = New DataTable
        With soldProductsList
            .Columns.Add("ProductName", GetType(String))
            .Columns.Add("TotalSold", GetType(Long))
        End With

        Using connection()
            openConnection()
            Using com As New MySqlCommand
                com.Connection = connection()
                'gettop product
                Dim reader As MySqlDataReader
                With com
                    .CommandText = "select orders_detail._name, sum(orders_detail.quantity) as TotalSold
                                    from orders
                                    inner join orders_detail on orders.transaction_code=orders_detail.transaction_code
                                    where DATE(order_date) between @fromDate and @toDate
                                    and not orders.deleted
                                    group by orders_detail._name
                                    order by TotalSold desc, order_detailID
                                    limit 5;"
                    .Parameters.Add("@fromDate", MySqlDbType.Date).Value = startDate
                    .Parameters.Add("@toDate", MySqlDbType.Date).Value = endDate
                End With
                reader = com.ExecuteReader
                While reader.Read
                    topProductsList.Rows.Add(reader(0).ToString, Convert.ToInt64(reader(1)))
                End While
                reader.Close()

                With com
                    .CommandText = "select orders_detail._name as ProductName, sum(orders_detail.quantity) as TotalSold
                                    from orders
                                    inner join orders_detail on orders.transaction_code=orders_detail.transaction_code
                                    where DATE(order_date) between @fromDate and @toDate
                                    and not orders_detail.deleted
                                    group by ProductName
                                    order by TotalSold desc, order_detailID;"
                End With
                reader = com.ExecuteReader
                While reader.Read
                    soldProductsList.Rows.Add(reader(0).ToString, Convert.ToInt64(reader(1)))
                End While
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
            getOrderAnalysis()
            getProductAnalysis()
            Console.WriteLine("Data Loaded. {0} to {1}", startDate.ToString, endDate.ToString)
            Return True
        Else
            Console.WriteLine("Same request, data not loaded. {0} to {1}", startDate.ToString, endDate.ToString)
            Return False
        End If
    End Function
End Class
