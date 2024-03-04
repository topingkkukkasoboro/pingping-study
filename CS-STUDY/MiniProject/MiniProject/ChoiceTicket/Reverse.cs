using MiniProject.Choice;
using MiniProject.Ok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject.ChoiceTicket
{
    public partial class Reverse : Form
    {
        public Reverse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Ok.Ok os = new Ok.Ok();
            os.Show();
            
        }
    }
}
