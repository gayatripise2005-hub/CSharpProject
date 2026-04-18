using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementWithGenericRepository.Entity.Model
{
    public class Address : BaseEntity
    {
        public string City { get; set; }

        public String PinCode { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, City : {City}, PinCode : {PinCode}";
        }
    }
}
