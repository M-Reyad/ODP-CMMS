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
    
    public partial class BREAKDOWN
    {
        public int ID { get; set; }
        public string EQUIPMENTID { get; set; }
        public System.DateTime FROMTIME { get; set; }
        public System.DateTime TOTIME { get; set; }
        public Nullable<int> WORKORDER { get; set; }
        public string BDNREASON { get; set; }
    
        public virtual WORKORDER WORKORDER1 { get; set; }
    }
}
