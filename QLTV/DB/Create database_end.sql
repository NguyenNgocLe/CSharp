--Create database!
CREATE DATABASE QUANLYTHUVIEN
GO
USE QUANLYTHUVIEN
GO
--

CREATE TABLE LOAINHANVIEN
(
	MaLoai VARCHAR(6) NOT NULL,
	TenLoai NVARCHAR(30),
	TrangThai NVARCHAR(15)
	CONSTRAINT PK_LOAINHANVIEN PRIMARY KEY(MaLoai)
)
GO

CREATE TABLE NHANVIEN
(	
	MaNhanVien VARCHAR(6) NOT NULL,
	TenNhanVien NVARCHAR(30),
	GioiTinh NVARCHAR(3),
	NgaySinh DATE,
	DiaChi NVARCHAR(50),
	DienThoai VARCHAR(10),
	MatKhau VARCHAR(32),
	MaLoai VARCHAR(6),
	HinhAnh NVARCHAR(30),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_NHANVIEN PRIMARY KEY(MaNhanVien),
	CONSTRAINT FK_NHANVIEN_LOAINHANVIEN FOREIGN KEY(MaLoai) REFERENCES LOAINHANVIEN(MaLoai)
)
GO

CREATE TABLE LOAIDOCGIA
(
	MaLoai VARCHAR(6) NOT NULL,
	TenLoai NVARCHAR(30),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_LOAIDOCGIA PRIMARY KEY(MaLoai)
)
GO

CREATE TABLE DOCGIA
(
	MaDocGia VARCHAR(6) NOT NULL,
	TenDocGia NVARCHAR(30),
	GioiTinh NVARCHAR(3),
	NgaySinh DATE,
	DiaChi NVARCHAR(50),
	DienThoai VARCHAR(10),
	MatKhau NVARCHAR(32),
	MaLoai VARCHAR(6),
	HinhAnh NVARCHAR(30),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_DOCGIA PRIMARY KEY(MaDocGia),
	CONSTRAINT FK_DOCGIA_LOAIDOCGIA FOREIGN KEY(MaLoai) REFERENCES LOAIDOCGIA(MaLoai)
)
GO

CREATE TABLE TACGIA
(
	MaTacGia VARCHAR(6) NOT NULL,
	TenTacGia NVARCHAR(30),
	DienThoai VARCHAR(10),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_TACGIA PRIMARY KEY(MaTacGia)
)
GO

CREATE TABLE NHAXUATBAN
(
	MaNhaXuatBan VARCHAR(6) NOT NULL,
	TenNhaXuatBan NVARCHAR(30),
	Email VARCHAR(30),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_NHAXUATBAN PRIMARY KEY(MaNhaXuatBan)
)
GO

CREATE TABLE NGONNGU
(	
	MaNgonNgu VARCHAR(6) NOT NULL,
	TenNgonNgu NVARCHAR(30),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_NGONNGU PRIMARY KEY(MaNgonNgu)
)
GO

CREATE TABLE LOAISACH
(
	MaLoai VARCHAR(6) NOT NULL,
	TenLoai NVARCHAR(30),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_LOAISACH PRIMARY KEY(MaLoai)
)
GO

CREATE TABLE SACH
(
	MaSach VARCHAR(6) NOT NULL,
	TenSach NVARCHAR(50),
	MaLoai VARCHAR(6),
	MaTacGia VARCHAR(6),
	MaNgonNgu VARCHAR(6),
	MaNhaXuatBan VARCHAR(6),
	NamXuatBan VARCHAR(4),
	SoLuong INT,
	GiaNhap INT,
	MoTa NVARCHAR(MAX),
	HinhAnh NVARCHAR(30),
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_SACH PRIMARY KEY(MaSach),
	CONSTRAINT FK_SACH_TACGIA FOREIGN KEY(MaTacGia) REFERENCES TACGIA(MaTacGia),
	CONSTRAINT FK_SACH_NHAXUATBAN FOREIGN KEY(MaNhaXuatBan) REFERENCES NHAXUATBAN(MaNhaXuatBan),
	CONSTRAINT FK_SACH_NGONNGU FOREIGN KEY(MaNgonNgu) REFERENCES NGONNGU(MaNgonNgu),
	CONSTRAINT FK_SACH_LOAISACH FOREIGN KEY(MaLoai) REFERENCES LOAISACH(MaLoai)
)
GO

