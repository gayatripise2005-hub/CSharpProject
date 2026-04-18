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
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _repository;

        public CustomerService(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task<Customer> AddAsync(Customer customer)
        {
            if (customer == null || string.IsNullOrWhiteSpace(customer.Name) || string.IsNullOrWhiteSpace(customer.PhoneNumber))
            {
                Console.WriteLine("Invalid Customer Data");
            }

            return await _repository.AddAsync(customer);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var record = await _repository.GetByIdAsync(id);
            if (record == null)
                return false;

            return await _repository.DeleteAsync(record);
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return (List<Customer>)await _repository.GetAllAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Customer> UpdateAsync(Customer customer)
        {
            var existing = await _repository.GetByIdAsync(customer.Id);
            if (existing == null)
                return null;

            existing.Name = customer.Name;
            existing.PhoneNumber = customer.PhoneNumber;

            return await _repository.UpdateAsync(existing);
        }
    }
}
