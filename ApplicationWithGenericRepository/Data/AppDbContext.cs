using ApplicationWithGenericRepository.Entity.Liabary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationWithGenericRepository.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> TblBook { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-MGNUF0MQ\SQLEXPRESS;Database=crud;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
