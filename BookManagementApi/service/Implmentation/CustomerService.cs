
using BookManagementApi.Entity;
using BookManagementApi.Repository;
using BookManagementApi.service.Definition;

namespace BookManagementApi.service.Implmentation
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _repository;

        
        public CustomerService(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task<List<Customer>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Customer> GetById(int id)
        {
            var customer = await _repository.GetById(id);

            if (customer == null)
                throw new Exception("Customer not found");

            return customer;
        }

        public async Task<Customer> Add(Customer customer)
        {
            if (customer == null)
                throw new Exception("Invalid Customer");

            if (string.IsNullOrWhiteSpace(customer.Name))
                throw new ArgumentException("Name is required");

            if (string.IsNullOrWhiteSpace(customer.Email))
                throw new ArgumentException("Email is required");

            await _repository.Add(customer);
            return customer;
        }

        public async Task<Customer> Update(Customer customer)
        {
            if (customer == null)
                throw new Exception("Invalid Customer");

            var existing = await _repository.GetById(customer.Id);

            if (existing == null)
                throw new Exception("Customer not found");

            await _repository.Update(customer);
            return customer;
        }

        public async Task<bool> Delete(int id)
        {
            var existing = await _repository.GetById(id);

            if (existing == null)
                throw new Exception("Customer not found");

            await _repository.Delete(id);
            return true;
        }
    }
}