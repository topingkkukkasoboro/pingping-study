using System.ComponentModel;

namespace WF_Class
{

    public partial class Form1 : Form
    {
        int y = 10;
        List<Car> list = new List<Car> ();

        class Car
        {
            public string Name { get; set; }

        }


        public Form1()
        {

            InitializeComponent();


            Car car1 = new Car() {Name = "안녕하세요 자동차1 입니다" };
            Car car2 = new Car() { Name = "안녕하세요 자동차2 입니다"};

            list.Add(car1);
            list.Add(car2);

            foreach (Car car in list)
            {
                MakeLabel(10, y,car.Name);
                Console.WriteLine(car);
            }

        }
        public void MakeLabel(int x, int y, String text)
        {
            label1 = new Label();

            label1.AutoSize = true;
            label1.Location = new Point(x, y);
            label1.TabIndex = 0;
            label1.Name = "label1";
            label1.Text = text;
            label1.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point, 129);
            this.Controls.Add(label1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeLabel(10, y += 40, textBox1.Text);
            Console.WriteLine(textBox1.Text);
            textBox1.Text = "";

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
