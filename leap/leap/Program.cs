using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace leap
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Write a  program to enter length and breadth of a rectangle and find its perimeter.
            int length;
            Console.WriteLine("enter length");
            length = int.Parse(Console.ReadLine());
            int breadth;
            Console.WriteLine("enter breadth");
            breadth = int.Parse(Console.ReadLine());
            if (length > 0 && breadth > 0)
            {
                int perimeter = 2 * (length + breadth);
                Console.WriteLine("perimeter =" + perimeter);
            }
            else
            {
                Console.WriteLine("length amd breadth is valid");
            }




            // Write a  program to enter length and breadth of a rectangle and find its area.


            Console.WriteLine("enter length");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("enter breadth");
            breadth = int.Parse(Console.ReadLine());
            if (length > 0 && (breadth > 0))
            {
                int area1 = length + breadth;
                Console.WriteLine("area=" + area1);
            }
            else
            {
                Console.WriteLine(" Invalid input.length and breadth is positive");
            }


            //Write a  program to enter radius of a circle and find its diameter, circumference and area.
            int radius;
            Console.WriteLine("enter the redius");
            radius = int.Parse(Console.ReadLine());
            if (radius > 0)
            {
                int diameter = 2 * radius;
                double circumference = 2 * 3.14 * radius;
                double area1 = 3.14 * radius * radius;

                Console.WriteLine("diameter=" + diameter);
                Console.WriteLine("cirumference=" + circumference);
                Console.WriteLine("area=" + area1);
            }
            else
            {
                Console.WriteLine("Invalid input.radius is valid");

            }
            //Write a  program to enter length in centimeter and convert it into meter and kilometer
            int lengthCm;
            Console.WriteLine("enter the length in Centimeter");
            lengthCm = int.Parse(Console.ReadLine());
            if (length >= 0)
            {
                double lengthM = length / 100;
                double lengthKm = length / 100000;
                Console.WriteLine("length in meter:" + lengthM);
                Console.WriteLine("length in Kilometer:" + lengthKm);
            }
            else
            {
                Console.WriteLine("length can be negative");

            }
            // Write a  program to enter two angles of a triangle and find the third angle.
            int angle1, angle2;
            Console.WriteLine("enter first angle:");
            angle1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second angle:");
            angle2 = int.Parse(Console.ReadLine());
            //calculate third angle
            int angle3 = 180 - (angle1 + angle2);
            Console.WriteLine("third angle of triangle:" + angle3);


            //Write a  program to enter base and height of a triangle and find its area.
            int br, h;
            Console.WriteLine("enter base of triangle:");
            br = int.Parse(Console.ReadLine());
            Console.WriteLine("enter height of triangle:");
            h = int.Parse(Console.ReadLine());
            int area = 1 / 2 * br * h;
            Console.WriteLine("area of triangle:" + area);


            //Write a  program to calculate area of an equilateral triangle
            double side;
            Console.WriteLine("enter the side of equilateral triangle:");
            side = double.Parse(Console.ReadLine());
            double area3 = (Math.Sqrt(3) / 4) * side * side;
            Console.WriteLine("Area=" + area);

            //Write a  program to enter marks of five subjects and calculate total, average and percentage.
            int sub1 = 78;
            int sub2 = 85;
            int sub3 = 90;
            int sub4 = 72;
            int sub5 = 80;

            int total = sub1 + sub2 + sub3 + sub4 + sub5;
            double average = total / 5.0;
            double percentage = (total / 500.0) * 100;

            Console.WriteLine("Marks of 5 Subjects:");
            Console.WriteLine("Subject 1 = " + sub1);
            Console.WriteLine("Subject 2 = " + sub2);
            Console.WriteLine("Subject 3 = " + sub3);
            Console.WriteLine("Subject 4 = " + sub4);
            Console.WriteLine("Subject 5 = " + sub5);

            Console.WriteLine("\nTotal Marks = " + total);
            Console.WriteLine("Average Marks = " + average);
            Console.WriteLine("Percentage = " + percentage);

            //Write a  program to enter P, T, R and calculate Simple Interest.

            int P, T, R, SI;
            Console.Write("Enter Principal (P): ");
            P = int.Parse(Console.ReadLine());

            Console.Write("Enter Time (T in years): ");
            T = int.Parse(Console.ReadLine());

            Console.Write("Enter Rate (R): ");
            R = int.Parse(Console.ReadLine());
            SI = (P * T * R) / 100;
            Console.WriteLine("\nSimple Interest = " + SI);

            //count of all notes 
            Console.WriteLine("enter the amount:");
            int amount = int.Parse(Console.ReadLine());
            int notes;
            if (amount >= 500)
            {
                notes = amount / 500;
                amount = amount % 500;
                Console.WriteLine($"500:{notes}notes");
            }
            if (amount >= 200)
            {
                notes = amount / 200;
                amount = amount % 200;
                Console.WriteLine($"200:{notes}notes");
            }
            if (amount >= 100)
            {
                notes = amount / 100;
                amount = amount % 100;
                Console.WriteLine($"100:{notes}notes");
            }
            if (amount >= 50)
            {
                notes = amount / 50;
                amount = amount % 50;
                Console.WriteLine($"50:{notes}notes");
            }
            if (amount >= 20)
            {
                notes = amount / 20;
                amount = amount % 20;
                Console.WriteLine($"20:{notes}notes");
            }
            if (amount >= 10)
            {
                notes = amount / 10;
                amount = amount % 10;
                Console.WriteLine($"10:{notes}notes");
            }
            if (amount >= 5)
            {
                notes = amount / 5;
                amount = amount % 5;
                Console.WriteLine($"5:{notes}notes");
            }
            if (amount >= 2)
            {
                notes = amount / 2;
                amount = amount % 2;
                Console.WriteLine($"2:{notes}notes");
            }
            if (amount >= 1)
            {
                notes = amount / 1; if (amount >= 500)
                {
                    notes = amount / 500;
                    amount = amount % 500;
                    Console.WriteLine($"500:{notes}notes");
                }

            }
            //Write a C program to find the maximum between two numbers.
            int a, b;
            Console.WriteLine("enter first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number:");
            b = int.Parse(Console.ReadLine());
            if (a > b)

                Console.WriteLine("maximum=" + a);
            else
                Console.WriteLine("maximum=" + b);




            //Write a C program to find a maximum between three numbers
            int x, y, z;
            Console.WriteLine("enter three number:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            if (x >= y && x >= z)
                Console.WriteLine("maximum=" + x);
            else if (y >= x && y >= z)
                Console.WriteLine("maximum=" + y);
            else
                Console.WriteLine("maximum=" + z);


            // Write a C program to check whether a number is negative, positive or zero.
            Console.WriteLine("enter the number:");
            x = int.Parse(Console.ReadLine());
            if (x > 0)
                Console.WriteLine("it is positive");
            else if (x < 0)
                Console.WriteLine("it is negative");
            else
                Console.WriteLine("it is zero");

            //Write a C program to check whether a number is divisible by 5 and 11 or not.

            if (x % 5 == 0 && x % 11 == 0)
                Console.WriteLine("divisible by 5 and 11");
            else
                Console.WriteLine("not divisible");

            //Write a C program to check whether a number is even or odd
            if (x > y)

                Console.WriteLine("even=" + x);
            else
                Console.WriteLine("odd=" + y);

            //Write a C program to check whether a year is a leap year or not.
            
            Console.WriteLine("enter the year:");
            int.Parse(Console.ReadLine());
            if ((y%4==0&&y%100!=0 )||(y%400==0))
            {
                Console.WriteLine($"{y}is leap year");
            }
            else
            {
                Console.WriteLine($"{y} is not leap year");
            }

            //Write a C program to check whether a character is in the alphabet or not.
            char ch = 'a';
            if((ch>='a'&&ch<='z')|| (ch>='A'&&ch<='Z'))
            {
                Console.WriteLine($"{ch}is an alphabet");
            }
            else
            {
                Console.WriteLine($"{ch}is not alphbet");
            }
            
            //
        }
    }
}
