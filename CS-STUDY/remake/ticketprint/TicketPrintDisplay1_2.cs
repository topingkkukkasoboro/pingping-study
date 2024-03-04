namespace miniproject.ticketprint
{
    public partial class TicketPrintDisplay1_2 : Form
    {
        public TicketPrintDisplay1_2()
        {
            InitializeComponent();
            timer1.Start();
        }

        // 검색한 정보에 맞는 정보 띄워 주는 기능 만들어야함

        // 출력 버튼
        // 출력하고 일정시간 뒤에 첫 화면으로 가는 기능 만들어야함
        private void btn_print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("예매번호로출력");
            Hide();
        }
        
        // 이전화면 가는 버튼
        private void btn_goPre_Click(object sender, EventArgs e)
        {
            TicketPrintDisplay1_1 ticketPrintDisplay1_1 = new TicketPrintDisplay1_1();
            Hide();
            ticketPrintDisplay1_1.ShowDialog();
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
