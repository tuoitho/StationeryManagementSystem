use StationeryManagementSystem

GRANT SELECT,INSERT,UPDATE,DELETE ON LoaiSanPham TO BanHang;
GRANT SELECT,INSERT,UPDATE,DELETE ON LoaiSanPham TO KiemKho;

GRANT EXEC ON sp_XemDanhSachSanPhamCuaNhaCungCap TO KiemKho;

GRANT SELECT,INSERT ON PhanCa TO BanHang;
GRANT SELECT,INSERT ON PhanCa TO KiemKho;


GRANT EXEC ON dbo.SearchTable TO BanHang;
GRANT EXEC ON dbo.SearchTable TO KiemKho;
