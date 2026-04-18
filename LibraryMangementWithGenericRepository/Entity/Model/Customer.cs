using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementWithGenericRepository.Entity.Model
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }

        public string Phone {  get; set; }

        public string email { get; set; }

        public override string ToString()
        {
           return $"Id :{Id}, name :{Name}, phone :{Phone}, email : {email}";
        }
    }
}
