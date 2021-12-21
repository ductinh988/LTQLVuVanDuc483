using LTQL_1721050483.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LTQL_1721050483.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(Account acc)
        {
            if (acc.username == "admin" && acc.password == "123456")
            {
                FormsAuthentication.SetAuthCookie(acc.username, true);
                return RedirectToAction("Create", "NhaCungCaps");
            }
            return RedirectToAction("Index", "Sanphams");
        }
    }
}