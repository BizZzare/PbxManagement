﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PbxManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PbxEntities : DbContext
    {
        public PbxEntities()
            : base("name=PbxEntities")
        {
            this.Configuration.AutoDetectChangesEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<PhoneCalls> PhoneCalls { get; set; }
        public virtual DbSet<Subscribers> Subscribers { get; set; }
        public virtual DbSet<SubscriberToTariff> SubscriberToTariff { get; set; }
        public virtual DbSet<TariffCharges> TariffCharges { get; set; }
        public virtual DbSet<Tariffs> Tariffs { get; set; }
    }
}
