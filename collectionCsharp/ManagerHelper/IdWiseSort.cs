using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp.ManagerHelper
{
    public class IdWiseSort : IComparer<Manager>
    {
        public int Compare(Manager? x, Manager? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
