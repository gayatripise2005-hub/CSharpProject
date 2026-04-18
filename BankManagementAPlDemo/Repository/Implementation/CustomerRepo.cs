using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Repository.Definiation;
using System.Collections.Generic;
using System.Linq;

namespace BankManagementAPlDemo.Repository.Implementation
{
    public class CustomerRepo : ICustomerRepo
    {
        private static List<Customer> customers = new List<Customer>();


        //public List<Customer> GetAll()
        //{
        //    return customers;
        //}
        public PagedResult<Customer> GetAll(int pageIndex, int pageSize)
        {
            var totalCount = customers.Count;

            var items = customers
                .Skip(pageIndex * pageSize) 
                .Take(pageSize)
                .ToList();

            return new PagedResult<Customer>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalCount = totalCount,
                Items = items
            };
        }


        public Customer GetById(int id)
        {
            return customers.FirstOrDefault(x => x.CustomerId == id);
        }

       
        public Customer Add(Customer customer)
        {
            customer.CustomerId = customers.Count + 1;
            customers.Add(customer);
            return customer;
        }

        
        public Customer Update(Customer customer)
        {
            var existing = customers.FirstOrDefault(x => x.CustomerId == customer.CustomerId);

            if (existing != null)
            {
                existing.Name = customer.Name;
                existing.Email = customer.Email;
                existing.Phone = customer.Phone;
            }

            return existing;
        }

    
        public bool Delete(int id)
        {
            var customer = customers.FirstOrDefault(x => x.CustomerId == id);

            if (customer != null)
            {
                customers.Remove(customer);
                return true;
            }

            return false;
        }
    }
}