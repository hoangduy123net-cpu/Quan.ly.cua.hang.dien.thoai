<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLCUAHANGDIENTHOAI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QLCUAHANGDIENTHOAI))
        Panel1 = New Panel()
        btnDangXuat = New Button()
        btnCTHoaDon = New Button()
        btnKhachHang = New Button()
        btnDienThoai = New Button()
        btnHoaDon = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(btnDangXuat)
        Panel1.Controls.Add(btnCTHoaDon)
        Panel1.Controls.Add(btnKhachHang)
        Panel1.Controls.Add(btnDienThoai)
        Panel1.Controls.Add(btnHoaDon)
        Panel1.Location = New Point(0, 316)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1164, 138)
        Panel1.TabIndex = 1
        ' 
        ' btnDangXuat
        ' 
        btnDangXuat.BackColor = Color.Azure
        btnDangXuat.FlatAppearance.BorderColor = Color.Black
        btnDangXuat.FlatStyle = FlatStyle.Flat
        btnDangXuat.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        btnDangXuat.ForeColor = Color.Black
        btnDangXuat.Image = CType(resources.GetObject("btnDangXuat.Image"), Image)
        btnDangXuat.ImageAlign = ContentAlignment.TopCenter
        btnDangXuat.Location = New Point(911, 18)
        btnDangXuat.Name = "btnDangXuat"
        btnDangXuat.Padding = New Padding(5)
        btnDangXuat.Size = New Size(174, 112)
        btnDangXuat.TabIndex = 4
        btnDangXuat.Text = "Đăng xuất"
        btnDangXuat.TextAlign = ContentAlignment.BottomCenter
        btnDangXuat.TextImageRelation = TextImageRelation.ImageAboveText
        btnDangXuat.UseCompatibleTextRendering = True
        btnDangXuat.UseVisualStyleBackColor = False
        ' 
        ' btnCTHoaDon
        ' 
        btnCTHoaDon.BackColor = Color.Azure
        btnCTHoaDon.FlatAppearance.BorderColor = Color.Black
        btnCTHoaDon.FlatStyle = FlatStyle.Flat
        btnCTHoaDon.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        btnCTHoaDon.ForeColor = Color.Black
        btnCTHoaDon.Image = CType(resources.GetObject("btnCTHoaDon.Image"), Image)
        btnCTHoaDon.ImageAlign = ContentAlignment.TopCenter
        btnCTHoaDon.Location = New Point(696, 18)
        btnCTHoaDon.Name = "btnCTHoaDon"
        btnCTHoaDon.Padding = New Padding(5)
        btnCTHoaDon.Size = New Size(174, 112)
        btnCTHoaDon.TabIndex = 3
        btnCTHoaDon.Text = "Hoá đơn chi tiết"
        btnCTHoaDon.TextAlign = ContentAlignment.BottomCenter
        btnCTHoaDon.TextImageRelation = TextImageRelation.ImageAboveText
        btnCTHoaDon.UseCompatibleTextRendering = True
        btnCTHoaDon.UseVisualStyleBackColor = False
        ' 
        ' btnKhachHang
        ' 
        btnKhachHang.BackColor = Color.Azure
        btnKhachHang.FlatAppearance.BorderColor = Color.Black
        btnKhachHang.FlatStyle = FlatStyle.Flat
        btnKhachHang.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        btnKhachHang.ForeColor = Color.Black
        btnKhachHang.Image = CType(resources.GetObject("btnKhachHang.Image"), Image)
        btnKhachHang.ImageAlign = ContentAlignment.TopCenter
        btnKhachHang.Location = New Point(44, 18)
        btnKhachHang.Name = "btnKhachHang"
        btnKhachHang.Padding = New Padding(5)
        btnKhachHang.Size = New Size(174, 112)
        btnKhachHang.TabIndex = 0
        btnKhachHang.Text = "Khách hàng"
        btnKhachHang.TextAlign = ContentAlignment.BottomCenter
        btnKhachHang.TextImageRelation = TextImageRelation.ImageAboveText
        btnKhachHang.UseCompatibleTextRendering = True
        btnKhachHang.UseVisualStyleBackColor = False
        ' 
        ' btnDienThoai
        ' 
        btnDienThoai.BackColor = Color.Azure
        btnDienThoai.FlatAppearance.BorderColor = Color.Black
        btnDienThoai.FlatStyle = FlatStyle.Flat
        btnDienThoai.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        btnDienThoai.ForeColor = Color.Black
        btnDienThoai.Image = CType(resources.GetObject("btnDienThoai.Image"), Image)
        btnDienThoai.ImageAlign = ContentAlignment.TopCenter
        btnDienThoai.Location = New Point(253, 18)
        btnDienThoai.Name = "btnDienThoai"
        btnDienThoai.Padding = New Padding(5)
        btnDienThoai.Size = New Size(174, 112)
        btnDienThoai.TabIndex = 1
        btnDienThoai.Text = "Điện thoại"
        btnDienThoai.TextAlign = ContentAlignment.BottomCenter
        btnDienThoai.TextImageRelation = TextImageRelation.ImageAboveText
        btnDienThoai.UseCompatibleTextRendering = True
        btnDienThoai.UseVisualStyleBackColor = False
        ' 
        ' btnHoaDon
        ' 
        btnHoaDon.BackColor = Color.Azure
        btnHoaDon.FlatAppearance.BorderColor = Color.Black
        btnHoaDon.FlatStyle = FlatStyle.Flat
        btnHoaDon.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        btnHoaDon.ForeColor = Color.Black
        btnHoaDon.Image = CType(resources.GetObject("btnHoaDon.Image"), Image)
        btnHoaDon.ImageAlign = ContentAlignment.TopCenter
        btnHoaDon.Location = New Point(480, 18)
        btnHoaDon.Name = "btnHoaDon"
        btnHoaDon.Padding = New Padding(5)
        btnHoaDon.Size = New Size(174, 112)
        btnHoaDon.TabIndex = 2
        btnHoaDon.Text = "Hoá đơn"
        btnHoaDon.TextAlign = ContentAlignment.BottomCenter
        btnHoaDon.TextImageRelation = TextImageRelation.ImageAboveText
        btnHoaDon.UseCompatibleTextRendering = True
        btnHoaDon.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Desktop
        Label1.Location = New Point(32, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(395, 98)
        Label1.TabIndex = 2
        Label1.Text = "Quản lý " & vbCrLf & "Cửa hàng điện thoại"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.InactiveCaptionText
        Label2.Location = New Point(44, 280)
        Label2.Name = "Label2"
        Label2.Size = New Size(329, 23)
        Label2.TabIndex = 3
        Label2.Text = "Hệ thống quản lý bán hàng chuyên nghiệp"
        ' 
        ' QLCUAHANGDIENTHOAI
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1154, 458)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "QLCUAHANGDIENTHOAI"
        Text = "QLCUAHANGDIENTHOAI"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnKhachHang As Button
    Friend WithEvents btnDangXuat As Button
    Friend WithEvents btnCTHoaDon As Button
    Friend WithEvents btnHoaDon As Button
    Friend WithEvents btnDienThoai As Button
End Class
