using Microsoft.EntityFrameworkCore;
using StudentWebApi.Data;
using StudentWebApi.Entity;
using StudentWebApi.Repository.Definition;
using System.Threading.Tasks;

namespace StudentWebApi.Repository.implementation
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public  async Task<Student> Add(Student student)
        {
            var entity= await _context.tblStudent.AddAsync(student);
            await SaveAndChangesAsync();
            return entity.Entity;
        }

        public async Task<bool> Delete(int id)
        {
          var obj =  await _context.tblStudent.FirstOrDefaultAsync(x => x.Id == id);
            _context.tblStudent.Remove(obj);
            return await  SaveAndChangesAsync();
        }

        public async Task<List<Student>> GetAll()
        => await _context.tblStudent.ToListAsync();
        public async Task<Student> GetById(int id)
         => await _context.tblStudent.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<bool> SaveAndChangesAsync()
        {
          return  await _context.SaveChangesAsync() > 0;
        }

        public async  Task<Student> Update(Student student)
        {
            var existing = await _context.tblStudent
       .FirstOrDefaultAsync(x => x.Id == student.Id);

            if (existing == null)
                return null;

            existing.Name = student.Name;
            existing.Phone = student.Phone;
            existing.Address = student.Address;

            await SaveAndChangesAsync();

            return existing;
        }



     
    }
}


