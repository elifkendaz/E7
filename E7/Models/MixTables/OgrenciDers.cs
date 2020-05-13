using E7.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E7.Models.MixTables
{
    public class OgrenciDers
    {
        public KullaniciGiris kullanici { get; set; }

        public Students student1 { get; set; }
            public StudentCourses studentcourse { get; set; }
           
        public Courses course { get; set; }
        
    }
    
}