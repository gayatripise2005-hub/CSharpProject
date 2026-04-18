//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace ProductManagementApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class BrandController : ControllerBase
//    {
//    }
//}



using Microsoft.AspNetCore.Mvc;
using ProductManagementApi.Entity.Model;
using ProductManagementApi.Service.Definition;

namespace ProductManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _service;

        public BrandController(IBrandService service)
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
                return NotFound($"Brand with Id {id} not found");

            return Ok(data);
        }

      
        [HttpPost]
        public IActionResult Add([FromBody] Brand brand)
        {
            if (brand == null)
                return BadRequest("Invalid brand data");

            var result = _service.Add(brand);
            return Ok(result);
        }

       
        [HttpPut]
        public IActionResult Update([FromBody] Brand brand)
        {
            if (brand == null)
                return BadRequest("Invalid brand data");

            var result = _service.Update(brand);

            if (result == null)
                return NotFound($"Brand with Id {brand.Id} not found");

            return Ok(result);
        }

       
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.Delete(id);

            if (!result)
                return NotFound($"Brand with Id {id} not found");

            return Ok("Brand deleted successfully");
        }
    }
}