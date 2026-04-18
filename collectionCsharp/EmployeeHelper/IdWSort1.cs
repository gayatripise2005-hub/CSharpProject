using CollectioninC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp.EmployeeHelper
{
    public class IdWSort1 : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
