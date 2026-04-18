
using Microsoft.AspNetCore.Mvc;
using BookManagementApi.Entity;
using BookManagementApi.service.Definition;

namespace BookManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;
        }

       
        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] Book b)
        {
            if (b == null)
                return BadRequest("Invalid Request");

            var data = await _service.Add(b);

            return Ok(new
            {
                Data = data,
                Message = "Book Added Successfully"
            });
        }

        
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var data = await _service.GetById(id);

            if (data == null)
                return NotFound("Book Not Found");

            return Ok(data);
        }

        
        [HttpPut]
        public async Task<IActionResult> UpdateBook([FromBody] Book b)
        {
            if (b == null)
                return BadRequest("Invalid Request");

            var result = await _service.Update(b);

            if (result == null)
                return NotFound("Book Not Found");

            return Ok(new
            {
                Data = result,
                Message = "Book Updated Successfully"
            });
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var result = await _service.Delete(id);

            if (!result)
                return NotFound("Book Not Found");

            return Ok("Book Deleted Successfully");
        }
    }
}