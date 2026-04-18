using Microsoft.AspNetCore.Http;
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
        private readonly ICustomerSerivce _customerService;

        public CustomerController(ICustomerSerivce customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            try
            {
                var result = _customerService.Add(customer);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]

        public IActionResult Edit(Customer customer)
        {
            try
            {
                var result = _customerService.Update(customer);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = _customerService.Delete(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpPut]
        public IActionResult GetAll()
        {
            try
            {
                var result = _customerService.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = _customerService.GetById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
