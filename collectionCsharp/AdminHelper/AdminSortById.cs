using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp.AdminHelper
{
    public class AdminSortById : IComparer<Admin>
    {
        public int Compare(Admin? x, Admin? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
