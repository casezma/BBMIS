using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BBMIS.Models
{
    public class BBMISContext : DbContext
    {
        public BBMISContext() : base("BBMIS") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<CarBuild> CarBuild { get; set; }
        public DbSet<CarBuildVolumes> CarBuildVolumes {get;set;}
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Derivation> Derivation { get; set; }
        public DbSet<Derivation_Supplier> Derivation_Supplier { get; set; }
        public DbSet<Fuel> Fuel { get; set; }
        public DbSet<Motor> Motor { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Product_Type> Product_Type { get; set; }
        public DbSet<Share> Share { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
    }
}