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
    public class DAL_LoaiNhanVien : General
    {
        public static DataTable Load()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaLoai, TenLoai from LOAINHANVIEN where TrangThai = N'Tồn tại'");
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
                string Query = string.Format("select* from LOAINHANVIEN where MaLoai = '{0}'", Id);
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
        public static bool Add(BEL_LoaiNhanVien LoaiNhanVien)
        {
            try
            {
                GetConnection();
                string Query = string.Format("insert into LOAINHANVIEN(MaLoai, TenLoai, TrangThai) values('{0}', N'{1}', N'{2}')", LoaiNhanVien.Ma, LoaiNhanVien.Ten, LoaiNhanVien.TrangThai);
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
                string Query = string.Format("update LOAINHANVIEN set TrangThai = N'Huỷ' where MaLoai = '{0}'", Id);
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
        public static bool Update(BEL_LoaiNhanVien LoaiNhanVien)
        {
            try
            {
                GetConnection();
                string Query = string.Format("update LOAINHANVIEN set TenLoai = N'{0}' where MaLoai = '{1}'", LoaiNhanVien.Ten, LoaiNhanVien.Ma);
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
        public static BEL_LoaiNhanVien GetObjectById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select* from LOAINHANVIEN where MaLoai = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                string MaLoai = (string)DataReader["MaLoai"];
                string TenLoai = (string)DataReader["TenLoai"];
                string TrangThai = (string)DataReader["TrangThai"];
                BEL_LoaiNhanVien LoaiNhanVien = new BEL_LoaiNhanVien(MaLoai, TenLoai, TrangThai);
                return LoaiNhanVien;
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
                string Query = string.Format("select MaLoai from LOAINHANVIEN where TenLoai = '{0}'", Name);
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
                string Query = string.Format("select TenLoai from LOAINHANVIEN where MaLoai = '{0}'", Id);
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
        public static int Count()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select count(MaLoai) from LOAINHANVIEN");
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
