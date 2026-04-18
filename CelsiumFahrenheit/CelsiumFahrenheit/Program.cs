using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiumFahrenheit
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            int Celsium = 26;
            int Fahrenheit = (9 / 5 * Celsium) + 32;
            Console.WriteLine("Fahrenheit =" + Fahrenheit);
            Console.ReadLine();
        }
    }
}
