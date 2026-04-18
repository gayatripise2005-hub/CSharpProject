using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp.TrainerHelper
{
    public class TrainerSortId : IComparer<Trainer>
    {
        public int Compare(Trainer? x, Trainer? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
