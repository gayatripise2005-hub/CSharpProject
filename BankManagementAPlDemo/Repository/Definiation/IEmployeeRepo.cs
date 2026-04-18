using BankManagementAPlDemo.Model;

namespace BankManagementAPlDemo.Repository.Definiation
{
    public interface IEmployeeRepo
    {
        //List<Employee> GetAll();
        PagedResult<Employee> GetAll(int pageIndex, int pageSize);
        Employee GetById(int id);
        Employee Add(Employee employee);
        bool Delete(int id);
        Employee Update(Employee employee);
    }
}
