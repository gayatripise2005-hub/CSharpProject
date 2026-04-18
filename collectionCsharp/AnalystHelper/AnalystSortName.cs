using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectioninC_;
namespace collectionCsharp.AnalystHelper
{
    public class AnalystSortName : IComparer<AnalystClass>
    {
        public int Compare(AnalystClass? x, AnalystClass? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
