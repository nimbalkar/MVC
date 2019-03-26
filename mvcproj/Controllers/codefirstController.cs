using mvcproj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcproj.Controllers
{
    public class codefirstController : Controller
    {
        // GET: Home
        TestDbEntities db = new TestDbEntities();
        public ActionResult Index()
        {
            List<Student> listStudent = db.students.ToList();
            return View(listStudent);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student obj)
        {
            db.students.Add(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}
