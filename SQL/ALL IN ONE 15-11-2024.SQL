CREATE DATABASE StationeryManagementSystem;
go
USE StationeryManagementSystem;
go
-- EXECUTE AS USER = 'KK3'; 
-- SELECT HAS_PERMS_BY_NAME('dbo.HoaDonNhap', 'OBJECT', 'SELECT') AS HasSelectPermission;
-- select * from sys.database_principals;

go
CREATE TABLE ChucVu(
    MaChucVu INT PRIMARY KEY,
    TenChucVu NVARCHAR(50) NOT NULL,
    LuongTheoGio FLOAT CHECK (LuongTheoGio >= 0) NULL
);
insert into ChucVu(MaChucVu,TenChucVu,LuongTheoGio) values (1,N'Nhân viên bán hàng',100000);
insert into ChucVu(MaChucVu,TenChucVu,LuongTheoGio) values (2,N'Nhân viên kiểm kho',80000);

CREATE TABLE DoanhThuTHang(
    month INT NULL,
    year INT NULL,
    revenue INT NULL
);
INSERT into DoanhThuThang(month,year, revenue) values (10,2024,2000000);
INSERT into DoanhThuThang(month,year, revenue) values (9,2024,3000000);
INSERT into DoanhThuThang(month,year, revenue) values (8,2024,1000000);
INSERT into DoanhThuThang(month,year, revenue) values (7,2024,4000000);
INSERT into DoanhThuThang(month,year, revenue) values (6,2024,3000000);
INSERT into DoanhThuThang(month,year, revenue) values (5,2024,2000000);
INSERT into DoanhThuThang(month,year, revenue) values (4,2024,5000000);
INSERT into DoanhThuThang(month,year, revenue) values (3,2024,4000000);
INSERT into DoanhThuThang(month,year, revenue) values (2,2024,2500000);
INSERT into DoanhThuThang(month,year, revenue) values (1,2024,1800000);
INSERT into DoanhThuThang(month,year, revenue) values (12,2023,2000000);
INSERT into DoanhThuThang(month,year, revenue) values (11,2023,2500000);
INSERT into DoanhThuThang(month,year, revenue) values (10,2023,1000000);
INSERT into DoanhThuThang(month,year, revenue) values (9,2023,2100000);
INSERT into DoanhThuThang(month,year, revenue) values (8,2023,2000000);
INSERT into DoanhThuThang(month,year, revenue) values (7,2023,2300000);
INSERT into DoanhThuThang(month,year, revenue) values (6,2023,2000000);
INSERT into DoanhThuThang(month,year, revenue) values (5,2023,1800000);
INSERT into DoanhThuThang(month,year, revenue) values (4,2023,1900000);
INSERT into DoanhThuThang(month,year, revenue) values (3,2023,1300000);
INSERT into DoanhThuThang(month,year, revenue) values (2,2023,1400000);
INSERT into DoanhThuThang(month,year, revenue) values (1,2023,1700000);
INSERT into DoanhThuThang(month,year, revenue) values (12,2022,2400000);

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
--trigger thêm tài khoản cho nhân viên sau khi thêm nhân viên đó
CREATE or Alter TRIGGER TG_ADD_Account
ON NhanVien
AFTER INSERT,DELETE AS
BEGIN
-- nếu là insert thì thêm vào bảng account
    IF EXISTS(SELECT * FROM inserted) AND NOT EXISTS(SELECT * FROM deleted)
    BEGIN
        DECLARE @username nvarchar(30), @passwd nvarchar(10), @role int
        DECLARE @sqlString nvarchar(max)
        SELECT @username=inserted.MaNhanVien FROM inserted;
        SELECT @role = inserted.MaChucVu FROM inserted;
        IF @role = 2 SET @username='KK' + @username;
        IF @role = 1 SET @username='BH' + @username;
        SET @passwd =123

        INSERT INTO ACCOUNT(Username, Password, isAdmin, MaNhanVien)
        SELECT @username, @passwd, 0,MaNhanVien FROM inserted;

        -- nếu đã tồn tại
        IF EXISTS(SELECT * FROM sys.server_principals WHERE name = @username)
        BEGIN
            SET @sqlString = 'ALTER LOGIN ' + '[' + @username + ']' + ' WITH PASSWORD = '''+ @passwd +'''';
            EXEC (@sqlString)
        END
        ELSE
        -- Tạo login dbms
        SET @sqlString= 'CREATE LOGIN ' + '[' + @username + ']' + ' WITH PASSWORD = '''+ @passwd +'''';
        EXEC (@sqlString)
        --nếu đã tồn tại thì xoá trc để tạo lại để tránh lỗi
        SET @sqlString = 'drop user if exists ' + @username;
        EXEC (@sqlString)
        --Tạo user dbms
        SET @sqlString= 'CREATE USER ' + '[' + @userName + ']' +' FOR LOGIN '+ '[' + @userName + ']'
        EXEC (@sqlString)
        --Add user vào role
        IF @role = 1
            SET @sqlString = 'ALTER ROLE BanHang ADD MEMBER '+ '[' + @userName + ']';
        ELSE IF @role = 2
            SET @sqlString = 'ALTER ROLE KiemKho ADD MEMBER ' + '[' + @userName + ']';
        EXEC (@sqlString)
    END
    ELSE IF EXISTS(SELECT * FROM deleted) AND NOT EXISTS(SELECT * FROM inserted)
    BEGIN
    -- nếu là delete thì xóa trong bảng account
        DECLARE @uname nvarchar(30)=(SELECT username FROM ACCOUNT WHERE MaNhanVien IN (SELECT MaNhanVien FROM deleted));
        DELETE FROM ACCOUNT WHERE Username=@uname;
        -- Xóa user dbms
        DECLARE @sql nvarchar(max)= 'DROP USER ' + '[' + @uname + ']';
        EXEC (@sql)
        -- Xóa login dbms
        SET @sql = 'DROP LOGIN ' + '[' + @uname + ']';
        EXEC (@sql)
    END
END
GO
create table ACCOUNT(
    Username NVARCHAR(50) PRIMARY KEY,
    Password varchar(50),
    isAdmin bit,
    MaNhanVien int NULL UNIQUE REFERENCES NhanVien(MaNhanVien)
);

CREATE ROLE BanHang;
CREATE ROLE KiemKho;



-- tạo admin có role là sysadmin vs username là admin và password là 123
if not exists (select * from sys.server_principals where name = 'admin')
begin
    CREATE LOGIN admin WITH PASSWORD = '123'
    ALTER SERVER ROLE sysadmin ADD MEMBER admin
end
else
    ALTER LOGIN admin WITH PASSWORD = '123';  

drop user if exists admin;
CREATE USER [admin] FOR LOGIN [admin];  
-- thêm tài khoản cho admin vào bảng account
DELETE FROM ACCOUNT WHERE Username='admin';
INSERT INTO ACCOUNT(Username, Password, isAdmin, MaNhanVien) VALUES ('admin', '123', 1, NULL)
go
INSERT into NhanVien(HoTen,NgaySinh,GioiTinh,DiaChi,SoDienThoai,Email,MaChucVu) values (N'Lê Thị Duyên','1999-02-01',N'Nữ',N'Đà Lạt','0360000001','a1@gmail.com',1);
INSERT into NhanVien(HoTen,NgaySinh,GioiTinh,DiaChi,SoDienThoai,Email,MaChucVu) values (N'Trần Văn Kiên','2004-02-02',N'Nam',N'Long An','0360000002','a2@gmail.com',1);
INSERT into NhanVien(HoTen,NgaySinh,GioiTinh,DiaChi,SoDienThoai,Email,MaChucVu) values (N'Nguyễn Thị Thuỷ Triều','2000-12-02',N'Nữ',N'Long Xuyên','0360000003','a3@gmail.com',2);

CREATE TABLE NhaCungCap(
    MaNhaCungCap INT PRIMARY KEY IDENTITY(1,1),
    TenNhaCungCap NVARCHAR(50) NOT NULL,
    DiaChi NVARCHAR(100) NOT NULL,
    SoDienThoai NVARCHAR(15) CHECK (LEN(SoDienThoai) = 10) UNIQUE
);
-- thêm cột isActived vào bảng NhaCungCap
ALTER TABLE NhaCungCap ADD IsActived BIT NULL DEFAULT 1;
INSERT into NhaCungCap( TenNhaCungCap, DiaChi, SoDienThoai) values (N'Thiên Long', N'Hồ Chí Minh', '0380000001');
INSERT into NhaCungCap( TenNhaCungCap, DiaChi, SoDienThoai) values (N'Việt Tiến', N'Số 1 Võ Văn Ngân', '0380000002');
INSERT into NhaCungCap( TenNhaCungCap, DiaChi, SoDienThoai) values (N'Casio', N'Hiệp Phú, Q9', '0380000003');
go
CREATE TABLE SanPham(
    MaSanPham INT PRIMARY KEY IDENTITY(1,1),
    TenSanPham NVARCHAR(50) NOT NULL,
    MaLoaiSanPham INT NULL,
    GiaNhap FLOAT CHECK (GiaNhap >= 0) NOT NULL DEFAULT 0,
    GiaBan FLOAT CHECK (GiaBan >= 0) NOT NULL DEFAULT 0,
    MaNhaCungCap INT NULL,
);
ALTER TABLE SanPham ADD IsActived BIT NULL DEFAULT 1;
go
CREATE TABLE LoaiSanPham(
    MaLoaiSanPham INT PRIMARY KEY IDENTITY(1,1),
    TenLoaiSanPham NVARCHAR(50) NOT NULL,
);
CREATE TABLE ThongTinTonKho(
    MaSanPham INT PRIMARY KEY IDENTITY(1,1),
    SoLuongTonKho INT NOT NULL DEFAULT 0
);
INSERT into LoaiSanPham( TenLoaiSanPham) values ( N'Dụng cụ học tập');
INSERT into LoaiSanPham( TenLoaiSanPham) values (N'Đồ dùng văn phòng');
INSERT into LoaiSanPham( TenLoaiSanPham) values ( N'Đồ dùng khác');

INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap,GiaNhap,GiaBan) values (N'Bút', 1, 1, 10000, 15000);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap,GiaNhap,GiaBan) values (N'Viết', 1, 2, 20000, 30000);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap,GiaNhap,GiaBan) values (N'Tập', 1, 3, 50000, 60000);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap,GiaNhap,GiaBan) values (N'Giấy', 1, 1, 20000, 25000);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap,GiaNhap,GiaBan) values (N'Kéo', 2, 2, 30000, 35000);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap,GiaNhap,GiaBan) values (N'Sổ tay', 2, 2, 20000, 25000);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap,GiaNhap,GiaBan) values (N'Ô', 3, 2, 10000, 15000);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap,GiaNhap,GiaBan) values (N'Cặp', 1, 2, 50000, 60000);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap,GiaNhap,GiaBan) values (N'Bàn chải', 3, 2, 10000, 15000);
INSERT into ThongTinTonKho(SoLuongTonKho) values (100);
INSERT into ThongTinTonKho(SoLuongTonKho) values (200);
INSERT into ThongTinTonKho(SoLuongTonKho) values (300);
INSERT into ThongTinTonKho(SoLuongTonKho) values (400);
INSERT into ThongTinTonKho(SoLuongTonKho) values (100);
INSERT into ThongTinTonKho(SoLuongTonKho) values (0);
INSERT into ThongTinTonKho(SoLuongTonKho) values (0);
INSERT into ThongTinTonKho(SoLuongTonKho) values (0);
INSERT into ThongTinTonKho(SoLuongTonKho) values (0);

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
INSERT into HoaDonNhap( NgayLap, MaNhanVien, MaNhaCungCap, GiaTri, TrangThaiThanhToan, NgayThanhToan) values ('2024-10-30', 3, 1, 100000, N'Đã thanh toán', '2024-10-30');
INSERT into HoaDonNhap( NgayLap, MaNhanVien, MaNhaCungCap, GiaTri, TrangThaiThanhToan, NgayThanhToan) values ('2024-10-29', 3, 1, 400000, N'Đã thanh toán', '2024-10-30');
INSERT into HoaDonNhap( NgayLap, MaNhanVien, MaNhaCungCap, GiaTri, TrangThaiThanhToan, NgayThanhToan) values ('2024-10-30', 3, 2, 1500000, N'Đã thanh toán', '2024-10-30');

go
CREATE TABLE ChiTietHoaDonNhap(
    MaHoaDonNhap INT,
    MaSanPham INT,
    SoLuong INT CHECK (SoLuong > 0) NOT NULL,
    DonGia FLOAT CHECK (DonGia >= 0) NOT NULL,
    TongTien FLOAT CHECK (TongTien >= 0) NOT NULL DEFAULT 0,
    PRIMARY KEY(MaHoaDonNhap, MaSanPham)
);
INSERT into ChiTietHoaDonNhap( MaHoaDonNhap, MaSanPham, SoLuong, DonGia, TongTien) values (1, 1, 5, 10000, 100000);
INSERT into ChiTietHoaDonNhap( MaHoaDonNhap, MaSanPham, SoLuong, DonGia, TongTien) values (1, 2, 7, 20000, 400000);
INSERT into ChiTietHoaDonNhap( MaHoaDonNhap, MaSanPham, SoLuong, DonGia, TongTien) values (1, 3, 8, 50000, 1500000);
INSERT into ChiTietHoaDonNhap( MaHoaDonNhap, MaSanPham, SoLuong, DonGia, TongTien) values (1, 4, 3, 20000, 800000);
INSERT into ChiTietHoaDonNhap( MaHoaDonNhap, MaSanPham, SoLuong, DonGia, TongTien) values (1, 5, 6, 30000, 1500000);
INSERT into ChiTietHoaDonNhap( MaHoaDonNhap, MaSanPham, SoLuong, DonGia, TongTien) values (2, 6, 7, 20000, 140000);
INSERT into ChiTietHoaDonNhap( MaHoaDonNhap, MaSanPham, SoLuong, DonGia, TongTien) values (2, 4, 8, 50000, 400000);
INSERT into ChiTietHoaDonNhap( MaHoaDonNhap, MaSanPham, SoLuong, DonGia, TongTien) values (2, 5, 3, 20000, 600000);
INSERT into ChiTietHoaDonNhap( MaHoaDonNhap, MaSanPham, SoLuong, DonGia, TongTien) values (3, 8, 7, 20000, 140000);
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

INSERT into KhachHang(HoTen, DiaChi, SoDienThoai) values (N'Nguyễn Trần Tuyết', N'Hà Nội', '0370000001');
INSERT into KhachHang(HoTen, DiaChi, SoDienThoai) values (N'Lê Văn Nam', N'Đà Lạt', '0370000002');

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
INSERT into HoaDonBan(MaNhanVien, MaKhachHang, GiaTri, TrangThaiThanhToan, NgayThanhToan) values (1, 1, 1500000, N'Đã thanh toán', '2024-10-20');
INSERT into HoaDonBan(MaNhanVien, MaKhachHang, GiaTri, TrangThaiThanhToan, NgayThanhToan) values (2, 1, 900000, N'Đã thanh toán', '2024-10-20');

go
CREATE TABLE ChiTietHoaDonBan(
    MaHoaDonBan INT,
    MaSanPham INT,
    SoLuong INT CHECK (SoLuong > 0) NOT NULL,
    DonGia FLOAT CHECK (DonGia >= 0) NOT NULL DEFAULT 0,
    TongTien FLOAT CHECK (TongTien >= 0) NOT NULL DEFAULT 0,
    PRIMARY KEY(MaHoaDonBan, MaSanPham)
);
INSERT into ChiTietHoaDonBan( MaHoaDonBan, MaSanPham, SoLuong, DonGia, TongTien) values (1, 1, 5, 10000, 100000);
INSERT into ChiTietHoaDonBan( MaHoaDonBan, MaSanPham, SoLuong, DonGia, TongTien) values (1, 2, 7, 20000, 400000);
INSERT into ChiTietHoaDonBan( MaHoaDonBan, MaSanPham, SoLuong, DonGia, TongTien) values (1, 3, 8, 50000, 150000);
INSERT into ChiTietHoaDonBan( MaHoaDonBan, MaSanPham, SoLuong, DonGia, TongTien) values (2, 4, 3, 20000, 80000);
INSERT into ChiTietHoaDonBan( MaHoaDonBan, MaSanPham, SoLuong, DonGia, TongTien) values (2, 5, 6, 30000, 150000);

GO
CREATE TABLE Ca(
    MaCa INT PRIMARY KEY,
    GioBatDau TIME NOT NULL,
    GioKetThuc TIME NOT NULL,
    CONSTRAINT CK_Ca CHECK (GioBatDau < GioKetThuc)
);
INSERT INTO Ca(MaCa,GioBatDau,GioKetThuc) VALUES (1,'08:00:00','12:00:00');
INSERT INTO Ca(MaCa,GioBatDau,GioKetThuc) VALUES (2,'13:00:00','17:00:00');
INSERT INTO Ca(MaCa,GioBatDau,GioKetThuc) VALUES (3,'18:00:00','20:00:00');
go

CREATE TABLE PhanCa(
    MaNhanVien INT,
    MaCa INT,
    Ngay DATE,
    CheckIn TIME NULL,
    CheckOut TIME NULL,
    PRIMARY KEY(MaNhanVien, MaCa, Ngay),
    CONSTRAINT CK_PhanCa CHECK(DATEDIFF(HOUR,CheckIn,Checkout) >= 0)    
);
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



GO
-- triger sau khi xoá sp thì xóa thông tin tồn kho
CREATE TRIGGER tr_XoaSanPham
on SanPham
AFTER delete
as
BEGIN
    DELETE From ThongTinTonKho
    where MaSanPham in (select MaSanPham
    from deleted)
end
go
-- trigger kiểm tra trc khi xoá nhân viên
CREATE TRIGGER tr_CheckBeforeDeleteNhanVien
ON NhanVien
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @maNhanVien INT= (select MaNhanVien
    FROM DELETED)
    IF EXISTS (SELECT 1
        from HoaDonBan
        WHERE MaNhanVien = @maNhanVien)
        or EXISTS (SELECT 1
        from HoaDonNhap
        WHERE MaNhanVien = @maNhanVien)
    BEGIN
        Update NhanVien SET IsActived = 0 WHERE MaNhanVien = @maNhanVien;
        RETURN;
    END
    DELETE FROM NhanVien WHERE MaNhanVien = @maNhanVien
END
go
-- trigger kiểm tra trc khi xoá sp
CREATE TRIGGER tr_CheckBeforeDeleteSanPham
ON SanPham
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @maSanPham INT= (select MaSanPham
    FROM DELETED)
    IF EXISTS (SELECT 1
        from ChiTietHoaDonBan
        WHERE MaSanPham = @maSanPham)
        or EXISTS (SELECT 1
        from ChiTietHoaDonNhap
        WHERE MaSanPham = @maSanPham)
    BEGIN
        Update SanPham SET IsActived = 0 WHERE MaSanPham = @maSanPham;
        RETURN;
    END
    DELETE FROM SanPham WHERE MaSanPham = @maSanPham
END

go
-- triger kiểm tra trc khi xoá khách hàng
CREATE TRIGGER tr_CheckBeforeDeleteKhachHang
ON KhachHang
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @maKhachHang INT= (select MaKhachHang
    FROM DELETED)
    IF EXISTS (SELECT 1
    from HoaDonBan
    WHERE MaKhachHang = @maKhachHang)
    BEGIN
        Update KhachHang SET IsActived = 0 WHERE MaKhachHang = @maKhachHang;
        RETURN;
    END
    DELETE FROM KhachHang WHERE MaKhachHang = @maKhachHang
END
go
-- triger kiểm tra trc khi xoá ncc
CREATE TRIGGER tr_CheckBeforeDeleteNhaCungCap
ON NhaCungCap
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @maNhaCungCap INT= (select MaNhaCungCap
    FROM DELETED)
    IF EXISTS (SELECT 1
    from HoaDonNhap
    WHERE MaNhaCungCap = @maNhaCungCap)
    BEGIN
        Update NhaCungCap SET IsActived = 0 WHERE MaNhaCungCap = @maNhaCungCap;
        RETURN;
    END
    DELETE FROM NhaCungCap WHERE MaNhaCungCap = @maNhaCungCap
END

go
-- Trigger tạo thông tin tồn kho cho sản phẩm khi thêm mới sản phẩm ban đầu
CREATE TRIGGER TRG_SanPham_INSERT
ON SanPham
INSTEAD OF INSERT
AS
BEGIN
    -- insert vào bảng ThongTinTonKho trước, sau đó insert vào bảng SanPham (vì để thoả khoá ngoại)
    INSERT INTO ThongTinTonKho
        (SoLuongTonKho)
    VALUES
        (0);
    -- lấy mã sản phẩm của dòng vừa thêm vào trong bảng ThongTinTonKho
    DECLARE @MaSanPham INT = (SELECT IDENT_CURRENT('ThongTinTonKho'));
    -- lấy thông tin sản phẩm từ bảng inserted
    DECLARE @TenSanPham NVARCHAR(50) = (SELECT TenSanPham
    FROM inserted);
    DECLARE @MaLoaiSanPham INT = (SELECT MaLoaiSanPham
    FROM inserted);
    DECLARE @GiaNhap FLOAT = (SELECT GiaNhap
    FROM inserted);
    DECLARE @GiaBan FLOAT = (SELECT GiaBan
    FROM inserted);
    DECLARE @MaNhaCungCap INT = (SELECT MaNhaCungCap
    FROM inserted);

    -- cho phép insert (với mã sản phẩm dc chỉ định) khi mà đã thiết lập tự tăng cho mã sản phẩm trong bảng SanPham
    SET IDENTITY_INSERT SanPham ON;
    INSERT INTO SanPham
        (MaSanPham,TenSanPham, MaLoaiSanPham, GiaNhap, GiaBan, MaNhaCungCap)
    VALUES(@MaSanPham, @TenSanPham, @MaLoaiSanPham, @GiaNhap, @GiaBan, @MaNhaCungCap);
    SET IDENTITY_INSERT SanPham OFF;
END;
GO
-- trigger tính tiền tương ứng của từng sản phẩm trong chi tiết hd nhập, đồng thời tính giá trị của hoá đơn nhập
CREATE TRIGGER TRG_ChiTietHoaDonNhap_INSERT
ON ChiTietHoaDonNhap
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @MaSP int=(SELECT MaSanPham
    FROM inserted)
    DECLARE @MaHDN int =(SELECT MaHoaDonNhap
    FROM inserted)
    --nếu đã tồn tại mã sp trong hoá đơn rồi rồi thì thay vì insert thì ta chỉ báo lỗi, không cho thêm mới.
    DECLARE @SoDong int = (
        SELECT COUNT(*)
    FROM ChiTietHoaDonNhap
    WHERE MaSanPham = @MaSP AND MaHoaDonNhap = @MaHDN)
    IF @SoDong > 0
    BEGIN
        RAISERROR('Sản phẩm đã tồn tại trong hoá đơn nhập, vui lòng chỉnh sửa số lượng sản phẩm thay vì thêm mới', 16, 1);
        ROLLBACK TRANSACTION;
    END;
    ELSE
    BEGIN
        --ngược lai thì insert như bình thường và tính tổng tiền tương ứng và cập nhật giá trị của hoá đơn nhập


        --insert
        INSERT INTO ChiTietHoaDonNhap
            (MaSanPham, MaHoaDonNhap, SoLuong, DonGia)
        SELECT MaSanPham, MaHoaDonNhap, SoLuong, DonGia
        FROM inserted;

        --tính tổng tiền tương ứng
        DECLARE @MaHoaDonNhap INT = (SELECT MaHoaDonNhap
        FROM inserted);
        DECLARE @MaSanPham INT = (SELECT MaSanPham
        FROM inserted);
        UPDATE ChiTietHoaDonNhap SET TongTien = SoLuong * DonGia WHERE MaHoaDonNhap = @MaHoaDonNhap AND MaSanPham = @MaSanPham;
        UPDATE HoaDonNhap
    SET GiaTri = (SELECT SUM(TongTien)
        FROM ChiTietHoaDonNhap
        WHERE MaHoaDonNhap = @MaHoaDonNhap)
    WHERE MaHoaDonNhap = @MaHoaDonNhap;
    END
END;
go

-- trigger cập nhật tổng tiền của chi tiết hoá đơn nhập và tính giá trị của hoá đơn nhập khi cập nhật số lượng hoặc đơn giá của sản phẩm trong chi tiết hoá đơn nhập
CREATE TRIGGER TRG_ChiTietHoaDonNhap_UPDATE
ON ChiTietHoaDonNhap
AFTER UPDATE
AS
BEGIN
    DECLARE @MaHoaDonNhap INT = (SELECT MaHoaDonNhap
    FROM inserted);
    DECLARE @MaSP INT = (SELECT MaSanPham
    FROM inserted);

    UPDATE ChiTietHoaDonNhap SET TongTien = SoLuong * DonGia WHERE MaHoaDonNhap = @MaHoaDonNhap AND MaSanPham = @MaSP;
    UPDATE HoaDonNhap
    SET GiaTri = (SELECT SUM(TongTien)
    FROM ChiTietHoaDonNhap
    WHERE MaHoaDonNhap = @MaHoaDonNhap)
    WHERE MaHoaDonNhap = @MaHoaDonNhap;

END;
go
-- trigger cập nhật số lượng tồn kho, giá nhập, giá bán, mã ncc của sp và ngày thanh toán khi trạng thái hoá đơn được thiết lập đã thanh toán,
CREATE TRIGGER TRG_HoaDonNhap_UPDATE
ON HoaDonNhap
AFTER UPDATE
AS
BEGIN
    DECLARE @MaHoaDonNhap INT= (SELECT MaHoaDonNhap
    FROM inserted);
    DECLARE @TrangThaiThanhToan_new NVARCHAR(50)= (SELECT TrangThaiThanhToan
    FROM inserted);
    DECLARE @TrangThaiThanhToan_old NVARCHAR(50)= (SELECT TrangThaiThanhToan
    FROM deleted);
    DECLARE @MaNhaCungCap INT=(SELECT MaNhaCungCap
    FROM inserted);
    -- print @TrangThaiThanhToan_new;
    -- print @TrangThaiThanhToan_old;
    IF @TrangThaiThanhToan_new = N'Đã thanh toán' AND @TrangThaiThanhToan_old = N'Chưa thanh toán'
    BEGIN
        UPDATE SanPham
        SET GiaNhap = ChiTietHoaDonNhap.DonGia,
            GiaBan = ChiTietHoaDonNhap.DonGia * 1.2,
            MaNhaCungCap = @MaNhaCungCap
        FROM ChiTietHoaDonNhap
        WHERE ChiTietHoaDonNhap.MaHoaDonNhap = @MaHoaDonNhap AND SanPham.MaSanPham = ChiTietHoaDonNhap.MaSanPham;

        UPDATE ThongTinTonKho
        SET SoLuongTonKho = SoLuongTonKho + ChiTietHoaDonNhap.SoLuong
        FROM ChiTietHoaDonNhap
        WHERE ChiTietHoaDonNhap.MaHoaDonNhap = @MaHoaDonNhap AND ThongTinTonKho.MaSanPham = ChiTietHoaDonNhap.MaSanPham;

        UPDATE HoaDonNhap
        SET NgayThanhToan = GETDATE()
        WHERE MaHoaDonNhap = @MaHoaDonNhap;
    END;
    ELSE IF @TrangThaiThanhToan_old = N'Đã thanh toán'
    BEGIN
        RAISERROR('Không thể cập nhật hoá đơn nhập đã thanh toán', 16, 1);
        ROLLBACK TRANSACTION;
    END;
END;
go
-----------------
-- Trigger kiểm tra sự tồn tại của sản phẩm trong cthdb trước khi thêm sp.
CREATE TRIGGER TRG_ChiTietHoaDonBan_INSTEAD_INSERT
ON ChiTietHoaDonBan
INSTEAD OF INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
    FROM ChiTietHoaDonBan
    WHERE MaHoaDonBan = (SELECT MaHoaDonBan
        FROM inserted) AND MaSanPham = (SELECT MaSanPham
        FROM inserted))
    BEGIN
        RAISERROR('Sản phẩm đã tồn tại trong chi tiết hóa đơn bán, vui lòng chỉnh sửa số lượng sản phẩm thay vì thêm mới', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    Insert into ChiTietHoaDonBan
        (MaHoaDonBan, MaSanPham, SoLuong)
    SELECT MaHoaDonBan, MaSanPham, SoLuong
    FROM inserted;
END;
GO
go
-- Trigger kiểm tra xem có đủ tồn kho cho sản phẩm khi thêm/cập nhật chi tiết hóa đơn bán, đồng thời cập nhật đon giá,tổng tiền của chi tiết hóa đơn bán và giá trị của hóa đơn bán
CREATE TRIGGER [dbo].[TRG_ChiTietHoaDonBan_INSERT_UPDATE]
ON [dbo].[ChiTietHoaDonBan]
AFTER INSERT,UPDATE
AS
BEGIN
    --(lúc này đã insert/update ở cthdb, nên chỉ cần kiểm tra số lượng tồn kho có đủ không, nếu không thì hoàn tác)
    DECLARE @MaSanPham INT = (SELECT MaSanPham
    FROM inserted);
    DECLARE @SoLuong INT = (SELECT SoLuong
    FROM inserted);

    DECLARE @SoLuongTonKho INT = (SELECT SoLuongTonKho
    FROM ThongTinTonKho
    WHERE MaSanPham = @MaSanPham);

    IF @SoLuong > @SoLuongTonKho
    BEGIN
        RAISERROR('Không đủ hàng trong kho để bán, vui lòng kiểm tra lại số lượng tồn kho', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
    DECLARE @GiaBan INT = (SELECT GiaBan FROM SanPham WHERE MaSanPham = @MaSanPham);
    --cập nhật đơn giá = giá bán của sản phẩm
    UPDATE ChiTietHoaDonBan
    SET DonGia = @GiaBan
    WHERE MaSanPham = @MaSanPham;

    -- cập nhật tổng tiền= số lượng * đơn giá

    DECLARE @MaHDB INT = (SELECT MaHoaDonBan
    FROM inserted);
    UPDATE ChiTietHoaDonBan
    SET TongTien = SoLuong * DonGia
    WHERE MaHoaDonBan = @MaHDB AND MaSanPham = @MaSanPham;

    -- tính giá trị hóa đơn bán
    UPDATE HoaDonBan
    SET GiaTri = (SELECT SUM(TongTien)
    FROM ChiTietHoaDonBan
    WHERE MaHoaDonBan = @MaHDB)
    WHERE MaHoaDonBan = @MaHDB;
END;

go



-- Trigger cập nhật giá trị hoá đơn bán và tồn kho của sp khi hóa đơn bán hàng được thanh toán.
DROP TRIGGER IF EXISTS TRG_HoaDonBan_UPDATE;
go
CREATE TRIGGER TRG_HoaDonBan_UPDATE
ON HoaDonBan
AFTER UPDATE
AS
BEGIN

    BEGIN TRY
        -- Start a transaction
        BEGIN TRANSACTION;
        DECLARE @MaHoaDonBan INT = (SELECT MaHoaDonBan FROM inserted);
        DECLARE @TrangThaiThanhToan_new NVARCHAR(50) = (SELECT TrangThaiThanhToan FROM inserted);
        DECLARE @TrangThaiThanhToan_old NVARCHAR(50) = (SELECT TrangThaiThanhToan FROM deleted);

        IF @TrangThaiThanhToan_new = N'Đã thanh toán'
           AND @TrangThaiThanhToan_old = N'Chưa thanh toán'
        BEGIN
            -- Cập nhật tồn kho cho sản phẩm đã bán
            UPDATE ThongTinTonKho
            SET SoLuongTonKho = SoLuongTonKho - ChiTietHoaDonBan.SoLuong
            FROM ChiTietHoaDonBan
            WHERE ChiTietHoaDonBan.MaHoaDonBan = @MaHoaDonBan
                  AND ThongTinTonKho.MaSanPham = ChiTietHoaDonBan.MaSanPham;
            -- Check if any product stock falls below 0
            IF EXISTS (SELECT 1 FROM ThongTinTonKho WHERE SoLuongTonKho < 0)
            BEGIN
                -- Rollback the transaction if stock falls below 0
                RAISERROR('Số lượng tồn kho không đủ, vui lòng kiểm tra lại.', 16, 1);
                ROLLBACK TRANSACTION;
                RETURN;
            END;
            UPDATE HoaDonBan
            SET NgayThanhToan = GETDATE()
            WHERE MaHoaDonBan = @MaHoaDonBan;
        END
        ELSE IF @TrangThaiThanhToan_old = N'Đã thanh toán'
        BEGIN
            RAISERROR('Không thể cập nhật hoá đơn bán đã thanh toán', 16, 1);
            ROLLBACK TRANSACTION;
        END;
        -- If no issues, commit the transaction
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback the transaction in case of any error
        ROLLBACK TRANSACTION; -- Retrieve error information
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;
        DECLARE @ErrorLine INT;

        SET @ErrorMessage = ERROR_MESSAGE();
        SET @ErrorSeverity = ERROR_SEVERITY();
        SET @ErrorState = ERROR_STATE();
        SET @ErrorLine = ERROR_LINE();

        -- Raise a detailed error with the retrieved information
        RAISERROR('Error occurred at line %d: %s (Severity: %d, State: %d)',
                     @ErrorSeverity,
                     @ErrorState,
                     @ErrorLine,
                     @ErrorMessage,
                     @ErrorSeverity,
                     @ErrorState
                     );
    END CATCH;

END;

go

ALTER TRIGGER [dbo].[TRG_HoaDonBan_UPDATE]
ON [dbo].[HoaDonBan]
AFTER UPDATE
AS
BEGIN

    BEGIN TRY
        -- Start a transaction
        BEGIN TRANSACTION;
        DECLARE @MaHoaDonBan INT = (SELECT MaHoaDonBan FROM inserted);
        DECLARE @TrangThaiThanhToan_new NVARCHAR(50) = (SELECT TrangThaiThanhToan FROM inserted);
        DECLARE @TrangThaiThanhToan_old NVARCHAR(50) = (SELECT TrangThaiThanhToan FROM deleted);

        IF @TrangThaiThanhToan_new = N'Đã thanh toán'
           AND @TrangThaiThanhToan_old = N'Chưa thanh toán'
        BEGIN
            -- Cập nhật tồn kho cho sản phẩm đã bán
            UPDATE ThongTinTonKho
            SET SoLuongTonKho = SoLuongTonKho - ChiTietHoaDonBan.SoLuong
            FROM ChiTietHoaDonBan
            WHERE ChiTietHoaDonBan.MaHoaDonBan = @MaHoaDonBan
                  AND ThongTinTonKho.MaSanPham = ChiTietHoaDonBan.MaSanPham;
            -- Check if any product stock falls below 0
            IF EXISTS (SELECT 1 FROM ThongTinTonKho WHERE SoLuongTonKho < 0)
            BEGIN
                -- Rollback the transaction if stock falls below 0
                RAISERROR('Số lượng tồn kho không đủ, vui lòng kiểm tra lại.', 16, 1);
                ROLLBACK TRANSACTION;
                RETURN;
            END;
            UPDATE HoaDonBan
            SET NgayThanhToan = GETDATE()
            WHERE MaHoaDonBan = @MaHoaDonBan;

			-- cập nhật revenue trong table DoanhThuThang--
			
			DECLARE @Month INT = MONTH(GETDATE())
			DECLARE @Year INT = YEAR(GETDATE())
			DECLARE @revenue INT;
			DECLARE @doanhthu DECIMAL(18, 2) = dbo.fn_TongDoanhThuTheoThang(@Month,@Year);
			SET @revenue = CONVERT(INT,@doanhthu);
			

			IF EXISTS (SELECT 1 FROM DoanhThuThang WHERE month = @Month AND year = @Year)
			BEGIN
				-- Nếu tồn tại thì update
				UPDATE DoanhThuThang
				SET revenue = @Revenue
				WHERE month = @Month AND year = @Year;
			END
			ELSE
			BEGIN
				-- Nếu không tồn tại thì thêm mới
				INSERT INTO DoanhThuThang (month, year, revenue)
				VALUES (@Month, @Year, @Revenue);
			END
        END
        ELSE IF @TrangThaiThanhToan_old = N'Đã thanh toán'
        BEGIN
            RAISERROR('Không thể cập nhật hoá đơn bán đã thanh toán', 16, 1);
            ROLLBACK TRANSACTION;
        END;
        -- If no issues, commit the transaction
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback the transaction in case of any error
        ROLLBACK TRANSACTION; -- Retrieve error information
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;
        DECLARE @ErrorLine INT;

        SET @ErrorMessage = ERROR_MESSAGE();
        SET @ErrorSeverity = ERROR_SEVERITY();
        SET @ErrorState = ERROR_STATE();
        SET @ErrorLine = ERROR_LINE();

        -- Raise a detailed error with the retrieved information
        RAISERROR('Error occurred at line %d: %s (Severity: %d, State: %d)',
                     @ErrorSeverity,
                     @ErrorState,
                     @ErrorLine,
                     @ErrorMessage,
                     @ErrorSeverity,
                     @ErrorState
                     );
    END CATCH;

END;

GO



-- Trigger cập nhật thời gian làm việc của nhân viên khi check-in/check-out
DROP TRIGGER IF EXISTS TRG_PhanCa_UPDATE;
GO
CREATE TRIGGER TRG_PhanCa_UPDATE
ON PhanCa
AFTER UPDATE
AS
BEGIN
    -- Kiểm tra trạng thái check-in và check-out, nếu đã check-in/check-out thì giữ nguyên thời gian check-in/check-out ban dầu
    DECLARE @CheckIn_old NVARCHAR(50) = (SELECT CheckIn
    FROM deleted);
    DECLARE @CheckOut_old NVARCHAR(50) = (SELECT CheckOut
    FROM deleted);
    DECLARE @CheckIn_new NVARCHAR(50) = (SELECT CheckIn
    FROM inserted);
    DECLARE @CheckOut_new NVARCHAR(50) = (SELECT CheckOut
    FROM inserted);

    DECLARE @MaNhanVien INT = (SELECT MaNhanVien
    FROM inserted);
    DECLARE @MaCa INT = (SELECT MaCa
    FROM inserted);
    DECLARE @Ngay DATE = (SELECT Ngay
    FROM inserted);

    -- Nếu giá trị CheckIn đã tồn tại, quay lại giá trị cũ
    IF @CheckIn_old IS NOT NULL
    BEGIN
        UPDATE PhanCa
        SET CheckIn = @CheckIn_old
        WHERE  MaNhanvien = @MaNhanVien AND MaCa = @MaCa AND Ngay = @Ngay;
    END;
    -- Nếu giá trị CheckOut đã tồn tại, quay lại giá trị cũ
    IF @CheckOut_old IS NOT NULL
    BEGIN
        UPDATE PhanCa
        SET CheckOut = @CheckOut_old
        WHERE  MaNhanvien = @MaNhanVien AND MaCa = @MaCa AND Ngay = @Ngay;
    END;
END;

-----------------------
GO

CREATE FUNCTION fn_CheckValidEmail  
(  
    @email NVARCHAR(MAX)  
)
RETURNS BIT
AS
BEGIN
    RETURN IIF(@email LIKE '%@%.%', 1, 0)
END
go
CREATE FUNCTION fn_CheckValidPhoneNumber  
(  
    @phone NVARCHAR(MAX)  
)
RETURNS BIT
AS
BEGIN
    if (LEN(@phone) < 10 or LEN(@phone) > 11)
        RETURN 0
    if (PATINDEX('%[^0-9]%', @phone) > 0)
        RETURN 0
    RETURN 1
END
go

-- function trả về danh sách sản phẩm trong hoá đơn nhập
create function fn_DanhSachSanPhamTrongHoaDonNhap(@MaHoaDonNhap INT)
returns TABLE
as
RETURN
(
    SELECT 
        cthdn.MaSanPham 'Mã SP', 
        sp.TenSanPham 'Tên SP',
        cthdn.SoLuong 'Số Lượng',
        cthdn.DonGia 'Đơn Giá',
        cthdn.TongTien 'Tổng Tiền'
    FROM ChiTietHoaDonNhap cthdn
    JOIN SanPham sp ON cthdn.MaSanPham = sp.MaSanPham
    WHERE cthdn.MaHoaDonNhap = @MaHoaDonNhap
);
go
-- gọi function
-- select * from fn_DanhSachSanPhamTrongHoaDonNhap(1)

go
-- function trả về danh sách sản phẩm trong hoá đơn bán
create function fn_DanhSachSanPhamTrongHoaDonBan(@MaHoaDonBan INT)
returns TABLE
as
RETURN
(
    SELECT 
        cthdb.MaSanPham 'Mã SP', 
        sp.TenSanPham 'Tên SP',
        cthdb.SoLuong 'Số Lượng',
        cthdb.DonGia 'Đơn Giá',
        cthdb.TongTien 'Tổng Tiền'
    FROM ChiTietHoaDonBan cthdb
    JOIN SanPham sp ON cthdb.MaSanPham = sp.MaSanPham
    WHERE cthdb.MaHoaDonBan = @MaHoaDonBan
);
GO
-- hàm trả về danh sách sản phẩm đã bán trong ngày (nhận ngày làm tham số)
CREATE FUNCTION fn_DanhSachSanPhamDaBanTrongNgay(@Ngay DATE)
RETURNS TABLE
AS
RETURN
(
    SELECT
        SP.MaSanPham 'Mã SP',
        SP.TenSanPham 'Tên SP',
        SUM(CTHDB.SoLuong) 'SL Đã Bán',
        HDB.NgayLap 'Ngày Lập'
    FROM
        ChiTietHoaDonBan CTHDB
        JOIN
        HoaDonBan HDB ON CTHDB.MaHoaDonBan = HDB.MaHoaDonBan
        JOIN
        SanPham SP ON CTHDB.MaSanPham = SP.MaSanPham
    WHERE 
            CAST(HDB.NgayLap AS DATE) = @Ngay and HDB.TrangThaiThanhToan=N'Đã thanh toán'
    GROUP BY 
            SP.MaSanPham, SP.TenSanPham, HDB.NgayLap
);
go


-- hàm trả về ds lương nhân viên theo ngày
-- có 3 ca, ca1,ca2,ca3
-- làm ca1 và ca2 bắt buộc làm đủ 8h trở lên, lương tính theo lươngtheogiờ/h, mất 1h trừ 150% luongtheogio của nhân viên đó
-- ca 3 không bắt buộc, lương tính bth theo giờ.
-- tổng giờ của ca 1 và ca 2  >= 8h thì lương = tổng giờ làm * lươngtheogio/h
-- tổng giờ của ca 1 và ca 2  < 8h thì lương = tổng giờ làm * lươngtheogio/h - (8 - tổng giờ làm) * 1.5 * lươngtheogio/h
-- lương của ca 3 = tổng giờ làm của ca 3* lươngtheogio/h
-- lương của nhân viên = lương của ca12 + lương của ca 3


-----------huhuhuhuhuuhuhu
CREATE FUNCTION fn_DanhSachLuongNhanVienTheoNgay(@Ngay DATE)
RETURNS TABLE
AS
RETURN
(
    WITH TongGioLamCa1Ca2 AS (
        SELECT 
            p.MaNhanVien,
            nv.Hoten,
            case 
                when SUM(DATEDIFF(HOUR, p.checkin, p.checkout)) is not null then SUM(DATEDIFF(HOUR, p.checkin, p.checkout))
                else 0
            end AS tonggiolam
        FROM PhanCa p
        JOIN NhanVien nv ON p.MaNhanVien = nv.MaNhanVien
        WHERE p.ngay = @Ngay
        GROUP BY p.MaNhanVien, nv.HoTen, p.maca
        having p.MaCa in (1, 2)
    ),
    LuongCa1Ca2 AS (
        SELECT
            t.MaNhanVien,
            t.Hoten,
            CASE 
                WHEN sum(t.tonggiolam) >= 8 THEN sum(t.tonggiolam) * cv.luongtheogio -- Đủ 8 giờ hoặc hơn
                ELSE (sum(t.tonggiolam) * cv.Luongtheogio) - ((8 - sum(t.tonggiolam)) * 1.5 * cv.luongtheogio) -- Thiếu giờ
            END AS luong
        FROM TongGioLamCa1Ca2 t
        JOIN NhanVien n ON t.MaNhanVien = n.MaNhanVien
        JOIN ChucVu cv ON n.MaChucVu = cv.MaChucVu
        group by t.MaNhanVien, t.Hoten, cv.luongtheogio
    ),
    LuongCa3 AS (
            SELECT
            n.MaNhanVien,
            n.Hoten,
            case 
                when SUM(DATEDIFF(HOUR, p.checkin, p.checkout))*cv.luongtheogio is not null then SUM(DATEDIFF(HOUR, p.checkin, p.checkout))*cv.luongtheogio
                else 0
                end AS luong
        from NhanVien n 
        JOIN ChucVu cv ON n.MaChucVu = cv.MaChucVu
        Join PhanCa p ON n.MaNhanVien = p.MaNhanVien
        group by n.MaNhanVien, n.Hoten, p.maca, cv.luongtheogio
        HAVING p.maca = 3
    )
    -- Kết hợp lương ca 1, ca 2, ca 3
    SELECT MaNhanVien 'Mã NV', Hoten 'Họ Tên', SUM(luong) AS 'Lương Ngày'
    FROM (
        SELECT * FROM LuongCa1Ca2
        UNION ALL
        SELECT * FROM LuongCa3
    ) AS Luong
    GROUP BY MaNhanVien, Hoten
);
GO

CREATE FUNCTION fn_TongLuongPhaiTraTheoThang(@Thang INT, @Nam INT)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TongLuong DECIMAL(18, 2) = 0;

    -- Tính tổng lương phải trả từ hàm fn_DanhSachLuongNhanVienTheoThang
    SELECT @TongLuong = ISNULL(SUM([Lương Tháng]), 0)
    FROM fn_DanhSachLuongNhanVienTheoThang(@Thang, @Nam);

    -- Trả về tổng lương
    RETURN @TongLuong;
END;
go
go
CREATE FUNCTION fn_DoanhThuBanHangTheoThang(@Thang INT, @Nam INT)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        sp.MaSanPham AS 'Mã Sản Phẩm',
        sp.TenSanPham AS 'Tên Sản Phẩm',
        SUM(cthdb.SoLuong) AS 'Số Lượng Bán',
        SUM(cthdb.SoLuong * sp.GiaBan) AS 'Tổng Doanh Thu'
    FROM HoaDonBan hdb
    JOIN ChiTietHoaDonBan cthdb ON hdb.MaHoaDonBan = cthdb.MaHoaDonBan
    JOIN SanPham sp ON cthdb.MaSanPham = sp.MaSanPham
    WHERE MONTH(hdb.NgayLap) = @Thang AND YEAR(hdb.NgayLap) = @Nam
    GROUP BY sp.MaSanPham, sp.TenSanPham
);
go
CREATE FUNCTION fn_ChiPhiNhapHangTheoThang(@Thang INT, @Nam INT)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        sp.MaSanPham AS 'Mã Sản Phẩm',
        sp.TenSanPham AS 'Tên Sản Phẩm',
        SUM(cthdn.SoLuong) AS 'Số Lượng Nhập',
        SUM(cthdn.SoLuong * cthdn.DonGia) AS 'Tổng Tiền Nhập'
    FROM HoaDonNhap hdn
    JOIN ChiTietHoaDonNhap cthdn ON hdn.MaHoaDonNhap = cthdn.MaHoaDonNhap
    JOIN SanPham sp ON cthdn.MaSanPham = sp.MaSanPham
    WHERE MONTH(hdn.NgayLap) = @Thang AND YEAR(hdn.NgayLap) = @Nam
    GROUP BY sp.MaSanPham, sp.TenSanPham
);
go
CREATE FUNCTION fn_DanhSachLuongNhanVienTheoThang(@Thang INT, @Nam INT)
RETURNS TABLE
AS
RETURN
(
    WITH TongGioLamCa1Ca2 AS (
        SELECT 
            p.MaNhanVien,
            nv.Hoten,
            case 
                when SUM(DATEDIFF(HOUR, p.checkin, p.checkout)) is not null then SUM(DATEDIFF(HOUR, p.checkin, p.checkout))
                else 0
            end AS tonggiolam,
            DAY(p.ngay) AS Ngay
        FROM PhanCa p
        JOIN NhanVien nv ON p.MaNhanVien = nv.MaNhanVien
        WHERE MONTH(p.ngay) = @Thang AND YEAR(p.ngay) = @Nam
        GROUP BY p.MaNhanVien, nv.HoTen, p.maca, DAY(p.ngay)
        HAVING p.MaCa IN (1, 2)
    ),
    LuongCa1Ca2 AS (
        SELECT
            t.MaNhanVien,
            t.Hoten,
            t.Ngay,
            CASE 
                WHEN SUM(t.tonggiolam) >= 8 THEN SUM(t.tonggiolam) * cv.luongtheogio -- Đủ 8 giờ hoặc hơn
                ELSE (SUM(t.tonggiolam) * cv.Luongtheogio) - ((8 - SUM(t.tonggiolam)) * 1.5 * cv.luongtheogio) -- Thiếu giờ
            END AS luong
        FROM TongGioLamCa1Ca2 t
        JOIN NhanVien n ON t.MaNhanVien = n.MaNhanVien
        JOIN ChucVu cv ON n.MaChucVu = cv.MaChucVu
        GROUP BY t.MaNhanVien, t.Hoten, t.Ngay, cv.luongtheogio
    ),
    LuongCa3 AS (
        SELECT
            n.MaNhanVien,
            n.Hoten,
            DAY(p.ngay) AS Ngay,
            CASE 
                WHEN SUM(DATEDIFF(HOUR, p.checkin, p.checkout)) * cv.luongtheogio IS NOT NULL 
                THEN SUM(DATEDIFF(HOUR, p.checkin, p.checkout)) * cv.luongtheogio
                ELSE 0
            END AS luong
        FROM NhanVien n 
        JOIN ChucVu cv ON n.MaChucVu = cv.MaChucVu
        JOIN PhanCa p ON n.MaNhanVien = p.MaNhanVien
        WHERE MONTH(p.ngay) = @Thang AND YEAR(p.ngay) = @Nam
        GROUP BY n.MaNhanVien, n.Hoten, p.maca, cv.luongtheogio, DAY(p.ngay)
        HAVING p.MaCa = 3
    )
    -- Kết hợp lương ca 1, ca 2, ca 3 cho mỗi ngày trong tháng
    , LuongTheoNgay AS (
        SELECT MaNhanVien, Hoten, Ngay, SUM(luong) AS LuongNgay
        FROM (
            SELECT MaNhanVien, Hoten, Ngay, luong FROM LuongCa1Ca2
            UNION ALL
            SELECT MaNhanVien, Hoten, Ngay, luong FROM LuongCa3
        ) AS LuongNgay
        GROUP BY MaNhanVien, Hoten, Ngay
    )
    -- Tính tổng lương trong tháng
    SELECT MaNhanVien 'Mã NV', Hoten 'Họ Tên', SUM(LuongNgay) AS 'Lương Tháng'
    FROM LuongTheoNgay
    GROUP BY MaNhanVien, Hoten
);
GO



-- procedure thêm sp
CREATE procedure sp_ThemSanPham
    @TenSanPham NVARCHAR(50),
    @MaLoaiSanPham INT
AS
BEGIN
    -- check empty fields
        IF @TenSanPham = '' or @TenSanPham IS NULL or @MaLoaiSanPham = '' or @MaLoaiSanPham IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập thông tin hợp lệ', 16, 1)
            RETURN
        END
        insert into SanPham
            (TenSanPham, MaLoaiSanPham)
        values(@TenSanPham, @MaLoaiSanPham)
END
go
-- procedure sửa sp
CREATE procedure sp_SuaSanPham
    @MaSanPham INT,
    @TenSanPham NVARCHAR(50),
    @GiaNhap FLOAT,
    @GiaBan FLOAT,
    @MaLoaiSanPham INT,
    @SoLuongTonKho INT
AS
BEGIN

        -- check empty fields
        IF @TenSanPham = '' or @GiaNhap = '' or @GiaBan = '' or @MaLoaiSanPham = '' or @SoLuongTonKho = ''
            or @TenSanPham IS NULL or @GiaNhap IS NULL or @GiaBan IS NULL or @MaLoaiSanPham IS NULL or @SoLuongTonKho IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        IF @SoLuongTonKho < 0
        BEGIN
            RAISERROR('Số lượng tồn kho không hợp lệ', 16, 1)
            RETURN
        END
        UPDATE SanPham
        SET TenSanPham = @TenSanPham, MaLoaiSanPham = @MaLoaiSanPham,
            GiaNhap = @GiaNhap, GiaBan = @GiaBan
        WHERE MaSanPham = @MaSanPham
        UPDATE ThongTinTonKho
        SET SoLuongTonKho = @SoLuongTonKho
        WHERE MaSanPham = @MaSanPham
    
END

-- go
-- -- procedure xóa sp
-- CREATE procedure sp_XoaSanPham
--     @MaSanPham INT
-- AS
-- BEGIN
    
--         IF @MaSanPham = '' or @MaSanPham IS NULL
--         BEGIN
--             RAISERROR('Vui lòng nhập mã sản phẩm', 16, 1)
--             RETURN
--         END
--         DELETE FROM SanPham
--         WHERE MaSanPham = @MaSanPham
-- END
go
--procedure them loai sp
go
CREATE procedure sp_ThemLoaiSanPham
    @TenLoaiSanPham NVARCHAR(50)
AS
BEGIN
    -- check empty fields
        IF @TenLoaiSanPham = '' or @TenLoaiSanPham IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        insert into LoaiSanPham
            (TenLoaiSanPham)
        values(@TenLoaiSanPham)
END
go

-- procedure xoá loại sp
go
CREATE procedure sp_XoaLoaiSanPham
    @MaLoaiSanPham INT
AS
BEGIN
    
        IF @MaLoaiSanPham = '' or @MaLoaiSanPham IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập mã loại sản phẩm', 16, 1)
            RETURN
        END
        DELETE FROM LoaiSanPham
        WHERE MaLoaiSanPham = @MaLoaiSanPham
    
    
END
go
-- procedure sửa loại sp
go
CREATE procedure sp_SuaLoaiSanPham
    @MaLoaiSanPham INT,
    @TenLoaiSanPham NVARCHAR(50)
AS
BEGIN
    
    -- check empty fields
        IF @TenLoaiSanPham = '' or @TenLoaiSanPham IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        UPDATE LoaiSanPham
        SET TenLoaiSanPham = @TenLoaiSanPham
        WHERE MaLoaiSanPham = @MaLoaiSanPham
    
    
END
go
-- procedure them nhan vien
CREATE procedure sp_ThemNhanVien
    @HoTen NVARCHAR(50),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @DiaChi NVARCHAR(100),
    @SoDienThoai NVARCHAR(15),
    @Email VARCHAR(50),
    @MaChucVu INT
AS
BEGIN

    -- check empty fields
        IF @HoTen = '' or @NgaySinh = '' or @GioiTinh = '' or @DiaChi = '' or @SoDienThoai = '' or @Email = '' or @MaChucVu = ''
            or @HoTen IS NULL or @NgaySinh IS NULL or @GioiTinh IS NULL or @DiaChi IS NULL or @SoDienThoai IS NULL or @Email IS NULL or @MaChucVu IS NULL
            or @NgaySinh > GETDATE()
        BEGIN
            RAISERROR('Vui lòng nhập thông tin hợp lệ', 16, 1)
            RETURN
        END
        -- check valid phone number
        IF (dbo.fn_CheckValidPhoneNumber(@SoDienThoai) = 0)
        BEGIN
            RAISERROR('Số điện thoại không hợp lệ', 16, 1)
            RETURN
        END
        -- check valid email
        IF (dbo.fn_CheckValidEmail(@Email) = 0)
        BEGIN
            RAISERROR('Email không hợp lệ', 16, 1)
            RETURN
        END
        -- check unique phone number
        IF EXISTS (select 1
        FROM NhanVien
        WHERE SoDienThoai = @SoDienThoai)
        BEGIN
            RAISERROR('Số điện thoại đã tồn tại', 16, 1)
            RETURN
        END
        -- check unique email
        IF EXISTS (select 1
        FROM NhanVien
        WHERE Email = @Email)
        BEGIN
            RAISERROR('Email đã tồn tại', 16, 1)
            RETURN
        END
        insert into NhanVien
            (HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, MaChucVu)
        values(@HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai, @Email, @MaChucVu)
    
    
END
GO

go
--procedure sữa nhân viên
CREATE procedure sp_UpdateNhanVien
    @MaNhanVien INT,
    @HoTen NVARCHAR(50),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @DiaChi NVARCHAR(100),
    @SoDienThoai NVARCHAR(15),
    @Email VARCHAR(50),
    @MaChucVu INT
AS
BEGIN
    
    -- check empty fields
        IF @HoTen = '' or @NgaySinh = '' or @GioiTinh = '' or @DiaChi = '' or @SoDienThoai = '' or @Email = '' or @MaChucVu = ''
            or @HoTen IS NULL or @NgaySinh IS NULL or @GioiTinh IS NULL or @DiaChi IS NULL or @SoDienThoai IS NULL or @Email IS NULL or @MaChucVu IS NULL
            or @NgaySinh > GETDATE()
        BEGIN
            RAISERROR('Vui lòng nhập thông tin hợp lệ', 16, 1)
            RETURN
        END
        -- check valid phone number (by fn_CheckValidPhoneNumber)
        IF (dbo.fn_CheckValidPhoneNumber(@SoDienThoai) = 0)
        BEGIN
            RAISERROR('Số điện thoại không hợp lệ', 16, 1)
            RETURN
        END
        -- check valid email
        IF (dbo.fn_CheckValidEmail(@Email) = 0)
        BEGIN
            RAISERROR('Email không hợp lệ', 16, 1)
            RETURN
        END
        -- check unique phone number
        -- lấy ra sdt hiện tại của nhân viên
        declare @sdtCu NVARCHAR(15)= (select SoDienThoai
        FROM NhanVien
        WHERE MaNhanVien = @MaNhanVien)
        IF @sdtCu != @SoDienThoai
        BEGIN
            IF (select count(*)
            FROM NhanVien
            WHERE SoDienThoai = @SoDienThoai) > 0
            BEGIN
                RAISERROR('Số điện thoại đã tồn tại', 16, 1)
                RETURN
            END
        END
        -- check unique email
        -- lấy ra email hiện tại của nhân viên
        declare @emailCu VARCHAR(50)= (select Email
        FROM NhanVien
        WHERE MaNhanVien = @MaNhanVien)
        IF @emailCu != @Email
        BEGIN
            IF (select count(*)
            FROM NhanVien
            WHERE Email = @Email) > 0
            BEGIN
                RAISERROR('Email đã tồn tại', 16, 1)
                RETURN
            END
        END
        UPDATE NhanVien
        SET HoTen = @HoTen,
            NgaySinh = @NgaySinh,
            GioiTinh = @GioiTinh,
            DiaChi = @DiaChi,
            SoDienThoai = @SoDienThoai,
            Email = @Email,
            MaChucVu = @MaChucVu
        WHERE MaNhanVien = @MaNhanVien
    
    
END
-- EXEC sp_UpdateNhanVien 3, N'Nguyễn Văn A', '1999-01-01', N'Nam', N'Địa chỉ 1', '0123456820', 's@gmail.com', 2
go
-- -- procedure xóa nhân viên
-- CREATE procedure sp_XoaNhanVien
--     @MaNhanVien INT
-- AS
-- BEGIN
    
--         IF @MaNhanVien = '' or @MaNhanVien IS NULL
--         BEGIN
--             RAISERROR('Vui lòng nhập mã nhân viên', 16, 1)
--             RETURN
--         END
--         DELETE FROM NhanVien
--         WHERE MaNhanVien = @MaNhanVien
    

-- END
-- go

--- procedure thêm nhà cung cấp
CREATE procedure sp_ThemNhaCungCap
    @TenNhaCungCap NVARCHAR(50),
    @DiaChi NVARCHAR(100),
    @SoDienThoai NVARCHAR(15)
AS
BEGIN
    
    -- check empty fields
        IF @TenNhaCungCap = '' or @DiaChi = '' or @SoDienThoai = ''
            or @TenNhaCungCap IS NULL or @DiaChi IS NULL or @SoDienThoai IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        -- check valid phone number (by fn_CheckValidPhoneNumber)
        IF (dbo.fn_CheckValidPhoneNumber(@SoDienThoai) = 0)
        BEGIN
            RAISERROR('Số điện thoại không hợp lệ', 16, 1)
            RETURN
        END
        -- check unique phone number
        IF EXISTS (select 1
        FROM NhaCungCap
        WHERE SoDienThoai = @SoDienThoai)
        BEGIN
            RAISERROR('Số điện thoại đã tồn tại', 16, 1)
            RETURN
        END
        insert into NhaCungCap
            (TenNhaCungCap, DiaChi, SoDienThoai)
        values(@TenNhaCungCap, @DiaChi, @SoDienThoai)
    
    
END
GO
go
-- procedure sửa nhà cung cấp
CREATE procedure sp_SuaNhaCungCap
    @MaNhaCungCap INT,
    @TenNhaCungCap NVARCHAR(50),
    @DiaChi NVARCHAR(100),
    @SoDienThoai NVARCHAR(15)
AS
BEGIN
    
    -- check empty fields
        IF @TenNhaCungCap = '' or @DiaChi = '' or @SoDienThoai = ''
            or @TenNhaCungCap IS NULL or @DiaChi IS NULL or @SoDienThoai IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        -- check valid phone number (by fn_CheckValidPhoneNumber)
        IF (dbo.fn_CheckValidPhoneNumber(@SoDienThoai) = 0)
        BEGIN
            RAISERROR('Số điện thoại không hợp lệ', 16, 1)
            RETURN
        END
        -- check unique phone number
        -- lấy ra sdt hiện tại của nhà cung cấp
        declare @sdtCu NVARCHAR(15)= (select SoDienThoai
        FROM NhaCungCap
        WHERE MaNhaCungCap = @MaNhaCungCap)
        IF @sdtCu != @SoDienThoai
        BEGIN
            IF (select count(*)
            FROM NhaCungCap
            WHERE SoDienThoai = @SoDienThoai) > 0
            BEGIN
                RAISERROR('Số điện thoại đã tồn tại', 16, 1)
                RETURN
            END
        END
        UPDATE NhaCungCap
        SET TenNhaCungCap = @TenNhaCungCap,
            DiaChi = @DiaChi,
            SoDienThoai = @SoDienThoai
        WHERE MaNhaCungCap = @MaNhaCungCap
    
    
END
GO
-- -- procedure xóa nhà cung cấp
-- CREATE procedure sp_XoaNhaCungCap
--     @MaNhaCungCap INT
-- AS
-- BEGIN
    
--         IF @MaNhaCungCap = '' or @MaNhaCungCap IS NULL
--         BEGIN
--             RAISERROR('Vui lòng nhập mã nhà cung cấp', 16, 1)
--             RETURN
--         END
--         DELETE FROM NhaCungCap
--         WHERE MaNhaCungCap = @MaNhaCungCap
    
    
-- END

go
---procedure them khach hang
CREATE procedure sp_ThemKhachHang
    @HoTen NVARCHAR(50),
    @DiaChi NVARCHAR(100),
    @SoDienThoai NVARCHAR(15)
AS
BEGIN
    
    -- check empty fields
        IF @HoTen = '' or @DiaChi = '' or @SoDienThoai = ''
            or @HoTen IS NULL or @DiaChi IS NULL or @SoDienThoai IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        -- check valid phone number (by fn_CheckValidPhoneNumber)
        IF (dbo.fn_CheckValidPhoneNumber(@SoDienThoai) = 0)
        BEGIN
            RAISERROR('Số điện thoại không hợp lệ', 16, 1)
            RETURN
        END
        -- check unique phone number
        IF EXISTS (select 1
        FROM KhachHang
        WHERE SoDienThoai = @SoDienThoai)
        BEGIN
            RAISERROR('Số điện thoại đã tồn tại', 16, 1)
            RETURN
        END
        insert into KhachHang
            (HoTen, DiaChi, SoDienThoai)
        values(@HoTen, @DiaChi, @SoDienThoai)
    
    
END
GO

go
-- procedure sửa khách hàng
CREATE procedure sp_SuaKhachHang
    @MaKhachHang INT,
    @HoTen NVARCHAR(50),
    @DiaChi NVARCHAR(100),
    @SoDienThoai NVARCHAR(15)
AS
BEGIN
    
    -- check empty fields
        IF @HoTen = '' or @DiaChi = '' or @SoDienThoai = ''
            or @HoTen IS NULL or @DiaChi IS NULL or @SoDienThoai IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        -- check valid phone number (by fn_CheckValidPhoneNumber)
        IF (dbo.fn_CheckValidPhoneNumber(@SoDienThoai) = 0)
        BEGIN
            RAISERROR('Số điện thoại không hợp lệ', 16, 1)
            RETURN
        END
        -- check unique phone number
        -- lấy ra sdt hiện tại của khách hàng
        declare @sdtCu NVARCHAR(15)= (select SoDienThoai
        FROM KhachHang
        WHERE MaKhachHang = @MaKhachHang)
        IF @sdtCu != @SoDienThoai
        BEGIN
            IF (select count(*)
            FROM KhachHang
            WHERE SoDienThoai = @SoDienThoai) > 0
            BEGIN
                RAISERROR('Số điện thoại đã tồn tại', 16, 1)
                RETURN
            END
        END
        UPDATE KhachHang
        SET HoTen = @HoTen,
            DiaChi = @DiaChi,
            SoDienThoai = @SoDienThoai
        WHERE MaKhachHang = @MaKhachHang
    
    
END
GO
-- -- procedure xóa khách hàng
-- CREATE procedure sp_XoaKhachHang
--     @MaKhachHang INT
-- AS
-- BEGIN
    
--         IF @MaKhachHang = '' or @MaKhachHang IS NULL
--         BEGIN
--             RAISERROR('Vui lòng nhập mã khách hàng', 16, 1)
--             RETURN
--         END
--         DELETE FROM KhachHang
--         WHERE MaKhachHang = @MaKhachHang
    
    
-- END

go
-- procedure thêm hóa đơn nhập
CREATE procedure sp_ThemHoaDonNhap
    @MaNhanVien INT,
    @MaNhaCungCap INT
AS
BEGIN
    
    --check empty fields
        IF @MaNhanVien = '' or @MaNhaCungCap = '' or @MaNhanVien IS NULL or @MaNhaCungCap IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        insert into HoaDonNhap
            (MaNhanVien, MaNhaCungCap)
        values(@MaNhanVien, @MaNhaCungCap)
    
    
END
go
-- procedure cập nhật trạng thái thanh toán hóa đơn nhập
CREATE procedure sp_CapNhatTrangThaiThanhToanHoaDonNhap
    @MaHoaDonNhap INT,
    @TrangThaiThanhToan NVARCHAR(50)
AS
BEGIN
    
        IF @TrangThaiThanhToan = '' or @TrangThaiThanhToan IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập trạng thái thanh toán', 16, 1)
            RETURN
        END
        IF @TrangThaiThanhToan != N'Đã thanh toán' and @TrangThaiThanhToan != N'Chưa thanh toán'
        BEGIN
            RAISERROR('Trạng thái thanh toán không hợp lệ', 16, 1)
            RETURN
        END
        UPDATE HoaDonNhap
        SET TrangThaiThanhToan = @TrangThaiThanhToan
        WHERE MaHoaDonNhap = @MaHoaDonNhap
    
    
END
go
-- -- procedure xoá hóa đơn nhập
-- CREATE procedure sp_XoaHoaDonNhap
--     @MaHoaDonNhap INT
-- AS
-- BEGIN
    
--         IF @MaHoaDonNhap = '' or @MaHoaDonNhap IS NULL
--         BEGIN
--             RAISERROR('Vui lòng nhập mã hóa đơn nhập', 16, 1)
--             RETURN
--         END
--         DELETE FROM HoaDonNhap
--         WHERE MaHoaDonNhap = @MaHoaDonNhap
    
    
-- END

go
-- procedure thêm hoá đơn bán
CREATE procedure sp_ThemHoaDonBan
    @MaNhanVien INT,
    @MaKhachHang INT
AS
BEGIN
    
        IF @MaNhanVien = '' or @MaKhachHang = '' or @MaNhanVien IS NULL or @MaKhachHang IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END

        insert into HoaDonBan
            (MaNhanVien, MaKhachHang)
        values(@MaNhanVien, @MaKhachHang)
    
    
END
go
-- procedure cập nhật trạng thái thanh toán hóa đơn bán
CREATE procedure sp_CapNhatTrangThaiThanhToanHoaDonBan
    @MaHoaDonBan INT,
    @TrangThaiThanhToan NVARCHAR(50)
AS
BEGIN
    
        IF @TrangThaiThanhToan = '' or @TrangThaiThanhToan IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập trạng thái thanh toán', 16, 1)
            RETURN
        END
        IF @TrangThaiThanhToan != N'Đã thanh toán' and @TrangThaiThanhToan != N'Chưa thanh toán'
        BEGIN
            RAISERROR('Trạng thái thanh toán không hợp lệ', 16, 1)
            RETURN
        END
        UPDATE HoaDonBan
        SET TrangThaiThanhToan = @TrangThaiThanhToan
        WHERE MaHoaDonBan = @MaHoaDonBan
    
    
END
go
-- -- procedure xoá hóa đơn bán
-- CREATE procedure sp_XoaHoaDonBan
--     @MaHoaDonBan INT
-- AS
-- BEGIN
    
--         IF @MaHoaDonBan = '' or @MaHoaDonBan IS NULL
--         BEGIN
--             RAISERROR('Vui lòng nhập mã hóa đơn bán', 16, 1)
--             RETURN
--         END
--         DELETE FROM HoaDonBan
--         WHERE MaHoaDonBan = @MaHoaDonBan
    
    
-- END
go
-- procedure thêm chi tiết hóa đơn nhập
CREATE procedure sp_ThemChiTietHoaDonNhap
    @MaHoaDonNhap INT,
    @MaSanPham INT,
    @SoLuong INT,
    @DonGia FLOAT
AS
BEGIN
    
        IF @MaHoaDonNhap = '' or @MaSanPham = '' or @SoLuong = '' or @DonGia = '' or @MaHoaDonNhap IS NULL or @MaSanPham IS NULL or @SoLuong IS NULL or @DonGia IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        IF @SoLuong <= 0 or @DonGia <= 0
        BEGIN
            RAISERROR('Số lượng và đơn giá phải lớn hơn 0', 16, 1)
            RETURN
        END

        insert into ChiTietHoaDonNhap
            (MaHoaDonNhap, MaSanPham, SoLuong, DonGia)
        values(@MaHoaDonNhap, @MaSanPham, @SoLuong, @DonGia)
    
    
END
go
-- procedure cập nhật chi tiết hóa đơn nhập
CREATE procedure sp_CapNhatChiTietHoaDonNhap
    @MaHoaDonNhap INT,
    @MaSanPham INT,
    @SoLuong INT,
    @DonGia FLOAT
AS
BEGIN
    
        IF @MaHoaDonNhap = '' or @MaSanPham = '' or @SoLuong = '' or @DonGia = '' or @MaHoaDonNhap IS NULL or @MaSanPham IS NULL or @SoLuong IS NULL or @DonGia IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        IF @SoLuong <= 0 or @DonGia <= 0
        BEGIN
            RAISERROR('Số lượng và đơn giá phải lớn hơn 0', 16, 1)
            RETURN
        END

        UPDATE ChiTietHoaDonNhap
        SET SoLuong = @SoLuong, DonGia = @DonGia
        WHERE MaHoaDonNhap = @MaHoaDonNhap and MaSanPham = @MaSanPham
    
    
END
go
-- procedure xoá chi tiết hóa đơn nhập
CREATE procedure sp_XoaChiTietHoaDonNhap
    @MaHoaDonNhap INT,
    @MaSanPham INT
AS
BEGIN
    
        IF @MaHoaDonNhap = '' or @MaSanPham = '' or @MaHoaDonNhap IS NULL or @MaSanPham IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        DELETE FROM ChiTietHoaDonNhap
        WHERE MaHoaDonNhap = @MaHoaDonNhap and MaSanPham = @MaSanPham
    
    
END
go
-- procedure thêm chi tiết hóa đơn bán
CREATE procedure sp_ThemChiTietHoaDonBan
    @MaHoaDonBan INT,
    @MaSanPham INT,
    @SoLuong INT
AS
BEGIN
    
        IF @MaHoaDonBan = '' or @MaSanPham = '' or @SoLuong = '' or @MaHoaDonBan IS NULL or @MaSanPham IS NULL or @SoLuong IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        IF @SoLuong <= 0
        BEGIN
            RAISERROR('Số lượng phải lớn hơn 0', 16, 1)
            RETURN
        END
        insert into ChiTietHoaDonBan
            (MaHoaDonBan, MaSanPham, SoLuong)
        values(@MaHoaDonBan, @MaSanPham, @SoLuong)
    
    
END
go
-- procedure cập nhật chi tiết hóa đơn bán
CREATE procedure sp_CapNhatChiTietHoaDonBan
    @MaHoaDonBan INT,
    @MaSanPham INT,
    @SoLuong INT
AS
BEGIN
    
        IF @MaHoaDonBan = '' or @MaSanPham = '' or @SoLuong = '' or @MaHoaDonBan IS NULL or @MaSanPham IS NULL or @SoLuong IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        IF @SoLuong <= 0
        BEGIN
            RAISERROR('Số lượng phải lớn hơn 0', 16, 1)
            RETURN
        END
        UPDATE ChiTietHoaDonBan
        SET SoLuong = @SoLuong
        WHERE MaHoaDonBan = @MaHoaDonBan and MaSanPham = @MaSanPham
    
    
END
go
-- procedure xoá chi tiết hóa đơn bán
CREATE procedure sp_XoaChiTietHoaDonBan
    @MaHoaDonBan INT,
    @MaSanPham INT
AS
BEGIN
    
        IF @MaHoaDonBan = '' or @MaSanPham = '' or @MaHoaDonBan IS NULL or @MaSanPham IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        DELETE FROM ChiTietHoaDonBan
        WHERE MaHoaDonBan = @MaHoaDonBan and MaSanPham = @MaSanPham
    
    
END


-- procedure phân ca cho toàn bộ nhân viên từ ngày x đến ngày y
go
drop procedure if exists sp_PhanCaChoNhanVien
go
CREATE PROCEDURE sp_PhanCaChoNhanVien
    @NgayBatDau DATE,
    @NgayKetThuc DATE
AS
BEGIN
    
        IF @NgayBatDau = '' or @NgayKetThuc = '' or @NgayBatDau IS NULL or @NgayKetThuc IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        IF @NgayBatDau > @NgayKetThuc
        BEGIN
            RAISERROR('Ngày bắt đầu phải nhỏ hơn ngày kết thúc', 16, 1)
            RETURN
        END;
        IF @NgayKetThuc > DATEADD(day, 7, @NgayBatDau)
        BEGIN
            RAISERROR('Khoảng thời gian phân ca không được quá 7 ngày', 16, 1)
            RETURN
        END
        while @NgayBatDau <= @NgayKetThuc
        IF NOT EXISTS (SELECT 1
        FROM PhanCa
        WHERE Ngay = @NgayBatDau)  
        BEGIN
            DECLARE @i INT = 1;
            WHILE @i <= 2  
            BEGIN
                DECLARE cur_NhanVien CURSOR FOR  
                    SELECT MaNhanVien
                FROM NhanVien
                WHERE IsActived = 1
                DECLARE @MaNhanVien INT

                OPEN cur_NhanVien
                FETCH NEXT FROM cur_NhanVien INTO @MaNhanVien
                WHILE @@FETCH_STATUS = 0  
                    BEGIN
                    -- Insert từng nhân viên vào bảng phân ca  
                    INSERT INTO PhanCa
                        (MaNhanVien, MaCa, Ngay)
                    VALUES
                        (@MaNhanVien, @i, @NgayBatDau)
                    FETCH NEXT FROM cur_NhanVien INTO @MaNhanVien
                END
                CLOSE cur_NhanVien
                DEALLOCATE cur_NhanVien
                SET @i = @i + 1
            END
            SET @NgayBatDau = DATEADD(day, 1, @NgayBatDau)
        END
        ELSE
        BEGIN
            THROW 50000, 'ca đã được phân trong khoảng này', 1;
        END
    
    
END

GO
-- exec sp_PhanCaChoNhanVien '2024-10-19', '2024-10-22'
GO
DROP TRIGGER IF EXISTS [TRG_PhanCa_INSERT]
GO
-- procedure đăng kí ca 3
-- CREATE PROCEDURE sp_DangKiCa3
--     @MaNhanVien INT,
--     @Ngay DATE
-- AS
-- BEGIN
    
--         IF @MaNhanVien = '' or @Ngay = '' or @MaNhanVien IS NULL or @Ngay IS NULL
--         BEGIN
--             RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
--             RETURN
--         END
--         IF @Ngay < CAST(GETDATE() AS DATE)
--         BEGIN
--             RAISERROR('Ngày đăng kí phải lớn hơn hoặc bằng ngày hiện tại', 16, 1)
--             RETURN
--         END
--         IF @Ngay > DATEADD(day, 3, GETDATE())
--         BEGIN
--             RAISERROR('Ngày đăng kí không được quá 3 ngày', 16, 1)
--             RETURN
--         END
--         IF EXISTS (SELECT 1
--         FROM PhanCa
--         WHERE MaNhanVien = @MaNhanVien AND Ngay = @Ngay AND MaCa = 3)
--         BEGIN
--             RAISERROR('Nhân viên đã đăng kí ca 3', 16, 1)
--             RETURN
--         END
--         INSERT INTO PhanCa
--             (MaNhanVien, MaCa, Ngay,DaDuyet)
--         VALUES
--             (@MaNhanVien, 3, @Ngay,0)
    
    
-- END
go
-- exec sp_DangKiCa3 7, '2024-10-19'
-- GO
-- CREATE PROCEDURE sp_DuyetDangKiCa3
--     @MaNhanVien INT,
--     @Ngay DATE
-- AS
-- BEGIN
    
--         IF @MaNhanVien = '' or @Ngay = '' or @MaNhanVien IS NULL or @Ngay IS NULL
--         BEGIN
--             RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
--             RETURN
--         END
--         IF NOT EXISTS (SELECT 1
--         FROM PhanCa
--         WHERE MaNhanVien = @MaNhanVien AND Ngay = @Ngay AND MaCa = 3)
--         BEGIN
--             RAISERROR('Nhân viên chưa đăng kí ca 3', 16, 1)
--             RETURN
--         END
--         UPDATE PhanCa
--         SET DaDuyet = 1
--         WHERE MaNhanVien = @MaNhanVien AND Ngay = @Ngay AND MaCa = 3
-- END
go
-- exec sp_DuyetDangKiCa3 7, '2024-10-19'
GO
CREATE PROCEDURE sp_HuyDangKiCa3
    @MaNhanVien INT,
    @Ngay DATE
AS
BEGIN
    
        IF @MaNhanVien = '' or @Ngay = '' or @MaNhanVien IS NULL or @Ngay IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        IF NOT EXISTS (SELECT 1
        FROM PhanCa
        WHERE MaNhanVien = @MaNhanVien AND Ngay = @Ngay AND MaCa = 3)
        BEGIN
            RAISERROR('Nhân viên chưa đăng kí ca 3', 16, 1)
            RETURN
        END
        DELETE FROM PhanCa
        WHERE MaNhanVien = @MaNhanVien AND Ngay = @Ngay AND MaCa = 3
    
    
END
go
-- exec sp_HuyDangKiCa3 7, '2024-10-19'


go

--- duyệt ca, đảm bảo chỉ cho nhân viên bán hàng làm ca 3 và tối đa 1 nv bán hàng. 
-- drop procedure IF exists sp_DuyetDangKiCa3
-- go
-- CREATE PROCEDURE sp_DuyetDangKiCa3  
--     @MaNhanVien INT,  
--     @Ngay DATE  
-- AS  
-- BEGIN  
--     BEGIN TRY  
--         BEGIN TRANSACTION;  
--         -- nếu là kiểm kho (chức vụ 2) thì không được đăng kí ca 3
--         -- kiểm tra chức vụ của nhân viên
--         DECLARE @MaChucVu INT=(SELECT MaChucVu FROM NhanVien WHERE MaNhanVien = @MaNhanVien)
--         IF @MaChucVu = 2
--         BEGIN  
--             RAISERROR('Nhân viên kiểm kho không được đăng kí ca 3', 16, 1);  
--             ROLLBACK TRANSACTION;  
--             RETURN;  
--         END
--         -- nếu đã duyệt rồi thì không được duyệt lại
--         IF EXISTS (SELECT 1 FROM PhanCa WHERE MaNhanVien = @MaNhanVien AND Ngay = @Ngay AND MaCa = 3 AND DaDuyet = 1)
--         BEGIN  
--             RAISERROR('Đã duyệt ca 3 cho nhân viên này trước đây', 16, 1);
--             ROLLBACK TRANSACTION;
--             RETURN;
--         END
--         IF EXISTS (SELECT 1 FROM PhanCa 
--         join NhanVien on PhanCa.MaNhanVien = NhanVien.MaNhanVien
--         WHERE MaCa = 3 AND Ngay = @Ngay and MaChucVu = 1)
--         BEGIN  
--             RAISERROR('Đã có nhân viên bán hàng làm ca 3', 16, 1);  
--             ROLLBACK TRANSACTION;  
--             RETURN;  
--         END   
--         UPDATE PhanCa
--         SET DaDuyet = 1
--         WHERE MaNhanVien = @MaNhanVien AND Ngay = @Ngay AND MaCa = 3
--         COMMIT TRANSACTION;  
--     END TRY  
--     BEGIN CATCH  
--         ROLLBACK TRANSACTION;  
--         DECLARE @ErrorMessage NVARCHAR(4000);  
--         SET @ErrorMessage = ERROR_MESSAGE();  
--         RAISERROR (@ErrorMessage, 16, 1);  
--     END CATCH  
-- END;  
-- go
-- exec sp_DuyetDangKiCa3 7, '2024-10-19'


--xoá vĩnh viễn
drop procedure IF exists sp_XoaVinhVien
go
CREATE PROCEDURE sp_XoaVinhVien
    @tableName NVARCHAR(128),
    @recordID INT
AS
BEGIN
    
        IF @tableName = 'NhanVien'
        BEGIN
        --xoa các dữ liệu tham chiếu đến nhân viên ở các bảng khác
            DELETE
                FROM PhanCa
                WHERE MaNhanVien = @recordID;
            DELETE
                FROM HoaDonBan
                WHERE MaNhanVien = @recordID;
            DELETE
                FROM HoaDonNhap
                WHERE MaNhanVien = @recordID;
            --xoa nhân viên
            DELETE 
                FROM NhanVien
                WHERE MaNhanVien = @recordID;
        END ELSE IF @tableName = 'KhachHang'
        BEGIN
            --xoa các dữ liệu tham chiếu đến khách hàng ở các bảng khác
            DELETE
                FROM HoaDonBan
                WHERE MaKhachHang = @recordID;
            --xoa khách hàng
            DELETE 
                FROM KhachHang
                WHERE MaKhachHang = @recordID;
        END ELSE IF @tableName = 'NhaCungCap'
        BEGIN
            --xoa các dữ liệu tham chiếu đến nhà cung cấp ở các bảng khác
            DELETE
                FROM HoaDonNhap
                WHERE MaNhaCungCap = @recordID;
            --xoa nhà cung cấp
            DELETE 
                FROM NhaCungCap
                WHERE MaNhaCungCap = @recordID;
        END ELSE IF @tableName = 'SanPham'
        BEGIN
            --xoa các dữ liệu tham chiếu đến sản phẩm ở các bảng khác
            DELETE
                FROM ChiTietHoaDonNhap
                WHERE MaSanPham = @recordID;
            DELETE
                FROM ChiTietHoaDonBan
                WHERE MaSanPham = @recordID;
            --xoa sản phẩm
            DELETE 
                FROM SanPham
                WHERE MaSanPham = @recordID;
        END
    
    
END
go

---RESTORE 
CREATE PROCEDURE sp_KhoiPhuc
    @tableName NVARCHAR(128),
    @recordID INT
AS
BEGIN
    
        IF @tableName = 'NhanVien'
        BEGIN
            UPDATE NhanVien
            SET IsActived = 1
            WHERE MaNhanVien = @recordID;
        END ELSE IF @tableName = 'KhachHang'
        BEGIN
            UPDATE KhachHang
            SET IsActived = 1
            WHERE MaKhachHang = @recordID;
        END ELSE IF @tableName = 'NhaCungCap'
        BEGIN
            UPDATE NhaCungCap
            SET IsActived = 1
            WHERE MaNhaCungCap = @recordID;
        END ELSE IF @tableName = 'SanPham'
        BEGIN
            UPDATE SanPham
            SET IsActived = 1
            WHERE MaSanPham = @recordID;
        END
    
    
END

GO
--checkin
drop procedure IF exists sp_CheckIn
go
CREATE PROCEDURE sp_CheckIn
    @MaNhanVien INT,
    @MaCa INT,
    @Ngay DATE,
    @ThoiGian TIME
AS
BEGIN
    
        IF @MaNhanVien = '' or @MaCa = '' or @Ngay = '' or @ThoiGian = '' or @MaNhanVien IS NULL or @MaCa IS NULL or @Ngay IS NULL or @ThoiGian IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        -- nếu thời gian nằm trong khoảng giờ bắt đầu và kết thúc của ca thì mới được checkin
        DECLARE @GioBatDau TIME = (SELECT GioBatDau FROM Ca WHERE MaCa = @MaCa)
        DECLARE @GioKetThuc TIME = (SELECT GioKetThuc FROM Ca WHERE MaCa = @MaCa)
        IF @ThoiGian < @GioBatDau or @ThoiGian > @GioKetThuc
        BEGIN
            RAISERROR('Thời gian checkin không hợp lệ', 16, 1)
            RETURN
        END
        IF EXISTS (SELECT 1 FROM PhanCa WHERE MaNhanVien = @MaNhanVien AND Ngay = @Ngay AND MaCa = @MaCa AND CheckIn IS NOT NULL)
        BEGIN
            RAISERROR('Nhân viên đã checkin ca này', 16, 1)
            RETURN
        END
        Update PhanCa
        SET CheckIn = @ThoiGian
        WHERE MaNhanVien = @MaNhanVien AND MaCa = @MaCa AND Ngay = @Ngay
    
    
END
GO
--checkout
drop procedure IF exists sp_CheckOut
go
CREATE PROCEDURE sp_CheckOut
    @MaNhanVien INT,
    @MaCa INT,
    @Ngay DATE,
    @ThoiGian TIME
AS
BEGIN
    
        IF @MaNhanVien = '' or @MaCa = '' or @Ngay = '' or @ThoiGian = '' or @MaNhanVien IS NULL or @MaCa IS NULL or @Ngay IS NULL or @ThoiGian IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        -- nếu thời gian nằm trong khoảng giờ bắt đầu và kết thúc của ca thì mới được checkin
        DECLARE @GioBatDau TIME = (SELECT GioBatDau FROM Ca WHERE MaCa = @MaCa)
        DECLARE @GioKetThuc TIME = (SELECT GioKetThuc FROM Ca WHERE MaCa = @MaCa)
        IF @ThoiGian < @GioBatDau or @ThoiGian > @GioKetThuc
        BEGIN
            RAISERROR('Thời gian checkout không hợp lệ', 16, 1)
            RETURN
        END
        IF EXISTS (SELECT 1 FROM PhanCa WHERE MaNhanVien = @MaNhanVien AND Ngay = @Ngay AND MaCa = @MaCa AND CheckIn IS NULL)
        BEGIN
            RAISERROR('Nhân viên chưa checkin ca này', 16, 1)
            RETURN
        END
        IF EXISTS (SELECT 1 FROM PhanCa WHERE MaNhanVien = @MaNhanVien AND Ngay = @Ngay AND MaCa = @MaCa AND CheckOut IS NOT NULL)
        BEGIN
            RAISERROR('Nhân viên đã checkout ca này', 16, 1)
            RETURN
        END
        Update PhanCa
        SET CheckOut = @ThoiGian
        WHERE MaNhanVien = @MaNhanVien AND MaCa = @MaCa AND Ngay = @Ngay
    
    
END
GO
--Xem th�ng tin nh�n vi�n
CREATE VIEW ThongTinNhanVien AS
SELECT 
    NV.MaNhanVien,
    NV.HoTen,
    NV.NgaySinh,
    NV.GioiTinh,
    NV.DiaChi,
    NV.SoDienThoai,
    NV.Email,
    CV.TenChucVu,
    CV.LuongTheoGio
FROM 
    NhanVien NV
LEFT JOIN 
    ChucVu CV ON NV.MaChucVu = CV.MaChucVu
    WHERE NV.isActived = 1;
go

--	Xem c�c ca l�m vi?c c?a nh�n vi�n trong ng�y 
CREATE VIEW ThongTinCaLamViec AS
SELECT 
    NV.MaNhanVien 'Mã NV',
    NV.HoTen 'Họ Tên',
    PC.Ngay 'Ngày',
    C.GioBatDau 'Giờ Bắt Đầu',
    C.GioKetThuc 'Giờ Kết Thúc',
    PC.CheckIn 'CheckIn',
    PC.CheckOut 'Checkout'
FROM 
    PhanCa PC
JOIN 
    NhanVien NV ON PC.MaNhanVien = NV.MaNhanVien
JOIN 
    Ca C ON PC.MaCa = C.MaCa
WHERE 
    PC.Ngay = CAST(GETDATE() AS DATE);
go
go

go
--Xem danh s�ch s?n ph?m 
Create view XemDanhSachSanPham
as
SELECT 
    SP.MaSanPham 'Mã SP',
    SP.TenSanPham 'Tên SP',
	LSP.MaLoaiSanPham 'Mã Loại SP',
    LSP.TenLoaiSanPham 'Tên Loại SP',
	NCC.MaNhaCungCap 'Mã NCC',
    NCC.TenNhaCungCap 'Tên NCC',
    SP.GiaNhap 'Giá Nhập',
    SP.GiaBan 'Giá Bán',
    TTK.SoLuongTonKho 'SL Tồn Kho'
FROM 
    SanPham SP
LEFT JOIN 
    LoaiSanPham LSP ON SP.MaLoaiSanPham = LSP.MaLoaiSanPham
LEFT JOIN 
    NhaCungCap NCC ON SP.MaNhaCungCap = NCC.MaNhaCungCap
LEFT JOIN 
    ThongTinTonKho TTK ON SP.MaSanPham = TTK.MaSanPham
where SP.IsActived = 1;
GO

GO
-- view xem danh sách hoá đơn nhập
create view v_DanhSachHoaDonNhap
as
select MaHoaDonNhap 'Mã HĐ Nhập', NgayLap 'Ngày Lập', NhanVien.MaNhanVien 'Mã NV', NhanVien.HoTen 'Họ Tên NV', NhaCungCap.MaNhaCungCap 'Mã NCC',NhaCungCap.TenNhaCungCap 'Tên NCC', GiaTri 'Giá Trị',TrangThaiThanhToan 'Trạng thái thanh toán',NgayThanhToan  'Ngày Thanh Toán'
from HoaDonNhap
left join NhanVien on HoaDonNhap.MaNhanVien = NhanVien.MaNhanVien
left join NhaCungCap on HoaDonNhap.MaNhaCungCap = NhaCungCap.MaNhaCungCap
go
-- SELECT * FROM v_DanhSachHoaDonNhap
go
-- view xem danh sách hoá đơn bán hàng
create view v_DanhSachHoaDonBan
as
select MaHoaDonBan 'Mã HĐ Bán', NgayLap 'Ngày Lập', NhanVien.MaNhanVien 'Mã NV', NhanVien.HoTen 'Họ Tên NV', KhachHang.MaKhachHang 'Mã KH',KhachHang.HoTen 'Tên KH', GiaTri 'Giá Trị',TrangThaiThanhToan 'Trạng thái thanh toán',NgayThanhToan  'Ngày Thanh Toán'
from HoaDonBan
left join NhanVien on HoaDonBan.MaNhanVien = NhanVien.MaNhanVien
left join KhachHang on HoaDonBan.MaKhachHang = KhachHang.MaKhachHang
go
-- SELECT * FROM v_DanhSachHoaDonBan
GO

-- view xem danh sách khách hàng
create view v_DanhSachKhachHang
as
select MaKhachHang 'Mã KH', HoTen 'Họ Tên', DiaChi 'Địa Chỉ', SoDienThoai 'Số Điện Thoại'
from KhachHang
where IsActived = 1
go
-- SELECT * FROM v_DanhSachKhachHang

go
-- view xem danh sách nhà cung cấp
create view v_DanhSachNhaCungCap
as
SELECT MaNhaCungCap 'Mã NCC', TenNhaCungCap 'Tên NCC', DiaChi 'Địa Chỉ', SoDienThoai 'Số Điện Thoại'
FROM NhaCungCap
where IsActived = 1
go
-- SELECT * FROM v_DanhSachNhaCungCap

GO


CREATE FUNCTION fn_TongPhiNhapHangTheoThang(@Thang INT, @Nam INT)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TongChiPhiNhapHang DECIMAL(18, 2) = 0;

    -- Tính tổng chi phí nhập hàng trong tháng
    SELECT @TongChiPhiNhapHang = ISNULL(SUM(cthdn.SoLuong * cthdn.DonGia), 0)
    FROM HoaDonNhap hdn
    JOIN ChiTietHoaDonNhap cthdn ON hdn.MaHoaDonNhap = cthdn.MaHoaDonNhap
    WHERE MONTH(hdn.NgayLap) = @Thang AND YEAR(hdn.NgayLap) = @Nam;

    -- Trả về tổng chi phí nhập hàng
    RETURN @TongChiPhiNhapHang;
END;
go
DROP FUNCTION fn_TongLuongPhaiTraTheoThang
go
CREATE FUNCTION fn_TongLuongPhaiTraTheoThang(@Thang INT, @Nam INT)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TongLuong DECIMAL(18, 2) = 0;

    -- Tính tổng lương phải trả từ hàm fn_DanhSachLuongNhanVienTheoThang,
    -- chỉ cộng lương dương
    SELECT @TongLuong = ISNULL(SUM([Lương Tháng]), 0)
    FROM fn_DanhSachLuongNhanVienTheoThang(@Thang, @Nam)
    WHERE [Lương Tháng] > 0; -- Chỉ cộng lương dương

    -- Trả về tổng lương
    RETURN @TongLuong;
END;
go
CREATE FUNCTION fn_TongDoanhThuTheoThang(@Thang INT, @Nam INT)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TongDoanhThu DECIMAL(18, 2) = 0;

    -- Tính tổng doanh thu từ hàm fn_DoanhThuBanHangTheoThang
    SELECT @TongDoanhThu = ISNULL(SUM([Tổng Doanh Thu]), 0)
    FROM fn_DoanhThuBanHangTheoThang(@Thang, @Nam);

    -- Trả về tổng doanh thu
    RETURN @TongDoanhThu;
END;
go
CREATE FUNCTION fn_TongChiTieuTheoThang(@Thang INT, @Nam INT)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TongLuong DECIMAL(18, 2) = 0;
    DECLARE @TongChiPhiNhapHang DECIMAL(18, 2) = 0;

    -- Tính tổng chi phí trả lương nhân viên trong tháng
    SELECT @TongLuong = ISNULL(SUM([Lương Tháng]), 0)
    FROM fn_DanhSachLuongNhanVienTheoThang(@Thang, @Nam)
    WHERE [Lương Tháng] > 0; -- Chỉ cộng lương dương

    -- Tính tổng chi phí nhập hàng trong tháng
    SELECT @TongChiPhiNhapHang = ISNULL(SUM(cthdn.SoLuong * cthdn.DonGia), 0)
    FROM HoaDonNhap hdn
    JOIN ChiTietHoaDonNhap cthdn ON hdn.MaHoaDonNhap = cthdn.MaHoaDonNhap
    WHERE MONTH(hdn.NgayLap) = @Thang AND YEAR(hdn.NgayLap) = @Nam;

    -- Nếu tổng chi phí nhập hàng âm thì không cộng vào tổng chi tiêu
    IF @TongChiPhiNhapHang < 0
    BEGIN
        SET @TongChiPhiNhapHang = 0;
    END

    -- Trả về tổng chi tiêu = tổng lương + tổng chi phí nhập hàng
    RETURN @TongLuong + @TongChiPhiNhapHang;
END;
go
CREATE or ALTER FUNCTION fn_DoanhThuBanHangTheoThang(@Thang INT, @Nam INT)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        sp.MaSanPham AS 'Mã Sản Phẩm',
        sp.TenSanPham AS 'Tên Sản Phẩm',
        SUM(cthdb.SoLuong) AS 'Số Lượng Bán',
        SUM(cthdb.SoLuong * sp.GiaBan) AS 'Tổng Doanh Thu'
    FROM HoaDonBan hdb
    JOIN ChiTietHoaDonBan cthdb ON hdb.MaHoaDonBan = cthdb.MaHoaDonBan
    JOIN SanPham sp ON cthdb.MaSanPham = sp.MaSanPham
    WHERE MONTH(hdb.NgayLap) = @Thang AND YEAR(hdb.NgayLap) = @Nam
    GROUP BY sp.MaSanPham, sp.TenSanPham
);
go
CREATE OR aLTER FUNCTION fn_ChiPhiNhapHangTheoThang(@Thang INT, @Nam INT)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        sp.MaSanPham AS 'Mã Sản Phẩm',
        sp.TenSanPham AS 'Tên Sản Phẩm',
        SUM(cthdn.SoLuong) AS 'Số Lượng Nhập',
        SUM(cthdn.SoLuong * cthdn.DonGia) AS 'Tổng Tiền Nhập'
    FROM HoaDonNhap hdn
    JOIN ChiTietHoaDonNhap cthdn ON hdn.MaHoaDonNhap = cthdn.MaHoaDonNhap
    JOIN SanPham sp ON cthdn.MaSanPham = sp.MaSanPham
    WHERE MONTH(hdn.NgayLap) = @Thang AND YEAR(hdn.NgayLap) = @Nam
    GROUP BY sp.MaSanPham, sp.TenSanPham
);
go
CREATE OR alter FUNCTION fn_DanhSachLuongNhanVienTheoThang(@Thang INT, @Nam INT)
RETURNS TABLE
AS
RETURN
(
    WITH TongGioLamCa1Ca2 AS (
        SELECT 
            p.MaNhanVien,
            nv.Hoten,
            case 
                when SUM(DATEDIFF(HOUR, p.checkin, p.checkout)) is not null then SUM(DATEDIFF(HOUR, p.checkin, p.checkout))
                else 0
            end AS tonggiolam,
            DAY(p.ngay) AS Ngay
        FROM PhanCa p
        JOIN NhanVien nv ON p.MaNhanVien = nv.MaNhanVien
        WHERE MONTH(p.ngay) = @Thang AND YEAR(p.ngay) = @Nam
        GROUP BY p.MaNhanVien, nv.HoTen, p.maca, DAY(p.ngay)
        HAVING p.MaCa IN (1, 2)
    ),
    LuongCa1Ca2 AS (
        SELECT
            t.MaNhanVien,
            t.Hoten,
            t.Ngay,
            CASE 
                WHEN SUM(t.tonggiolam) >= 8 THEN SUM(t.tonggiolam) * cv.luongtheogio -- Đủ 8 giờ hoặc hơn
                ELSE (SUM(t.tonggiolam) * cv.Luongtheogio) - ((8 - SUM(t.tonggiolam)) * 1.5 * cv.luongtheogio) -- Thiếu giờ
            END AS luong
        FROM TongGioLamCa1Ca2 t
        JOIN NhanVien n ON t.MaNhanVien = n.MaNhanVien
        JOIN ChucVu cv ON n.MaChucVu = cv.MaChucVu
        GROUP BY t.MaNhanVien, t.Hoten, t.Ngay, cv.luongtheogio
    ),
    LuongCa3 AS (
        SELECT
            n.MaNhanVien,
            n.Hoten,
            DAY(p.ngay) AS Ngay,
            CASE 
                WHEN SUM(DATEDIFF(HOUR, p.checkin, p.checkout)) * cv.luongtheogio IS NOT NULL 
                THEN SUM(DATEDIFF(HOUR, p.checkin, p.checkout)) * cv.luongtheogio
                ELSE 0
            END AS luong
        FROM NhanVien n 
        JOIN ChucVu cv ON n.MaChucVu = cv.MaChucVu
        JOIN PhanCa p ON n.MaNhanVien = p.MaNhanVien
        WHERE MONTH(p.ngay) = @Thang AND YEAR(p.ngay) = @Nam
        GROUP BY n.MaNhanVien, n.Hoten, p.maca, cv.luongtheogio, DAY(p.ngay)
        HAVING p.MaCa = 3
    )
    -- Kết hợp lương ca 1, ca 2, ca 3 cho mỗi ngày trong tháng
    , LuongTheoNgay AS (
        SELECT MaNhanVien, Hoten, Ngay, SUM(luong) AS LuongNgay
        FROM (
            SELECT MaNhanVien, Hoten, Ngay, luong FROM LuongCa1Ca2
            UNION ALL
            SELECT MaNhanVien, Hoten, Ngay, luong FROM LuongCa3
        ) AS LuongNgay
        GROUP BY MaNhanVien, Hoten, Ngay
    )
    -- Tính tổng lương trong tháng
    SELECT MaNhanVien 'Mã NV', Hoten 'Họ Tên', SUM(LuongNgay) AS 'Lương Tháng'
    FROM LuongTheoNgay
    GROUP BY MaNhanVien, Hoten
);

GO
-- thủ tục tìm kiếm nhận tham số tên bảng và từ khóa cần tìm


CREATE OR ALTER PROCEDURE SearchTable
    @TableName NVARCHAR(128),
    @Keyword NVARCHAR(255)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    -- Xây dựng câu truy vấn động
    if @TableName = 'NhanVien' 
        SET @sql = N'SELECT * FROM ThongTinNhanVien WHERE CAST(MaNhanVien AS NVARCHAR) + HoTen like N''%' + @Keyword + N'%''';
    ELSE IF @TableName = 'SanPham'
        SET @sql = N'SELECT * FROM XemDanhSachSanPham WHERE CAST([Mã SP] AS NVARCHAR) + [Tên SP] like N''%' + @Keyword + N'%''';
    ELSE IF @TableName = 'KhachHang'
        SET @sql = N'SELECT * FROM v_DanhSachKhachHang WHERE CAST([Mã KH] AS NVARCHAR) + [Họ Tên] like N''%' + @Keyword + N'%''';
    ELSE IF @TableName = 'NCC'
        SET @sql = N'SELECT * FROM v_DanhSachNhaCungCap WHERE CAST([Mã NCC] AS NVARCHAR) + [Tên NCC] like N''%' + @Keyword + N'%''';
    -- Thực thi câu truy vấn động
    EXEC sp_executesql @sql;
