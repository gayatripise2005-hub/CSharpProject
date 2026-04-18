using ProductManagementApi.Data;
using ProductManagementApi.Entity.Model;
using ProductManagementApi.Service.Definition;

namespace ProductManagementApi.Service.Implementation
{
    public class SupplierService : ISupplierService
    {
        private readonly AppDbContext _context;

        public SupplierService(AppDbContext context)
        {
            _context = context;
        }

        public List<Supplier> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public Supplier GetById(int id)
        {
            return _context.Suppliers.FirstOrDefault(s => s.Id == id);
        }

        public Supplier Add(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
            return supplier;
        }

        public Supplier Update(Supplier supplier)
        {
            var existing = _context.Suppliers.Find(supplier.Id);

            if (existing == null)
                return null;

            existing.Name = supplier.Name;

            _context.SaveChanges();
            return existing;
        }

        public bool Delete(int id)
        {
            var existing = _context.Suppliers.Find(id);

            if (existing == null)
                return false;

            _context.Suppliers.Remove(existing);
            _context.SaveChanges();
            return true;
        }
    }
}