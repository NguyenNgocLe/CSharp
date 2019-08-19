using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class General
    {
        protected static SqlConnection Connection = new SqlConnection(@"Data Source=TAN\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=true;");
        //
        protected static void GetConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }
    }
}
