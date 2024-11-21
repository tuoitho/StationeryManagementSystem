
create table ACCOUNT(
	Username NVARCHAR(50) PRIMARY KEY,
	Password varchar(50),
	isAdmin bit,
    MaNhanVien int NULL UNIQUE REFERENCES NhanVien(MaNhanVien)
);


CREATE ROLE BanHang;
CREATE ROLE KiemKho;

GRANT SELECT,INSERT,UPDATE ON PhanCa TO BanHang;
GRANT SELECT,INSERT,UPDATE ON PhanCa TO KiemKho;


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

-------------

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
