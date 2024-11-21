CREATE DATABASE StationeryManagementSystem;
go
USE StationeryManagementSystem;
GO
CREATE TABLE NhanVien(
    MaNhanVien INT PRIMARY KEY IDENTITY(1,1),
    HoTen NVARCHAR(50) NOT NULL,
    NgaySinh DATE check (NgaySinh <= GETDATE()) NOT NULL,
    GioiTinh NVARCHAR(10) check (GioiTinh IN (N'Nam', N'Nữ')) NOT NULL,
    DiaChi NVARCHAR(100) NOT NULL,
    SoDienThoai NVARCHAR(15) check (LEN(SoDienThoai) = 10) UNIQUE,
    Email VARCHAR(50) check (Email LIKE '%@%.%') UNIQUE,
    MaChucVu INT
);
-- thêm cột isActived vào bảng NhanVien
ALTER TABLE NhanVien ADD IsActived BIT NULL DEFAULT 1;
go
CREATE TABLE ChucVu(
    MaChucVu INT PRIMARY KEY,
    TenChucVu NVARCHAR(50) NOT NULL,
    LuongTheoGio FLOAT CHECK (LuongTheoGio >= 0) NULL
);
go
CREATE TABLE HoaDonNhap(
    MaHoaDonNhap INT PRIMARY KEY IDENTITY(1,1),
    NgayLap DATE check (NgayLap <= GETDATE()) NULL DEFAULT (GETDATE()),
    MaNhanVien INT,
    MaNhaCungCap INT,
    GiaTri FLOAT CHECK (GiaTri >= 0) NOT NULL DEFAULT 0,
    TrangThaiThanhToan NVARCHAR(50) CHECK (TrangThaiThanhToan IN (N'Chưa thanh toán', N'Đã thanh toán')) NOT NULL DEFAULT N'Chưa thanh toán',
    NgayThanhToan DATE NULL CHECK (NgayThanhToan <= GETDATE())
);
go
CREATE TABLE NhaCungCap(
    MaNhaCungCap INT PRIMARY KEY IDENTITY(1,1),
    TenNhaCungCap NVARCHAR(50) NOT NULL,
    DiaChi NVARCHAR(100) NOT NULL,
    SoDienThoai NVARCHAR(15) CHECK (LEN(SoDienThoai) = 10) UNIQUE
);
GO
-- thêm cột isActived vào bảng NhaCungCap
ALTER TABLE NhaCungCap ADD IsActived BIT NULL DEFAULT 1;
go
CREATE TABLE ChiTietHoaDonNhap(
    MaHoaDonNhap INT,
    MaSanPham INT,
    SoLuong INT CHECK (SoLuong > 0) NOT NULL,
    DonGia FLOAT CHECK (DonGia >= 0) NOT NULL,
    TongTien FLOAT CHECK (TongTien >= 0) NOT NULL DEFAULT 0,
    PRIMARY KEY(MaHoaDonNhap, MaSanPham)
);
go
CREATE TABLE SanPham(
    MaSanPham INT PRIMARY KEY IDENTITY(1,1),
    TenSanPham NVARCHAR(50) NOT NULL,
    MaLoaiSanPham INT NULL,
    GiaNhap FLOAT CHECK (GiaNhap >= 0) NOT NULL DEFAULT 0,
    GiaBan FLOAT CHECK (GiaBan >= 0) NOT NULL DEFAULT 0,
    MaNhaCungCap INT NULL,
);
--thêm cột IsActived vào bảng SanPham
ALTER TABLE SanPham ADD IsActived BIT NULL DEFAULT 1;
go
CREATE TABLE LoaiSanPham(
    MaLoaiSanPham INT PRIMARY KEY IDENTITY(1,1),
    TenLoaiSanPham NVARCHAR(50) NOT NULL,
);
go
CREATE TABLE ThongTinTonKho(
    MaSanPham INT PRIMARY KEY IDENTITY(1,1),
    SoLuongTonKho INT NOT NULL DEFAULT 0
);
go
CREATE TABLE HoaDonBan(
    MaHoaDonBan INT PRIMARY KEY IDENTITY(1,1),
    NgayLap DATE check (NgayLap <= GETDATE()) NULL DEFAULT (GETDATE()),
    MaNhanVien INT,
    MaKhachHang INT,
    GiaTri FLOAT CHECK (GiaTri >= 0) NOT NULL DEFAULT 0,
    TrangThaiThanhToan NVARCHAR(50) CHECK (TrangThaiThanhToan IN (N'Chưa thanh toán', N'Đã thanh toán')) NOT NULL DEFAULT N'Chưa thanh toán',
    NgayThanhToan DATE NULL CHECK (NgayThanhToan <= GETDATE())
);
go
CREATE TABLE KhachHang(
    MaKhachHang INT PRIMARY KEY IDENTITY(1,1),
    HoTen NVARCHAR(50) NULL,
    DiaChi NVARCHAR(100) NULL,
    SoDienThoai NVARCHAR(15) NULL CHECK (LEN(SoDienThoai) = 10) UNIQUE
);
GO
-- thêm cột isActived vào bảng KhachHang
ALTER TABLE KhachHang ADD IsActived BIT NULL DEFAULT 1;
go
CREATE TABLE ChiTietHoaDonBan(
    MaHoaDonBan INT,
    MaSanPham INT,
    SoLuong INT CHECK (SoLuong > 0) NOT NULL,
    DonGia FLOAT CHECK (DonGia >= 0) NOT NULL DEFAULT 0,
    TongTien FLOAT CHECK (TongTien >= 0) NOT NULL DEFAULT 0,
    PRIMARY KEY(MaHoaDonBan, MaSanPham)
);
CREATE TABLE Ca(
    MaCa INT PRIMARY KEY,
    GioBatDau TIME NOT NULL,
    GioKetThuc TIME NOT NULL,
    CONSTRAINT CK_Ca CHECK (GioBatDau < GioKetThuc)
);
CREATE TABLE PhanCa(
    MaNhanVien INT,
    MaCa INT,
    Ngay DATE,
    CheckIn TIME NULL,
    CheckOut TIME NULL,
    PRIMARY KEY(MaNhanVien, MaCa, Ngay),
    CONSTRAINT CK_PhanCa CHECK(DATEDIFF(HOUR,CheckIn,Checkout) >= 0)    
);
-- -- thêm cột đã duyệt vào bảng PhanCa
-- ALTER TABLE PhanCa ADD DaDuyet BIT NULL DEFAULT 1;
go

