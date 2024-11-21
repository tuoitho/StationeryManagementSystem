
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
    FROM fn_DanhSachLuongNhanVienTheoThang(@Thang, @Nam);

    -- Tính tổng chi phí nhập hàng trong tháng
    SELECT @TongChiPhiNhapHang = ISNULL(SUM(cthdn.SoLuong * cthdn.DonGia), 0)
    FROM HoaDonNhap hdn
    JOIN ChiTietHoaDonNhap cthdn ON hdn.MaHoaDonNhap = cthdn.MaHoaDonNhap
    WHERE MONTH(hdn.NgayLap) = @Thang AND YEAR(hdn.NgayLap) = @Nam;

    -- Trả về tổng chi tiêu = tổng lương + tổng chi phí nhập hàng
    RETURN @TongLuong + @TongChiPhiNhapHang;
END;
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
