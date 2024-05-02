Public Class unitModel
    Private _unit_id As Long
    Private _unit As String
    Private _created_at As Date
    Private _updated_at As Date

    Public Property unit_id As Long
        Get
            Return _unit_id
        End Get
        Set(value As Long)
            _unit_id = value
        End Set
    End Property

    Public Property unit As String
        Get
            Return _unit
        End Get
        Set(value As String)
            _unit = value
        End Set
    End Property

    Public Property created_at As Date
        Get
            Return _created_at
        End Get
        Set(value As Date)
            _created_at = value
        End Set
    End Property

    Public Property updated_at As Date
        Get
            Return _updated_at
        End Get
        Set(value As Date)
            _updated_at = value
        End Set
    End Property
End Class
