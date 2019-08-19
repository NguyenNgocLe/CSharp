using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_TacGia : General
    {
        public static DataTable Load()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaTacGia, TenTacGia, DienThoai from TACGIA where TrangThai = N'Tồn tại'");
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataTable Result = new DataTable();
                Result.Load(DataReader);
                return Result;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static bool IsExist(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select* from TACGIA where MaTacGia = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                object Result = Command.ExecuteScalar();
                return (Result != null);
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static bool Add(BEL_TacGia TacGia)
        {
            try
            {
                GetConnection();
                string Query = string.Format("insert into TACGIA(MaTacGia, TenTacGia, DienThoai, TrangThai) values('{0}', N'{1}', N'{2}', N'{3}')", TacGia.Ma, TacGia.Ten, TacGia.DienThoai, TacGia.TrangThai);
                SqlCommand Command = new SqlCommand(Query, Connection);
                int Result = Command.ExecuteNonQuery();
                return (Result == 1);
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static bool Delete(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("update TACGIA set TrangThai = N'Huỷ' where MaTacGia = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                int Result = Command.ExecuteNonQuery();
                return (Result == 1);
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static bool Update(BEL_TacGia TacGia)
        {
            try
            {
                GetConnection();
                string Query = string.Format("update TACGIA set TenTacGia = N'{0}', DienThoai = '{1}' where MaTacGia = '{2}'", TacGia.Ten, TacGia.DienThoai, TacGia.Ma);
                SqlCommand Command = new SqlCommand(Query, Connection);
                int Result = Command.ExecuteNonQuery();
                return (Result == 1);
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static BEL_TacGia GetObjectById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select* from TACGIA where MaTacGia = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                string MaTacGia = (string)DataReader["MaTacGia"];
                string TenTacGia = (string)DataReader["TenTacGia"];
                string DienThoai = (string)DataReader["DienThoai"];
                string TrangThai = (string)DataReader["TrangThai"];
                BEL_TacGia TacGia = new BEL_TacGia(MaTacGia, TenTacGia, DienThoai, TrangThai);
                return TacGia;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static DataTable SearchById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaTacGia, TenTacGia, DienThoai from TACGIA where TrangThai = N'Tồn tại' and MaTacGia = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                DataTable Result = new DataTable();
                SqlDataReader DataReader = Command.ExecuteReader();
                if (DataReader.HasRows)
                {
                    Result.Load(DataReader);
                }
                else
                {
                    Result = null;
                }
                return Result;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static DataTable SearchByName(string Name)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaTacGia, TenTacGia, DienThoai from TACGIA where  TrangThai = N'Tồn tại' and TenTacGia like N'%{0}%'", Name);
                SqlCommand Command = new SqlCommand(Query, Connection);
                DataTable Result = new DataTable();
                SqlDataReader DataReader = Command.ExecuteReader();
                if (DataReader.HasRows)
                {
                    Result.Load(DataReader);
                }
                else
                {
                    Result = null;
                }
                return Result;
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public static int Count()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select count(MaTacGia) from TACGIA");
                SqlCommand Command = new SqlCommand(Query, Connection);
                int Result = (int)Command.ExecuteScalar();
                return (Result);
            }
            catch (Exception Err)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
