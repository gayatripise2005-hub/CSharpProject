using CafeManagementSystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.Service.Definition
{
    public interface IMenuItemService
    {
        Task<MenuItem> AddAsync(MenuItem item);
        Task<List<MenuItem>> GetAllAsync();
        Task<MenuItem> GetByIdAsync(int id);
        Task<MenuItem> UpdateAsync(MenuItem item);
        Task<bool> DeleteAsync(int id);
    }
}
