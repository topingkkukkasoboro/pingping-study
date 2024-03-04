namespace miniproject.ticketprint
{
    public partial class TicketPrintDisplay1 : Form
    {
        public TicketPrintDisplay1()
        {
            InitializeComponent();
            timer1.Start();
        }

        // 예매번호조회 가는 버튼
        private void btn_tkNum_Click(object sender, EventArgs e)
        {
            TicketPrintDisplay1_1 ticketPrintDisplay1_1 = new TicketPrintDisplay1_1();
            Hide();
            ticketPrintDisplay1_1.ShowDialog();
        }

        // 전화번호조회 가는 버튼
        private void btn_phoneNum_Click(object sender, EventArgs e)
        {
            TicketPrintDisplay2_1 ticketPrintDisplay2_1 = new TicketPrintDisplay2_1();
            Hide();
            ticketPrintDisplay2_1.ShowDialog();
        }

        // 메인화면 가는 버튼
        private void btn_goHome_Click(object sender, EventArgs e)
        {
            MainDisplay mainDisplay = new MainDisplay();
            Hide();
            mainDisplay.ShowDialog();
        }

        // 시계
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy-MM-dd\ntt hh:mm:ss");
        }
    }
}
