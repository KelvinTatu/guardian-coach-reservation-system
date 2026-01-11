Imports MySql.Data.MySqlClient

Public Class DBHelper
    Private Shared connString As String = "server=localhost;userid=root;password=;database=bus_booking;SslMode=None"

    Public Shared Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connString)
    End Function
End Class
