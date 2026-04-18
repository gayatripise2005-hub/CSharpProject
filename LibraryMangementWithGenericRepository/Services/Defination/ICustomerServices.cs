using LibraryMangementWithGenericRepository.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementWithGenericRepository.Services.Defination
{
    public interface ICustomerServices
    {
        Task<Customer> AddAsync(Customer c);
        Task<IList<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);
        Task<Customer> UpdateAsync(Customer c);
        Task<bool> DeleteAsync(int id);
    }
}
