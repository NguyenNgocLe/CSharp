namespace BEL
{
    public class BEL_LoaiDocGia : BEL_MaVaTen
    {
        public BEL_LoaiDocGia()
        { }
        public BEL_LoaiDocGia(string MaLoai, string TenLoai, string TrangThai)
        {
            _Ma = MaLoai;
            _Ten = TenLoai;
            _TrangThai = TrangThai;
        }
        public BEL_LoaiDocGia(BEL_LoaiDocGia LoaiDocGia)
        {
            _Ma = LoaiDocGia._Ma;
            _Ten = LoaiDocGia._Ten;
            _TrangThai = LoaiDocGia._TrangThai;
        }
    }
}
