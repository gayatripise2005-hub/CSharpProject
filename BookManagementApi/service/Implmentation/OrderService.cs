using BookManagementApi.Entity;
using BookManagementApi.Repository;
using BookManagementApi.service.Definition;

namespace BookManagementApi.service.Implmentation
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _repository;

        public OrderService(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public async Task<List<Order>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Order> GetById(int id)
        {
            var order = await _repository.GetById(id);

            if (order == null)
                throw new Exception("Order not found");

            return order;
        }

        public async Task<Order> Add(Order order)
        {
            if (order == null)
                throw new Exception("Invalid Order");

            if (string.IsNullOrWhiteSpace(order.OrderNumber))
                throw new ArgumentException("Order number is required");

            if (string.IsNullOrWhiteSpace(order.CustomerName))
                throw new ArgumentException("Customer name is required");

            if (string.IsNullOrWhiteSpace(order.BookTitle))
                throw new ArgumentException("Book title is required");

            await _repository.Add(order);
            return order;
        }

        public async Task<Order> Update(Order order)
        {
            if (order == null)
                throw new Exception("Invalid Order");

            var existing = await _repository.GetById(order.Id);

            if (existing == null)
                throw new Exception("Order not found");

            await _repository.Update(order);
            return order;
        }

        public async Task<bool> Delete(int id)
        {
            var existing = await _repository.GetById(id);

            if (existing == null)
                throw new Exception("Order not found");

            await _repository.Delete(id);
            return true;
        }
    }
}
