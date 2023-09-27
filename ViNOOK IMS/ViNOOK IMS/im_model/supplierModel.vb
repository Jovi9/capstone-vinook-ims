Public Class supplierModel
    Private _supplierID As Long
    Private _name As String
    Private _address As String
    Private _phone As String
    Private _email As String
    Private _other_details As String
    Private _created_at As Date
    Private _updated_at As Date

    Public Property supplierid As Long
        Get
            Return _supplierID
        End Get
        Set(value As Long)
            _supplierID = value
        End Set
    End Property

    Public Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property

    Public Property phone As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property

    Public Property email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property other_details As String
        Get
            Return _other_details
        End Get
        Set(value As String)
            _other_details = value
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
