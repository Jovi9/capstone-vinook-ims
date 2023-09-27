Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class userFunction : Inherits database
    Dim com As MySqlCommand
    Dim reader As MySqlDataReader

    Private _firstName As String
    Private _lastName As String
    Private _phone As String
    Private _email As String
    Private _address As String
    Private _content As String

    Private _newContent
    Private new_firstName As String
    Private new_lastName As String
    Private new_phone As String
    Private new_email As String
    Private new_address As String

    Public Function generateOTP() As String
        Const lowerLetter As String = "abcdefghijklmnopqrstuvwxyz"
        Dim alphaNumeric() As Char = (lowerLetter & lowerLetter.ToUpper & "0123456789").ToCharArray
        Dim otpResult As New StringBuilder
        Dim rand As New Random
        For i As Integer = 0 To 5
            otpResult.Append(alphaNumeric(rand.Next(alphaNumeric.Length)))
        Next
        Return otpResult.ToString
    End Function

#Region "->Forgot Password by SMS"
    Public Function sendOTP_SMS(phoneNumber As String, verificationCode As String)
        Using client As New Net.WebClient
            Dim parameter As New Specialized.NameValueCollection
            Dim url As String = "https://semaphore.co/api/v4/messages"
            parameter.Add("apikey", "33c3c09e6077de95c7d2e50d4c52657b")
            parameter.Add("number", phoneNumber)
            parameter.Add("message", "ViNOOK Inventory Verification Code: " & verificationCode & ". This code is only valid for 10 minutes.")
            parameter.Add("sendername", "SEMAPHORE")
            Dim rpb = client.UploadValues(url, "POST", parameter)
            sendOTP_SMS = (New System.Text.UTF8Encoding).GetString(rpb)
        End Using
    End Function
#End Region

