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
drop trigger TRG_ChiTietHoaDonBan_INSERT_UPDATE
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
alter TRIGGER TRG_HoaDonBan_UPDATE
ON HoaDonBan
AFTER UPDATE
AS
BEGIN
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
    -- nếu phaanca đã duyệt thì mới cho phép check-in/check-out
    DECLARE @DaDuyet INT = (SELECT DaDuyet
    FROM inserted);
    IF @DaDuyet = 0
    BEGIN
        RAISERROR('Chưa được duyệt, không thể check-in/check-out', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END;
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