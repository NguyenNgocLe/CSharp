using System;

namespace BEL
{
    public class BEL_NhanVien : BEL_NguoiDung
    {
        public BEL_NhanVien()
        { }
        public BEL_NhanVien(string MaNhanVien, string TenNhanVien, string GioiTinh, DateTime NgaySinh, string DiaChi, string DienThoai, string MatKhau, string MaLoai, string HinhAnh, string TrangThai)
        {
            _Ma = MaNhanVien;
            _Ten = TenNhanVien;
            _GioiTinh = GioiTinh;
            _NgaySinh = NgaySinh;
            _DiaChi = DiaChi;
            _DienThoai = DienThoai;
            _MatKhau = MatKhau;
            _MaLoai = MaLoai;
            _HinhAnh = HinhAnh;
            _TrangThai = TrangThai;
        }
        public BEL_NhanVien(string MaNhanVien, string TenNhanVien, string GioiTinh, DateTime NgaySinh, string DiaChi, string DienThoai, string MaLoai, string HinhAnh, string TrangThai)
        {
            _Ma = MaNhanVien;
            _Ten = TenNhanVien;
            _GioiTinh = GioiTinh;
            _NgaySinh = NgaySinh;
            _DiaChi = DiaChi;
            _DienThoai = DienThoai;
            _MatKhau = null;
            _MaLoai = MaLoai;
            _HinhAnh = HinhAnh;
            _TrangThai = TrangThai;
        }
        public BEL_NhanVien(BEL_NhanVien NhanVien)
        {
            _Ma = NhanVien._Ma;
            _Ten = NhanVien._Ten;
            _GioiTinh = NhanVien._GioiTinh;
            _NgaySinh = NhanVien._NgaySinh;
            _DiaChi = NhanVien._DiaChi;
            _DienThoai = NhanVien._DienThoai;
            _MatKhau = NhanVien._MatKhau;
            _MaLoai = NhanVien._MaLoai;
            _HinhAnh = NhanVien._HinhAnh;
            _TrangThai = NhanVien._TrangThai;
        }
        
    }
}
