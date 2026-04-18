using ProductManagment.Entity;

namespace ProductManagment.Repositories.Defination
{
    public interface IRepository<T> where T : BaseEntity 
    {
        Task<T?> GetByIdAsync(long id);
   
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
      
        Task DeleteAsync(T entity);

        //get all entities with Pagination 

        Task<IEnumerable<T>> GetAllAsync(int page=1 , int pageSize=10);

    }
}
