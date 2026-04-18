using Microsoft.AspNetCore.Mvc;
using BookManagementApi.Entity;
using BookManagementApi.service.Definition;

namespace BookManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        
        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] Order o)
        {
            if (o == null)
                return BadRequest("Invalid Request");

            var data = await _service.Add(o);

            return Ok(new
            {
                Data = data,
                Message = "Order Created Successfully"
            });
        }

       
        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var data = await _service.GetById(id);

            if (data == null)
                return NotFound("Order Not Found");

            return Ok(data);
        }

        
        [HttpPut]
        public async Task<IActionResult> UpdateOrder([FromBody] Order o)
        {
            if (o == null)
                return BadRequest("Invalid Request");

            var result = await _service.Update(o);

            if (result == null)
                return NotFound("Order Not Found");

            return Ok(new
            {
                Data = result,
                Message = "Order Updated Successfully"
            });
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var result = await _service.Delete(id);

            if (!result)
                return NotFound("Order Not Found");

            return Ok("Order Deleted Successfully");
        }
    }
}