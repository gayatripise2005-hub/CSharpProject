
using ProductManagementApi.Data;
using ProductManagementApi.Entity.Model;
using ProductManagementApi.Service.Definition;

namespace ProductManagementApi.Service.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }

        public Category Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public Category Update(Category category)
        {
            var existing = _context.Categories.Find(category.Id);

            if (existing == null)
                return null;

            existing.Name = category.Name;

            _context.SaveChanges();
            return existing;
        }

        public bool Delete(int id)
        {
            var existing = _context.Categories.Find(id);

            if (existing == null)
                return false;

            _context.Categories.Remove(existing);
            _context.SaveChanges();
            return true;
        }
    }
}