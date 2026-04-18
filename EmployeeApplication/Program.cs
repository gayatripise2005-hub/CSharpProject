//Ado Net is a data access technology from the Microsoft .NET Framework that provides a set of classes for working with data sources such as databases. It allows developers to connect to databases, execute commands, and retrieve results in a structured way. ADO.NET provides a bridge between the front-end user interface and the back-end database, enabling developers to create data-driven applications.

using System.Data;
using System.Data.SqlClient;

/// <summary>
/// this class Repreasent the Table of Student in the database and it has 4 properties Id, Name, Marks 
/// </summary>
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public decimal Salary { get; set; }

    //tostring 
    public override string ToString()
    {
        return $"Emp [Id:{Id}, Name: {Name}, Salary: {Salary} ]";
    }
}

public class Program
{
    public static void Main(string[] args)
    {

        List<Employee> list = new List<Employee>();
        //  Step 1: Connection


        string constring = "Server=LAPTOP-MGNUF0MQ\\SQLEXPRESS;Database=Employee;Trusted_Connection=True;";
        using (SqlConnection con = new SqlConnection(constring))
        {
            con.Open();
            string query = "Select * from Employee";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Employee employee = new Employee()
                    {
                        Id = (int)reader["id"],
                        Name = reader.GetString("name"),
                        Salary = reader.GetDecimal(2)
                    };
                    list.Add(employee);
                }
                //reader.Close();
                //con.Close();
            }
        }

        list.ForEach(Console.WriteLine);
    }
}




////=====================================================================================================================================================
///

//using System;
//using System.Data;
//using System.Data.SqlClient;

//public class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public decimal Salary { get; set; }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Employee s1 = new Employee { Name = "Rutuja", Salary = 85000 };
//        Employee s2 = new Employee { Name = "Vicky", Salary = 92000 };
//        Employee s3 = new Employee { Name = "Charlie", Salary = 78000 };

//        // Step 1: Connection
//        string constring = "Server=LAPTOP-MGNUF0MQ\\SQLEXPRESS;Database=Employee;Trusted_Connection=True;";
//        SqlConnection con = new SqlConnection(constring);
//        con.Open();

//        // Step 2: Query
//        string query = "INSERT INTO Employee (Name, Salary) VALUES (@Name, @Salary)";

//        // Step 3: Command
//        SqlCommand cmd = new SqlCommand(query, con);
//        cmd.Parameters.AddWithValue("@Name", s1.Name);

//      
//        cmd.Parameters.Add("@Salary", SqlDbType.Decimal).Value = s1.Salary;

//        // Step 4: Execute
//        int res = cmd.ExecuteNonQuery();

//        con.Close();

//        if (res >= 1)
//        {
//            Console.WriteLine("Data inserted successfully");
//        }
//        else
//        {
//            Console.WriteLine("Data insertion failed");
//        }

//        Console.ReadLine(); // output rukega
//    }
//}
//=====================================================================








//Employee s1 = new Employee { Name = "Rutuja", Salary = 85000 };
//Employee s2 = new Employee { Name = "Vicky", Salary = 92000 };
//Employee s3 = new Employee { Name = "Charlie", Salary = 78000 };

////Ado .net First Step 
////establishing a connection to the database using a connection string
//string constring = "Server=LAPTOP-MGNUF0MQ\\SQLEXPRESS;Database=Employee;Trusted_Connection=True;";
//SqlConnection con = new SqlConnection(constring);
//con.Open();

////Ado .net Second Step sql query to insert data into the database
//string query = "update [dbo].[Employee] set Name =@name , Salary =@salary where id =@id";

////step 3: creating a SqlCommand object and executing the query
//SqlCommand cmd = new SqlCommand(query, con);
//cmd.Parameters.AddWithValue("@name", "Mahi");
//cmd.Parameters.Add("@id", SqlDbType.Int).Value = 1;
////by using Add Method 
//cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = 77778;

//int res = cmd.ExecuteNonQuery();
//con.Close();

//if (res <= 1)
//{
//    Console.WriteLine("Data Update successfully");
//}
//else
//{
//    Console.WriteLine("Data update failed");
//}