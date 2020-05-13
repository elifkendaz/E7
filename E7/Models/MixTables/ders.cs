using E7.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E7.Models.MixTables
{
    public class ders
    {
        public Departments department { get; set; }
        public Courses course { get; set; }
        

    }
}