END;
GO
-- EXEC SearchTable 'NhanVien', 'Lê';
go
-- 3.2.2. Thủ tục xoá một bản ghi nhận tham số tên bảng, tên cột khoá chính và id của bảng ghi đó.
CREATE OR ALTER PROCEDURE DeleteRecord
    @TableName NVARCHAR(128),
    @PrimaryKeyColumn NVARCHAR(128),
    @PrimaryKeyValue INT
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);

    -- Kiểm tra nếu có cột khóa chính
    IF @PrimaryKeyColumn IS NULL
    BEGIN
        RAISERROR('No primary key found for table %s', 16, 1, @TableName);
        RETURN;
    END

    -- Xây dựng câu truy vấn động
    SET @sql = 'DELETE FROM ' + @TableName + ' WHERE ' + @PrimaryKeyColumn + ' = ' + CAST(@PrimaryKeyValue AS NVARCHAR);
    -- Thực thi câu truy vấn động
    EXEC sp_executesql @sql;
END;
GO
-- EXEC DeleteRecord 'NhanVien', 'MaNhanVien', 1;

go
--tt tìm kiếm hoá đơn theo ngày lập
CREATE OR ALTER PROCEDURE SearchHoaDon
    @BatDauNgayLap DATE,
    @KetThucNgayLap DATE,
    @IsHoaDonNhap BIT
