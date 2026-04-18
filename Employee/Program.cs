using EmployeeMangement.BLL;
using EmployeeMangement.Models;
using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        var empService = new EmployeeService();
        var deptService = new DepartmentService();

        while (true)
        {
            Console.WriteLine("\\n1.Add Dept 2.View Dept 3.Update Dept 4.Delete Dept");
            Console.WriteLine("5.Add Emp 6.View Emp 7.Update Emp 8.Delete Emp 9.Exit");

            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Name: ");
                    deptService.Add(new Department { DepartmentName = Console.ReadLine() });
                    break;

                case 2:
                    foreach (var d in deptService.GetAll())
                        Console.WriteLine($"{d.Id} - {d.DepartmentName}");
                    break;

                case 3:
                    Console.Write("Id: ");
                    int did = int.Parse(Console.ReadLine());
                    Console.Write("New Name: ");
                    deptService.Update(new Department { Id = did, DepartmentName = Console.ReadLine() });
                    break;

                case 4:
                    Console.Write("Id: ");
                    deptService.Delete(int.Parse(Console.ReadLine()));
                    break;

                case 5:
                    Employee e = new Employee();
                    Console.Write("Name: ");
                    e.Name = Console.ReadLine();
                    Console.Write("DeptId: ");
                    e.DepartmentId = int.Parse(Console.ReadLine());
                    Console.Write("Salary: ");
                    e.Salary = decimal.Parse(Console.ReadLine());
                    empService.Add(e);
                    break;

                case 6:
                    foreach (var emp in empService.GetAll())
                        Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.DepartmentId} - {emp.Salary}");
                    break;

                case 7:
                    Console.Write("Id: ");
                    empService.Delete(int.Parse(Console.ReadLine()));
                    break;

                case 8:
                    

                    Employee u = new Employee();
                    Console.Write("Id: ");
                    u.Id = int.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    u.Name = Console.ReadLine();
                    Console.Write("DeptId: ");
                    u.DepartmentId = int.Parse(Console.ReadLine());
                    Console.Write("Salary: ");
                    u.Salary = decimal.Parse(Console.ReadLine());
                    empService.Update(u);
                    break;

                case 9:
                    return;
            }
        }
    }
}
