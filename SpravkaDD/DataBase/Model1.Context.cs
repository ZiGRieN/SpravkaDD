﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SpravkaDD_DataModelContainer : DbContext
    {
        public SpravkaDD_DataModelContainer()
            : base("name=SpravkaDD_DataModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Persons> PersonsSet { get; set; }
        public virtual DbSet<raion> raionSet { get; set; }
        public virtual DbSet<Object> ObjectSet { get; set; }
        public virtual DbSet<Category> CategorySet { get; set; }
        public virtual DbSet<SubCategory> SubCategorySet { get; set; }
    }
}