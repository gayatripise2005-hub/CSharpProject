using CafeManagementSystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.Service.Definition
{
    public interface IChefsService
    {
        Task<Chefs> AddAsync(Chefs chefs);
        Task<List<Chefs>> GetAllAsync();
        Task<Chefs>   GetByIdAsync(int id);
        Task<Chefs> UpdateAsync(Chefs chefs);
        Task <bool> DeleteAsync(int id);
    }
}
