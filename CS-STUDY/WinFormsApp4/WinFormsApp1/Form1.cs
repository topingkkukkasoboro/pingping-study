namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int y = 30; 
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Button btn1 = new Button();
                btn1.Text = "OK";
                btn1.Location = new Point(200, 10 +(y*i));
                btn1.UseVisualStyleBackColor = false;
                btn1.Click += Btn1_Click;
                Controls.Add(btn1);
            }
        }

        private void Btn1_Click(object? sender, EventArgs e)
        {
            Random rn = new Random();
            int x = rn.Next (1, 100);
            int y = rn.Next(10, 200);
            Console.WriteLine(x);
            Console.WriteLine(y);  


            Button btn = sender as Button;

           if (btn.BackColor == Color.Magenta)
            {
                btn.BackColor = Color.White;  
                btn.Text = "OK";
                btn.Location = new Point(x, y);
            } 
           else
            {
                btn.BackColor = Color.Magenta;
                btn.Text = "Not OK";
            }
        }
    }
}
