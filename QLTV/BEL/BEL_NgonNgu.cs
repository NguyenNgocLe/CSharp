namespace BEL
{
    public class BEL_NgonNgu : BEL_MaVaTen
    {
        public BEL_NgonNgu()
        { }
        public BEL_NgonNgu(string MaNgonNgu, string TenNgonNgu, string TrangThai)
        {
            _Ma = MaNgonNgu;
            _Ten = TenNgonNgu;
            _TrangThai = TrangThai;
        }
        public BEL_NgonNgu(BEL_NgonNgu NgonNgu)
        {
            _Ma = NgonNgu._Ma;
            _Ten = NgonNgu._Ten;
            _TrangThai = NgonNgu._TrangThai;
        }
    }
}
