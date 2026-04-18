
//using LibraryMangementWithGenericRepository.Data;
//using LibraryMangementWithGenericRepository.Entity.Model;
//using LibraryMangementWithGenericRepository.Repositories.Defination;
//using LibraryMangementWithGenericRepository.Repositories.Implmentation;
//using LibraryMangementWithGenericRepository.Services.Defination;
//using LibraryMangementWithGenericRepository.Services.Implementation;

//public class Program
//{
//    public static async Task Main(string[] args)
//    {
//        //var context = new AppDbContext();
//        try
//        {
//            await RunApp();   // 👈 yaha call hoga
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("ERROR: " + ex.Message);
//            Console.WriteLine("STACK: " + ex.StackTrace);
//        }
//        static async Task RunApp()
//        {
//            var context = new AppDbContext();

//            // tumhara pura existing code yaha paste karo
//        }

//        Console.ReadLine();

//        // Repositories
//        IRepository<Book> bookRepo = new Repository<Book>(context);
//        IRepository<Customer> customerRepo = new Repository<Customer>(context);
//        IRepository<Category> categoryRepo = new Repository<Category>(context);
//        IRepository<Address> addressRepo = new Repository<Address>(context);

//        // Services (using interface)
//        IBookServices bookService = new BookServices(bookRepo);
//        ICustomerServices customerService = new CustomerServices(customerRepo);
//        ICategoryservices categoryService = new CategoryService(categoryRepo);
//        IAddressServices addressService = new AddressServices(addressRepo);

//        while (true)
//        {
//            Console.WriteLine("\n===== MAIN MENU =====");
//            Console.WriteLine("1. Book");
//            Console.WriteLine("2. Customer");
//            Console.WriteLine("3. Category");
//            Console.WriteLine("4. Address");
//            Console.WriteLine("5. Exit");

//            int main = Convert.ToInt32(Console.ReadLine());

//            switch (main)
//            {
//                case 1:
//                    await BookMenu(bookService);
//                    break;

//                case 2:
//                    await CustomerMenu(customerService);
//                    break;

//                case 3:
//                    await CategoryMenu(categoryService);
//                    break;

//                case 4:
//                    await AddressMenu(addressService);
//                    break;

//                case 5:
//                    return;
//            }
//        }
//    }

//    // ================= BOOK =================
//    static async Task BookMenu(IBookServices service)
//    {
//        Console.WriteLine("\n1.Add 2.View 3.Delete 4.Update");
//        int ch = Convert.ToInt32(Console.ReadLine());

//        if (ch == 1)
//        {
//            Console.Write("Name: ");
//            string name = Console.ReadLine();

//            Console.Write("Author: ");
//            string author = Console.ReadLine();

//            await service.AddAsync(new Book { Name = name, Author = author });
//        }
//        else if (ch == 2)
//        {
//            var list = await service.GetAllAsync();
//            foreach (var item in list)
//                Console.WriteLine(item);
//        }
//        else if (ch == 3)
//        {
//            Console.Write("Id: ");
//            int id = Convert.ToInt32(Console.ReadLine());
//            await service.DeleteAsync(id);
//        }
//        else if (ch == 4)
//        {
//            Console.Write("Id: ");
//            int id = Convert.ToInt32(Console.ReadLine());

//            Console.Write("New Name: ");
//            string name = Console.ReadLine();

//            Console.Write("New Author: ");
//            string author = Console.ReadLine();

//            await service.UpdateAsync(new Book
//            {
//                Id = id,
//                Name = name,
//                Author = author
//            });
//        }
//    }

//    // ================= CUSTOMER =================
//    static async Task CustomerMenu(ICustomerServices service)
//    {
//        Console.WriteLine("\n1.Add 2.View 3.Delete 4.Update");
//        int ch = Convert.ToInt32(Console.ReadLine());

//        if (ch == 1)
//        {
//            Console.Write("Name: ");
//            string name = Console.ReadLine();

//            Console.Write("Phone: ");
//            string phone = Console.ReadLine();

//            Console.Write("Email: ");
//            string email = Console.ReadLine();

//            await service.AddAsync(new Customer
//            {
//                Name = name,
//                Phone = phone,
//                email = email
//            });
//        }
//        else if (ch == 2)
//        {
//            var list = await service.GetAllAsync();
//            foreach (var item in list)
//                Console.WriteLine(item);
//        }
//        else if (ch == 3)
//        {
//            Console.Write("Id: ");
//            int id = Convert.ToInt32(Console.ReadLine());
//            await service.DeleteAsync(id);
//        }
//        else if (ch == 4)
//        {
//            Console.Write("Id: ");
//            int id = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Name: ");
//            string name = Console.ReadLine();

