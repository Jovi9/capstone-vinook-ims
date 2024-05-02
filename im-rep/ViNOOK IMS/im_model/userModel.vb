Public Class userModel

    Private _userID As Long
    Private _firstName As String
    Private _lastName As String
    Private _name As String
    Private _phone As String
    Private _email As String
    Private _address As String
    Private _userName As String
    Private _userPassword As String
    Private _role As String
    Private _recoveryCode As String
    Private _created_at As Date
    Private _updated_at As Date
    Private _updated_by As String
    Private _last_login_at As Date

    Public Sub New()

    End Sub

    Public Sub New(userName As String, userPassword As String)
        _userName = userName
        _userPassword = userPassword
    End Sub

    Public Property userid As Long
        Get
            Return _userID
        End Get
        Set(value As Long)
            _userID = value
        End Set
    End Property

    Public Property firstname As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    Public Property lastname As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
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

    Public Property username As String
        Get
            Return _userName
        End Get
        Set(value As String)
            _userName = value
        End Set
    End Property

    Public Property userpassword As String
        Get
            Return _userPassword
        End Get
        Set(value As String)
            _userPassword = value
        End Set
    End Property

    Public Property role As String
        Get
            Return _role
        End Get
        Set(value As String)
            _role = value
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

    Public Property updated_by As String
        Get
            Return _updated_by
        End Get
        Set(value As String)
            _updated_by = value
        End Set
    End Property

    Public Property last_login_at As Date
        Get
            Return _last_login_at
        End Get
        Set(value As Date)
            _last_login_at = value
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

    Public Property recoverycode As String
        Get
            Return _recoveryCode
        End Get
        Set(value As String)
            _recoveryCode = value
        End Set
    End Property
End Class
