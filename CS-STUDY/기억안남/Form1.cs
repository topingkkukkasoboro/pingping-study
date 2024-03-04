using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=hr;Password=1234;";
        OracleConnection conn;
        OracleCommand cmd;
        private string strConnection;

        public Form1()
        {
            InitializeComponent();
            // 주석처리 단축키 ztrl + k + c
            // mbox tab tab
            //MessageBox.Show("strConnection");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(connectionString);
            cmd = new OracleCommand();
            //cmd.Connection = conn;
            conn.Open();

            DataSet dataset = new DataSet();
            string sql = "select * from emp";

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = new OracleCommand(sql, conn);
            adapter.Fill(dataset);

            dataGridView1.DataSource = dataset.Tables[0];

            conn.Close();
            //MessageBox.Show("Test" + strConnection);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
