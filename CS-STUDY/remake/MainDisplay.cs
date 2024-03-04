using miniproject.ticketcancle;
using miniproject.ticketing;
using miniproject.ticketprint;

namespace miniproject
{
    public partial class MainDisplay : Form
    {
        public MainDisplay()
        {
            InitializeComponent();
            timer1.Start();
        }

        // 시계
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy-MM-dd\ntt hh:mm:ss");
        }

        // 티켓 출력으로 가는 버튼
        private void btn_gotp_Click(object sender, EventArgs e)
        {
            TicketPrintDisplay1 ticketPrintDisplay1 = new TicketPrintDisplay1();
            Hide();
            ticketPrintDisplay1.ShowDialog();
        }

        // 티켓 예매로 가는 버튼
        private void btn_gotk_Click(object sender, EventArgs e)
        {
            Ticketing ticekting = new Ticketing();
            Hide();
            ticekting.ShowDialog();
        }

        // 예매 취소로 가는 버튼
        private void btn_gotkCancle_Click(object sender, EventArgs e)
        {
            TicketCancleMain ticketCancleMain = new TicketCancleMain();
            Hide();
            ticketCancleMain.ShowDialog();
        }
    }
}
