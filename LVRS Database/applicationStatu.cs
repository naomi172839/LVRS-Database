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
    
    public partial class applicationStatu
    {
        public int appStatID { get; set; }
        public int memberID { get; set; }
        public int appStatTypeID { get; set; }
        public string appStatNotes { get; set; }
        public string comments { get; set; }
    
        public virtual applicationStatusType applicationStatusType { get; set; }
        public virtual member member { get; set; }
    }
}