CREATE TABLE HOADONNHAP
(
	MaHoaDon VARCHAR(6) NOT NULL,
	MaNhanVien VARCHAR(6),
	NgayLap DATE,
	TongTien INT,
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_HOADONNHAP PRIMARY KEY(MaHoaDon),
	CONSTRAINT FK_HOADONNHAP_NHANVIEN FOREIGN KEY(MaNhanVien) REFERENCES NHANVIEN(MaNhanVien)
)
GO

CREATE TABLE CHITIETHOADONNHAP
(	
	MaHoaDon VARCHAR(6) NOT NULL,
	MaSach VARCHAR(6) NOT NULL,
	SoLuong INT,
	CONSTRAINT PK_CHITIETHOADONNHAP PRIMARY KEY(MaHoaDon, MaSach),
	CONSTRAINT FK_CHITIETHOADONNHAP_HOADONNHAP FOREIGN KEY(MaHoaDon) REFERENCES HOADONNHAP(MaHoaDon)
)
GO

CREATE TABLE HOADONMUON
(
	MaHoaDon VARCHAR(6) NOT NULL,
	MaNhanVien VARCHAR(6),
	MaDocGia VARCHAR(6),
	NgayLap DATE,
	NgayTra DATE,
	DaTra BIT,
	TrangThai NVARCHAR(15),
	CONSTRAINT PK_HOADONMUON PRIMARY KEY(MaHoaDon),
	CONSTRAINT FK_HOADONMUON_NHANVIEN FOREIGN KEY(MaNhanVien) REFERENCES NHANVIEN(MaNhanVien),
	CONSTRAINT FK_HOADONMUON_DOCGIA FOREIGN KEY(MaDocGia) REFERENCES DOCGIA(MaDocGia)
)
GO

CREATE TABLE CHITIETHOADONMUON
(
	MaHoaDon VARCHAR(6) NOT NULL,
	MaSach VARCHAR(6),
	SoLuong INT,
	CONSTRAINT PK_CHITIETHOADONMUON PRIMARY KEY(MaHoaDon, MaSach),
	CONSTRAINT FK_CHITIETHOADONMUON_HOADONMUON FOREIGN KEY(MaHoaDon) REFERENCES HOADONMUON(MaHoaDon),
	CONSTRAINT FK_CHITIETHOADONMUON_SACH FOREIGN KEY(MaSach) REFERENCES SACH(MaSach)
)
GO

--Insert data!
INSERT INTO LOAINHANVIEN(MaLoai, TenLoai, TrangThai)
VALUES ('LNV1', N'Quản lý kho', N'Tồn tại')
INSERT INTO LOAINHANVIEN(MaLoai, TenLoai, TrangThai)
VALUES ('LNV2', N'Thủ thư', N'Tồn tại')

INSERT INTO NHANVIEN(MaNhanVien, TenNhanVien, GioiTinh, NgaySinh, DiaChi, DienThoai, MatKhau, MaLoai, HinhAnh, TrangThai)
VALUES ('NV1', N'Lâm Triều Anh', N'Nữ', '02-29-1992', N'Quận 1, TP.HCM', '0868383838', 'c4ca4238a0b923820dcc509a6f75849b', 'LNV1', N'nv1.jpg', N'Tồn tại')
INSERT INTO NHANVIEN(MaNhanVien, TenNhanVien, GioiTinh, NgaySinh, DiaChi, DienThoai, MatKhau, MaLoai, HinhAnh, TrangThai)
VALUES ('NV2', N'Nguyễn Ngọc Trâm Anh', N'Nữ', '07-07-1995', N'Đường Trần Duy Hưng, Hà Nội', '0868404404', 'c81e728d9d4c2f636f067f89cc14862c', 'LNV2', N'nv2.jpg', N'Tồn tại')
INSERT INTO NHANVIEN(MaNhanVien, TenNhanVien, GioiTinh, NgaySinh, DiaChi, DienThoai, MatKhau, MaLoai, HinhAnh, TrangThai)
VALUES('NV3', N'Phi Huyền Trang', N'Nữ', '05-05-1995', N'Đống Đa, Hà Nội', '0365874523', 'eccbc87e4b5ce2fe28308fd9f2a7baf3', 'LNV2', N'nv3.jpg', N'Hủy')

