using miniproject.ticketprint;
using remake.dagtbase;
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
        Tk2 tk2 = new Tk2();
        Ticketing3 Ticketing3 = new Ticketing3();

        private String mv1;
        private String mv2;
        private String mv3;
        private String mv1t1;
        private String mv1t2;
        private String mv1t3;
        private String mv2t1;
        private String mv2t2;
        private String mv2t3;
        private String mv3t1;
        private String mv3t2;
        private String mv3t3;
        public Ticketing2()
        {
            InitializeComponent();
            timer1.Start();
            Movie1();
            Movie2();
            Movie3();
           
        }
        // 이전화면 가는 버튼
        private void btn_goPre_Click(object sender, EventArgs e)
        {
            Ticketing ticketing = new Ticketing();
            ticketing.Show();
            Close();
        }

        // 메인화면 가는 버튼
        private void btn_goHome_Click(object sender, EventArgs e)
        {
            MainDisplay mainDisplay = new MainDisplay();
            mainDisplay.Show();
            Close();
        }

        // 시계
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
        //영화1의 정보
        public void Movie1()
        {
            String mv1 = tk2.MovieName1();
            String mv1t1 = tk2.mv1();
            String mv1t2 = tk2.mv2();
            String mv1t3 = tk2.mv3();
            movie1name.Text = mv1;
            movie1time1.Text = mv1t1;
            movie1time2.Text = mv1t2;
            movie1time3.Text = mv1t3;
        }
        //영화2의 정보
        public void Movie2()
        {
            String mv2 = tk2.MovieName2();
            String mv2t1 = tk2.mv4();
            String mv2t2 = tk2.mv5();
            String mv2t3 = tk2.mv6();
            movie2name.Text = mv2;
            movie2time1.Text = mv2t1;
            movie2time2.Text = mv2t2;
            movie2time3.Text = mv2t3;
        }
        //영화3의 정보
        public void Movie3()
        {
            String mv3 = tk2.MovieName3();
            String mv3t1 = tk2.mv7();
            String mv3t2 = tk2.mv8();
            String mv3t3 = tk2.mv9();
            movie3name.Text = mv3;
            movie3time1.Text = mv3t1;
            movie3time2.Text = mv3t2;
            movie3time3.Text = mv3t3;
        }

        //영화1의 1번째 시간 클릭
        private void movie1time1_Click(object sender, EventArgs e)
        {
            Ticketing3.Movie(mv1, mv1t1);
            Ticketing3.Show();
            Close();
        }
        //영화1의 2번째 시간 클릭
        private void movie1time2_Click(object sender, EventArgs e)
        {
            Ticketing3.Movie(mv1, mv1t2);
            Ticketing3.Show();
            Close();
        }
        //영화1의 3번째 시간 클릭
        private void movie1time3_Click(object sender, EventArgs e)
        {
            Ticketing3.Movie(mv1, mv1t3);
            Ticketing3.Show();
            Close();
        }
        //영화2의 1번째 시간 클릭
        private void movie2time1_Click(object sender, EventArgs e)
        {
            Ticketing3.Movie(mv2, mv2t1);
            Ticketing3.Show();
            Close();
        }
        //영화2의 2번째 시간 클릭
        private void movie2time2_Click(object sender, EventArgs e)
        {
            Ticketing3.Movie(mv2, mv2t2);
            Ticketing3.Show();
            Close();
        }
        //영화2의 3번째 시간 클릭
        private void movie2time3_Click(object sender, EventArgs e)
        {
            Ticketing3.Movie(mv2, mv2t3);
            Ticketing3.Show();
            Close();
        }
        //영화3의 1번째 시간 클릭
        private void movie3time1_Click(object sender, EventArgs e)
        {
            Ticketing3.Movie(mv3, mv3t1);
            Ticketing3.Show();
            Close();
        }
        //영화3의 2번째 시간 클릭
        private void movie3time2_Click(object sender, EventArgs e)
        {
            Ticketing3.Movie(mv3, mv3t2);
            Ticketing3.Show();
            Close();
        }
        //영화3의 3번째 시간 클릭
        private void movie3time3_Click(object sender, EventArgs e)
        {
            Ticketing3.Movie(mv3, mv3t3);
            Ticketing3.Show();
            Close();
        }
    }
}
