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
    public class BAL_LoaiDocGia
    {
        public static DataTable Load()
        {
            try
            {
                return DAL_LoaiDocGia.Load();
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
                throw new Exception("ID không được rỗng!");
            }
            try
            {
                return DAL_LoaiDocGia.IsExist(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Add(BEL_LoaiDocGia LoaiDocGia)
        {
            if (LoaiDocGia.Ma == "")
            {
                throw new Exception("Mã loại không được rỗng!");
            }
            if (LoaiDocGia.Ten == "")
            {
                throw new Exception("Tên loại không được rỗng!");
            }
            if (LoaiDocGia.TrangThai == "")
            {
                throw new Exception("Trạng thái không được rỗng!");
            }
            try
            {
                return BAL_LoaiDocGia.Add(LoaiDocGia);
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
                throw new Exception("ID không được rỗng!");
            }
            try
            {
                return DAL_LoaiDocGia.Delete(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Update(BEL_LoaiDocGia LoaiDocGia)
        {

            if (LoaiDocGia.Ma == "")
            {
                throw new Exception("Mã loại không được rỗng!");
            }
            if (LoaiDocGia.Ten == "")
            {
                throw new Exception("Tên loại không được rỗng!");
            }
            if (LoaiDocGia.TrangThai == "")
            {
                throw new Exception("Trạng thái không được rỗng!");
            }
            try
            {
                return DAL_LoaiDocGia.Update(LoaiDocGia);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static BEL_LoaiDocGia GetObjectById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã loại không được rỗng!");
            }
            try
            {
                return DAL_LoaiDocGia.GetObjectById(Id);
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
                return DAL_LoaiDocGia.GetIdByName(Name);
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
                return DAL_LoaiDocGia.GetNameById(Id);
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
                return DAL_LoaiDocGia.Count();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
    }
}
