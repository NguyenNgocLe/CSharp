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
    public class BAL_LoaiNhanVien
    {
        public static DataTable Load()
        {
            try
            {
                return DAL_LoaiNhanVien.Load();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool IsExist(string Id)
        {
            if(Id == "")
            {
                throw new Exception("ID không được rỗng!");
            }
            try
            {
                return DAL_LoaiNhanVien.IsExist(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Add(BEL_LoaiNhanVien LoaiNhanVien)
        {
            if (LoaiNhanVien.Ma == "")
            {
                throw new Exception("Mã loại không được rỗng!");
            }
            if (LoaiNhanVien.Ten == "")
            {
                throw new Exception("Tên loại không được rỗng!");
            }
            if (LoaiNhanVien.TrangThai == "")
            {
                throw new Exception("Trạng thái không được rỗng!");
            }
            try
            {
                return BAL_LoaiNhanVien.Add(LoaiNhanVien);
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
                throw new Exception("ID không được rỗng!");
            }
            try
            {
                return DAL_LoaiNhanVien.Delete(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Update(BEL_LoaiNhanVien LoaiNhanVien)
        {

            if (LoaiNhanVien.Ma == "")
            {
                throw new Exception("Mã loại không được rỗng!");
            }
            if (LoaiNhanVien.Ten == "")
            {
                throw new Exception("Tên loại không được rỗng!");
            }
            if (LoaiNhanVien.TrangThai == "")
            {
                throw new Exception("Trạng thái không được rỗng!");
            }
            try
            {
                return DAL_LoaiNhanVien.Update(LoaiNhanVien);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static BEL_LoaiNhanVien GetObjectById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã loại không được rỗng!");
            }
            try
            {
                return DAL_LoaiNhanVien.GetObjectById(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static string GetIdByName(string Name)
        {
            if (Name == "")
            {
                throw new Exception("Tên loại không được trống!");
            }
            try
            {
                return DAL_LoaiNhanVien.GetIdByName(Name);
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
                throw new Exception("Mã loại không được rỗng!");
            }
            try
            {
                return DAL_LoaiNhanVien.GetNameById(Id);
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
                return DAL_LoaiNhanVien.Count();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
    }
}
