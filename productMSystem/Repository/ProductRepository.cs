using Microsoft.EntityFrameworkCore;
using productMSystem.Data;
using productMSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productMSystem.Repository
{
    public class ProductRepository
    {
        public async Task<bool> AddProduct(Product p)
        {
            if (p == null)
                return false;
            if (string.IsNullOrEmpty(p.Name))
                return false;
            using (var context = new ProductDbContext())
            {
                await context.TblProduct.AddAsync(p);
                return (await context.SaveChangesAsync() > 0);
            }
        }
        public async Task<bool> UpdateProduct(int id, Product p)
        {
            if (id == 0)
                return false;
            if (p == null)
                return false;
            using (var context = new ProductDbContext())
            {
                var product = await context.TblProduct.FindAsync(id);
                if (product == null)
                    return false;
                product.Name = p.Name;
                product.Quantity = p.Quantity;
                product.Price = p.Price;
                product.Description = p.Description;
                context.TblProduct.Update(product);
                return (await context.SaveChangesAsync() > 0);
            }
        }
        public async Task<bool> DeleteProduct(int id)
        {
            if (id == 0)
                return false;
            using (var context = new ProductDbContext())
            {

                var product = context.TblProduct.FirstOrDefault(x=> x.Id == id);  
                if (product == null)
                    return false;
                context.TblProduct.Remove(product);
                return (await context.SaveChangesAsync() > 0);
            }
        }
        public async Task<List<Product>> GetAllProducts(int page =0, int pageSize=10, string search = "")
        {
            using (var context = new ProductDbContext())
            {
                var query = context.TblProduct.AsQueryable();
                if (!string.IsNullOrWhiteSpace(search))
                    query.Where(x => x.Name == search);
                
                query = query.Skip(page * pageSize).Take(pageSize);

                return await query.ToListAsync();

            }

        }
        public  async Task<Product> GetProductById(int id)
        {
            using (var context = new ProductDbContext())
            {
                return await context.TblProduct.FirstOrDefaultAsync(x => x.Id == id);   
            }
        }
           
            
    }
}
