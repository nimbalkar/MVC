using mvcproj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcproj.Controllers
{
    public class entityclassController : Controller
    {
        datacontext db = new datacontext();
        // GET: entityclass
        public ActionResult Index()
        {
            List<Dept> deptList = db.GetDepts();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Dept obj)
        {
            db.AddDept(obj);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Dept Obj = db.GetDept(id);
            return View(Obj);
        }

        public ActionResult Edit(int id)
        {
            Dept obj = db.GetDept(id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult Edit(Dept obj)
        {
            db.EditDept(obj);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Dept obj = db.GetDept(id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult Delete(String id)
        {
            int n = int.Parse(id);
            db.DeleteDept(n);
            return RedirectToAction("Index");
        }

    }
}