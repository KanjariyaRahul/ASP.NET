using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using List_task.Models;

namespace List_task.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<List_model> items = new List<List_model>
            {
                new List_model { Name = "jay", Value = 10, Age = 25 },
                new List_model { Name = "dhaval", Value = 20, Age = 21 },
                new List_model { Name = "yash", Value = 5, Age = 20 },
                new List_model { Name = "jeet", Value = 50, Age = 28 },
                new List_model { Name = "rahul", Value = 60, Age = 35 },
                new List_model { Name = "mahaveer", Value = 70, Age = 18 },
                new List_model { Name = "parash", Value = 80, Age = 45 }
            };


            return View(items);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            
            return View();
        }
    }
}