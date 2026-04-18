using collectionCsharp;
using collectionCsharp.AdminHelper;
using collectionCsharp.Analyst;
using collectionCsharp.AnalystHelper;
using collectionCsharp.CustomerHelper;
using collectionCsharp.EmployeeHelper;
using collectionCsharp.Helper;
using collectionCsharp.InternHelper;
using collectionCsharp.ManagerHelper;
using collectionCsharp.OperatorHelper;
using collectionCsharp.TeacherHelper;
using collectionCsharp.TrainerHelper;
using CollectioninC_;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




//using collectionCsharp.InternHelper;

//List<Employee> empList = new List<Employee>();
//Employee e1 = new Employee(1, "Raju", 10000);
//Employee e2 = new Employee(2, "Prachi", 20000);
//Employee e3 = new Employee(3, "Charan", 30000);
//Employee e4 = new Employee(4, "Arnav", 40000);
//Employee e5 = new Employee(5, "Rohit", 50000);
//Employee e6 = new Employee(6, "Satyarth", 60000);

//==================================================================================================

//List <Employee> empList = new List<Employee>();    
//Employee e1 = new Employee(1, "Raju", 10000);
//Employee e2 = new Employee(2, "Prachi", 20000);
//Employee e3 = new Employee(3, "Charan", 30000);


//empList.Add(e1);
//empList.Add(e2);
//empList.Add(e3);
//empList.Sort();
//foreach (Employee emp in empList)
//{
//    Console.WriteLine(emp);
//}
//Console.WriteLine("Total Employees: " + empList.Count);

//Employeelist.sort

//int a = 3;

//=============================================================================================================

//NameWSort nameWSort = new NameWSort();

//IdWSort idWSort = new IdWSort();




//SortedSet<Student> ob = new SortedSet<Student>();
//ob.Add(new Student(1, "Raju", 85));
//ob.Add(new Student(2, "Prachi", 90));
//ob.Add(new Student(3, "Charan", 78));

//foreach (Student s in ob)
//{
//    Console.WriteLine(s);
//}


//=====================================================================================================================

//TeacherSortId i= new TeacherSortId();
//TeacherSortName n = new TeacherSortName();

//SortedSet<Teacher> ob1 = new SortedSet<Teacher>(i);
//ob1.Add(new Teacher(1, "Pratham", ".net"));
//ob1.Add(new Teacher(2, "Ritesh", "Angular"));
//ob1.Add(new Teacher(3, "vijay", "React"));

//foreach (Teacher t in ob1)
//{
//    Console.WriteLine(t);
//}

//=====================================================================================================================

//AnalystSortId i = new AnalystSortId();
//AnalystSortName n = new AnalystSortName();

//SortedSet<AnalystClass> ob2 = new SortedSet<AnalystClass>(n);
//ob2.Add(new AnalystClass(1, "Rohit", "Finance"));
//ob2.Add(new AnalystClass(2, "Satyarth", "Marketing"));
//ob2.Add(new AnalystClass(3, "Arnav", "Operations"));

//foreach( var a in ob2)
//{
//    Console.WriteLine(a);
//}

//======================================================================================================================

//AdminSortByName n = new AdminSortByName();
//AdminSortById i = new AdminSortById();

//SortedSet<Admin> ob3 = new SortedSet<Admin>(n);
//ob3.Add(new Admin(1, "Yesh", "HR"));
//ob3.Add(new Admin(2, "Sayali", "IT"));
//ob3.Add(new Admin(3, "Aarpan", "Finance"));

//foreach (Admin a in ob3)
//{
//    Console.WriteLine(a);
//}

//=======================================================================================================================

//SortWId i = new SortWId();
//SortWName n = new SortWName();

//SortedSet<Customer> ob4 = new SortedSet<Customer>(i);
//ob4.Add(new Customer(61, "Shivtej", "akluj"));
//ob4.Add(new Customer(22, "Aryan", "pune"));
//ob4.Add(new Customer(93, "Ram", "mumbai"));

//foreach (Customer c in ob4)
//{
//    Console.WriteLine(c);
//}

//=========================================================================================================================

//IdWSort i = new IdWSort();
//NameWSort1 n = new NameWSort1();

//SortedSet<Employee> ob5 = new SortedSet<Employee>(n);
//ob5.Add(new Employee(1, "Maithili", 10000));
//ob5.Add(new Employee(2, "Pooja", 20000));
//ob5.Add(new Employee(3, "Rutuja", 30000));

//foreach (Employee e in ob5)
//{
//    Console.WriteLine(e);
//}

//===========================================================================================================================

//IdWSort2 id = new IdWSort2();
//NameWSort name = new NameWSort();

//SortedSet<Intern> ob6 = new SortedSet<Intern>(id);
//ob6.Add(new Intern(91, "Aditya", "IIT Bombay"));
//ob6.Add(new Intern(28, "Omkar", "IIT Delhi"));
//ob6.Add(new Intern(39, "Yogesh", "IIT Madras"));

//foreach (Intern s in ob6)
//{
//    Console.WriteLine(s);
//}

//============================================================================================================================

//IdWiseSort id = new IdWiseSort();
//NameWiseSort name = new NameWiseSort();

//SortedSet<Manager> ob7 = new SortedSet<Manager>(id);
//ob7.Add(new Manager(1, "Satya", "IT"));
//ob7.Add(new Manager(2, "Ritika", "Finance"));
//ob7.Add(new Manager(3, "Arman", "Operations"));

//foreach (Manager s in ob7)
//{
//    Console.WriteLine(s);
//}

//=============================================================================================================================

//IdWiseSort id1 = new IdWiseSort();
//NameWiseSort name1 = new NameWiseSort();

//SortedSet<Operator> ob8 = new SortedSet<Operator>(id1);
//ob8.Add(new Operator(1, "Siya", "Support"));
//ob8.Add(new Operator(2, "Rohit", "Maintenance"));
//ob8.Add(new Operator(3, "Arnav", "Customer Service"));

//foreach (Operator op in ob8)
//{
//    Console.WriteLine(op);
//}

//==============================================================================================================================

TrainerSortName i = new TrainerSortName();
TrainerSortName n = new TrainerSortName();

SortedSet<Trainer> ob9 = new SortedSet<Trainer>(n);
ob9.Add(new Trainer(1, "Rohit", "C#"));
ob9.Add(new Trainer(2, "Satyarth", "Java"));
ob9.Add(new Trainer(3, "Arnav", "Python"));

foreach (Trainer t in ob9)
{
    Console.WriteLine(t);
}
/////////////////////////////////////////////////////////////////
///