ALTER TABLE NhanVien ADD CONSTRAINT FK_NhanVien_ChucVu FOREIGN KEY(MaChucVu) REFERENCES ChucVu(MaChucVu) ON DELETE SET NULL ON UPDATE CASCADE;
ALTER TABLE HoaDonNhap ADD CONSTRAINT FK_HoaDonNhap_NhanVien FOREIGN KEY(MaNhanVien) REFERENCES NhanVien(MaNhanVien);
ALTER TABLE HoaDonNhap ADD CONSTRAINT FK_HoaDonNhap_NhaCungCap FOREIGN KEY(MaNhaCungCap) REFERENCES NhaCungCap(MaNhaCungCap);
ALTER TABLE ChiTietHoaDonNhap ADD CONSTRAINT FK_ChiTietHoaDonNhap_HoaDonNhap FOREIGN KEY(MaHoaDonNhap) REFERENCES HoaDonNhap(MaHoaDonNhap) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE ChiTietHoaDonNhap ADD CONSTRAINT FK_ChiTietHoaDonNhap_SanPham FOREIGN KEY(MaSanPham) REFERENCES SanPham(MaSanPham);
ALTER TABLE SanPham ADD CONSTRAINT FK_SanPham_LoaiSanPham FOREIGN KEY(MaLoaiSanPham) REFERENCES LoaiSanPham(MaLoaiSanPham) ON DELETE SET NULL ON UPDATE CASCADE;
ALTER TABLE SanPham ADD CONSTRAINT FK_SanPham_NhaCungCap FOREIGN KEY(MaNhaCungCap) REFERENCES NhaCungCap(MaNhaCungCap);
ALTER TABLE SanPham ADD CONSTRAINT FK_SanPham_ThongTinTonKho FOREIGN KEY(MaSanPham) REFERENCES ThongTinTonKho(MaSanPham);
ALTER TABLE HoaDonBan ADD CONSTRAINT FK_HoaDonBan_NhanVien FOREIGN KEY(MaNhanVien) REFERENCES NhanVien(MaNhanVien);
ALTER TABLE HoaDonBan ADD CONSTRAINT FK_HoaDonBan_KhachHang FOREIGN KEY(MaKhachHang) REFERENCES KhachHang(MaKhachHang);
ALTER TABLE ChiTietHoaDonBan ADD CONSTRAINT FK_ChiTietHoaDonBan_HoaDon FOREIGN KEY(MaHoaDonBan) REFERENCES HoaDonBan(MaHoaDonBan) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE ChiTietHoaDonBan ADD CONSTRAINT FK_ChiTietHoaDonBan_SanPham FOREIGN KEY(MaSanPham) REFERENCES SanPham(MaSanPham);
ALTER TABLE PhanCa ADD CONSTRAINT FK_PhanCa_NhanVien FOREIGN KEY(MaNhanVien) REFERENCES NhanVien(MaNhanVien);
ALTER TABLE PhanCa ADD CONSTRAINT FK_PhanCa_Ca FOREIGN KEY(MaCa) REFERENCES Ca(MaCa);



