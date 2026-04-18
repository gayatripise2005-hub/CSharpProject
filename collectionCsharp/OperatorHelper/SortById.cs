using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace collectionCsharp.OperatorHelper
{
    public class SortById : IComparer<Operator>
    {
        public int Compare(Operator? x, Operator? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
