Imports MySql.Data.MySqlClient

Public Class categoryFunction : Inherits database

    Dim com As MySqlCommand
    Dim reader As MySqlDataReader

    Dim _id As String
    Dim _category As String
    Dim _content As String

    Dim _newContent As String
    Dim new_category As String
    Public Property totalCategories As Long

#Region "->save to database"
    Public Function updateCategoryDetail(category As categoryModel) As Boolean
        Try
            openConnection()
            category.updated_at = Date.Now
            Dim que As String = "update categories set category=@category, updated_at=@updated_at " &
                                "where category_id=@id"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@id", MySqlDbType.Int64).Value = category.id
                .Parameters.Add("@category", MySqlDbType.VarChar).Value = category.category
                .Parameters.Add("@updated_at", MySqlDbType.DateTime).Value = category.updated_at
            End With

            _id = "No. " & category.id & ", "

            _category = "Category Name: " & trackCategory_name
            new_category = "Category Name: " & category.category

            _content = _category
            _newContent = new_category

            Dim modelHistory As New historyModel(session_username, "UPDATE", "CATEGORY", _content, _newContent, category.updated_at)
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

    Public Function addNewCategory(category As categoryModel) As Boolean
        Try
            openConnection()
            category.created_at = Date.Now
            Dim que As String = "insert into categories (category, created_at, updated_at) " &
                            "values(@category, @created, @updated)"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@category", MySqlDbType.VarChar).Value = category.category
                .Parameters.Add("@created", MySqlDbType.DateTime).Value = category.created_at
                .Parameters.Add("@updated", MySqlDbType.DateTime).Value = category.created_at
            End With

            _category = "Category Name: " & category.category

            _content = _category

            Dim modelHistory As New historyModel(session_username, "CREATE", "CATEGORY", _content, category.created_at)
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

    Public Function getTopCategories() As DataTable
        Dim topCategoriesList As New DataTable
        With topCategoriesList
            .Columns.Add("category", GetType(String))
            .Columns.Add("stock", GetType(Long))
        End With

        Using connection()
            openConnection()
            Using command As New MySqlCommand
                With command
                    .Connection = connection()
                    .CommandText = "select categories.category,
                                    (select count(category_id) from products
                                    inner join products_detail on products.product_id=products_detail.product_id
                                    where products.category_id=categories.category_id
                                    and not products_detail.deleted) as TotalStock
                                    from categories
                                    order by TotalStock desc
                                    limit 5;"
                End With
                Using dataReader As MySqlDataReader = command.ExecuteReader
                    While dataReader.Read
                        topCategoriesList.Rows.Add(dataReader(0).ToString, Convert.ToInt64(dataReader(1)))
                    End While
                End Using
                With command
                    .CommandText = "select count(category_id) as TotalCategories
                                    from categories where not deleted;"
                End With
                totalCategories = Convert.ToInt64(command.ExecuteScalar)
            End Using
            closeConnection()
        End Using
        Return topCategoriesList
    End Function

    Public Function checkIfCategoryExists(txt As String) As Boolean
        Try
            openConnection()
            Dim que As String = "select * from categories where category=@category and not deleted"
            com = New MySqlCommand(que, condb)
            com.Parameters.Add("@category", MySqlDbType.VarChar).Value = txt
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

    Public Sub getCategoryDetails(category As categoryModel)
        Try
            openConnection()
            Dim que As String = "select * from categories where category_id=@id"
            com = New MySqlCommand(que, condb)
            com.Parameters.Add("@id", MySqlDbType.Int64).Value = category.id
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                category.id = reader(0)
                category.category = reader(1)
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Sub populateDGVCategory(dgv As DataGridView, search As String)
        Try
            openConnection()
            Dim que As String = "select * from categories " &
                                "where category like @category and not deleted order by category"
            com = New MySqlCommand(que, condb)
            com.Parameters.Add("@category", MySqlDbType.VarChar).Value = "%" & search & "%"
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()

            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

End Class
