using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using System.Linq.Expressions;
using System.CodeDom;
using IBrokerService.DBModel;
using System.Collections;

namespace IBrokerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IBrokerService" in both code and config file together.
    public class IBrokerService : IIBrokerService
    {
        static string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public string GetLogin(LoginDetails Login)
        {
            string success = null;
            
            using (SqlConnection con = new SqlConnection(conString))
                {
                try
                {
                    SqlCommand cmd = new SqlCommand("Get_LoginData", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@param", Login.Param);
                    cmd.Parameters.AddWithValue("@userName", Login.UserName);
                    cmd.Parameters.AddWithValue("@password", Login.Password);
                    cmd.Parameters.AddWithValue("@status", Login.Status);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            success = sdr["SaveFlag"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }
                }
           
            return success;
        
        }
    }
}
