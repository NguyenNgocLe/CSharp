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
    public class DAL_NgonNgu : General
    {
        public static DataTable Load()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaNgonNgu, TenNgonNgu from NGONNGU where TrangThai = N'Tồn tại'");
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
                string Query = string.Format("select MaLoai, TenLoai from NGONNGU where MaLoai = '{0}'", Id);
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
        public static bool Add(BEL_NgonNgu NgonNgu)
        {
            try
            {
                GetConnection();
                string Query = string.Format("insert into NGONNGU(MaNgonNgu, TenNgonNgu, TrangThai) values('{0}', N'{1}', N'{2}')", NgonNgu.Ma, NgonNgu.Ten, NgonNgu.TrangThai);
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
                string Query = string.Format("update NGONNGU set TrangThai = N'Huỷ' where MaNgonNgu = '{0}'", Id);
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
        public static bool Update(BEL_NgonNgu NgonNgu)
        {
            try
            {
                GetConnection();
                string Query = string.Format("update NGONNGU set TenNgonNgu = N'{0}' where MaNgonNgu = '{1}'", NgonNgu.Ten, NgonNgu.Ma);
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
        public static BEL_NgonNgu GetObjectById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select* from NGONNGU where MaNgonNgu = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                string MaNgonNgu = (string)DataReader["MaNgonNgu"];
                string TenNgonNgu = (string)DataReader["TenNgonNgu"];
                string TrangThai = (string)DataReader["TrangThai"];
                BEL_NgonNgu NgonNgu = new BEL_NgonNgu(MaNgonNgu, TenNgonNgu, TrangThai);
                return NgonNgu;
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
        public static string GetIdByName(string Name)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaLoai from NGONNGU where TenLoai = N'{0}'", Name);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                string Result = (string)DataReader["MaLoai"];
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
        public static string GetNameById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select TenLoai from NGONNGU where MaLoai = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                string Result = (string)DataReader["TenLoai"];
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
        public static DataTable SearchById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaNgonNgu, TenNgonNgu from NGONNGU where  TrangThai = N'Tồn tại' and MaNgonNgu = '{0}'", Id);
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
                string Query = string.Format("select MaNgonNgu, TenNgonNgu from NGONNGU where  TrangThai = N'Tồn tại' and TenNgonNgu like N'%{0}%'", Name);
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
                string Query = string.Format("select count(MaNgonNgu) from NGONNGU");
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
