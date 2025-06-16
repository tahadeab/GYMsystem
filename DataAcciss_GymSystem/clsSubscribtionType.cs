using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAcciss_GymSystem
{
    public static  class clsSubscribtionType
    {
            public static bool GetSubscribeTypeByID(int SubsicribtionID,ref string Name,
                                                    ref short Period, ref string Details,ref Decimal Price)
        {
            bool isFound = false;

            SqlConnection conn = new SqlConnection(ConnectPath.StringPath);
            string Query = @"Select * FROM SubsicribtionType Where SubsicribtionID = @SubsicribtionID";
            SqlCommand cmd = new SqlCommand(Query,conn);
            cmd.Parameters.AddWithValue("@SubsicribtionID", SubsicribtionID);
            try
            {
                isFound = true;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Name = (string)reader["Name"];
                    Period = (short)reader["Period"];
                    Details = (string)reader["Details"];
                    Price = (Decimal)reader["Price"];
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally { conn.Close(); }



            return isFound; 
        }

        public static bool GetSubscribeTypeByName(ref int SubsicribtionID,  string Name,
                                                      ref short Period, ref string Details, ref Decimal Price)
        {
            bool isFound = false;

            SqlConnection conn = new SqlConnection(ConnectPath.StringPath);
            string Query = @"Select * FROM SubsicribtionType Where Name = @Name";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@Name", Name);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    SubsicribtionID = (int)reader["SubsicribtionID"];
                    Name = (string)reader["Name"];
                    Period = (short)reader["Period"];
                    Details = (string)reader["Details"];
                    Price = (Decimal)reader["Price"];
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally { conn.Close(); }



            return isFound;
        }

        public static DataTable GetAllSubscribtionType()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectPath.StringPath);
            string Query = @"select * FROM SubsicribtionType Order by Name;";
            SqlCommand cmd = new SqlCommand(Query,conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                // Error 
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
    
    
            
            public static bool UpdateSubscribtionType(int SubsicribtionID, string Name,
                                                     short Period,  string Details , Decimal Price)
        {
            int RowAfficted = 0;
            SqlConnection conn = new SqlConnection(ConnectPath.StringPath);
            string Query = @"Update SubsicribtionType set Name = @Name ,
                                                           Period = @Period,
                                                           Details = @Details,
                                                           Price = @Price where SubsicribtionID = @SubsicribtionID;";

            SqlCommand cmd = new SqlCommand(Query,conn);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Period", Period);
            cmd.Parameters.AddWithValue("@Details", Details);
            cmd.Parameters.AddWithValue("@SubsicribtionID", SubsicribtionID);
            cmd.Parameters.AddWithValue("@Price", Price);

            try
            {
                conn.Open();
                RowAfficted = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                RowAfficted = 0;
            }
            finally { conn.Close(); }




            return RowAfficted > 0;
        }



    }
}
