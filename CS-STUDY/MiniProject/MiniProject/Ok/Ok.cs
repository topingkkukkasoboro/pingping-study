using MiniProject.Choice;
using MiniProject.ChoiceTicket;
using MiniProject.Finish;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MiniProject.Ok
{
    public partial class Ok : Form
    {
        public Ok()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Reverse reverse = new Reverse();
            reverse.Show();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("M");
            label2.Text = DateTime.Now.ToString("T");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Finish.Finish finish = new Finish.Finish();
            finish.Show();
        }
    }
}
