using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using database.Models;

namespace database.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentEntities db = new StudentEntities();
            List<Stud> stds = db.Studs.ToList();
            return View(stds);
        } 
        
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Stud s )
        {
            StudentEntities db = new StudentEntities();
            db.Studs.Add(s);
            db.SaveChanges();
            return View();
        }

        public ActionResult Delete(int Id)
        {
            StudentEntities db = new StudentEntities();
            Stud std = db.Studs.Find(Id);
            db.Studs.Remove(std);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }

  
}