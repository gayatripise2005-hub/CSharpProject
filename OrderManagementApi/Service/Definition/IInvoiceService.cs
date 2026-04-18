using OrderManagementApi.Entity.model;

namespace OrderManagementApi.Service.Definition
{
    public interface IInvoiceService
    {
        List<Invoice> GetAll();
        Invoice GetById(int id);
       Invoice Add(Invoice invoice);
       Invoice Update(Invoice invoice);
        bool Delete(int id);
    }
}
