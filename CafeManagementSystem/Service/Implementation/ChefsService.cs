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
    public class ChefsService : IChefsService
    {
        private readonly IRepository<Chefs> _repository;

        public ChefsService(IRepository<Chefs> repository)
        {
            _repository = repository;
        }

        public async Task<Chefs> AddAsync(Chefs chefs)
        {
            if (chefs == null ||
                string.IsNullOrWhiteSpace(chefs.Name) ||
                string.IsNullOrWhiteSpace(chefs.Speciality))
                
            {
                Console.WriteLine("Invalid Chef Data");
            }

            return await _repository.AddAsync(chefs);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var record = await _repository.GetByIdAsync(id);
            if (record == null)
                return false;

            return await _repository.DeleteAsync(record);
        }

        public async Task<List<Chefs>> GetAllAsync()
        {
            return (List<Chefs>)await _repository.GetAllAsync();
        }

        public async Task<Chefs> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Chefs> UpdateAsync(Chefs chefs)
        {
            var existing = await _repository.GetByIdAsync(chefs.Id);
            if (existing == null)
                return null;

            existing.Name = chefs.Name;
            existing.Speciality = chefs.Speciality;
            

            return await _repository.UpdateAsync(existing);
        }
    }
}
