


using CafeManagementSystem.Data;
using CafeManagementSystem.Entity.Model;
using CafeManagementSystem.Repository.Implementation;
using CafeManagementSystem.Service.Implementation;
using System;
using System.Threading.Tasks;

namespace CafeManagementSystem.OperationHandler
{
    public class CrudHandler
    {
        public async Task Start()
        {
            var context = new AppDbContext();

            var chefService =
                new ChefsService(new Repository<Chefs>(context));

            var customerService =
                new CustomerService(new Repository<Customer>(context));

            var menuService =
                new MenuItemService(new Repository<MenuItem>(context));

            var staffService =
                new Staffservice(new Repository<Staff>(context));

            string choice;

            do
            {
                Console.WriteLine("\n===== SELECT MODULE =====");
                Console.WriteLine("1. Chefs");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. MenuItem");
                Console.WriteLine("4. Staff");
                Console.WriteLine("0. Exit");

                Console.Write("Enter Choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await ChefMenu(chefService);
                        break;

                    case "2":
                        await CustomerMenu(customerService);
                        break;

                    case "3":
                        await MenuItemMenu(menuService);
                        break;

                    case "4":
                        await StaffMenu(staffService);
                        break;

                }

            } while (choice != "0");
        }

        // ================= CHEF =================
        private async Task ChefMenu(ChefsService service)
        {
            Console.WriteLine("\n--- CHEF OPERATIONS ---");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Get All");
            Console.WriteLine("3.Get By Id");
            Console.WriteLine("4.Update");
            Console.WriteLine("5.Delete");

            Console.Write("Enter Operation: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    Chefs c = new Chefs();

                    Console.Write("Name: ");
                    c.Name = Console.ReadLine();

                    Console.Write("Speciality: ");
                    c.Speciality = Console.ReadLine();

                    await service.AddAsync(c);
                    Console.WriteLine("Chef Added");
                    break;

                case "2":
                    var chefs = await service.GetAllAsync();
                    chefs.ForEach(x => Console.WriteLine(x));
                    break;

                case "3":
                    Console.Write("Enter Id: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    var chef = await service.GetByIdAsync(id);
                    Console.WriteLine(chef);
                    break;

                case "4":
                    Console.Write("Enter Id: ");
                    int uid = Convert.ToInt32(Console.ReadLine());

                    Chefs uc = new Chefs();

                    Console.Write("Name: ");
                    uc.Name = Console.ReadLine();

                    Console.Write("Speciality: ");
                    uc.Speciality = Console.ReadLine();

                    uc.Id = uid;

                    await service.UpdateAsync(uc);
                    Console.WriteLine("Updated");
                    break;

                case "5":
                    Console.Write("Enter Id: ");
                    int did = Convert.ToInt32(Console.ReadLine());

                    await service.DeleteAsync(did);
                    Console.WriteLine("Deleted");
                    break;
            }
        }

        // ================= CUSTOMER =================
        private async Task CustomerMenu(CustomerService service)
        {
            Console.WriteLine("\n--- CUSTOMER OPERATIONS ---");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Get All");
            Console.WriteLine("3.Get By Id");
            Console.WriteLine("4.Update");
            Console.WriteLine("5.Delete");

            Console.Write("Enter Operation: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    Customer c = new Customer();

                    Console.Write("Name: ");
                    c.Name = Console.ReadLine();

                    Console.Write("Phone: ");
                    c.PhoneNumber = Console.ReadLine();

                    await service.AddAsync(c);
                    Console.WriteLine("Customer Added");
                    break;

                case "2":
                    var customers = await service.GetAllAsync();
                    customers.ForEach(x => Console.WriteLine(x));
                    break;

                case "3":
                    Console.Write("Enter Id: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    var customer = await service.GetByIdAsync(id);
                    Console.WriteLine(customer);
                    break;

                case "4":
                    Console.Write("Enter Id: ");
                    int uid = Convert.ToInt32(Console.ReadLine());

                    Customer uc = new Customer();

                    Console.Write("Name: ");
                    uc.Name = Console.ReadLine();

                    Console.Write("Phone: ");
                    uc.PhoneNumber = Console.ReadLine();

                    uc.Id = uid;

                    await service.UpdateAsync(uc);
                    Console.WriteLine("Updated");
                    break;

                case "5":
                    Console.Write("Enter Id: ");
                    int did = Convert.ToInt32(Console.ReadLine());

                    await service.DeleteAsync(did);
                    Console.WriteLine("Deleted");
                    break;
            }
        }

        // ================= MENU ITEM =================
        private async Task MenuItemMenu(MenuItemService service)
        {
            Console.WriteLine("\n--- MENU OPERATIONS ---");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Get All");
            Console.WriteLine("3.Get By Id");
            Console.WriteLine("4.Update");
            Console.WriteLine("5.Delete");

            Console.Write("Enter Operation: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    MenuItem m = new MenuItem();

                    Console.Write("Name: ");
                    m.Name = Console.ReadLine();

                    Console.Write("Price: ");
                    m.Price = Convert.ToDecimal(Console.ReadLine());

                    await service.AddAsync(m);
                    Console.WriteLine("Menu Item Added");
                    break;

                case "2":
                    var list = await service.GetAllAsync();
                    list.ForEach(x => Console.WriteLine(x));
                    break;

                case "3":
                    Console.Write("Enter Id: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    var item = await service.GetByIdAsync(id);
                    Console.WriteLine(item);
                    break;

                case "4":
                    Console.Write("Enter Id: ");
                    int uid = Convert.ToInt32(Console.ReadLine());

                    MenuItem um = new MenuItem();

                    Console.Write("Name: ");
                    um.Name = Console.ReadLine();

                    Console.Write("Price: ");
                    um.Price = Convert.ToDecimal(Console.ReadLine());

                    um.Id = uid;

                    await service.UpdateAsync(um);
                    Console.WriteLine("Updated");
                    break;

                case "5":
                    Console.Write("Enter Id: ");
                    int did = Convert.ToInt32(Console.ReadLine());

                    await service.DeleteAsync(did);
                    Console.WriteLine("Deleted");
                    break;
            }
        }

        // ================= STAFF =================
        private async Task StaffMenu(Staffservice service)
        {
            Console.WriteLine("\n--- STAFF OPERATIONS ---");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Get All");
            Console.WriteLine("3.Get By Id");
            Console.WriteLine("4.Update");
            Console.WriteLine("5.Delete");

            Console.Write("Enter Operation: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    Staff s = new Staff();

                    Console.Write("Name: ");
                    s.Name = Console.ReadLine();

                    Console.Write("Position: ");
                    s.Position = Console.ReadLine();

                    Console.Write("Salary: ");
                    s.Salary = Convert.ToDecimal(Console.ReadLine());

                    await service.AddAsync(s);
                    Console.WriteLine("Staff Added");
                    break;

                case "2":
                    var list = await service.GetAllAsync();
                    list.ForEach(x => Console.WriteLine(x));
                    break;

                case "3":
                    Console.Write("Enter Id: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    var staff = await service.GetByIdAsync(id);
                    Console.WriteLine(staff);
                    break;

                case "4":
                    Console.Write("Enter Id: ");
                    int uid = Convert.ToInt32(Console.ReadLine());

                    Staff us = new Staff();

                    Console.Write("Name: ");
                    us.Name = Console.ReadLine();

                    Console.Write("Position: ");
                    us.Position = Console.ReadLine();

                    Console.Write("Salary: ");
                    us.Salary = Convert.ToDecimal(Console.ReadLine());

                    us.Id = uid;

                    await service.UpdateAsync(us);
                    Console.WriteLine("Updated");
                    break;

                case "5":
                    Console.Write("Enter Id: ");
                    int did = Convert.ToInt32(Console.ReadLine());

                    await service.DeleteAsync(did);
                    Console.WriteLine("Deleted");
                    break;
            }
        }
    }
}