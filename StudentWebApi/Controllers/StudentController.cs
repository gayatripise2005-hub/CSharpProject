using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Entity;
using StudentWebApi.service.Definition;

namespace StudentWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        #region Fields 
        private readonly IStudentservice _service;
        #endregion

        #region Ctor
        public StudentController(IStudentservice service)
        {
            _service = service;
        }
        #endregion

        #region Action Methods 
        [HttpPost]
        public async Task<IActionResult> CreateStudent([FromBody] Student s)
        {
            if (s == null)
            {
                return BadRequest("invalid Request");
            }
          var ob= await _service.Add(s);
            return Ok(new 
            { Data = s,
                Message = "Data SuccessFull Added"
            });
        }
        #endregion
        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var data = await _service.GetById(id);

            if (data == null)
                return NotFound("Student Not Found");

            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudent([FromBody] Student s)
        {
            if (s == null)
                return BadRequest("Invalid Request");

            var result = await _service.Update(s);

            if (result == null)
                return NotFound("Student Not Found");

            return Ok(new
            {
                Data = result,
                Message = "Student Updated Successfully"
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var result = await _service.Delete(id);

            if (!result)
                return NotFound("Student Not Found");

            return Ok("Student Deleted Successfully");
        }
    }
}
