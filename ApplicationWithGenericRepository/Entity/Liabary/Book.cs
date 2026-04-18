using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationWithGenericRepository.Entity.Liabary
{
    public class Book : BaseEntity
    {
        public string   Name { get; set; }
        public string Author { get; set; }

        //tostring method to display book information
        public override string ToString()
        {
            return $"Book Id: {Id}, Name: {Name}, Author: {Author}";
        }
    }
}
