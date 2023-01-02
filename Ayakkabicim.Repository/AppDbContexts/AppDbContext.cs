using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ayakkabicim.Core.Models;

namespace Ayakkabicim.Repository.AppDbContexts.AppDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category>Categories { get; set; }
        public DbSet<ProductBrands> ProductBrands { get; set; }
        public DbSet<ProductColors> ProductColors { get; set; }
        public DbSet<ProductCurrencyUnits> ProductCurrencyUnits { get; set; }
        public DbSet<ProductFeatures> ProductFeatures { get; set; }
        public DbSet<ProductMeasurementUnits> ProductMeasurementUnits { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductsWeightUnits> ProductWeightUnits { get; set; }
        public DbSet<ProductVatUnits> ProductVatUnits { get; set; }
        public DbSet<ProductProjects> ProductProjects { get; set; }
        public DbSet<CompanySube> CompanySube { get; set; }
        public DbSet<CompanyFirma> CompanyFirma { get; set; }
        public DbSet<CompanyBayi> CompanyBayi { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

        }
        
        



    }
}


// Burada alan adlarını oluşturucaz. DB de alan adlarını oluşturuyoruz.