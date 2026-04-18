using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProject.Project1
{
    public class Course: BaseEntity
    {
        public string CourseName { get; set; }  
        public decimal CourseFee { get; set; }
        public int Duration { get; set; }

        public override string ToString()
        {
            return $"CourseName: {CourseName}, CourseFee: {CourseFee}, Duration: {Duration} months";
        }


    }
}
