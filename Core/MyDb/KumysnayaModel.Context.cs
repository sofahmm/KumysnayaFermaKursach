﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.MyDb
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KumysnaFermaEntities : DbContext
    {
        public KumysnaFermaEntities()
            : base("name=KumysnaFermaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Breed> Breed { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeHorse> EmployeeHorse { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Horse> Horse { get; set; }
        public DbSet<HorseType> HorseType { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<SposobOplati> SposobOplati { get; set; }
        public DbSet<StatusOrder> StatusOrder { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<User> User { get; set; }
    }
}