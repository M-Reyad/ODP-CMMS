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
    
    public partial class WORKORDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WORKORDER()
        {
            this.BREAKDOWNs = new HashSet<BREAKDOWN>();
            this.ISSUEs = new HashSet<ISSUE>();
            this.STORERETURNs = new HashSet<STORERETURN>();
        }
    
        public string WORKORDERDIRECTIVE { get; set; }
        public string WORKORDERSTATUSID { get; set; }
        public string WORKORDERTYPEID { get; set; }
        public Nullable<System.DateTime> WORKSTARTDATE { get; set; }
        public Nullable<System.DateTime> WORKDONEDATE { get; set; }
        public string WORKORDEREQUIPMENTID { get; set; }
        public string WORKORDERCREATORID { get; set; }
        public System.DateTime WORKORDERREGISTERATIONDATE { get; set; }
        public Nullable<System.DateTime> WORKORDERFINISHDATE { get; set; }
        public string WORKORDERNOTES { get; set; }
        public Nullable<int> EQUIPMENTRH { get; set; }
        public string WORKDONETYPE { get; set; }
        public byte[] WORKORDERATTACH { get; set; }
        public int WORKORDERID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BREAKDOWN> BREAKDOWNs { get; set; }
        public virtual EQUIPMENT EQUIPMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ISSUE> ISSUEs { get; set; }
        public virtual ODP_USER ODP_USER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STORERETURN> STORERETURNs { get; set; }
        public virtual WORKDONETYPE WORKDONETYPE1 { get; set; }
        public virtual WORKORDERSTATU WORKORDERSTATU { get; set; }
        public virtual WORKORDERTYPE WORKORDERTYPE { get; set; }
    }
}
