Imports Microsoft.Data.SqlClient
Public Class CHITIETHOADON
    Private Sub CHITIETHOADON_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabaseModule.OpenConnection()
        LoadHoaDon()
        LoadDienThoai()
    End Sub


    Sub LoadHoaDon()
        Dim sql As String = "SELECT MaHoaDon FROM HOA_DON"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        da.Fill(dt)
        cboMaHD.DataSource = dt
        cboMaHD.DisplayMember = "MaHoaDon"
        cboMaHD.ValueMember = "MaHoaDon"
    End Sub

    Sub LoadDienThoai()
        Dim sql As String = "SELECT MaDienThoai, TenDienThoai FROM DIEN_THOAI"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        da.Fill(dt)
        cboMaDT.DataSource = dt
        cboMaDT.DisplayMember = "TenDienThoai"
        cboMaDT.ValueMember = "MaDienThoai"
    End Sub
    Private Sub BtThem_Click(sender As Object, e As EventArgs) Handles BtThem.Click
        Try
            Dim sql As String = "INSERT INTO CHI_TIET_HOA_DON (MaHoaDon, MaDienThoai, SoLuong, ThanhTien) VALUES (@MaHoaD, @MaDienThoai, @SoLuong, @ThanhTien)"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaHoaDon", cboMaHD.SelectedValue)
            cmd.Parameters.AddWithValue("@MaDienThoai", cboMaDT.SelectedValue)
            cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            cmd.Parameters.AddWithValue("@ThanhTien", txtThanhTien.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Đã thêm chi tiết hóa đơn thành công!")
        Catch ex As Exception
            MessageBox.Show(" Lỗi khi thêm dữ liệu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class