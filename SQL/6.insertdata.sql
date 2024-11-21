USE StationeryManagementSystem;

INSERT into NhaCungCap( TenNhaCungCap, DiaChi, SoDienThoai) values (N'Thiên Long', N'Hồ Chí Minh', '0380000001');
INSERT into NhaCungCap( TenNhaCungCap, DiaChi, SoDienThoai) values (N'Việt Tiến', N'Số 1 Võ Văn Ngân', '0380000002');
INSERT into NhaCungCap( TenNhaCungCap, DiaChi, SoDienThoai) values (N'Casio', N'Hiệp Phú, Q9', '0380000003');

INSERT into LoaiSanPham( TenLoaiSanPham) values ( N'Dụng cụ học tập');
INSERT into LoaiSanPham( TenLoaiSanPham) values (N'Đồ dùng văn phòng');
INSERT into LoaiSanPham( TenLoaiSanPham) values ( N'Đồ dùng khác');

INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap) values (N'Bút', 1, 1);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap) values (N'Viết', 1, 2);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap) values (N'Tập', 1, 3);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap) values (N'Giấy', 1, 1);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap) values (N'Kéo', 2, 2);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap) values (N'Sổ tay', 2, 2);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap) values (N'Ô', 3, 2);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap) values (N'Cặp', 1, 2);
INSERT into SanPham(TenSanPham, MaLoaiSanPham, MaNhaCungCap) values (N'Bàn chải', 3, 2);

INSERT into KhachHang(HoTen, DiaChi, SoDienThoai) values (N'Nguyễn Trần Tuyết', N'Hà Nội', '0370000001');
INSERT into KhachHang(HoTen, DiaChi, SoDienThoai) values (N'Lê Văn Nam', N'Đà Lạt', '0370000002');

insert into ChucVu(MaChucVu,TenChucVu,LuongTheoGio) values (1,N'Nhân viên bán hàng',100000);
insert into ChucVu(MaChucVu,TenChucVu,LuongTheoGio) values (2,N'Nhân viên kiểm kho',80000);

INSERT into NhanVien(HoTen,NgaySinh,GioiTinh,DiaChi,SoDienThoai,Email,MaChucVu) values (N'Nguyễn Thị Duyên','1999-02-01',N'Nữ',N'Đà Lạt','0360000001','a1@gmail.com',1);
INSERT into NhanVien(HoTen,NgaySinh,GioiTinh,DiaChi,SoDienThoai,Email,MaChucVu) values (N'Nguyễn Văn Khánh Kiên','2004-02-02',N'Nam',N'Long An','0360000002','a2@gmail.com',1);
INSERT into NhanVien(HoTen,NgaySinh,GioiTinh,DiaChi,SoDienThoai,Email,MaChucVu) values (N'Nguyễn Thị Thuỷ Triều','2000-12-02',N'Nữ',N'Long Xuyên','0360000003','a3@gmail.com',2);


INSERT INTO Ca(MaCa,GioBatDau,GioKetThuc) VALUES (1,'08:00:00','12:00:00');
INSERT INTO Ca(MaCa,GioBatDau,GioKetThuc) VALUES (2,'13:00:00','17:00:00');
INSERT INTO Ca(MaCa,GioBatDau,GioKetThuc) VALUES (3,'18:00:00','20:00:00');

