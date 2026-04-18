using Microsoft.AspNetCore.Mvc;
using OrderManagementApi.Entity.model;
using OrderManagementApi.Service.Definition;

namespace OrderManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _service;

        public InvoiceController(IInvoiceService service)
        {
            _service = service;
        }

      
        [HttpPost]
        public IActionResult CreateInvoice([FromBody] Invoice invoice)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var data = _service.Add(invoice);

            return Ok(new
            {
                Data = data,
                Message = "Invoice Added Successfully"
            });
        }

       
        [HttpGet]
        public IActionResult GetAllInvoices()
        {
            var data = _service.GetAll();

            if (data == null || !data.Any())
                return NotFound("No Invoices Found");

            return Ok(data);
        }

       
        [HttpGet("{id}")]
        public IActionResult GetInvoiceById(int id)
        {
            var data = _service.GetById(id);

            if (data == null)
                return NotFound("Invoice Not Found");

            return Ok(data);
        }

        
        [HttpPut]
        public IActionResult UpdateInvoice([FromBody] Invoice invoice)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _service.Update(invoice);

            if (result == null)
                return NotFound("Invoice Not Found");

            return Ok(new
            {
                Data = result,
                Message = "Invoice Updated Successfully"
            });
        }

       
        [HttpDelete("{id}")]
        public IActionResult DeleteInvoice(int id)
        {
            var result = _service.Delete(id);

            if (!result)
                return NotFound("Invoice Not Found");

            return Ok(new
            {
                Message = "Invoice Deleted Successfully"
            });
        }
    }
}