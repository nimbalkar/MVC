using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcproj.Controllers
{
    public class get : Controller
    {
        
        public ActionResult Index1()
        {
            return View();
        }

        public ActionResult Details1(int dno)
        {
            Response.Write("Requested Deptno: " + dno);
            return View();
        }
     
        public ActionResult Details2(int id)
        {
            Response.Write("Requested Deptno:" + id);
            return View();
        }

    }
}