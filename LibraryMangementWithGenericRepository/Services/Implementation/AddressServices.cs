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
    public class AddressServices : IAddressServices
    {
        private readonly IRepository<Address> _repo;

        public AddressServices(IRepository<Address> repo)
        {
            _repo = repo;
        }

        public Task<Address> AddAsync(Address a) => _repo.CreateAsync(a);
        public Task<IList<Address>> GetAllAsync() => _repo.GetAllAsync();
        public Task<Address> GetByIdAsync(int id) => _repo.GetByIdAsync(id);

        public async Task<Address> UpdateAsync(Address a)
        {
            var existing = await _repo.GetByIdAsync(a.Id);
            if (existing == null) throw new Exception("Address not found");

            existing.City = a.City;
            existing.PinCode = a.PinCode;

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