AS
BEGIN
    IF @IsHoaDonNhap = 1
    BEGIN
        SELECT * FROM v_DanhSachHoaDonNhap WHERE [Ngày Lập] BETWEEN @BatDauNgayLap AND @KetThucNgayLap;
    END
    ELSE
    BEGIN
        SELECT * FROM v_DanhSachHoaDonBan WHERE [Ngày Lập] BETWEEN @BatDauNgayLap AND @KetThucNgayLap;
    END
END;
GO

-- EXEC SearchHoaDon '2024-10-22', '2024-10-24', 0;

-- 3.10.5. Ứng dụng transaction: Khi có quá nhiều nhân viên đăng ký ca làm thêm tại 1 thời điêm, hệ thống đảm bảo chỉ 1 nhân viên đăng ký thành công.
CREATE OR ALTER PROCEDURE sp_DangKiCaLamThem
    @MaNhanVien INT,
    @Ngay DATE
AS
BEGIN
BEGIN TRY
    BEGIN TRANSACTION;
    -- chỉ đc đăng kí từ 7:00:00 đến 8:00:00
    IF CAST(GETDATE() AS TIME) < '07:00:00' OR CAST(GETDATE() AS TIME) > '08:00:00'
    BEGIN
        RAISERROR('Chỉ được đăng ký ca làm thêm từ 7:00:00 đến 8:00:00', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
    DECLARE @Slot INT;
    SELECT @Slot = COUNT(*) 
    FROM PhanCa 
    WHERE Ngay = @Ngay and MaCa = 3
    -- print @Slot
    IF @Slot = 0
    -- nếu chưa nhân viên nào đăng ký ca làm thêm
    BEGIN
        -- Đăng ký ca làm thêm
        INSERT INTO PhanCa WITH (TABLOCK) (MaNhanVien, MaCa, Ngay) 
        VALUES(@MaNhanVien, 3, @Ngay)
        COMMIT TRANSACTION;
    END
    ELSE
    -- tức là đã có nhân viên đăng ký ca làm thêm
        BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR ('Hôm nay đã có nhân viên đăng ký ca làm thêm', 16, 1);
        END
END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;
    DECLARE @ErrorMessage NVARCHAR(4000);
    SET @ErrorMessage = ERROR_MESSAGE();
    RAISERROR (@ErrorMessage, 16, 1);
END CATCH
END
go




CREATE PROCEDURE sp_XemDanhSachSanPhamCuaNhaCungCap
    @MaNhaCungCap INT
AS
BEGIN
    SELECT 
        SP.MaSanPham AS 'Mã SP',
        SP.TenSanPham AS 'Tên SP',
        LSP.MaLoaiSanPham AS 'Mã Loại SP',
        LSP.TenLoaiSanPham AS 'Tên Loại SP',
        NCC.MaNhaCungCap AS 'Mã NCC',
        NCC.TenNhaCungCap AS 'Tên NCC',
        SP.GiaNhap AS 'Giá Nhập',
        SP.GiaBan AS 'Giá Bán',
        TTK.SoLuongTonKho AS 'SL Tồn Kho'
    FROM 
        SanPham SP
    LEFT JOIN 
        LoaiSanPham LSP ON SP.MaLoaiSanPham = LSP.MaLoaiSanPham
    LEFT JOIN 
        NhaCungCap NCC ON SP.MaNhaCungCap = NCC.MaNhaCungCap
    LEFT JOIN 
        ThongTinTonKho TTK ON SP.MaSanPham = TTK.MaSanPham
    WHERE 
        SP.IsActived = 1
        AND (SP.MaNhaCungCap = @MaNhaCungCap OR SP.MaNhaCungCap IS NULL);
END;
GO





GRANT SELECT,INSERT,UPDATE,DELETE ON HoaDonBan TO BanHang;
GRANT SELECT,UPDATE ON SanPham TO BanHang;
GRANT SELECT,INSERT,UPDATE,DELETE ON KhachHang TO BanHang;
GRANT EXEC ON sp_ThemKhachHang TO BanHang;
GRANT EXEC ON sp_SuaKhachHang TO BanHang;
GRANT EXEC ON DeleteRecord TO BanHang;
GRANT EXEC ON sp_SuaSanPham TO BanHang;
GRANT EXEC ON sp_ThemHoaDonBan TO BanHang;
GRANT EXEC ON sp_CapNhatTrangThaiThanhToanHoaDonBan To BanHang;
GRANT EXEC ON sp_ThemChiTietHoaDonBan To BanHang;
GRANT EXEC ON sp_CapNhatChiTietHoaDonBan To BanHang;
GRANT EXEC ON sp_XoaChiTietHoaDonBan To BanHang;
GRANT EXEC ON sp_CheckOut TO BanHang;
GRANT EXEC ON sp_CheckIn TO BanHang;
GRANT EXEC ON SearchHoaDon TO BanHang;
GRANT EXEC ON sp_DangKiCaLamThem TO BanHang;

GRANT EXEC ON fn_CheckValidEmail TO BanHang;
GRANT EXEC ON fn_CheckValidPhoneNumber TO BanHang;
GRANT SELECT ON dbo.fn_DanhSachSanPhamTrongHoaDonBan TO BanHang;
GRANT SELECT ON fn_DanhSachSanPhamDaBanTrongNgay TO BanHang;

DENY SELECT,INSERT,UPDATE,DELETE ON HoaDonNhap TO BanHang;
DENY SELECT,INSERT,UPDATE,DELETE ON ChiTietHoaDonNhap TO BanHang;
DENY INSERT,UPDATE,DELETE ON NhaCungCap TO BanHang;
DENY INSERT,UPDATE,DELETE ON NhanVien TO BanHang;

    GRANT SELECT ON dbo.ThongTinCaLamViec TO BanHang;
    GRANT SELECT ON dbo.ThongTinNhanVien TO BanHang;
    GRANT SELECT ON dbo.XemDanhSachSanPham TO BanHang;
    GRANT SELECT ON dbo.v_DanhSachHoaDonBan TO BanHang;
    GRANT SELECT ON dbo.v_DanhSachKhachHang TO BanHang;
    GRANT SELECT ON dbo.v_DanhSachNhaCungCap TO BanHang;

----------------------------
go

    GRANT SELECT ON dbo.ThongTinCaLamViec TO KiemKho;
    GRANT SELECT ON dbo.ThongTinNhanVien TO KiemKho;
    GRANT SELECT ON dbo.XemDanhSachSanPham TO KiemKho;
    GRANT SELECT ON dbo.v_DanhSachHoaDonNhap TO KiemKho;
    -- GRANT SELECT ON dbo.v_DanhSachKhachHang TO KiemKho;
    GRANT SELECT ON dbo.v_DanhSachNhaCungCap TO KiemKho;
GRANT SELECT,INSERT,UPDATE,DELETE ON HoaDonNhap TO KiemKho
GRANT SELECT,INSERT,UPDATE,DELETE ON SanPham TO KiemKho
GRANT SELECT,INSERT,UPDATE,DELETE ON KhachHang TO KiemKho
GRANT EXEC ON sp_ThemKhachHang TO KiemKho
GRANT EXEC ON sp_SuaKhachHang TO KiemKho
GRANT EXEC ON DeleteRecord TO KiemKho

GRANT EXEC ON sp_SuaSanPham TO KiemKho
GRANT EXEC ON sp_ThemHoaDonNhap TO KiemKho
GRANT EXEC ON sp_CapNhatTrangThaiThanhToanHoaDonNhap To KiemKho
GRANT EXEC ON sp_ThemChiTietHoaDonNhap To KiemKho
GRANT EXEC ON sp_CapNhatChiTietHoaDonNhap To KiemKho
GRANT EXEC ON sp_XoaChiTietHoaDonNhap To KiemKho
GRANT EXEC ON sp_CheckOut TO KiemKho
GRANT EXEC ON sp_CheckIn TO KiemKho
GRANT EXEC ON SearchHoaDon TO KiemKho
GRANT EXEC ON sp_DangKiCaLamThem TO KiemKho

GRANT EXEC ON fn_CheckValidEmail TO KiemKho
GRANT EXEC ON fn_CheckValidPhoneNumber TO KiemKho
GRANT SELECT ON fn_DanhSachSanPhamTrongHoaDonNhap TO KiemKho

DENY SELECT,INSERT,UPDATE,DELETE ON HoaDonBan TO KiemKho
DENY SELECT,INSERT,UPDATE,DELETE ON ChiTietHoaDonBan TO KiemKho
DENY SELECT,INSERT,UPDATE,DELETE ON KhachHang TO KiemKho
DENY INSERT,UPDATE,DELETE ON NhanVien TO KiemKho

-------------

go
