using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using collectionCsharp;

namespace collectionCsharp.InternHelper
{
    public class NameWSort : IComparer<Intern>
    {
        public int Compare(Intern? x, Intern? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

}