//            Console.Write("Phone: ");
//            string phone = Console.ReadLine();

//            Console.Write("Email: ");
//            string email = Console.ReadLine();

//            await service.UpdateAsync(new Customer
//            {
//                Id = id,
//                Name = name,
//                Phone = phone,
//                email = email
//            });
//        }
//    }

//    // ================= CATEGORY =================
//    static async Task CategoryMenu(ICategoryservices service)
//    {
//        Console.WriteLine("\n1.Add 2.View 3.Delete 4.Update");
//        int ch = Convert.ToInt32(Console.ReadLine());

//        if (ch == 1)
//        {
//            Console.Write("Name: ");
//            string name = Console.ReadLine();

//            Console.Write("Description: ");
//            string desc = Console.ReadLine();

//            await service.AddAsync(new Category
//            {
//                CategoryName = name,
//                Description = desc
//            });
//        }
//        else if (ch == 2)
//        {
//            var list = await service.GetAllAsync();
//            foreach (var item in list)
//                Console.WriteLine(item);
//        }
//        else if (ch == 3)
//        {
//            Console.Write("Id: ");
//            int id = Convert.ToInt32(Console.ReadLine());
//            await service.DeleteAsync(id);
//        }
//        else if (ch == 4)
//        {
//            Console.Write("Id: ");
//            int id = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Name: ");
//            string name = Console.ReadLine();

//            Console.Write("Description: ");
//            string desc = Console.ReadLine();

//            await service.UpdateAsync(new Category
//            {
//                Id = id,
//                CategoryName = name,
//                Description = desc
//            });
//        }
//    }

//    // ================= ADDRESS =================
//    static async Task AddressMenu(IAddressServices service)
//    {
//        Console.WriteLine("\n1.Add 2.View 3.Delete 4.Update");
//        int ch = Convert.ToInt32(Console.ReadLine());

//        if (ch == 1)
//        {
//            Console.Write("City: ");
//            string city = Console.ReadLine();

//            Console.Write("PinCode: ");
//            string pin = Console.ReadLine();

//            await service.AddAsync(new Address
//            {
//                City = city,
//                PinCode = pin
//            });
//        }
//        else if (ch == 2)
//        {
//            var list = await service.GetAllAsync();
//            foreach (var item in list)
//                Console.WriteLine(item);
//        }
//        else if (ch == 3)
//        {
//            Console.Write("Id: ");
//            int id = Convert.ToInt32(Console.ReadLine());
//            await service.DeleteAsync(id);
//        }
//        else if (ch == 4)
//        {
//            Console.Write("Id: ");
//            int id = Convert.ToInt32(Console.ReadLine());

//            Console.Write("City: ");
//            string city = Console.ReadLine();

//            Console.Write("PinCode: ");
//            string pin = Console.ReadLine();

//            await service.UpdateAsync(new Address
//            {
//                Id = id,
//                City = city,
//                PinCode = pin
//            });
//        }
//    }
//}





using LibraryMangementWithGenericRepository.Data;
using LibraryMangementWithGenericRepository.Entity.Model;
using LibraryMangementWithGenericRepository.Repositories.Defination;
using LibraryMangementWithGenericRepository.Repositories.Implmentation;
using LibraryMangementWithGenericRepository.Services.Defination;
using LibraryMangementWithGenericRepository.Services.Implementation;

