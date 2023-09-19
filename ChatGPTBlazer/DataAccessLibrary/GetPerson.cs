using Microsoft.Data.SqlClient; 
using System.Text; 
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http; 
namespace DataAccessLibrary
{
    public class GetPerson  
    {
         
        public bool VerifyPerson(string username,string plaintext, string connectionString)
        {          
            string password = Convert.ToBase64String(GetEncryptedPassword(plaintext));
            SqlConnection sqlcon = new SqlConnection();
            string statement = "SELECT * FROM PeopleTest where Username = @username AND Password = @password";
            sqlcon.ConnectionString = connectionString;
            try
            {
                
                 
                using (SqlCommand sqlcom = new SqlCommand(statement, sqlcon))
                {
                    sqlcon.Open();
                    sqlcom.Parameters.Add(new SqlParameter("@username", username));
                    sqlcom.Parameters.Add(new SqlParameter("@password", password));
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
                     
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
             
            return false;
        }
        private byte[] GetEncryptedPassword(string text)
        {
            SHA512Managed algo512 = new SHA512Managed();
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
