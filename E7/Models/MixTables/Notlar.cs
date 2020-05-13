using E7.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E7.Models.MixTables
{
    public class Notlar
    {
        public Students student { get; set; }
        public StudentCourses studentcourse { get; set; }
        public ExamGrades examgrade { get; set; }
        public Courses course { get; set; }
    }
}