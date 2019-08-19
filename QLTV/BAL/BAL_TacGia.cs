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
    public class BAL_TacGia
    {
        public static DataTable Load()
        {
            try
            {
                return DAL_TacGia.Load();
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
                return DAL_TacGia.IsExist(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Add(BEL_TacGia TacGia)
        {
            if (TacGia.Ma == "")
            {
                throw new Exception("Mã tác giả không được rỗng!");
            }
            if (TacGia.Ten == "")
            {
                throw new Exception("Tên tác giả không được rỗng!");
            }
            if (TacGia.DienThoai == "")
            {
                throw new Exception("Điện thoại không được rỗng!");
            }
            if (TacGia.TrangThai == "")
            {
                throw new Exception("Trạng thái không được rỗng!");
            }
            try
            {
                return DAL_TacGia.Add(TacGia);
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
                throw new Exception("Mã tác giả không được rỗng!");
            }
            try
            {
                return DAL_TacGia.Delete(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Update(BEL_TacGia TacGia)
        {
            if (TacGia.Ma == "")
            {
                throw new Exception("Mã tác giả không được rỗng!");
            }
            if (TacGia.Ten == "")
            {
                throw new Exception("Tên tác giả không được rỗng!");
            }
            if (TacGia.DienThoai == "")
            {
                throw new Exception("Điện thoại không được rỗng!");
            }
            if (TacGia.TrangThai == "")
            {
                throw new Exception("Trạng thái không được rỗng!");
            }
            try
            {
                return DAL_TacGia.Update(TacGia);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static BEL_TacGia GetObjectById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã tác giả không được trống!");
            }
            try
            {
                return DAL_TacGia.GetObjectById(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static DataTable SearchById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã tác giả không được trống!");
            }
            try
            {
                return DAL_TacGia.SearchById(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static DataTable SearchByName(string Name)
        {
            if (Name == "")
            {
                throw new Exception("Tên tác giả không được trống!");
            }
            try
            {
                return DAL_TacGia.SearchByName(Name);
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
                return DAL_TacGia.Count();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
    }
}
