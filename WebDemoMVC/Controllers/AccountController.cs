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
        // GET: Account
        public ActionResult Index()
        {
            //var AccManger = new WebDemoMVC.AccountManager.AccountManager();
            //var model = new List<Account>();
            //model = AccManger.Account_GetList().ToList();
            //return PartialView("Account", model);
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Account model)
        {
            try
            {
                var BlogManger = new WebDemoMVC.AccountManager.AccountManager();

                var acc = new Account
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Username = model.Username,
                    Password = model.Password
                };

                var result = BlogManger.Account_InsertUpdate(acc, 0);
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

    }
}