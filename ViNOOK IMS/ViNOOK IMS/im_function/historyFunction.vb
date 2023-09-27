Imports MySql.Data.MySqlClient

Public Class historyFunction : Inherits database
    Dim com As MySqlCommand
    Dim reader As MySqlDataReader

    Public Sub addToHistory(history As historyModel)
        Try
            openConnection()
            Dim que As String = "insert into sys_history (username, _action, title, content, newContent, _date) " &
                      "values(@username, @action, @title, @content, @new, @date)"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@username", MySqlDbType.VarChar).Value = history.username
                .Parameters.Add("@action", MySqlDbType.VarChar).Value = history.action
                .Parameters.Add("@title", MySqlDbType.VarChar).Value = history.title
                .Parameters.Add("@content", MySqlDbType.LongText).Value = history.content
                .Parameters.Add("@new", MySqlDbType.LongText).Value = history.newcontent
                .Parameters.Add("@date", MySqlDbType.DateTime).Value = history.execdate
            End With
            com.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub

    Public Sub getHistoryDetails(history As historyModel)
        Try
            openConnection()
            Dim que As String = "select * from sys_history where id=@id"
            com = New MySqlCommand(que, condb)
            com.Parameters.Add("@id", MySqlDbType.Int64).Value = history.id
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                history.id = reader(0)
                history.username = reader(1)
                history.action = reader(2)
                history.title = reader(3)
                history.content = reader(4)
                history.execdate = reader(5)
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Sub populateDGVHistory(dgv As DataGridView, search As String)
        Try
            openConnection()
            Dim que As String = ""
            If session_role = 0 Then
                que = "select * from sys_history order by _date desc"
            ElseIf session_role = 1 Then
                que = "select * from sys_history where username=@user order by _date desc"
            End If
            com = New MySqlCommand(que, condb)
            'com.Parameters.Add("@name", MySqlDbType.VarChar).Value = "%" & search & "%"
            With com
                .Parameters.Add("@user", MySqlDbType.VarChar).Value = session_username
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()

            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), Format(reader(6), "dd-MMM-yyyy hh:mm:ss tt"))
            Loop
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub
End Class
