using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProject.Project1
{
    public class Teacher: BaseEntity
    {
        public string Name { get; set; }
         
        public string SubjectName { get; set; }

        public int Experience { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, SubjectName: {SubjectName}, Experience: {Experience} years";
        }

    }
}
