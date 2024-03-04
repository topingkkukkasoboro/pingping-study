using mdiproject.todo;
using mdiproject.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdiproject
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm userform = UserForm.getInstance();
            userform.MdiParent = this;
            userform.Show();
        }

        private void 할일관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TodoForm todoform = TodoForm.getInstance();
            todoform.MdiParent = this;
            todoform.Show();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
