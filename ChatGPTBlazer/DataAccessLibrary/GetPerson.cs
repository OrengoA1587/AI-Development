using Microsoft.Data.SqlClient;
using System.Data;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System.IO;
namespace DataAccessLibrary
{
    public class GetPerson  
    {
        public bool VerifyPerson(string username,string password, string connectionString)
        {
            SqlConnection sqlcon = new SqlConnection();
            string statement = "SELECT * FROM PeopleTest where Username = @username AND Password = @password";
            //sqlcon.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlcon.ConnectionString = connectionString;

            using (SqlCommand sqlcom = new SqlCommand(statement, sqlcon))
            {
                sqlcon.Open();
                sqlcom.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                sqlcom.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;                
                SqlDataReader reader = sqlcom.ExecuteReader();
                if (reader.Read())
                {
                    string userName = reader.GetValue(0).ToString();
                    string passwordCheck = reader.GetValue(1).ToString();
                    sqlcon.Close();
                    return true;
                }
                else
                {
                    sqlcon.Close();
                    return false;
                }
                sqlcon.Close();
            }
            return false;
        }         
    }
}
