using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NAudio.Wave;
using System.Media;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp2
{

    public partial class Form1 : Form
    {


        private HashSet<Keys> keysPressed = new HashSet<Keys>(); // 현재 눌린 키를 저장할 해시셋 // 이거 안쓰면 버징 걸림
        private Dictionary<Keys, string> mp3FilePaths = new Dictionary<Keys, string>(); // 각 키에 대한 MP3 파일 경로 저장
        private Dictionary<Keys, WaveOutEvent> outputDevices = new Dictionary<Keys, WaveOutEvent>(); // 각 키에 대한 WaveOutEvent 인스턴스 저장

        private WaveInEvent waveSource; // wave파일 사용하기 위한 인스턴스
        private WaveFileWriter waveFile; // wave파일을 작성하기 위한 인스턴스
        private SoundPlayer soundPlayer; // 재생하자 좀 제발





        public Form1()
        {
            InitializeComponent();
            InitializeKeyMonitoring();

            // 보이지마라
            num1.Visible = false; num2.Visible = false; num3.Visible = false; num4.Visible = false; num5.Visible = false; num6.Visible = false; num7.Visible = false; num8.Visible = false;

            numq.Visible = false; numw.Visible = false; nume.Visible = false; numr.Visible = false; numt.Visible = false; numy.Visible = false; numu.Visible = false; numi.Visible = false;

            numa.Visible = false; nums.Visible = false; numd.Visible = false; numf.Visible = false; numg.Visible = false; numh.Visible = false; numj.Visible = false; numk.Visible = false;

            numz.Visible = false; numx.Visible = false; numc.Visible = false; numv.Visible = false; numb.Visible = false; numn.Visible = false; numm.Visible = false; numcom.Visible = false;

            nump7.Visible = false; nump8.Visible = false; nump9.Visible = false; nump4.Visible = false; nump5.Visible = false; nump6.Visible = false; nump1.Visible = false; nump2.Visible = false;

            Rc.Visible = false; Rc2.Visible = false;

            d1c.Visible = false; d2d.Visible = false; d3e.Visible = false; d4f.Visible = false; d5g.Visible = false; d6a.Visible = false; d7b.Visible = false; d8c.Visible = false;

            wd.Visible = false; ee.Visible = false; rf.Visible = false; tg.Visible = false; ya.Visible = false; ub.Visible = false; ic.Visible = false;

            sd.Visible = false; de.Visible = false; ff.Visible = false; gg.Visible = false; ha.Visible = false; jb.Visible = false; kc.Visible = false;

            xd.Visible = false; ce.Visible = false; vf.Visible = false; bg.Visible = false; na.Visible = false; mb.Visible = false; n1c.Visible = false;

            np8d.Visible = false; np9e.Visible = false; np4f.Visible = false; np5g.Visible = false; np6a.Visible = false; np1b.Visible = false; np2c.Visible = false;

            loop.Visible = false;



            //#을 구현해야하나 말아냐 하나 

            /*            mp3FilePaths.Add(Keys.Q, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음\도도.mp3");
                        mp3FilePaths.Add(Keys.D2, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음#\도도#.mp3");
                         mp3FilePaths.Add(Keys.W, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음\레레.mp3");
            mp3FilePaths.Add(Keys.D3, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음#\레레#.mp3");
            mp3FilePaths.Add(Keys.E, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음\미미.mp3");
            mp3FilePaths.Add(Keys.R, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음\파파.mp3");
            mp3FilePaths.Add(Keys.T, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음\솔솔.mp3");
            mp3FilePaths.Add(Keys.D5, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음#\솔솔#.mp3");
            mp3FilePaths.Add(Keys.Y, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음\라라.mp3");
            mp3FilePaths.Add(Keys.D6, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음#\라라#.mp3");
            mp3FilePaths.Add(Keys.U, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음\시시.mp3");
            mp3FilePaths.Add(Keys.D7, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음#\시시#.mp3");
            mp3FilePaths.Add(Keys.I, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음\도도도.mp3");

            mp3FilePaths.Add(Keys.Z, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음\도도도.mp3");
            mp3FilePaths.Add(Keys.S, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음#\도도도#.mp3");
            mp3FilePaths.Add(Keys.X, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음\레레레.mp3");
            mp3FilePaths.Add(Keys.D, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음#\레레레#.mp3");
            mp3FilePaths.Add(Keys.C, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음\미미미.mp3");

            mp3FilePaths.Add(Keys.X, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음\파파파.mp3");


            */
            // 각 키에 대한 MP3 파일 경로 설정
            mp3FilePaths.Add(Keys.D1, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 낮은 음\도.mp3");
            mp3FilePaths.Add(Keys.D2, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 낮은 음\레.mp3");
            mp3FilePaths.Add(Keys.D3, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 낮은 음\미.mp3");
            mp3FilePaths.Add(Keys.D4, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 낮은 음\파.mp3");
            mp3FilePaths.Add(Keys.D5, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 낮은 음\솔.mp3");
            mp3FilePaths.Add(Keys.D6, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 낮은 음\라.mp3");
            mp3FilePaths.Add(Keys.D7, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 낮은 음\시.mp3");
            mp3FilePaths.Add(Keys.D8, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음\도도.mp3");

            mp3FilePaths.Add(Keys.Q, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음\도도.mp3");
            mp3FilePaths.Add(Keys.W, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음\레레.mp3");
            mp3FilePaths.Add(Keys.E, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음\미미.mp3");
            mp3FilePaths.Add(Keys.R, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음\파파.mp3");
            mp3FilePaths.Add(Keys.T, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음\솔솔.mp3");
            mp3FilePaths.Add(Keys.Y, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음\라라.mp3");
            mp3FilePaths.Add(Keys.U, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\낮은 음\시시.mp3");
            mp3FilePaths.Add(Keys.I, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음\도도도.mp3");

            mp3FilePaths.Add(Keys.A, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음\도도도.mp3");
            mp3FilePaths.Add(Keys.S, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음\레레레.mp3");
            mp3FilePaths.Add(Keys.D, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음\미미미.mp3");
            mp3FilePaths.Add(Keys.F, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음\파파파.mp3");
            mp3FilePaths.Add(Keys.G, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음\솔솔솔.mp3");
            mp3FilePaths.Add(Keys.H, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음\라라라.mp3");
            mp3FilePaths.Add(Keys.J, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\기본 음\시시시.mp3");
            mp3FilePaths.Add(Keys.K, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\높은 음\도도도도.mp3");

            mp3FilePaths.Add(Keys.Z, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\높은 음\도도도도.mp3");
            mp3FilePaths.Add(Keys.X, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\높은 음\레레레레.mp3");
            mp3FilePaths.Add(Keys.C, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\높은 음\미미미미.mp3");
            mp3FilePaths.Add(Keys.V, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\높은 음\파파파파.mp3");
            mp3FilePaths.Add(Keys.B, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\높은 음\솔솔솔솔.mp3");
            mp3FilePaths.Add(Keys.N, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\높은 음\라라라라.mp3");
            mp3FilePaths.Add(Keys.M, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\높은 음\시시시시.mp3");
            mp3FilePaths.Add(Keys.Oemcomma, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 높은 음\도도도도도.mp3");

            mp3FilePaths.Add(Keys.NumPad7, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 높은 음\도도도도도.mp3");
            mp3FilePaths.Add(Keys.NumPad8, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 높은 음\레레레레레.mp3");
            mp3FilePaths.Add(Keys.NumPad9, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 높은 음\미미미미미.mp3");
            mp3FilePaths.Add(Keys.NumPad4, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 높은 음\파파파파파.mp3");
            mp3FilePaths.Add(Keys.NumPad5, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 높은 음\솔솔솔솔솔.mp3");
            mp3FilePaths.Add(Keys.NumPad6, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 높은 음\라라라라라.mp3");
            mp3FilePaths.Add(Keys.NumPad1, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 높은 음\시시시시시.mp3");
            mp3FilePaths.Add(Keys.NumPad2, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\피아노 소리\제일 높은 음\끝.mp3");



            // 각 키에 대한 WaveOutEvent 인스턴스 생성
            // 각 각 실행되게 할려면 순간 저장
            // waveout 인스턴는 outputDevices여기에 저장
            foreach (var key in mp3FilePaths.Keys)
            {
                outputDevices[key] = new WaveOutEvent();
            }
        }

        private void InitializeKeyMonitoring()
        {
            // 키 이벤트 핸들러 등록
            KeyPreview = true;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
        }

        // 키 다운 이벤트 핸들러
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // 만약 mp3FilePaths 딕셔너리에 해당 키코드가 존재하고 MP3 파일 경로가 비어 있지 않으면
            if (mp3FilePaths.ContainsKey(e.KeyCode) && !string.IsNullOrEmpty(mp3FilePaths[e.KeyCode]))
            {
                // 해당 키가 keysPressed 리스트에 없다면
                if (!keysPressed.Contains(e.KeyCode))
                {
                    // keysPressed 리스트에 해당 키를 추가하고 해당 키에 대한 MP3를 재생해라고
                    keysPressed.Add(e.KeyCode);
                    PlayMP3IfNotPlaying(e.KeyCode);
                }

                // 해당 키에 맞는 라벨을 표시하는 부분
                ShowNoteLabel(e.KeyCode);

            }
            //키보드의 F1을 눌렀을때 녹음시작
            if (e.KeyCode == Keys.F1)
            {
                button1_Click(sender, e);
            }
            // 키보드의 f2를 눌렀을때 녹음 스탑
            if (e.KeyCode == Keys.F2)
            {
                button2_Click(sender, e);
            }

            // 넘패드의 + 키를 눌렀을 때
            if (e.KeyCode == Keys.Add)
            {
                AdjustVolume(1);
            }
            // 넘패드의 - 키를 눌렀을 때
            if (e.KeyCode == Keys.Subtract)
            {
                AdjustVolume(-1);
            }
            if(e.KeyCode == Keys.Space)
            {

            }
            else if (e.KeyCode != Keys.Add && e.KeyCode != Keys.Subtract)
            {
                // 지정된 키 외에 다른 키가 눌렸을 때 오류를 방지하기 위해 추가
                // 망할 변수
                e.SuppressKeyPress = true;
            }

        }

        // 키 업 이벤트 핸들러
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // 해당 키를 뗀 상태로 변경
            keysPressed.Remove(e.KeyCode);
            HideNoteLabel(e.KeyCode);
            if (e.KeyCode == Keys.D1) { num1.Visible = false; d1c.Visible = false; }
            if (e.KeyCode == Keys.D2) { num2.Visible = false; d2d.Visible = false; }
            if (e.KeyCode == Keys.D3) { num3.Visible = false; d3e.Visible = false; }
            if (e.KeyCode == Keys.D4) { num4.Visible = false; d4f.Visible = false; }
            if (e.KeyCode == Keys.D5) { num5.Visible = false; d5g.Visible = false; }
            if (e.KeyCode == Keys.D6) { num6.Visible = false; d6a.Visible = false; }
            if (e.KeyCode == Keys.D7) { num7.Visible = false; d7b.Visible = false; }
            if (e.KeyCode == Keys.D8) { num8.Visible = false; d8c.Visible = false; }

            if (e.KeyCode == Keys.Q) { numq.Visible = false; d8c.Visible = false; }
            if (e.KeyCode == Keys.W) { numw.Visible = false; wd.Visible = false; }
            if (e.KeyCode == Keys.E) { nume.Visible = false; ee.Visible = false; }
            if (e.KeyCode == Keys.R) { numr.Visible = false; rf.Visible = false; }
            if (e.KeyCode == Keys.T) { numt.Visible = false; tg.Visible = false; }
            if (e.KeyCode == Keys.Y) { numy.Visible = false; ya.Visible = false; }
            if (e.KeyCode == Keys.U) { numu.Visible = false; ub.Visible = false; }
            if (e.KeyCode == Keys.I) { numi.Visible = false; ic.Visible = false; }

            if (e.KeyCode == Keys.A) { numa.Visible = false; ic.Visible = false; }
            if (e.KeyCode == Keys.S) { nums.Visible = false; sd.Visible = false; }
            if (e.KeyCode == Keys.D) { numd.Visible = false; de.Visible = false; }
            if (e.KeyCode == Keys.F) { numf.Visible = false; ff.Visible = false; }
            if (e.KeyCode == Keys.G) { numg.Visible = false; gg.Visible = false; }
            if (e.KeyCode == Keys.H) { numh.Visible = false; ha.Visible = false; }
            if (e.KeyCode == Keys.J) { numj.Visible = false; jb.Visible = false; }
            if (e.KeyCode == Keys.K) { numk.Visible = false; kc.Visible = false; }

            if (e.KeyCode == Keys.Z) { numz.Visible = false; kc.Visible = false; }
            if (e.KeyCode == Keys.X) { numx.Visible = false; xd.Visible = false; }
            if (e.KeyCode == Keys.C) { numc.Visible = false; ce.Visible = false; }
            if (e.KeyCode == Keys.V) { numv.Visible = false; vf.Visible = false; }
            if (e.KeyCode == Keys.B) { numb.Visible = false; bg.Visible = false; }
            if (e.KeyCode == Keys.N) { numn.Visible = false; na.Visible = false; }
            if (e.KeyCode == Keys.M) { numm.Visible = false; mb.Visible = false; }
            if (e.KeyCode == Keys.Oemcomma) { numcom.Visible = false; n1c.Visible = false; }

            if (e.KeyCode == Keys.NumPad7) { nump7.Visible = false; n1c.Visible = false; }
            if (e.KeyCode == Keys.NumPad8) { nump8.Visible = false; np8d.Visible = false; }
            if (e.KeyCode == Keys.NumPad9) { nump9.Visible = false; np9e.Visible = false; }
            if (e.KeyCode == Keys.NumPad4) { nump4.Visible = false; np4f.Visible = false; }
            if (e.KeyCode == Keys.NumPad5) { nump5.Visible = false; np5g.Visible = false; }
            if (e.KeyCode == Keys.NumPad6) { nump6.Visible = false; np6a.Visible = false; }
            if (e.KeyCode == Keys.NumPad1) { nump1.Visible = false; np1b.Visible = false; }
            if (e.KeyCode == Keys.NumPad2) { nump2.Visible = false; np2c.Visible = false; }

        }
        private void PlayMP3IfNotPlaying(Keys key)
        {
            // 만약 outputDevices 딕셔너리에 주어진 키에 해당하는 인스턴스가 존재한다면
            if (outputDevices.ContainsKey(key))
            {
                // 재생하지말고 헤제해라
                outputDevices[key]?.Stop();
                outputDevices[key]?.Dispose();
                outputDevices.Remove(key); // 인스턴스 삭제 key눌린것에 대한
            }
            // if 안걸리면 인스턴스 새로 생성하고 해당 파일 초기화 안하면 조짐
            outputDevices[key] = new WaveOutEvent();
            outputDevices[key].Init(new AudioFileReader(mp3FilePaths[key]));
            outputDevices[key].Play();
        }

        // 이건 키다운이다 왜 switch 써야 되는건가
        private void ShowNoteLabel(Keys key)
        {
            switch (key)
            {
                case Keys.D1:
                    num1.Visible = true;
                    d1c.Visible = true;
                    break;
                case Keys.D2:
                    num2.Visible = true;
                    d2d.Visible = true;
                    break;
                case Keys.D3:
                    num3.Visible = true;
                    d3e.Visible = true;
                    break;
                case Keys.D4:
                    num4.Visible = true;
                    d4f.Visible = true;
                    break;
                case Keys.D5:
                    num5.Visible = true;
                    d5g.Visible = true;
                    break;
                case Keys.D6:
                    num6.Visible = true;
                    d6a.Visible = true;
                    break;
                case Keys.D7:
                    num7.Visible = true;
                    d7b.Visible = true;
                    break;
                case Keys.D8:
                    num8.Visible = true;
                    d8c.Visible = true;
                    break;
                case Keys.Q:
                    numq.Visible = true;
                    d8c.Visible = true;
                    break;
                case Keys.W:
                    numw.Visible = true;
                    wd.Visible = true;
                    break;
                case Keys.E:
                    nume.Visible = true;
                    ee.Visible = true;
                    break;
                case Keys.R:
                    numr.Visible = true;
                    rf.Visible = true;
                    break;
                case Keys.T:
                    numt.Visible = true;
                    tg.Visible = true;
                    break;
                case Keys.Y:
                    numy.Visible = true;
                    ya.Visible = true;
                    break;
                case Keys.U:
                    numu.Visible = true;
                    ub.Visible = true;
                    break;
                case Keys.I:
                    numi.Visible = true;
                    ic.Visible = true;
                    break;
                case Keys.A:
                    numa.Visible = true;
                    ic.Visible = true;
                    break;
                case Keys.S:
                    nums.Visible = true;
                    sd.Visible = true;
                    break;
                case Keys.D:
                    numd.Visible = true;
                    de.Visible = true;
                    break;
                case Keys.F:
                    numf.Visible = true;
                    ff.Visible = true;
                    break;
                case Keys.G:
                    numg.Visible = true;
                    gg.Visible = true;
                    break;
                case Keys.H:
                    numh.Visible = true;
                    ha.Visible = true;
                    break;
                case Keys.J:
                    numj.Visible = true;
                    jb.Visible = true;
                    break;
                case Keys.K:
                    numk.Visible = true;
                    kc.Visible = true;
                    break;
                case Keys.Z:
                    numz.Visible = true;
                    kc.Visible = true;
                    break;
                case Keys.X:
                    numx.Visible = true;
                    xd.Visible = true;
                    break;
                case Keys.C:
                    numc.Visible = true;
                    ce.Visible = true;
                    break;
                case Keys.V:
                    numv.Visible = true;
                    vf.Visible = true;
                    break;
                case Keys.B:
                    numb.Visible = true;
                    bg.Visible = true;
                    break;
                case Keys.N:
                    numn.Visible = true;
                    na.Visible = true;
                    break;
                case Keys.M:
                    numm.Visible = true;
                    mb.Visible = true;
                    break;
                case Keys.Oemcomma:
                    numcom.Visible = true;
                    n1c.Visible = true;
                    break;
                case Keys.NumPad7:
                    nump7.Visible = true;
                    n1c.Visible = true;
                    break;
                case Keys.NumPad8:
                    nump8.Visible = true;
                    np8d.Visible = true;
                    break;
                case Keys.NumPad9:
                    nump9.Visible = true;
                    np9e.Visible = true;
                    break;
                case Keys.NumPad4:
                    nump4.Visible = true;
                    np4f.Visible = true;
                    break;
                case Keys.NumPad5:
                    nump5.Visible = true;
                    np5g.Visible = true;
                    break;
                case Keys.NumPad6:
                    nump6.Visible = true;
                    np6a.Visible = true;
                    break;
                case Keys.NumPad1:
                    nump1.Visible = true;
                    np1b.Visible = true;
                    break;
                case Keys.NumPad2:
                    nump2.Visible = true;
                    np2c.Visible = true;
                    break;
                default:
                    break;
            }
        }

        // 아무것도 없다
        private void HideNoteLabel(Keys key)
        {
            switch (key)
            {
            }
        }

        // MP3 파일 재생 함수
        private void PlayMP3(Keys key, string filePath)
        {
            // NAudio 라이브러리를 사용하여 MP3 파일을 재생
            using (var audioFile = new AudioFileReader(filePath))
            {
                var outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int volume = trackBar1.Value; // 트랙바의 값(음량) 가져오기

            // 모든 재생 중인 WaveOutEvent에 대해 볼륨 조절
            foreach (var outputDevice in outputDevices.Values)
            {
                outputDevice.Volume = volume / 100f; // 볼륨 값을 0과 1 사이로 설정
            }
        }
        private void AdjustVolume(int increment)
        {
            int volume = trackBar1.Value + increment;
            volume = Math.Max(trackBar1.Minimum, Math.Min(trackBar1.Maximum, volume)); // 최소값과 최대값 사이에서 볼륨 조절
            trackBar1.Value = volume;

            // 모든 재생 중인 WaveOutEvent에 대해 볼륨 조절
            foreach (var outputDevice in outputDevices.Values)
            {
                outputDevice.Volume = volume / 100f; // 볼륨 값을 0과 1 사이로 설정
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\PC_DSKTOP2\Desktop\녹음파일\"; // 저장할 폴더 경로
            string fileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".wav"; // 현재 날짜와 시간으로 파일명 생성
            string filePath = Path.Combine(folderPath, fileName); // 전체 파일 경로 생성

            // 녹음을 시작하기 전에 기존에 녹음 중인 경우 중지
            StopRecording();

            // NAudio 라이브러리를 사용하여 녹음 시작
            waveSource = new WaveInEvent();
            waveSource.WaveFormat = new WaveFormat(44100, 1); // 44.1kHz, 모노 설정
            waveFile = new WaveFileWriter(filePath, waveSource.WaveFormat);

            waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable); // 데이터가 이용 가능할 때 이벤트 핸들러 연결
            waveSource.StartRecording(); // 녹음 시작

            Rc.Visible = true;
            Rc2.Visible = true;
        }

        private void StopRecording()
        {
            // 기존에 녹음 중이었다면 중지하고 자원을 해제
            // 안하니 조짐
            if (waveSource != null)
            {
                waveSource.StopRecording();
                waveSource.Dispose();
                waveSource = null;
            }

            if (waveFile != null)
            {
                waveFile.Dispose();
                waveFile = null;
            }
        }

        private void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            // 녹음된 데이터를 파일에 씁니다.
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded); // 버퍼 기록
                waveFile.Flush(); // 버퍼에 생긴 데이터를 디스크에 써서 만든다
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StopRecording();

            Rc.Visible = false;
            Rc2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //또 인스턴스
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    // 파일경로, 파일 종류 설정
                    openFileDialog.InitialDirectory = @"C:\Users\PC_DSKTOP2\Desktop\녹음파일";
                    openFileDialog.Filter = "WAV 파일 (*.wav)|*.wav|모든 파일 (*.*)|*.*";
                    openFileDialog.FilterIndex = 1; // 필터링 하나만 하자 wav만 되게
                    openFileDialog.RestoreDirectory = true; // 폴더 위치 기억

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFilePath = openFileDialog.FileName;
                        PlayRecordedAudio(selectedFilePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("파일을 열던 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // 예외일때는 오류라는 창이름 + 오류 발생했어 + 확인 버튼 // 버튼 눌러봐
            }
        }

        private void PlayRecordedAudio(string filePath)
        {
            try
            {
                // 오디오 파일 경로 불러올려고 또스턴스 생성
                using (var audioFile = new AudioFileReader(filePath))
                {
                    //재생을 위한 또스턴스 생성
                    using (var outputDevice = new WaveOutEvent())
                    {
                        outputDevice.Init(audioFile); // 선 초기화
                        outputDevice.Play(); // 플레이

                        // 재생이 끝날 때까지 대기 
                        while (outputDevice.PlaybackState == PlaybackState.Playing)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오디오 파일을 재생하는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void loopstart_Click(object sender, EventArgs e)
        {
            // OpenFileDialog를 생성하여 WAV 파일을 선택할 수 있도록 합니다.
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\PC_DSKTOP2\Desktop\녹음파일";
                openFileDialog.Filter = "WAV 파일 (*.wav)|*.wav|모든 파일 (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // 사용자가 파일을 선택하고 확인 버튼을 눌렀을 때
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 선택된 파일 경로를 가져옵니다.
                    string selectedFilePath = openFileDialog.FileName;

                    // 이전에 생성된 SoundPlayer 객체가 있다면 해제
                    if (soundPlayer != null)
                    {
                        soundPlayer.Dispose();
                    }

                    // SoundPlayer 객체 생성 및 선택된 음악 파일 로드
                    soundPlayer = new SoundPlayer(selectedFilePath);

                    // 무한 반복 설정
                    soundPlayer.PlayLooping();
                }
            }
            loop.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (soundPlayer != null)
            {
                // 무한 반복 재생을 멈춥니다.
                soundPlayer.Stop();
                // SoundPlayer 객체를 해제합니다.
                soundPlayer.Dispose();

                loop.Visible = false;
            }
        }


    }
}