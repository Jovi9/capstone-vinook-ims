Public Class stockModel
    Private _detailID As Long
    Private _serialNumber As String
    Private _atCost As Decimal
    Private _supplierID As Long
    Private _supplierName As String

    Public Property detailid As Long
        Get
            Return _detailID
        End Get
        Set(value As Long)
            _detailID = value
        End Set
    End Property

    Public Property serialnumber As String
        Get
            Return _serialNumber
        End Get
        Set(value As String)
            _serialNumber = value
        End Set
    End Property

    Public Property atcost As Decimal
        Get
            Return _atCost
        End Get
        Set(value As Decimal)
            _atCost = value
        End Set
    End Property

    Public Property supplierid As Long
        Get
            Return _supplierID
        End Get
        Set(value As Long)
            _supplierID = value
        End Set
    End Property

    Public Property suppliername As String
        Get
            Return _supplierName
        End Get
        Set(value As String)
            _supplierName = value
        End Set
    End Property
End Class
