//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ODP2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EQUIPMENTFAMILY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EQUIPMENTFAMILY()
        {
            this.EQUIPMENTs = new HashSet<EQUIPMENT>();
            this.PMTEMPLATEs = new HashSet<PMTEMPLATE>();
        }
    
        public string EQUIPMENTFAMILYCODE { get; set; }
        public string EQUIPMENTTYPEDIRECTIVE { get; set; }
        public string EQUIPMENTSCOPE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EQUIPMENT> EQUIPMENTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMTEMPLATE> PMTEMPLATEs { get; set; }
    }
}