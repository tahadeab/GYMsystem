using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcciss_GymSystem
{
    public static  class clsClientData
    {
        public static bool GetClientInfoByID(int MemberID, ref int PersonID, ref string EmergencyPhone,
                                             ref decimal BodyWeight,ref bool IsActive,ref decimal Length)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ConnectPath.StringPath);

            string query = "SELECT * FROM Members WHERE MemberID = @MemberID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    MemberID = (int)reader["MemberID"];
                    PersonID = (int)reader["PersonID"];
                    EmergencyPhone = (string)reader["EmergencyPhone"];
                    IsActive = (bool)reader["IsActive"];
                    BodyWeight = (decimal)reader["BodyWeight"];
                    if (reader["Length"] != DBNull.Value)
                        Length = (decimal)reader["Length"];
                    else
                        Length = 0;


                }
                else
                {
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }





            return isFound;
        }

        public static bool GetClientInfoByPersonID(ref int MemberID,  int PersonID, ref string EmergencyPhone,
                                             ref decimal BodyWeight, ref bool IsActive, ref decimal Length)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ConnectPath.StringPath);

            string query = "SELECT * FROM Members WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    MemberID = (int)reader["MemberID"];
                   // PersonID = (int)reader["PersonID"];
                    EmergencyPhone = (string)reader["EmergencyPhone"];
                    IsActive = (bool)reader["IsActive"];
                    BodyWeight = (decimal)reader["BodyWeight"];
                    if (reader["Length"] != DBNull.Value)
                    Length = (decimal)reader["Length"];
                    else
                    Length = 0;



                }
                else
                {
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }





            return isFound;
        }


        public static int  AddNewClient(int PersonID,  string EmergencyPhone,
                                              decimal BodyWeight,  bool IsActive,  decimal Length)
        {
            int MemberID = -1;
            SqlConnection connection = new SqlConnection(ConnectPath.StringPath);

            string query = @"INSERT INTO Members (PersonID,EmergencyPhone,BodyWeight,IsActive,Length)
                             VALUES (@PersonID, @EmergencyPhone,@BodyWeight,@IsActive,@Length);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@EmergencyPhone", EmergencyPhone);
            command.Parameters.AddWithValue("@BodyWeight", BodyWeight);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            if(Length != 0)
            command.Parameters.AddWithValue("@Length", Length);
            else
            command.Parameters.AddWithValue("@Length", DBNull.Value);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    MemberID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return MemberID;
        }


        public static bool UpdateClient(int MemberID,int PersonID, string EmergencyPhone,
                                              decimal BodyWeight, bool IsActive, decimal Length)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ConnectPath.StringPath);

            string query = @"Update  Members  
                            set PersonID = @PersonID,
                                EmergencyPhone = @EmergencyPhone,
                                BodyWeight = @Password,
                                IsActive = @IsActive,
                                 Length =@Length
                                where MemberID = @MemberID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@EmergencyPhone", EmergencyPhone);
            command.Parameters.AddWithValue("@BodyWeight", BodyWeight);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@Length", Length);



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

        public static DataTable GetAllClients()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectPath.StringPath);

            string query = @"SELECT  Members.MemberID, Members.PersonID,
                            FullName = HR.FirstName + ' ' + HR.SecondName + ' ' + ISNULL( HR.ThirdName,'') +' ' + HR.LastName,
                            Members.BodyWeight, Members.Length ,Members.EmergencyPhone, Members.IsActive
                             FROM  Members INNER JOIN
                                    HR ON Members.PersonID = HR.PersonID";

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

        public static bool DeleteClient(int MemberID)
        {
            int ArrowAficted = 0;

            SqlConnection conn = new SqlConnection(ConnectPath.StringPath);
            string Query = @"Delete from Members where MemberID = @MemberID";

            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("MemberID", MemberID);
            try
            {
                conn.Open();
                ArrowAficted = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally { conn.Close(); }

            return ArrowAficted > 0;
        }


        public static bool IsClientExist(int MemberID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConnectPath.StringPath);

            string query = "SELECT Found=1 FROM Members WHERE MemberID = @MemberID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);

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



        public static bool IsClientExistByPersonID(int  PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConnectPath.StringPath);

            string query = "SELECT Found=1 FROM Members WHERE PersonID = @PersonID";

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
