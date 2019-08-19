using System;

namespace BEL
{
    public class BEL_HoaDonMuon
    {
        private string _MaHoaDon;
        private string _MaNhanVien;
        private string _MaDocGia;
        private DateTime _NgayLap;
        private DateTime _NgayTra;
        private bool _DaTra;
        private string _TrangThai;
        //
        public BEL_HoaDonMuon()
        { }
        public BEL_HoaDonMuon(string MaHoaDon, string MaNhanVien, string MaDocGia, DateTime NgayLap, DateTime NgayTra, bool DaTra, string TrangThai)
        {
            _MaHoaDon = MaHoaDon;
            _MaNhanVien = MaNhanVien;
            _MaDocGia = MaDocGia;
            _NgayLap = NgayLap;
            _NgayTra = NgayTra;
            _DaTra = DaTra;
            _TrangThai = TrangThai;
        }
        public BEL_HoaDonMuon(BEL_HoaDonMuon HoaDonMuon)
        {
            _MaHoaDon = HoaDonMuon._MaHoaDon;
            _MaNhanVien = HoaDonMuon._MaNhanVien;
            _MaDocGia = HoaDonMuon._MaDocGia;
            _NgayLap = HoaDonMuon._NgayLap;
            _NgayTra = HoaDonMuon._NgayTra;
            _DaTra = HoaDonMuon._DaTra;
            _TrangThai = HoaDonMuon._TrangThai;
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
        public string MaDocGia
        {
            get
            {
                return _MaDocGia;
            }
            set
            {
                _MaDocGia = value;
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
        public DateTime NgayTra
        {
            get
            {
                return _NgayTra;
            }
            set
            {
                _NgayTra = value;
            }
        }
        public bool DaTra
        {
            get
            {
                return _DaTra;
            }
            set
            {
                _DaTra = value;
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
