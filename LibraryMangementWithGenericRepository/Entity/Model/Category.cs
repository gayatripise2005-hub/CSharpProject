using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementWithGenericRepository.Entity.Model
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }


        public override string ToString()
        {
            return $"CategoryId :{Id}, categoryName :{CategoryName}, description :{Description}";
        }
    }
}
