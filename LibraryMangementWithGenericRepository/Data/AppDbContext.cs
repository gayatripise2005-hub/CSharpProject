using LibraryMangementWithGenericRepository.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementWithGenericRepository.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Address> TblAddress { get; set; }
        public DbSet<Book> TblBook { get; set; }
        public DbSet<Customer> TblCustomer { get; set; }
        public DbSet<Category> TblCategory { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-MGNUF0MQ\SQLEXPRESS;Database=libraryManagement;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }

    
}
