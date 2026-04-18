using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.Entity.Model
{
    public class MenuItem : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {   
            return $"Id:{Id},Name:{Name},Price: {Price}";
        }
    }
}
