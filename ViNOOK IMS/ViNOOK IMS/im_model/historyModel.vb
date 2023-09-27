Public Class historyModel
    Private _id As Long
    Private _username As String
    Private _action As String
    Private _title As String
    Private _content As String
    Private _newContent As String
    Private _execDate As Date

    Public Sub New()
    End Sub

    Public Sub New(username As String, action As String, title As String, content As String, execDate As Date)
        _username = username
        _action = action
        _title = title
        _content = content
        _execDate = execDate
    End Sub

    Public Sub New(username As String, action As String, title As String, content As String, newContent As String, execDate As Date)
        _username = username
        _action = action
        _title = title
        _content = content
        _newContent = newContent
        _execDate = execDate
    End Sub

    Public Property id As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Public Property username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property action As String
        Get
            Return _action
        End Get
        Set(value As String)
            _action = value
        End Set
    End Property

    Public Property title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property content As String
        Get
            Return _content
        End Get
        Set(value As String)
            _content = value
        End Set
    End Property

    Public Property execdate As Date
        Get
            Return _execDate
        End Get
        Set(value As Date)
            _execDate = value
        End Set
    End Property

    Public Property newcontent As String
        Get
            Return _newContent
        End Get
        Set(value As String)
            _newContent = value
        End Set
    End Property
End Class
