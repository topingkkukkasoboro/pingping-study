namespace miniproject.ticketing
{
    partial class Ticketing3
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
            btn_goPre = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_goHome = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lb_index1 = new Label();
            btn_index1M = new Button();
            btn_index1P = new Button();
            btn_index2P = new Button();
            btn_index2M = new Button();
            lb_index2 = new Label();
            btn_index3P = new Button();
            btn_index3M = new Button();
            lb_index3 = new Label();
            btn_index4P = new Button();
            btn_index4M = new Button();
            lb_index4 = new Label();
            btn_seatChoice = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(97, 23);
            label1.Name = "label1";
            label1.Size = new Size(111, 46);
            label1.TabIndex = 15;
            label1.Text = "label1";
            // 
            // btn_goPre
            // 
            btn_goPre.Font = new Font("맑은 고딕", 25F);
            btn_goPre.Location = new Point(31, 717);
            btn_goPre.Name = "btn_goPre";
            btn_goPre.Size = new Size(242, 113);
            btn_goPre.TabIndex = 13;
            btn_goPre.Text = "이전 화면";
            btn_goPre.UseVisualStyleBackColor = true;
            btn_goPre.Click += btn_goPre_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btn_goHome
            // 
            btn_goHome.Font = new Font("맑은 고딕", 25F);
            btn_goHome.Location = new Point(309, 717);
            btn_goHome.Name = "btn_goHome";
            btn_goHome.Size = new Size(242, 113);
            btn_goHome.TabIndex = 14;
            btn_goHome.Text = "메인 화면";
            btn_goHome.UseVisualStyleBackColor = true;
            btn_goHome.Click += btn_goHome_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(85, 189);
            label2.Name = "label2";
            label2.Size = new Size(109, 57);
            label2.TabIndex = 16;
            label2.Text = "일반";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 278);
            label3.Name = "label3";
            label3.Size = new Size(151, 57);
            label3.TabIndex = 16;
            label3.Text = "청소년";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(43, 367);
            label4.Name = "label4";
            label4.Size = new Size(151, 57);
            label4.TabIndex = 16;
            label4.Text = "장애인";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(43, 456);
            label5.Name = "label5";
            label5.Size = new Size(151, 57);
            label5.TabIndex = 16;
            label5.Text = "노약자";
            // 
            // lb_index1
            // 
            lb_index1.BackColor = Color.White;
            lb_index1.Font = new Font("맑은 고딕", 25F);
            lb_index1.Location = new Point(341, 189);
            lb_index1.Name = "lb_index1";
            lb_index1.Size = new Size(71, 57);
            lb_index1.TabIndex = 17;
            lb_index1.Text = "10";
            lb_index1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_index1M
            // 
            btn_index1M.BackColor = Color.White;
            btn_index1M.FlatStyle = FlatStyle.Flat;
            btn_index1M.Font = new Font("돋움", 25F);
            btn_index1M.Location = new Point(251, 189);
            btn_index1M.Name = "btn_index1M";
            btn_index1M.Size = new Size(71, 57);
            btn_index1M.TabIndex = 18;
            btn_index1M.Text = "-";
            btn_index1M.UseVisualStyleBackColor = false;
            btn_index1M.Click += btn_index1M_Click;
            // 
            // btn_index1P
            // 
            btn_index1P.BackColor = Color.White;
            btn_index1P.FlatStyle = FlatStyle.Flat;
            btn_index1P.Font = new Font("돋움", 25F);
            btn_index1P.Location = new Point(432, 189);
            btn_index1P.Name = "btn_index1P";
            btn_index1P.Size = new Size(71, 57);
            btn_index1P.TabIndex = 18;
            btn_index1P.Text = "+";
            btn_index1P.UseVisualStyleBackColor = false;
            btn_index1P.Click += btn_index1P_Click;
            // 
            // btn_index2P
            // 
            btn_index2P.BackColor = Color.White;
            btn_index2P.FlatStyle = FlatStyle.Flat;
            btn_index2P.Font = new Font("돋움", 25F);
            btn_index2P.Location = new Point(432, 278);
            btn_index2P.Name = "btn_index2P";
            btn_index2P.Size = new Size(71, 57);
            btn_index2P.TabIndex = 21;
            btn_index2P.Text = "+";
            btn_index2P.UseVisualStyleBackColor = false;
            btn_index2P.Click += btn_index2P_Click;
            // 
            // btn_index2M
            // 
            btn_index2M.BackColor = Color.White;
            btn_index2M.FlatAppearance.BorderColor = Color.White;
            btn_index2M.FlatStyle = FlatStyle.Flat;
            btn_index2M.Font = new Font("돋움", 25F);
            btn_index2M.Location = new Point(251, 278);
            btn_index2M.Name = "btn_index2M";
            btn_index2M.Size = new Size(71, 57);
            btn_index2M.TabIndex = 20;
            btn_index2M.Text = "-";
            btn_index2M.UseVisualStyleBackColor = false;
            btn_index2M.Click += btn_index2M_Click;
            // 
            // lb_index2
            // 
            lb_index2.BackColor = Color.White;
            lb_index2.Font = new Font("맑은 고딕", 25F);
            lb_index2.Location = new Point(341, 278);
            lb_index2.Name = "lb_index2";
            lb_index2.Size = new Size(71, 57);
            lb_index2.TabIndex = 19;
            lb_index2.Text = "10";
            lb_index2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_index3P
            // 
            btn_index3P.BackColor = Color.White;
            btn_index3P.FlatStyle = FlatStyle.Flat;
            btn_index3P.Font = new Font("돋움", 25F);
            btn_index3P.Location = new Point(432, 367);
            btn_index3P.Name = "btn_index3P";
            btn_index3P.Size = new Size(71, 57);
            btn_index3P.TabIndex = 24;
            btn_index3P.Text = "+";
            btn_index3P.UseVisualStyleBackColor = false;
            btn_index3P.Click += btn_index3P_Click;
            // 
            // btn_index3M
            // 
            btn_index3M.BackColor = Color.White;
            btn_index3M.FlatAppearance.BorderColor = Color.White;
            btn_index3M.FlatStyle = FlatStyle.Flat;
            btn_index3M.Font = new Font("돋움", 25F);
            btn_index3M.Location = new Point(251, 367);
            btn_index3M.Name = "btn_index3M";
            btn_index3M.Size = new Size(71, 57);
            btn_index3M.TabIndex = 23;
            btn_index3M.Text = "-";
            btn_index3M.UseVisualStyleBackColor = false;
            btn_index3M.Click += btn_index3M_Click;
            // 
            // lb_index3
            // 
            lb_index3.BackColor = Color.White;
            lb_index3.Font = new Font("맑은 고딕", 25F);
            lb_index3.Location = new Point(341, 367);
            lb_index3.Name = "lb_index3";
            lb_index3.Size = new Size(71, 57);
            lb_index3.TabIndex = 22;
            lb_index3.Text = "10";
            lb_index3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_index4P
            // 
            btn_index4P.BackColor = Color.White;
            btn_index4P.FlatStyle = FlatStyle.Flat;
            btn_index4P.Font = new Font("돋움", 25F);
            btn_index4P.Location = new Point(432, 456);
            btn_index4P.Name = "btn_index4P";
            btn_index4P.Size = new Size(71, 57);
            btn_index4P.TabIndex = 27;
            btn_index4P.Text = "+";
            btn_index4P.UseVisualStyleBackColor = false;
            btn_index4P.Click += btn_index4P_Click;
            // 
            // btn_index4M
            // 
            btn_index4M.BackColor = Color.White;
            btn_index4M.FlatAppearance.BorderColor = Color.White;
            btn_index4M.FlatStyle = FlatStyle.Flat;
            btn_index4M.Font = new Font("돋움", 25F);
            btn_index4M.Location = new Point(251, 456);
            btn_index4M.Name = "btn_index4M";
            btn_index4M.Size = new Size(71, 57);
            btn_index4M.TabIndex = 26;
            btn_index4M.Text = "-";
            btn_index4M.UseVisualStyleBackColor = false;
            btn_index4M.Click += btn_index4M_Click;
            // 
            // lb_index4
            // 
            lb_index4.BackColor = Color.White;
            lb_index4.Font = new Font("맑은 고딕", 25F);
            lb_index4.Location = new Point(341, 456);
            lb_index4.Name = "lb_index4";
            lb_index4.Size = new Size(71, 57);
            lb_index4.TabIndex = 25;
            lb_index4.Text = "10";
            lb_index4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_seatChoice
            // 
            btn_seatChoice.Font = new Font("맑은 고딕", 25F);
            btn_seatChoice.Location = new Point(170, 556);
            btn_seatChoice.Name = "btn_seatChoice";
            btn_seatChoice.Size = new Size(242, 113);
            btn_seatChoice.TabIndex = 28;
            btn_seatChoice.Text = "좌석선택";
            btn_seatChoice.UseVisualStyleBackColor = true;
            btn_seatChoice.Click += btn_seatChoice_Click;
            // 
            // Ticketing3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(582, 853);
            Controls.Add(btn_seatChoice);
            Controls.Add(btn_index4P);
            Controls.Add(btn_index4M);
            Controls.Add(lb_index4);
            Controls.Add(btn_index3P);
            Controls.Add(btn_index3M);
            Controls.Add(lb_index3);
            Controls.Add(btn_index2P);
            Controls.Add(btn_index2M);
            Controls.Add(lb_index2);
            Controls.Add(btn_index1P);
            Controls.Add(btn_index1M);
            Controls.Add(lb_index1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_goPre);
            Controls.Add(btn_goHome);
            Name = "Ticketing3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticketing3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_goPre;
        private System.Windows.Forms.Timer timer1;
        private Button btn_goHome;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lb_index1;
        private Button btn_index1M;
        private Button btn_index1P;
        private Button btn_index2P;
        private Button btn_index2M;
        private Label lb_index2;
        private Button btn_index3P;
        private Button btn_index3M;
        private Label lb_index3;
        private Button btn_index4P;
        private Button btn_index4M;
        private Label lb_index4;
        private Button btn_seatChoice;
    }
}