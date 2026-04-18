
using Microsoft.AspNetCore.Http;
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Service.Definiation;
using Microsoft.AspNetCore.Mvc;

namespace BankManagementAPlDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountservice;

        public AccountController(IAccountService accountservice)
        {
            _accountservice = accountservice;
        }

        
        [HttpGet]
        public IActionResult GetAll(int pageIndex = 0, int pageSize = 3)
        {
            var result = _accountservice.GetAll(pageIndex, pageSize);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var account = _accountservice.GetById(id);
            return Ok(account);
        }

        [HttpPost]
        public IActionResult Create(Account account)
        {
            var created = _accountservice.Add(account);
            return Ok(created);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Account account)
        {
            account.AccountId = id;
            var updated = _accountservice.Update(account);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _accountservice.Delete(id);
            return Ok("Deleted Successfully");
        }
    }
}