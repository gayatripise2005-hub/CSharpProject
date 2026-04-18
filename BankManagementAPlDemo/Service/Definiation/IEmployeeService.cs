using BankManagementAPlDemo.Model;

namespace BankManagementAPlDemo.Service.Definiation
{
    public interface IEmployeeService
    {
        //List<Employee> GetAll();
        PagedResult<Employee> GetAll(int pageIndex, int pageSize);
        Employee GetById(int id);
        Employee Add(Employee employee);
        Employee Update(Employee employee);
        bool Delete(int id);
    }
}
