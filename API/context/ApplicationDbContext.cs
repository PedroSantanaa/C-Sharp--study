using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.context
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Product>().Property(p=>p.Description).HasMaxLength(500).IsRequired(false);
            modelBuilder.Entity<Product>().Property(p=>p.Name).HasMaxLength(120).IsRequired();
            modelBuilder.Entity<Product>().Property(p=>p.Code).HasMaxLength(20).IsRequired();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)        
           => optionsBuilder.UseSqlServer(
            "Server=localhost;Database=Products;User Id=sa;Password=@Sql2023;MultipleActiveResultSets=true;Encrypt=YES;TrustServerCertificate=YES");
        
    }
}