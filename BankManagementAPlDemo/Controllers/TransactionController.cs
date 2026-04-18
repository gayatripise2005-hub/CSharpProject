
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Service.Definiation;
using Microsoft.AspNetCore.Mvc;

namespace BankManagementAPlDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _Service;

        public TransactionController(ITransactionService Service)
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
            var transaction = _Service.GetById(id);
            return Ok(transaction);
        }

        [HttpPost]
        public IActionResult Create(Transaction transaction)
        {
            var created = _Service.Add(transaction);
            return Ok(created);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Transaction transaction)
        {
            transaction.TransactionId = id;
            var updated = _Service.Update(transaction);
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