using CollectioninC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp.Helper
{
    public class IdWSort : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.Id.CompareTo(y.Id);
        }

    }

    //===========================================================================================

    //================================================================================================


   


}
