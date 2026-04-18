using FirstWebApiDemo.Model;
using FirstWebApiDemo.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpPost]
        public void AddStudent([FromBody] Student student)
        {
            _studentRepository.AddStudent(student);
        }
        [HttpGet]
        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }
        [HttpGet("Get")]
        public Student GetById([FromQuery] int id)
        {
            return _studentRepository.GetById(id);
        }
    }
}
