namespace miniproject.ticketing
{
    public partial class Ticketing4 : Form
    {
        public Ticketing4()
        {
            InitializeComponent();
            timer1.Start();
        }

        // 결제 버튼
        // Ticketing3에서 나온 sum값으로 결제기능 만들어야함
        // DB정보로 예매된 좌석 버튼선택 못하게하고 선택한 버튼 색바뀌게 해야함
        // sum 값으로 sum값 초과되게 좌석 버튼 누르면 안눌리게 해야함
        private void btn_pay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결제완료");
            MainDisplay mainDisplay = new MainDisplay();
            Hide();
        }

        // 시계
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        // 이전화면 가는 버튼
        private void btn_goPre_Click(object sender, EventArgs e)
        {
            Ticketing3 ticketing3 = new Ticketing3();
            Hide();
            ticketing3.ShowDialog();
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
