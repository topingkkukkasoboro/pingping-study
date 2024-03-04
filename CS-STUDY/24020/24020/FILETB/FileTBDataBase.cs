using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _24020.FILETB
{
    public class FileTBDataBase
    {
        
        private static string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=HR;Password=1234;";

        private static OracleConnection con = null;
        public static OracleConnection connect()
        {
            if (con == null)
            {
                con = new OracleConnection(connectionString);
                con.Open();
            }
            else
            {
                con.Open();
            }
            return con;

        }
        public void insert(String text)
        {
            OracleConnection con = connect();

            String sql = "insert into FILETB values (:values1)";

            using (OracleCommand command = new OracleCommand(sql, con))
            {
                command.Parameters.Add(":values1", text);
                int rowid = command.ExecuteNonQuery();
                Console.WriteLine($"{rowid} 행을 삽입했습니다");
            }   
            con.Close();
        }

        public List<string> read()
        {

            List<string> list = new List<string>();

            OracleConnection con = connect();

            string sql = "select * from filetb";

            using (OracleCommand command = new OracleCommand(sql,con))
            {
                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader["str"].ToString());
                }
                
            }
            con.Close();
            return list;

        }
        public void update(String org, String dst)
        {

            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=HR;Password=1234;";

            OracleConnection con = new OracleConnection(connectionString);
            con.Open();

            OracleCommand oracleCommand = new OracleCommand($" update filetb set str='{dst}'"
                                                            + $" where str ='{org}' ", con);

            oracleCommand.ExecuteNonQuery();

            con.Close();
        }

    }
}