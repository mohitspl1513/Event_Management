﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Event_Management.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Event_ManagementEntities : DbContext
    {
        public Event_ManagementEntities()
            : base("name=Event_ManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADD_ON_ITEM> ADD_ON_ITEM { get; set; }
        public virtual DbSet<Book_Event> Book_Event { get; set; }
        public virtual DbSet<Customer_Entry> Customer_Entry { get; set; }
        public virtual DbSet<Decoration> Decorations { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
    }
}
