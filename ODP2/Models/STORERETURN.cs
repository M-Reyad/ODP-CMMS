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
    
    public partial class STORERETURN
    {
        public int RETURNID { get; set; }
        public int WORKORDER { get; set; }
        public int QTY { get; set; }
        public string COMPONENTSN { get; set; }
        public decimal RETURNPRICE { get; set; }
    
        public virtual COMPONENT COMPONENT { get; set; }
        public virtual WORKORDER WORKORDER1 { get; set; }
    }
}
