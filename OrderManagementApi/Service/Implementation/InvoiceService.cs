using OrderManagementApi.Entity.model;
using OrderManagementApi.Repository;
using OrderManagementApi.Service.Definition;
using System;
using System.Collections.Generic;

namespace OrderManagementApi.Service.Implementation
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IRepository<Invoice> _repository;

        public InvoiceService(IRepository<Invoice> repository)
        {
            _repository = repository;
        }

        public Invoice Add(Invoice invoice)
        {
            if (invoice == null)
                throw new Exception("Invalid invoice");

            if (invoice.OrderId <= 0)
                throw new Exception("OrderId must be greater than zero");

            if (invoice.FinalAmmount <= 0)
                throw new Exception("FinalAmmount must be greater than zero");

            if (invoice.InvoiceDate == default)
                throw new Exception("InvoiceDate is required");

            _repository.Add(invoice);

            return invoice;
        }

        public bool Delete(int id)
        {
            var existing = _repository.GetById(id);

            if (existing == null)
                throw new Exception("Invoice not found");
            _repository.Delete(existing);

            return true;
        }

        public List<Invoice> GetAll()
        {
            return _repository.GetAll();
        }

        public Invoice GetById(int id)
        {
            var invoice = _repository.GetById(id);

            if (invoice == null)
                throw new Exception("Invoice not found");
            return invoice;
        }

        public Invoice Update(Invoice invoice)
        {
          if (invoice == null)
                throw new ArgumentNullException(nameof(invoice));
          var existing = _repository.GetById(invoice.Id);

            if (existing == null)
                throw new Exception("Invoice not found");

            invoice.Id = existing.Id; 

            _repository.Update(invoice);
            return invoice;

        }
    }
}
