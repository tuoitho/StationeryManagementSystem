
use StationeryManagementSystem;
ALTER table ChiTietHoaDonBan ADD TenSanPham NVARCHAR(100);
alter table ChiTietHoaDonNhap ADD TenSanPham NVARCHAR(100);
go
-- function trả về danh sách sản phẩm trong hoá đơn nhập
alter function fn_DanhSachSanPhamTrongHoaDonNhap(@MaHoaDonNhap INT)
returns TABLE
as
RETURN
(
    SELECT 
        cthdn.MaSanPham 'Mã SP', 
        cthdn.TenSanPham 'Tên SP',
        cthdn.SoLuong 'Số Lượng',
        cthdn.DonGia 'Đơn Giá',
        cthdn.TongTien 'Tổng Tiền'
    FROM ChiTietHoaDonNhap cthdn
    WHERE cthdn.MaHoaDonNhap = @MaHoaDonNhap
);
go

-- function trả về danh sách sản phẩm trong hoá đơn bán
alter function fn_DanhSachSanPhamTrongHoaDonBan(@MaHoaDonBan INT)
returns TABLE
as
RETURN
(
    SELECT 
        cthdb.MaSanPham 'Mã SP', 
        cthdb.TenSanPham 'Tên SP',
        cthdb.SoLuong 'Số Lượng',
        cthdb.DonGia 'Đơn Giá',
        cthdb.TongTien 'Tổng Tiền'
    FROM ChiTietHoaDonBan cthdb
    WHERE cthdb.MaHoaDonBan = @MaHoaDonBan
);
go

-- hàm trả về danh sách sản phẩm đã bán trong ngày (nhận ngày làm tham số)
alter FUNCTION fn_DanhSachSanPhamDaBanTrongNgay(@Ngay DATE)
RETURNS TABLE
AS
RETURN
(
    SELECT
        CTHDB.MaSanPham 'Mã SP',
        CTHDB.TenSanPham 'Tên SP',
        SUM(CTHDB.SoLuong) 'SL Đã Bán',
        HDB.NgayLap 'Ngày Lập'
    FROM
        ChiTietHoaDonBan CTHDB
        JOIN
        HoaDonBan HDB ON CTHDB.MaHoaDonBan = HDB.MaHoaDonBan
    WHERE 
            CAST(HDB.NgayLap AS DATE) = @Ngay and HDB.TrangThaiThanhToan=N'Đã thanh toán'
    GROUP BY 
            CTHDB.MaSanPham, CTHDB.TenSanPham, HDB.NgayLap
);

go
alter FUNCTION fn_DoanhThuBanHangTheoThang(@Thang INT, @Nam INT)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        cthdb.MaSanPham AS 'Mã Sản Phẩm',
        cthdb.TenSanPham AS 'Tên Sản Phẩm',
        SUM(cthdb.SoLuong) AS 'Số Lượng Bán',
        SUM(cthdb.SoLuong * cthdb.DonGia) AS 'Tổng Doanh Thu'
    FROM HoaDonBan hdb
    JOIN ChiTietHoaDonBan cthdb ON hdb.MaHoaDonBan = cthdb.MaHoaDonBan
    WHERE MONTH(hdb.NgayLap) = @Thang AND YEAR(hdb.NgayLap) = @Nam
    GROUP BY cthdb.MaSanPham, cthdb.TenSanPham
);
go

go
alter FUNCTION fn_ChiPhiNhapHangTheoThang(@Thang INT, @Nam INT)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        cthdn.MaSanPham AS 'Mã Sản Phẩm',
        cthdn.TenSanPham AS 'Tên Sản Phẩm',
        SUM(cthdn.SoLuong) AS 'Số Lượng Nhập',
        SUM(cthdn.SoLuong * cthdn.DonGia) AS 'Tổng Tiền Nhập'
    FROM HoaDonNhap hdn
    JOIN ChiTietHoaDonNhap cthdn ON hdn.MaHoaDonNhap = cthdn.MaHoaDonNhap
    WHERE MONTH(hdn.NgayLap) = @Thang AND YEAR(hdn.NgayLap) = @Nam
    GROUP BY cthdn.MaSanPham, cthdn.TenSanPham
);
go





-- trigger tính tiền tương ứng của từng sản phẩm trong chi tiết hd nhập, đồng thời tính giá trị của hoá đơn nhập

ALTER TRIGGER TRG_ChiTietHoaDonNhap_INSERT
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
        DECLARE @TenSP nvarchar(100)=(SELECT TenSanPham FROM SanPham WHERE MaSanPham=@MaSanPham)

        UPDATE ChiTietHoaDonNhap 
        SET TongTien = SoLuong * DonGia,
              TenSanPham =@TenSP 
        WHERE MaHoaDonNhap = @MaHoaDonNhap AND MaSanPham = @MaSanPham;
        UPDATE HoaDonNhap
        SET GiaTri = (SELECT SUM(TongTien)  
        FROM ChiTietHoaDonNhap
        WHERE MaHoaDonNhap = @MaHoaDonNhap)
    WHERE MaHoaDonNhap = @MaHoaDonNhap;
    END
END;
go

-- trigger cập nhật tổng tiền của chi tiết hoá đơn nhập và tính giá trị của hoá đơn nhập khi cập nhật số lượng hoặc đơn giá của sản phẩm trong chi tiết hoá đơn nhập
alter TRIGGER TRG_ChiTietHoaDonNhap_UPDATE
ON ChiTietHoaDonNhap
AFTER UPDATE
AS
BEGIN
    DECLARE @MaHoaDonNhap INT = (SELECT MaHoaDonNhap
    FROM inserted);
    DECLARE @MaSP INT = (SELECT MaSanPham
    FROM inserted);
    DECLARE @TenSP nvarchar(100)=(SELECT TenSanPham FROM SanPham WHERE MaSanPham=@MaSP)
    UPDATE ChiTietHoaDonNhap 
    SET TongTien = SoLuong * DonGia ,
        TenSanPham =@TenSP
    WHERE MaHoaDonNhap = @MaHoaDonNhap AND MaSanPham = @MaSP;
    UPDATE HoaDonNhap
    SET GiaTri = (SELECT SUM(TongTien)
    FROM ChiTietHoaDonNhap
    WHERE MaHoaDonNhap = @MaHoaDonNhap)
    WHERE MaHoaDonNhap = @MaHoaDonNhap;

END;


GO

-- Trigger kiểm tra xem có đủ tồn kho cho sản phẩm khi thêm/cập nhật chi tiết hóa đơn bán, đồng thời cập nhật đon giá,tổng tiền của chi tiết hóa đơn bán và giá trị của hóa đơn bán
alter TRIGGER [dbo].[TRG_ChiTietHoaDonBan_INSERT_UPDATE]
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
    DECLARE @TenSP nvarchar(100)=(SELECT TenSanPham FROM SanPham WHERE MaSanPham=@MaSanPham)
    DECLARE @GiaBan INT = (SELECT GiaBan FROM SanPham WHERE MaSanPham = @MaSanPham);
    --cập nhật đơn giá = giá bán của sản phẩm
    UPDATE ChiTietHoaDonBan
    SET DonGia = @GiaBan,
        TenSanPham =@TenSP
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
