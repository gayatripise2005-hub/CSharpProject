using LibraryMangementWithGenericRepository.Entity.Model;
using LibraryMangementWithGenericRepository.Repositories.Defination;
using LibraryMangementWithGenericRepository.Services.Defination;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementWithGenericRepository.Services.Implementation
{
    public class CategoryService : ICategoryservices
    {
        private readonly IRepository<Category> _repo;

        public CategoryService(IRepository<Category> repo)
        {
            _repo = repo;
        }

        public Task<Category> AddAsync(Category c) => _repo.CreateAsync(c);

        public Task<IList<Category>> GetAllAsync() => _repo.GetAllAsync();

        public Task<Category> GetByIdAsync(int id) => _repo.GetByIdAsync(id);

        public async Task<Category> UpdateAsync(Category c)
        {
            var existing = await _repo.GetByIdAsync(c.Id);
            if (existing == null) throw new Exception("Category not found");

            existing.CategoryName = c.CategoryName;
            existing.Description = c.Description;

            return await _repo.UpdateAsync(existing);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data == null) return false;

            return await _repo.DeleteAsync(data);
        }
    }
}
