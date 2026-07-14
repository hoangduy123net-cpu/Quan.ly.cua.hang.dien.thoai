<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CHITIETHOADON
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
        cboMaDT = New ComboBox()
        cboMaHD = New ComboBox()
        txtSoLuong = New TextBox()
        TextBox2 = New TextBox()
        txtThanhTien = New TextBox()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        BtThem = New Button()
        Button2 = New Button()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cboMaDT
        ' 
        cboMaDT.FormattingEnabled = True
        cboMaDT.Location = New Point(167, 352)
        cboMaDT.Name = "cboMaDT"
        cboMaDT.Size = New Size(121, 28)
        cboMaDT.TabIndex = 0
        ' 
        ' cboMaHD
        ' 
        cboMaHD.FormattingEnabled = True
        cboMaHD.Location = New Point(167, 248)
        cboMaHD.Name = "cboMaHD"
        cboMaHD.Size = New Size(121, 28)
        cboMaHD.TabIndex = 1
        ' 
        ' txtSoLuong
        ' 
        txtSoLuong.Location = New Point(541, 248)
        txtSoLuong.Name = "txtSoLuong"
        txtSoLuong.Size = New Size(130, 27)
        txtSoLuong.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(541, 312)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(130, 27)
        TextBox2.TabIndex = 3
        ' 
        ' txtThanhTien
        ' 
        txtThanhTien.Location = New Point(541, 369)
        txtThanhTien.Name = "txtThanhTien"
        txtThanhTien.Size = New Size(130, 27)
        txtThanhTien.TabIndex = 4
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(81, 29)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(722, 165)
        DataGridView1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 257)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 6
        Label1.Text = "Mã hoá đơn:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 360)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 7
        Label2.Text = "Mã điện thoại:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(386, 251)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 8
        Label3.Text = "Số lượng:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(386, 315)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 20)
        Label4.TabIndex = 9
        Label4.Text = "Giá bán điện thoại:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(386, 372)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 20)
        Label5.TabIndex = 10
        Label5.Text = "Thành tiền:"
        ' 
        ' BtThem
        ' 
        BtThem.Location = New Point(797, 242)
        BtThem.Name = "BtThem"
        BtThem.Size = New Size(94, 29)
        BtThem.TabIndex = 11
        BtThem.Text = "Thêm "
        BtThem.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(797, 306)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 12
        Button2.Text = "Sửa"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(797, 372)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 13
        Button3.Text = "Xoá"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' CHITIETHOADON
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(956, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(BtThem)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(txtThanhTien)
        Controls.Add(TextBox2)
        Controls.Add(txtSoLuong)
        Controls.Add(cboMaHD)
        Controls.Add(cboMaDT)
        Name = "CHITIETHOADON"
        Text = "CHITIETHOADON"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboMaDT As ComboBox
    Friend WithEvents cboMaHD As ComboBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtThanhTien As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtThem As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
