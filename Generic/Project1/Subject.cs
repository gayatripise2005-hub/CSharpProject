using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProject.Project1
{
    public class Subject: BaseEntity
    {
        public string SubjectCode { get; set; } 

        public string SubjectName { get; set; }

        public override string ToString()
        {
            return $"SubjectCode: {SubjectCode}, SubjectName: {SubjectName}";
        }

    }
}
