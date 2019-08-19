using System;

namespace BEL
{
    public class BEL_DocGia : BEL_NguoiDung
    {
        public BEL_DocGia()
        { }
        public BEL_DocGia(string MaDocGia, string TenDocGia, string GioiTinh, DateTime NgaySinh, string DiaChi, string DienThoai, string MatKhau, string MaLoai, string HinhAnh, string TrangThai)
        {
            _Ma = MaDocGia;
            _Ten = TenDocGia;
            _GioiTinh = GioiTinh;
            _NgaySinh = NgaySinh;
            _DiaChi = DiaChi;
            _DienThoai = DienThoai;
            _MatKhau = MatKhau;
            _MaLoai = MaLoai;
            _HinhAnh = HinhAnh;
            _TrangThai = TrangThai;
        }
        public BEL_DocGia(string MaDocGia, string TenDocGia, string GioiTinh, DateTime NgaySinh, string DiaChi, string DienThoai, string MaLoai, string HinhAnh, string TrangThai)
        {
            _Ma = MaDocGia;
            _Ten = TenDocGia;
            _GioiTinh = GioiTinh;
            _NgaySinh = NgaySinh;
            _DiaChi = DiaChi;
            _DienThoai = DienThoai;
            _MatKhau = null;
            _MaLoai = MaLoai;
            _HinhAnh = HinhAnh;
            _TrangThai = TrangThai;
        }
        public BEL_DocGia(BEL_DocGia DocGia)
        {
            _Ma = DocGia._Ma;
            _Ten = DocGia._Ten;
            _GioiTinh = DocGia._GioiTinh;
            _NgaySinh = DocGia._NgaySinh;
            _DiaChi = DocGia._DiaChi;
            _DienThoai = DocGia._DienThoai;
            _MatKhau = DocGia._MatKhau;
            _MaLoai = DocGia._MaLoai;
            _HinhAnh = DocGia._HinhAnh;
            _TrangThai = DocGia._TrangThai;
        }
    }
}
