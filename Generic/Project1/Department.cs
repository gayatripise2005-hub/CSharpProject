using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProject.Project1
{
    public class Department: BaseEntity
    {
        public string DepartmentName { get; set; }
       
        public string HeadOfDepartment { get; set; }

        public override string ToString()
        {
            return $"DepartmentName: {DepartmentName}, HeadOfDepartment: {HeadOfDepartment}";
        }
    }
}
