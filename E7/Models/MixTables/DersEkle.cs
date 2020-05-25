using E7.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E7.Models.MixTables
{
    public class DersEkle
    {
        public StudentCourses studentcourse { get; set; }
        public Courses course { get; set; }
        public Students student { get; set; }
    }
}