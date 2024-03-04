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
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_allMovie = new Button();
            btn_goHome = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 46);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btn_allMovie
            // 
            btn_allMovie.Font = new Font("맑은 고딕", 25F);
            btn_allMovie.Location = new Point(45, 450);
            btn_allMovie.Name = "btn_allMovie";
            btn_allMovie.Size = new Size(495, 195);
            btn_allMovie.TabIndex = 1;
            btn_allMovie.Text = "전체영화보기";
            btn_allMovie.UseVisualStyleBackColor = true;
            btn_allMovie.Click += btn_allMovie_Click;
            // 
            // btn_goHome
            // 
            btn_goHome.Font = new Font("맑은 고딕", 25F);
            btn_goHome.Location = new Point(167, 696);
            btn_goHome.Name = "btn_goHome";
            btn_goHome.Size = new Size(242, 113);
            btn_goHome.TabIndex = 9;
            btn_goHome.Text = "메인 화면";
            btn_goHome.UseVisualStyleBackColor = true;
            btn_goHome.Click += btn_goHome_Click;
            // 
            // Ticketing
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(582, 853);
            Controls.Add(btn_goHome);
            Controls.Add(btn_allMovie);
            Controls.Add(label1);
            Name = "Ticketing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticekting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button btn_allMovie;
        private Button btn_goHome;
    }
}