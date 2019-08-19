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
    public class DAL_LoaiSach : General
    {
        public static DataTable Load()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaLoai, TenLoai from LOAISACH where TrangThai = N'Tồn tại'");
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
                string Query = string.Format("select* from LOAISACH where MaLoai = '{0}'", Id);
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
        public static bool Add(BEL_LoaiSach LoaiSach)
        {
            try
            {
                GetConnection();
                string Query = string.Format("insert into LOAISACH(MaLoai, TenLoai, TrangThai) values('{0}', N'{1}', N'{2}')", LoaiSach.Ma, LoaiSach.Ten, LoaiSach.TrangThai);
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
                string Query = string.Format("update LOAISACH set TrangThai = N'Huỷ' where MaLoai = '{0}'", Id);
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
        public static bool Update(BEL_LoaiSach LoaiSach)
        {
            try
            {
                GetConnection();
                string Query = string.Format("update LOAISACH set TenLoai = N'{0}' where MaLoai = '{1}'", LoaiSach.Ten, LoaiSach.Ma);
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
        public static BEL_LoaiSach GetObjectById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select* from LOAISACH where MaLoai = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                string MaLoai = (string)DataReader["MaLoai"];
                string TenLoai = (string)DataReader["TenLoai"];
                string TrangThai = (string)DataReader["TrangThai"];
                BEL_LoaiSach LoaiSach = new BEL_LoaiSach(MaLoai, TenLoai, TrangThai);
                return LoaiSach;
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
                string Query = string.Format("select MaLoai from LOAISACH where TenLoai = '{0}'", Name);
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
                string Query = string.Format("select TenLoai from LOAISACH where MaLoai = '{0}'", Id);
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
                string Query = string.Format("select MaLoai, TenLoai from LOAISACH where  TrangThai = N'Tồn tại' and MaLoai = '{0}'", Id);
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
                string Query = string.Format("select MaLoai, TenLoai from LOAISACH where TrangThai = N'Tồn tại' and TenLoai like N'%{0}%'", Name);
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
                string Query = string.Format("select count(MaLoai) from LOAISACH");
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
