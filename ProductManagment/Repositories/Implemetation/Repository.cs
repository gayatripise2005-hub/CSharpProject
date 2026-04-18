using Microsoft.EntityFrameworkCore;
using ProductManagment.Data;
using ProductManagment.Entity;
using ProductManagment.Repositories.Defination;

namespace ProductManagment.Repositories.Implemetation
{
    //public class Repository
    //{
    //}
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T?> GetByIdAsync(long id)
        {
            return await _dbSet.FirstOrDefaultAsync( t => t.Id==id);
        }

        public async Task<T> AddAsync(T entity)
        {
           var entityEntry= await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entityEntry.Entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
           var entityEntry =  _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entityEntry.Entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(int page = 1, int pageSize = 10)
        {
            return await _dbSet
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }
    }

}
