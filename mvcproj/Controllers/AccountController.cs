using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.Security;

namespace mvcproj.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            if (Request.IsAuthenticated == true)
            {
                Response.Redirect(Url.Action("Account", "Login"));
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(string uid, string pwd)
        {
            if (uid == "admin" && pwd == "admin123")
            {
                FormsAuthentication.RedirectFromLoginPage(uid, false);
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid UserName or Password";
            }
            return View();
        }
    }
}




  