using BookManagementApi.Entity;
using BookManagementApi.Entity.Model;
using Microsoft.EntityFrameworkCore;


namespace BookManagementApi.Data
{
    public class ApplicationDbContext :DbContext
    {

        public DbSet<Book> tblBook { get; set; }
        public DbSet<Customer> tblcustomer { get; set; }
        public DbSet<Order> tblorder { get; set; }
        public DbSet<Review> tblreview { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
