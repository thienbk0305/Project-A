using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebDemoMVC.CategoryManager;
using WebDemoMVC.EntitiesFrameWork;
using WebDemoMVC.EntitiesFrameWork.Entites;
using OfficeOpenXml;



namespace WebDemoMVC.Controllers
{
    public class ProductController : Controller
    {
        private BlogContext db = new BlogContext();

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductListPartialView(string keysearch)
        {

            var productManager = new ProductManager();

            var list = productManager.GetProducts(keysearch);

            return PartialView(list);
        }
        [HttpPost]
        public ActionResult Insert(Product model)
        {
            try
            {
                var productManager = new WebDemoMVC.CategoryManager.ProductManager();

                var pro = new Product
                {
                    Name = model.Name
                };

                var result = productManager.Product_InsertOrUpdate(pro, 0);
                if (result > 0)
                {
                    return Json(new { code = 1, msg = "Thêm mới thành công" });
                }
                else
                {
                    return Json(new { code = 0, msg = "Thêm mới thất bại" });
                }
            }
            catch (Exception ex)
            {

                return Json(new { code = -99, msg = ex.Message });
            }
        }
        [HttpPost]
        public JsonResult Delete(Product model)
        {
            try
            {
                var productManager = new WebDemoMVC.CategoryManager.ProductManager();


                var result = productManager.Product_Delete(model);
                if (result > 0)
                {
                    return Json(new { code = 1, msg = "Xóa mới thành công" });
                }
                else
                {
                    return Json(new { code = 0, msg = "Xóa mới thất bại" });
                }
            }
            catch (Exception ex)
            {

                return Json(new { code = -99, msg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                try
                {
                    using (var package = new ExcelPackage(file.InputStream))
                    {
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                        DataTable dt = new DataTable();

                        foreach (var firstRowCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                        {
                            dt.Columns.Add(firstRowCell.Text);
                        }

                        for (var rowNumber = 2; rowNumber <= worksheet.Dimension.End.Row; rowNumber++)
                        {
                            var row = worksheet.Cells[rowNumber, 1, rowNumber, worksheet.Dimension.End.Column];
                            var newRow = dt.NewRow();
                            foreach (var cell in row)
                            {
                                newRow[cell.Start.Column - 1] = cell.Text;
                            }
                            dt.Rows.Add(newRow);
                        }

                        foreach (DataRow row in dt.Rows)
                        {
                            Product product = new Product
                            {
                                Name = row["Name"].ToString(),
                            };

                            db.Product.Add(product);
                        }

                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Error: " + ex.Message;
                }
            }

            return RedirectToAction("Index");
        }
        public ActionResult ExportToExcel()
        {
            var productManager = new ProductManager();

            var products = productManager.GetProducts("");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Report");

                // Add headers
                worksheet.Cells["A1"].Value = "Product ID";
                worksheet.Cells["B1"].Value = "Product Name";

                // Populate data
                int row = 2;
                foreach (var product in products)
                {
                    worksheet.Cells["A" + row].Value = product.Id;
                    worksheet.Cells["B" + row].Value = product.Name;
                    row++;
                }
                worksheet.Cells["A:AZ"].AutoFitColumns();
                // Set content type and disposition for the response
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                Response.AddHeader("content-disposition", "attachment: filename=" + "Product.xlsx");

                // Write the Excel package to the response stream
                Response.BinaryWrite(package.GetAsByteArray());
                Response.End();
            }

            return RedirectToAction("Index");
        }
    }
}
