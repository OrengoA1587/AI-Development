using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
 
namespace DataAccessLibrary
{
    public class InsertPerson
    {
        public bool InsertPersonIntoDatabase(string fName, string lName, string address, string email, string password,string dob,ref string connectionString)
        {
            Console.WriteLine("YOU ARE HERE!");
             
            SqlConnection sqlcon = new SqlConnection();
            string statement = "INSERT INTO PeopleTest(FirstName,LastName,Address,DateOfBirth,EmailAddress,Username,Password) VALUES (@fName,@lName,@address,@dob,@email,@username,@password)";
            sqlcon.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PersonDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //sqlcon.ConnectionString = connectionString;
            try
            {
                sqlcon.Open();
                using (SqlCommand sqlcom = new SqlCommand(statement, sqlcon))
                {
                    sqlcom.Parameters.Add(new SqlParameter("@fName", fName));
                    sqlcom.Parameters.Add(new SqlParameter("@lName", lName));
                    sqlcom.Parameters.Add(new SqlParameter("@address", address));
                    sqlcom.Parameters.Add(new SqlParameter("@dob", dob));
                    sqlcom.Parameters.Add(new SqlParameter("@email", email));
                    sqlcom.Parameters.Add(new SqlParameter("@username", email));
                    sqlcom.Parameters.Add(new SqlParameter("@password", password));


                    //sqlcom.Parameters.Add("@fNname", SqlDbType.NVarChar).Value = fName;
                    //sqlcom.Parameters.Add("@lName", SqlDbType.NVarChar).Value = lName;
                    //sqlcom.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                    //sqlcom.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob;
                    //sqlcom.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                    //sqlcom.Parameters.Add("@username", SqlDbType.NVarChar).Value = email;
                    //sqlcom.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;


                    int rowsAffected = sqlcom.ExecuteNonQuery();

                    if (rowsAffected >= 0)
                    {
                        Console.WriteLine("Data inserted successfully.");
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                    sqlcon.Close();


                }


            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                 
            }
            return false;   
        }
    }
}
