namespace BEL
{
    public class BEL_MaVaTen
    {
        protected string _Ma;
        protected string _Ten;
        protected string _TrangThai;
        //
        public BEL_MaVaTen()
        { }
        public BEL_MaVaTen(string Ma, string Ten, string TrangThai)
        {
            _Ma = Ma;
            _Ten = Ten;
            _TrangThai = TrangThai;
        }
        public BEL_MaVaTen(BEL_MaVaTen MaVaTen)
        {
            _Ma = MaVaTen._Ma;
            _Ten = MaVaTen._Ten;
            _TrangThai = MaVaTen._TrangThai;
        }
        //
        public string Ma
        {
            get
            {
                return _Ma;
            }
            set
            {
                _Ma = value;
            }
        }
        public string Ten
        {
            get
            {
                return _Ten;
            }
            set
            {
                _Ten = value;
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
