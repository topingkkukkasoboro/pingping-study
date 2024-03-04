using MiniProject.Choice;

namespace MiniProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Day.Text = DateTime.Now.ToString("M");
            Time.Text = DateTime.Now.ToString("T");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home manin = new Home();
            manin.Show();
            
            
           
        }
    }
}
