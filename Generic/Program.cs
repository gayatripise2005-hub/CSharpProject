using GenericProject.Project1;
using System;



namespace GenericProject
{

    class Program
    {
        public static void Main(string[] args)
        {
            IRepository<Event> repository = new Repository<Event>();
            Event eve = new Event { EventName = "xyz", Location = "Pune" };
            Event eve2 = new Event { EventName = "abc", Location = "mumbai" };

            repository.Add(eve);
            repository.Add(eve2);



            // Call Process class to handle menu
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n--- Event Menu ---");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Remove");
                Console.WriteLine("3. GetAll");
                Console.WriteLine("4. Get by Id");
                Console.WriteLine("5. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    exit = true;
                    Console.WriteLine("Exiting...");
                }
                else
                {
                    Process<Event>.Operation(repository, choice);
                }


                //repository.Add(eve);
                //repository.Add(eve2);

                //Console.WriteLine("event");
                //PrintAll(repository);
                //repository.Delete(1);
                //Console.WriteLine("event delete");
                //PrintAll(repository);


                ////var even = repository.GetById(1);

                //repository.Delete(1);

                //static void PrintAll<T>(IRepository<T> repo) where T : BaseEntity
                //{
                //    var List = repo.GetAll();

                //    foreach (var item in List)
                //    {
                //        Console.WriteLine(item);
                //    }
                // }

            }








        }
    }
}