//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E7.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExamGrades
    {
        public int ExamID { get; set; }
        public Nullable<int> StudentCourseID { get; set; }
        public Nullable<int> Grade { get; set; }
    
        public virtual StudentCourses StudentCourses { get; set; }
    }
}
