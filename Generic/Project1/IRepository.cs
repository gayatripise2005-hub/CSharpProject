using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProject.Project1
{
   
        public interface IRepository<T> where T : BaseEntity
        {
            List<T> GetAll();
            T? GetById(long id);
                void Add(T entity);
                void Update(T entity);
                void Delete(long id);

        }

    
}
