Imports System.Security.Cryptography
Imports System.Text

Public Class PasswordHelper
    Public Shared Function HashPassword(ByVal password As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes = Encoding.UTF8.GetBytes(password)
            Dim hash = sha.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function
End Class
