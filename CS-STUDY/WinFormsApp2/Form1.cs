namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).ToString());
            MessageBox.Show(tb.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int num1;
            //int num2;

            int.TryParse(tb_num1.Text.ToString(), out int num1);
            int.TryParse(tb_num2.Text.ToString(), out int num2);

            MessageBox.Show("더하기" + (num1 + num2));
            label6.Text = (num1 + num2) + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int num1;
            //int num2;

            int.TryParse(tb_num1.Text.ToString(), out int num1);
            int.TryParse(tb_num2.Text.ToString(), out int num2);

            
            MessageBox.Show("빼기" + (num1 - num2));
            label6.Text = (num1 - num2) + "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //int num1;
                //int num2;

                int.TryParse(tb_num1.Text.ToString(), out int num1);
                int.TryParse(tb_num2.Text.ToString(), out int num2);
                MessageBox.Show("나누기" + (num1 / num2));
                label6.Text = (num1 / num2) + "";
            }
            catch (Exception)
            {
                MessageBox.Show("0으로 나눌수없습니다");

                throw;
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //int num1;
            //int num2;

            int.TryParse(tb_num1.Text.ToString(), out int num1);
            int.TryParse(tb_num2.Text.ToString(), out int num2);
            MessageBox.Show("곱하기" + (num1 * num2));
            label6.Text = (num1 * num2) + "";
        }

        private void lb_result(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
