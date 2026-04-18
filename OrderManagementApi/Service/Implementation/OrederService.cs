using OrderManagementApi.Entity.model;
using OrderManagementApi.Repository;
using OrderManagementApi.Service.Definition;
using System;
using System.Collections.Generic;

namespace OrderManagementApi.Service.Implementation
{
    public class OrederService : IOrderService
    {
        private readonly IRepository<Order> _repository;

        public OrederService(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public Order Add(Order order)
        {
            if (order == null)
                throw new ArgumentException("Order cannot be null");

            if (string.IsNullOrEmpty(order.OrderNumber))
                throw new ArgumentException("Order number cannot be null or empty");

            if (order.Amount <= 0)
                throw new ArgumentException("Order amount must be greater than zero");

            if (string.IsNullOrEmpty(order.Status))
                throw new ArgumentException("Order status cannot be null or empty");

            return _repository.Add(order);
        }

        public bool Delete(int id)
        {
            var existing = _repository.GetById(id);

            if (existing == null)
                throw new Exception("Order not found");
            _repository.Delete(existing);

            return true;
        }
        public List<Order> GetAll()
        {
            return _repository.GetAll();
        }

        public Order GetById(int id)
        {
            var order = _repository.GetById(id);

            if (order == null)
                throw new Exception("Order not found");

            return order;
        }

        public Order Update(Order order)
        {
            if (order == null)
                throw new ArgumentException("Order cannot be null");
            var existing = _repository.GetById(order.Id);

            if (existing == null)
                throw new Exception("Order not found");

            order.Id = existing.Id;

            _repository.Update(order);

            return order;
        }
    }
}
