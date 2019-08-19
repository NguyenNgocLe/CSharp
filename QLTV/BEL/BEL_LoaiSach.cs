namespace BEL
{
    public class BEL_LoaiSach : BEL_MaVaTen
    {
        public BEL_LoaiSach()
        { }
        public BEL_LoaiSach(string MaLoai, string TenLoai, string TrangThai)
        {
            _Ma = MaLoai;
            _Ten = TenLoai;
            _TrangThai = TrangThai;
        }
        public BEL_LoaiSach(BEL_LoaiSach LoaiSach)
        {
            _Ma = LoaiSach._Ma;
            _Ten = LoaiSach._Ten;
            _TrangThai = LoaiSach._TrangThai;
        }
    }
}
