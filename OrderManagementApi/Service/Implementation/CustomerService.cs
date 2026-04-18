
using OrderManagementApi.Entity.model;
using OrderManagementApi.Repository;
using OrderManagementApi.Service.Definition;
using System;
using System.Collections.Generic;

namespace OrderManagementApi.Service.Implementation
{
    public class CustomerService : ICustomerSerivce
    {
        private readonly IRepository<Customer> _repo;

        public CustomerService(IRepository<Customer> repo)
        {
            _repo = repo;
        }

        public List<Customer> GetAll()
        {
            return _repo.GetAll();
        }

        public Customer GetById(int id)
        {
            var data = _repo.GetById(id);
            if (data == null)
                throw new Exception("Customer not found");

            return data;
        }

        public Customer Add(Customer customer)
        {
            if (customer == null)
                throw new Exception("Invalid customer");

            if (string.IsNullOrEmpty(customer.Phone))
                throw new Exception("Customer phone is required");

            if (string.IsNullOrEmpty(customer.Address))
                throw new Exception("Customer address is required");

            if (string.IsNullOrEmpty(customer.Name))
                throw new Exception("Customer name is required");

            _repo.Add(customer);
            return customer;
        }

        public Customer Update(Customer customer)
        {
            if (customer == null)
                throw new Exception("Invalid customer");

            var existing = _repo.GetById(customer.Id);
            if (existing == null)
                throw new Exception("Customer not found");

            _repo.Update(customer);
            return customer;
        }

        public bool Delete(int id)
        {
            var existing = _repo.GetById(id);
            if (existing == null)
                throw new Exception("Customer not found");

            _repo.Delete(existing);
            return true;
        }
    }
}