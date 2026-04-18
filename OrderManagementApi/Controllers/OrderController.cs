using Microsoft.AspNetCore.Mvc;
using OrderManagementApi.Entity.model;
using OrderManagementApi.Service.Definition;

namespace OrderManagementApi.Controllers
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
        public IActionResult CreateOrder([FromBody] Order order)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var data = _service.Add(order);

            return Ok(new
            {
                Data = data,
                Message = "Order Created Successfully"
            });
        }

      
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var data = _service.GetAll();

            if (data == null || !data.Any())
                return NotFound("No Orders Found");

            return Ok(data);
        }

        
        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            var data = _service.GetById(id);

            if (data == null)
                return NotFound("Order Not Found");

            return Ok(data);
        }

        
        [HttpPut]
        public IActionResult UpdateOrder([FromBody] Order order)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _service.Update(order);

            if (result == null)
                return NotFound("Order Not Found");

            return Ok(new
            {
                Data = result,
                Message = "Order Updated Successfully"
            });
        }

        
        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var result = _service.Delete(id);

            if (!result)
                return NotFound("Order Not Found");

            return Ok(new
            {
                Message = "Order Deleted Successfully"
            });
        }
    }
}