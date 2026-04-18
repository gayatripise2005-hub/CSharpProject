using Microsoft.EntityFrameworkCore;
using ProductManagement.Data;
using ProductManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Repository
{
    /// <summary>
    /// Provides methods for managing products in the database, including adding, updating, deleting, and retrieving
    /// product information.
    /// </summary>
    /// <remarks>This repository encapsulates data access logic for products, supporting asynchronous
    /// operations for add and update methods. Methods are designed to validate input parameters and return operation
    /// results indicating success or failure. Thread safety is not guaranteed; callers should ensure appropriate
    /// synchronization if accessing the repository from multiple threads concurrently.</remarks>
    public class ProductRepository
    {

        #region Db  Methods
        /// <summary>
        /// Asynchronously adds a new product to the database.
        /// </summary>
        /// <param name="p">The product to add. The product's Name property must not be null or empty.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is <see langword="true"/> if the product
        /// was added successfully; otherwise, <see langword="false"/>.</returns>
        public async Task<bool> AddProduct(Product p)
        {
            if (p == null)
                return false;
            if(string.IsNullOrEmpty(p.Name))
                return false;
            using (var context = new ProductDbContext())
            {
               await context.TblProduct.AddAsync(p);
              return  (await context.SaveChangesAsync()>0);
            }
        }

        /// <summary>
        /// Updates the details of an existing product with the specified identifier.
        /// </summary>
        /// <remarks>The method does not update the product if the specified identifier does not exist or
        /// if the provided product data is null. No changes are made if the product is not found.</remarks>
        /// <param name="id">The unique identifier of the product to update. Must be a non-zero value.</param>
        /// <param name="p">The product data containing the updated values. Cannot be null.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is <see langword="true"/> if the product
        /// was successfully updated; otherwise, <see langword="false"/>.</returns>
        public async Task<bool> UpdateProduct(int id , Product p)
        {
            if(id == 0)
                return false;
            if (p == null)
                return false;
            using (var context = new ProductDbContext())
            {
                var product = context.TblProduct.FirstOrDefault(x => x.Id == id);

                if (product == null)
                    return false;
                product.Name = p.Name;
                product.Price = p.Price;
                product.Quantity = p.Quantity;
                context.TblProduct.Update(product);
                return (await context.SaveChangesAsync() > 0);
            }
        }

        /// <summary>
        /// Deletes the product with the specified identifier from the database.
        /// </summary>
        /// <remarks>If no product with the specified identifier exists, the method returns <see
        /// langword="false"/> and no changes are made to the database.</remarks>
        /// <param name="id">The unique identifier of the product to delete. Must be a non-zero value.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is <see langword="true"/> if the product
        /// was found and deleted; otherwise, <see langword="false"/>.</returns>
        public async Task<bool> DeleteProduct(int id)
        {
           if(id == 0)
                return false;
            using (var context = new ProductDbContext())
            {
                var product = context.TblProduct.FirstOrDefault(x => x.Id == id);
                if (product == null)
                    return false;
                context.TblProduct.Remove(product);
                return (await context.SaveChangesAsync() > 0);
            }
        }
        public async Task<List<Product>> GetAllProduct(int page = 0, int pageSize = 10, string search = "")
        {
            using (var context = new ProductDbContext())
            {
               var query = context.TblProduct.AsQueryable();
                if(!string.IsNullOrWhiteSpace(search))
                     query.Where(x=> x.Name == search);

                query=query.Skip(page * pageSize).Take(pageSize);

                return await query.ToListAsync();
            }
            
        }
        public async Task<Product> GetProductById(int id)
        {
           using(var context = new ProductDbContext())
            {
                return await context.TblProduct.FirstOrDefaultAsync(x => x.Id == id);
            }
        }
        #endregion

    }
}
