<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DANGNHAP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TxtTenDN = New TextBox()
        TxtPass = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        BtDangNhap = New Button()
        BtDangKy = New Button()
        BtExit = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtTenDN
        ' 
        TxtTenDN.Location = New Point(313, 177)
        TxtTenDN.Multiline = True
        TxtTenDN.Name = "TxtTenDN"
        TxtTenDN.Size = New Size(194, 42)
        TxtTenDN.TabIndex = 0
        ' 
        ' TxtPass
        ' 
        TxtPass.Location = New Point(313, 248)
        TxtPass.Multiline = True
        TxtPass.Name = "TxtPass"
        TxtPass.Size = New Size(194, 42)
        TxtPass.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(138, 192)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 19)
        Label1.TabIndex = 2
        Label1.Text = "Tên đăng nhập:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        Label2.ForeColor = SystemColors.Highlight
        Label2.Location = New Point(138, 271)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 19)
        Label2.TabIndex = 3
        Label2.Text = "Mật khẩu:"
        ' 
        ' BtDangNhap
        ' 
        BtDangNhap.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtDangNhap.ForeColor = Color.Blue
        BtDangNhap.Location = New Point(90, 324)
        BtDangNhap.Name = "BtDangNhap"
        BtDangNhap.Size = New Size(117, 50)
        BtDangNhap.TabIndex = 4
        BtDangNhap.Text = "Đăng nhập"
        BtDangNhap.UseVisualStyleBackColor = True
        ' 
        ' BtDangKy
        ' 
        BtDangKy.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtDangKy.ForeColor = Color.Red
        BtDangKy.Location = New Point(442, 324)
        BtDangKy.Name = "BtDangKy"
        BtDangKy.Size = New Size(117, 50)
        BtDangKy.TabIndex = 5
        BtDangKy.Text = "Đăng ký"
        BtDangKy.UseVisualStyleBackColor = True
        ' 
        ' BtExit
        ' 
        BtExit.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        BtExit.ForeColor = Color.MediumVioletRed
        BtExit.Location = New Point(273, 354)
        BtExit.Name = "BtExit"
        BtExit.Size = New Size(117, 50)
        BtExit.TabIndex = 6
        BtExit.Text = "Thoát"
        BtExit.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Cyan
        PictureBox1.Image = My.Resources.Resources.loginicon
        PictureBox1.Location = New Point(265, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 119)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' DANGNHAP
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cyan
        ClientSize = New Size(674, 416)
        Controls.Add(PictureBox1)
        Controls.Add(BtExit)
        Controls.Add(BtDangKy)
        Controls.Add(BtDangNhap)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TxtPass)
        Controls.Add(TxtTenDN)
        Name = "DANGNHAP"
        Text = "Chương trình đăng nhập"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtTenDN As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtDangNhap As Button
    Friend WithEvents BtDangKy As Button
    Friend WithEvents BtExit As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
