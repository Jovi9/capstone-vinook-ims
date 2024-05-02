Imports MySql.Data.MySqlClient

Public Class database : Implements IDisposable

    ReadOnly str_con As String = "server=localhost;userid=vnook_merchandise;password=VNookComputers_200207_Inventory;database=virtual_inventory;"
    ReadOnly con As New MySqlConnection(str_con)

    Public ReadOnly Property condb()
        Get
            Return con
        End Get
    End Property

    Public Function connection() As MySqlConnection
        Return con
    End Function

    Public Sub openConnection()
        con.Close()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Public Sub closeConnection()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
                con.Dispose()

            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
