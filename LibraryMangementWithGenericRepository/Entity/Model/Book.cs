using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementWithGenericRepository.Entity.Model
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Author { get; set; }

     
        public override string ToString()
        {
            return $"Book Id: {Id}, Name: {Name}, Author: {Author}";
        }
    }
}
