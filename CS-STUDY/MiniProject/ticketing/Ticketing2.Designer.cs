namespace miniproject.ticketing
{
    partial class Ticketing2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btn_goPre = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_goHome = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_goPre
            // 
            btn_goPre.Font = new Font("맑은 고딕", 25F);
            btn_goPre.Location = new Point(29, 703);
            btn_goPre.Name = "btn_goPre";
            btn_goPre.Size = new Size(242, 113);
            btn_goPre.TabIndex = 11;
            btn_goPre.Text = "이전 화면";
            btn_goPre.UseVisualStyleBackColor = true;
            btn_goPre.Click += btn_goPre_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 46);
            label1.TabIndex = 12;
            label1.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btn_goHome
            // 
            btn_goHome.Font = new Font("맑은 고딕", 25F);
            btn_goHome.Location = new Point(307, 703);
            btn_goHome.Name = "btn_goHome";
            btn_goHome.Size = new Size(242, 113);
            btn_goHome.TabIndex = 11;
            btn_goHome.Text = "메인 화면";
            btn_goHome.UseVisualStyleBackColor = true;
            btn_goHome.Click += btn_goHome_Click;
            // 
            // button1
            // 
            button1.Location = new Point(222, 541);
            button1.Name = "button1";
            button1.Size = new Size(155, 88);
            button1.TabIndex = 13;
            button1.Text = "임시버튼\r\n다음화면";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Ticketing2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(582, 853);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btn_goHome);
            Controls.Add(btn_goPre);
            Name = "Ticketing2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticketing2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_goPre;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button btn_goHome;
        private Button button1;
    }
}