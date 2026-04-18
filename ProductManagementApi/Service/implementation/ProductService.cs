using ProductManagementApi.Data;
using ProductManagementApi.Entity.Model;
using ProductManagementApi.Service.Definition;

namespace ProductManagementApi.Service.Implementation
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public Product Update(Product product)
        {
            var existing = _context.Products.Find(product.Id);

            if (existing == null)
                return null;

            existing.Name = product.Name;
            existing.Price = product.Price;
            existing.Quantity = product.Quantity;

            _context.SaveChanges();
            return existing;
        }

        public bool Delete(int id)
        {
            var existing = _context.Products.Find(id);

            if (existing == null)
                return false;

            _context.Products.Remove(existing);
            _context.SaveChanges();
            return true;
        }
    }
}