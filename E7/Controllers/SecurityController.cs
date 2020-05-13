using E7.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace E7.Controllers
{
    [AllowAnonymous]
    public class SecurityController : Controller
    {
        
        USIS1Entities db = new USIS1Entities();
        // GET: Security
        
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(KullaniciGiris kullaniciGiris)
        {
            
            var kullaniciInDb = db.kullaniciGiris.FirstOrDefault(x => x.StudentNo == kullaniciGiris.StudentNo&& x.Password==kullaniciGiris.Password);
            if (kullaniciInDb != null)
            {
                
                FormsAuthentication.SetAuthCookie(kullaniciInDb.StudentNo.ToString(), true);
                @TempData["Veri"] = kullaniciInDb;
                return RedirectToAction("Anasayfa", "Home");
                
            }
            else
            {
                ViewBag.Mesaj = "gecersiz.";
                return View();
            }
           
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        internal class kullaniciInDb
        {
        }
    }
}