using Microsoft.AspNetCore.Mvc;
using ProductManagementApi.Entity.Model;
using ProductManagementApi.Service.Definition;

namespace ProductManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _service;

        public SupplierController(ISupplierService service)
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
                return NotFound($"Supplier with Id {id} not found");

            return Ok(data);
        }

       
        [HttpPost]
        public IActionResult Add([FromBody] Supplier supplier)
        {
            if (supplier == null)
                return BadRequest("Invalid supplier data");

            var result = _service.Add(supplier);
            return Ok(result);
        }

      
        [HttpPut]
        public IActionResult Update([FromBody] Supplier supplier)
        {
            if (supplier == null)
                return BadRequest("Invalid supplier data");

            var result = _service.Update(supplier);

            if (result == null)
                return NotFound($"Supplier with Id {supplier.Id} not found");

            return Ok(result);
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.Delete(id);

            if (!result)
                return NotFound($"Supplier with Id {id} not found");

            return Ok("Supplier deleted successfully");
        }
    }
}