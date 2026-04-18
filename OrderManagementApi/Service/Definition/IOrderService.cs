using OrderManagementApi.Entity.model;

namespace OrderManagementApi.Service.Definition
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetById(int id);
        Order Add(Order order);
        Order Update(Order order);
        bool Delete(int id);
    }
}
