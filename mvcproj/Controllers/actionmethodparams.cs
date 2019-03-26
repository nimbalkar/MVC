using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcproj.Controllers
{
    public class actionmethodparamsController : Controller
    {
        // GET: actionmethodparams
        public ActionResult Index()
        {
            return View();
        }

        // Get ActionMethod QueryString
        public ActionResult Details1(int dno)
        {
            Response.Write("Requested Deptno: " + dno);
            return View();
        }

        //Get ActionMethod Route-URL-Parameter 
        public ActionResult Details2(int id)
        {
            Response.Write("Requested Deptno:" + id);
            return View();
        }

    }
}