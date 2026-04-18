using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.Json.Serialization.Metadata;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Program
{
    public static void Main(string[] args)

    {

        //int[] elements = { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 };

        //int[] ages = { 22, 23, 24, 67, 17, 25, 26, 27, 11, 22, 11, 33, 22, 33, 22, 22, 22 };

        //int[] res = elements.Where(e => e % 5 == 0).ToArray();
        //foreach (int item in res)
        //{
        //    Console.WriteLine(item);
        //}


        ////find Max age and Min age from ages array
        //int max = ages.Max();
        //int min = ages.Min();
        //Console.WriteLine($"Max age is: {max}");
        //Console.WriteLine($"Min age is: {min}");

        // //find average age from ages array
        //double avg = ages.Average();
        //Console.WriteLine($"Average age is: {avg}");

        ////find count of ages greater than 18
        //int count = elements.Where(a => a <= 18).Count();
        //Console.WriteLine($"Count of ages less than or equal to 18 is:{count}");

        ////find all even ages from ages array and Sum of even ages
        //int sum1= ages.Where(a=>a%2==0).Sum();
        //Console.WriteLine("sum if Even Ages" + sum1);

        //// find all odd ages from ages array and Sum of odd ages
        //int sum1=ages.Where(a=>a%2!=0).Sum();
        // Console.WriteLine("sum of Odd Ages"+sum1);


        ////find Maximum time repeated age in ages array
        //    var res = ages.GroupBy(a => a)
        //        .OrderByDescending(g => g.Count())
        //        .Select(g => new { Age = g.Key, Count = g.Count() })
        //        .FirstOrDefault();

        //Console.WriteLine($"{ res?.Age} { res?.Count}");

        //========================================================================================================================================================
        //========================================================================================================================================================


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

        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //var group = arr.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
        //foreach (var grp in group)
        //{
        //    Console.WriteLine(grp.Key);
        //    foreach (int n in grp)
        //    {
        //        Console.WriteLine(n);
        //    }
        //}


        //13.Count how many elements exist in each group after grouping.




        //14.Using an integer array, retrieve a value using SingleOrDefault() safely.

        //int[] numbers = { 60 };

        //int result = numbers.SingleOrDefault();
        //Console.WriteLine(result);





        //15.From an empty array, safely retrieve:
        // first element
        //int[] arr = { 1,2,3,4,5,6};
        //int first = arr.FirstOrDefault();
        //Console.WriteLine(first);


        // last element

        //int[] arr = { 1, 2, 3, 4, 5, 6 };
        //int last = arr.LastOrDefault();
        //Console.WriteLine(last);


        // single element





        //=====================================================================================================================================================
        //=====================================================================================================================================================

        //Distinct Function :It is used to remove duplicate elements

        //descending
        //int[] elements = { 12, 14, 15, 8, 7, 10, 11, 12, 11, 6, 11, 13, 14, 23, 16, 15};

        //var res = elements.Distinct().OrderByDescending(e => e).ToArray();
        //foreach (var elem in res)
        //{
        //    {
        //        Console.WriteLine(elem);
        //    }

        //}



        //Ascending
        //int[] elements = { 12, 14, 15, 8, 7, 10, 11, 12, 11, 6, 11, 13, 14, 23, 16, 15 };

        //var res = elements.Distinct().OrderBy(e => e).ToArray();
        //foreach (var elem in res)
        //{
        //    {
        //        Console.WriteLine(elem);
        //    }

        //}

        //----------------------------------------------

        //int[] arr1 = { 1, 2, 4, 5, 6 };

        //int[] arr2 = { 1, 2, 3, 4, 7, 8, 9, 10 };

        //Union:combines both arrays and removes duplicates

        //var res = arr1.Union(arr2).ToArray();
        //foreach (var ele in res)
        //{
        //    Console.WriteLine(ele);
        //}



        // INTERSECT: finds common elements in both arrays

        //var intersect = arr1.Intersect(arr2).ToList();
        //foreach (var ele in intersect)
        //{
        //    Console.WriteLine(ele);
        //}
        //intersect.Add(10);

        //Console.WriteLine("");

        //-----------------------------------------------------/

        //here create Delegate 
        //Action<int> display = (e) => Console.WriteLine(e);
        //int[] arr = { 1, 2, 3, 6 };

        ////find the missing Element

        //var list = Enumerable.Range(arr.Min(), arr.Count() + 1).ToList();

        ////here create Range ex like 1,2,3,4,5,6
        //foreach (var i in list)
        //{
        //    Console.WriteLine(i);
        //}
        ////List ForEach methods 
        //list.ForEach(display);
        //list.ForEach((e) => Console.WriteLine(e));

        ////  here remove inside list match element in the arr

        //var nums = list.Except(arr).ToArray();
        //foreach (int i in nums)
        //    Console.WriteLine(i);

        //--------------------------------------
        // find second largest element
        //var arr = new int[] { 1, 6, 2, 8, 3, 5 };
        //var res = arr.OrderByDescending(x => x).Skip(1) .FirstOrDefault();
        //Console.WriteLine(res);

        //======================================================================================================
        //----practice question---------

        //1.Create an integer array of 10 elements and print all elements.

        //int[] arr = { 10, 6, 2, 8, 3, 5, 1, 4, 9, 7 };
        ////Console.WriteLine();
        //foreach (int n in arr)
        //{
        //    Console.WriteLine(n);
        //}

        ////2.Find the sum of all elements in an integer array.
        //int sum = arr.Sum();
        //Console.WriteLine("Sum="+sum);

        ////3.Find the maximum and minimum value from an array.
        //int max = arr.Max();
        //int min=arr.Min();
        //Console.WriteLine($"Max={max},Min={min}");

        ////4.Count how many even and odd numbers are present in an array.
        //int even = arr.Count(x => x % 2 == 0);
        //int odd = arr.Count(x => x % 2 != 0);
        //Console.WriteLine($"Even={even},Odd={odd}");

        //5.Reverse an array without using built-in reverse methods.


        ////6.Sort an array in ascending order.
        //int[] sort = arr.Order().ToArray();
        //foreach (var num in sort)
        //    Console.WriteLine(num);


        //7.Search for a given element in an array and print its index
        //int search = 7;
        //int index=Array.IndexOf(arr,search);
        //Console.WriteLine($"{search} its index{index}");


        //8.Remove duplicate elements from an array.
        //int[] arr2 = { 2, 4, 6, 8, 7,11 };
        //var res = arr.Union(arr2).ToArray();
        //foreach (var ele in res)
        //{
        //    Console.WriteLine(ele);
        //}


        //9.Find the second largest number in an array.
        //var res = arr.OrderByDescending(x => x).Skip(1).FirstOrDefault();
        //Console.WriteLine(res);


        //10.Merge two arrays into a single array.


        //------------------------------------------------------------------------------------
        // 1.Use LINQ to find all even numbers from an integer array.
        //int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80,90 };
        //var even = arr.Where(x => x % 2 == 0).ToArray();
        //foreach (var n in even)
        //{
        //    Console.Write(n + " ");
        //}


        //2.Use LINQ to find all numbers greater than 50 from an array.
        //int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        //var res=arr.Where(x => x > 50).ToArray();   
        //foreach( var x in res )
        //{
        //    Console.WriteLine(x+" "); 
        //}


        //3.Use LINQ to calculate the sum and average of array elements.
        //int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        //int sum = arr.Sum();
        //double avg=arr.Average();
        //Console.WriteLine($"sum={sum},Average={avg}");


        //4.Find the maximum and minimum value using LINQ.
        //int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        //int max = arr.Max();
        //int min = arr.Min();
        //Console.WriteLine($"Max={max} Min={min}");


        //5.Sort an array in descending order using LINQ.
        //int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        //var res = arr.OrderByDescending(x => x).ToArray();
        //foreach ( var x in res)
        //{
        //    Console.WriteLine(x); 
        //}


        //6.Remove duplicate elements using LINQ.
        //int[] arr = { 10, 20, 30, 40, 90, 60, 20, 80, 90 };
        //var res = arr.Distinct().ToArray();
        //foreach (var x in res)
        //    {
        //        Console.WriteLine(x);
        //    }


        //7.Find the top 3 largest numbers using LINQ.
        //int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        //var res = arr.OrderByDescending(x => x).Take(3).ToArray();
        //foreach (var x in res)
        //{
        //    Console.WriteLine(x);
        //}


        //Count how many elements are greater than the average value.
        //int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        //double avg=arr.Average();
        //int res = arr.Where(x => x > avg).Count();
        //Console.WriteLine("Count="+res);


        //8.Convert an array of strings into uppercase using LINQ.
        //string[] arr = { "shivtej", "gayatri", "aryan", "maithili", "vaishnavi" };
        //var res = arr.Select(x => x.ToUpper()).ToArray();
        //foreach (var x in res)
        //{
        //    Console.WriteLine(x);
        //}


        //9.Group numbers by even and odd using LINQ.
        //int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };



        //10.Given an array of integers, use LINQ to find the first number greater than 100.If none exists, return -1.

        //-------------------------------------------------------------------------------
        //1.Find all numbers that are divisible by both 3 and 5.
        //int[] arr = { 10, 15, 20, 25, 30, 35, 40, 45, 50 };

        //var res = arr.Where(x => x % 3 == 0 && x % 5 == 0).ToArray();

        //foreach (var x in res)
        //{
        //    Console.WriteLine(x);
        //}


        //2.Find the count of prime numbers in an array using LINQ.


        //3.Find the second smallest number using LINQ.
        //int[] arr = { 10, 15, 20, 25, 30, 35, 40, 45, 50 };
        //var res = arr.OrderBy(x => x).Skip(1).First();
        //Console.WriteLine(res);


        //4.Find all distinct characters from a string using LINQ.
        //string str = "linqmethod";
        //var res=str.Distinct().ToArray();
        //foreach(var ch in res)
        //{
        //    Console.WriteLine(ch); 
        //}


        //5.Find the longest string in a string array.
        //string[] arr = { "shivtej", "gayatri", "aryan", "vaishnavi","maithili" };
        //string res=arr.OrderByDescending(x=>x.Length).First();
        //Console.WriteLine(res);

        //6.Find words that start with a vowel using LINQ.
        //string[] arr = { "shivtej", "gayatri", "aryan", "vaishnavi", "maithili","ovee"};
        //var res = arr.Where(x => );



        //7.Check if all elements are positive using LINQ.
        //int[] arr = { 10, 20, 30, 40, 50, 60, 70 };
        //bool res = arr.All(x => x > 0);
        //Console.WriteLine(res);

        //8.Check if any number is negative using LINQ.
        //int[] arr = { 1, 2, 3, 4, 5 };
        //bool res = arr.Any(x => x < 0);
        //Console.WriteLine(res);

        //9.Create a dictionary from an array using LINQ.
        //10Group numbers by their digit count using LINQ.



       






    }
}