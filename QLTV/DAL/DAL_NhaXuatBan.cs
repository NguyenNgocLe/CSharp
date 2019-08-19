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
    public class DAL_NhaXuatBan : General
    {
        public static DataTable Load()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaNhaXuatBan, TenNhaXuatBan, Email from NHAXUATBAN where TrangThai = N'Tồn tại'");
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
                string Query = string.Format("select* from NHAXUATBAN where MaNhaXuatBan = '{0}'", Id);
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
        public static bool Add(BEL_NhaXuatBan NhaXuatBan)
        {
            try
            {
                GetConnection();
                string Query = string.Format("insert into NHAXUATBAN(MaNhaXuatBan, TenNhaXuatBan, Email, TrangThai) values('{0}', N'{1}', '{2}', N'{3}')", NhaXuatBan.Ma, NhaXuatBan.Ten, NhaXuatBan.Email, NhaXuatBan.TrangThai);
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
                string Query = string.Format("update NHAXUATBAN set TrangThai = N'Huỷ' where MaNhaXuatBan = '{0}'", Id);
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
        public static bool Update(BEL_NhaXuatBan NhaXuatBan)
        {
            try
            {
                GetConnection();
                string Query = string.Format("update NHAXUATBAN set TenNhaXuatBan = N'{0}', Email = '{1}' where MaNhaXuatBan = '{2}'", NhaXuatBan.Ten, NhaXuatBan.Email, NhaXuatBan.Ma);
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
        public static BEL_NhaXuatBan GetObjectById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select* from NHAXUATBAN where MaNhaXuatBan = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                string MaNhaXuatBan = (string)DataReader["MaNhaXuatBan"];
                string TenNhaXuatBan = (string)DataReader["TenNhaXuatBan"];
                string Email = (string)DataReader["Email"];
                string TrangThai = (string)DataReader["TrangThai"];
                BEL_NhaXuatBan NhaXuatBan = new BEL_NhaXuatBan(MaNhaXuatBan, TenNhaXuatBan, Email, TrangThai);
                return NhaXuatBan;
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
                string Query = string.Format("select MaNhaXuatBan, TenNhaXuatBan, Email from NHAXUATBAN where  TrangThai = N'Tồn tại' and MaNhaXuatBan = '{0}'", Id);
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
                string Query = string.Format("select MaNhaXuatBan, TenNhaXuatBan, Email from NHAXUATBAN where  TrangThai = N'Tồn tại' and TenNhaXuatBan like N'%{0}%'", Name);
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
                string Query = string.Format("select count(MaNhaXuatBan) from NHAXUATBAN");
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
