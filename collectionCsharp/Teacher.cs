using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp
{
    public class Teacher 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

      

        public Teacher(int id, string name, string descriptio)
        {
            Id = id;
            Name = name;
            Description = descriptio;

        }
        public override string ToString()
        {
                 return $"Id: {Id}, Name: {Name}, Description: {Description}";
        }

        
    }
}
