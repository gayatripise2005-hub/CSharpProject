using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp
{
    public  class Admin 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        

        public Admin(int id, string name, string role)
        {
            Id = id;
            Name = name;
            Role = role;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Role: {Role}";
        }

        
    }
}
