using _24020.File;
using _24020.FILETB;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24020
{
    public partial class Form1 : Form
    {
        FileControl fc = new FileControl();
        FileTBDataBase ftdb = new FileTBDataBase();


        private String selectedString = "";
       
        public Form1()
        {
            InitializeComponent();

            List<String> list = ftdb.read();
            listBox1.DataSource = null;
            listBox1.DataSource = list;
        }

        private void 파일쓰기_Click(object sender, EventArgs e)
        {


            if(textBox1.Text == "")
            {
                MessageBox.Show("글자입력해라 머글아");
                return;
            }

            ftdb.insert(textBox1.Text);
            List<String> list = ftdb.read();
            listBox1.DataSource = null;
            listBox1.DataSource = list;


        }

        private void 불러오기_Click(object sender, EventArgs e)
        {

            List<String> list = ftdb.read();
            listBox1.DataSource = null;
            listBox1.DataSource = list;

        }

        private void update_Click_1(object sender, EventArgs e)
        {
           MessageBox.Show("수정");

            if(textBox1.Text == "")
            {
                MessageBox.Show("글자 넣어라");
                return;
            }

            String updateStr = textBox1.Text;
            ftdb.update(selectedString, updateStr);

/*            update.PerformClick();
            textBox1.Text = "";*/


        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=HR;Password=1234;";

            OracleConnection con = new OracleConnection(connectionString);
            con.Open();

            OracleCommand oracleCommand = new OracleCommand($"delete from filetb fwhere str='{textBox1.Text}'", con);

            oracleCommand.ExecuteNonQuery();

            con.Close();

            delete.PerformClick();
            textBox1.Text = "";

            MessageBox.Show("삭제");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(listBox1.SelectedIndex);
            Console.WriteLine(listBox1.SelectedItem);

            if (listBox1.SelectedItem != null)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
                selectedString = listBox1.SelectedItem.ToString();
                MessageBox.Show("바뀜"+selectedString);

            }
        }
    }
}
