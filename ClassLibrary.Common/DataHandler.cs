using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary.Common
{
    public class DataHandler
    {

        SqlCommand command;
        SqlDataReader dr;
        //User defined Connection
        Connection conn = new Connection();

        public DataHandler() { }

        public bool executeSQL(string spName, List<object[]> mParams)
        {

            try
            {
                conn.CloseConnection();
                if (conn.OpenConnection())
                {
                    command = new SqlCommand(spName, conn.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    if (mParams != null)
                    {
                        foreach (object[] Params in mParams)
                        {
                            command.Parameters.AddWithValue(Params[0].ToString(), Params[1]);
                        }
                    }
                    int succeeded = command.ExecuteNonQuery();

                    if (succeeded > 0)
                        return true;
                    else
                        return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

        }

        public SqlDataReader readData(string spName, List<object[]> mParams)
        {
            try
            {
                conn.CloseConnection();
                if (conn.OpenConnection())
                {
                    command = new SqlCommand(spName, conn.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    if (mParams != null)
                    {
                        foreach (object[] Params in mParams)
                        {
                            command.Parameters.AddWithValue(Params[0].ToString(), Params[1]);
                        }

                        return command.ExecuteReader();
                    }
                    else
                    {
                        command = new SqlCommand(spName, conn.connection);
                        command.CommandType = CommandType.StoredProcedure;
                        return command.ExecuteReader();
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

    }
}