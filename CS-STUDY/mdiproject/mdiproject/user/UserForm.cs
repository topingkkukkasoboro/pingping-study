using mdiproject.dbinfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdiproject.user
{
    public partial class UserForm : Form
    {
        private static UserForm instance = null;

        public static UserForm getInstance()
        {
            if (instance == null || instance.IsDisposed) {
                return new UserForm();
                return instance;
            }
            else
            {
                return instance;
            }
        }
        public UserForm()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.ReadOnly = true;
        }

        private void LoadData()
        {
            DataTable dt = userDBManager.select();
            if(dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        UserDBManager userDBManager = new UserDBManager();

        // 삽입기능
        private void insert_Click(object sender, EventArgs e)
        {
            Users users = new Users()
            {Name = tbname.Text,
             Email = tbemail.Text,
             Addr = tbaddr.Text,
             Password = tbpassword.Text};
            Console.WriteLine(users.ToString());
            bool result = userDBManager.insert(users);

            if(result == true)
            {
                MessageBox.Show("등록이 완료 되었습니다");
                tbname.Clear();
                tbaddr.Clear();
                tbpassword.Clear();
                tbemail.Clear();
                LoadData();
            }
            else
            {
                MessageBox.Show("등록이 안되었는데 왜그럴까");
            }
        }

        //수정기능
        private void update_Click(object sender, EventArgs e)
        {

        }

        //삭제기능
        private void delete_Click(object sender, EventArgs e)
        {

        }
        //조회기능
        private void select_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
