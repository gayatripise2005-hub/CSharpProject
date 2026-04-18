
using ProductManagementApi.Data;
using ProductManagementApi.Entity.Model;
using ProductManagementApi.Repository;
using ProductManagementApi.Service.Definition;

namespace ProductManagementApi.Service.Implementation
{
    public class BrandService : IBrandService
    {
        private readonly IRepository<Brand> _context;

        public BrandService(IRepository<Brand> context)
        {
            _context = context;
        }

        public async List<Brand> GetAll()
        {
            return await _context.GetAllAsync();
        }

        public Brand GetById(int id)
        {
            return _context.Brands.FirstOrDefault(b => b.Id == id);
        }

        public Brand Add(Brand brand)
        {
            _context.Brands.Add(brand);
            _context.SaveChanges();
            return brand;
        }

        public Brand Update(Brand brand)
        {
            var existing = _context.Brands.Find(brand.Id);

            if (existing == null)
                return null;

            existing.Name = brand.Name;

            _context.SaveChanges();
            return existing;
        }

        public bool Delete(int Id)
        {
            var existing = _context.Brands.Find(Id);

            if (existing == null)
                return false;

            _context.Brands.Remove(existing);
            _context.SaveChanges();
            return true;
        }
    }
}