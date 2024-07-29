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
            new List_model { Name = "Item 1", Value = 10 },
            new List_model { Name = "Item 2", Value = 20 },
            new List_model { Name = "Item 3", Value = 5 },
            new List_model { Name = "Item 4", Value = 50 },
            new List_model { Name = "Item 5", Value = 60},
            new List_model { Name = "Item 6", Value = 70},
            new List_model { Name = "Item 7", Value = 80 }
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