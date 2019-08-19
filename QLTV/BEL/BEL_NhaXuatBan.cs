namespace BEL
{
    public class BEL_NhaXuatBan : BEL_MaVaTen
    {
        private string _Email;
        //
        public BEL_NhaXuatBan()
        { }
        public BEL_NhaXuatBan(string MaNhaXuatBan, string TenNhaXuatBan, string Email, string TrangThai)
        {
            _Ma = MaNhaXuatBan;
            _Ten = TenNhaXuatBan;
            _Email = Email;
            _TrangThai = TrangThai;
        }
        public BEL_NhaXuatBan(BEL_NhaXuatBan NhaXuatBan)
        {
            _Ma = NhaXuatBan._Ma;
            _Ten = NhaXuatBan._Ten;
            _Email = NhaXuatBan._Email;
            _TrangThai = NhaXuatBan._TrangThai;
        }
        //
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }
    }
}
