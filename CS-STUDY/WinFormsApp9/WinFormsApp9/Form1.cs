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
                control.Text = "���ڹٲٱ�";
                control.Font = new Font("�޸տ�ü", 12, FontStyle.Bold);

                if (control is Panel)
                {
                    Panel panel1 = control as Panel;
                    foreach (Control subcontrol in panel1.Controls)
                    {
                        subcontrol.Text = "���ڹٲٱ�";
                        subcontrol.Font = new Font("�޸տ�ü", 12, FontStyle.Bold);
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
