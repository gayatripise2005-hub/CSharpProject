using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp.InternHelper
{
    public class IdWSort2 : IComparer<Intern>
    {
        public int Compare(Intern? x, Intern? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
