using System;

namespace BEL
{
    public class BEL_NguoiDung
    {
        protected string _Ma;
        protected string _Ten;
        protected string _GioiTinh;
        protected DateTime _NgaySinh;
        protected string _DiaChi;
        protected string _DienThoai;
        protected string _MatKhau;
        protected string _MaLoai;
        protected string _HinhAnh;
        protected string _TrangThai;
        //
        public BEL_NguoiDung()
        { }
        public BEL_NguoiDung(string Ma, string Ten, string GioiTinh, DateTime NgaySinh, string DiaChi, string DienThoai, string MatKhau, string MaLoai, string HinhAnh,string TrangThai)
        {
            _Ma = Ma;
            _Ten = Ten;
            _GioiTinh = GioiTinh;
            _NgaySinh = NgaySinh;
            _DiaChi = DiaChi;
            _DienThoai = DienThoai;
            _MatKhau = MatKhau;
            _MaLoai = MaLoai;
            _HinhAnh = HinhAnh;
            _TrangThai = TrangThai;
        }
        public BEL_NguoiDung(BEL_NguoiDung NguoiDung)
        {
            _Ma = NguoiDung._Ma;
            _Ten = NguoiDung._Ten;
            _GioiTinh = NguoiDung._GioiTinh;
            _NgaySinh = NguoiDung._NgaySinh;
            _DiaChi = NguoiDung._DiaChi;
            _DienThoai = NguoiDung._DienThoai;
            _MatKhau = NguoiDung._MatKhau;
            _MaLoai = NguoiDung._MaLoai;
            _HinhAnh = NguoiDung._HinhAnh;
            _TrangThai = NguoiDung._TrangThai;
        }
        //
        public string Ma
        {
            get
            {
                return _Ma;
            }
            set
            {
                _Ma = value;
            }
        }
        public string Ten
        {
            get
            {
                return _Ten;
            }
            set
            {
                _Ten = value;
            }
        }
        public string GioiTinh
        {
            get
            {
                return _GioiTinh;
            }
            set
            {
                _GioiTinh = value;
            }
        }
        public DateTime NgaySinh
        {
            get
            {
                return _NgaySinh;
            }
            set
            {
                _NgaySinh = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }
            set
            {
                _DiaChi = value;
            }
        }
        public string DienThoai
        {
            get
            {
                return _DienThoai;
            }
            set
            {
                _DienThoai = value;
            }
        }
        public string MatKhau
        {
            get
            {
                return _MatKhau;
            }
            set
            {
                _MatKhau = value;
            }
        }
        public string MaLoai
        {
            get
            {
                return _MaLoai;
            }
            set
            {
                _MaLoai = value;
            }
        }
        public string HinhAnh
        {
            get
            {
                return _HinhAnh;
            }  
            set
            {
                _HinhAnh = value;
            }
        }
        public string TrangThai
        {
            get
            {
                return _TrangThai;
            }
            set
            {
                _TrangThai = value;
            }
        }
    }
}
