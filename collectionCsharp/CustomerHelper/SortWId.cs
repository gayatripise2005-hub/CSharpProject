using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp.CustomerHelper
{
    public class SortWId: IComparer<Customer>
    {
        public int Compare(Customer? x, Customer? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
