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
    
    public partial class issue
    {
        public int issueID { get; set; }
        public int workOrder { get; set; }
        public int qty { get; set; }
        public string sparePartCode { get; set; }
        public Nullable<System.DateTime> issueDate { get; set; }
        public Nullable<decimal> partPrice { get; set; }
        public Nullable<decimal> totalPrice { get; set; }
        public Nullable<System.DateTime> requestDate { get; set; }
        public string issueState { get; set; }
    
        public virtual sparePart sparePart { get; set; }
        public virtual workOrder workOrder1 { get; set; }
        public virtual issueStatu issueStatu { get; set; }
    }
}