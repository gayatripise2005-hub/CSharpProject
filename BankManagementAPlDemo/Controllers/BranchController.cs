
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Service.Definiation;

namespace BankManagementAPlDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchService _service;

        public BranchController(IBranchService service)
        {
            _service = service;
        }

        
        [HttpGet]
        public IActionResult GetAll(int pageIndex = 0, int pageSize = 3)
        {
            var result = _service.GetAll(pageIndex, pageSize);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var branch = _service.GetById(id);
            return Ok(branch);
        }

        [HttpPost]
        public IActionResult Create(Branch branch)
        {
            var created = _service.Add(branch);
            return Ok(created);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Branch branch)
        {
            branch.BranchId = id;
            var updated = _service.Update(branch);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _service.Delete(id);
            return Ok("Deleted Successfully");
        }
    }
}