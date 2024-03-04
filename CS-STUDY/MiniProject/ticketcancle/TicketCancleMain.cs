using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproject.ticketcancle
{
    public partial class TicketCancleMain : Form
    {
        public TicketCancleMain()
        {
            InitializeComponent();
            timer1.Start();
        }

        // 예매번호취소로 가는 버튼
        private void btn_tkNum_Click(object sender, EventArgs e)
        {
            TicketCancle1_1 ticketCancle1_1 = new TicketCancle1_1();
            Hide();
            ticketCancle1_1.ShowDialog();
        }

        // 전화번호취소로 가는 버튼
        private void btn_phoneNum_Click(object sender, EventArgs e)
        {
            TicketCancle2_1 ticketCancle2_1 = new TicketCancle2_1();
            Hide();
            ticketCancle2_1.ShowDialog();
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
