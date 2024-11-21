DROP PROCEDURE sp_HuyDangKiCa3;
DROP PROCEDURE sp_KhoiPhuc;
DROP PROCEDURE sp_XoaVinhVien;

go

-- tạo login
CREATE LOGIN [abcd] WITH PASSWORD = '123'
-- drop LOGIN [abcd]
-- tạo user
CREATE USER abcd  FOR LOGIN [abcd]
-- add user vào role
ALTER ROLE BanHang ADD MEMBER abcd