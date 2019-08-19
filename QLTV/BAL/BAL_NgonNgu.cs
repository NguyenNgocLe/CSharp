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
    public class BAL_NgonNgu
    {
        public static DataTable Load()
        {
            try
            {
                return DAL_NgonNgu.Load();
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
                throw new Exception("Mã ngôn ngữ không được để trống!");
            }
            try
            {
                return DAL_NgonNgu.IsExist(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Add(BEL_NgonNgu NgonNgu)
        {
            if (NgonNgu.Ma == "")
            {
                throw new Exception("Mã ngôn ngữ không được trống!");
            }
            if (NgonNgu.Ten == "")
            {
                throw new Exception("Tên ngôn ngữ không được trống!");
            }
            if (NgonNgu.TrangThai == "")
            {
                throw new Exception("Trạng thái không được trống!");
            }
            try
            {
                return DAL_NgonNgu.Add(NgonNgu);
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
                throw new Exception("Mã ngôn ngữ không được trống!");
            }
            try
            {
                return DAL_NgonNgu.Delete(Id);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static bool Update(BEL_NgonNgu NgonNgu)
        {
            if (NgonNgu.Ma == "")
            {
                throw new Exception("Mã ngôn ngữ không được trống!");
            }
            if (NgonNgu.Ten == "")
            {
                throw new Exception("Tên ngôn ngữ không được trống!");
            }
            if (NgonNgu.TrangThai == "")
            {
                throw new Exception("Trạng thái không được trống!");
            }
            try
            {
                return DAL_NgonNgu.Update(NgonNgu);
            }
            catch (Exception Err)
            {
                throw;
            }
        }
        public static BEL_NgonNgu GetObjectById(string Id)
        {
            if (Id == "")
            {
                throw new Exception("Mã ngôn ngữ không được trống!");
            }
            try
            {
                return DAL_NgonNgu.GetObjectById(Id);
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
                throw new Exception("Tên ngôn ngữ không được trống!");
            }
            try
            {
                return DAL_NgonNgu.GetIdByName(Name);
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
                throw new Exception("Mã ngôn ngữ không được trống!");
            }
            try
            {
                return DAL_NgonNgu.GetNameById(Id);
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
                throw new Exception("Mã ngôn ngữ không được trống!");
            }
            try
            {
                return DAL_NgonNgu.SearchById(Id);
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
                throw new Exception("Tên ngôn ngữ không được trống!");
            }
            try
            {
                return DAL_NgonNgu.SearchByName(Name);
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
                return DAL_NgonNgu.Count();
            }
            catch (Exception Err)
            {
                throw;
            }
        }
    }
}
