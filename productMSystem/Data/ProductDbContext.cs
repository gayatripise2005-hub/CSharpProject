using Microsoft.EntityFrameworkCore;
using productMSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productMSystem.Data
{
    public class ProductDbContext : DbContext
    {
            //dbset
            public DbSet<Product> TblProduct { get; set; }
            public DbSet<Category> TblCategory { get; set; }
            public DbSet<Customer> TblCustomer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=LAPTOP-MGNUF0MQ\SQLEXPRESS;Database=ProductDb;Trusted_Connection=True;TrustServerCertificate=True;");
            }

        
    }
}
