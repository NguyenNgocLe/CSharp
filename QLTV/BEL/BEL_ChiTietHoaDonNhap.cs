using System;

namespace BEL
{
    public class BEL_ChiTietHoaDonNhap
    {
        private string _MaHoaDon;
        private string _MaSach;
        private int _SoLuong;
        //
        public BEL_ChiTietHoaDonNhap()
        { }
        public BEL_ChiTietHoaDonNhap(string MaHoaDon, string MaSach, int SoLuong)
        {
            _MaHoaDon = MaHoaDon;
            _MaSach = MaSach;
            _SoLuong = SoLuong;
        }
        public BEL_ChiTietHoaDonNhap(BEL_ChiTietHoaDonNhap ChiTietHoaDonNhap)
        {
            _MaHoaDon = ChiTietHoaDonNhap._MaHoaDon;
            _MaSach = ChiTietHoaDonNhap._MaSach;
            _SoLuong = ChiTietHoaDonNhap._SoLuong;
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
    }
}
