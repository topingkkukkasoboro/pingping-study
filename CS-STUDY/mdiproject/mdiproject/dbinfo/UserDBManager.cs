using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdiproject.dbinfo
{
    internal class UserDBManager
    {
        public UserDBManager() { }
        public bool insert(Users users)
        {
            try {
            OracleConnection conn = DBInfo.openconnect();
            String sql = "insert into users (idx,email,addr,password,name)" +
                         " values (usersidx.nextval,:email,:addr,:password,:name)";
            OracleCommand cmd = new OracleCommand(sql,conn);
            cmd.Parameters.Add(":email", users.Email);
            cmd.Parameters.Add(":addr",users.Addr);
            cmd.Parameters.Add("password",users.Password);
            cmd.Parameters.Add(":name", users.Name);
            cmd.ExecuteNonQuery();
            conn.Close();
            DBInfo.closeconnect();
            return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return false;
            }
           
        }
        public void update(Users users)
        {
            
        }
        public void delete(Users users) 
        {

        }
        public DataTable select()
        {
            try
            {
                OracleConnection con = DBInfo.openconnect();

                String sql = "select * from users";

                OracleDataAdapter adapter = new OracleDataAdapter();
                DataSet ds = new DataSet();

                OracleCommand oracleCommand = new OracleCommand(sql, con);
                adapter.SelectCommand = oracleCommand;

                adapter.Fill(ds);

                DBInfo.closeconnect();
                return ds.Tables[0];
            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
                return null;
            }
            
        }
    }
    
}
