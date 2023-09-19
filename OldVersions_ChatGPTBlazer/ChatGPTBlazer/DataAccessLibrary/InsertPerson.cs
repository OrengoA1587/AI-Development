using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace DataAccessLibrary
{
    public class InsertPerson
    {
        SHA512Managed algo512 = new SHA512Managed();

        public bool InsertPersonIntoDatabase(string fName, string lName, string address, string email, string plaintext,string dob,ref string connectionString)
        {
            string password = Convert.ToBase64String(GetEncryptedPassword(plaintext));           
             
            SqlConnection sqlcon = new SqlConnection();
            string statement = "INSERT INTO PeopleTest(FirstName,LastName,Address,DateOfBirth,EmailAddress,Username,Password) VALUES (@fName,@lName,@address,@dob,@email,@username,@password)";
            sqlcon.ConnectionString = connectionString;
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

                    int rowsAffected = sqlcom.ExecuteNonQuery();
                    if (rowsAffected >= 0)
                    {
                        Console.WriteLine("Data inserted successfully.");
                        sqlcon.Close();
                        return true;
                         
                    }
                    else
                    {
                        sqlcon.Close();
                        return false;
                    }
                     
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                 
            }
            return false;   
        }
        private byte[] GetEncryptedPassword(string text)
        {

            var convText = Encoding.ASCII.GetBytes(text);
            var salt = Encoding.ASCII.GetBytes("H@ck3r$Rul3");

            byte[] Encryptpass = new byte[convText.Length + salt.Length];

            for (int i = 0; i < convText.Length; i++)
            {
                Encryptpass[i] = convText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                Encryptpass[i + convText.Length] = salt[i];
            }
            return algo512.ComputeHash(Encryptpass);
        }
    }
}
