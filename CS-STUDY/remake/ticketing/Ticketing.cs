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
    public partial class Ticketing : Form
    {

        public Ticketing()
        {
            InitializeComponent();
            timer1.Start();
            ImportMovie();
        }

        // 추천 영화 누르면 Tickting3으로 가는 기능 만들어야함

        // 시계
        private void timer1_Tick(object sender, EventArgs e)
        {
            datetime.Text = DateTime.Now.ToString();
        }

        // 모든영화보기 가는 버튼
        private void btn_allMovie_Click(object sender, EventArgs e)
        {
            Ticketing2 ticketing2 = new Ticketing2();
            ticketing2.Show();
            Close();
        }

        // 메인화면 가는 버튼
        private void btn_goHome_Click(object sender, EventArgs e)
        {
            MainDisplay mainDisplay = new MainDisplay();
            mainDisplay.Show();
            Close();
        }
        public void ImportMovie() 
        {
            List<String> movie1 = MainDB.Movie1();
            List<String> movie1time2 = MainDB.Movie1To2();
            List<String> movie1time33 = MainDB.Movie2To3();
            tk1moviename.Text = movie1[4].ToString();// 영화명
            tk1movieage.Text = movie1[5].ToString();// 영화 연령
            tk1moviestory.Text = movie1[8].ToString();// 영화 줄거리
            movie1time1.Text = movie1[3].ToString();//영화시간1
            movietime2.Text = movie1time2[3].ToString();//영화시간 2
            movie1time3.Text = movie1time33[3].ToString();//영화시간 3
        }

    }
}
