using E7.Models.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using E7.Models.MixTables;

namespace E7.Controllers
{
    public class NotlarController : Controller
    {

        public ActionResult NotlarView()
        {
            using (USIS1Entities db = new USIS1Entities())
            {
                {
                    List<Students> studentlist = db.Students.ToList();
                    List<StudentCourses> studentcourselist = db.StudentCourses.ToList();
                    List<Courses> courselist = db.Courses.ToList();
                    List<ExamGrades> examgrade = db.ExamGrades.ToList();


                    var item = from s in studentlist
                               join sc in studentcourselist on s.StudenID equals sc.StudentID into table1
                               from sc in table1.ToList()
                               join c in courselist on sc.CourseID equals c.CourseID into table2
                               from c in table2.ToList()
                               join eg in examgrade on sc.StudentCourseID equals eg.StudentCourseID into table3
                               from eg in table3.ToList()

                               select new Notlar
                               {
                                   student = s,
                                   studentcourse = sc,
                                   course = c,
                                   examgrade=eg

                               };






                    return View(item);
                }




            }
        }
    }
}