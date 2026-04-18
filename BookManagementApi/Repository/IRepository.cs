
using BookManagementApi.Entity;

namespace BookManagementApi.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(int id);



    }
}