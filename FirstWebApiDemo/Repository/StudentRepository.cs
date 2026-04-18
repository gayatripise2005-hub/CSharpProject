using FirstWebApiDemo.Model;

namespace FirstWebApiDemo.Repository
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        List<Student> GetAll();
        Student GetById(int id);
    }

    public class StudentRepository : IStudentRepository
    {
        public static List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
           students.Add(student);
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}
