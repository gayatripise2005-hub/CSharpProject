using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp
{
    public class Student 
    { 
     public int Id { get; set; }
     public string Name { get; set; }
     public double Grade { get; set; }
        
        public Student() { }

        public Student(int id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }
       
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Grade: {Grade}";
        }

        
    }
}
