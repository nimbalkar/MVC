using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcproj.Controllers
{
    public class viewdataController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(string pname, int uprice, int qty)
        {
            int n = uprice * qty;
            ViewData["ProductName"] = pname;
            ViewBag.total = n;
            return View();
        }

    }
}