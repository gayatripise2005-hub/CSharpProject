using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagementApi.Service.Definition;
using OrderManagementApi.Entity.model;
using OrderManagementApi.Service.Implementation;

namespace OrderManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class invoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public invoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpPost]
        public IActionResult Add(Invoice invoice)
        {
            try
            {
                var result = _invoiceService.Add(invoice);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]

        public IActionResult Edit(Invoice invoice)
        {
            try
            {
                var result = _invoiceService.Update(invoice);
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
                var result = _invoiceService.Delete(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult getAll(Invoice invoice)
        {
            try
            {
                var result = _invoiceService.Update(invoice);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult getById(int id)
        {
            try
            {
                var result = _invoiceService.GetById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
