using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using azureProductWebApp.models;

namespace azureProductWebApp.context
{
    public class AzureAppContext : DbContext
    {
        public AzureAppContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
       


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>().HasData(
        //        new Product() { Id = 101, Name = "Phone", Image = "" },
        //        new Product() { Id = 102, Name = "Laptop", Image = "" }
        //        );
        //} 
        }
}
