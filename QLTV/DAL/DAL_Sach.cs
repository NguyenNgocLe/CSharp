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
    public class DAL_Sach : General
    {
        public static DataTable Load()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaSach, TenSach, LOAISACH.TenLoai, TACGIA.TenTacGia, NGONNGU.TenNgonNgu, NHAXUATBAN.TenNhaXuatBan, MaNhaXuatBan, NamXuatBan, SoLuong, GiaNhap, MoTa, HinhAnh from SACH, LOAISACH, TACGIA, NGONNGU, NHAXUATBAN where SACH.MaLoai = LOAISACH.MaLoai and SACH.MaTacGia = TACGIA.MaTacGia and SACH.MaNgonNgu = NGONNGU.MaNgonNgu and SACH.MaNhaXuatBan = NHAXUATBAN.MaNhaXuatBan and TrangThai = N'Tồn tại'");
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
                string Query = string.Format("select* from SACH where MaSach = '{0}'", Id);
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
        public static bool Add(BEL_Sach Sach)
        {
            try
            {
                GetConnection();
                string Query = string.Format("insert into SACH(MaSach, TenSach, MaLoai, MaTacGia, MaNgonNgu, MaNhaXuatBan, NamXuatBan, SoLuong, GiaNhap, MoTa, HinhAnh, TrangThai) values('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', N'{9}', N'{10}', N'{11}')", Sach.MaSach, Sach.TenSach, Sach.MaLoai, Sach.MaTacGia, Sach.MaNgonNgu, Sach.MaNhaXuatBan, Sach.NamXuatBan, Sach.SoLuong, Sach.GiaNhap, Sach.MoTa, Sach.HinhAnh, Sach.TrangThai);
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
                string Query = string.Format("update SACH set TrangThai = N'Huỷ' where MaSach = '{0}'", Id);
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
        public static bool Update(BEL_Sach Sach)
        {
            try
            {
                GetConnection();
                string Query = string.Format("update SACH set TenSach = N'{0}', MaLoai = '{1}', MaTacGia = '{2}', MaNgonNgu = N'{3}', MaNhaXuatBan = '{4}', NamXuatBan = '{5}', SoLuong = '{6}', GiaNhap = '{7}', MoTa = N'{8}', HinhAnh = N'{9}' where MaSach = '{10}'", Sach.TenSach, Sach.MaLoai, Sach.MaTacGia, Sach.MaNgonNgu, Sach.MaNhaXuatBan, Sach.NamXuatBan, Sach.SoLuong, Sach.GiaNhap, Sach.MoTa, Sach.HinhAnh);
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
        public static BEL_Sach GetObjectById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select* from SACH where MaSach = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                string MaSach = (string)DataReader["MaSach"];
                string TenSach = (string)DataReader["TenSach"];
                string MaLoai = (string)DataReader["MaLoai"];
                string MaTacGia = (string)DataReader["MaTacGia"];
                string MaNgonNgu = (string)DataReader["MaNgonNgu"];
                string MaNhaXuatBan = (string)DataReader["MaNhaXuatBan"];
                string NamXuatBan = (string)DataReader["NamXuatBan"];
                int SoLuong = (int)DataReader["SoLuong"];
                int GiaNhap = (int)DataReader["GiaNhap"];
                string MoTa = (string)DataReader["MoTa"];
                string HinhAnh = (string)DataReader["HinhAnh"];
                string TrangThai = (string)DataReader["TrangThai"];
                BEL_Sach Sach = new BEL_Sach(MaSach, TenSach, MaLoai, MaTacGia, MaNgonNgu, MaNhaXuatBan, NamXuatBan, SoLuong, GiaNhap, MoTa, HinhAnh, TrangThai);
                return Sach;
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
                string Query = string.Format("select MaLoai from SACH where MaSach = '{0}' ", Id);
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
        public static int Count()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select count(MaSach) from SACH");
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
