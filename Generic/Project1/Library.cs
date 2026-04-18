using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProject.Project1
{
    public partial class  Library: BaseEntity
    {
        public string LibraryName { get; set; }
        public int NumberOfBooks { get; set; }
        
        public string Author { get; set; }  

        public override string ToString()
        {
            return $"LibraryName: {LibraryName}, NumberOfBooks: {NumberOfBooks}, Author: {Author}";
        }
    }
}
