namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                Console.WriteLine(control);
                control.Text = "±ÛÀÚ¹Ù²Ù±â";
                control.Font = new Font("ÈÞ¸Õ¿¾Ã¼", 12, FontStyle.Bold);

                if (control is Panel)
                {
                    Panel panel1 = control as Panel;
                    foreach (Control subcontrol in panel1.Controls)
                    {
                        subcontrol.Text = "±ÛÀÚ¹Ù²Ù±â";
                        subcontrol.Font = new Font("ÈÞ¸Õ¿¾Ã¼", 12, FontStyle.Bold);
                    }
                }

                if (control is Button)
                {
                    Button button = control as Button;
                    button.AutoSize = true;
                }
            }
        }
    }
}
