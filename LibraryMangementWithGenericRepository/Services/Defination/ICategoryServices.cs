using LibraryMangementWithGenericRepository.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementWithGenericRepository.Services.Defination
{
    public interface ICategoryservices
    {
        Task<Category> AddAsync(Category category);
        Task<IList<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task<Category> UpdateAsync(Category category);
        Task<bool> DeleteAsync(int id);
            

    }
}
