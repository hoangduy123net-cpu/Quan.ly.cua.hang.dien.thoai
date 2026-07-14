
Imports Microsoft.Data.SqlClient

Public Class DANGNHAP

    Private Sub BtDangNhap_Click(sender As Object, e As EventArgs) Handles BtDangNhap.Click
        ' Chuỗi kết nối
        Dim connStr As String = "Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=quanlycuahangdienthoai;Integrated Security=True;TrustServerCertificate=True"

        Using conn As New SqlConnection(connStr)
            Try
                conn.Open()

                Dim sql As String = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap=@tk AND MatKhau=@mk"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@tk", TxtTenDN.Text)
                    cmd.Parameters.AddWithValue("@mk", TxtPass.Text)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Đăng nhập thành công!")
                        ' Mở form chính
                        Dim f As New QLCUAHANGDIENTHOAI()
                        f.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!")
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Lỗi kết nối: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub BtDangKy_Click(sender As Object, e As EventArgs) Handles BtDangKy.Click

        Me.Hide()

        Dim f As New DANGKY()
        f.ShowDialog()

        Me.Show()
    End Sub
    Private Sub BtExit_Click(sender As Object, e As EventArgs) Handles BtExit.Click
        Application.Exit()

    End Sub
End Class
