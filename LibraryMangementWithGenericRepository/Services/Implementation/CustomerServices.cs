using LibraryMangementWithGenericRepository.Entity.Model;
using LibraryMangementWithGenericRepository.Repositories.Defination;
using LibraryMangementWithGenericRepository.Services.Defination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementWithGenericRepository.Services.Implementation
{
    public class CustomerServices : ICustomerServices
    {
        private readonly IRepository<Customer> _repo;

        public CustomerServices(IRepository<Customer> repo)
        {
            _repo = repo;
        }

        public Task<Customer> AddAsync(Customer c) => _repo.CreateAsync(c);

        public Task<IList<Customer>> GetAllAsync() => _repo.GetAllAsync();

        public Task<Customer> GetByIdAsync(int id) => _repo.GetByIdAsync(id);

        public async Task<Customer> UpdateAsync(Customer c)
        {
            var existing = await _repo.GetByIdAsync(c.Id);
            if (existing == null) throw new Exception("Customer not found");

            existing.Name = c.Name;
            existing.Phone = c.Phone;
            existing.email = c.email;

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
