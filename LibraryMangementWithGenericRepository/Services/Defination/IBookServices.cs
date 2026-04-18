using LibraryMangementWithGenericRepository.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementWithGenericRepository.Services.Defination
{
    public interface IBookServices
    {
        Task<Book> AddAsync(Book book);
        Task<IList<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(int id);
        Task<Book> UpdateAsync(Book book);
        Task<bool> DeleteAsync(int id);
    }
}
