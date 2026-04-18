using OrderManagementApi.Entity;
namespace OrderManagementApi.Repository
{
    public interface IRepository <T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        T Add(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
