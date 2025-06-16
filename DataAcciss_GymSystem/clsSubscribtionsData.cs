using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace DataAcciss_GymSystem
{
    public static class clsSubscribtionsData
    {
        public static bool GetSubscribtionIfoByID(int SubscribtionID,ref int SubsicribtionTypeID,
                                                   ref DateTime StartDate, ref DateTime EndDate,ref int MemberID,
                                                   ref decimal Cash, ref decimal remainder,ref int CoachID)
        {   
            bool isFound = false;
            SqlConnection conn = new SqlConnection(ConnectPath.StringPath);
            string Query = @"SELECT * From SubsicribtionInfo Where SubscribtionID =@SubscribtionID;";

            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@SubscribtionID", SubscribtionID);
        
            try
            {
                conn.Open();
                SqlDataReader reader =cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    SubsicribtionTypeID = (int)reader["SubsicribtionTypeID"];
                    StartDate = (DateTime)reader["StartDate"];
                    EndDate = (DateTime)reader["EndDate"];
                    MemberID = (int)reader["MemberID"];
                    Cash = (decimal)reader["Cash"];
                    remainder = (decimal)reader["remainder"];
                    if (reader["CoacheID"] == DBNull.Value)
                     CoachID = 0;
                    else
                     CoachID = (int)reader["CoachID"];

                }
                reader.Close();
            }
            catch(Exception e) 
            {
            
            }
            finally { conn.Close(); }

            return isFound;
        }

        public static DataTable GetAllSubscribtions()
        {
            DataTable dataTable = new DataTable();
            
            SqlConnection conn = new SqlConnection(ConnectPath.StringPath);
            string Query = @"Select * FROM View_1 order by StartDate desc "; 
            SqlCommand cmd = new SqlCommand(Query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }  
            
            return dataTable;
        }

        public static int AddNewSubscribtion( int SubsicribtionTypeID,
                                                    DateTime StartDate,  DateTime EndDate,  int MemberID,
                                                    decimal Cash,  decimal remainder,  int CoachID)
        {
            int RetSubID = -1;
            SqlConnection conn = new SqlConnection(ConnectPath.StringPath);
            string Query = @"
                   INSERT INTO [dbo].[SubsicribtionInfo]
                              ([SubsicribtionTypeID]
                              ,[StartDate]
                              ,[EndDate]
                              ,[MemberID]
                              ,[Cash]
                              ,[remainder]
                              ,[CoachID])
                        VALUES
                              (@SubsicribtionTypeID
                              ,@StartDate
                              ,@EndDate
                              ,@MemberID
                              ,@Cash
                              ,@remainder
                              ,@CoachID)
                                            select SCOPE_IDENTITY();";
                   
            SqlCommand command = new SqlCommand(Query, conn);
            command.Parameters.AddWithValue("@SubsicribtionTypeID", SubsicribtionTypeID);
            command.Parameters.AddWithValue("@StartDate", StartDate);
            command.Parameters.AddWithValue("@EndDate", EndDate);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@Cash", Cash);
            command.Parameters.AddWithValue("@remainder", remainder);
            
            if(CoachID > 0)
             command.Parameters.AddWithValue("@CoachID", CoachID);
            else
             command.Parameters.AddWithValue("@CoachID", DBNull.Value);

            try
            {
                conn.Open();
                object result = command.ExecuteScalar();    
                if(result != null && int.TryParse(result.ToString(),out int ReID))
                 {
                    RetSubID = ReID;
                }
            }
            catch (Exception e)
            {

            }
            finally { conn.Close(); }


            return RetSubID;
        }

        public static bool UpdateSubscribtion(int SubscribtionID,  int SubsicribtionTypeID,
                                                    DateTime StartDate,  DateTime EndDate,  int MemberID,
                                                decimal Cash,  decimal remainder,  int CoachID)
        {
            int RowAffected = 0;
            SqlConnection conn = new SqlConnection(ConnectPath.StringPath);
            string Query = @"UPDATE [dbo].[SubsicribtionInfo]
                                      SET [SubsicribtionTypeID] = @SubsicribtionTypeID
                                         ,[StartDate] =@StartDate
                                         ,[EndDate] = @EndDate
                                         ,[MemberID] =@MemberID
                                         ,[Cash] = @Cash
                                         ,[remainder] =@remainder
                                         ,[CoachID] = CoachID
                             WHERE SubscribtionID = @SubscribtionID;";

            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@SubscribtionID", SubscribtionID);
            cmd.Parameters.AddWithValue("@SubsicribtionTypeID", SubsicribtionTypeID);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);
            cmd.Parameters.AddWithValue("@MemberID", MemberID);
            cmd.Parameters.AddWithValue("@Cash", Cash);
            cmd.Parameters.AddWithValue("@remainder", remainder);
            if(CoachID > 0)
                cmd.Parameters.AddWithValue("@CoachID", CoachID);
            else
                cmd.Parameters.AddWithValue("@CoachID", DBNull.Value);

            try
            {
                conn.Open();
                RowAffected = cmd.ExecuteNonQuery();
            }
            catch(Exception ex) { return false; }
            finally
            { conn.Close(); }


            return RowAffected > 0;
        }
   
         public static bool DeleteSubscribtion(int SubscribtionID)
        {
            int RowAffected = 0;
            SqlConnection conn = new SqlConnection(ConnectPath.StringPath);
            string Query = @"Delete SubsicribtionInfo where SubscribtionID =@SubscribtionID ";
             SqlCommand cmd = new SqlCommand(Query,conn);
            cmd.Parameters.AddWithValue("@SubscribtionID", SubscribtionID);
            try
            {
                conn.Open();
                RowAffected = cmd.ExecuteNonQuery();
            }
            catch(Exception ex) { return false; }
            finally { conn.Close(); }


            return RowAffected > 0;
        }
    
    
         public static bool IsSubscribtionExist(int SubscribtionID)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(ConnectPath.StringPath);
            string Query = @"Select Found = 1 From SubsicribtionInfo where SubscribtionID =@SubscribtionID;";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@SubscribtionID", SubscribtionID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch(Exception ex) { return false; }
            finally { conn.Close(); }


            return isFound;
        }

        public static bool IsSubscribtionExistByMemberID(int MemberID)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(ConnectPath.StringPath);
            string Query = @"Select Found = 1 From SubsicribtionInfo where MemberID =@MemberID;";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@MemberID", MemberID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex) { return false; }
            finally { conn.Close(); }


            return isFound;
        }



    }
}
