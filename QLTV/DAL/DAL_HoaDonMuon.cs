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
    public class DAL_HoaDonMuon : General
    {
        public static DataTable Load()
        {
            try
            {
                GetConnection();
                string Query = string.Format("select MaHoaDon, NhanVien.TenNhanVien, DOCGIA.TenDocGia, NgayLap, NgayTra, DaTra from HOADONMUON, NHANVIEN, DOCGIA where HOADONMUON.MaNhanVien = NHANVIEN.MaNhanVien and HOADONMUON.MaDocGia = DOCGIA.MaDocGia and TrangThai = N'Tồn tại'");
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
                string Query = string.Format("select* from HOADONMUON where MaHoaDon = '{0}'", Id);
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
        public static bool Add(BEL_HoaDonMuon HoaDonMuon)
        {
            try
            {
                GetConnection();
                string Query = string.Format("insert into HOADONMUON(MaHoaDon, MaNhanVien, MaDocGia, NgayLap, NgayTra, DaTra, TrangThai) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', N'{7}')", HoaDonMuon.MaHoaDon, HoaDonMuon.MaNhanVien, HoaDonMuon.MaDocGia, HoaDonMuon.NgayLap.ToString("MM-dd-yyyy"), HoaDonMuon.NgayTra.ToString("MM-dd-yyyy"), false, HoaDonMuon.TrangThai);
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
                string Query = string.Format("update HOADONMUON set TrangThai = N'Huỷ' where MaHoaDon = '{0}'", Id);
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
        public static bool Update(BEL_HoaDonMuon HoaDonMuon)
        {
            try
            {
                GetConnection();
                string Query = string.Format("update HOADONMUON set MaNhanVien = '{0}', MaDocGia = '{1}', NgayLap = '{2}', NgayTra = '{3}', DaTra = {4}, where MaLoai = '{5}'", HoaDonMuon.MaNhanVien, HoaDonMuon.MaHoaDon, HoaDonMuon.MaDocGia, HoaDonMuon.NgayLap.ToString("MM-dd-yyyy"), HoaDonMuon.NgayTra.ToString("MM-dd-yyyy"), HoaDonMuon.DaTra, HoaDonMuon.MaHoaDon);
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
        public static BEL_HoaDonMuon GetObjectById(string Id)
        {
            try
            {
                GetConnection();
                string Query = string.Format("select* from HOADONMUON where MaHoaDon = '{0}'", Id);
                SqlCommand Command = new SqlCommand(Query, Connection);
                SqlDataReader DataReader = Command.ExecuteReader();
                DataReader.Read();
                string MaHoaDon = (string)DataReader["MaHoaDon"];
                string MaNhanVien = (string)DataReader["MaNhanVien"];
                string MaDocGia = (string)DataReader["MaDocGia"];
                DateTime NgayLap = (DateTime)DataReader["NgayLap"];
                DateTime NgayTra = (DateTime)DataReader["NgayTra"];
                bool DaTra = (bool)DataReader["DaTra"];
                string TrangThai = (string)DataReader["TrangThai"];
                BEL_HoaDonMuon HoaDonMuon = new BEL_HoaDonMuon(MaHoaDon, MaNhanVien, MaDocGia, NgayLap, NgayTra, DaTra, TrangThai);
                return HoaDonMuon;
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
                string Query = string.Format("select count(MaHoaDon) from HOADONMUON");
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
