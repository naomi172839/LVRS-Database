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
    
    public partial class statusType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public statusType()
        {
            this.finalJoinStatus = new HashSet<finalJoinStatu>();
            this.initialJoinStatus = new HashSet<initialJoinStatu>();
            this.statusChanges = new HashSet<statusChange>();
        }
    
        public int statID { get; set; }
        public string statusType1 { get; set; }
        public string comments { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<finalJoinStatu> finalJoinStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<initialJoinStatu> initialJoinStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<statusChange> statusChanges { get; set; }
    }
}
