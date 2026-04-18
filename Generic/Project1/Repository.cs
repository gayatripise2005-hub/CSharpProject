using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProject.Project1
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public List<T> _data=new List<T>();
        public int _id = 1;
        public void Add(T entity)
        {
           if (entity == null)
            {
                Console.WriteLine("entity is required");
                return;
            }
           entity.Id = _id++;
            _data.Add(entity);
        }

        public void Delete(long id)
        {
            if(id <= 0)
            {
                Console.WriteLine("Invalid id");
                return;
            }
            _data.RemoveAll(x => x.Id == id);
        }


        public T? GetById(long id)
        {
            return _data.FirstOrDefault(x => x.Id == id);
        }

        public List<T> GetAll()
        {
            return _data;
            
        }

        public void Update(T entity)
        {
            var existing = _data.FirstOrDefault(e =>e.Id==entity.Id);
            _data.Remove(existing);
            _data.Add(entity);
        }
    }
}
