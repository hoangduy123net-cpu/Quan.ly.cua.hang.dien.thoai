<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KHACHHANG
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgvKhachHang = New DataGridView()
        BtThem = New Button()
        BtSua = New Button()
        BtXoa = New Button()
        BtTimKiem = New Button()
        BtLuu = New Button()
        BtMenu = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtTenKH = New TextBox()
        txtMaKH = New TextBox()
        diachi = New TextBox()
        txtSDT = New TextBox()
        Label5 = New Label()
        ngaysinh = New DateTimePicker()
        BtDienThoai = New Button()
        CType(dgvKhachHang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvKhachHang
        ' 
        dgvKhachHang.BackgroundColor = SystemColors.Control
        dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKhachHang.Location = New Point(57, 30)
        dgvKhachHang.Name = "dgvKhachHang"
        dgvKhachHang.RowHeadersWidth = 51
        dgvKhachHang.Size = New Size(801, 188)
        dgvKhachHang.TabIndex = 0
        ' 
        ' BtThem
        ' 
        BtThem.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtThem.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        BtThem.Location = New Point(57, 236)
        BtThem.Name = "BtThem"
        BtThem.Size = New Size(103, 44)
        BtThem.TabIndex = 5
        BtThem.Text = "Thêm"
        BtThem.UseVisualStyleBackColor = True
        ' 
        ' BtSua
        ' 
        BtSua.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtSua.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        BtSua.Location = New Point(198, 236)
        BtSua.Name = "BtSua"
        BtSua.Size = New Size(103, 44)
        BtSua.TabIndex = 6
        BtSua.Text = "Sửa"
        BtSua.UseVisualStyleBackColor = True
        ' 
        ' BtXoa
        ' 
        BtXoa.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtXoa.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BtXoa.Location = New Point(340, 236)
        BtXoa.Name = "BtXoa"
        BtXoa.Size = New Size(103, 44)
        BtXoa.TabIndex = 7
        BtXoa.Text = "Xoá"
        BtXoa.UseVisualStyleBackColor = True
        ' 
        ' BtTimKiem
        ' 
        BtTimKiem.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtTimKiem.ForeColor = Color.Navy
        BtTimKiem.Location = New Point(515, 236)
        BtTimKiem.Name = "BtTimKiem"
        BtTimKiem.Size = New Size(103, 44)
        BtTimKiem.TabIndex = 8
        BtTimKiem.Text = "Tìm kiếm"
        BtTimKiem.UseVisualStyleBackColor = True
        ' 
        ' BtLuu
        ' 
        BtLuu.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtLuu.ForeColor = Color.Navy
        BtLuu.Location = New Point(665, 236)
        BtLuu.Name = "BtLuu"
        BtLuu.Size = New Size(103, 44)
        BtLuu.TabIndex = 9
        BtLuu.Text = "Lưu"
        BtLuu.UseVisualStyleBackColor = True
        ' 
        ' BtMenu
        ' 
        BtMenu.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtMenu.ForeColor = Color.Maroon
        BtMenu.Location = New Point(817, 236)
        BtMenu.Name = "BtMenu"
        BtMenu.Size = New Size(103, 44)
        BtMenu.TabIndex = 10
        BtMenu.Text = "Menu"
        BtMenu.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 324)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 20)
        Label1.TabIndex = 11
        Label1.Text = "Tên khách hàng:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(57, 398)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 20)
        Label2.TabIndex = 12
        Label2.Text = "Mã khách hàng:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(515, 321)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 20)
        Label3.TabIndex = 13
        Label3.Text = "Ngày sinh:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(515, 401)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 20)
        Label4.TabIndex = 14
        Label4.Text = "Địa chỉ:"
        ' 
        ' txtTenKH
        ' 
        txtTenKH.Location = New Point(198, 321)
        txtTenKH.Multiline = True
        txtTenKH.Name = "txtTenKH"
        txtTenKH.Size = New Size(205, 34)
        txtTenKH.TabIndex = 15
        ' 
        ' txtMaKH
        ' 
        txtMaKH.Location = New Point(198, 387)
        txtMaKH.Multiline = True
        txtMaKH.Name = "txtMaKH"
        txtMaKH.Size = New Size(205, 34)
        txtMaKH.TabIndex = 16
        ' 
        ' diachi
        ' 
        diachi.Location = New Point(633, 387)
        diachi.Multiline = True
        diachi.Name = "diachi"
        diachi.Size = New Size(205, 34)
        diachi.TabIndex = 18
        ' 
        ' txtSDT
        ' 
        txtSDT.Location = New Point(1004, 310)
        txtSDT.Multiline = True
        txtSDT.Name = "txtSDT"
        txtSDT.Size = New Size(205, 34)
        txtSDT.TabIndex = 20
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(886, 324)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 20)
        Label5.TabIndex = 19
        Label5.Text = "Số điện thoại:"
        ' 
        ' ngaysinh
        ' 
        ngaysinh.Location = New Point(608, 319)
        ngaysinh.Name = "ngaysinh"
        ngaysinh.Size = New Size(250, 27)
        ngaysinh.TabIndex = 21
        ' 
        ' BtDienThoai
        ' 
        BtDienThoai.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtDienThoai.ForeColor = Color.Tomato
        BtDienThoai.Location = New Point(959, 236)
        BtDienThoai.Name = "BtDienThoai"
        BtDienThoai.Size = New Size(125, 44)
        BtDienThoai.TabIndex = 22
        BtDienThoai.Text = "ĐIỆN THOẠI"
        BtDienThoai.UseVisualStyleBackColor = True
        ' 
        ' KHACHHANG
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1313, 505)
        Controls.Add(BtDienThoai)
        Controls.Add(ngaysinh)
        Controls.Add(txtSDT)
        Controls.Add(Label5)
        Controls.Add(diachi)
        Controls.Add(txtMaKH)
        Controls.Add(txtTenKH)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtMenu)
        Controls.Add(BtLuu)
        Controls.Add(BtTimKiem)
        Controls.Add(BtXoa)
        Controls.Add(BtSua)
        Controls.Add(BtThem)
        Controls.Add(dgvKhachHang)
        Name = "KHACHHANG"
        Text = "Danh sách khách hàng"
        CType(dgvKhachHang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvKhachHang As DataGridView
    Friend WithEvents BtThem As Button
    Friend WithEvents BtSua As Button
    Friend WithEvents BtXoa As Button
    Friend WithEvents BtTimKiem As Button
    Friend WithEvents BtLuu As Button
    Friend WithEvents BtMenu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents diachi As TextBox
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ngaysinh As DateTimePicker
    Friend WithEvents BtDienThoai As Button
End Class
