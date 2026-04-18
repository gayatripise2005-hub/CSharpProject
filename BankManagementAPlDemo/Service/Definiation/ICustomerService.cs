using BankManagementAPlDemo.Model;

namespace BankManagementAPlDemo.Service.Definiation
{
    public interface ICustomerService
    {
        //List<Customer> GetAll();
        PagedResult<Customer> GetAll(int pageIndex, int pageSize);
        Customer GetById(int id);
        Customer Add(Customer customer);
        Customer Update(Customer customer);
        bool Delete(int id);
    }
}
