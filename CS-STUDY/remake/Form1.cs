
namespace miniproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ���� ȭ������ ���� ��ư
        private void btn_gomain_Click(object sender, EventArgs e)
        {
            MainDisplay mainDisplay = new MainDisplay();
            Hide();
            mainDisplay.ShowDialog();
            Show();
        }

        // ��ư �̹��� �ٲ�� ��������
    }
}
