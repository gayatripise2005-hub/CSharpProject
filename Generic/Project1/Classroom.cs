using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProject.Project1
{
    public class Classroom: BaseEntity
    {
        public string ClassroomName { get; set; }
        public int Capacity { get; set; }
        public override string ToString()
        {
            return $"ClassroomName: {ClassroomName}, Capacity: {Capacity}";
        }
    }
}
