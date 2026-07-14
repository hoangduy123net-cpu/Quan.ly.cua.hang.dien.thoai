<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HOADON
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
        DataGridView1 = New DataGridView()
        txtMaHD = New TextBox()
        cboMaKH = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnThem = New Button()
        btnSua = New Button()
        btnXoa = New Button()
        btnLuu = New Button()
        dtpNgayLap = New DateTimePicker()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(21, 23)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(892, 245)
        DataGridView1.TabIndex = 0
        ' 
        ' txtMaHD
        ' 
        txtMaHD.Location = New Point(182, 312)
        txtMaHD.Name = "txtMaHD"
        txtMaHD.Size = New Size(156, 27)
        txtMaHD.TabIndex = 1
        ' 
        ' cboMaKH
        ' 
        cboMaKH.FormattingEnabled = True
        cboMaKH.Location = New Point(559, 311)
        cboMaKH.Name = "cboMaKH"
        cboMaKH.Size = New Size(156, 28)
        cboMaKH.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 405)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 20)
        Label1.TabIndex = 5
        Label1.Text = "Ngày lập:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 319)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 20)
        Label2.TabIndex = 6
        Label2.Text = "Mã hoá đơn:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(431, 319)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 20)
        Label3.TabIndex = 7
        Label3.Text = "Mã khách hàng:"
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(182, 447)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(94, 29)
        btnThem.TabIndex = 8
        btnThem.Text = "Thêm "
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Location = New Point(378, 447)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(94, 29)
        btnSua.TabIndex = 9
        btnSua.Text = "Sửa"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(578, 447)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(94, 29)
        btnXoa.TabIndex = 10
        btnXoa.Text = "Xoá"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnLuu
        ' 
        btnLuu.Location = New Point(767, 447)
        btnLuu.Name = "btnLuu"
        btnLuu.Size = New Size(94, 29)
        btnLuu.TabIndex = 11
        btnLuu.Text = "Lưu"
        btnLuu.UseVisualStyleBackColor = True
        ' 
        ' dtpNgayLap
        ' 
        dtpNgayLap.Location = New Point(182, 405)
        dtpNgayLap.Name = "dtpNgayLap"
        dtpNgayLap.Size = New Size(156, 27)
        dtpNgayLap.TabIndex = 12
        ' 
        ' HOADON
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(935, 509)
        Controls.Add(dtpNgayLap)
        Controls.Add(btnLuu)
        Controls.Add(btnXoa)
        Controls.Add(btnSua)
        Controls.Add(btnThem)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cboMaKH)
        Controls.Add(txtMaHD)
        Controls.Add(DataGridView1)
        Name = "HOADON"
        Text = "HOADON"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtMaHD As TextBox
    Friend WithEvents cboMaKH As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents dtpNgayLap As DateTimePicker
End Class
