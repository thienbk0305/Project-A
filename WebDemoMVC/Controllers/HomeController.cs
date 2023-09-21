using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDemoMVC.EntitiesFrameWork;
using WebDemoMVC.EntitiesFrameWork.Entites;

namespace WebDemoMVC.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index(string name)
        {
            var BlogManger = new WebDemoMVC.CategoryManager.CategoryManager();
            var PostManger = new WebDemoMVC.PostManager.PostManager();
            var model = new List<Category>();

            //var cate = new Category
            //{
            //    CategoryId = 1,
            //    CategoryName = "Điện tử",
            //    CategoryDescription = "Hàng Điện tử"
            //};

            //var result = BlogManger.Category_InsertUpdate(cate, 0);

            //if (result > 0)
            //{
            //    // xử lý thông báo
            //    model = BlogManger.Categories_GetList(0, "").ToList();
            //}

            model = BlogManger.Categories_GetList(0, "").ToList();

            //var posts = new Post
            //{
            //    PostId = 1,
            //    PostName = "This is the content of post 1",
            //    CategoryId = 3,
            //    CreateDate=DateTime.Now
            //};
            //var result = PostManger.Post_InsertUpdate(posts, 0);

            //if (result > 0)
            //{
            //    // xử lý thông báo
            //    posts = PostManger.Post_GetList(0, "").ToList();
            //    ViewData["Posts"] = posts;
            //}

            var posts = new List<Post>();
            posts = PostManger.Post_GetList(0, "").ToList();
            ViewData["Posts"] = posts;
            // Trả về dữ liệu cho View

            return View(model);
        }

        [HttpPost]
        public ActionResult Insert(Category model)
        {
            try
            {
                var BlogManger = new WebDemoMVC.CategoryManager.CategoryManager();

                var cate = new Category
                {
                    CategoryId = model.CategoryId,
                    CategoryName = model.CategoryName
                };

                var result = BlogManger.Category_InsertUpdate(cate, 0);
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
        public ActionResult InsertPost(Post model)
        {
            try
            {
                var BlogManger = new WebDemoMVC.PostManager.PostManager();

                var post = new Post
                {
                    PostId = model.PostId,
                    PostName = model.PostName,
                    CategoryId = 3,
                    CreateDate = DateTime.Now
                };

                var result = BlogManger.Post_InsertUpdate(post, 0);
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
        public ActionResult Update(Category model)
        {
            try
            {
                var BlogManger = new WebDemoMVC.CategoryManager.CategoryManager();

                var cate = new Category
                {
                    CategoryId = model.CategoryId,
                    CategoryName = model.CategoryName
                };

                var result = BlogManger.Category_InsertUpdate(cate, 1);
                if (result > 0)
                {
                    return Json(new { code = 1, msg = "Chỉnh sửa thành công" });
                }
                else
                {
                    return Json(new { code = 0, msg = "Chỉnh sửa thất bại" });
                }
            }
            catch (Exception ex)
            {

                return Json(new { code = -99, msg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdatePost(Post model)
        {
            try
            {
                var BlogManger = new WebDemoMVC.PostManager.PostManager();

                var post = new Post
                {
                    PostId = model.PostId,
                    PostName = model.PostName
                };

                var result = BlogManger.Post_InsertUpdate(post, 1);
                if (result > 0)
                {
                    return Json(new { code = 1, msg = "Chỉnh sửa thành công" });
                }
                else
                {
                    return Json(new { code = 0, msg = "Chỉnh sửa thất bại" });
                }
            }
            catch (Exception ex)
            {

                return Json(new { code = -99, msg = ex.Message });
            }
        }

        public JsonResult Delete(int id)
        {
            try
            {
                var BlogManger = new WebDemoMVC.CategoryManager.CategoryManager();


                var result = BlogManger.Category_Delete(Convert.ToInt32(id));
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

        public JsonResult DeletePost(int id)
        {
            try
            {
                var BlogManger = new WebDemoMVC.PostManager.PostManager();


                var result = BlogManger.Post_Delete(Convert.ToInt32(id));
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
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return RedirectToAction("Contact","Home");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}