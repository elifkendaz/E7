using E7.Models.EntityFramework;
using E7.Models.MixTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E7.Controllers
{
    public class DersProgramiController : Controller
    {
        // GET: DersProgrami
        public ActionResult DersPView()
        {
            var a = Session["ActiveUser"].ToString();
            int i = int.Parse(a);
            using (USIS1Entities db = new USIS1Entities())
            {
                {
                    List<Students> studentlist = db.Students.ToList();
                    List<Departments> departmentlist = db.Departments.ToList();

                    var item = from s in studentlist
                               join dl in departmentlist on s.DepartmentID equals dl.DepartmentID into table1
                               from dl in table1.ToList()
                             
                               where s.StudenID == i

                               select new dersp
                               {
                                  
                                   student = s,
                                   department=dl

                               };



                    return View(item);
                }
            }
        }
    }
}