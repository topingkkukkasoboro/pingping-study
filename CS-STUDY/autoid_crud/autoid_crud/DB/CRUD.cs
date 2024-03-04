using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoid_crud.DB
{
    public class CRUD
    {
        private static String GetConnection()
        {
            string dbstr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=HR;Password=1234;";

            return dbstr;
        } 
        public static OracleConnection con =new OracleConnection(GetConnection());
        public static OracleCommand cmd = new OracleCommand();
        public static String sql = "";
    }
}
