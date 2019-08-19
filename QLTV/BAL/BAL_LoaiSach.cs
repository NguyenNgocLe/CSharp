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
    public class BAL_LoaiSach
    {
        public static DataTable Load()
        {
            try
            {
                return DAL_LoaiSach.Load();
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
                throw new Exception("Mã loại sách không được để trống!");
            }
            try
            {
                return DAL_LoaiSach.IsExist(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Add(BEL_LoaiSach LoaiSach)
        {
            if (LoaiSach.Ma == "")
            {
                throw new Exception("Mã loại sách không được trống!");
            }
            if (LoaiSach.Ten == "")
            {
                throw new Exception("Tên loại sách không được trống!");
            }
            if (LoaiSach.TrangThai == "")
            {
                throw new Exception("Trạng thái không được trống!");
            }
            try
            {
                return DAL_LoaiSach.Add(LoaiSach);
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
                throw new Exception("Mã loại sách không được trống!");
            }
            try
            {
                return DAL_LoaiSach.Delete(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Update(BEL_LoaiSach LoaiSach)
        {
            if (LoaiSach.Ma == "")
            {
                throw new Exception("Mã loại sách không được trống!");
            }
            if (LoaiSach.Ten == "")
            {
                throw new Exception("Tên loại sách không được trống!");
            }
            if (LoaiSach.TrangThai == "")
            {
                throw new Exception("Trạng thái không được trống!");
            }
            try
            {
                return DAL_LoaiSach.Update(LoaiSach);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static BEL_LoaiSach GetObjectById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã loại sách không được trống!");
            }
            try
            {
                return DAL_LoaiSach.GetObjectById(Id);
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
                throw new Exception("Tên loại sách không được trống!");
            }
            try
            {
                return DAL_LoaiSach.GetIdByName(Name);
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
                throw new Exception("Mã loại sách không được trống!");
            }
            try
            {
                return DAL_LoaiSach.GetNameById(Id);
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
                throw new Exception("Mã loại sách không được trống!");
            }
            try
            {
                return DAL_LoaiSach.SearchById(Id);
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
                throw new Exception("Tên loại sách không được trống!");
            }
            try
            {
                return DAL_LoaiSach.SearchByName(Name);
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
                return DAL_LoaiSach.Count();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
    }
}
