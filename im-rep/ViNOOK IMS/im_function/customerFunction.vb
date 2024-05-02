Imports MySql.Data.MySqlClient

Public Class customerFunction : Inherits database
    Dim com As MySqlCommand
    Dim reader As MySqlDataReader

    Dim _id As String
    Dim _name As String
    Dim _address As String
    Dim _phone As String
    Dim _tinID As String
    Dim _content As String

    Dim _newContent As String
    Dim new_name As String
    Dim new_address As String
    Dim new_phone As String
    Dim new_tinID As String

    Public Property totalCustomer As Long

#Region "->save to database"
    Public Function updateCustomerDetail(customer As customerModel) As Boolean
        Try
            openConnection()

            customer.updated_at = Date.Now
            Dim que As String = "update customers set _name=@name, address=@address, phone=@phone, tinID=@tinid, updated_at=@updated_at " &
                                "where customer_id=@id"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@id", MySqlDbType.Int64).Value = customer.id
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = customer.name
                .Parameters.Add("@address", MySqlDbType.VarChar).Value = customer.address
                .Parameters.Add("@phone", MySqlDbType.VarChar).Value = customer.phone
                .Parameters.Add("@tinid", MySqlDbType.LongText).Value = customer.tin_id
                .Parameters.Add("@updated_at", MySqlDbType.DateTime).Value = customer.updated_at
            End With

            _id = "Customer No.: " & customer.id & Environment.NewLine

            If String.Equals(trackCustomer_name, customer.name) Then
                _name = "Customer Name: " & trackCustomer_name & Environment.NewLine
            Else
                _name = "Customer Name: " & trackCustomer_name & Environment.NewLine
                new_name = "Customer Name: " & customer.name & Environment.NewLine
            End If

            If String.Equals(trackCustomer_address, customer.address) Then
                _address = ""
            Else
                _address = "Address: " & trackCustomer_address & Environment.NewLine
                new_address = "Address: " & customer.address & Environment.NewLine
            End If
            If String.Equals(trackCustomer_phone, customer.phone) Then
                _phone = ""
            Else
                If trackCustomer_phone = "" Then
                    trackCustomer_phone = "None"
                End If
                If customer.phone = "" Then
                    customer.phone = "None"
                End If
                _phone = "Phone: " & trackCustomer_phone & Environment.NewLine
                new_phone = "Phone: " & customer.phone & Environment.NewLine
            End If
            If String.Equals(trackCustomer_tinID, customer.tin_id) Then
                _tinID = ""
            Else
                If trackCustomer_tinID = "" Then
                    trackCustomer_tinID = "None"
                End If
                If customer.tin_id = "" Then
                    customer.tin_id = "None"
                End If
                _tinID = "TIN ID: " & trackCustomer_tinID
                new_tinID = "TIN ID: " & customer.tin_id
            End If

            _content = _name & _address & _phone & _tinID
            _newContent = new_name & new_address & new_phone & new_tinID

            Dim modelHistory As New historyModel(session_username, "UPDATE", "CUSTOMER", _content, _newContent, customer.updated_at)
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

    Public Function addNewCustomer(customer As customerModel) As Boolean
        Try
            openConnection()
            customer.created_at = Date.Now
            Dim que As String = "insert into customers (_name, address, phone, tinID, created_at, updated_at) " &
                            "values(@name, @address, @phone, @tinid, @created, @updated)"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = customer.name
                .Parameters.Add("@address", MySqlDbType.VarChar).Value = customer.address
                .Parameters.Add("@phone", MySqlDbType.VarChar).Value = customer.phone
                .Parameters.Add("@tinid", MySqlDbType.LongText).Value = customer.tin_id
                .Parameters.Add("@created", MySqlDbType.DateTime).Value = customer.created_at
                .Parameters.Add("@updated", MySqlDbType.DateTime).Value = customer.created_at
            End With

            If Not customer.name = "" Then
                _name = "Customer Name: " & customer.name & Environment.NewLine
            Else
                _name = ""
            End If
            If Not customer.address = "" Then
                _address = "Address: " & customer.address & Environment.NewLine
            Else
                _address = ""
            End If
            If Not customer.phone = "" Then
                _phone = "Phone: " & customer.phone & Environment.NewLine
            Else
                _phone = ""
            End If
            If Not customer.tin_id = "" Then
                _tinID = "TIN ID: " & customer.tin_id
            Else
                _tinID = ""
            End If

            _content = _name & _address & _phone & _tinID
            Dim modelHistory As New historyModel(session_username, "CREATE", "CUSTOMER", _content, customer.created_at)
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

    Public Function getTopCustomers() As DataTable
        Dim topCustomerList As New DataTable
        With topCustomerList
            .Columns.Add("customer", GetType(String))
            .Columns.Add("orders", GetType(Long))
        End With

        Using connection()
            openConnection()
            Using command As New MySqlCommand
                With command
                    .Connection = connection()
                    .CommandText = "select distinct _name,
                                    (select count(customer)
                                    from orders
                                    where orders.customer=customers.customer_id) as OrderCount
                                    from customers
                                    inner join orders on customers.customer_id=orders.customer
                                    where not orders.deleted
                                    order by OrderCount desc, order_date
                                    limit 5;"
                End With
                Using dataReader As MySqlDataReader = command.ExecuteReader
                    While dataReader.Read
                        topCustomerList.Rows.Add(dataReader(0).ToString, Convert.ToInt64(dataReader(1)))
                    End While
                End Using

                With command
                    .CommandText = "select count(customer_id) as TotalCustomer
                                    from customers where not deleted;"
                End With
                totalCustomer = Convert.ToInt64(command.ExecuteScalar)
            End Using
            closeConnection()
        End Using
        Return topCustomerList
    End Function

    Public Function checkIfCustomerExists(txt As String) As Boolean
        Try
            openConnection()
            Dim que As String = "select customer_id, _name from customers " &
                                "where _name=@name and not deleted"
            com = New MySqlCommand(que, condb)
            com.Parameters.Add("@name", MySqlDbType.VarChar).Value = txt
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

    Public Sub getCustomerDetails(customer As customerModel)
        Try
            openConnection()
            Dim que As String = "select customer_id, _name, address, phone, tinID from customers where customer_id=@id"
            com = New MySqlCommand(que, condb)
            com.Parameters.Add("@id", MySqlDbType.Int64).Value = customer.id
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

    Public Sub populateDGVCustomer(dgv As DataGridView, search As String)
        Try
            openConnection()
            Dim que As String = "select customer_id, _name, address, phone, tinID from customers " &
                                "where _name like @name or customer_id like @id and not deleted order by _name"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@id", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = "%" & search & "%"
            End With

            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()

            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

End Class
