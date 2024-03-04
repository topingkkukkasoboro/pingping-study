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
            movie1name = new Label();
            movie2time2 = new Label();
            movie2time1 = new Label();
            movie1time1 = new Label();
            movie1time2 = new Label();
            movie2name = new Label();
            movie3name = new Label();
            movie3time2 = new Label();
            movie3time1 = new Label();
            movie1time3 = new Label();
            movie2time3 = new Label();
            movie3time3 = new Label();
            SuspendLayout();
            // 
            // btn_goPre
            // 
            btn_goPre.Font = new Font("맑은 고딕", 25F);
            btn_goPre.Location = new Point(23, 527);
            btn_goPre.Margin = new Padding(2);
            btn_goPre.Name = "btn_goPre";
            btn_goPre.Size = new Size(188, 85);
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
            label1.Location = new Point(173, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
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
            btn_goHome.Location = new Point(239, 527);
            btn_goHome.Margin = new Padding(2);
            btn_goHome.Name = "btn_goHome";
            btn_goHome.Size = new Size(188, 85);
            btn_goHome.TabIndex = 11;
            btn_goHome.Text = "메인 화면";
            btn_goHome.UseVisualStyleBackColor = true;
            btn_goHome.Click += btn_goHome_Click;
            // 
            // movie1name
            // 
            movie1name.AutoSize = true;
            movie1name.Font = new Font("맑은 고딕", 20F);
            movie1name.ForeColor = Color.White;
            movie1name.Location = new Point(23, 270);
            movie1name.Margin = new Padding(2, 0, 2, 0);
            movie1name.Name = "movie1name";
            movie1name.Size = new Size(32, 37);
            movie1name.TabIndex = 14;
            movie1name.Text = "1";
            // 
            // movie2time2
            // 
            movie2time2.AutoSize = true;
            movie2time2.Font = new Font("맑은 고딕", 12F);
            movie2time2.ForeColor = Color.White;
            movie2time2.Location = new Point(199, 361);
            movie2time2.Margin = new Padding(2, 0, 2, 0);
            movie2time2.Name = "movie2time2";
            movie2time2.Size = new Size(50, 21);
            movie2time2.TabIndex = 15;
            movie2time2.Text = "00:00";
            movie2time2.Click += movie2time2_Click;
            // 
            // movie2time1
            // 
            movie2time1.AutoSize = true;
            movie2time1.Font = new Font("맑은 고딕", 12F);
            movie2time1.ForeColor = Color.White;
            movie2time1.Location = new Point(199, 323);
            movie2time1.Margin = new Padding(2, 0, 2, 0);
            movie2time1.Name = "movie2time1";
            movie2time1.Size = new Size(50, 21);
            movie2time1.TabIndex = 16;
            movie2time1.Text = "00:00";
            movie2time1.Click += movie2time1_Click;
            // 
            // movie1time1
            // 
            movie1time1.AutoSize = true;
            movie1time1.Font = new Font("맑은 고딕", 12F);
            movie1time1.ForeColor = Color.White;
            movie1time1.Location = new Point(40, 323);
            movie1time1.Margin = new Padding(2, 0, 2, 0);
            movie1time1.Name = "movie1time1";
            movie1time1.Size = new Size(50, 21);
            movie1time1.TabIndex = 17;
            movie1time1.Text = "00:00";
            movie1time1.Click += movie1time1_Click;
            // 
            // movie1time2
            // 
            movie1time2.AutoSize = true;
            movie1time2.Font = new Font("맑은 고딕", 12F);
            movie1time2.ForeColor = Color.White;
            movie1time2.Location = new Point(40, 361);
            movie1time2.Margin = new Padding(2, 0, 2, 0);
            movie1time2.Name = "movie1time2";
            movie1time2.Size = new Size(50, 21);
            movie1time2.TabIndex = 18;
            movie1time2.Text = "00:00";
            movie1time2.Click += movie1time2_Click;
            // 
            // movie2name
            // 
            movie2name.AutoSize = true;
            movie2name.Font = new Font("맑은 고딕", 20F);
            movie2name.ForeColor = Color.White;
            movie2name.Location = new Point(183, 270);
            movie2name.Margin = new Padding(2, 0, 2, 0);
            movie2name.Name = "movie2name";
            movie2name.Size = new Size(32, 37);
            movie2name.TabIndex = 19;
            movie2name.Text = "2";
            // 
            // movie3name
            // 
            movie3name.AutoSize = true;
            movie3name.Font = new Font("맑은 고딕", 20F);
            movie3name.ForeColor = Color.White;
            movie3name.Location = new Point(337, 270);
            movie3name.Margin = new Padding(2, 0, 2, 0);
            movie3name.Name = "movie3name";
            movie3name.Size = new Size(32, 37);
            movie3name.TabIndex = 20;
            movie3name.Text = "3";
            // 
            // movie3time2
            // 
            movie3time2.AutoSize = true;
            movie3time2.Font = new Font("맑은 고딕", 12F);
            movie3time2.ForeColor = Color.White;
            movie3time2.Location = new Point(351, 361);
            movie3time2.Margin = new Padding(2, 0, 2, 0);
            movie3time2.Name = "movie3time2";
            movie3time2.Size = new Size(50, 21);
            movie3time2.TabIndex = 21;
            movie3time2.Text = "00:00";
            movie3time2.Click += movie3time2_Click;
            // 
            // movie3time1
            // 
            movie3time1.AutoSize = true;
            movie3time1.Font = new Font("맑은 고딕", 12F);
            movie3time1.ForeColor = Color.White;
            movie3time1.Location = new Point(351, 323);
            movie3time1.Margin = new Padding(2, 0, 2, 0);
            movie3time1.Name = "movie3time1";
            movie3time1.Size = new Size(50, 21);
            movie3time1.TabIndex = 22;
            movie3time1.Text = "00:00";
            movie3time1.Click += movie3time1_Click;
            // 
            // movie1time3
            // 
            movie1time3.AutoSize = true;
            movie1time3.Font = new Font("맑은 고딕", 12F);
            movie1time3.ForeColor = Color.White;
            movie1time3.Location = new Point(40, 400);
            movie1time3.Margin = new Padding(2, 0, 2, 0);
            movie1time3.Name = "movie1time3";
            movie1time3.Size = new Size(50, 21);
            movie1time3.TabIndex = 23;
            movie1time3.Text = "00:00";
            movie1time3.Click += movie1time3_Click;
            // 
            // movie2time3
            // 
            movie2time3.AutoSize = true;
            movie2time3.Font = new Font("맑은 고딕", 12F);
            movie2time3.ForeColor = Color.White;
            movie2time3.Location = new Point(199, 400);
            movie2time3.Margin = new Padding(2, 0, 2, 0);
            movie2time3.Name = "movie2time3";
            movie2time3.Size = new Size(50, 21);
            movie2time3.TabIndex = 24;
            movie2time3.Text = "00:00";
            movie2time3.Click += movie2time3_Click;
            // 
            // movie3time3
            // 
            movie3time3.AutoSize = true;
            movie3time3.Font = new Font("맑은 고딕", 12F);
            movie3time3.ForeColor = Color.White;
            movie3time3.Location = new Point(351, 400);
            movie3time3.Margin = new Padding(2, 0, 2, 0);
            movie3time3.Name = "movie3time3";
            movie3time3.Size = new Size(50, 21);
            movie3time3.TabIndex = 25;
            movie3time3.Text = "00:00";
            movie3time3.Click += movie3time3_Click;
            // 
            // Ticketing2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(453, 640);
            Controls.Add(movie3time3);
            Controls.Add(movie2time3);
            Controls.Add(movie1time3);
            Controls.Add(movie3time1);
            Controls.Add(movie3time2);
            Controls.Add(movie3name);
            Controls.Add(movie2name);
            Controls.Add(movie1time2);
            Controls.Add(movie1time1);
            Controls.Add(movie2time1);
            Controls.Add(movie2time2);
            Controls.Add(movie1name);
            Controls.Add(label1);
            Controls.Add(btn_goHome);
            Controls.Add(btn_goPre);
            Margin = new Padding(2);
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
        private Label movie1name;
        private Label movie2time2;
        private Label movie2time1;
        private Label movie1time1;
        private Label movie1time2;
        private Label movie2name;
        private Label movie3name;
        private Label movie3time2;
        private Label movie3time1;
        private Label movie1time3;
        private Label movie2time3;
        private Label movie3time3;
    }
}