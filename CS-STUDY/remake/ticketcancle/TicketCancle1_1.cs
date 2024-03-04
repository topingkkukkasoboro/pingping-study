﻿using miniproject.ticketprint;
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
    public partial class TicketCancle1_1 : Form
    {
        public TicketCancle1_1()
        {
            InitializeComponent();
            timer1.Start();
        }

        // 취소 버튼
        // 예매 번호 확인,삭제 기능 만들어야함
        private void btn_check_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소완료");
            Hide();
        }

        // 이전화면 가는 버튼
        private void btn_goPre_Click(object sender, EventArgs e)
        {
            TicketCancleMain ticketCancleMain = new TicketCancleMain();
            Hide();
            ticketCancleMain.ShowDialog();
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