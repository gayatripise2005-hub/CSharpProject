using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeMangement.Models;
namespace EmployeeMangement.DAL
{
    //public class EmployeeRepository
    //{
    //    public void Add(Employee e)
    //    {
    //        using (SqlConnection con = new SqlConnection(DbHelper.conStr))
    //        {
    //            SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeMangement(Name,DepartmentId,Salary) VALUES(@n,@d,@s)", con);
    //            cmd.Parameters.AddWithValue("@n", e.Name);
    //            cmd.Parameters.AddWithValue("@d", e.DepartmentId);
    //            cmd.Parameters.AddWithValue("@s", e.Salary);
    //            con.Open();
    //            cmd.ExecuteNonQuery();
    //        }
    //    }


    //    public void Delete(Employee e) 
    //    {
    //        using (SqlConnection con = new SqlConnection(DbHelper.conStr))
    //        {
    //            SqlCommand cmd = new SqlCommand("DELETE FROM EmployeeMangement WHERE Id=@id", con);
    //            cmd.Parameters.AddWithValue("@id", e.Id);
    //            con.Open();
    //            cmd.ExecuteNonQuery();
    //        }
    //    }

    //    public void Update(Employee e)
    //    {
    //        using (SqlConnection con = new SqlConnection(DbHelper.conStr))
    //        {
    //            SqlCommand cmd = new SqlCommand("UPDATE EmployeeMangement SET Name=@n,DepartmentId=@d,Salary=@s WHERE Id=@id", con);
    //            cmd.Parameters.AddWithValue("@n", e.Name);
    //            cmd.Parameters.AddWithValue("@d", e.DepartmentId);
    //            cmd.Parameters.AddWithValue("@s", e.Salary);
    //            cmd.Parameters.AddWithValue("@id", e.Id);
    //            con.Open();
    //            cmd.ExecuteNonQuery();
    //        }
    //    }

    //    public List<Employee> GetAll()
    //    {
    //        List<Employee> list = new List<Employee>();
    //        using (SqlConnection con = new SqlConnection(DbHelper.conStr))
    //        {
    //            SqlCommand cmd = new SqlCommand("SELECT * FROM EmployeeMangement", con);
    //            con.Open();
    //            SqlDataReader reader = cmd.ExecuteReader();
    //            while (reader.Read())
    //            {
    //                Employee e = new Employee();
    //                e.Id = (int)reader["Id"];
    //                e.Name = reader["Name"].ToString();
    //                e.DepartmentId = (int)reader["DepartmentId"];
    //                e.Salary = (decimal)reader["Salary"];
    //                list.Add(e);
    //            }
    //        }
    //        return list;
    //    }
    //}








    //====================================================================================================================================


    public class EmployeeRepository
    {
        public void Add(Employee e)
        {
            using (SqlConnection con = new SqlConnection(DbHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee(Name,DepartmentId,Salary) VALUES(@n,@d,@s)", con);
                cmd.Parameters.AddWithValue("@n", e.Name);
                cmd.Parameters.AddWithValue("@d", e.DepartmentId);
                cmd.Parameters.AddWithValue("@s", e.Salary);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Employee e)
        {
            using (SqlConnection con = new SqlConnection(DbHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Employee SET Name=@n,DepartmentId=@d,Salary=@s WHERE Id=@id", con);
                cmd.Parameters.AddWithValue("@n", e.Name);
                cmd.Parameters.AddWithValue("@d", e.DepartmentId);
                cmd.Parameters.AddWithValue("@s", e.Salary);
                cmd.Parameters.AddWithValue("@id", e.Id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(DbHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE Id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Employee> GetAll()
        {
            List<Employee> list = new List<Employee>();

            using (SqlConnection con = new SqlConnection(DbHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new Employee
                    {
                        Id = (int)dr["Id"],
                        Name = dr["Name"].ToString(),
                        DepartmentId = (int)dr["DepartmentId"],
                        Salary = (decimal)dr["Salary"]
                    });
                }
            }
            return list;
        }
    }







}