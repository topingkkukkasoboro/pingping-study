namespace miniproject.ticketprint
{
    public partial class TicketPrintDisplay2_1 : Form
    {
        public TicketPrintDisplay2_1()
        {
            InitializeComponent();
            timer1.Start();
        }

        // 조회 버튼
        // DB에 있는 전화번호로 조회하는 기능 만들어야함
        private void btn_check_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tb_phoneNum.Text);
            TicketPrintDisplay2_2 ticketPrintDisplay2_2 = new TicketPrintDisplay2_2();
            Hide();
            ticketPrintDisplay2_2.ShowDialog();
        }

        // 이전화면 가는 버튼
        private void btn_goPre_Click(object sender, EventArgs e)
        {
            TicketPrintDisplay1 ticketPrintDisplay1 = new TicketPrintDisplay1();
            Hide();
            ticketPrintDisplay1.ShowDialog();
        }

        // 메인화면 가는 버튼
        private void btn_goHome_Click(object sender, EventArgs e)
        {
            MainDisplay mainDisplay = new MainDisplay();
            Hide();
            mainDisplay.ShowDialog();
        }

        // 시계
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy-MM-dd\ntt hh:mm:ss");
        }
    }
}
