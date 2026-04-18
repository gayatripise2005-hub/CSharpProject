using System;
using System.Reflection.Metadata.Ecma335;

namespace Demo173
{

    public class Display<T>
    {
        public static void Show(T[] arr)
        {
            foreach (T t in arr)
            {
                Console.WriteLine(t);
            }
        }


//        // public static void Show1(T[] arr)
//        //{
//        //    foreach (T item in arr)
//        //    {
//        //        Console.WriteLine(item);
//        //    }
//        //}

//    //public class Program
//    //{
//        //public static void DisplayAges(int[] ages)
//        //{
//        //    Console.WriteLine("Ages in the array are:");
//        //    for (int i = 0; i < ages.Length; i++)
//        //    {
//        //        Console.WriteLine(ages[i]);
//        //    }
//        //}

//        //public static void UI(ref int[] ages) {
//        //    for (int i = 0; i < ages.Length; i++)
//        //    {
//        //        Console.WriteLine($"Enter age for arr[{i}]:");
//        //        a[i] = int.Parse(Console.ReadLine());
//        //    }
//              //}
//        public static void Main(string[]args)
//        {
//            //int[] ages = { 12, 15, 18, 20, 25, 30, 35, 40, 45, 50 };
//            //int[] arr;
//            //arr = new int[5];

//            int[] ages = {1,5,6,7,6};

//            Display<int>.Show(ages);








//        }


//        //string[] names = new string[5] { "pooja", "ram", "sita", "gita", "laxman" };
//        //areay declaration and creation
//        //names ={ "pooja", "ram", "sita", "gita", "laxman" };
//        //its not correct way to declare and initialize an array

//        //int[] numbers = new int[5] { 1, 3, 5, 7, 9 };

//        //arr[0]= int.Parse(Console.ReadLine());
//        //arr[1]= 15;
//        //arr[2]= 18;
//        //arr[3]= 20;
//        //arr[4]= 25;


//        // user input for array elements

//        //DisplayAges(arr);


    }
//
}