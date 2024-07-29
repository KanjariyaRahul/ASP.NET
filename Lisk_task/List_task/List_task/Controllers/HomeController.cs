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
            new List_model { Name = "jay", Value = 10 },
            new List_model { Name = "dhaval", Value = 20 },
            new List_model { Name = "yash", Value = 5 },
            new List_model { Name = "jeet", Value = 50 },
            new List_model { Name = "rahul", Value = 60},
            new List_model { Name = "mahaveer", Value = 70},
            new List_model { Name = "parash", Value = 80 }
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