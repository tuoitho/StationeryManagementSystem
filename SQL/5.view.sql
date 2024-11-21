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
