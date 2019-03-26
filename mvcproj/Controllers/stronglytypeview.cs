using mvcproj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcproj.Controllers
{
    public class stronglytypeviewController : Controller
    {
        // GET: stronglytypeview
        public ActionResult Index()
        {

            //Step 1 prepare data to send view
            Dept obj = new Dept();
            obj.DeptNo = 10;
            obj.DName = "Accounts";
            obj.Location = "Pune";

            //step 2 send  data using view method
            return View(obj);

        }

        public ActionResult Index2()
        {
            //Step 1 prepare data to send view
            List<Dept> deptlist = new List<Dept>();
            Dept d1 = new Dept() { DeptNo = 10, DName = "Account", Location = "Hyd" };
            Dept d2 = new Dept() { DeptNo = 20, DName = "sales", Location = "Pune" };
            Dept d3 = new Dept() { DeptNo = 30, DName = "Marketing", Location = "Mumbai" };
            deptlist.Add(d1);
            deptlist.Add(d2);
            deptlist.Add(d3);
            //step 2 send  data using view method
            return View(deptlist);
        }

    }

}
