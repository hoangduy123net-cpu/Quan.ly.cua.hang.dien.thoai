Imports Microsoft.Data.SqlClient

Module DatabaseModule

   Public ReadOnly connStr As String =
"Data Source=(LocalDB)\MSSQLLocalDB;" &
"AttachDbFilename=|DataDirectory|\quanlycuahangdienthoai.mdf;" &
"Integrated Security=True"

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
