using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDemoMVC.EntitiesFrameWork;
using WebDemoMVC.EntitiesFrameWork.Entites;
using static System.Data.Entity.Infrastructure.Design.Executor;


namespace WebDemoMVC.CategoryManager
{
    public class ProductManager : IProduct
    {
        BlogContext dbContext = new BlogContext();
        public List<Product> GetProducts(string KeySearch)
        {
            var ProducManger = new WebDemoMVC.CategoryManager.ProductManager();
            var model = new List<Product>();
            try
            {
                model = dbContext.Product.ToList();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            if (!string.IsNullOrEmpty(KeySearch))
            {
                model = model.FindAll(s => s.Name.ToLower().Contains(KeySearch.ToLower()));
            }
            return model;
        }

        public int Product_Delete(Product product)
        {
            try
            {
                var productRemove = dbContext.Product.Where(c => c.Id == product.Id).FirstOrDefault();
                dbContext.Product.Remove(productRemove);
                return dbContext.SaveChanges();
            }
            catch (Exception)
            {

                return -1;
            }
        }

        public int Product_InsertOrUpdate(Product product, int isUpdate)
        {
            try
            {
                if (isUpdate == 0)
                {
                    // INSERT
                    var checkExist = dbContext.Product.ToList().FindAll(s => s.Id == product.Id);
                    if (checkExist.Count > 0)
                    {
                        // đã tồn tại rồi
                        return -1;
                    }

                    dbContext.Product.Add(product);
                }
                else
                {
                    // UPDATE
                    var pro = dbContext.Product.ToList().FindAll(s => s.Id == product.Id).FirstOrDefault();
                    pro.Name = product.Name;
                }

                return dbContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}