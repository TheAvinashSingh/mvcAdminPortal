using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvcAdminPortal.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext():base("DefaultConnection")
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Primary Key Category
            modelBuilder.Entity<Category>().HasKey(p => p.CategoryId);
            modelBuilder.Entity<Category>().Property(p => p.CategoryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Primary Key Brand
            modelBuilder.Entity<Brand>().HasKey(p => p.BrandId);
            modelBuilder.Entity<Brand>().Property(p => p.BrandId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            // Primary Key Product
            modelBuilder.Entity<Product>().HasKey(p => p.ProductId);
            modelBuilder.Entity<Product>().Property(p => p.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Foreign Key BrandId
            modelBuilder.Entity<Product>().HasRequired(p => p.Brand).WithMany(b => b.Products).HasForeignKey(b => b.BrandId);
            // Foreign Key CategoryId
            modelBuilder.Entity<Product>().HasRequired(p => p.Category).WithMany(b => b.Products).HasForeignKey(b => b.CategoryId);

            base.OnModelCreating(modelBuilder);
        }
    }
}