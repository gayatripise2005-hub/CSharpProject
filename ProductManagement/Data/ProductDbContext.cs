using Microsoft.EntityFrameworkCore;
using ProductManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProductManagement.Data
{
    /// <summary>
    /// Represents the Entity Framework database context for accessing and managing product-related data.
    /// </summary>
    /// <remarks>Use this context to query and save instances of product entities in the underlying database.
    /// Inherit from this class to configure entity mappings and database behavior specific to product data.</remarks>
   public class ProductDbContext  : DbContext
    {
        //dbset
        public DbSet<Product> TblProduct { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-MGNUF0MQ\SQLEXPRESS;Database=crud;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    }
}