#Region "->Forgot Password by Email"
    Public Function verifyEmail(email As String) As Boolean
        Try
            openConnection()
            Dim que As String = "select email from user_accounts where email=@email"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@email", MySqlDbType.VarChar).Value = email
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                Return True
            Else
                Return False
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Email Verify Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Function

    Public Sub sendOTP_ToMail(emailAddress As String, otp As String)
        Try
            Dim email As New MailMessage
            With email
                .From = New MailAddress("jvtechservices20@gmail.com")
                .To.Add(emailAddress)
                .Subject = "ViNOOK Inventory Forgot Password"
                .Body = $"ViNOOK Inventory Verification" &
                        Environment.NewLine &
                        Environment.NewLine &
                        "Code: " & otp &
                        Environment.NewLine &
                        "A verification code was requested using your account. If this was you, please use the code above. The code is valid for 10 minutes."
                .IsBodyHtml = False
            End With

            Dim smtp_server As New SmtpClient("smtp.gmail.com")
            With smtp_server
                .UseDefaultCredentials = False
                .DeliveryMethod = SmtpDeliveryMethod.Network
                .Credentials = New Net.NetworkCredential("jvtechservices20@gmail.com", "cjuwmiccqmapmxgt")
                .Port = 587
                .EnableSsl = True
            End With
            smtp_server.Send(email)
            customMessageBox.show("Verification Code was sent to " & emailAddress, "Verification Code", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Recovery Send Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub updateOTP_byEmail(user As userModel)
        Try
            openConnection()
            Dim que As String = "update user_accounts set recovery_code=sha2(@code, 512), code_expire=@expiry where email=@email "
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@email", MySqlDbType.VarChar).Value = user.email
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = user.recoverycode
                .Parameters.Add("@expiry", MySqlDbType.DateTime).Value = Date.Now.AddMinutes(10)
            End With
            com.ExecuteNonQuery()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Recovery Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub

    Public Sub getUsername_byEmail(email As String)
        Try
            openConnection()
            Dim que As String = "select username from user_accounts where email=@email"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@email", MySqlDbType.VarChar).Value = email
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                session_username = reader("username")
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Function getExpiryDate(email As String, verification As String) As Date
        Dim expireDate As Date
        Try
            openConnection()
            Dim que As String = "select code_expire from user_accounts where email=@email and recovery_code=sha2(@code, 512)"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@email", MySqlDbType.VarChar).Value = email
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = verification
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                expireDate = reader("code_expire")
            End If
            Return expireDate
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Expire Code Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return expireDate
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Function

    Public Function verifyOTP(user As userModel) As Boolean
        Try
            openConnection()
            Dim que As String = "select recovery_code from user_accounts where email=@email and recovery_code=sha2(@code, 512)"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@email", MySqlDbType.VarChar).Value = user.email
                .Parameters.Add("@code", MySqlDbType.VarChar).Value = user.recoverycode
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                Return True
            Else
                Return False
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Recovery Verify Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Function

    Public Function changePassword_byEmail(user As userModel) As Boolean
        Try
            openConnection()
            user.updated_at = Date.Now
            Dim que As String = "update user_accounts set userpassword=sha2(@pass, 512), updated_at=@updated where email=@email"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@email", MySqlDbType.VarChar).Value = user.email
                .Parameters.Add("@pass", MySqlDbType.VarChar).Value = user.userpassword
                .Parameters.Add("@updated", MySqlDbType.DateTime).Value = user.updated_at
            End With

            _content = "Changed Password."
            Dim modelHistory As New historyModel(session_username, "UPDATE", "ACCOUNT", _content, user.updated_at)
            Dim funcHistory As New historyFunction

            If com.ExecuteNonQuery = 1 Then
                funcHistory.addToHistory(modelHistory)
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            closeConnection()
        End Try
    End Function

#End Region

    Public Function changePassword(user As userModel) As Boolean
        Try
            openConnection()
            user.updated_at = Date.Now
            Dim que As String = "update user_accounts set userpassword=sha2(@pass, 512), updated_at=@updated where username=@username"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@username", MySqlDbType.VarChar).Value = user.username
                .Parameters.Add("@pass", MySqlDbType.VarChar).Value = user.userpassword
                .Parameters.Add("@updated", MySqlDbType.DateTime).Value = user.updated_at
            End With

            _content = "Changed Password."
            Dim modelHistory As New historyModel(session_username, "UPDATE", "ACCOUNT", _content, user.updated_at)
            Dim funcHistory As New historyFunction

            If com.ExecuteNonQuery = 1 Then
                funcHistory.addToHistory(modelHistory)
                Return True
            Else
                Return False
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            closeConnection()
        End Try
    End Function

    Public Function updateAccountDetails(user As userModel) As Boolean
        Try
            openConnection()
            user.updated_at = Date.Now
            Dim que As String = "update user_accounts set first_name=@fname, last_name=@lname, phone=@phone, email=@email, address=@address, updated_at=@updated where username=@username"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@username", MySqlDbType.VarChar).Value = user.username
                .Parameters.Add("@fname", MySqlDbType.VarChar).Value = user.firstname
                .Parameters.Add("@lname", MySqlDbType.VarChar).Value = user.lastname
                .Parameters.Add("@phone", MySqlDbType.VarChar).Value = user.phone
                .Parameters.Add("@email", MySqlDbType.VarChar).Value = user.email
                .Parameters.Add("@address", MySqlDbType.VarChar).Value = user.address
                .Parameters.Add("@updated", MySqlDbType.DateTime).Value = user.updated_at
            End With

            If String.Equals(trackAccount_firstname, user.firstname) Then
                _firstName = "First Name: " & trackAccount_firstname & Environment.NewLine
            Else
                _firstName = "First Name: " & trackAccount_firstname & Environment.NewLine
                new_firstName = "First Name: " & user.firstname & Environment.NewLine
            End If
            If String.Equals(trackAccount_lastname, user.lastname) Then
                _lastName = "Last Name: " & trackAccount_lastname & Environment.NewLine
            Else
                _lastName = "Last Name: " & trackAccount_lastname & Environment.NewLine
                new_lastName = "Last Name: " & user.lastname & Environment.NewLine
            End If
            If String.Equals(trackAccount_phone, user.phone) Then
                _phone = ""
            Else
                If trackAccount_phone = "" Then
                    trackAccount_phone = "None"
                End If
                If user.phone = "" Then
                    user.phone = "None"
                End If
                _phone = "Phone: " & trackAccount_phone & Environment.NewLine
                new_phone = "Phone: " & user.phone & Environment.NewLine
            End If
            If String.Equals(trackAccount_email, user.email) Then
                _email = ""
            Else
                If trackAccount_email = "" Then
                    trackAccount_email = "None"
                End If
                If user.email = "" Then
                    user.email = "None"
                End If
                _email = "Email: " & trackAccount_email & Environment.NewLine
                new_email = "Email: " & user.email & Environment.NewLine
            End If
            If String.Equals(trackAccount_address, user.address) Then
                _address = ""
            Else
                If trackAccount_address = "" Then
                    trackAccount_address = "None"
                End If
                If user.address = "" Then
                    user.address = "None"
                End If
                _address = "Address: " & trackAccount_address & Environment.NewLine
                new_address = "Address: " & user.address & Environment.NewLine
            End If

            _content = user.username & Environment.NewLine & _firstName & _lastName & _phone & _email & _address
            _newContent = new_firstName & new_lastName & new_phone & new_email & new_address

            Dim modelHistory As New historyModel(session_username, "UPDATE", "ACCOUNT", _content, _newContent, user.updated_at)
            Dim funcHistory As New historyFunction

            If com.ExecuteNonQuery = 1 Then
                funcHistory.addToHistory(modelHistory)
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            closeConnection()
        End Try
    End Function

    Public Sub getAccountDetails(user As userModel)
        Try
            openConnection()
            Dim que As String = "select username, first_name, last_name, phone, email, address, role from user_accounts where username=@user"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@user", MySqlDbType.VarChar).Value = user.username
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                user.username = reader("username")
                user.firstname = reader("first_name")
                user.lastname = reader("last_name")
                user.name = user.firstname & " " & user.lastname
                user.phone = reader("phone").ToString
                user.email = reader("email").ToString
                user.address = reader("address").ToString
                If reader("role") = 0 Then
                    user.role = "Administrator"
                ElseIf reader("role") = 1 Then
                    user.role = "Cashier"
                End If
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Function verifyLoginCredential(user As userModel) As Boolean
        Try
            openConnection()
            Dim que As String = "select first_name, last_name, username, userpassword, role from user_accounts where username=@user and userpassword=sha2(@password, 512) and not deleted"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@user", MySqlDbType.VarChar).Value = user.username
                .Parameters.Add("@password", MySqlDbType.String).Value = user.userpassword
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                session_firstname = reader(0)
                session_lastname = reader(1)
                session_username = reader(2)
                session_role = reader(4)
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            reader.Close()
            closeConnection()
        End Try
    End Function

    Public Sub updateLoginTime(username As String)
        Try
            openConnection()
            Dim que As String = "update user_accounts set last_login_at=@current where username=@username"
            com = New MySqlCommand(que, condb)
            With com
                .Parameters.Add("@current", MySqlDbType.DateTime).Value = Date.Now
                .Parameters.Add("@username", MySqlDbType.VarChar).Value = username
            End With
            com.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Failed Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub
End Class

