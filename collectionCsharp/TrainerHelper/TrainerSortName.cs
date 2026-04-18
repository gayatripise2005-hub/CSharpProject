using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp.TrainerHelper
{
    public class TrainerSortName : IComparer<Trainer>
    {
        public int Compare(Trainer? x, Trainer? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

}
