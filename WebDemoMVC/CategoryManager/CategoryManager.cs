using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using WebDemoMVC.EntitiesFrameWork;
using WebDemoMVC.EntitiesFrameWork.Entites;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace WebDemoMVC.CategoryManager
{
    public class CategoryManager : ICategory

    {
        BlogContext dbContext = new BlogContext();
        public List<Category> Categories_GetList(int cateId, string name)
        {
            var list = new List<Category>();
            try
            {
                list = dbContext.Category.ToList();
                if (cateId > 0)
                {
                    list = list.FindAll(s => s.CategoryId == cateId).ToList();
                }

                if (!string.IsNullOrEmpty(name))
                {
                    list = list.FindAll(s => s.CategoryName.ToLower().Contains(name)).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return list;
        }

        public int Category_Delete(int cateId)
        {
            try
            {
                // Bước 1: lấy ra category theo CateId truyền vào 
                var categoryRemove = dbContext.Category.Where(c => c.CategoryId == cateId).FirstOrDefault();

                // Bước 2 : Xóa
                dbContext.Category.Remove(categoryRemove);
                return dbContext.SaveChanges();
            }
            catch (Exception)
            {

                return -1;
            }
        }

        public int Category_InsertUpdate(Category category, int isUpdate)
        {
            try
            {
                if (isUpdate == 0)
                {
                    // INSERT
                    var checkExist = dbContext.Category.ToList().FindAll(s => s.CategoryId == category.CategoryId);
                    if (checkExist.Count > 0)
                    {
                        // đã tồn tại rồi
                        return -1;
                    }

                    dbContext.Category.Add(category);
                }
                else
                {
                    // UPDATE
                    var cate = dbContext.Category.ToList().FindAll(s => s.CategoryId == category.CategoryId).FirstOrDefault();
                    cate.CategoryName = category.CategoryName;
                }

                return dbContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal int Product_InsertUpdate(Product pro, int v)
        {
            throw new NotImplementedException();
        }
    }

}