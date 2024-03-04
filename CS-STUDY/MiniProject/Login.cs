using miniproject.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // admin / 고객 로그인
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("1234") && textBox2.Text.Equals("admin"))
            {
                AdminMain adminMain = new AdminMain();
                Hide();
                adminMain.ShowDialog();
                Show();
            }
            else if (textBox1.Text.Equals("") && textBox2.Text.Equals(""))
            {
                Form1 form1 = new Form1();
                Hide();
                form1.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("아이디 비번 확인");
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
