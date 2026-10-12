using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class Person
    {
        public  static bool Find_By_ID(int ID , ref string First_Name, ref string Second_Name , ref string Third_Name ,
            ref string Last_Name, ref string NationalNo, ref DateTime DateOfBirth,
           ref short Gendor, ref string Address, ref string Phone, ref string Email,
           ref int NationalityCountryID, ref string ImagePath)
        {
            bool Is_Found = false;
            SqlConnection connection = new SqlConnection(DataAcssesSetting.ConnectionString);
            string query = "select * from People where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Is_Found = true;
                    ID = (int)reader["personID"];
                    First_Name = (string)reader["FirstName"];
                    Second_Name = (string)reader["SecondName"];
                    
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        Third_Name = (string)reader["ThirdName"];
                    }
                    else
                    {
                        Third_Name = "";
                    }
                    Last_Name = (string)reader["LastName"];
                    NationalNo = (string)reader["NationalNo"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
                }
                else
                {
                    Is_Found = false;
                }
                reader.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return Is_Found;
        }

        public static DataTable GET_All_Person()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAcssesSetting.ConnectionString);

            string query = 
                @"SELECT People.PersonID, People.NationalNo,
              People.FirstName, People.SecondName, People.ThirdName, People.LastName,
			  People.DateOfBirth, People.Gendor,  
				  CASE
                  WHEN People.Gendor = 0 THEN 'Male'

                  ELSE 'Female'

                  END as GendorCaption ,
			  People.Address, People.Phone, People.Email, 
              People.NationalityCountryID, Countries.CountryName, People.ImagePath
              FROM            People INNER JOIN
                         Countries ON People.NationalityCountryID = Countries.CountryID
                ORDER BY People.FirstName";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine (ex.Message);
            }finally { connection.Close(); }
            return dt;
        }

        public static int ADD_Person(string FirstName, string SecondName,
           string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth,
           short Gendor, string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            int personID = -1;
            SqlConnection connection = new SqlConnection(DataAcssesSetting.ConnectionString);
            string query =
                @"insert into people (FirstName,SecondName,ThirdName,LastName,NationalNo,
                                        DateOfBirth,Gendor,Address, Phone, Email,NationalityCountryID,ImagePath)
                            VALUES(@FirstName,@SecondName,@ThirdName,@LastName,@NationalNo,@DateOfBirth,
                                @Gendor,@Address,@Phone,@Email,@NationaltyCountryID,@ImagePath);
                             select scope_identity();";

            SqlCommand command = new SqlCommand (query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != "" && ThirdName != null)
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            try
            {
                connection.Open();
                object person = command.ExecuteScalar();
                if (person != null && int.TryParse(person.ToString(), out int resultID))
                {
                    personID = resultID;
                }

            } catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }finally { connection.Close(); }
            
            return personID;
        }

        public static bool Delet_Person(int ID)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(DataAcssesSetting.ConnectionString);
            string query = @"Delet people Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personID", ID);
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }finally { connection.Close(); }
            return (result > 0);
        }

        public static bool Update_Person(int PersonID ,string FirstName, string SecondName,
           string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth,
           short Gendor, string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(DataAcssesSetting.ConnectionString);
            string query = @"update people 
                            set FirstName = @FirstName, SecondName = @SecondName
                             ThirdName = @ThirdName , LastName= @LastName
                             NationalNo = @NationalNo , DateOfBirth = @DateOfBirth,
                             Gendor = @Gendor , Address = @Address ,Phone = @Phone
                             Email = @Email , NatiolnalityCountryID = @NationalityCountryID , ImagePath = @ImagePath
                              Where PersonID = @personID";
            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != "" && ThirdName != null)
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue ("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }finally { connection.Close(); }

            return (result >  0);
        }

        public static bool Find_By_NationalNO(string NationalNo,ref int ID,ref string FirstName,
            ref string SecondName, ref string ThirdName , ref string LastName, ref DateTime DateofBirth,
            ref short Gendor , ref string Address ,ref string Phone , ref string Email ,
            ref int NationalityCountryID,ref string ImagePath)
        {
            bool Is_Found = false;
            SqlConnection connection = new SqlConnection(DataAcssesSetting.ConnectionString);
            string query = "Select * from People Where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Is_Found = true;
                    ID = (int)reader["personID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }
                    LastName = (string)reader["LastName"];
                    DateofBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (short)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    if (reader["email"] != DBNull.Value)
                    {
                        Email = (string)reader["email"];
                    }
                    else
                    {
                        Email = "";
                    }
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                }
                reader.Close();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return Is_Found;
        }
    }
}
