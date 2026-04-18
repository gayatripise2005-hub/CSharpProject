using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInC_.LambdaSorting
{
    public class Advisor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public Advisor() { }

        public Advisor(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Department: {Department}";
        }
    }

    
}
