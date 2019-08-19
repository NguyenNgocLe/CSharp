using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class DAL_DocGia : General
    {
        private static string MD5Encode(string input)
        {
            try
            {
                MD5 MD5 = MD5.Create();
                byte[] Data = MD5.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder Result = new StringBuilder();
                for (int i = 0; i < Data.Length; i++)
                {
                    Result.Append(Data[i].ToString("x2"));
                }
                return Result.ToString();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool IsLogin(string UserName, string Password)
        {
            try
            {
                GetConnection();
                Password = MD5Encode(Password);
                string Query = string.Format("select* from DOCGIA where MaDocGia = '{0}' and MatKhau = '{1}'", UserName, Password);
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
        public static DataTable Load()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaDocGia, TenDocGia, GioiTinh, NgaySinh, DiaChi, DienThoai, LOAIDOCGIA.TenLoai, HinhAnh from DOCGIA, LOAIDOCGIA where DOCGIA.MaLoai = LOAIDOCGIA.MaLoai and DOCGIA.TrangThai = N'Tồn tại'");
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
                string Query = string.Format("select* from DOCGIA where MaDocGia = '{0}'", Id);
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
        public static bool Add(BEL_DocGia DocGia)
        {
            try
            {
                GetConnection();
                DocGia.MatKhau = MD5Encode(DocGia.MatKhau);
                string Query = string.Format("insert into DOCGIA(MaDocGia, TenDocGia, GioiTinh, NgaySinh, DiaChi, DienThoai, MatKhau, MaLoai, HinhAnh, TrangThai) values('{0}', N'{1}', N'{2}', '{3}', N'{4}', '{5}', '{6}', '{7}', N'{8}', N'{9}')", DocGia.Ma, DocGia.Ten, DocGia.GioiTinh, DocGia.NgaySinh.ToString("MM-dd-yyyy"), DocGia.DiaChi, DocGia.DienThoai, DocGia.MatKhau, DocGia.MaLoai, DocGia.HinhAnh, DocGia.TrangThai);
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
                string Query = string.Format("update DOCGIA set TrangThai = N'Huỷ' where MaLoai = '{0}'", Id);
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
        public static bool Update(BEL_DocGia DocGia)
        {
            try
            {
                GetConnection();
                string Query = string.Format("update DOCGIA set TenDocGia = N'{0}', GioiTinh = N'{1}', NgaySinh = '{2}', DiaChi = N'{3}', DienThoai = '{4}', MaLoai = '{5}', HinhAnh = N'{6}' where MaDocGia  = '{7}'", DocGia.Ten, DocGia.GioiTinh, DocGia.NgaySinh.ToString("MM-dd-yyyy"), DocGia.DiaChi, DocGia.DienThoai, DocGia.MaLoai, DocGia.HinhAnh, DocGia.Ma);
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
        public static BEL_DocGia GetObjectById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select* from DOCGIA where MaDocGia = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                string MaDocGia = (string)DataReader["MaDocGia"];
                string TenDocGia = (string)DataReader["TenDocGia"];
                string GioiTinh = (string)DataReader["GioiTinh"];
                DateTime NgaySinh = (DateTime)DataReader["NgaySinh"];
                string DiaChi = (string)DataReader["DiaChi"];
                string DienThoai = (string)DataReader["DienThoai"];
                string MaLoai = (string)DataReader["MaLoai"];
                string HinhAnh = (string)DataReader["HinhAnh"];
                string TrangThai = (string)DataReader["TrangThai"];
                BEL_DocGia DocGia = new BEL_DocGia(MaDocGia, TenDocGia, GioiTinh, NgaySinh, DiaChi, DienThoai, MaLoai, HinhAnh, TrangThai);
                return DocGia;
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
        public static string GetSpeciesById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaLoai from DOCGIA where MaDocGia = '{0}' ", Id);
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
                string Query = string.Format("select TenDocGia from DOCGIA where MaDocGia = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                string Result = (string)DataReader["TenDocGia"];
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
                string Query = string.Format("select count(MaDocGia) from DOCGIA");
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
