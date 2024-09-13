using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index(string searchFirstName = "", string searchLastName = "", string searchFullName = "", string searchBy = "", string searchCriteria = "")
        {
            using (MyDBEntities db = new MyDBEntities())
            {
                // Filter students based on searchFirstName and searchLastName
                var students = db.Students.AsQueryable();

                if (!string.IsNullOrEmpty(searchFirstName))
                {
                    students = students.Where(s => s.fname.Contains(searchFirstName));
                }

                if (!string.IsNullOrEmpty(searchLastName))
                {
                    students = students.Where(s => s.lname.Contains(searchLastName));
                } 
                if (!string.IsNullOrEmpty(searchFullName))
                {
                    students = students.Where(s => s.lname.Contains(searchFullName) || s.fname.Contains(searchFullName));
                }
                if (!string.IsNullOrEmpty(searchCriteria) && !string.IsNullOrEmpty(searchBy))
                {
                    if (searchBy == "firstName")
                    {
                        students = students.Where(s => s.fname.Contains(searchCriteria));
                    }
                    else if (searchBy == "lastName")
                    {
                        students = students.Where(s => s.lname.Contains(searchCriteria));
                    }
                }

                List<Student> std = students.ToList();
                return View(std);
            }
        }

        public ActionResult Delete(int id)
        {
            using (MyDBEntities db = new MyDBEntities())
            {
                Student student = db.Students.Find(id);
                if (student != null)
                {
                    db.Students.Remove(student);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteSelected(int[] selectedIds)
        {
            using (MyDBEntities db = new MyDBEntities())
            {
                if (selectedIds != null)
                {
                    foreach (int id in selectedIds)
                    {
                        Student student = db.Students.Find(id);
                        if (student != null)
                        {
                            db.Students.Remove(student);
                        }
                    }
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Insert(int id = 0, string mode = "")
        {
            using (MyDBEntities db = new MyDBEntities())
            {
                Student student = new Student();
                if (id != 0)
                {
                    student = db.Students.Find(id);
                }
                else
                {
                    student = new Student();
                }
                ViewBag.mode = mode;
                ViewBag.id = id;

                return View(student);
            }
        }

        [HttpPost]
        public ActionResult InsertPost(Student s)
        {
            using (MyDBEntities db = new MyDBEntities())
            {
                string mode = Request["mode"];
                int id = Convert.ToInt32(Request["id"]);

                if (mode == "E")
                {
                    Student onestudent = db.Students.Find(id);
                    if (onestudent != null)
                    {
                        onestudent.fname = s.fname;
                        onestudent.lname = s.lname;

                        db.SaveChanges();
                    }
                }
                else
                {
                    db.Students.Add(s);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
