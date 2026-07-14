Imports System.Data
Imports Microsoft.Data.SqlClient


Public Class DANGKY
    Private Sub BtDangky_Click(sender As Object, e As EventArgs) Handles BtDangky.Click
        OpenConnection()
        Dim sql As String = "INSERT INTO NguoiDung(TenDangNhap, MatKhau) VALUES(@tk, @mk)"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@tk", txtTenTK.Text)
        cmd.Parameters.AddWithValue("@mk", txtMK.Text)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Đăng ký thành công!")
            Me.Hide()
            DANGNHAP.Show()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi đăng ký: " & ex.Message)
        End Try
        CloseConnection()
    End Sub
    Private Sub BtThoat_Click(sender As Object, e As EventArgs) Handles BtThoat.Click
        DANGNHAP.Show()
        Me.Close()
    End Sub
End Class
