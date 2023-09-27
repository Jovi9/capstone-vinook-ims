Public Class ordersModel
    Private _transactionCode As Long
    Private _invoice As String
    Private _orderDate As Date
    Private _customerID As Long
    Private _customerName As String
    Private _customerAddress As String
    Private _totalAmountDue As Decimal
    Private _balance As Decimal
    Private _received_amount As Decimal
    Private _change As Decimal
    Private _paymentType As String
    Private _cheque_no As String
    Private _payStatus As String
    Private _created_at As Date
    Private _updated_at As Date

    Public Property transactioncode As Long
        Get
            Return _transactionCode
        End Get
        Set(value As Long)
            _transactionCode = value
        End Set
    End Property

    Public Property invoice As String
        Get
            Return _invoice
        End Get
        Set(value As String)
            _invoice = value
        End Set
    End Property

    Public Property orderdate As Date
        Get
            Return _orderDate
        End Get
        Set(value As Date)
            _orderDate = value
        End Set
    End Property

    Public Property customerid As Long
        Get
            Return _customerID
        End Get
        Set(value As Long)
            _customerID = value
        End Set
    End Property

    Public Property totalamountdue As Decimal
        Get
            Return _totalAmountDue
        End Get
        Set(value As Decimal)
            _totalAmountDue = value
        End Set
    End Property

    Public Property balance As Decimal
        Get
            Return _balance
        End Get
        Set(value As Decimal)
            _balance = value
        End Set
    End Property

    Public Property received_amount As Decimal
        Get
            Return _received_amount
        End Get
        Set(value As Decimal)
            _received_amount = value
        End Set
    End Property

    Public Property change As Decimal
        Get
            Return _change
        End Get
        Set(value As Decimal)
            _change = value
        End Set
    End Property

    Public Property paymenttype As String
        Get
            Return _paymentType
        End Get
        Set(value As String)
            _paymentType = value
        End Set
    End Property

    Public Property paystatus As String
        Get
            Return _payStatus
        End Get
        Set(value As String)
            _payStatus = value
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

    Public Property customername As String
        Get
            Return _customerName
        End Get
        Set(value As String)
            _customerName = value
        End Set
    End Property

    Public Property customeraddress As String
        Get
            Return _customerAddress
        End Get
        Set(value As String)
            _customerAddress = value
        End Set
    End Property

    Public Property cheque_no As String
        Get
            Return _cheque_no
        End Get
        Set(value As String)
            _cheque_no = value
        End Set
    End Property
End Class
