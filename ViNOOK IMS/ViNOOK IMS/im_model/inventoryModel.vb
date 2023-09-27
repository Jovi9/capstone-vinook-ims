Public Class inventoryModel
    'product
    Private _productID As Long
    Private _itemCode As String
    Private _name As String
    Private _brand As String
    Private _model As String
    Private _category As String
    Private _categoryName As String
    Private _quantity As Long
    Private _onHand As Long
    Private _unit As String
    Private _price As Decimal
    Private _created_at As Date
    Private _updated_at As Date
    'details
    Private _detailID As Long
    Private _serialNumber As String
    Private _atCost As Decimal
    Private _dateIN As Date
    Private _supplier As String
    Private _supplierName As String
    Private _other_details As String
    Private _status As String
    Private _reference_id As String

    Public Property productid As Long
        Get
            Return _productID
        End Get
        Set(value As Long)
            _productID = value
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

    Public Property brand As String
        Get
            Return _brand
        End Get
        Set(value As String)
            _brand = value
        End Set
    End Property

    Public Property model As String
        Get
            Return _model
        End Get
        Set(value As String)
            _model = value
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

    Public Property quantity As Long
        Get
            Return _quantity
        End Get
        Set(value As Long)
            _quantity = value
        End Set
    End Property

    Public Property onhand As Long
        Get
            Return _onHand
        End Get
        Set(value As Long)
            _onHand = value
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

    Public Property price As Decimal
        Get
            Return _price
        End Get
        Set(value As Decimal)
            _price = value
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

    Public Property atCost As Decimal
        Get
            Return _atCost
        End Get
        Set(value As Decimal)
            _atCost = value
        End Set
    End Property

    Public Property datein As Date
        Get
            Return _dateIN
        End Get
        Set(value As Date)
            _dateIN = value
        End Set
    End Property

    Public Property supplier As String
        Get
            Return _supplier
        End Get
        Set(value As String)
            _supplier = value
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

    Public Property status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

    Public Property itemcode As String
        Get
            Return _itemCode
        End Get
        Set(value As String)
            _itemCode = value
        End Set
    End Property

    Public Property categoryname As String
        Get
            Return _categoryName
        End Get
        Set(value As String)
            _categoryName = value
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

    Public Property reference_id As String
        Get
            Return _reference_id
        End Get
        Set(value As String)
            _reference_id = value
        End Set
    End Property
End Class
