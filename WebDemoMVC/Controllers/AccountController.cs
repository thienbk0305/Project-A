using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDemoMVC.EntitiesFrameWork;
using WebDemoMVC.EntitiesFrameWork.Entites;
using WebDemoMVC.User;
using WebGrease;

namespace WebDemoMVC.Controllers
{
    public class AccountController : Controller
    {
        BlogContext dbContext = new BlogContext();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Account()
        {
            var AccManger = new WebDemoMVC.AccountManager.AccountManager();
            var model = new List<Account>();
            model = AccManger.Account_GetList().ToList();
            return PartialView("Account", model);
        }
        [HttpPost]
        public ActionResult Insert(Account model)
        {
            try
            {
                var AccountManger = new WebDemoMVC.AccountManager.AccountManager();

                var acc = new Account
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Username = model.Username,
                    Password = model.Password
                };

                var result = AccountManger.Account_InsertUpdate(acc, 0);
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
        public JsonResult Delete(string id)
        {
            try
            {
                var AccountManger = new WebDemoMVC.AccountManager.AccountManager();


                var result = AccountManger.Account_Delete(id);
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
        [HttpGet]
        public ActionResult Search(Account mode)
        {
            
            var accounts = new List<Account>();
            accounts = dbContext.Account.Where(account => account.Username.Contains(mode.Username))
                .Where(account => account.CreatedDate < mode.CreatedDate).ToList();
            
            return PartialView("Search",accounts);


        }
    }
}