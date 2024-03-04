using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labeladdbutton
{
    public partial class Form1 : Form
    {
        List<int>ints = new List<int>() ;
        public Form1()
        {
            InitializeComponent();
/*            // this.label2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            Console.WriteLine();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                button.Text = random.Next(100).ToString();
                button.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                button.AutoSize = true;
                button.Location = new Point(55 + (i*100), 230);
                button.Click += Button_Click;
*//*                button.Click += Button_Click1;
                button.Click += (aa, bb) =>
                {
                    MessageBox.Show("람다가 되네?"+"sender"+);
                };*//*
                Controls.Add(button);
            }*/
            addbuttons();
            setlabellist();
        }

        private void Button_Click1(object aa, EventArgs bb)
        {
            MessageBox.Show("버튼클릭또되나?");
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int temp = int.Parse(btn.Text);
            ints.Add(temp);
            setlabellist() ;
        }

        // 버튼 추가하는 함수
        private void addbuttons()
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                String randomstr = random.Next(100).ToString();
                //추가하는 버튼
                Button button = new Button();
                button.Text = randomstr;
                button.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                button.AutoSize = true;
                button.Location = new Point(55 + (i * 100), 220);
                button.Click += Button_Click;
                setlabellist();
                Controls.Add(button);


                Button button1 = new Button();
                button1.Text = randomstr;
                button1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                button1.AutoSize = true;
                button1.Location = new Point(55 + (i * 100), 320);
                button1.Click += (sender, e) =>
                {
                    Button temp = sender as Button;
                    int itemp = int.Parse(temp.Text);
                    ints.Remove(itemp);
                    setlabellist();
                };
                Controls.Add(button1);
            }
        }




        private void setlabellist()
        {
            String result = "";
            for (int i = 0; i < ints.Count; i++)
            {
                if (ints.Count != (i + 1))
                {
                    result = result + ints[i] + ", ";
                }
                else
                {
                    result += ints[i];
                }
            }
            label2.Text = result;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("나와라");
        }
    }
}
