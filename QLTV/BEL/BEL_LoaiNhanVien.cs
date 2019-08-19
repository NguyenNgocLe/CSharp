namespace BEL
{
    public class BEL_LoaiNhanVien : BEL_MaVaTen
    {
        public BEL_LoaiNhanVien()
        { }
        public BEL_LoaiNhanVien(string MaLoai, string TenLoai, string TrangThai)
        {
            _Ma = MaLoai;
            _Ten = TenLoai;
            _TrangThai = TrangThai;
        }
        public BEL_LoaiNhanVien(BEL_LoaiNhanVien LoaiNhanVien)
        {
            _Ma = LoaiNhanVien._Ma;
            _Ten = LoaiNhanVien._Ten;
            _TrangThai = LoaiNhanVien._TrangThai;
        }
    }
}
