using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProject.Controllers
{
    public class RazorStudentInfoController : Controller
    {
        // GET: RazorStudentInfo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {

            return View();
        }

        public ActionResult courses()
        {
            return View();
        }

        public ActionResult coursesList()
        {
            return View();
        }
    }
}