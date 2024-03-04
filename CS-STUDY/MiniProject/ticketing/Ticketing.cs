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
    public partial class Ticketing : Form
    {
        public Ticketing()
        {
            InitializeComponent();
            timer1.Start();
        }

        // 추천 영화 누르면 Tickting3으로 가는 기능 만들어야함

        // 시계
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        // 모든영화보기 가는 버튼
        private void btn_allMovie_Click(object sender, EventArgs e)
        {
            Ticketing2 ticketing2 = new Ticketing2();
            Hide();
            ticketing2.ShowDialog();
        }

        // 메인화면 가는 버튼
        private void btn_goHome_Click(object sender, EventArgs e)
        {
            MainDisplay mainDisplay = new MainDisplay();
            Hide();
            mainDisplay.ShowDialog();
        }
    }
}
