using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using firstproject.Models;

namespace firstproject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Student s = new Student();
            //s.Id = 1;
            //s.Name = "rahul";
            //s.PhoneNumber = 9265614292;

            //string[] Name = {"rahul", "raj" , "jay" , "meet"};

            List<Student> list = new List<Student>() {
          new Student() {
                    Id = 1,
                    Name = "rahul",
                    PhoneNumber = 9265614291
            },
            new Student() {
                    Id = 2,
                    Name = "jay",
                    PhoneNumber = 1123365647
            } };
            ViewBag.model = list;
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}