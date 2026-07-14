# 📱 Quản Lý Cửa Hàng Điện Thoại

Đây là đồ án xây dựng phần mềm **Quản lý Cửa hàng Điện thoại** được phát triển bằng **Visual Basic .NET (WinForms)** trên **Visual Studio 2022** và sử dụng **SQL Server** để lưu trữ dữ liệu.

Mục tiêu của dự án là hỗ trợ quản lý các nghiệp vụ cơ bản của cửa hàng điện thoại như quản lý khách hàng, sản phẩm và hóa đơn thông qua giao diện Windows Forms.

---

# Công nghệ sử dụng

| Thành phần | Công nghệ |
|------------|-----------|
| IDE | Visual Studio 2022 |
| Ngôn ngữ | Visual Basic .NET |
| Framework | .NET 8.0 Windows |
| Giao diện | Windows Forms |
| Database | SQL Server |
| Kết nối CSDL | Microsoft.Data.SqlClient |

---

# Chức năng của chương trình

Project hiện gồm các module chính:

- Đăng nhập
- Đăng ký tài khoản
- Quản lý khách hàng
- Quản lý điện thoại
- Quản lý hóa đơn
- Quản lý chi tiết hóa đơn

---

# Cấu trúc project

```
Quan.ly.cua.hang.dien.thoai
│
├── DANGNHAP.vb
├── DANGKY.vb
├── KHACHHANG.vb
├── DIENTHOAI.vb
├── HOADON.vb
├── CHITIETHOADON.vb
├── QLCUAHANGDIENTHOAI.vb
├── Thuvien.vb
│
├── quanlycuahangdienthoai.mdf
├── quanlycuahangdienthoai_log.ldf
│
└── Chuongtrinhdangnhap.sln
```

---

# Cài đặt

## 1. Clone project

```bash
git clone https://github.com/hoangduy123net-cpu/Quan.ly.cua.hang.dien.thoai.git
```

hoặc tải file ZIP.

---

## 2. Mở project

Mở file

```
Chuongtrinhdangnhap.sln
```

bằng Visual Studio 2022.

---

## 3. Chuẩn bị SQL Server

Project sử dụng SQL Server.

Trong project đã đính kèm

```
quanlycuahangdienthoai.mdf
quanlycuahangdienthoai_log.ldf
```

Có thể Attach database bằng SQL Server Management Studio.

---

## 4. Sửa Connection String

Mở file

```
Thuvien.vb
```

Thay đổi

```vb
Data Source=ADMIN-PC\SQLEXPRESS
```

thành tên SQL Server trên máy của bạn.

Ví dụ

```vb
Data Source=DESKTOP-ABC123\SQLEXPRESS
```

hoặc

```vb
Data Source=localhost
```

nếu SQL Server được cài mặc định.

---

## 5. Chạy project

Nhấn

```
F5
```

hoặc

```
Ctrl + F5
```

để chạy chương trình.

---

# Thư viện sử dụng

Project sử dụng các package NuGet sau:

- Microsoft.Data.SqlClient
- System.Data.SqlClient

Visual Studio sẽ tự động Restore khi mở project.

---

# Một số lỗi thường gặp

## Không kết nối được SQL Server

Kiểm tra:

- SQL Server đã chạy chưa
- Tên Server đã đúng chưa
- Database đã Attach chưa
- Connection String trong `Thuvien.vb` đã đúng chưa

---

## Không mở được project

Hãy sử dụng:

- Visual Studio 2022
- .NET 8 SDK

---

# Tác giả

Hoàng Duy

GitHub:

https://github.com/hoangduy123net-cpu

---

# Giấy phép

Dự án được chia sẻ nhằm mục đích học tập và tham khảo.

Nếu sử dụng hoặc phát triển từ source này, vui lòng ghi rõ nguồn tác giả.
