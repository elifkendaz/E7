using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E7.Models;
using E7.Models.EntityFramework;
using E7.Models.MixTables;

namespace E7.Controllers
{
    public class OgrenciDerslerController : Controller
    {
        // GET: OgrenciDersler
        public ActionResult OgrenciDersView()
        {
            using (USIS1Entities db = new USIS1Entities())
            {
                {
                    List<Students> studentlist = db.Students.ToList();
                    List<StudentCourses> studentcourselist = db.StudentCourses.ToList();
                    List<Courses> courselist = db.Courses.ToList();
                    List<KullaniciGiris> giris = db.kullaniciGiris.ToList();

                    var item = from g in giris
                               join s in studentlist on g.KullaniciID equals s.StudenID into table1
                               from s in table1.ToList()
                               join sc in studentcourselist on s.StudenID equals sc.StudentID into table2
                               from sc in table2.ToList()
                               join c in courselist on sc.CourseID equals c.CourseID into table3
                               from c in table3.ToList()

                               select new OgrenciDers
                               {
                                   kullanici=g,
                                   student1 = s,
                                   studentcourse = sc,
                                   course=c

                               };






                    return View(item);
                }
            }
        }
    }
}
