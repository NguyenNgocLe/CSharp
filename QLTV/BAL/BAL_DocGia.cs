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
    public class BAL_DocGia
    {
        public static bool IsLogin(string UserName, string Password)
        {
            if (UserName == "")
            {
                throw new Exception("Mã người dùng không được trống!");
            }
            if (Password == "")
            {
                throw new Exception("Mật khẩu không được trống!");
            }
            try
            {
                return DAL_DocGia.IsLogin(UserName, Password);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static DataTable Load()
        {
            try
            {
                return DAL_DocGia.Load();
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
                throw new Exception("Mã người dùng không được trống!");
            }
            try
            {
                return DAL_DocGia.IsExist(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Add(BEL_DocGia DocGia)
        {
            if (DocGia.Ma == "")
            {
                throw new Exception("Mã độc giả không được rỗng!");
            }
            if (DocGia.Ten == "")
            {
                throw new Exception("Tên độc giả không được rỗng!");
            }
            if (DocGia.GioiTinh == "")
            {
                throw new Exception("Giới tính không được rỗng!");
            }
            if (DocGia.NgaySinh == null)
            {
                throw new Exception("Ngày sinh không được rỗng!");
            }
            if (DocGia.DiaChi == "")
            {
                throw new Exception("Địa chỉ không được rỗng!");
            }
            if (DocGia.DienThoai == "")
            {
                throw new Exception("Điện thoại không được rỗng!");
            }
            if (DocGia.MatKhau == "")
            {
                throw new Exception("Mật khẩu không được rỗng!");
            }
            if (DocGia.MaLoai == "")
            {
                throw new Exception("Mã loại không được rỗng!");
            }
            if (DocGia.HinhAnh == "")
            {
                throw new Exception("Hình ảnh không được rỗng!");
            }
            if (DocGia.TrangThai == "")
            {
                throw new Exception("Trạng thái không được rỗng!");
            }
            try
            {
                return DAL_DocGia.Add(DocGia);
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
                throw new Exception("Mã người dùng không được rỗng!");
            }
            try
            {
                return DAL_DocGia.Delete(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Update(BEL_DocGia DocGia)
        {

            if (DocGia.Ma == "")
            {
                throw new Exception("Mã độc giả không được rỗng!");
            }
            if (DocGia.Ten == "")
            {
                throw new Exception("Tên độc giả không được rỗng!");
            }
            if (DocGia.GioiTinh == "")
            {
                throw new Exception("Giới tính không được rỗng!");
            }
            if (DocGia.NgaySinh == null)
            {
                throw new Exception("Ngày sinh không được rỗng!");
            }
            if (DocGia.DiaChi == "")
            {
                throw new Exception("Địa chỉ không được rỗng!");
            }
            if (DocGia.DienThoai == "")
            {
                throw new Exception("Điện thoại không được rỗng!");
            }
            if (DocGia.MatKhau == "")
            {
                throw new Exception("Mật khẩu không được rỗng!");
            }
            if (DocGia.MaLoai == "")
            {
                throw new Exception("Mã loại không được rỗng!");
            }
            if (DocGia.HinhAnh == "")
            {
                throw new Exception("Hình ảnh không được rỗng!");
            }
            if (DocGia.TrangThai == "")
            {
                throw new Exception("Trạng thái không được rỗng!");
            }
            try
            {
                return DAL_DocGia.Update(DocGia);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static BEL_DocGia GetObjectById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã người dùng không được trống!");
            }
            try
            {
                return DAL_DocGia.GetObjectById(Id);
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
                throw new Exception("Mã người dùng không được trống!");
            }
            try
            {
                return DAL_DocGia.GetSpeciesById(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static string GetNameById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã độc giả không được trống!");
            }
            try
            {
                return DAL_DocGia.GetNameById(Id);
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
                return DAL_DocGia.Count();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
    }
}