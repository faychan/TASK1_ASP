﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TASK1_ASP.Models.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DemoDBEntities1 : DbContext
    {
        public DemoDBEntities1()
            : base("name=DemoDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LOOKUPRole> LOOKUPRole { get; set; }
        public virtual DbSet<SYSUser> SYSUser { get; set; }
        public virtual DbSet<SYSUserProfile> SYSUserProfile { get; set; }
        public virtual DbSet<SYSUserRole> SYSUserRole { get; set; }
    }
}
