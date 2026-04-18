using Microsoft.EntityFrameworkCore;
using ProductManagment.Entity.Products;

namespace ProductManagment.Data
{
    public class ApplicationDbContext : DbContext
    {
        #region Ctor
        /// <summary>
        /// Initializes a new instance of the ApplicationDbContext class using the specified options.
        /// </summary>
        /// <remarks>Use this constructor to configure the context with specific options, such as the
        /// database provider, connection string, or other context behaviors.</remarks>
        /// <param name="option">The options to be used by the DbContext. Must not be null.</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option) { }

        #endregion

        #region property 


        /// <summary>
        /// Gets or sets the collection of products in the database.
        /// </summary>
        public DbSet<Product> TblProduct { get; set; }

        /// <summary>
        /// Gets or sets the collection of product images in the database.
        /// </summary>
        public DbSet<ProductImage> TblProductImage { get; set; }
        #endregion
    }
}
