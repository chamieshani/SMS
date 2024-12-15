using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace ClassLibraries.SMS.Common
{
    public class Connection
    {

        public string appconnecionStr = String.Empty;

        // string conString = System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ToString();
        // public SqlConnection connection = new SqlConnection(appconnecionStr);
        // public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
       
        public SqlConnection connection = new SqlConnection();
        //public SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-I4DA4G2\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True");
        public bool OpenConnection()
        {
            connection.ConnectionString = appconnecionStr;
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public bool CloseConnection()
        {
            connection.ConnectionString = appconnecionStr;

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                return true;
            }
            else
                return false;

        }
    }
}
