using CafeManagementSystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.Service.Definition
{
    public interface IStaffService
    {
        Task<Staff> AddAsync(Staff staff);
        Task<List<Staff>> GetAllAsync();
        Task<Staff> GetByIdAsync(int id);
        Task<Staff> UpdateAsync(Staff staff);
        Task<bool> DeleteAsync(int id);
    }
}
