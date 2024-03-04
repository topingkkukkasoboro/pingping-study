using NAudio.Wave;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_keydown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("키 누름" + e.KeyCode);
            if (e.KeyCode == Keys.Q)
            {
                panel1.Visible = false;
                WaveOutEvent waveOut = new WaveOutEvent();
                waveOut.Init(new AudioFileReader(@"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음\도도도.mp3"));
                waveOut.Play();
            }
        }

        private void Form1_keyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("키 똄" + e.KeyCode);
            panel1.Visible = true;
        }

        private void timer1_trick_Click(object sender, EventArgs e)
        {
            timer1_trick.Text = DateTime.Now.ToString();
        }
    }
}
