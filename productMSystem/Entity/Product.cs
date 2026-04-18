using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productMSystem.Entity
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Quantity { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Quantity: {Quantity}, Price: {Price}, Description: {Description}";
        }


    }
}
