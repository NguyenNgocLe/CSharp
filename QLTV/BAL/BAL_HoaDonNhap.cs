using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
using System.Data;

namespace BAL
{
    public class BAL_HoaDonNhap
    {
        // dang lam toi day
        public static DataTable Load()
        {
            try
            {
                return DAL_HoaDonNhap.Load();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool IsExist(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã hóa đơn nhập không được để trống!");
            }
            try
            {
                return DAL_HoaDonNhap.IsExist(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Add(BEL_HoaDonNhap HoaDonNhap)
        {
            if (HoaDonNhap.MaHoaDon == "")
            {
                throw new Exception("Mã hóa đơn nhập không được trống!");
            }
            if (HoaDonNhap.MaNhanVien == "")
            {
                throw new Exception("Mã nhân viên không được trống!");
            }
            if (HoaDonNhap.NgayLap == null)
            {
                throw new Exception("Ngày lập không được trống!");
            }
            if (HoaDonNhap.TongTien <= 0)
            {
                throw new Exception("Hóa đơn nhập không hợp lệ!");
            }
            if (HoaDonNhap.TrangThai == "")
            {
                throw new Exception("Trạng thái không được trống!");
            }
            try
            {
                return DAL_HoaDonNhap.Add(HoaDonNhap);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Delete(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã hóa đơn không được trống!");
            }
            try
            {
                return DAL_HoaDonNhap.Delete(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Update(BEL_HoaDonNhap HoaDonNhap)
        {
            if (HoaDonNhap.MaHoaDon == "")
            {
                throw new Exception("Mã hóa đơn không được trống!");
            }
            if (HoaDonNhap.MaNhanVien == "")
            {
                throw new Exception("Mã nhân viên không được trống!");
            }
            if (HoaDonNhap.NgayLap == null)
            {
                throw new Exception("Ngày lập không được trống!");
            }
            if (HoaDonNhap.TongTien == null)
            {
                throw new Exception("Hóa đơn nhập không hợp lệ!");
            }
            if (HoaDonNhap.TrangThai == "")
            {
                throw new Exception("Trạng thái không được trống!");
            }
            try
            {
                return DAL_HoaDonNhap.Update(HoaDonNhap);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static BEL_HoaDonNhap GetObjectById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã hóa đơn không được trống!");
            }
            try
            {
                return DAL_HoaDonNhap.GetObjectById(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static int Count()
        {
            try
            {
                return DAL_HoaDonNhap.Count();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
    }
}
