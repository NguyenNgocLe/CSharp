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
    public class BAL_NhaXuatBan
    {
        public static DataTable Load()
        {
            try
            {
                return DAL_NhaXuatBan.Load();
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
                throw new Exception("Mã nhà xuất bản không được trống!");
            }
            try
            {
                return DAL_NhaXuatBan.IsExist(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Add(BEL_NhaXuatBan NhaXuatBan)
        {
            if (NhaXuatBan.Ma == "")
            {
                throw new Exception("Mã nhà xuất bản không được rỗng!");
            }
            if (NhaXuatBan.Ten == "")
            {
                throw new Exception("Tên nhà xuất bản không được rỗng!");
            }
            if (NhaXuatBan.Email == "")
            {
                throw new Exception("Email không được rỗng!");
            }
            if (NhaXuatBan.TrangThai == "")
            {
                throw new Exception("Trạng thái không được rỗng!");
            }
            try
            {
                return DAL_NhaXuatBan.Add(NhaXuatBan);
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
                throw new Exception("Mã nhà xuất bản không được trống!");
            }
            try
            {
                return DAL_NhaXuatBan.Delete(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Update(BEL_NhaXuatBan NhaXuatBan)
        {
            if (NhaXuatBan.Ma == "")
            {
                throw new Exception("Mã nhà xuất bản không được rỗng!");
            }
            if (NhaXuatBan.Ten == "")
            {
                throw new Exception("Tên nhà xuất bản không được rỗng!");
            }
            if (NhaXuatBan.Email == "")
            {
                throw new Exception("Email không được rỗng!");
            }
            if (NhaXuatBan.TrangThai == "")
            {
                throw new Exception("Trạng thái không được rỗng!");
            }
            try
            {
                return DAL_NhaXuatBan.Update(NhaXuatBan);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static BEL_NhaXuatBan GetObjectById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã nhà xuất bản không được rỗng!");
            }
            try
            {
                return DAL_NhaXuatBan.GetObjectById(Id);
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
                throw new Exception("Mã nhà xuất bản không được trống!");
            }
            try
            {
                return DAL_NhaXuatBan.SearchById(Id);
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
                throw new Exception("Tên nhà xuất bản không được trống!");
            }
            try
            {
                return DAL_NhaXuatBan.SearchByName(Name);
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
                return DAL_NhaXuatBan.Count();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
    }
}
