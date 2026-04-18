
using BankManagementAPlDemo.Service.Definiation;
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Repository.Definiation;

namespace BankManagementAPlDemo.Service.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepo _repository;

        public EmployeeService(IEmployeeRepo repository)
        {
            _repository = repository;
        }

        
        public PagedResult<Employee> GetAll(int pageIndex, int pageSize)
        {
            if (pageSize > 50)
                pageSize = 50;

            return _repository.GetAll(pageIndex, pageSize);
        }

        public Employee GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid Employee Id");

            var employee = _repository.GetById(id);

            if (employee == null)
                throw new Exception("Employee not found");

            return employee;
        }

        public Employee Add(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            if (string.IsNullOrWhiteSpace(employee.Name))
                throw new Exception("Name is required");

            if (employee.Salary < 0)
                throw new Exception("Invalid salary amount");

            // 🔥 IMPORTANT CHANGE
            var all = _repository.GetAll(0, int.MaxValue).Items;

            if (all.Any(x => x.Name.ToLower() == employee.Name.ToLower()))
                throw new Exception("Employee with this name already exists");

            return _repository.Add(employee);
        }

        public Employee Update(Employee employee)
        {
            if (employee.EmployeeId <= 0)
                throw new Exception("Invalid Employee Id");

            var existing = _repository.GetById(employee.EmployeeId);

            if (existing == null)
                throw new Exception("Employee not found");

            if (string.IsNullOrWhiteSpace(employee.Name))
                throw new Exception("Name is required");

            if (employee.Salary < 0)
                throw new Exception("Invalid salary amount");


            var all = _repository.GetAll(0, int.MaxValue).Items;

            if (all.Any(x => x.EmployeeId != employee.EmployeeId &&
                             x.Name.ToLower() == employee.Name.ToLower()))
                throw new Exception("Another employee with this name already exists");

            return _repository.Update(employee);
        }

        public bool Delete(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid Employee Id");

            var existing = _repository.GetById(id);

            if (existing == null)
                throw new Exception("Employee not found");

            return _repository.Delete(id);
        }
    }
}