
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Service.Definiation;
using Microsoft.AspNetCore.Mvc;

namespace BankManagementAPlDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _Service;

        public EmployeeController(IEmployeeService Service)
        {
            _Service = Service;
        }

        
        [HttpGet]
        public IActionResult GetAll(int pageIndex = 0, int pageSize = 3)
        {
            var result = _Service.GetAll(pageIndex, pageSize);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var employee = _Service.GetById(id);
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            var created = _Service.Add(employee);
            return Ok(created);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Employee employee)
        {
            employee.EmployeeId = id;
            var updated = _Service.Update(employee);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _Service.Delete(id);
            return Ok("Deleted successfully");
        }
    }
}