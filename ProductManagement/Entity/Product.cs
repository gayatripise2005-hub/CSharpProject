using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        //tostring method
        public override string ToString()
        {
            return $"Product [Id: {Id}, Name: {Name}, Price: {Price}, Quantity: {Quantity}]";
        }
    }
}
