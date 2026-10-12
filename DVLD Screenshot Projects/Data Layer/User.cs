using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class User
    {
        public static bool User_info_by_USER_AND_Password(string User_Name , string Password, ref int user_ID,
            ref int person_id , ref bool IS_Activ)
        {
            bool is_found = false;
            
            SqlConnection connection = new SqlConnection(DataAcssesSetting.ConnectionString);
            
            string query = "SELECT * FROM Users WHERE Username = @Username and Password=@Password;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username" , User_Name);
            command.Parameters.AddWithValue("@Password" , Password );

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    is_found = true;
                    user_ID = (int)reader["UserID"];
                    person_id = (int)reader["personID"];
                    IS_Activ = (bool)reader["IsActive"];
                    User_Name = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                }
                else
                {
                    is_found = false;
                }
                reader.Close();
            }
            catch(Exception ex) {
                
                Console.WriteLine(ex.ToString());
            }finally{
                connection.Close();
            }
            return is_found;
        }
    }
}
