using BookManagementApi.Entity;

namespace BookManagementApi.service.Definition
{
    public interface IOrderService
    {
        Task<List<Order>> GetAll();
        Task<Order> GetById(int id);
        Task<Order> Add(Order order);
        Task<Order> Update(Order order);
        Task<bool> Delete(int id);
    }
}
