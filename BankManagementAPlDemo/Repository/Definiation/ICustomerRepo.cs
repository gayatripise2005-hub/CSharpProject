using BankManagementAPlDemo.Model;

namespace BankManagementAPlDemo.Repository.Definiation
{
    public interface ICustomerRepo
    {
        
        PagedResult<Customer> GetAll(int pageIndex, int pageSize);
        Customer GetById(int id);
        Customer Add(Customer customer);
        bool Delete(int id);
        Customer Update(Customer customer);
    }
}
