Imports Microsoft.Data.SqlClient

Module DatabaseModule

   Public ReadOnly connStr As String =
"Data Source=DESKTOP-ABC123\SQLEXPRESS;
Initial Catalog=quanlycuahangdienthoai;
Integrated Security=True;
TrustServerCertificate=True;"

    Public conn As New SqlConnection(connStr)

    Public Sub OpenConnection()
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
    End Sub

    Public Sub CloseConnection()
        If conn.State <> ConnectionState.Closed Then
            conn.Close()
        End If
    End Sub

End Module
