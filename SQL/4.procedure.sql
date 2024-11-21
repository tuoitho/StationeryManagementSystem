
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
            -- khai báo một con trỏ tên cur_NhanVien, được sử dụng để duyệt qua từng dòng kết quả từ câu truy vấn select
                DECLARE cur_NhanVien CURSOR FOR  
                    SELECT MaNhanVien
                FROM NhanVien
                WHERE IsActived = 1
                DECLARE @MaNhanVien INT
            -- Mở con trỏ cur_NhanVien để bắt đầu duyệt
                OPEN cur_NhanVien
                -- Lấy dòng đầu tiên từ con trỏ cur_NhanVien
                FETCH NEXT FROM cur_NhanVien INTO @MaNhanVien
                -- nếu còn dòng, FETCH thành công 
                WHILE @@FETCH_STATUS = 0  
                    BEGIN
                    -- Insert từng nhân viên vào bảng phân ca  
                    INSERT INTO PhanCa
                        (MaNhanVien, MaCa, Ngay)
                    VALUES
                        (@MaNhanVien, @i, @NgayBatDau)
                        -- tiếp tục lấy dòng tiếp theo từ con trỏ và gán vào @MaNhanVien.
                    FETCH NEXT FROM cur_NhanVien INTO @MaNhanVien
                END
                -- đóng con trỏ
                CLOSE cur_NhanVien
                -- giải phóng
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
CREATE PROCEDURE sp_DangKiCa3
    @MaNhanVien INT,
    @Ngay DATE
AS
BEGIN
    
        IF @MaNhanVien = '' or @Ngay = '' or @MaNhanVien IS NULL or @Ngay IS NULL
        BEGIN
            RAISERROR('Vui lòng nhập đầy đủ thông tin', 16, 1)
            RETURN
        END
        IF @Ngay < CAST(GETDATE() AS DATE)
        BEGIN
            RAISERROR('Ngày đăng kí phải lớn hơn hoặc bằng ngày hiện tại', 16, 1)
            RETURN
        END
        IF @Ngay > DATEADD(day, 3, GETDATE())
        BEGIN
            RAISERROR('Ngày đăng kí không được quá 3 ngày', 16, 1)
            RETURN
        END
        IF EXISTS (SELECT 1
        FROM PhanCa
        WHERE MaNhanVien = @MaNhanVien AND Ngay = @Ngay AND MaCa = 3)
        BEGIN
            RAISERROR('Nhân viên đã đăng kí ca 3', 16, 1)
            RETURN
        END
        INSERT INTO PhanCa
            (MaNhanVien, MaCa, Ngay,DaDuyet)
        VALUES
            (@MaNhanVien, 3, @Ngay,0)
    
    
END
go
-- exec sp_DangKiCa3 7, '2024-10-19'
GO
CREATE PROCEDURE sp_DuyetDangKiCa3
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
        UPDATE PhanCa
        SET DaDuyet = 1
        WHERE MaNhanVien = @MaNhanVien AND Ngay = @Ngay AND MaCa = 3
    
    
END
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
drop procedure IF exists sp_DuyetDangKiCa3
go
CREATE PROCEDURE sp_DuyetDangKiCa3  
    @MaNhanVien INT,  
    @Ngay DATE  
AS  
BEGIN  
    BEGIN TRY  
        BEGIN TRANSACTION;  
        -- nếu là kiểm kho (chức vụ 2) thì không được đăng kí ca 3
        -- kiểm tra chức vụ của nhân viên
        DECLARE @MaChucVu INT=(SELECT MaChucVu FROM NhanVien WHERE MaNhanVien = @MaNhanVien)
        IF @MaChucVu = 2
        BEGIN  
            RAISERROR('Nhân viên kiểm kho không được đăng kí ca 3', 16, 1);  
            ROLLBACK TRANSACTION;  
            RETURN;  
        END
        -- nếu đã duyệt rồi thì không được duyệt lại
        IF EXISTS (SELECT 1 FROM PhanCa WHERE MaNhanVien = @MaNhanVien AND Ngay = @Ngay AND MaCa = 3 AND DaDuyet = 1)
        BEGIN  
            RAISERROR('Đã duyệt ca 3 cho nhân viên này trước đây', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END
        IF EXISTS (SELECT 1 FROM PhanCa 
        join NhanVien on PhanCa.MaNhanVien = NhanVien.MaNhanVien
        WHERE MaCa = 3 AND Ngay = @Ngay and MaChucVu = 1)
        BEGIN  
            RAISERROR('Đã có nhân viên bán hàng làm ca 3', 16, 1);  
            ROLLBACK TRANSACTION;  
            RETURN;  
        END   
        UPDATE PhanCa
        SET DaDuyet = 1
        WHERE MaNhanVien = @MaNhanVien AND Ngay = @Ngay AND MaCa = 3
        COMMIT TRANSACTION;  
    END TRY  
    BEGIN CATCH  
        ROLLBACK TRANSACTION;  
        DECLARE @ErrorMessage NVARCHAR(4000);  
        SET @ErrorMessage = ERROR_MESSAGE();  
        RAISERROR (@ErrorMessage, 16, 1);  
    END CATCH  
END;  
go
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