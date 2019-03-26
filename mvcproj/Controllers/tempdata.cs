using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcproj.Controllers
{
    public class tempdataController : Controller
    {
        // GET: tempdata
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string uid, string pwd)
        {
            if (uid == "admin" && pwd == "admin123")
            {
                TempData["UserName"] = uid;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Invilid username or password";
                return View();
            }

        }
    }
}