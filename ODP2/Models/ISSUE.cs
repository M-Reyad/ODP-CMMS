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
    
    public partial class ISSUE
    {
        public int ISSUEID { get; set; }
        public int WORKORDER { get; set; }
        public int QTY { get; set; }
        public string SPAREPARTCODE { get; set; }
        public Nullable<System.DateTime> ISSUEDATE { get; set; }
        public Nullable<decimal> PARTPRICE { get; set; }
        public Nullable<decimal> TOTALPRICE { get; set; }
        public Nullable<System.DateTime> REQUESTDATE { get; set; }
        public string ISSUESTATE { get; set; }
    
        public virtual ISSUESTATU ISSUESTATU { get; set; }
        public virtual SPAREPART SPAREPART { get; set; }
        public virtual WORKORDER WORKORDER1 { get; set; }
    }
}
