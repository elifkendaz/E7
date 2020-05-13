using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E7.Models;
using E7.Models.EntityFramework;
using E7.Controllers;

namespace E7.Controllers
{
    
    [Authorize]
    public class HomeController : Controller
    {
        USIS1Entities db = new USIS1Entities();

       

        public ActionResult Index()
        {
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
        public ActionResult Anasayfa()
        {
            return View();
        }
        public ActionResult Ogrenci()
        {
            var a1 = @TempData["Veri"];

            var degerler = db.Students.ToList();
            return View(degerler);
           
      
        }
       

    }
}