INSERT INTO LOAIDOCGIA(MaLoai, TenLoai, TrangThai)
VALUES ('LDG1', N'Trẻ em', N'Tồn tại')
INSERT INTO LOAIDOCGIA(MaLoai, TenLoai, TrangThai)
VALUES ('LDG2', N'Nguời lớn',  N'Tồn tại')

INSERT INTO DOCGIA(MaDocGia, TenDocGia, GioiTinh, NgaySinh, DiaChi, DienThoai, MatKhau, MaLoai, HinhAnh, TrangThai)
VALUES ('DG1', N'Lâm Xung', 'Nam', '01-13-2002', N'Quận Thủ Đức, TP.HCM', '0888123123', 'c4ca4238a0b923820dcc509a6f75849b', 'LDG1', N'ldg1.jpg', N'Tồn tại')
INSERT INTO DOCGIA(MaDocGia, TenDocGia, GioiTinh, NgaySinh, DiaChi, DienThoai, MatKhau, MaLoai, HinhAnh, TrangThai)
VALUES ('DG2', N'Lý Tiểu Long', 'Nam', '07-23-1967', N'Thường Châu - Trung Quốc', '0888789789', 'c81e728d9d4c2f636f067f89cc14862c', 'LDG2', N'dg2.jpg', N'Tồn tại')
INSERT INTO DOCGIA(MaDocGia, TenDocGia, GioiTinh, NgaySinh, DiaChi, DienThoai, MatKhau, MaLoai, HinhAnh, TrangThai)
VALUES('DG3', N'Hoàng Phi Hồng', 'Nam', '03-03-1962', N'Quảng Châu - Trung Quốc', '0365895632', 'eccbc87e4b5ce2fe28308fd9f2a7baf3', 'LDG2', N'dg3.jpg', N'Hủy')

INSERT INTO LOAISACH(MaLoai, TenLoai, TrangThai)
VALUES ('LS1', N'Tiểu thuyết', N'Tồn tại')
INSERT INTO LOAISACH(MaLoai, TenLoai, TrangThai)
VALUES ('LS2', N'Văn học', N'Tồn tại')
INSERT INTO LOAISACH(MaLoai, TenLoai, TrangThai)
VALUES ('LS3', N'Ngôn tình', N'Hủy')

INSERT INTO TACGIA(MaTacGia, TenTacGia, DienThoai, TrangThai)
VALUES ('TG1', N'Nam Cao', '0358363232', N'Tồn tại')
INSERT INTO TACGIA(MaTacGia, TenTacGia, DienThoai, TrangThai)
VALUES ('TG2', N'Vũ Đình Liên', '0361478963', N'Tồn tại')
INSERT INTO TACGIA(MaTacGia, TenTacGia, DienThoai, TrangThai)
VALUES ('TG3', N'Tố Hữu', '0361478963', N'Hủy')

INSERT INTO NGONNGU(MaNgonNgu, TenNgonNgu, TrangThai)
VALUES ('NN1', N'Tiếng Anh', N'Tồn tại')
INSERT INTO NGONNGU(MaNgonNgu, TenNgonNgu, TrangThai)
VALUES ('NN2', N'Tiếng Nga', N'Tồn tại')
INSERT INTO NGONNGU(MaNgonNgu, TenNgonNgu, TrangThai)
VALUES ('NN3', N'Tiếng Việt', N'Huỷ')

INSERT INTO NHAXUATBAN(MaNhaXuatBan, TenNhaXuatBan, Email, TrangThai)
VALUES ('NXB1', N'Kim Đồng', 'Kimdong@gmail.com', N'Tồn tại')
INSERT INTO NHAXUATBAN(MaNhaXuatBan, TenNhaXuatBan, Email, TrangThai)
VALUES ('NXB2', N'Hà Nội', 'Hanoi@gmail.com', N'Tồn tại')
INSERT INTO NHAXUATBAN(MaNhaXuatBan, TenNhaXuatBan, Email, TrangThai)
VALUES ('NXB3', N'TPHCM', 'TPHCM@gmail.com', N'Hủy')

