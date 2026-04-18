using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Program
{
    public static void Main(string[] args)
    {
        //int[] elements = { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 };
        //int[] ages = { 22, 23, 24, 67, 17, 25, 26, 27, 11, 22, 11, 33, 22, 33, 22, 22, 22 };

        //var result = elements.Where(e => e > 10 && e % 2 == 0).Select(s => new { num = s, square = s * s }).ToArray();

        //foreach(var ob in result)
        //{
        //    Console.WriteLine($"Number =>{ob.num}, Square=>{ob.square}");
        //}

        //first
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 6, 17, 18, 19, 20 };
        //int ele = arr.First(e => e > 20);// this will throw exception
        //Console.WriteLine(ele);

        //firstOrDefault
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 17, 18, 19, 20 };
        //int ele = arr.FirstOrDefault(e => e > 20);
        //Console.WriteLine(ele);

        //SingleOrDefaul
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 17, 18, 19, 20 };
        //int ele = arr.SingleOrDefault(e => e ==5);
        //Console.WriteLine(ele);


        //Last and LastOrDefault
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 6, 1, 17, 18, 19, 20 };
        //int ele = arr.Last(e => e > 20);//this will throw exception
        //Console.WriteLine(ele);

        //OrderBy
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 6,7, 17, 18, 19, 20 };
        //var res = arr.OrderBy(e => e).ToArray();
        // foreach(var num in res)
        //   Console.WriteLine(num);

        //orderByDescending
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 6, 7, 17, 18, 19, 20 };
        //var res = arr.OrderByDescending(e => e).ToArray();
        // foreach(var num in res)
        //     Console.WriteLine(num);


        //order

        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 6, 7, 17, 18, 19, 20 };
        //int[] sort = arr.Order().ToArray();
        //  foreach(var num in sort)
        //    Console.WriteLine(num);

        //var res = arr.OrderByDescending(e => e).ToArray().ToArray();
        //foreach (var num in res)
        //    Console.WriteLine(num);

        //===========================================================================================================================
        //===========================================================================================================================
        //--------------------------------practice question----------------------------------------------


        //1 Given an integer array, find the first element using LINQ.

        //int[] arr = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
        //int elem = arr.First();
        //Console.WriteLine(elem);

        //2.Given an empty integer array, retrieve the first element safely without exception.

        //int[] arr = {  };
        //int elem = arr.FirstOrDefault();
        //Console.WriteLine(elem);

        //3.Given a string array, get the last element using LINQ.

        //string[] arr = { "Neha", "Maithili", "Snehal", "Gauri", "Rutuja" };
        //string elem = arr.Last();
        //Console.WriteLine(elem);

        //4.Given an array with exactly one element, retrieve it using Single().

        //int [] arr = { 130 };
        //int elem = arr.Single();
        //Console.WriteLine(elem);

        //5.From an integer array, select only even numbers.

        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        //var result = arr.Where(n => n % 2 == 0);
        //foreach(int e in result)
        //{
        //    Console.WriteLine(e);
        //}


        //-------------------Intermediate-----------------------

        //6.From an integer array, find all numbers greater than 50.

        //int[] arr = { 10, 20, 70, 40, 60, 80, 90, 30 };
        //var result = arr.Where(n => n > 50);
        //foreach (int n in result)
        //{
        //    Console.WriteLine(n);
        //}


        //7.Given an integer array, return a new array containing the square of each element.

        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //var result= arr.Select(s => new { num = s, square = s * s }).ToArray();
        //foreach (var ob in result)
        //{
        //    Console.WriteLine($"Number =>{ob.num}, Square=>{ob.square}");
        //}

        //8.Sort an integer array in ascending order.

        //int[] arr = { 4, 2, 8, 5, 9, 1, 6, 3,7 };
        //int[] sort = arr.Order().ToArray();
        //foreach (var num in sort)
        //    Console.WriteLine(num);

        //9.Sort an integer array in descending order.

        //int[] arr = { 4, 2, 8, 5, 9, 1, 6, 3,7 };
        //var res = arr.OrderByDescending(e => e).ToArray().ToArray();
        //foreach (var num in res)
        //    Console.WriteLine(num);


        //10.From an integer array, find the first number greater than 40.

        //int[] arr = { 10, 20, 60, 80, 90, 30 } ;
        //var result = arr.First(n => n > 40);
        //Console.WriteLine(result);

        //11.Filter numbers greater than a given value and convert the result to an array.     

        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int value = 5;
        //int[] result = arr.Where(e => e > value).ToArray();
        //foreach (int e in result)
        //{
        //    Console.WriteLine(e);
        //}


        //----------------- Advanced-----------------------------

        //12. Group an integer array into Even and Odd numbers.

        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var group = arr.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
        foreach(var grp in group)
        {
            Console.WriteLine(grp.Key);
            foreach (int n in grp)
            {
                Console.WriteLine(n);
            }
        }


      //13.Count how many elements exist in each group after grouping.
      //14.Using an integer array, retrieve a value using SingleOrDefault() safely.
      //15.From an empty array, safely retrieve:
       // first element
       // last element
       // single elemen




    }
}