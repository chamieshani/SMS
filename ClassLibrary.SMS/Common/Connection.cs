using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ClassLibrary.SMS.Common
{
    public class Connection
    {
        private string _connectionString = string.Empty;

        public string ConnectionString { get { return _connectionString; } set { _connectionString = value; } }
        
        public SQLConnection 
        public bool ConnectionOpen()
        {
            try
            {
                if()
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
