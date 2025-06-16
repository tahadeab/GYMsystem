using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAcciss_GymSystem
{
    public static class clsHR
    {

        public static bool GetPersonInfoByID(int PersonID, ref string FirstName,ref string SecondName,
                                              ref string ThirdName, ref string LastName,
                                              ref short Gender ,ref DateTime DateOfBirth,ref string PhoneNum,
                                              ref int CountryID,ref string Email, ref string Address,
                                              ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection Conn = new SqlConnection(ConnectPath.StringPath);
            string Query = @"Select * From HR where PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(Query,Conn);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    FirstName =(string) reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["ThirdName"];
                    else
                        ThirdName = "";

                    LastName = (string)reader["LastName"];
                    Gender = (short)reader["Gender"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    PhoneNum = (string)reader["PhoneNum"];
                    CountryID = (int)reader["CountryID"];
                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    if (reader["Address"] != DBNull.Value)
                        Address = (string)reader["Address"];
                    else
                        Address = "";

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";


                    reader.Close();

                }
                else
                { 
                    isFound = false;
                }


            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally { Conn.Close(); }


            return isFound;
        }


        public static bool GetPersonInfoByFirstNameAndLastName(string FirstName, ref int PersonID, ref string SecondName,
                                               ref string ThirdName,string LastName,
                                               ref short Gender, ref DateTime DateOfBirth, ref string PhoneNum,
                                               ref int CountryID, ref string Email, ref string Address,
                                               ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection Conn = new SqlConnection(ConnectPath.StringPath);
            string Query = @"Select * From HR where FirstName = @FirstName and LastName = @LastName";
            SqlCommand cmd = new SqlCommand(Query, Conn);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);

            try
            {
                Conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    SecondName = (string)reader["SecondName"];
                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["ThirdName"];
                    else
                        ThirdName = "";

                  //  LastName = (string)reader["LastName"];

                    Gender = (byte)reader["Gender"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    PhoneNum = (string)reader["PhoneNum"];
                    CountryID = (int)reader["CountryID"];
                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    if (reader["Address"] != DBNull.Value)
                        Address = (string)reader["Address"];
                    else
                        Address = "";

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";


                    reader.Close();

                }
                else
                {
                    isFound = false;
                }


            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally { Conn.Close(); }


            return isFound;
        }


        public static int AddNewPersonToDB(string FirstName,  string SecondName,
                                               string ThirdName,  string LastName,
                                               short Gender,  DateTime DateOfBirth,  string PhoneNum,
                                               int CountryID,  string Email,  string Address,
                                              string ImagePath)
        {
            int ReturnedID = -1;
            SqlConnection conn = new SqlConnection(ConnectPath.StringPath);
            string Query = @"INSERT INTO HR
           (FirstName
            ,SecondName
           ,ThirdName
           ,LastName
           ,Gender
           ,DateOfBirth
           ,PhoneNum
           ,CountryID
           ,Email
           ,Address
           ,ImagePath)
                     VALUES (@FirstName,@SecondName,@ThirdName,@LastName,@Gender, @DateOfBirth,
                              @PhoneNum,@CountryID, @Email,@Address,@ImagePath);
                          Select SCOPE_IDENTITY() ";


            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
          if(ThirdName != "" && ThirdName != null)
            cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
          else
                cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);

            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@PhoneNum", PhoneNum);
            cmd.Parameters.AddWithValue("@CountryID", CountryID);
            cmd.Parameters.AddWithValue("@Address", Address);

            if (Email != null && Email != "")
                cmd.Parameters.AddWithValue("@Email", Email);
            else
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);

            if (ImagePath != null && ImagePath != "")
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);


            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out int ReID))
                {
                    ReturnedID = ReID;
                }

            }
            catch(Exception ex) {
            
            }
            finally { conn.Close(); }



            return ReturnedID;



        }



        public static bool UpdatePerson(int PersonID, string FirstName, string SecondName,
       string ThirdName, string LastName, short Gender, DateTime DateOfBirth,
        string PhoneNum,int CountryID, string Email, string Address,
         string ImagePath)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ConnectPath.StringPath);

            string query = @"Update  HR  
                            set FirstName = @FirstName,
                                SecondName = @SecondName,
                                ThirdName = @ThirdName,
                                LastName = @LastName,
                                Gender=@Gender,
                                DateOfBirth = @DateOfBirth,
                                PhoneNum = @PhoneNum,
                                CountryID = @CountryID,
                                Email = @Email, 
                                Address = @Address,  
                                ImagePath =@ImagePath
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != "" && ThirdName != null)
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);


            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
           
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@PhoneNum", PhoneNum);

            command.Parameters.AddWithValue("@Address", Address);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            command.Parameters.AddWithValue("@CountryID", CountryID);

            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }





        public static DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectPath.StringPath);

            string query =
              @"SELECT HR.PersonID,
              HR.FirstName, HR.SecondName, HR.ThirdName, HR.LastName,
			  HR.DateOfBirth, HR.Gender,  
				  CASE
                  WHEN HR.Gender = 0 THEN 'Male'

                  ELSE 'Female'

                  END as GenderCaption ,
			  HR.Address, HR.PhoneNum, HR.Email, 
              HR.CountryID, Countries.CountryName, HR.ImagePath
              FROM            HR INNER JOIN
                         Countries ON HR.CountryID = Countries.CountryID
                ORDER BY HR.FirstName";




            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }



        public static bool DeletePerson(int PersonID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(ConnectPath.StringPath);

            string query = @"Delete HR 
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }


        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConnectPath.StringPath);

            string query = "SELECT Found=1 FROM HR WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }








    }
}
