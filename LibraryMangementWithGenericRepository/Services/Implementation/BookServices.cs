using LibraryMangementWithGenericRepository.Entity.Model;
using LibraryMangementWithGenericRepository.Repositories.Defination;
using LibraryMangementWithGenericRepository.Services.Defination;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementWithGenericRepository.Services.Implementation
{
    public class BookServices :IBookServices
    {
        private readonly IRepository<Book> _repo;

        public BookServices(IRepository<Book> repo)
        {
            _repo = repo;
        }

        public async Task<Book> AddAsync(Book book)
        {
            if (book == null || string.IsNullOrWhiteSpace(book.Name))
                throw new Exception("Invalid Book");

            return await _repo.CreateAsync(book);
        }

        public async Task<IList<Book>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task<Book> UpdateAsync(Book book)
        {
            var existing = await _repo.GetByIdAsync(book.Id);
            if (existing == null) throw new Exception("Book not found");

            existing.Name = book.Name;
            existing.Author = book.Author;

            return await _repo.UpdateAsync(existing);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity == null) return false;

            return await _repo.DeleteAsync(entity);
        }
    }
}
