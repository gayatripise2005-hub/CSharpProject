using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productMSystem.Entity
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Productcount { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Productcount: {Productcount}";
        }

    }
}
