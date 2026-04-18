using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.Entity.Model
{
    public  class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"Id:{Id},Name:{Name},phoneNumber: {PhoneNumber}";
        }

    }
}
