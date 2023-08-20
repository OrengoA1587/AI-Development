using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Reflection.Metadata;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Data;
using NLog.Internal;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Xml.Linq;

namespace DataAccessLibrary
{
    public class GetPerson
    {
        private string _username = "";
        private string _password = "";
        private IConfiguration _configuration;

        public GetPerson(string username, string password)
        {
            _username = username;
            _password = password;

            Console.WriteLine(_username + _password);
            

        }
        public static bool VerifyPerson(string username,string password)

        {
            
            SqlConnection sqlcon = new SqlConnection();
            string statement = "SELECT * FROM PeopleTest where Username = @username AND Password = @password";
            sqlcon.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";



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
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

         
    }
}
