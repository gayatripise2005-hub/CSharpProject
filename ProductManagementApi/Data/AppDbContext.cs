using Microsoft.EntityFrameworkCore;
using ProductManagementApi.Entity.Model;

namespace ProductManagementApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Brand> Brands {  get; set; }
        public DbSet<Product> Products { get;  set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }




    }
 }
