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
    
    public partial class leaveType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public leaveType()
        {
            this.leaveStatus = new HashSet<leaveStatu>();
        }
    
        public int leaveTypeID { get; set; }
        public string leaveType1 { get; set; }
        public string comments { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<leaveStatu> leaveStatus { get; set; }
    }
}
