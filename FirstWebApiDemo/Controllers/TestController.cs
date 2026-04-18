using FirstWebApiDemo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApiDemo.Controllers
{
    [Route("api/Pratham/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        public static List<Student> students = new List<Student>();
        [HttpPost]
        public void AddStudent([FromBody]Student student)
        {
            students.Add(student);
        }
        [HttpGet]
        public List<Student> GetAll()
        {
            return students;
        }
        [HttpGet("Get")]
        public Student GetById([FromQuery] int id)
        {
          return  students.FirstOrDefault(x => x.Id == id);
        }

    }
}
