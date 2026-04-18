using OrderManagementApi.Entity.model;

namespace OrderManagementApi.Service.Definition
{
    public interface ICustomerSerivce
    {
        List<Customer > GetAll();
        Customer GetById(int id);
        Customer Add(Customer customer);

        Customer Update(Customer customer);
        bool Delete(int id);
    }
}
