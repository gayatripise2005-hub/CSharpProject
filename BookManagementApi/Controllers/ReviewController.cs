using Microsoft.AspNetCore.Mvc;
using BookManagementApi.Entity.Model;
using BookManagementApi.service.Definition;

namespace BookManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _service;

        public ReviewController(IReviewService service)
        {
            _service = service;
        }

       
        [HttpPost]
        public async Task<IActionResult> CreateReview([FromBody] Review r)
        {
            if (r == null)
                return BadRequest("Invalid Request");

            var data = await _service.Add(r);

            return Ok(new
            {
                Data = data,
                Message = "Review Added Successfully"
            });
        }

        
        [HttpGet]
        public async Task<IActionResult> GetAllReviews()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReviewById(int id)
        {
            var data = await _service.GetById(id);

            if (data == null)
                return NotFound("Review Not Found");

            return Ok(data);
        }

       
        [HttpPut]
        public async Task<IActionResult> UpdateReview([FromBody] Review r)
        {
            if (r == null)
                return BadRequest("Invalid Request");

            var result = await _service.Update(r);

            if (result == null)
                return NotFound("Review Not Found");

            return Ok(new
            {
                Data = result,
                Message = "Review Updated Successfully"
            });
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            var result = await _service.Delete(id);

            if (!result)
                return NotFound("Review Not Found");

            return Ok("Review Deleted Successfully");
        }
    }
}