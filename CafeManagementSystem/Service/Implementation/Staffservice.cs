using CafeManagementSystem.Entity.Model;
using CafeManagementSystem.Repository.Definition;
using CafeManagementSystem.Repository.Implementation;
using CafeManagementSystem.Service.Definition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.Service.Implementation
{
    internal class Staffservice : IStaffService
    {

        private readonly IRepository<Staff> _repository;

        public Staffservice(IRepository<Staff> repository)
        {
            _repository = repository;
        }

        public async Task<Staff> AddAsync(Staff staff)
        {
            if (staff == null || string.IsNullOrWhiteSpace(staff.Name))
            {
                Console.WriteLine("Invalid Staff Data");
            }

            return await _repository.AddAsync(staff);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var record = await _repository.GetByIdAsync(id);
            if (record == null)
                return false;

            return await _repository.DeleteAsync(record);
        }

        public async Task<List<Staff>> GetAllAsync()
        {
            return (List<Staff>)await _repository.GetAllAsync();
        }

        public async Task<Staff> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Staff> UpdateAsync(Staff staff)
        {
            var existing = await _repository.GetByIdAsync(staff.Id);
            if (existing == null)
                return null;

            existing.Name = staff.Name;

            return await _repository.UpdateAsync(existing);
        }
    }
}
