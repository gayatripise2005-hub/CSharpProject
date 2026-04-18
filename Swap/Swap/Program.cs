using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 33;
            //int b = 21;

            //a = a + b; 
            //b = a - b;
            //a = a - b;
            //Console.WriteLine($"a = {a} b = {b}"); 


            //create a program to determine if a given year is a leap year
            int year;
            Console.WriteLine("Enter a year");
            year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && 200 != 0))

            {
                Console.WriteLine($"{year}is leap");

            }
            else if (year % 4 == 0)
            {
                Console.WriteLine($"{year}is leap");

            }
            else
            {
                Console.WriteLine($"{year}is not leap");
            }
        }
    }
}
