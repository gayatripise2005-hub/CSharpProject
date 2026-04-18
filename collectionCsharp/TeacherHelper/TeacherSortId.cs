using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp.TeacherHelper
{

    public class TeacherSortId : IComparer<Teacher>
    {
        public int Compare(Teacher? x, Teacher? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
