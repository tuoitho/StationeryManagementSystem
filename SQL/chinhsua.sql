
alter table PhanCa ADD LoaiCa nvarchar(50) not null DEFAULT N'Cố Định';
go
create PROCEDURE BaoNghiCa
    @MaNhanVien INT,
    @MaCa INT,
    @Ngay DATE
AS
BEGIN
    Update PhanCa
    SET LoaiCa = N'Báo Nghỉ'
    WHERE MaNhanVien = @MaNhanVien AND MaCa = @MaCa AND Ngay = @Ngay;
END;

go

alter FUNCTION fn_DanhSachLuongNhanVienTheoNgay(@Ngay DATE)
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
        WHERE p.ngay = @Ngay and p.LoaiCa != N'Báo Nghỉ'
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
        Join PhanCa p ON n.MaNhanVien = p.MaNhanVien and p.LoaiCa != N'Báo Nghỉ'
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

alter FUNCTION fn_DanhSachLuongNhanVienTheoThang(@Thang INT, @Nam INT)
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
        WHERE MONTH(p.ngay) = @Thang AND YEAR(p.ngay) = @Nam and p.LoaiCa != N'Báo Nghỉ'
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
        WHERE MONTH(p.ngay) = @Thang AND YEAR(p.ngay) = @Nam and p.LoaiCa != N'Báo Nghỉ'
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


alter FUNCTION fn_DanhSachLuongNhanVienTheoThang(@Thang INT, @Nam INT)
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
        WHERE MONTH(p.ngay) = @Thang AND YEAR(p.ngay) = @Nam and p.LoaiCa != N'Báo Nghỉ'
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
        WHERE MONTH(p.ngay) = @Thang AND YEAR(p.ngay) = @Nam and p.LoaiCa != N'Báo Nghỉ'
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

go-- 3.10.5. Ứng dụng transaction: Khi có quá nhiều nhân viên đăng ký ca làm thêm tại 1 thời điêm, hệ thống đảm bảo chỉ 1 nhân viên đăng ký thành công.
CREATE OR ALTER PROCEDURE sp_DangKiCaLamThem
    @MaNhanVien INT,
    @Ngay DATE
AS
BEGIN
BEGIN TRY
    BEGIN TRANSACTION;
    ------chỉ đc đăng kí từ 7:00:00 đến 8:00:00
    IF CAST(GETDATE() AS TIME) < '07:00:00' OR CAST(GETDATE() AS TIME) > '08:00:00'
    BEGIN
        RAISERROR('Chỉ được đăng ký ca làm thêm từ 7:00:00 đến 8:00:00', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
    DECLARE @Slot INT;
    SELECT @Slot = COUNT(*) 
    FROM PhanCa 
    WITH (UPDLOCK, HOLDLOCK)  -- UPDLOCK ngăn các transaction thực hiện thay đổi trên các bản ghi ,  áp dụng một khóa cập nhật thay vì khóa chia sẻ, Khóa cập nhật ngăn các giao dịch khác lấy khóa cập nhật hoặc khóa độc quyền (Exclusive Lock - X) trên cùng một bản ghi.
                             --  HOLDLOCK: Khóa này giữ tất cả các khóa cập nhật (UPDLOCK) trong toàn bộ thời gian của giao dịch, giúp ngăn các giao dịch khác thêm hoặc sửa dữ liệu trên các bản ghi được chọn.
    WHERE Ngay = @Ngay and MaCa = 3
    -- print @Slot
    IF @Slot = 0
    -- nếu chưa nhân viên nào đăng ký ca làm thêm
    BEGIN
        -- Đăng ký ca làm thêm
        INSERT INTO PhanCa
          (MaNhanVien, MaCa, Ngay,LoaiCa)
        VALUES(@MaNhanVien, 3, @Ngay, N'Đăng Ký');
        COMMIT TRANSACTION;
    END
    ELSE
    -- tức là đã có nhân viên đăng ký ca làm thêm
        BEGIN
            THROW 51000, 'Hôm nay đã có nhân viên đăng ký ca làm thêm', 1;
        END
END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;
    DECLARE @ErrorMessage NVARCHAR(4000);
    SET @ErrorMessage = ERROR_MESSAGE();
    RAISERROR (@ErrorMessage, 16, 1);
END CATCH
END