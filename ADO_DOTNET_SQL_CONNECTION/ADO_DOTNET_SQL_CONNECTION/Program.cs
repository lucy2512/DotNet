using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DOTNET_SQL_CONNECTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader reader;
            int i;
            con = new SqlConnection("Server=localhost\\SQLEXPRESS01;Database=EmployeeDB;Trusted_Connection=true");
            con.Open();
            try
            {
                //Insert data into the table
                /*cmd = new SqlCommand("insert into Employee_Table values(@p1,@p2,@p3)", con);
                cmd.Parameters.AddWithValue("@p1", "Parthib Sarkar");
                cmd.Parameters.AddWithValue("@p2", " Senior Software Engineer");
                cmd.Parameters.AddWithValue("@p3", 90000);
                i = cmd.ExecuteNonQuery();*/

                //Delete Data from the Table
                /*cmd = new SqlCommand("delete from Employee_Table where emp_id=@p1", con);
                cmd.Parameters.AddWithValue("@p1", 3);
                i = cmd.ExecuteNonQuery();*/

                /*if (i != 0)
                {
                    Console.WriteLine("Query executed successfully");
                }
                else
                {
                    Console.WriteLine("Error in query/ connection");
                }*/

                //Two types of function are there
                //1.ExecuteNonQuery() (for insert,update, delete)
                //2.ExecuteReader() (showing all the data from the tabale)

                //Showing All the Data using select & ExecuteReader
                cmd = new SqlCommand("select * from Employee_Table ", con);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3]);

                }

            }
            catch (SqlException se) { Console.WriteLine("Error Message " + se.Message); }
            finally
            {
                con.Close();
            }
            Console.Read();

        }
    }
}
