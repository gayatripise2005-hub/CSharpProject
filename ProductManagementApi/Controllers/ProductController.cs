using Microsoft.AspNetCore.Mvc;
using ProductManagementApi.Entity.Model;
using ProductManagementApi.Service.Definition;

namespace ProductManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

      
        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _service.GetAll();
            return Ok(data);
        }

     
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var data = _service.GetById(id);

            if (data == null)
                return NotFound($"Product with Id {id} not found");

            return Ok(data);
        }

      
        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {
            if (product == null)
                return BadRequest("Invalid product data");

            var result = _service.Add(product);
            return Ok(result);
        }

      
        [HttpPut]
        public IActionResult Update([FromBody] Product product)
        {
            if (product == null)
                return BadRequest("Invalid product data");

            var result = _service.Update(product);

            if (result == null)
                return NotFound($"Product with Id {product.Id} not found");

            return Ok(result);
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.Delete(id);

            if (!result)
                return NotFound($"Product with Id {id} not found");

            return Ok("Product deleted successfully");
        }
    }
}