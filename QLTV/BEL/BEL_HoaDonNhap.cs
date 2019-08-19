using System;

namespace BEL
{
    public class BEL_HoaDonNhap
    {
        private string _MaHoaDon;
        private string _MaNhanVien;
        private DateTime _NgayLap;
        private int _TongTien;
        private string _TrangThai;
        //
        public BEL_HoaDonNhap()
        { }
        public BEL_HoaDonNhap(string MaHoaDon, string MaNhanVien, DateTime NgayLap, int TongTien, string TrangThai)
        {
            _MaHoaDon = MaHoaDon;
            _MaNhanVien = MaNhanVien;
            _NgayLap = NgayLap;
            _TongTien = TongTien;
            _TrangThai = TrangThai;
        }
        public BEL_HoaDonNhap(BEL_HoaDonNhap HoaDonNhap)
        {
            _MaHoaDon = HoaDonNhap._MaHoaDon;
            _MaNhanVien = HoaDonNhap._MaNhanVien;
            _NgayLap = HoaDonNhap._NgayLap;
            _TongTien = HoaDonNhap._TongTien;
            _TrangThai = HoaDonNhap._TrangThai;
        }
        //
        public string MaHoaDon
        {
            get
            {
                return _MaHoaDon;
            }
            set
            {
                _MaHoaDon = value;
            }
        }
        public string MaNhanVien
        {
            get
            {
                return _MaNhanVien;
            }
            set
            {
                _MaNhanVien = value;
            }
        }
        public DateTime NgayLap
        {
            get
            {
                return _NgayLap;
            }
            set
            {
                _NgayLap = value;
            }
        }
        public int TongTien
        {
            get
            {
                return _TongTien;
            }
            set
            {
                _TongTien = value;
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
