using StudentWebApi.Entity;
using StudentWebApi.Repository.Definition;
using StudentWebApi.service.Definition;
using System.Threading.Tasks;

namespace StudentWebApi.service.Implementation
{
    public class StudentService : IStudentservice
    {
        private readonly IStudentRepository _repository;
        //constructor Injection 
        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<Student> Add(Student student)
        {
            //validation 
           return await _repository.Add(student);
        }

        public async Task<bool> Delete(int id)
        {
            //validation 
          return  await _repository.Delete(id);
        }

        public async Task<List<Student>> GetAll()
        => await _repository.GetAll();

        public async Task<Student> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<Student> Update(Student student)
        {
            return await _repository.Update(student);
        }
    }
}

