
namespace miniproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 메인 화면으로 가는 버튼
        private void btn_gomain_Click(object sender, EventArgs e)
        {
            MainDisplay mainDisplay = new MainDisplay();
            Hide();
            mainDisplay.ShowDialog();
            Show();
        }

        // 버튼 이미지 바뀌게 만들어야함
    }
}
