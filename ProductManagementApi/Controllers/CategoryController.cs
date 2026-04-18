using Microsoft.AspNetCore.Mvc;
using ProductManagementApi.Entity.Model;
using ProductManagementApi.Service.Definition;

namespace ProductManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
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
                return NotFound($"Category with Id {id} not found");

            return Ok(data);
        }

    
        [HttpPost]
        public IActionResult Add([FromBody] Category category)
        {
            if (category == null)
                return BadRequest("Invalid category data");

            var result = _service.Add(category);
            return Ok(result);
        }

     
        [HttpPut]
        public IActionResult Update([FromBody] Category category)
        {
            if (category == null)
                return BadRequest("Invalid category data");

            var result = _service.Update(category);

            if (result == null)
                return NotFound($"Category with Id {category.Id} not found");

            return Ok(result);
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.Delete(id);

            if (!result)
                return NotFound($"Category with Id {id} not found");

            return Ok("Category deleted successfully");
        }
    }
}