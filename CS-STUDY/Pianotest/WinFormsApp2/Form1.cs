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


        private HashSet<Keys> keysPressed = new HashSet<Keys>(); // ���� ���� Ű�� ������ �ؽü� // �̰� �Ⱦ��� ��¡ �ɸ�
        private Dictionary<Keys, string> mp3FilePaths = new Dictionary<Keys, string>(); // �� Ű�� ���� MP3 ���� ��� ����
        private Dictionary<Keys, WaveOutEvent> outputDevices = new Dictionary<Keys, WaveOutEvent>(); // �� Ű�� ���� WaveOutEvent �ν��Ͻ� ����

        private WaveInEvent waveSource; // wave���� ����ϱ� ���� �ν��Ͻ�
        private WaveFileWriter waveFile; // wave������ �ۼ��ϱ� ���� �ν��Ͻ�
        private SoundPlayer soundPlayer; // ������� �� ����





        public Form1()
        {
            InitializeComponent();
            InitializeKeyMonitoring();

            // ����������
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



            //#�� �����ؾ��ϳ� ���Ƴ� �ϳ� 

            /*            mp3FilePaths.Add(Keys.Q, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\����.mp3");
                        mp3FilePaths.Add(Keys.D2, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��#\����#.mp3");
                         mp3FilePaths.Add(Keys.W, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\����.mp3");
            mp3FilePaths.Add(Keys.D3, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��#\����#.mp3");
            mp3FilePaths.Add(Keys.E, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\�̹�.mp3");
            mp3FilePaths.Add(Keys.R, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\����.mp3");
            mp3FilePaths.Add(Keys.T, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\�ּ�.mp3");
            mp3FilePaths.Add(Keys.D5, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��#\�ּ�#.mp3");
            mp3FilePaths.Add(Keys.Y, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\���.mp3");
            mp3FilePaths.Add(Keys.D6, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��#\���#.mp3");
            mp3FilePaths.Add(Keys.U, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\�ý�.mp3");
            mp3FilePaths.Add(Keys.D7, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��#\�ý�#.mp3");
            mp3FilePaths.Add(Keys.I, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\�⺻ ��\������.mp3");

            mp3FilePaths.Add(Keys.Z, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\�⺻ ��\������.mp3");
            mp3FilePaths.Add(Keys.S, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\�⺻ ��#\������#.mp3");
            mp3FilePaths.Add(Keys.X, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\�⺻ ��\������.mp3");
            mp3FilePaths.Add(Keys.D, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\�⺻ ��#\������#.mp3");
            mp3FilePaths.Add(Keys.C, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\�⺻ ��\�̹̹�.mp3");

            mp3FilePaths.Add(Keys.X, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\�⺻ ��\������.mp3");


            */
            // �� Ű�� ���� MP3 ���� ��� ����
            mp3FilePaths.Add(Keys.D1, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\��.mp3");
            mp3FilePaths.Add(Keys.D2, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\��.mp3");
            mp3FilePaths.Add(Keys.D3, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\��.mp3");
            mp3FilePaths.Add(Keys.D4, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\��.mp3");
            mp3FilePaths.Add(Keys.D5, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\��.mp3");
            mp3FilePaths.Add(Keys.D6, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\��.mp3");
            mp3FilePaths.Add(Keys.D7, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\��.mp3");
            mp3FilePaths.Add(Keys.D8, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\����.mp3");

            mp3FilePaths.Add(Keys.Q, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\����.mp3");
            mp3FilePaths.Add(Keys.W, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\����.mp3");
            mp3FilePaths.Add(Keys.E, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\�̹�.mp3");
            mp3FilePaths.Add(Keys.R, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\����.mp3");
            mp3FilePaths.Add(Keys.T, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\�ּ�.mp3");
            mp3FilePaths.Add(Keys.Y, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\���.mp3");
            mp3FilePaths.Add(Keys.U, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\�ý�.mp3");
            mp3FilePaths.Add(Keys.I, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\�⺻ ��\������.mp3");

            mp3FilePaths.Add(Keys.A, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\�⺻ ��\������.mp3");
            mp3FilePaths.Add(Keys.S, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\�⺻ ��\������.mp3");
            mp3FilePaths.Add(Keys.D, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\�⺻ ��\�̹̹�.mp3");
            mp3FilePaths.Add(Keys.F, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\�⺻ ��\������.mp3");
            mp3FilePaths.Add(Keys.G, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\�⺻ ��\�ּּ�.mp3");
            mp3FilePaths.Add(Keys.H, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\�⺻ ��\����.mp3");
            mp3FilePaths.Add(Keys.J, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\�⺻ ��\�ýý�.mp3");
            mp3FilePaths.Add(Keys.K, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\��������.mp3");

            mp3FilePaths.Add(Keys.Z, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\��������.mp3");
            mp3FilePaths.Add(Keys.X, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\��������.mp3");
            mp3FilePaths.Add(Keys.C, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\�̹̹̹�.mp3");
            mp3FilePaths.Add(Keys.V, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\��������.mp3");
            mp3FilePaths.Add(Keys.B, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\�ּּּ�.mp3");
            mp3FilePaths.Add(Keys.N, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\�����.mp3");
            mp3FilePaths.Add(Keys.M, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ��\�ýýý�.mp3");
            mp3FilePaths.Add(Keys.Oemcomma, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\����������.mp3");

            mp3FilePaths.Add(Keys.NumPad7, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\����������.mp3");
            mp3FilePaths.Add(Keys.NumPad8, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\����������.mp3");
            mp3FilePaths.Add(Keys.NumPad9, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\�̹̹̹̹�.mp3");
            mp3FilePaths.Add(Keys.NumPad4, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\����������.mp3");
            mp3FilePaths.Add(Keys.NumPad5, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\�ּּּּ�.mp3");
            mp3FilePaths.Add(Keys.NumPad6, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\������.mp3");
            mp3FilePaths.Add(Keys.NumPad1, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\�ýýýý�.mp3");
            mp3FilePaths.Add(Keys.NumPad2, @"C:\Users\PC_DSKTOP2\Desktop\student\cs_work\�ǾƳ� �Ҹ�\���� ���� ��\��.mp3");



            // �� Ű�� ���� WaveOutEvent �ν��Ͻ� ����
            // �� �� ����ǰ� �ҷ��� ���� ����
            // waveout �ν��ϴ� outputDevices���⿡ ����
            foreach (var key in mp3FilePaths.Keys)
            {
                outputDevices[key] = new WaveOutEvent();
            }
        }

        private void InitializeKeyMonitoring()
        {
            // Ű �̺�Ʈ �ڵ鷯 ���
            KeyPreview = true;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
        }

        // Ű �ٿ� �̺�Ʈ �ڵ鷯
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // ���� mp3FilePaths ��ųʸ��� �ش� Ű�ڵ尡 �����ϰ� MP3 ���� ��ΰ� ��� ���� ������
            if (mp3FilePaths.ContainsKey(e.KeyCode) && !string.IsNullOrEmpty(mp3FilePaths[e.KeyCode]))
            {
                // �ش� Ű�� keysPressed ����Ʈ�� ���ٸ�
                if (!keysPressed.Contains(e.KeyCode))
                {
                    // keysPressed ����Ʈ�� �ش� Ű�� �߰��ϰ� �ش� Ű�� ���� MP3�� ����ض��
                    keysPressed.Add(e.KeyCode);
                    PlayMP3IfNotPlaying(e.KeyCode);
                }

                // �ش� Ű�� �´� ���� ǥ���ϴ� �κ�
                ShowNoteLabel(e.KeyCode);

            }
            //Ű������ F1�� �������� ��������
            if (e.KeyCode == Keys.F1)
            {
                button1_Click(sender, e);
            }
            // Ű������ f2�� �������� ���� ��ž
            if (e.KeyCode == Keys.F2)
            {
                button2_Click(sender, e);
            }

            // ���е��� + Ű�� ������ ��
            if (e.KeyCode == Keys.Add)
            {
                AdjustVolume(1);
            }
            // ���е��� - Ű�� ������ ��
            if (e.KeyCode == Keys.Subtract)
            {
                AdjustVolume(-1);
            }
            if(e.KeyCode == Keys.Space)
            {

            }
            else if (e.KeyCode != Keys.Add && e.KeyCode != Keys.Subtract)
            {
                // ������ Ű �ܿ� �ٸ� Ű�� ������ �� ������ �����ϱ� ���� �߰�
                // ���� ����
                e.SuppressKeyPress = true;
            }

        }

        // Ű �� �̺�Ʈ �ڵ鷯
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // �ش� Ű�� �� ���·� ����
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
            // ���� outputDevices ��ųʸ��� �־��� Ű�� �ش��ϴ� �ν��Ͻ��� �����Ѵٸ�
            if (outputDevices.ContainsKey(key))
            {
                // ����������� �����ض�
                outputDevices[key]?.Stop();
                outputDevices[key]?.Dispose();
                outputDevices.Remove(key); // �ν��Ͻ� ���� key�����Ϳ� ����
            }
            // if �Ȱɸ��� �ν��Ͻ� ���� �����ϰ� �ش� ���� �ʱ�ȭ ���ϸ� ����
            outputDevices[key] = new WaveOutEvent();
            outputDevices[key].Init(new AudioFileReader(mp3FilePaths[key]));
            outputDevices[key].Play();
        }

        // �̰� Ű�ٿ��̴� �� switch ��� �Ǵ°ǰ�
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

        // �ƹ��͵� ����
        private void HideNoteLabel(Keys key)
        {
            switch (key)
            {
            }
        }

        // MP3 ���� ��� �Լ�
        private void PlayMP3(Keys key, string filePath)
        {
            // NAudio ���̺귯���� ����Ͽ� MP3 ������ ���
            using (var audioFile = new AudioFileReader(filePath))
            {
                var outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int volume = trackBar1.Value; // Ʈ������ ��(����) ��������

            // ��� ��� ���� WaveOutEvent�� ���� ���� ����
            foreach (var outputDevice in outputDevices.Values)
            {
                outputDevice.Volume = volume / 100f; // ���� ���� 0�� 1 ���̷� ����
            }
        }
        private void AdjustVolume(int increment)
        {
            int volume = trackBar1.Value + increment;
            volume = Math.Max(trackBar1.Minimum, Math.Min(trackBar1.Maximum, volume)); // �ּҰ��� �ִ밪 ���̿��� ���� ����
            trackBar1.Value = volume;

            // ��� ��� ���� WaveOutEvent�� ���� ���� ����
            foreach (var outputDevice in outputDevices.Values)
            {
                outputDevice.Volume = volume / 100f; // ���� ���� 0�� 1 ���̷� ����
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\PC_DSKTOP2\Desktop\��������\"; // ������ ���� ���
            string fileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".wav"; // ���� ��¥�� �ð����� ���ϸ� ����
            string filePath = Path.Combine(folderPath, fileName); // ��ü ���� ��� ����

            // ������ �����ϱ� ���� ������ ���� ���� ��� ����
            StopRecording();

            // NAudio ���̺귯���� ����Ͽ� ���� ����
            waveSource = new WaveInEvent();
            waveSource.WaveFormat = new WaveFormat(44100, 1); // 44.1kHz, ��� ����
            waveFile = new WaveFileWriter(filePath, waveSource.WaveFormat);

            waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable); // �����Ͱ� �̿� ������ �� �̺�Ʈ �ڵ鷯 ����
            waveSource.StartRecording(); // ���� ����

            Rc.Visible = true;
            Rc2.Visible = true;
        }

        private void StopRecording()
        {
            // ������ ���� ���̾��ٸ� �����ϰ� �ڿ��� ����
            // ���ϴ� ����
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
            // ������ �����͸� ���Ͽ� ���ϴ�.
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded); // ���� ���
                waveFile.Flush(); // ���ۿ� ���� �����͸� ��ũ�� �Ἥ �����
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
                //�� �ν��Ͻ�
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    // ���ϰ��, ���� ���� ����
                    openFileDialog.InitialDirectory = @"C:\Users\PC_DSKTOP2\Desktop\��������";
                    openFileDialog.Filter = "WAV ���� (*.wav)|*.wav|��� ���� (*.*)|*.*";
                    openFileDialog.FilterIndex = 1; // ���͸� �ϳ��� ���� wav�� �ǰ�
                    openFileDialog.RestoreDirectory = true; // ���� ��ġ ���

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFilePath = openFileDialog.FileName;
                        PlayRecordedAudio(selectedFilePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ���� �� ������ �߻��߽��ϴ�: " + ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // �����϶��� ������� â�̸� + ���� �߻��߾� + Ȯ�� ��ư // ��ư ������
            }
        }

        private void PlayRecordedAudio(string filePath)
        {
            try
            {
                // ����� ���� ��� �ҷ��÷��� �ǽ��Ͻ� ����
                using (var audioFile = new AudioFileReader(filePath))
                {
                    //����� ���� �ǽ��Ͻ� ����
                    using (var outputDevice = new WaveOutEvent())
                    {
                        outputDevice.Init(audioFile); // �� �ʱ�ȭ
                        outputDevice.Play(); // �÷���

                        // ����� ���� ������ ��� 
                        while (outputDevice.PlaybackState == PlaybackState.Playing)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("����� ������ ����ϴ� �� ������ �߻��߽��ϴ�: " + ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void loopstart_Click(object sender, EventArgs e)
        {
            // OpenFileDialog�� �����Ͽ� WAV ������ ������ �� �ֵ��� �մϴ�.
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\PC_DSKTOP2\Desktop\��������";
                openFileDialog.Filter = "WAV ���� (*.wav)|*.wav|��� ���� (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // ����ڰ� ������ �����ϰ� Ȯ�� ��ư�� ������ ��
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // ���õ� ���� ��θ� �����ɴϴ�.
                    string selectedFilePath = openFileDialog.FileName;

                    // ������ ������ SoundPlayer ��ü�� �ִٸ� ����
                    if (soundPlayer != null)
                    {
                        soundPlayer.Dispose();
                    }

                    // SoundPlayer ��ü ���� �� ���õ� ���� ���� �ε�
                    soundPlayer = new SoundPlayer(selectedFilePath);

                    // ���� �ݺ� ����
                    soundPlayer.PlayLooping();
                }
            }
            loop.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (soundPlayer != null)
            {
                // ���� �ݺ� ����� ����ϴ�.
                soundPlayer.Stop();
                // SoundPlayer ��ü�� �����մϴ�.
                soundPlayer.Dispose();

                loop.Visible = false;
            }
        }


    }
}