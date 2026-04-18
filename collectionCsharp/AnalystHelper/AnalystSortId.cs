using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp.Analyst
{
    public class AnalystSortId : IComparer<AnalystClass>
    {
        public int Compare(AnalystClass? x, AnalystClass? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
