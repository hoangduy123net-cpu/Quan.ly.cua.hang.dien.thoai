<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DIENTHOAI
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
        Giaban = New TextBox()
        Hang = New TextBox()
        txtMaDT = New TextBox()
        txtTenDT = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        BtThoat = New Button()
        BtXoa = New Button()
        BtSua = New Button()
        BtThem = New Button()
        Soluongtonkho = New TextBox()
        Label5 = New Label()
        dgvDienThoai = New DataGridView()
        BtMenu = New Button()
        BtKhachHang = New Button()
        Panel1 = New Panel()
        CType(dgvDienThoai, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Giaban
        ' 
        Giaban.Location = New Point(745, 517)
        Giaban.Multiline = True
        Giaban.Name = "Giaban"
        Giaban.Size = New Size(205, 34)
        Giaban.TabIndex = 37
        ' 
        ' Hang
        ' 
        Hang.Location = New Point(745, 440)
        Hang.Multiline = True
        Hang.Name = "Hang"
        Hang.Size = New Size(205, 34)
        Hang.TabIndex = 36
        ' 
        ' txtMaDT
        ' 
        txtMaDT.Location = New Point(310, 517)
        txtMaDT.Multiline = True
        txtMaDT.Name = "txtMaDT"
        txtMaDT.Size = New Size(205, 34)
        txtMaDT.TabIndex = 35
        ' 
        ' txtTenDT
        ' 
        txtTenDT.Location = New Point(310, 451)
        txtTenDT.Multiline = True
        txtTenDT.Name = "txtTenDT"
        txtTenDT.Size = New Size(205, 34)
        txtTenDT.TabIndex = 34
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(627, 531)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 20)
        Label4.TabIndex = 33
        Label4.Text = "Giá bán:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(627, 451)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 32
        Label3.Text = "Hãng:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(169, 528)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 31
        Label2.Text = "Mã điện thoại:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(169, 454)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 20)
        Label1.TabIndex = 30
        Label1.Text = "Tên điện thoại:"
        ' 
        ' BtThoat
        ' 
        BtThoat.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtThoat.ForeColor = Color.Maroon
        BtThoat.Location = New Point(1025, 489)
        BtThoat.Name = "BtThoat"
        BtThoat.Size = New Size(103, 44)
        BtThoat.TabIndex = 29
        BtThoat.Text = "Thoát"
        BtThoat.UseVisualStyleBackColor = True
        ' 
        ' BtXoa
        ' 
        BtXoa.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtXoa.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BtXoa.Location = New Point(683, 360)
        BtXoa.Name = "BtXoa"
        BtXoa.Size = New Size(103, 44)
        BtXoa.TabIndex = 26
        BtXoa.Text = "Xoá"
        BtXoa.UseVisualStyleBackColor = True
        ' 
        ' BtSua
        ' 
        BtSua.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtSua.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        BtSua.Location = New Point(429, 360)
        BtSua.Name = "BtSua"
        BtSua.Size = New Size(103, 44)
        BtSua.TabIndex = 25
        BtSua.Text = "Sửa"
        BtSua.UseVisualStyleBackColor = True
        ' 
        ' BtThem
        ' 
        BtThem.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtThem.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        BtThem.Location = New Point(158, 360)
        BtThem.Name = "BtThem"
        BtThem.Size = New Size(103, 44)
        BtThem.TabIndex = 24
        BtThem.Text = "Thêm"
        BtThem.UseVisualStyleBackColor = True
        ' 
        ' Soluongtonkho
        ' 
        Soluongtonkho.Location = New Point(745, 607)
        Soluongtonkho.Multiline = True
        Soluongtonkho.Name = "Soluongtonkho"
        Soluongtonkho.Size = New Size(205, 34)
        Soluongtonkho.TabIndex = 39
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(627, 621)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 20)
        Label5.TabIndex = 38
        Label5.Text = "Số lượng tồn kho:"
        ' 
        ' dgvDienThoai
        ' 
        dgvDienThoai.BackgroundColor = SystemColors.ActiveCaption
        dgvDienThoai.ColumnHeadersHeight = 29
        dgvDienThoai.GridColor = SystemColors.HotTrack
        dgvDienThoai.Location = New Point(20, 14)
        dgvDienThoai.Name = "dgvDienThoai"
        dgvDienThoai.RowHeadersWidth = 51
        dgvDienThoai.Size = New Size(929, 257)
        dgvDienThoai.TabIndex = 0
        ' 
        ' BtMenu
        ' 
        BtMenu.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtMenu.ForeColor = Color.Maroon
        BtMenu.Location = New Point(1025, 410)
        BtMenu.Name = "BtMenu"
        BtMenu.Size = New Size(103, 44)
        BtMenu.TabIndex = 40
        BtMenu.Text = "Menu"
        BtMenu.UseVisualStyleBackColor = True
        ' 
        ' BtKhachHang
        ' 
        BtKhachHang.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtKhachHang.ForeColor = Color.Maroon
        BtKhachHang.Location = New Point(1012, 579)
        BtKhachHang.Name = "BtKhachHang"
        BtKhachHang.Size = New Size(139, 44)
        BtKhachHang.TabIndex = 42
        BtKhachHang.Text = "KHÁCH HÀNG"
        BtKhachHang.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(dgvDienThoai)
        Panel1.Location = New Point(87, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(972, 288)
        Panel1.TabIndex = 43
        ' 
        ' DIENTHOAI
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1196, 716)
        Controls.Add(Panel1)
        Controls.Add(BtKhachHang)
        Controls.Add(BtMenu)
        Controls.Add(Soluongtonkho)
        Controls.Add(Label5)
        Controls.Add(Giaban)
        Controls.Add(Hang)
        Controls.Add(txtMaDT)
        Controls.Add(txtTenDT)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtThoat)
        Controls.Add(BtXoa)
        Controls.Add(BtSua)
        Controls.Add(BtThem)
        Name = "DIENTHOAI"
        Text = "DIENTHOAI"
        CType(dgvDienThoai, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Giaban As TextBox
    Friend WithEvents Hang As TextBox
    Friend WithEvents txtMaDT As TextBox
    Friend WithEvents txtTenDT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtThoat As Button
    Friend WithEvents BtXoa As Button
    Friend WithEvents BtSua As Button
    Friend WithEvents BtThem As Button
    Friend WithEvents Soluongtonkho As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvDienThoai As DataGridView
    Friend WithEvents BtMenu As Button
    Friend WithEvents BtKhachHang As Button
    Friend WithEvents Panel1 As Panel
End Class
