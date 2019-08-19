namespace BEL
{
    public class BEL_TacGia : BEL_MaVaTen
    {
        private string _DienThoai;
        //
        public BEL_TacGia()
        { }
        public BEL_TacGia(string MaTacGia, string TenTacGia, string DienThoai, string TrangThai)
        {
            _Ma = MaTacGia;
            _Ten = TenTacGia;
            _DienThoai = DienThoai;
            _TrangThai = TrangThai;
        }

        public BEL_TacGia(BEL_TacGia TacGia)
        {
            _Ma = TacGia._Ma;
            _Ten = TacGia._Ten;
            _DienThoai = TacGia._DienThoai;
            _TrangThai = TacGia.TrangThai;
        }
        //
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
    }
}
