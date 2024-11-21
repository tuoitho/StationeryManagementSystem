-- 3.10.5. Ứng dụng transaction: Khi có quá nhiều nhân viên đăng ký ca làm thêm tại 1 thời điêm, hệ thống đảm bảo chỉ 1 nhân viên đăng ký thành công.
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

-- 
-- exec sp_DangKiCaLamThem 1, '2021-12-01'
-- exec sp_DangKiCaLamThem 2, '2021-12-01'
