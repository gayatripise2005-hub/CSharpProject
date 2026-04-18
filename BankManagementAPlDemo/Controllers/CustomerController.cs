
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Service.Definiation;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _service;

    public CustomerController(ICustomerService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll(int pageIndex = 0, int pageSize = 3)
    {
        var result = _service.GetAll(pageIndex, pageSize);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok(_service.GetById(id));
    }

    [HttpPost]
    public IActionResult Create(Customer customer)
    {
        return Ok(_service.Add(customer));
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Customer customer)
    {
        customer.CustomerId = id;
        return Ok(_service.Update(customer));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.Delete(id);
        return Ok("Deleted Successfully");
    }
}