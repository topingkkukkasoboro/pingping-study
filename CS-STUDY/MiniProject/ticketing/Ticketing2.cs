using miniproject.ticketprint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproject.ticketing
{
    public partial class Ticketing2 : Form
    {
        public Ticketing2()
        {
            InitializeComponent();
            timer1.Start();
        }

        // 임시로 다음화면 가는 버튼
        // 영화 선택하면 다음 화면으로 가는 버튼 만들어야함
        private void button1_Click(object sender, EventArgs e)
        {
            Ticketing3 ticketing3 = new Ticketing3();
            Hide();
            ticketing3.ShowDialog();
        }

        // 이전화면 가는 버튼
        private void btn_goPre_Click(object sender, EventArgs e)
        {
            Ticketing ticketing = new Ticketing();
            Hide();
            ticketing.ShowDialog();
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
            label1.Text = DateTime.Now.ToString();
        }
    }
}
