<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DANGKY
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
        txtTenTK = New TextBox()
        txtMK = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        BtDangky = New Button()
        BtThoat = New Button()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtTenTK
        ' 
        txtTenTK.Location = New Point(345, 97)
        txtTenTK.Multiline = True
        txtTenTK.Name = "txtTenTK"
        txtTenTK.Size = New Size(209, 48)
        txtTenTK.TabIndex = 0
        ' 
        ' txtMK
        ' 
        txtMK.Location = New Point(345, 185)
        txtMK.Multiline = True
        txtMK.Name = "txtMK"
        txtMK.Size = New Size(209, 48)
        txtMK.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.ForeColor = Color.DarkOrange
        Label1.Location = New Point(166, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 23)
        Label1.TabIndex = 2
        Label1.Text = "Tên tài khoản:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label2.ForeColor = Color.DarkOrange
        Label2.Location = New Point(180, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 23)
        Label2.TabIndex = 3
        Label2.Text = "Mật khẩu:"
        ' 
        ' BtDangky
        ' 
        BtDangky.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtDangky.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        BtDangky.Location = New Point(387, 350)
        BtDangky.Name = "BtDangky"
        BtDangky.Size = New Size(117, 51)
        BtDangky.TabIndex = 4
        BtDangky.Text = "Đăng ký"
        BtDangky.UseVisualStyleBackColor = True
        ' 
        ' BtThoat
        ' 
        BtThoat.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtThoat.Location = New Point(741, 416)
        BtThoat.Name = "BtThoat"
        BtThoat.Size = New Size(117, 51)
        BtThoat.TabIndex = 5
        BtThoat.Text = "Thoát"
        BtThoat.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label3.ForeColor = Color.LightSeaGreen
        Label3.Location = New Point(374, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(151, 41)
        Label3.TabIndex = 6
        Label3.Text = "ĐĂNG KÝ"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(345, 277)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(209, 48)
        TextBox1.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label4.ForeColor = Color.DarkOrange
        Label4.Location = New Point(142, 302)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 23)
        Label4.TabIndex = 8
        Label4.Text = "Xác nhận mật khẩu:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label5.Location = New Point(28, 434)
        Label5.Name = "Label5"
        Label5.Size = New Size(159, 19)
        Label5.TabIndex = 9
        Label5.Text = "Bạn đã có tài khoản?"
        ' 
        ' DANGKY
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(908, 479)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(BtThoat)
        Controls.Add(BtDangky)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtMK)
        Controls.Add(txtTenTK)
        Name = "DANGKY"
        Text = "Đăng ký"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTenTK As TextBox
    Friend WithEvents txtMK As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtDangky As Button
    Friend WithEvents BtThoat As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
