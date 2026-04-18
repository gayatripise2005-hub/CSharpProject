using CafeManagementSystem.Data;
using CafeManagementSystem.Entity;
using CafeManagementSystem.Repository.Definition;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
       
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }


        public async Task<T> AddAsync(T entity)
        {
            var createEntity = await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return createEntity.Entity;
        }
        

        public async Task<bool> DeleteAsync(T entity)
        {
            var deleteEntity = _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return deleteEntity != null;
        }


        public async Task<IList<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }


        public async Task<T> GetByIdAsync(int id)
        {
           var entity = await _dbSet.FirstOrDefaultAsync(e=> e.Id == id);
            return entity;
        }


        public async Task<T> UpdateAsync(T entity)
        {
            var updateEntity = _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return updateEntity.Entity;
        }
    }
}