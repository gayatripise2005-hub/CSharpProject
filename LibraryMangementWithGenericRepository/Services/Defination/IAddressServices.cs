using LibraryMangementWithGenericRepository.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementWithGenericRepository.Services.Defination
{
    public interface IAddressServices
    {
        Task<Address> AddAsync(Address address);
        Task<IList<Address>> GetAllAsync();
        Task<Address> GetByIdAsync(int id);
        Task<Address> UpdateAsync(Address address);
        Task<bool> DeleteAsync(int id);
    }
}

