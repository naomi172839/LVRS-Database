//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LVRS_Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class job
    {
        public int jobID { get; set; }
        public int memberID { get; set; }
        public int jobTypeID { get; set; }
        public Nullable<System.DateTime> jobDate { get; set; }
        public string comments { get; set; }
    
        public virtual jobType jobType { get; set; }
        public virtual member member { get; set; }
    }
}
