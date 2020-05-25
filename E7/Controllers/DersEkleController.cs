
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using E7.Models.EntityFramework;
using E7.Models.MixTables;


namespace E7.Controllers
{
    public class DersEkleController : Controller

    {

        USIS1Entities db = new USIS1Entities();
        // GET: DersEkle

    [HttpGet]
        public ActionResult DersEkle()

        {
            var a = Session["ActiveUser"].ToString();
            int x = int.Parse(a);


            List<Students> student = db.Students.ToList();
            List<Courses> course = db.Courses.ToList();
            List<StudentCourses> studentcourse = db.StudentCourses.ToList();


            List<SelectListItem> degerler = (from c in course
                                             join s in student on c.DepartmentID equals s.DepartmentID

                                             where s.StudenID == x

                                             select new SelectListItem
                                             {
                                                 Text = c.CourseName,
                                                 Value = c.CourseID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            



            return View();
        }


        [HttpPost]
        public ActionResult DersEkle(StudentCourses p)

        {
           

            var a = Session["ActiveUser"].ToString();
            int x = int.Parse(a);

        
            var ktg = db.Courses.Where(m => m.CourseID == p.CourseID).FirstOrDefault();
            p.Courses = ktg;
            
            
            p.StudentID = x;
            db.StudentCourses.Add(p);
            db.SaveChanges();
            ViewBag.ekle = "eklendi";


            return View();





        }

    }

}

