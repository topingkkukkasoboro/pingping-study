using MiniProject.ChoiceTicket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject.Choice
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {
            Reverse reverse = new Reverse();
            reverse.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("M");
            Time2.Text = DateTime.Now.ToString("T");
        }
    }
}
