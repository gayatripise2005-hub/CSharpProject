
using CafeManagementSystem.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> TblCustomer { get; set; }
        public DbSet<Staff> TblStaff { get; set; }

        public DbSet<Chefs> TblChefs { get; set; }

        public DbSet<MenuItem> TblMenuItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-MGNUF0MQ\SQLEXPRESS;Database=CafeManagement;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
