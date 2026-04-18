using System;
using System.Data;
using System.Data.SqlClient;

public class  Student 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

}

public class  Program 
{
    public static void Main(string[] args)
    {
       Student  s1 = new Student() { Id = 1, Name = "Shivtej", Age = 20 };
       Student  s2 = new Student() { Id = 2, Name = "Aryan", Age = 22 };
       Student s3 = new Student() { Id = 3, Name = "Sanket", Age = 19 };


        //Step 1: Create a connection to the database
        string constring = "Server=LAPTOP-MGNUF0MQ\\SQLEXPRESS;Database=Student;Trusted_Connection=True;";
       SqlConnection con = new SqlConnection(constring);
       con.Open();

        //Step 2:query to insert data into the database
        String query = "INSERT INTO Student (Id, Name, Age) VALUES (@Id, @Name, @Age)";

        //Step 3: Create a SqlCommand object and execute the query
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.CommandType = CommandType.Text;


        cmd.Parameters.Add("@Age", SqlDbType.Int).Value = s1.Age;

        //Step 4: Execute the command
        int res =cmd.ExecuteNonQuery();
        if(res <=1)
        {
            Console.WriteLine("Data inserted successfully");
        }
        else
        {
            Console.WriteLine("Data insertion failed");
        }
        //=================================================================================================


    }
}