using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remake.dagtbase
{
    class DBInfo
    {
        public static String dbstr =  "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=8083))(CONNECT_DATA=(SERVICE_NAME=XE)));User Id=id;Password=1234;";
        public static OracleConnection conn = null;

        public static OracleConnection openconnect()
        {
            try
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
            }
            catch (OracleException ex)
            {
                    Console.WriteLine("예외 발생: " + ex.Message);
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
