using System.Xml.Serialization;

namespace miniproject.ticketing
{
    public partial class Ticketing3 : Form
    {
        int adult = 0;
        int teen = 0;
        int dis = 0;
        int old = 0;
        int sum = 0;

        private String movien;
        private String moviet;

        public Ticketing3()
        {
            InitializeComponent();
            timer1.Start();
            lb_index1.Text = adult.ToString();
            lb_index2.Text = teen.ToString();
            lb_index3.Text = dis.ToString();
            lb_index4.Text = old.ToString();
            btnEnabled();
            
        }
        public void Movie(String mvname, String mvtime)
        {
            movien = mvname;
            moviet = mvtime;
            moviename.Text = movien;
            movietime.Text = moviet;
        }
        // Ticketing4로 가는 버튼
        private void btn_seatChoice_Click(object sender, EventArgs e)
        {
            sum = adult + teen + dis + old;

            if (sum > 0)
            {
                Ticketing4 ticketing4 = new Ticketing4();
                ticketing4.Show();
                Close();
            }
            else
            {
                MessageBox.Show("인원을 선택해주세요.");
            }
        }

        // 시계
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        // 이전화면 가는 버튼
        private void btn_goPre_Click(object sender, EventArgs e)
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

        // 인원수 버튼 기능 모아둠
        #region btnindex
        private void btnEnabled()
        {
            if (adult == 0)
            {
                btn_index1M.Enabled = false;
                btn_index1M.BackColor = Color.Gray;
                btn_index1M.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (adult > 0)
            {
                btn_index1M.Enabled = true;
                btn_index1M.BackColor = Color.White;
                btn_index1M.FlatAppearance.BorderColor = Color.White;
            }

            if (adult > 8)
            {
                btn_index1P.Enabled = false;
                btn_index1P.BackColor = Color.Gray;
                btn_index1P.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (adult < 9)
            {
                btn_index1P.Enabled = true;
                btn_index1P.BackColor = Color.White;
                btn_index1P.FlatAppearance.BorderColor = Color.White;
            }

            if (teen == 0)
            {
                btn_index2M.Enabled = false;
                btn_index2M.BackColor = Color.Gray;
                btn_index2M.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (teen > 0)
            {
                btn_index2M.Enabled = true;
                btn_index2M.BackColor = Color.White;
                btn_index2M.FlatAppearance.BorderColor = Color.White;
            }

            if (teen > 8)
            {
                btn_index2P.Enabled = false;
                btn_index2P.BackColor = Color.Gray;
                btn_index2P.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (teen < 9)
            {
                btn_index2P.Enabled = true;
                btn_index2P.BackColor = Color.White;
                btn_index2P.FlatAppearance.BorderColor = Color.White;
            }

            if (dis == 0)
            {
                btn_index3M.Enabled = false;
                btn_index3M.BackColor = Color.Gray;
                btn_index3M.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (dis > 0)
            {
                btn_index3M.Enabled = true;
                btn_index3M.BackColor = Color.White;
                btn_index3M.FlatAppearance.BorderColor = Color.White;
            }

            if (dis > 8)
            {
                btn_index3P.Enabled = false;
                btn_index3P.BackColor = Color.Gray;
                btn_index3P.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (teen < 9)
            {
                btn_index3P.Enabled = true;
                btn_index3P.BackColor = Color.White;
                btn_index3P.FlatAppearance.BorderColor = Color.White;
            }

            if (old == 0)
            {
                btn_index4M.Enabled = false;
                btn_index4M.BackColor = Color.Gray;
                btn_index4M.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (old > 0)
            {
                btn_index4M.Enabled = true;
                btn_index4M.BackColor = Color.White;
                btn_index4M.FlatAppearance.BorderColor = Color.White;
            }

            if (old > 8)
            {
                btn_index4P.Enabled = false;
                btn_index4P.BackColor = Color.Gray;
                btn_index4P.FlatAppearance.BorderColor = Color.Gray;
            }
            else if (old < 9)
            {
                btn_index4P.Enabled = true;
                btn_index4P.BackColor = Color.White;
                btn_index4P.FlatAppearance.BorderColor = Color.White;
            }
        }

        private void btn_index1M_Click(object sender, EventArgs e)
        {
            adult--;
            lb_index1.Text = adult.ToString();

            btnEnabled();
        }

        private void btn_index1P_Click(object sender, EventArgs e)
        {
            adult++;
            lb_index1.Text = adult.ToString();

            btnEnabled();
        }

        private void btn_index2M_Click(object sender, EventArgs e)
        {
            teen--;
            lb_index2.Text = teen.ToString();

            btnEnabled();
        }

        private void btn_index2P_Click(object sender, EventArgs e)
        {
            teen++;
            lb_index2.Text = teen.ToString();

            btnEnabled();
        }

        private void btn_index3M_Click(object sender, EventArgs e)
        {
            dis--;
            lb_index3.Text = dis.ToString();

            btnEnabled();
        }

        private void btn_index3P_Click(object sender, EventArgs e)
        {
            dis++;
            lb_index3.Text = dis.ToString();

            btnEnabled();
        }

        private void btn_index4M_Click(object sender, EventArgs e)
        {
            old--;
            lb_index4.Text = old.ToString();

            btnEnabled();
        }

        private void btn_index4P_Click(object sender, EventArgs e)
        {
            old++;
            lb_index4.Text = old.ToString();

            btnEnabled();
        }
        #endregion btnindex
    }
}
