Imports Microsoft.Data.SqlClient

Public Class KHACHHANG
    Private Sub LoadData()
        OpenConnection()
        Dim sql As String = "SELECT * FROM KHACH_HANG"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvKhachHang.DataSource = dt
        CloseConnection()
    End Sub
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles BtTimKiem.Click
        LoadData()
    End Sub

    Private Sub BtThem_Click(sender As Object, e As EventArgs) Handles BtThem.Click
        OpenConnection()
        Dim sql As String = "INSERT INTO KHACH_HANG(MaKhachHang, HoTen, SoDienThoai, Email, DiaChi) 
                             VALUES(@ma, @ten, @sodt, @email, @dc)"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ma", txtMaKH.Text)
        cmd.Parameters.AddWithValue("@ten", txtTenKH.Text)
        cmd.Parameters.AddWithValue("@sodt", TxtSDT.Text)
        cmd.Parameters.AddWithValue("@email", (ngaysinh.Text))
        cmd.Parameters.AddWithValue("@dc", (diachi.Text))

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Thêm khách hàng thành công!")
            LoadData()
            ClearTextBoxes()
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
        CloseConnection()
    End Sub


    Private Sub BtXoa_Click(sender As Object, e As EventArgs) Handles BtXoa.Click
        OpenConnection()
        Dim sql As String = "DELETE FROM KHACH_HANG WHERE MaKhachHang=@ma"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ma", txtMaKH.Text)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Xóa thành công!")
            LoadData()
            ClearTextBoxes()
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
        CloseConnection()
    End Sub

    Private Sub BtSua_Click(sender As Object, e As EventArgs) Handles BtSua.Click
        OpenConnection()
        Dim sql As String = "UPDATE KHACH_HANG SET HoTen=@ten, SoDienThoai=@sodt, Email=@email, DiaChi=@dc WHERE MaKhachHang=@ma"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ma", txtMaKH.Text)
        cmd.Parameters.AddWithValue("@ten", txtTenKH.Text)
        cmd.Parameters.AddWithValue("@sodt", txtSDT.Text)
        cmd.Parameters.AddWithValue("@email", (ngaysinh.Text))
        cmd.Parameters.AddWithValue("@dc", (diachi.Text))

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Cập nhật thành công!")
            LoadData()
            ClearTextBoxes()
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
        CloseConnection()
    End Sub
    Private Sub ClearTextBoxes()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If
        Next
    End Sub

    Private Sub BtTimKiem_Click(sender As Object, e As EventArgs) Handles BtTimKiem.Click
        Using conn As New SqlConnection("Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=quanlycuahangdienthoai;Integrated Security=True;TrustServerCertificate=True")
            conn.Open()
            Dim sql As String = "SELECT * FROM KHACH_HANG WHERE MaKhachHang = @Ma"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Ma", txtMaKH.Text)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvKhachHang.DataSource = table
            ClearTextBoxes()
        End Using
    End Sub
    Private Sub BtMenu_Click(sender As Object, e As EventArgs) Handles BtMenu.Click
        Dim f As New QLCUAHANGDIENTHOAI()
        f.Show()
        Me.Hide()
    End Sub
    Private Sub BtDienThoai_Click(sender As Object, e As EventArgs) Handles BtDienThoai.Click
        Dim f As New DIENTHOAI()
        f.Show()
        Me.Hide()
    End Sub
End Class