using Microsoft.AspNetCore.Mvc;
using OrderManagementApi.Entity.model;
using OrderManagementApi.Service.Definition;
using OrderManagementApi.Service.Implementation;

namespace OrderManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerSerivce _service;

        public CustomerController(ICustomerSerivce service)
        {
            _service = service;
        }

        
        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] Customer c)
        {
            if (c == null)
                return BadRequest("Invalid Request");

            var data = _service.Add(c);

            return Ok(new
            {
                Data = data,
                Message = "Customer Added Successfully"
            });
        }

       
        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var data = _service.GetAll();
            return Ok(data);
        }

       
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var data =  _service.GetById(id);

            if (data == null)
                return NotFound("Customer Not Found");

            return Ok(data);
        }

       
        [HttpPut]
        public async Task<IActionResult> UpdateCustomer([FromBody] Customer c)
        {
            if (c == null)
                return BadRequest("Invalid Request");

            var result =  _service.Update(c);

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
            var result = _service.Delete(id);

            if (!result)
                return NotFound("Customer Not Found");

            return Ok("Customer Deleted Successfully");
        }
    }
}