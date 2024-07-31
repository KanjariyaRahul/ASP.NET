using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
namespace file_upload.Controllers
{
    public class HomeController : Controller
    {

        // Allowed file extensions
        private static readonly string[] AllowedExtensions = { ".jpg", ".jpeg", ".png", ".gif" };
        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                string extension = Path.GetExtension(file.FileName).ToLower();
                if (Array.Exists(AllowedExtensions, ext => ext.Equals(extension)))
                {
                    try
                    {
                        string filename = Guid.NewGuid().ToString() + extension;
                        string path = Path.Combine(Server.MapPath("~/Uploads/"), filename);
                        file.SaveAs(path);
                        ViewBag.ImagePath = Url.Content("~/Uploads/" + filename);
                        ViewBag.Message = "File uploaded successfully!";
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Message = "Error occurred: " + ex.Message;
                    }
                }
                else
                {
                    ViewBag.Message = "Invalid file type. Only JPEG, PNG, and GIF files are allowed.";
                }
            }
            else
            {
                ViewBag.Message = "No file uploaded.";
            }
            return View();
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