using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcproj.Controllers
{
    public class mvcajaxController : Controller
    {
        // GET: mvcajax
        public ActionResult Index()
        {
            return View();
        }

        EmpDeptDBEntities db = new EmpDeptDBEntities();
        public ActionResult GetEmpCount(int id)
        {
            var q1 = from c in db.Emp.ToList() where c.DeptNo == id select c;
            string str = "Employee Count : " + q1.Count();
            return Json(str, JsonRequestBehavior.AllowGet);
        }

    }
}