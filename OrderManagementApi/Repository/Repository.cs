using OrderManagementApi.Entity;
using OrderManagementApi.Entity.model;
using System.Collections.Generic;


namespace OrderManagementApi.Repository
{
  
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private static List<T> _data = new List<T>();

        public List<T> GetAll()
        {
            return _data.ToList();
        }

        public T GetById(int id)
        {
            return _data.FirstOrDefault(x => x.Id == id);
        }

        public T Add(T obj)
        {
            _data.Add(obj);
            return obj;
        }

        public void Update(T obj)
        {
            var existing = _data.FirstOrDefault(x => x.Id == obj.Id);

            if (existing != null)
            {
                _data.Remove(existing);
                _data.Add(obj);
            }
        }

        public void Delete(T obj)
        {
            var existing = _data.FirstOrDefault(x => x.Id == obj.Id);

            if (existing != null)
            {
                _data.Remove(existing);
            }
        }
    }


}

