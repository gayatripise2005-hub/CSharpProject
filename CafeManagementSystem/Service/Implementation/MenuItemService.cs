using CafeManagementSystem.Entity.Model;
using CafeManagementSystem.Repository.Definition;
using CafeManagementSystem.Service.Definition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.Service.Implementation
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IRepository<MenuItem> _repository;

        public MenuItemService(IRepository<MenuItem> repository)
        {
            _repository = repository;
        }

        public async Task<MenuItem> AddAsync(MenuItem item)
        {
            if (item == null || string.IsNullOrWhiteSpace(item.Name))
            {
                Console.WriteLine("Invalid Menu Item");
            }

            return await _repository.AddAsync(item);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var record = await _repository.GetByIdAsync(id);
            if (record == null)
                return false;

            return await _repository.DeleteAsync(record);
        }

        public async Task<List<MenuItem>> GetAllAsync()
        {
            return (List<MenuItem>)await _repository.GetAllAsync();
        }

        public async Task<MenuItem> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<MenuItem> UpdateAsync(MenuItem item)
        {
            var existing = await _repository.GetByIdAsync(item.Id);
            if (existing == null)
                return null;

            existing.Name = item.Name;
            existing.Price = item.Price;

            return await _repository.UpdateAsync(existing);
        }


    }
}
