Public Class categoryModel
    Private _id As Long
    Private _category As String
    Private _created_at As Date
    Private _updated_at As Date

    Public Property id As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Public Property category As String
        Get
            Return _category
        End Get
        Set(value As String)
            _category = value
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
