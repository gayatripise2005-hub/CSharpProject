using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectioninC_;

namespace collectionCsharp.EmployeeHelper
{
    public class NameWSort1 : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Name.CompareTo(y.Name);
        }

    }
}
