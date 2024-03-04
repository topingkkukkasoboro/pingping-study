namespace miniproject.ticketing
{
    partial class Ticketing
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
            datetime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_allMovie = new Button();
            btn_goHome = new Button();
            tk1moviename = new Label();
            tk1movieage = new Label();
            tk1moviestory = new Label();
            movie1time1 = new Label();
            movietime2 = new Label();
            movie1time3 = new Label();
            SuspendLayout();
            // 
            // datetime
            // 
            datetime.AutoSize = true;
            datetime.Font = new Font("맑은 고딕", 20F);
            datetime.ForeColor = Color.White;
            datetime.Location = new Point(11, 9);
            datetime.Margin = new Padding(2, 0, 2, 0);
            datetime.Name = "datetime";
            datetime.Size = new Size(124, 37);
            datetime.TabIndex = 0;
            datetime.Text = "datetime";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btn_allMovie
            // 
            btn_allMovie.Font = new Font("맑은 고딕", 25F);
            btn_allMovie.Location = new Point(35, 338);
            btn_allMovie.Margin = new Padding(2);
            btn_allMovie.Name = "btn_allMovie";
            btn_allMovie.Size = new Size(385, 146);
            btn_allMovie.TabIndex = 1;
            btn_allMovie.Text = "전체영화보기";
            btn_allMovie.UseVisualStyleBackColor = true;
            btn_allMovie.Click += btn_allMovie_Click;
            // 
            // btn_goHome
            // 
            btn_goHome.Font = new Font("맑은 고딕", 25F);
            btn_goHome.Location = new Point(130, 522);
            btn_goHome.Margin = new Padding(2);
            btn_goHome.Name = "btn_goHome";
            btn_goHome.Size = new Size(188, 85);
            btn_goHome.TabIndex = 9;
            btn_goHome.Text = "메인 화면";
            btn_goHome.UseVisualStyleBackColor = true;
            btn_goHome.Click += btn_goHome_Click;
            // 
            // tk1moviename
            // 
            tk1moviename.AutoSize = true;
            tk1moviename.Font = new Font("맑은 고딕", 14.25F);
            tk1moviename.ForeColor = Color.White;
            tk1moviename.Location = new Point(170, 68);
            tk1moviename.Margin = new Padding(2, 0, 2, 0);
            tk1moviename.Name = "tk1moviename";
            tk1moviename.Size = new Size(112, 25);
            tk1moviename.TabIndex = 10;
            tk1moviename.Text = "moviename";
            // 
            // tk1movieage
            // 
            tk1movieage.AutoSize = true;
            tk1movieage.Font = new Font("맑은 고딕", 14.25F);
            tk1movieage.ForeColor = Color.White;
            tk1movieage.Location = new Point(170, 109);
            tk1movieage.Margin = new Padding(2, 0, 2, 0);
            tk1movieage.Name = "tk1movieage";
            tk1movieage.Size = new Size(95, 25);
            tk1movieage.TabIndex = 11;
            tk1movieage.Text = "movieage";
            // 
            // tk1moviestory
            // 
            tk1moviestory.AutoSize = true;
            tk1moviestory.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            tk1moviestory.ForeColor = Color.White;
            tk1moviestory.Location = new Point(170, 147);
            tk1moviestory.Margin = new Padding(2, 0, 2, 0);
            tk1moviestory.Name = "tk1moviestory";
            tk1moviestory.Size = new Size(72, 17);
            tk1moviestory.TabIndex = 12;
            tk1moviestory.Text = "moviestory";
            // 
            // movie1time1
            // 
            movie1time1.AutoSize = true;
            movie1time1.Font = new Font("맑은 고딕", 14.25F);
            movie1time1.ForeColor = Color.White;
            movie1time1.Location = new Point(21, 279);
            movie1time1.Margin = new Padding(2, 0, 2, 0);
            movie1time1.Name = "movie1time1";
            movie1time1.Size = new Size(56, 25);
            movie1time1.TabIndex = 13;
            movie1time1.Text = "00:00";
            // 
            // movietime2
            // 
            movietime2.AutoSize = true;
            movietime2.Font = new Font("맑은 고딕", 14.25F);
            movietime2.ForeColor = Color.White;
            movietime2.Location = new Point(108, 279);
            movietime2.Margin = new Padding(2, 0, 2, 0);
            movietime2.Name = "movietime2";
            movietime2.Size = new Size(56, 25);
            movietime2.TabIndex = 14;
            movietime2.Text = "00:00";
            // 
            // movie1time3
            // 
            movie1time3.AutoSize = true;
            movie1time3.Font = new Font("맑은 고딕", 14.25F);
            movie1time3.ForeColor = Color.White;
            movie1time3.Location = new Point(195, 279);
            movie1time3.Margin = new Padding(2, 0, 2, 0);
            movie1time3.Name = "movie1time3";
            movie1time3.Size = new Size(56, 25);
            movie1time3.TabIndex = 15;
            movie1time3.Text = "00:00";
            // 
            // Ticketing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(453, 640);
            Controls.Add(movie1time3);
            Controls.Add(movietime2);
            Controls.Add(movie1time1);
            Controls.Add(tk1moviestory);
            Controls.Add(tk1movieage);
            Controls.Add(tk1moviename);
            Controls.Add(btn_goHome);
            Controls.Add(btn_allMovie);
            Controls.Add(datetime);
            Margin = new Padding(2);
            Name = "Ticketing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticekting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label datetime;
        private System.Windows.Forms.Timer timer1;
        private Button btn_allMovie;
        private Button btn_goHome;
        private Label tk1moviename;
        private Label tk1movieage;
        private Label tk1moviestory;
        private Label movie1time1;
        private Label movietime2;
        private Label movie1time3;
    }
}