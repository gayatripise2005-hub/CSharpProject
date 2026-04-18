
using BookManagementApi.Data;
using BookManagementApi.Entity;
using Microsoft.EntityFrameworkCore;

namespace BookManagementApi.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
            await Task.CompletedTask;
        }

        public async Task Delete(int id)
        {
            var data = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

            if (data != null)
            {
                _dbSet.Remove(data);
            }
        }
    }
}

