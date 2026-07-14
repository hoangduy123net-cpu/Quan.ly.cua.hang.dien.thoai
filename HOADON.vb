Imports Microsoft.Data.SqlClient

Public Class HOADON
    Dim da As SqlDataAdapter
    Dim dt As DataTable

    Private Sub HOADON_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            OpenConnection()

            LoadKhachHang()

            LoadHoaDon()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadKhachHang()
        Dim sql As String = "SELECT MaKhachHang, HoTen FROM KHACH_HANG"
        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable()
        da.Fill(dt)
        cboMaKH.DataSource = dt
        cboMaKH.DisplayMember = "HoTen"
        cboMaKH.ValueMember = "MaKhachHang"
    End Sub

    Private Sub LoadHoaDon()
        Dim sql As String = "SELECT * FROM HOA_DON"
        da = New SqlDataAdapter(sql, conn)
        dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim sql As String = "INSERT INTO HOA_DON(MaHoaDon, MaKhachHang, NgayLap) VALUES (@MaHD, @MaKH, @NgayLap)"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
        cmd.Parameters.AddWithValue("@MaKH", cboMaKH.SelectedValue)
        cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value)
        cmd.ExecuteNonQuery()
        LoadHoaDon()
        MessageBox.Show("Thêm hóa đơn thành công!")
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim sql As String = "UPDATE HOA_DON SET MaKhachHang=@MaKH, NgayLap=@NgayLap,  WHERE MaHoaDon=@MaHD"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
        cmd.Parameters.AddWithValue("@MaKH", cboMaKH.SelectedValue)
        cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value)
        cmd.ExecuteNonQuery()
        LoadHoaDon()
        MessageBox.Show("Cập nhật hóa đơn thành công!")
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim sql As String = "DELETE FROM HOA_DON WHERE MaHoaDon=@MaHD"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
        cmd.ExecuteNonQuery()
        LoadHoaDon()
        MessageBox.Show("Xóa hóa đơn thành công!")
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        LoadHoaDon()
    End Sub
End Class
