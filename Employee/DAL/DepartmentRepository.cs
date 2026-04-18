using EmployeeMangement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangement.DAL
{
    //public class DepartmentRepository
    //{
    //    public void Add(Department d)
    //    {
    //        using (SqlConnection con = new SqlConnection(DbHelper.conStr))
    //        {
    //            SqlCommand cmd = new SqlCommand("INSERT INTO Department(DepartmentName) VALUES(@n)", con);
    //            cmd.Parameters.AddWithValue("@n", d.DepartmentName);
    //            con.Open();
    //            cmd.ExecuteNonQuery();
    //        }
    //    }

    //    public void Delete(Department d)
    //    {
    //        using (SqlConnection con = new SqlConnection(DbHelper.conStr))
    //        {
    //            SqlCommand cmd = new SqlCommand("DELETE FROM Department WHERE Id=@id", con);
    //            cmd.Parameters.AddWithValue("@id", d.Id);
    //            con.Open();
    //            cmd.ExecuteNonQuery();
    //        }

    //    }

    //    public void Update(Department d)
    //    {
    //        using (SqlConnection con = new SqlConnection(DbHelper.conStr))
    //        {
    //            SqlCommand cmd = new SqlCommand("UPDATE Department SET DepartmentName=@n WHERE Id=@id", con);
    //            cmd.Parameters.AddWithValue("@n", d.DepartmentName);
    //            cmd.Parameters.AddWithValue("@id", d.Id);
    //            con.Open();
    //            cmd.ExecuteNonQuery();
    //        }

    //    }

    //        public List<Department> GetAll()
    //        {
    //            List<Department> list = new List<Department>();
    //            using (SqlConnection con = new SqlConnection(DbHelper.conStr))
    //            {
    //                SqlCommand cmd = new SqlCommand("SELECT * FROM Department", con);
    //                con.Open();
    //                SqlDataReader reader = cmd.ExecuteReader();
    //                while (reader.Read())
    //                {
    //                    Department d = new Department();
    //                    d.Id = (int)reader["Id"];
    //                    d.DepartmentName = reader["DepartmentName"].ToString();
    //                    list.Add(d);
    //                }
    //            }
    //            return list;
    //        }
    //}



    //==================================================================================================================================================================================

    public class DepartmentRepository
    {
        public void Add(Department d)
        {
            using (SqlConnection con = new SqlConnection(DbHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Department(DepartmentName) VALUES(@n)", con);
                cmd.Parameters.AddWithValue("@n", d.DepartmentName);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void Update(Department d)
        {
            using (SqlConnection con = new SqlConnection(DbHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Department SET DepartmentName=@n WHERE Id=@id", con);
                cmd.Parameters.AddWithValue("@n", d.DepartmentName);
                cmd.Parameters.AddWithValue("@id", d.Id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(DbHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Department WHERE Id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Department> GetAll()
        {
            List<Department> list = new List<Department>();

            using (SqlConnection con = new SqlConnection(DbHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Department", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new Department
                    {
                        Id = (int)dr["Id"],
                        DepartmentName = dr["DepartmentName"].ToString()
                    });
                }
            }
            return list;
        }
    }

}
