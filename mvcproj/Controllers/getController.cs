using mvcproj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcproj.Controllers
{
    public class getController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
 
        public ActionResult Index(Dept obj)
        {
            Response.Write("DeptNo:" + obj.Deptno);
            Response.Write("<br/> DeptName: " + obj.Dname);
            Response.Write("<br/> Location: " + obj.Location);
            return View();
        }

    }
}