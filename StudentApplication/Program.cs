
//using System.Data;
//using System.Data.SqlClient;

///// <summary>
///// this class Repreasent the Table of Student in the database and it has 4 properties Id, Name, Marks 
///// </summary>
//public class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public decimal Marks { get; set; }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {

//        Student s1 = new Student { Name = "Vicky", Marks = 85 };
//        Student s2 = new Student { Name = "Gayatri", Marks = 92 };
//        Student s3 = new Student { Name = "Viju", Marks = 78 };

//        // //Ado .net First Step 
//        // //establishing a connection to the database using a connection string
//        string constring = "Server=LAPTOP-MGNUF0MQ\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;";
//        SqlConnection con = new SqlConnection(constring);
//        con.Open();

//        //================================================================================================

//        ///Insert

//        //Ado .net Second Step sql query to insert data into the database
//        string query = "INSERT INTO Student (Name, Marks) VALUES (@Name, @Marks)";

//        //step 3: creating a SqlCommand object and executing the query
//        SqlCommand cmd = new SqlCommand(query, con);
//        cmd.Parameters.AddWithValue("@Name", s1.Name);

//        //by using Add Method 
//        cmd.Parameters.Add("@Marks", SqlDbType.Decimal).Value = s1.Marks;

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


//        //============================================================================================================================================
//        ///Update

//        ////Ado .net Second Step sql query to insert data into the database
//        ////string query = "UPDATE Student (Name, Marks) VALUES (@Name, @Marks)";
//        //string query = "UPDATE Student SET Name=@Name, Marks=@Marks WHERE Id=@Id";

//        ////step 3: creating a SqlCommand object and executing the query
//        //SqlCommand cmd = new SqlCommand(query, con);
//        //cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = "Aryan";
//        //cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = 1;
//        //cmd.Parameters.Add("@Marks", SqlDbType.Decimal).Value = 90;

//        ////by using Add Method 
//        ////cmd.Parameters.Add("@Marks", SqlDbType.Decimal).Value = s1.Marks;

//        //int res = cmd.ExecuteNonQuery();
//        //con.Close();

//        //if (res >= 1)
//        //{
//        //    Console.WriteLine("Data updated successfully");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("Data updated failed");
//        //}

//        //==================================================================================================

//        ///Select

//        //List<Student> s = new List<Student>();

//        //string query = "SELECT * FROM Student";
//        //SqlCommand cmd = new SqlCommand(query, con);
//        //cmd.CommandText = query;
//        //using (SqlDataReader reader = cmd.ExecuteReader())
//        //{
//        //    while (reader.Read())
//        //    {
//        //        Student student = new Student
//        //        {
//        //            Id = reader.GetInt32(0),
//        //            Name = reader.GetString(1),
//        //            Marks = reader.GetDecimal(2)
//        //        };
//        //        s.Add(student);
//        //    }
//        //}
//        //s.ForEach(Console.WriteLine);




//        //=========================================================================================================
//        //string query = "DELETE FROM Student WHERE SET Name=@Name, Marks=@Marks WHERE Id=@Id";

//        ////step 3: creating a SqlCommand object and executing the query
//        //SqlCommand cmd = new SqlCommand(query, con);
//        //cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = "Aryan";
//        //cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = 1;
//        //cmd.Parameters.Add("@Marks", SqlDbType.Decimal).Value = 90;

//        ////by using Add Method 
//        ////cmd.Parameters.Add("@Marks", SqlDbType.Decimal).Value = s1.Marks;

//        //int res = cmd.ExecuteNonQuery();
//        //con.Close();

//        //if (res >= 1)
//        //{
//        //    Console.WriteLine("Data Deleted successfully");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("Data Deleted failed");
//        //}

//        //=====================================================================================================================
//        ///Delete

//        ////step 1 : write query 
//        //string query = "DELETE FROM Student WHERE Id=@Id";

//        ////step 2 : create command object and execute the query
//        //SqlCommand cmd = new SqlCommand(query, con);

//        //cmd.Parameters.Add("@Id", SqlDbType.Int).Value = 1;

//        //int res = cmd.ExecuteNonQuery();
//        //con.Close();

//        //if (res >= 1)
//        //{
//        //    Console.WriteLine("Data Deleted successfully");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("Data Deleted failed");
//        //}


//    }
//}




//==========================================================================================================================================================================

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Marks { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        string constring = "Server=LAPTOP-MGNUF0MQ\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;";

        Console.WriteLine("1. Insert");
        Console.WriteLine("2. Update");
        Console.WriteLine("3. Delete");
        Console.WriteLine("4. Select");

        Console.Write("Enter Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        SqlConnection con = new SqlConnection(constring);
        con.Open();

        switch (choice)
        {
            // ================= INSERT =================
            case 1:

                Student s1 = new Student { Name = "Vicky", Marks = 85 };

                string query = "INSERT INTO Student (Name, Marks) VALUES (@Name, @Marks)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", s1.Name);
                cmd.Parameters.Add("@Marks", SqlDbType.Decimal).Value = s1.Marks;

                int res = cmd.ExecuteNonQuery();

                if (res >= 1)
                    Console.WriteLine("Data inserted successfully");
                else
                    Console.WriteLine("Data insertion failed");

                break;

            // ================= UPDATE =================
            case 2:

                string query2 = "UPDATE Student SET Name=@Name, Marks=@Marks WHERE Id=@Id";
                SqlCommand cmd2 = new SqlCommand(query2, con);

                cmd2.Parameters.Add("@Name", SqlDbType.VarChar).Value = "Aryan";
                cmd2.Parameters.Add("@Id", SqlDbType.Int).Value = 1;
                cmd2.Parameters.Add("@Marks", SqlDbType.Decimal).Value = 90;

                int res2 = cmd2.ExecuteNonQuery();

                if (res2 >= 1)
                    Console.WriteLine("Data updated successfully");
                else
                    Console.WriteLine("Data update failed");

                break;

            // ================= DELETE =================
            case 3:

                string query3 = "DELETE FROM Student WHERE Id=@Id";
                SqlCommand cmd3 = new SqlCommand(query3, con);

                cmd3.Parameters.Add("@Id", SqlDbType.Int).Value = 1;

                int res3 = cmd3.ExecuteNonQuery();

                if (res3 >= 1)
                    Console.WriteLine("Data deleted successfully");
                else
                    Console.WriteLine("Data delete failed");

                break;

            // ================= SELECT =================
            case 4:

                List<Student> s = new List<Student>();

                string query4 = "SELECT * FROM Student";
                SqlCommand cmd4 = new SqlCommand(query4, con);

                using (SqlDataReader reader = cmd4.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Student student = new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Marks = reader.GetDecimal(2)
                        };
                        s.Add(student);
                    }
                }

                foreach (var item in s)
                {
                    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Marks: {item.Marks}");
                }

                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }

        con.Close();
    }
}


//=====================================================================================================================