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
    public class BAL_NhanVien
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
                return DAL_NhanVien.IsLogin(UserName, Password);  
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
                return DAL_NhanVien.Load();
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
                return DAL_NhanVien.IsExist(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Add(BEL_NhanVien NhanVien)
        {
            if (NhanVien.Ma == "")
            {
                throw new Exception("Mã nhân viên không được rỗng!");
            }
            if (NhanVien.Ten == "")
            {
                throw new Exception("Tên nhân viên không được rỗng!");
            }
            if (NhanVien.GioiTinh == "")
            {
                throw new Exception("Giới tính không được rỗng!");
            }
            if (NhanVien.NgaySinh == null)
            {
                throw new Exception("Ngày sinh không được rỗng!");
            }
            if (NhanVien.DiaChi == "")
            {
                throw new Exception("Địa chỉ không được rỗng!");
            }
            if (NhanVien.DienThoai == "")
            {
                throw new Exception("Điện thoại không được rỗng!");
            }
            if (NhanVien.MatKhau == "")
            {
                throw new Exception("Mật khẩu không được rỗng!");
            }
            if (NhanVien.MaLoai == "")
            {
                throw new Exception("Mã loại không được rỗng!");
            }
            if(NhanVien.HinhAnh == "")
            {
                throw new Exception("Hình ảnh không được rỗng!");
            }
            if (NhanVien.TrangThai == "")
            {
                throw new Exception("Trạng thái không được rỗng!");
            }
            try
            {
                return DAL_NhanVien.Add(NhanVien);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Delete(string Id)
        {
            if(Id == "")
            {
                throw new Exception("Mã người dùng không được rỗng!");
            }
            try
            {
                return DAL_NhanVien.Delete(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Update(BEL_NhanVien NhanVien)
        {

            if (NhanVien.Ma == "")
            {
                throw new Exception("Mã nhân viên không được rỗng!");
            }
            if (NhanVien.Ten == "")
            {
                throw new Exception("Tên nhân viên không được rỗng!");
            }
            if (NhanVien.GioiTinh == "")
            {
                throw new Exception("Giới tính không được rỗng!");
            }
            if (NhanVien.NgaySinh == null)
            {
                throw new Exception("Ngày sinh không được rỗng!");
            }
            if (NhanVien.DiaChi == "")
            {
                throw new Exception("Địa chỉ không được rỗng!");
            }
            if (NhanVien.DienThoai == "")
            {
                throw new Exception("Điện thoại không được rỗng!");
            }
            if (NhanVien.MatKhau == "")
            {
                throw new Exception("Mật khẩu không được rỗng!");
            }
            if (NhanVien.MaLoai == "")
            {
                throw new Exception("Mã loại không được rỗng!");
            }
            if (NhanVien.HinhAnh == "")
            {
                throw new Exception("Hình ảnh không được rỗng!");
            }
            if (NhanVien.TrangThai == "")
            {
                throw new Exception("Trạng thái không được rỗng!");
            }
            try
            {
                return DAL_NhanVien.Update(NhanVien);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static BEL_NhanVien GetObjectById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã người dùng không được trống!");
            }
            try
            {
                return DAL_NhanVien.GetObjectById(Id);
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
                return DAL_NhanVien.GetSpeciesById(Id);
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
                throw new Exception("Mã người dùng không được trống!");
            }
            try
            {
                return DAL_NhanVien.GetNameById(Id);
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
                return DAL_NhanVien.Count();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
    }
}