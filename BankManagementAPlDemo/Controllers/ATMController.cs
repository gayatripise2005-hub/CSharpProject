
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Service.Definiation;
using Microsoft.AspNetCore.Mvc;

namespace BankManagementAPlDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ATMController : ControllerBase
    {
        private readonly IATMService _service;

        public ATMController(IATMService service)
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
            var atm = _service.GetById(id);
            return Ok(atm);
        }

        [HttpPost]
        public IActionResult Create(ATM atm)
        {
            var created = _service.Add(atm);
            return Ok(created);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ATM atm)
        {
            atm.ATMId = id;
            var updated = _service.Update(atm);
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