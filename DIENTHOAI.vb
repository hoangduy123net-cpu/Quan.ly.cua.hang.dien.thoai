Imports Microsoft.Data.SqlClient

Public Class DIENTHOAI
    Private Sub LoadData()
        OpenConnection()
        Dim sql As String = "SELECT * FROM DIEN_THOAI"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvDienThoai.DataSource = dt
        CloseConnection()
    End Sub
    Private Sub ClearTextBoxes()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If
        Next
    End Sub

    Private Sub BtThem_Click(sender As Object, e As EventArgs) Handles BtThem.Click
        OpenConnection()
        Dim sql As String = "INSERT INTO DIEN_THOAI(MaDienThoai, TenDienThoai, HangSanXuat, GiaBan, SoLuongTon) 
                             VALUES(@ma, @ten, @hang, @gia, @sl)"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ma", txtMaDT.Text)
        cmd.Parameters.AddWithValue("@ten", txtTenDT.Text)
        cmd.Parameters.AddWithValue("@hang", Hang.Text)
        cmd.Parameters.AddWithValue("@gia", Convert.ToDecimal(Giaban.Text))
        cmd.Parameters.AddWithValue("@sl", Convert.ToInt32(Soluongtonkho.Text))

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Thêm điện thoại thành công!")
            LoadData()
            ClearTextBoxes()
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
        CloseConnection()
    End Sub

    Private Sub BtXoa_Click(sender As Object, e As EventArgs) Handles BtXoa.Click
        OpenConnection()
        Dim sql As String = "DELETE FROM DIEN_THOAI WHERE MaDienThoai=@ma"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ma", txtMaDT.Text)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Xóa thành công!")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
        CloseConnection()
    End Sub

    Private Sub BtSua_Click(sender As Object, e As EventArgs) Handles BtSua.Click
        OpenConnection()
        Dim sql As String = "UPDATE DIEN_THOAI SET TenDienThoai=@ten, HangSanXuat=@hang, GiaBan=@gia, SoLuongTon=@sl WHERE MaDienThoai=@ma"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ma", txtMaDT.Text)
        cmd.Parameters.AddWithValue("@ten", txtTenDT.Text)
        cmd.Parameters.AddWithValue("@hang", Hang.Text)
        cmd.Parameters.AddWithValue("@gia", Convert.ToDecimal(Giaban.Text))
        cmd.Parameters.AddWithValue("@sl", Convert.ToInt32(Soluongtonkho.Text))

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Cập nhật thành công!")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
        CloseConnection()
    End Sub
    Private Sub BtMenu_Click(sender As Object, e As EventArgs) Handles BtMenu.Click
        ' Quay lại form chính (QLCUAHANGDIENTHOAI)
        Dim f As New QLCUAHANGDIENTHOAI
        f.Show()
        Me.Hide()
    End Sub
    Private Sub BtKhachHang_Click(sender As Object, e As EventArgs) Handles BtKhachHang.Click
        ' Mở form Khách hàng
        Dim f As New KHACHHANG
        f.Show()
        Me.Hide()
    End Sub

End Class