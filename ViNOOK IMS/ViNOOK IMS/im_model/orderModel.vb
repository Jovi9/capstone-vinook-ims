Public Class orderModel
    Private _productID As Long
    Private _productDetailID As Long

    Private _orderID As Long
    Private _transactionCode As Long
    Private _serialNumber As String
    Private _productName As String
    Private _productBrand As String
    Private _productModel As String
    Private _productCategory As String
    Private _supplier As String
    Private _quantity As Long
    Private _unit As String
    Private _price As Decimal
    Private _total As Decimal
    Private _warrantyStart As String
    Private _warrantyEnd As String

    Private _totalOnhand As Long

    Private _created_at As Date
    Private _updated_at As Date

    Public Property productid As Long
        Get
            Return _productID
        End Get
        Set(value As Long)
            _productID = value
        End Set
    End Property

    Public Property productdetailid As Long
        Get
            Return _productDetailID
        End Get
        Set(value As Long)
            _productDetailID = value
        End Set
    End Property

    Public Property orderid As Long
        Get
            Return _orderID
        End Get
        Set(value As Long)
            _orderID = value
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

    Public Property productname As String
        Get
            Return _productName
        End Get
        Set(value As String)
            _productName = value
        End Set
    End Property

    Public Property productbrand As String
        Get
            Return _productBrand
        End Get
        Set(value As String)
            _productBrand = value
        End Set
    End Property

    Public Property productmodel As String
        Get
            Return _productModel
        End Get
        Set(value As String)
            _productModel = value
        End Set
    End Property

    Public Property productcategory As String
        Get
            Return _productCategory
        End Get
        Set(value As String)
            _productCategory = value
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

    Public Property price As Decimal
        Get
            Return _price
        End Get
        Set(value As Decimal)
            _price = value
        End Set
    End Property

    Public Property total As Decimal
        Get
            Return _total
        End Get
        Set(value As Decimal)
            _total = value
        End Set
    End Property

    Public Property warrantystart As String
        Get
            Return _warrantyStart
        End Get
        Set(value As String)
            _warrantyStart = value
        End Set
    End Property

    Public Property warrantyend As String
        Get
            Return _warrantyEnd
        End Get
        Set(value As String)
            _warrantyEnd = value
        End Set
    End Property

    Public Property totalonhand As Long
        Get
            Return _totalOnhand
        End Get
        Set(value As Long)
            _totalOnhand = value
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

    Public Property transactionCode As Long
        Get
            Return _transactionCode
        End Get
        Set(value As Long)
            _transactionCode = value
        End Set
    End Property

    Public Property suppliername As String
        Get
            Return _supplier
        End Get
        Set(value As String)
            _supplier = value
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
End Class
