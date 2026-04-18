using Microsoft.AspNetCore.Mvc;
using BookManagementApi.Entity;
using BookManagementApi.service.Definition;

namespace BookManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

       
        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] Customer c)
        {
            if (c == null)
                return BadRequest("Invalid Request");

            var data = await _service.Add(c);

            return Ok(new
            {
                Data = data,
                Message = "Customer Added Successfully"
            });
        }

        
        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var data = await _service.GetById(id);

            if (data == null)
                return NotFound("Customer Not Found");

            return Ok(data);
        }

        
        [HttpPut]
        public async Task<IActionResult> UpdateCustomer([FromBody] Customer c)
        {
            if (c == null)
                return BadRequest("Invalid Request");

            var result = await _service.Update(c);

            if (result == null)
                return NotFound("Customer Not Found");

            return Ok(new
            {
                Data = result,
                Message = "Customer Updated Successfully"
            });
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var result = await _service.Delete(id);

            if (!result)
                return NotFound("Customer Not Found");

            return Ok("Customer Deleted Successfully");
        }
    }
}