INSERT INTO SACH(MaSach, TenSach, MaLoai, MaTacGia, MaNgonNgu, MaNhaXuatBan, NamXuatBan, SoLuong, GiaNhap, MoTa, HinhAnh, TrangThai)
VALUES ('S1', N'Hôm nay tôi thất tình', 'LS1', 'TG1', 'NN1', 'NXB1', '2015', 10, 135000, N'Đây là sách hôm nay tôi thất tình', N's1.jpg', N'Tồn tại')
INSERT INTO SACH(MaSach, TenSach, MaLoai, MaTacGia, MaNgonNgu, MaNhaXuatBan, NamXuatBan, SoLuong, GiaNhap, MoTa, HinhAnh, TrangThai)
VALUES ('S2', N'Thủy Hử', 'LS2', 'TG2', 'NN2', 'NXB2', '2005', 5, 125000, N'Đây là sách Thủy Hử', N's2.jpg', N'Đang cho mượn')
INSERT INTO SACH(MaSach, TenSach, MaLoai, MaTacGia, MaNgonNgu, MaNhaXuatBan, NamXuatBan, SoLuong, GiaNhap, MoTa, HinhAnh, TrangThai)
VALUES ('S3', N'Tây Tiến', 'LS2', 'TG2', 'NN2', 'NXB3', '1975', 9, 365000, N'Đây là sách Tây Tiến', N's3.jpg', N'Hủy')

INSERT INTO HOADONNHAP(MaHoaDon, MaNhanVien, NgayLap, TongTien, TrangThai)
VALUES ('HD1', 'NV1', '10-20-2019', 13500000, N'Tồn tại')
INSERT INTO HOADONNHAP(MaHoaDon, MaNhanVien, NgayLap, TongTien, TrangThai)
VALUES ('HD2', 'NV2', '03-22-2019', 625000, N'Tồn tại')
INSERT INTO HOADONNHAP(MaHoaDon, MaNhanVien, NgayLap, TongTien, TrangThai)
VALUES ('HD3', 'NV3', '09-05-2019', 3285000, N'Hủy')

INSERT INTO CHITIETHOADONNHAP(MaHoaDon, MaSach, SoLuong)
VALUES ('HD1', 'S1', 10)
INSERT INTO CHITIETHOADONNHAP(MaHoaDon, MaSach, SoLuong)
VALUES ('HD2', 'S2', 5)
INSERT INTO CHITIETHOADONNHAP(MaHoaDon, MaSach, SoLuong)
VALUES ('HD3', 'S3', 9)

INSERT INTO HOADONMUON(MaHoaDon, MaNhanVien, MaDocGia, NgayLap, NgayTra, DaTra, TrangThai)
VALUES ('HD1', 'NV1', 'DG1', '06-02-2018', '06-09-2018', 1, N'Tồn tại')
INSERT INTO HOADONMUON(MaHoaDon, MaNhanVien, MaDocGia, NgayLap, NgayTra, DaTra, TrangThai)
VALUES ('HD2', 'NV1', 'DG2', '06-02-2018', '06-09-2018', 1, N'Tồn tại')
INSERT INTO HOADONMUON(MaHoaDon, MaNhanVien, MaDocGia, NgayLap, NgayTra, DaTra, TrangThai)
VALUES ('HD3', 'NV2', 'DG2', '09-03-2018', '09-10-2018', 1, N'Huỷ')

INSERT INTO CHITIETHOADONMUON(MaHoaDon, MaSach, SoLuong)
VALUES ('HD1', 'S1', 4)
INSERT INTO CHITIETHOADONMUON(MaHoaDon, MaSach, SoLuong)
VALUES ('HD2', 'S2', 6)
INSERT INTO CHITIETHOADONMUON(MaHoaDon, MaSach, SoLuong)
VALUES ('HD3', 'S3', 3)
