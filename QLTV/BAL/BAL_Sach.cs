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
    public class BAL_Sach
    {
        public static DataTable Load()
        {
            try
            {
                return DAL_Sach.Load();
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
                throw new Exception("Mã sách không được trống!");
            }
            try
            {
                return DAL_Sach.IsExist(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Add(BEL_Sach Sach)
        {
            if (Sach.MaSach == "")
            {
                throw new Exception("Mã sách không được trống!");
            }
            if (Sach.TenSach == "")
            {
                throw new Exception("Tên sách không được trống!");
            }
            if (Sach.MaLoai == "")
            {
                throw new Exception("Mã loại không được trống!");
            }
            if (Sach.MaTacGia == null)
            {
                throw new Exception("Mã tác giả không được trống!");
            }
            if (Sach.MaNgonNgu == "")
            {
                throw new Exception("Mã ngôn ngữ không được trống!");
            }
            if (Sach.MaNhaXuatBan == "")
            {
                throw new Exception("Mã nhà xuất bản không được trống!");
            }
            if (Sach.NamXuatBan == "")
            {
                throw new Exception("Năm xuất bản không được trống!");
            }
            if (Sach.SoLuong == null)
            {
                throw new Exception("Số lượng không được trống!");
            }
            if (Sach.GiaNhap == null)
            {
                throw new Exception("Giá nhập không được trống!");
            }
            if (Sach.MoTa == "")
            {
                throw new Exception("Mô tả không được trống!");
            }
            if (Sach.HinhAnh == "")
            {
                throw new Exception("Hình ảnh không được trống!");
            }
            if (Sach.TrangThai == "")
            {
                throw new Exception("Trạng thái không được trống!");
            }
            try
            {
                return DAL_Sach.Add(Sach);
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
                throw new Exception("Mã sách không được trống!");
            }
            try
            {
                return DAL_Sach.Delete(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Update(BEL_Sach Sach)
        {
            if (Sach.MaSach == "")
            {
                throw new Exception("Mã sách không được trống!");
            }
            if (Sach.TenSach == "")
            {
                throw new Exception("Tên sách không được trống!");
            }
            if (Sach.MaLoai == "")
            {
                throw new Exception("Mã loại không được trống!");
            }
            if (Sach.MaTacGia == null)
            {
                throw new Exception("Mã tác giả không được trống!");
            }
            if (Sach.MaNgonNgu == "")
            {
                throw new Exception("Mã ngôn ngữ không được trống!");
            }
            if (Sach.MaNhaXuatBan == "")
            {
                throw new Exception("Mã nhà xuất bản không được trống!");
            }
            if (Sach.NamXuatBan == "")
            {
                throw new Exception("Năm xuất bản không được trống!");
            }
            if (Sach.SoLuong == null)
            {
                throw new Exception("Số lượng không được trống!");
            }
            if (Sach.GiaNhap == null)
            {
                throw new Exception("Giá nhập không được trống!");
            }
            if (Sach.MoTa == "")
            {
                throw new Exception("Mô tả không được trống!");
            }
            if (Sach.HinhAnh == "")
            {
                throw new Exception("Hình ảnh không được trống!");
            }
            if (Sach.TrangThai == "")
            {
                throw new Exception("Trạng thái không được trống!");
            }
            try
            {
                return DAL_Sach.Update(Sach);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static BEL_Sach GetObjectById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã sách không được trống!");
            }
            try
            {
                return DAL_Sach.GetObjectById(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static string GetSpeciesById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã sách không được trống!");
            }
            try
            {
                return DAL_Sach.GetSpeciesById(Id);
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
                return DAL_Sach.Count();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
    }
}
