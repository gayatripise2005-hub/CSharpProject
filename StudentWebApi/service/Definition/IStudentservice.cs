using StudentWebApi.Entity;
namespace StudentWebApi.service.Definition
{
    public interface IStudentservice
    {
        Task<List<Student>> GetAll();
        Task<Student> GetById(int id);
        Task<Student> Add(Student student);
        Task<Student> Update(Student student);
        Task<bool> Delete(int id);

    }
}
