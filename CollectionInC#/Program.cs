using CollectionInC_;
using System;
using System.Collections.Generic;
using CollectionInC_.LambdaSorting;

//IComparer<Person> c = Comparer<Person>.Create(((x, y) => x.Id.CompareTo(y.Id)));
//SortedSet<Person> ob10 = new SortedSet<Person>(Comparer<Person>.Create((x, y) => x.Id.CompareTo(y.Id)));
//SortedSet<Person> p=new SortedSet<Person>(c);

//p.Add(new Person(11, "Shivtej", "Customer"));
//p.Add(new Person(9, "Maithili", "Employee"));
//p.Add(new Person(3, "Gayatri", "Manager"));


//foreach (var item in p )
//{
//    Console.WriteLine(p);
//}

//=====================================================================================

//Sort by using Linq

//// Step 1: Create list
//   List<Person> p = new List<Person>()
//   { 
//            new Person { Id = 3, Name = "Rohit",Role="Manager" },
//            new Person { Id = 1, Name = "Amit" },
//            new Person { Id = 2, Name = "Satyarth" },
//            new Person { Id = 1, Name = "Zara" }
//   };

//// Step 2: LINQ Sorting
//var sortedList = p
//    .OrderBy(x => x.Id)
//    .ThenBy(x => x.Name)
//    .ToList();

//// Step 3: Display Output
//sortedList.ForEach(x => Console.WriteLine(x));

//=====================================================================================


public class Demo
{
    public static void Run()
    {
        List<Advisor> a = new List<Advisor>
            {
                new Advisor(1, "Alice", "Computer Science")),
                new Advisor(2, "Bob", "Mathematics"),
                new Advisor(3, "Charlie", "Physics"),
                new Advisor(4, "David", "Chemistry"),
                new Advisor(5, "Eve", "Biology")
            };
        IComparer<Advisor> comparer = Comparer<Advisor>.Create((x, y) => x.Name.CompareTo(y.Name));
        a.Sort(comparer);
        foreach (var advisor in a)
        {
            Console.WriteLine(advisor);
        }

        //var sortedByDepartment = a.OrderBy(advisor => advisor.Department);


    }

}



