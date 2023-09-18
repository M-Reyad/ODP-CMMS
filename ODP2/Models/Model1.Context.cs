﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ODPEntities : DbContext
    {
        public ODPEntities()
            : base("name=ODPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<breakDown> breakDowns { get; set; }
        public virtual DbSet<component> components { get; set; }
        public virtual DbSet<componentFamilyIDDirective> componentFamilyIDDirectives { get; set; }
        public virtual DbSet<componentStatu> componentStatus { get; set; }
        public virtual DbSet<equipment> equipments { get; set; }
        public virtual DbSet<equipmentFamily> equipmentFamilies { get; set; }
        public virtual DbSet<equipmentStatu> equipmentStatus { get; set; }
        public virtual DbSet<fuelingWorkOrder> fuelingWorkOrders { get; set; }
        public virtual DbSet<issue> issues { get; set; }
        public virtual DbSet<sparePart> spareParts { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<system> systems { get; set; }
        public virtual DbSet<systemIDDirective> systemIDDirectives { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<userLevel> userLevels { get; set; }
        public virtual DbSet<userSection> userSections { get; set; }
        public virtual DbSet<workDoneType> workDoneTypes { get; set; }
        public virtual DbSet<workOrder> workOrders { get; set; }
        public virtual DbSet<workOrderStatu> workOrderStatus { get; set; }
        public virtual DbSet<workOrderType> workOrderTypes { get; set; }
        public virtual DbSet<partCode> partCodes { get; set; }
    }
}