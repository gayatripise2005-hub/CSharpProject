using Microsoft.EntityFrameworkCore;
using StudentWebApi.Entity;

namespace StudentWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> tblStudent { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            


        }
    }
}
