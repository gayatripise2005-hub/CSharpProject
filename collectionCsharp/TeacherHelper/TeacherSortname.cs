using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionCsharp.TeacherHelper
{
   public class TeacherSortName : IComparer<Teacher>
    {
        public int Compare(Teacher? x, Teacher? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
