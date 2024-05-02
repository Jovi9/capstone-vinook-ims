Imports MySql.Data.MySqlClient

Public Class supplierFunction : Inherits database
    Dim com As MySqlCommand
    Dim reader As MySqlDataReader

    Dim id As String
    Dim name As String
    Dim address As String
    Dim phone As String
    Dim email As String
    Dim otherDetails As String
    Dim content As String

    Dim _newContent As String
    Dim new_name As String
    Dim new_address As String
    Dim new_phone As String
    Dim new_email As String
    Dim new_otherDetails As String
    Public Property totalSuppliers As Long

#Region "->save to database"
    Public Function updateSupplierDetail(supplier As supplierModel) As Boolean
        Try
            openConnection()

            supplier.updated_at = Date.Now
            Dim que As String = "update suppliers set _name=@name, address=@address, phone=@phone, email=@email, other_details=@otherdetails, updated_at=@updated_at " &
                                "where supplier_id=@id"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@id", MySqlDbType.Int64).Value = supplier.supplierid
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = supplier.name
                .Parameters.Add("@address", MySqlDbType.VarChar).Value = supplier.address
                .Parameters.Add("@phone", MySqlDbType.VarChar).Value = supplier.phone
                .Parameters.Add("@email", MySqlDbType.VarChar).Value = supplier.email
                .Parameters.Add("@otherdetails", MySqlDbType.LongText).Value = supplier.other_details
                .Parameters.Add("@updated_at", MySqlDbType.DateTime).Value = supplier.updated_at
            End With

            If String.Equals(tracking_Suppliername, supplier.name) Then
                name = "Supplier Name: " & tracking_Suppliername & Environment.NewLine
            Else
                name = "Supplier Name: " & tracking_Suppliername & Environment.NewLine
                new_name = "Supplier Name: " & supplier.name & Environment.NewLine
            End If
            If String.Equals(tracking_Supplieraddress, supplier.address) Then
                address = ""
            Else
                address = "Address: " & tracking_Supplieraddress & Environment.NewLine
                new_address = "Address: " & supplier.address & Environment.NewLine
            End If
            If String.Equals(tracking_Supplierphone, supplier.phone) Then
                phone = ""
            Else
                If tracking_Supplierphone = "" Then
                    tracking_Supplierphone = "None"
                End If
                If supplier.phone = "" Then
                    supplier.phone = "None"
                End If
                phone = "Phone: " & tracking_Supplierphone & Environment.NewLine
                new_phone = "Phone: " & supplier.phone & Environment.NewLine
            End If
            If String.Equals(tracking_Supplieremail, supplier.email) Then
                email = ""
            Else
                If tracking_Supplieremail = "" Then
                    tracking_Supplieremail = "None"
                End If
                If supplier.email = "" Then
                    supplier.email = "None"
                End If
                email = "Email: " & tracking_Supplieremail & Environment.NewLine
                new_email = "Email: " & supplier.email & Environment.NewLine
            End If
            If String.Equals(tracking_SupplierotherDetails, supplier.other_details) Then
                otherDetails = ""
            Else
                If tracking_SupplierotherDetails = "" Then
                    tracking_SupplierotherDetails = "None"
                End If
                If supplier.other_details = "" Then
                    supplier.other_details = "None"
                End If
                otherDetails = "Other Details: " & tracking_SupplierotherDetails
                new_otherDetails = "Other Details: " & supplier.other_details
            End If

            id = "Supplier ID: " & supplier.supplierid & Environment.NewLine

            content = name & address & phone & email & otherDetails
            _newContent = new_name & new_address & new_phone & new_email & new_otherDetails
            Dim modelHistory As New historyModel(session_username, "UPDATE", "SUPPLIER", content, _newContent, supplier.updated_at)
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

    Public Function addNewSupplier(supplier As supplierModel) As Boolean
        Try
            openConnection()
            supplier.created_at = Date.Now
            Dim que As String = "insert into suppliers (_name, address, phone, email, other_details, created_at, updated_at) " &
                        "values(@name, @address, @phone, @email, @otherdetails, @created, @updated)"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = supplier.name
                .Parameters.Add("@address", MySqlDbType.VarChar).Value = supplier.address
                .Parameters.Add("@phone", MySqlDbType.VarChar).Value = supplier.phone
                .Parameters.Add("@email", MySqlDbType.VarChar).Value = supplier.email
                .Parameters.Add("@otherdetails", MySqlDbType.LongText).Value = supplier.other_details
                .Parameters.Add("@created", MySqlDbType.DateTime).Value = supplier.created_at
                .Parameters.Add("@updated", MySqlDbType.DateTime).Value = supplier.created_at
            End With

            If Not supplier.name = "" Then
                name = "Supplier Name: " & supplier.name & Environment.NewLine
            Else
                name = ""
            End If
            If Not supplier.address = "" Then
                address = "Address: " & supplier.address & Environment.NewLine
            Else
                address = ""
            End If
            If Not supplier.phone = "" Then
                phone = "Phone: " & supplier.phone & Environment.NewLine
            Else
                phone = ""
            End If
            If Not supplier.email = "" Then
                email = "Email: " & supplier.email & Environment.NewLine
            Else
                email = ""
            End If
            If Not supplier.other_details = "" Then
                otherDetails = "Other Details: " & supplier.other_details
            Else
                otherDetails = ""
            End If

            content = name & address & phone & email & otherDetails
            Dim modelHistory As New historyModel(session_username, "CREATE", "SUPPLIER", content, supplier.created_at)
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

    Public Function getTopSupplier() As DataTable
        Dim topSupplierList As New DataTable
        With topSupplierList
            .Columns.Add("supplier", GetType(String))
            .Columns.Add("stock", GetType(Long))
        End With

        Using connection()
            openConnection()
            Using command As New MySqlCommand
                With command
                    .Connection = connection()
                    .CommandText = "select _name, 
                                    (select count(quantity) from products_detail
                                    where products_detail.supplier_id=suppliers.supplier_id
                                    and not products_detail.deleted) as numProducts
                                    from suppliers 
                                    order by numProducts desc
                                    limit 5;"
                End With
                Using dataReader As MySqlDataReader = command.ExecuteReader
                    While dataReader.Read
                        topSupplierList.Rows.Add(dataReader(0).ToString, Convert.ToInt64(dataReader(1)))
                    End While
                End Using
                With command
                    .CommandText = "select count(supplier_id) as TotalSuppliers
                                    from suppliers where not deleted;"
                End With
                totalSuppliers = Convert.ToInt64(command.ExecuteScalar)
            End Using
            closeConnection()
        End Using
        Return topSupplierList
    End Function

    Public Function checkIfSupplierExists(txt As String) As Boolean
        Try
            openConnection()
            Dim que As String = "select supplier_id, _name from suppliers " &
                            "where _name=@name and not deleted"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@name", MySqlDbType.VarChar).Value = txt
            End With
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
            reader.Close()
            closeConnection()
        End Try
    End Function

    'view
    Public Sub getSupplierDetails(supplier As supplierModel)
        Try
            openConnection()
            Dim que As String = "select supplier_id, _name, address, phone, email, other_details from suppliers " &
                                "where supplier_id=@id"
            com = New MySqlCommand(que, condb)
            com.Parameters.Add("@id", MySqlDbType.Int64).Value = supplier.supplierid
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                supplier.supplierid = reader(0)
                supplier.name = reader(1)
                supplier.address = reader(2)
                supplier.phone = reader(3).ToString
                supplier.email = reader(4).ToString
                supplier.other_details = reader(5).ToString
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    'load supplier list
    Public Sub populateDGVSupplier(dgv As DataGridView, search As String)
        Try
            openConnection()
            Dim que As String = "select supplier_id, _name, address, phone, email from suppliers " &
                                "where _name like @name or supplier_id like @id and not deleted order by _name"
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
