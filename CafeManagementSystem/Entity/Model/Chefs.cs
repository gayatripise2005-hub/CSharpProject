using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.Entity.Model
{
    public class Chefs : BaseEntity
    {
        public string Name { get; set; }

        public string Speciality { get; set; }

        public override string ToString()
        {
            return $"id :{Id},Name:{Name},Speciality:{Speciality}";
        }
    }
}
