﻿namespace miniproject.ticketprint
{
    partial class TicketPrintDisplay1_1
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
            btn_goHome = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_goPre = new Button();
            lb_tkNum = new Label();
            tb_tkNum = new TextBox();
            btn_check = new Button();
            SuspendLayout();
            // 
            // btn_goHome
            // 
            btn_goHome.Font = new Font("맑은 고딕", 25F);
            btn_goHome.Location = new Point(309, 664);
            btn_goHome.Name = "btn_goHome";
            btn_goHome.Size = new Size(242, 113);
            btn_goHome.TabIndex = 8;
            btn_goHome.Text = "메인 화면";
            btn_goHome.UseVisualStyleBackColor = true;
            btn_goHome.Click += btn_goHome_Click;
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(91, 74);
            label1.Name = "label1";
            label1.Size = new Size(400, 146);
            label1.TabIndex = 7;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btn_goPre
            // 
            btn_goPre.Font = new Font("맑은 고딕", 25F);
            btn_goPre.Location = new Point(33, 664);
            btn_goPre.Name = "btn_goPre";
            btn_goPre.Size = new Size(242, 113);
            btn_goPre.TabIndex = 9;
            btn_goPre.Text = "이전 화면";
            btn_goPre.UseVisualStyleBackColor = true;
            btn_goPre.Click += btn_goPre_Click;
            // 
            // lb_tkNum
            // 
            lb_tkNum.AutoSize = true;
            lb_tkNum.Font = new Font("맑은 고딕", 30F);
            lb_tkNum.ForeColor = Color.White;
            lb_tkNum.Location = new Point(172, 241);
            lb_tkNum.Name = "lb_tkNum";
            lb_tkNum.Size = new Size(247, 67);
            lb_tkNum.TabIndex = 10;
            lb_tkNum.Text = "예매 번호";
            // 
            // tb_tkNum
            // 
            tb_tkNum.BackColor = Color.MidnightBlue;
            tb_tkNum.Font = new Font("맑은 고딕", 35F);
            tb_tkNum.ForeColor = Color.White;
            tb_tkNum.Location = new Point(42, 363);
            tb_tkNum.Name = "tb_tkNum";
            tb_tkNum.Size = new Size(500, 85);
            tb_tkNum.TabIndex = 11;
            tb_tkNum.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_check
            // 
            btn_check.Font = new Font("맑은 고딕", 25F);
            btn_check.Location = new Point(172, 481);
            btn_check.Name = "btn_check";
            btn_check.Size = new Size(242, 86);
            btn_check.TabIndex = 12;
            btn_check.Text = "조회";
            btn_check.UseVisualStyleBackColor = true;
            btn_check.Click += btn_check_Click;
            // 
            // TicketPrintDisplay1_1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(582, 853);
            Controls.Add(btn_check);
            Controls.Add(tb_tkNum);
            Controls.Add(lb_tkNum);
            Controls.Add(btn_goPre);
            Controls.Add(btn_goHome);
            Controls.Add(label1);
            Name = "TicketPrintDisplay1_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicketPrintDisplay1_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_goHome;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button btn_goPre;
        private Label lb_tkNum;
        private TextBox tb_tkNum;
        private Button btn_check;
    }
}