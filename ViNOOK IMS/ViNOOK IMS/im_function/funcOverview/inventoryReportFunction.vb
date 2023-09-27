Imports MySql.Data.MySqlClient

Public Class inventoryReportFunction : Inherits database
    Private startDate As Date
    Private endDate As Date
    Private numberOfDays As Long
    Private groupByFormatter As String

    Public Property totalStocks As Long
    Public Property totalStocksAvailable As Long
    Public Property stockByDateList As DataTable
    Public Property productStatistics As DataTable

    Public Sub New()

    End Sub

    Public Function getInitialDateIn() As Date
        Using connection()
            openConnection()
            Using com As New MySqlCommand
                com.Connection = connection()
                com.CommandText = "select DATE(date_in)
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

    Private Sub getNumberOfItems()
        Using connection()
            openConnection()
            Using com As New MySqlCommand
                com.Connection = connection()
                'get total orders
                With com
                    .CommandText = "select sum(quantity)
                                    from products_detail
                                    where DATE(date_in) between @fromDate and @toDate
                                    and not deleted;"
                    .Parameters.Add("@fromDate", MySqlDbType.Date).Value = startDate
                    .Parameters.Add("@toDate", MySqlDbType.Date).Value = endDate
                End With
                Dim total = com.ExecuteScalar
                totalStocks = If(Not IsDBNull(total), Convert.ToInt64(total), 0)

                With com
                    .CommandText = "select sum(on_hand)
                                    from products_detail
                                    where DATE(date_in) between @fromDate and @toDate
                                    and not deleted;"
                End With
                total = com.ExecuteScalar
                totalStocksAvailable = If(Not IsDBNull(total), Convert.ToInt64(total), 0)
            End Using
            closeConnection()
        End Using
    End Sub

    Private Sub getStockAnalysis()
        stockByDateList = New DataTable
        With stockByDateList
            .Columns.Add("DateIn", GetType(DateTime))
            .Columns.Add("Stock", GetType(Long))
        End With

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
                    .CommandText = "select date_in, sum(quantity) as Stock
                                    from products_detail
                                    where DATE(date_in) between @fromDate and @toDate
                                    and not deleted
                                    group by date_format(date_in, @formatter) order by date_in;"
                    .Parameters.Add("@formatter", MySqlDbType.VarChar).Value = groupByFormatter
                    .Parameters.Add("@fromDate", MySqlDbType.Date).Value = startDate
                    .Parameters.Add("@toDate", MySqlDbType.Date).Value = endDate
                End With
                Using reader As MySqlDataReader = com.ExecuteReader
                    While reader.Read
                        stockByDateList.Rows.Add(Convert.ToDateTime(reader(0)), Convert.ToInt64(reader(1)))
                    End While
                End Using
            End Using
            closeConnection()
        End Using
    End Sub

    Private Sub getProductStatistics()
        productStatistics = New DataTable
        With productStatistics
            .Columns.Add("ProductName", GetType(String))
            .Columns.Add("TotalStock", GetType(Long))
            .Columns.Add("TotalAvailable", GetType(Long))
            .Columns.Add("TotalSold", GetType(Long))
        End With

        Using connection()
            openConnection()
            Using com As New MySqlCommand
                com.Connection = connection()
                With com
                    .CommandText = "select products._name as ProductName, sum(products_detail.quantity) as TotalStock, sum(products_detail.on_hand) as TotalAvailable, sum(products_detail.quantity) - sum(products_detail.on_hand) as TotalSold
                                    from products
                                    inner join products_detail
                                    on products.product_id=products_detail.product_id
                                    where DATE(date_in) between @fromDate and @toDate
                                    and not products.deleted
                                    group by ProductName
                                    order by TotalSold desc, TotalStock desc;"
                    .Parameters.Add("@fromDate", MySqlDbType.Date).Value = startDate
                    .Parameters.Add("@toDate", MySqlDbType.Date).Value = endDate
                End With
                Using reader As MySqlDataReader = com.ExecuteReader
                    While reader.Read
                        productStatistics.Rows.Add(reader(0).ToString, Convert.ToInt64(reader(1)), Convert.ToInt64(reader(2)), Convert.ToInt64(reader(3)))
                    End While
                End Using
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
            getStockAnalysis()
            getProductStatistics()
            Console.WriteLine("Data Loaded. {0} to {1}", startDate.ToString, endDate.ToString)
            Return True
        Else
            Console.WriteLine("Same request, data not loaded. {0} to {1}", startDate.ToString, endDate.ToString)
            Return False
        End If
    End Function
End Class
