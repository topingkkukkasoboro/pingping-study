namespace ex240219
{
    public partial class Form1 : Form
    {
        List<String> listboxdata = new List<string>() {"홍길동","이길동","박길동" };
        List<Person> personlist = new List<Person>() {
        new Person() {name = "김길동",age = 20}, new Person() { name = "이길동",age = 30}};
        public Form1()
        {
            InitializeComponent();
            List<int> ints = new List<int>() { 11, 22, 33, 44, 55 };
            String result = "";
            foreach (int i in ints)
            {
                result += result;
            }
            label2.Text = result;
        }
        public void myThread()
        {
            Random random = new Random();
            while (true)
            {
                double ran = random.NextDouble();
                button1.Invoke((MethodInvoker)delegate
                {
                    button1.Text = ran.ToString();
                    button1.Location = new Point(random.Next(300), random.Next(500));
                });
                Thread.Sleep(2000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(myThread);
            th.Start();

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                this.Controls.Add(button);

                Point point = new Point();

                point.X = 10;
                point.Y = 100 + 40 * i;
                button.Location = point;



                button.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A a = new A();
            A b = new A();

            AA aa = new AA();
            AA bb = new AA();

            a.x = 100;
            Console.WriteLine($"a.x = {a.x}");
            Console.WriteLine($"b.x =" + b.x);

            aa.x = 100;
            Console.WriteLine($"aa.x = {aa.x}");
            Console.WriteLine($"bb.x = " + bb.x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int i in list)
            {
                Console.WriteLine(list);
            }
        }

        private void datagrid_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listboxdata.Add("고길동");
            listBox1.DataSource = listboxdata;
            
        }

        private void listbox_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = listboxdata;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personlist;


        }
    }
}
