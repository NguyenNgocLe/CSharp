using System;

namespace BEL
{
    public class BEL_ChiTietHoaDonMuon
    {
        private string _MaHoaDon;
        private string _MaSach;
        private int _SoLuong;
        //
        public BEL_ChiTietHoaDonMuon()
        { }
        public BEL_ChiTietHoaDonMuon(string MaHoaDon, string MaSach, int SoLuong, string DonGia)
        {
            _MaHoaDon = MaHoaDon;
            _MaSach = MaSach;
            _SoLuong = SoLuong;
        }
        public BEL_ChiTietHoaDonMuon(BEL_ChiTietHoaDonMuon ChiTietHoaDonMuon)
        {
            _MaHoaDon = ChiTietHoaDonMuon._MaHoaDon;
            _MaSach = ChiTietHoaDonMuon._MaSach;
            _SoLuong = ChiTietHoaDonMuon._SoLuong;
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
