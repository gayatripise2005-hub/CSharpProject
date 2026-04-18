using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp.CustomerHelper
{
    public class SortWName : IComparer<Customer>
    {
        public int Compare(Customer? x, Customer? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
