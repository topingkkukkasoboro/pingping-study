using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiproject.dbinfo
{
    internal class DBInfo
    {
        public static String dbstr = "data source = localhost; user id = id; password = 1234;";
        public static OracleConnection conn = null;

        public static OracleConnection openconnect()
        {
            if (conn == null)
            {
                conn = new OracleConnection(dbstr);
                conn.Open();
            }
            else
            {
                conn.Open();
            }
                return conn;
        }
        public static void closeconnect()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
    }

}
