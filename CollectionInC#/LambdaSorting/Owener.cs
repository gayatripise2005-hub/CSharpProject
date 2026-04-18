using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInC_.LambdaSorting
{
    public class Owener
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public int Rental { get; set; }

        public Owener() { }

        public Owener(string name, string address, int rental)
        {
            Name = name;
            Address = address;
            Rental = rental;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}, Rental: {Rental}";
        }
    }
    public class Demo1
    {
        public static void Run1()
        {
            SortedSet<Owener> owners = new SortedSet<Owener>
            {
               new Owener("Alice", "123 Main St", 1500),
                new Owener("Bob", "456 Elm St", 1200),
                new Owener("Charlie", "789 Oak St", 1800),
                new Owener("David", "321 Pine St", 1300),

            };


        }

    }
}
