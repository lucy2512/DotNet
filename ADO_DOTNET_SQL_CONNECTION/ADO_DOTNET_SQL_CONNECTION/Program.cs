/*
 ADO.net->ActiveX Data Object for .net Framework-
It is the part of the .net framework - to interact with the database.
They are Majorily 4 objects
1. Connection object
2. Command Object
3. DataReader object
4. Data Adapter objects
System.Data.SqlClient.(namespace)
Connection Object is used to establish connection between application and database
Command - To use Sql command in database
DataReader object - to select records from the database(Connected Architecture)
Connection should exist until all the records are fetched.

DataAdapter object is also used to select records from the
database - connection can be closed once the records are fetched.


application    dataset    (can't communicate with the database) it uses data adapter ( it is an interface between the dataset and database)		database

(uses dataset to fetch records)

application -> dataset -> data adapter -> database( dissconnected)

application - >data reader  - database ( connected )
 */


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
                i = cmd.ExecuteNonQuery();*//*

                //Delete Data from the Table
                *//*cmd = new SqlCommand("delete from Employee_Table where emp_id=@p1", con);
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
            /*
            --------Using DataAdapter----------
            SqlDataAdapter sda;
            SqlConnection con;
            DataSet ds;
            //visit app.config connectionstring part for "myconnection"
            con=new SqlConnection(ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString);
            con.Open();
            sda=new SqlDataAdapter("select * from Student_Table",con);
            ds=new DataSet();
            sda.Fill(ds,"Student_Table");
            con.Close();
            foreach(DataRow dr in ds.Tables["Student_Table"].Rows)
            {
                Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3]);
            }   
            Console.Read();
            */

        }
    }
}
