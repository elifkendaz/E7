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
    public class DerslerController : Controller
    {
        // GET: OgrenciDersler
        public ActionResult DersView()
        {
            using (USIS1Entities db = new USIS1Entities())
            {
                {
                    List<Departments> departmentlist = db.Departments.ToList();
                    List<Courses> courselist = db.Courses.ToList();
                   

                    var item = from d in departmentlist
                               join c in courselist on d.DepartmentID equals c.DepartmentID into table1
                               from c in table1.ToList()
                              

                               select new ders
                               {
                                   department = d,
                                   course = c

                               };

                    return View(item);
                }
            }
        }
    }
}