
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Repository.Definiation;

namespace BankManagementAPlDemo.Repository.Implementation
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private static List<Employee> employees = new List<Employee>();

        
        public PagedResult<Employee> GetAll(int pageIndex, int pageSize)
        {
            var totalCount = employees.Count;

            var items = employees
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToList();

            return new PagedResult<Employee>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalCount = totalCount,
                Items = items
            };
        }

        public Employee GetById(int id)
        {
            return employees.FirstOrDefault(x => x.EmployeeId == id);
        }

        public Employee Add(Employee employee)
        {
            employee.EmployeeId = employees.Count + 1;
            employees.Add(employee);
            return employee;
        }

        public Employee Update(Employee employee)
        {
            var existing = employees.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);

            if (existing != null)
            {
                existing.Name = employee.Name;
                existing.Role = employee.Role;
                existing.Salary = employee.Salary;
            }

            return existing;
        }

        public bool Delete(int id)
        {
            var employee = employees.FirstOrDefault(x => x.EmployeeId == id);

            if (employee != null)
            {
                employees.Remove(employee);
                return true;
            }

            return false;
        }
    }
}