Imports MySql.Data.MySqlClient

Public Class unitFunction : Inherits database
    Dim com As MySqlCommand
    Dim reader As MySqlDataReader

    Dim _id As String
    Dim _unit As String
    Dim _content As String

    Dim new_content As String
    Dim new_unit As String

#Region "->save to database"
    Public Function addNewUnit(unit As unitModel) As Boolean
        Try
            openConnection()
            unit.created_at = Date.Now
            Dim que As String = "insert into units (units, created_at, updated_at) " &
                            "values(@unit, @created, @updated)"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@unit", MySqlDbType.VarChar).Value = unit.unit
                .Parameters.Add("@created", MySqlDbType.DateTime).Value = unit.created_at
                .Parameters.Add("@updated", MySqlDbType.DateTime).Value = unit.created_at
            End With

            _unit = "Unit Name: " & unit.unit

            _content = _unit

            Dim modelHistory As New historyModel(session_username, "CREATE", "UNIT", _content, unit.created_at)
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

    Public Function updateUnitDetail(unit As unitModel) As Boolean
        Try
            openConnection()
            unit.updated_at = Date.Now
            Dim que As String = "update units set units=@unit, updated_at=@updated_at " &
                                "where id=@id"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@id", MySqlDbType.Int64).Value = unit.unit_id
                .Parameters.Add("@unit", MySqlDbType.VarChar).Value = unit.unit
                .Parameters.Add("@updated_at", MySqlDbType.DateTime).Value = unit.updated_at
            End With

            _id = "No. " & unit.unit_id & ", "

            _unit = "Unit Name: " & trackUnit_name
            new_unit = "Unit Name: " & unit.unit

            _content = _unit
            new_content = new_unit

            Dim modelHistory As New historyModel(session_username, "UPDATE", "UNIT", _content, new_content, unit.updated_at)
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

    Public Sub getUnitDetails(unit As unitModel)
        Try
            openConnection()
            Dim que As String = "select * from units where id=@id"
            com = New MySqlCommand(que, condb)
            com.Parameters.Add("@id", MySqlDbType.Int64).Value = unit.unit_id
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                unit.unit_id = reader(0)
                unit.unit = reader(1)
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Function checkIfUnitExists(txt As String) As Boolean
        Try
            openConnection()
            Dim que As String = "select * from units where units=@unit and not deleted"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@unit", MySqlDbType.VarChar).Value = txt
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

    Public Sub populateUnitsDataGrid(dgv As DataGridView, search As String)
        Try
            openConnection()
            Dim que As String = "select * from units " &
                                "where units like @unit and not deleted order by units"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@unit", MySqlDbType.VarChar).Value = "%" & search & "%"
            End With
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
