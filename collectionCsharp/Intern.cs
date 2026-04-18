using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp
{
    public class Intern 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string University { get; set; }

        

        public Intern(int id, string name, string university)
        {
            Id = id;
            Name = name;
            University = university;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, University: {University}";
        }

        
    }
}
