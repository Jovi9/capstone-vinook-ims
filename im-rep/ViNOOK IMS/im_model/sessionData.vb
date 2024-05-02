Imports System.Reflection
Imports System.Text.RegularExpressions

Module sessionData

    Public Property session_username As String
    Public Property session_email As String
    Public Property session_firstname As String
    Public Property session_lastname As String
    Public Property session_role As String

    Public Property notification_timeout As Date

    Public Sub setDoubleBuffer(ByVal control As DataGridView)
        GetType(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty Or BindingFlags.Instance Or BindingFlags.NonPublic, Nothing, control, New Object() {True})
    End Sub

    Public Sub onlyAcceptNumber(e As KeyPressEventArgs)
        'number sana sa textbox
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub enableReadOnlyFillable(ctrl As Control)
        For Each field As Control In ctrl.Controls
            If field.GetType = GetType(TextBox) Then
                CType(field, TextBox).ReadOnly = True
            End If
            If field.GetType = GetType(MaskedTextBox) Then
                CType(field, MaskedTextBox).ReadOnly = True
            End If
            If field.GetType = GetType(NumericUpDown) Then
                CType(field, NumericUpDown).ReadOnly = True
            End If
            If field.GetType = GetType(ComboBox) Then
                CType(field, ComboBox).Enabled = False
            End If
        Next
    End Sub

    Public Sub disableReadOnlyFillable(ctrl As Control)
        For Each field As Control In ctrl.Controls
            If field.GetType = GetType(TextBox) Then
                CType(field, TextBox).ReadOnly = False
            End If
            If field.GetType = GetType(MaskedTextBox) Then
                CType(field, MaskedTextBox).ReadOnly = False
            End If
            If field.GetType = GetType(NumericUpDown) Then
                CType(field, NumericUpDown).ReadOnly = False
            End If
            If field.GetType = GetType(ComboBox) Then
                CType(field, ComboBox).Enabled = True
            End If
        Next
    End Sub

    Public Sub enableAllControls(ctrl As Control)
        For Each field As Control In ctrl.Controls
            If field.GetType = GetType(TextBox) Then
                CType(field, TextBox).Enabled = True
            End If
            If field.GetType = GetType(MaskedTextBox) Then
                CType(field, MaskedTextBox).Enabled = True
            End If
            If field.GetType = GetType(NumericUpDown) Then
                CType(field, NumericUpDown).Enabled = True
            End If
            If field.GetType = GetType(ComboBox) Then
                CType(field, ComboBox).Enabled = True
            End If
        Next
    End Sub

    Public Sub disableAllControls(ctrl As Control)
        For Each field As Control In ctrl.Controls
            If field.GetType = GetType(TextBox) Then
                CType(field, TextBox).Enabled = False
            End If
            If field.GetType = GetType(MaskedTextBox) Then
                CType(field, MaskedTextBox).Enabled = False
            End If
            If field.GetType = GetType(NumericUpDown) Then
                CType(field, NumericUpDown).Enabled = False
            End If
            If field.GetType = GetType(ComboBox) Then
                CType(field, ComboBox).Enabled = False
            End If
        Next
    End Sub

    Public Sub clearToDefault(ctrl As Control)
        For Each field As Control In ctrl.Controls
            If field.GetType = GetType(TextBox) Then
                CType(field, TextBox).Clear()
            End If
            If field.GetType = GetType(MaskedTextBox) Then
                CType(field, MaskedTextBox).Clear()
            End If
            If field.GetType = GetType(NumericUpDown) Then
                CType(field, NumericUpDown).Value = 1
            End If
            If field.GetType = GetType(ComboBox) Then

                Try
                    CType(field, ComboBox).SelectedIndex = 0
                Catch ex As ArgumentOutOfRangeException
                    If ex.Message.Contains("InvalidArgument=Value of '0' is not valid for 'SelectedIndex") Then
                        CType(field, ComboBox).Text = "ALL"
                    End If
                End Try

            End If
        Next
    End Sub

    Public Function matchCurrent_NewDetails(currentDetails() As String, newDetails() As String) As Boolean
        For i As Integer = 0 To currentDetails.Length - 1
            If (currentDetails.GetValue(i) <> newDetails.GetValue(i)) Then
                Return False
                Exit For
            End If
        Next
        Return True
    End Function

    Public Function validateEmail(email As String) As Boolean
        Dim regex As New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Dim isValid As Boolean = regex.IsMatch(email)
        Return isValid
    End Function

    'tracking history
    'account
    Public Property trackAccount_username As String
    Public Property trackAccount_firstname As String
    Public Property trackAccount_lastname As String
    Public Property trackAccount_phone As String
    Public Property trackAccount_email As String
    Public Property trackAccount_address As String

    'supplier
    Public Property tracking_Suppliername As String
    Public Property tracking_Supplieraddress As String
    Public Property tracking_Supplierphone As String
    Public Property tracking_Supplieremail As String
    Public Property tracking_SupplierotherDetails As String

    'customers
    Public Property trackCustomer_name As String
    Public Property trackCustomer_address As String
    Public Property trackCustomer_phone As String
    Public Property trackCustomer_tinID As String

    'category
    Public Property trackCategory_name As String

    'inventory
    'products
    Public Property trackProduct_itemCode As String
    Public Property trackProduct_name As String
    Public Property trackProduct_brand As String
    Public Property trackProduct_model As String
    Public Property trackProduct_category As String
    Public Property trackProduct_unit As String
    Public Property trackProduct_price As Decimal
    'inventory
    Public Property trackStock_serialNumber As String
    Public Property trackStock_atCost As Decimal
    Public Property trackStock_supplier As Long
    Public Property trackStock_suppliername As String

    'units
    Public Property trackUnit_name As String
End Module
