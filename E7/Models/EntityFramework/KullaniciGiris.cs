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
    
    public partial class KullaniciGiris
    {
        public int KullaniciID { get; set; }
        public Nullable<int> StudentNo { get; set; }
        public string Password { get; set; }
    
        public virtual Students Students { get; set; }
    }
}
