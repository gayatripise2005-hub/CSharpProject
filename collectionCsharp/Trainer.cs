using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp
{
    public class Trainer 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Expertise { get; set; }

        public Trainer(int id, string name, string expertise)
        {
            Id = id;
            Name = name;
            Expertise = expertise;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Expertise: {Expertise}";
        }

        
    }
}
