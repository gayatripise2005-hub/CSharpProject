using DBFirstApporch.Models;
using DBFirstApporch.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBFirstApporch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        #region Fields 
        private readonly IRepository<TblBook> _bookRepository;
        #endregion

        #region Ctor
        public BookController(IRepository<TblBook> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _bookRepository.GetAllAsync();

            return books.Count() > 0 ? Ok(new { data = books, Message = "books Fetch Successfull" }) :
                NotFound(" Data Not Found");
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(TblBook book)
        {
            //validation
            await _bookRepository.AddAsync(book);
            var flag =await _bookRepository.SaveAsync() >0;
            if(flag)
               return Ok(book);
            return BadRequest("book Not Added ");
        }
        [HttpGet("GetById")]

        public async Task<IActionResult> GetBookById([FromQuery] int id)
        {
           var b= await _bookRepository.GetByIdAsync(id);
            return Ok(b);
        }
        #endregion
    }
}
