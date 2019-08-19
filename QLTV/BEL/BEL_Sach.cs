namespace BEL
{
    public class BEL_Sach
    {
        private string _MaSach;
        private string _TenSach;
        private string _MaLoai;
        private string _MaTacGia;
        private string _MaNgonNgu;
        private string _MaNhaXuatBan;
        private string _NamXuatBan;
        private int _SoLuong;
        private int _GiaNhap;
        private string _MoTa;
        private string _HinhAnh;
        private string _TrangThai;
        //
        public BEL_Sach()
        { }
        public BEL_Sach(string MaSach, string TenSach, string MaLoai, string MaTacGia, string MaNgonNgu, string MaNhaXuatBan, string NamXuatBan, int SoLuong, int GiaNhap, string MoTa, string HinhAnh, string TrangThai)
        {
            _MaSach = MaSach;
            _TenSach = TenSach;
            _MaLoai = MaLoai;
            _MaTacGia = MaTacGia;
            _MaNgonNgu = MaNgonNgu;
            _MaNhaXuatBan = MaNhaXuatBan;
            _NamXuatBan = NamXuatBan;
            _SoLuong = SoLuong;
            _GiaNhap = GiaNhap;
            _MoTa = MoTa;
            _HinhAnh = HinhAnh;
            _TrangThai = TrangThai;
        }

        public BEL_Sach(BEL_Sach Sach)
        {
            _MaSach = Sach._MaSach;
            _TenSach = Sach._TenSach;
            _MaLoai = Sach._MaLoai;
            _MaTacGia = Sach._MaTacGia;
            _MaNgonNgu = Sach._MaNgonNgu;
            _MaNhaXuatBan = Sach._MaNhaXuatBan;
            _NamXuatBan = Sach._NamXuatBan;
            _SoLuong = Sach._SoLuong;
            _GiaNhap = Sach._GiaNhap;
            _MoTa = Sach._MoTa;
            _HinhAnh = Sach._HinhAnh;
            _TrangThai = Sach._TrangThai;
        }
        //
        public string MaSach
        {
            get
            {
                return _MaSach;
            }
            set
            {
                _MaSach = value;
            }
        }
        public string TenSach
        {
            get
            {
                return _TenSach;
            }
            set
            {
                _TenSach = value;
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
        public string MaTacGia
        {
            get
            {
                return _MaTacGia;
            }
            set
            {
                _MaTacGia = value;
            }
        }
        public string MaNgonNgu
        {
            get
            {
                return _MaNgonNgu;
            }
            set
            {
                _MaNgonNgu = value;
            }
        }
        public string MaNhaXuatBan
        {
            get
            {
                return _MaNhaXuatBan;
            }
            set
            {
                _MaNhaXuatBan = value;
            }
        }     
        public string NamXuatBan
        {
            get
            {
                return _NamXuatBan;
            }
            set
            {
                _NamXuatBan = value;
            }
        }
        public int SoLuong
        {
            get
            {
                return _SoLuong;
            }
            set
            {
                _SoLuong = value;
            }
        }
        public int GiaNhap
        {
            get
            {
                return _GiaNhap;
            }
            set
            {
                _GiaNhap = value;
            }
        }
        public string MoTa
        {
            get
            {
                return _MoTa;
            }
            set
            {
                _MoTa = value;
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
