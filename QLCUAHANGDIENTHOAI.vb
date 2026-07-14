Public Class QLCUAHANGDIENTHOAI

    Private Sub btnKhachHang_Click(sender As Object, e As EventArgs) Handles btnKhachHang.Click
        Dim f As New KHACHHANG
        f.ShowDialog()
    End Sub

    Private Sub btnDienThoai_Click(sender As Object, e As EventArgs) Handles btnDienThoai.Click
        Dim f As New DIENTHOAI
        f.ShowDialog()
    End Sub

    Private Sub btnHoaDon_Click(sender As Object, e As EventArgs) Handles btnHoaDon.Click
        Dim f As New HOADON
        f.ShowDialog()
    End Sub

    Private Sub btnCTHoaDon_Click(sender As Object, e As EventArgs) Handles btnCTHoaDon.Click
        Dim f As New CHITIETHOADON
        f.ShowDialog()
    End Sub

    Private Sub btnDangXuat_Click(sender As Object, e As EventArgs) Handles btnDangXuat.Click
        Dim result As DialogResult

        result = MessageBox.Show(
            "Bạn có muốn đăng xuất không?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Me.Hide()

            Dim f As New DANGNHAP
            f.Show()
            Me.Close()

        End If
    End Sub

End Class