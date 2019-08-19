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
    public class DAL_HoaDonNhap : General
    {
        public static DataTable Load()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaHoaDon, NHANVIEN.TenNhanVien, TongTien from HOADONNHAP, NHANVIEN where HOADONNHAP.MaNhanVien = NHANVIEN.MaNhanVien and TrangThai = N'Tồn tại'");
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
                string Query = string.Format("select* from HOADON where MaHoaDon = '{0}'", Id);
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
        public static bool Add(BEL_HoaDonNhap HoaDonNhap)
        {
            try
            {
                GetConnection();
                string Query = string.Format("insert into HOADONNHAP(MaHoaDon, MaNhanVien, NgayLap, TongTien, TrangThai) values('{0}', '{1}', '{2}', '{3}', N'{4}')", HoaDonNhap.MaHoaDon, HoaDonNhap.MaNhanVien, HoaDonNhap.NgayLap.ToString("MM-dd-yyyy"), HoaDonNhap.TrangThai);
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
                string Query = string.Format("update HOADONNHAP set TrangThai = N'Huỷ' where MaHoaDon = '{0}'", Id);
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
        public static bool Update(BEL_HoaDonNhap HoaDonNhap)
        {
            try
            {
                GetConnection();
                string Query = string.Format("update HOADONNHAP set MaNhanVien = '{0}', NgayLap = '{1}', TongTien = '{3}' where MaLoai = '{1}'", HoaDonNhap.MaNhanVien, HoaDonNhap.NgayLap, HoaDonNhap.TongTien);
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
        public static BEL_HoaDonNhap GetObjectById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select* from HOADONNHAP where MaHoaDon = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                string MaHoaDon = (string)DataReader["MaHoaDon"];
                string MaNhanVien = (string)DataReader["MaNhanVien"];
                DateTime NgayLap = (DateTime)DataReader["NgayLap"];
                int TongTien = (int)DataReader["TongTien"];
                string TrangThai = (string)DataReader["TrangThai"];
                BEL_HoaDonNhap HoaDonNhap = new BEL_HoaDonNhap(MaHoaDon, MaNhanVien, NgayLap, TongTien, TrangThai);
                return HoaDonNhap;
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
                string Query = string.Format("select count(MaHoaDon) from HOADONNHAP");
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