public class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            await RunApp();
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
        }

        Console.ReadLine();
    }

     public static async Task RunApp()
    {
        var context = new AppDbContext();

        // Repositories
        IRepository<Book> bookRepo = new Repository<Book>(context);
        IRepository<Customer> customerRepo = new Repository<Customer>(context);
        IRepository<Category> categoryRepo = new Repository<Category>(context);
        IRepository<Address> addressRepo = new Repository<Address>(context);

        // Services
        IBookServices bookService = new BookServices(bookRepo);
        ICustomerServices customerService = new CustomerServices(customerRepo);
        ICategoryservices categoryService = new CategoryService(categoryRepo); 
        IAddressServices addressService = new AddressServices(addressRepo);

        while (true)
        {
            Console.WriteLine("\n===== MAIN MENU =====");
            Console.WriteLine("1. Book");
            Console.WriteLine("2. Customer");
            Console.WriteLine("3. Category");
            Console.WriteLine("4. Address");
            Console.WriteLine("5. Exit");

            if (!int.TryParse(Console.ReadLine(), out int main))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            switch (main)
            {
                case 1:
                    await BookMenu(bookService);
                    break;

                case 2:
                    await CustomerMenu(customerService);
                    break;

                case 3:
                    await CategoryMenu(categoryService);
                    break;

                case 4:
                    await AddressMenu(addressService);
                    break;

                case 5:
                    return;
            }
        }
    }

    // ================= BOOK =================
    static async Task BookMenu(IBookServices service)
    {
        Console.WriteLine("\n1.Add 2.View 3.Delete 4.Update");

        if (!int.TryParse(Console.ReadLine(), out int ch)) return;

        if (ch == 1)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Author: ");
            string author = Console.ReadLine() ?? "";

            await service.AddAsync(new Book { Name = name, Author = author });
        }
        else if (ch == 2)
        {
            var list = await service.GetAllAsync();
            foreach (var item in list)
                Console.WriteLine(item);
        }
        else if (ch == 3)
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            await service.DeleteAsync(id);
        }
        else if (ch == 4)
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("New Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("New Author: ");
            string author = Console.ReadLine() ?? "";

            await service.UpdateAsync(new Book
            {
                Id = id,
                Name = name,
                Author = author
            });
        }
    }

    // ================= CUSTOMER =================
    static async Task CustomerMenu(ICustomerServices service)
    {
        Console.WriteLine("\n1.Add 2.View 3.Delete 4.Update");

        if (!int.TryParse(Console.ReadLine(), out int ch)) return;

        if (ch == 1)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Phone: ");
            string phone = Console.ReadLine() ?? "";

            Console.Write("Email: ");
            string email = Console.ReadLine() ?? "";

            await service.AddAsync(new Customer
            {
                Name = name,
                Phone = phone,
                email = email
            });
        }
        else if (ch == 2)
        {
            var list = await service.GetAllAsync();
            foreach (var item in list)
                Console.WriteLine(item);
        }
        else if (ch == 3)
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            await service.DeleteAsync(id);
        }
        else if (ch == 4)
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Phone: ");
            string phone = Console.ReadLine() ?? "";

            Console.Write("Email: ");
            string email = Console.ReadLine() ?? "";

            await service.UpdateAsync(new Customer
            {
                Id = id,
                Name = name,
                Phone = phone,
                email = email
            });
        }
    }

    // ================= CATEGORY =================
    static async Task CategoryMenu(ICategoryservices service)
    {
        Console.WriteLine("\n1.Add 2.View 3.Delete 4.Update");

        if (!int.TryParse(Console.ReadLine(), out int ch)) return;

        if (ch == 1)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Description: ");
            string desc = Console.ReadLine() ?? "";

            await service.AddAsync(new Category
            {
                CategoryName = name,
                Description = desc
            });
        }
        else if (ch == 2)
        {
            var list = await service.GetAllAsync();
            foreach (var item in list)
                Console.WriteLine(item);
        }
        else if (ch == 3)
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            await service.DeleteAsync(id);
        }
        else if (ch == 4)
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Description: ");
            string desc = Console.ReadLine() ?? "";

            await service.UpdateAsync(new Category
            {
                Id = id,
                CategoryName = name,
                Description = desc
            });
        }
    }

    // ================= ADDRESS =================
    static async Task AddressMenu(IAddressServices service)
    {
        Console.WriteLine("\n1.Add 2.View 3.Delete 4.Update");

        if (!int.TryParse(Console.ReadLine(), out int ch)) return;

        if (ch == 1)
        {
            Console.Write("City: ");
            string city = Console.ReadLine() ?? "";

            Console.Write("PinCode: ");
            string pin = Console.ReadLine() ?? "";

            await service.AddAsync(new Address
            {
                City = city,
                PinCode = pin
            });
        }
        else if (ch == 2)
        {
            var list = await service.GetAllAsync();
            foreach (var item in list)
                Console.WriteLine(item);
        }
        else if (ch == 3)
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            await service.DeleteAsync(id);
        }
        else if (ch == 4)
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("City: ");
            string city = Console.ReadLine() ?? "";

            Console.Write("PinCode: ");
            string pin = Console.ReadLine() ?? "";

            await service.UpdateAsync(new Address
            {
                Id = id,
                City = city,
                PinCode = pin
            });
        }
    }
}


