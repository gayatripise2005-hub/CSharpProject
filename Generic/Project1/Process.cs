using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GenericProject.Project1
{

    public class Process<T> where T : BaseEntity, new()
    {
        public static void Operation(IRepository<T> repository, int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Name: ");
                    string name = Console.ReadLine();

                    var obj = new T();
                    obj.Id = id;
                    typeof(T).GetProperty("Name")?.SetValue(obj, name);

                    repository.Add(obj);
                    Console.WriteLine("Element added successfully.");
                    break;

                case 2:
                    Console.WriteLine("Enter Id to remove: ");
                    int removeId = Convert.ToInt32(Console.ReadLine());
                    repository.Delete(removeId);
                    Console.WriteLine("Element removed successfully.");
                    break;

                case 3:
                    Console.WriteLine("Elements in the repository:");
                    foreach (var item in repository.GetAll())
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case 4:
                    Console.WriteLine("Enter Id to get element: ");
                    int searchId = Convert.ToInt32(Console.ReadLine());
                    var found = repository.GetById(searchId);
                    if (found != null)
                    {
                        Console.WriteLine($"Found: {found}");
                    }
                    else
                    {
                        Console.WriteLine("Element not found.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }



}
